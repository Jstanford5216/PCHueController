using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using Q42.HueApi.Models;
using Q42.HueApi.Models.Groups;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.OriginalWithModel;
using System.Threading;

namespace PCHueController
{
    public partial class PCHueController : Form
    {
        public static string ip { get; set; } //Users inputted ip.

        static ILocalHueClient client = null; //Initialise client.

        static IEnumerable<Light> lights = null; //Initialise collection of lights.

        public List<string> selectedLights = new List<string>(); //Initialise collection for currently selected lights.

        static IEnumerable<Scene> scenes = null; //Initialise collection for scenes.

        static bool discoToggle = false; //Initialise disco toggle bool.

        public PCHueController()
        {
            InitializeComponent();
            GetBridgeIps();
        }

        public void clientConnection()
        {
            if (ip != null) //If the user has selected a hub.
            {
                if (client == null) //If the user has selected a hub but the connection hasnt been attempted yet then make one.
                {
                    client = new LocalHueClient(ip);
                }

                else if (client.CheckConnection().Result == false) //If the connection has been made already check to ensure the user is still connected.
                {
                    txtResults.BackColor = Color.Red; //Show error.
                    txtResults.Show();
                    txtResults.Text = "Connection failed, please make sure you are connected to the internet and have pressed connect.";
                }
            }
            else //If their is no hubs available then display an error. 
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "No hubs found, please try again.";
            }
        }

        public async Task GetBridgeIps()
        {
            lstHubs.Items.Clear();
            
            IBridgeLocator locator = new HttpBridgeLocator();
            IEnumerable<LocatedBridge> bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5)); //Scan for bridges, should find them within 5 seconds.

            foreach (var item in bridgeIPs)
            {
                string listFormat = string.Format("{0} ({1})", item.BridgeId, item.IpAddress); //Add all bridges id and ip to the listbox and 
                lstHubs.Items.Add(listFormat);                                                 //default selected to item 0.
            }

            lstHubs.SelectedIndex = 0;
        }

        private void lstHubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ip = lstHubs.SelectedItem.ToString().Split('(')[1].Trim(')'); //Set the ip value to the newly selected hub. 
            }

            catch
            {
                //If null do nothing as it will be handled by clientConnection method.
            }
        }

        private void btnNewColour_Click(object sender, EventArgs e)
        {
            try
            {
                bool c = client.CheckConnection().Result; //Make sure the connection is active before allowing button to load colour picker.

                LoadColorPick();
            }

            catch 
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed, please make sure you are connected to the internet and have pressed connect.";
            }
        }


        public async Task commandSender(LightCommand command)
        {
            await client.SendCommandAsync(command, selectedLights); //Sends command to the current lights.
        }

        public async Task sceneSender(string sceneName)
        {
            string id = "";

            foreach (var item in scenes)
            {
                if (item.Name == sceneName) //Find selected scene.
                {
                    id = item.Id;
                }
            }

            string selectedGroup = "";

            List <Group> g = new List<Group>();

            foreach (Group f in client.GetGroupsAsync().Result)
            {
                g.Add(f);
            }

            Light l = client.GetLightAsync(selectedLights[0]).Result;

            foreach (Group t in g)
            {
                List<string> s = t.Lights;

                if (s.Contains(selectedLights[0]))
                {
                    selectedGroup = t.Id;
                }
            }

            await client.RecallSceneAsync(id,selectedGroup); //Send command to change the scene.
        }

        public async Task RegisterTask()
        {
            if (txtAppName.Text != "" && txtAppName.Text != null && txtAppName.Text != "" && txtAppName.Text != null) //Make sure app & device name are not blank.
            {
                try
                {
                    var appKey = await client.RegisterAsync(txtAppName.Text, txtDeviceName.Text); //Attempt to register and show success message.
                    txtResults.Show();
                    txtResults.Text = "App registered successfully." + Environment.NewLine + appKey;
                    txtKey.Text = appKey;
                    txtResults.BackColor = Color.Green;
                }

                catch //If failed to register show error message.
                {
                    txtResults.BackColor = Color.Red;
                    txtResults.Show();
                    txtResults.Text = "App not registered, make sure button was pressed within 2 mins before registering.";
                }
            }

            else //If app or device names are blank show error.  
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "App & Device names must not be blank.";
            }
        }
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterTask();
        }

        public void LoadColorPick()
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = pnlCurrentSwatch.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                clientConnection(); //Before confirming colour make sure that the connection is still active or reconnect.

                if (client != null)
                {
                    discoToggle = false; //Disable disco when selecting new colour.

                    pnlCurrentSwatch.BackColor = MyDialog.Color; //Change panel colour to the selected colour.

                    RGBColor convert = new RGBColor(MyDialog.Color.R, MyDialog.Color.G, MyDialog.Color.B); //Get individual colors to create a compatible colour.

                    LightCommand command = new LightCommand(); //Create new command.
                    
                    command.Effect = Effect.None; //Disable any effects such as colour loop.

                    commandSender(command);  

                    command.Effect = null; //No need to disable the effect twice.

                    command.TurnOn().SetColor(convert); //Set the colour.

                    commandSender(command);
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtKey.Text != "" && txtKey.Text != null) //If key is not blank carry on.
            {
                clientConnection();

                if (client != null)
                {
                    client.Initialize(txtKey.Text); //Try to connect to the selected hub using given key.

                    if (client.CheckConnection().Result == true) //If client connection is successfully show a message to confirm this.
                    {
                        txtResults.Show();
                        txtResults.Text = "Connected successfully."; 
                        txtResults.BackColor = Color.Green;

                        lights = client.GetLightsAsync().Result; //Get lights.

                        lstLights.Items.Clear(); //Clear light listbox.

                        selectedLights.Clear(); //Clear old selectedLights.

                        lstLights.Items.Add("All"); //Add option to select all lights.

                        int lightsOn = 0; //Set the amount of lights on to 0;

                        Color col = new Color(); 

                        foreach (var item in lights)
                        {
                            lstLights.Items.Add(item.Name); //Add lights to listbox and obtain 

                            string id = item.ModelId;

                            col = ColorTranslator.FromHtml("#" + item.State.ToHex(id)); //Get the current color of the light or last light if all is selected.

                            if (item.State.On == true)
                            {
                                lightsOn++; //Track the amount of lights that are on. 
                            }
                        }

                        if (lightsOn < 1) //If no lights are on then set the switch to the off position.
                        {
                            btnOnOff.BackgroundImage = Properties.Resources.Off;
                        }

                        else //if at least one light is on then set switch to on.
                        {
                            btnOnOff.BackgroundImage = Properties.Resources.On;
                        }

                        lstLights.SelectedIndex = 0; //Set default selection to all.

                        pnlCurrentSwatch.BackColor = col; //Set current colour swatch to the current colour.

                        scenes = null; //Reset scene collection.

                        lstScenes.Items.Clear(); //Clear scenes listbox.

                        lstScenes.Items.Add("Color loop"); //Add additional scenes.

                        scenes = client.GetScenesAsync().Result.Where(s => !s.Name.Contains("Scene")); //Only show custom scenes. 

                        foreach (var item2 in scenes)
                        {
                            lstScenes.Items.Add(item2.Name); //Add the scenes to the listbox.
                        }
                    }

                    else
                    {
                        txtResults.BackColor = Color.Red;
                        txtResults.Show();
                        txtResults.Text = "Connection failed ensure you have choosen the right device and that your key is correct.";
                    }
                }

                else
                {
                    txtResults.BackColor = Color.Red;
                    txtResults.Show();
                    txtResults.Text = "Connection failed ensure you have internet connection.";
                }
            }

            else //If key is blank display an error message.
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Key cannot be blank.";
            }
        }

        private void lstLights_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = null;  

            try
            {
                selectedIndex = lstLights.SelectedItem.ToString(); //Get the selected light.
                lights = client.GetLightsAsync().Result; //Get up to date lights in case of state being out of date.
            }
            catch
            {

            }

            selectedLights.Clear(); //Clear the currently selected lights.

            int lightsOn = 0;

            foreach (var item in lights)
            {
                if (selectedIndex == "All") //Set new selected lights. If selected is all and light is on then check both lights.
                {
                    if(item.State.On == true)
                    {
                        lightsOn++;
                    }
                    
                    selectedLights.Add(item.Id);
                }

                else if (item.Name == selectedIndex) //If light matches selected then there will only be one light so check the state and add to counter. 
                {
                    if(item.State.On == true)
                    {
                        lightsOn++;
                    }

                    selectedLights.Add(item.Id);
                }
            }

            if(lightsOn > 0) 
            {
                btnOnOff.BackgroundImage = Properties.Resources.On;
            }

            else
            {
                btnOnOff.BackgroundImage = Properties.Resources.Off;
            }
        }

        private void btnRefreshScene_Click(object sender, EventArgs e)
        {
            try
            {
                bool c = client.CheckConnection().Result;

                scenes = null;

                lstScenes.Items.Clear();

                lstScenes.Items.Add("Color loop");

                scenes = client.GetScenesAsync().Result.Where(s => !s.Name.Contains("Scene"));

                foreach (var item2 in scenes)
                {
                    lstScenes.Items.Add(item2.Name);
                }
            }

            catch
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed, please make sure you are connected to the internet and have pressed connect.";
            }
        }

        private void lstScenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sceneIndex = ""; //Reset scene index.

            try
            {
                sceneIndex = lstScenes.SelectedItem.ToString(); //Make sure selected scene isn't blank.

                if (sceneIndex == "Color loop")
                {
                    discoToggle = false;

                    var command = new LightCommand();

                    command.TurnOn().Effect = Effect.ColorLoop; //Set scene to color loop.

                    commandSender(command);

                    btnOnOff.BackgroundImage = Properties.Resources.On; 
                }

                else //If not colour loop or disco then it is a normal theme so disable disco and send the scene to the method.
                {
                    discoToggle = false;
                    sceneSender(sceneIndex); 
                }
            }

            catch
            {

            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            try
            {
                lights = client.GetLightsAsync().Result; //Update light states.

                int lightsOn = 0;
                bool isAll = false;

                foreach (var item in lights)
                {
                    if (lstLights.SelectedItem.ToString() == "All")
                    {
                        if (item.State.On == true)
                        {
                            lightsOn++;
                        }

                        isAll = true;
                    }

                    else if (item.Name == lstLights.SelectedItem.ToString())
                    {
                        if (item.State.On == true)
                        {
                            var command = new LightCommand();
                            command.TurnOff();
                            commandSender(command);
                            btnOnOff.BackgroundImage = Properties.Resources.Off;
                        }

                        else
                        {
                            var command = new LightCommand();
                            command.TurnOn();
                            commandSender(command);
                            btnOnOff.BackgroundImage = Properties.Resources.On;
                        }
                    }
                }

                if (lightsOn > 0 && isAll == true) //These only run when all lights are selected.
                {
                    discoToggle = false;
                    var command = new LightCommand(); 
                    command.TurnOff();
                    commandSender(command);
                    btnOnOff.BackgroundImage = Properties.Resources.Off;
                }

                else if (lightsOn == 0 && isAll == true)
                {
                    var command = new LightCommand();
                    command.TurnOn();
                    commandSender(command);
                    btnOnOff.BackgroundImage = Properties.Resources.On;
                }
            }

            catch
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed, please make sure you are connected to the internet and have pressed connect.";
            }
        }

        public async Task discoThread()
        {
            while (discoToggle == true) //Loop until different colour, scene selected or lights turned off.
            {
                List<RGBColor> colorList = new List<RGBColor>(); //Initalise colour collection.

                Random rnd = new Random();

                foreach (var item in lights)
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); //Get new random colour.

                    RGBColor convert = new RGBColor(randomColor.R, randomColor.G, randomColor.B); //Convert colour to usable colour.

                    pnlCurrentSwatch.BackColor = randomColor; //Set current swatch colour to the last random colour.

                    colorList.Add(convert); //Add colours to list.
                }

                for (int i = 0; i < lights.Count(); i++) //For each light grab relevant color from the list and send it to one light only. 
                {
                    var command = new LightCommand();

                    command.TurnOn().SetColor(colorList[i]);

                    await client.SendCommandAsync(command, new List<string> { (i + 1).ToString() });
                }

                Thread.Sleep(500); //Wait after changing all lights before changing again.
            }
        }

        private void btnRefreshHubs_Click(object sender, EventArgs e)
        {
            GetBridgeIps();
        }

        private void btnRefreshLights_Click(object sender, EventArgs e)
        {
           try
           {
                lights = client.GetLightsAsync().Result;

                lstLights.Items.Clear();

                selectedLights.Clear();

                lstLights.Items.Add("All");

                Color col = new Color();

                int lightsOn = 0;

                foreach (var item in lights)
                {
                    lstLights.Items.Add(item.Name);

                    string id = item.ModelId;
                    col = ColorTranslator.FromHtml("#" + item.State.ToHex(id));

                    if (item.State.On == true)
                    {
                        lightsOn++;
                    }
                }

                if (lightsOn < 1)
                {
                    btnOnOff.BackgroundImage = Properties.Resources.Off;
                }

                else
                {
                    btnOnOff.BackgroundImage = Properties.Resources.On;
                }

                lstLights.SelectedIndex = 0;
            }

            catch
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed, please make sure you are connected to the internet and have pressed connect.";
            }
        }

        private void btnDisco_Click(object sender, EventArgs e)
        {
            if (discoToggle == false) //If disco hasn't started yet then turn it on
            {
                discoToggle = true;
                discoThread(); //Begin disco threads.

                btnOnOff.BackgroundImage = Properties.Resources.On;
            }
            else //If disco is on then turn it off
            { 
                discoToggle = false;

                btnOnOff.BackgroundImage = Properties.Resources.Off;
            } 
        }
    }
}

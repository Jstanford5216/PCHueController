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
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.OriginalWithModel;

namespace PCHueController
{
    public partial class PCHueController : Form
    {
        public static string ip { get; set; }

        static ILocalHueClient client = null;

        static IEnumerable<Light> lights = null;

        public List<string> selectedLights = new List<string>();

        static IEnumerable<Scene> scenes = null;

        static bool discoToggle = false; 

    public PCHueController()
        {
            InitializeComponent();
            GetBridgeIps();
        }

        public void clientConnection()
        {
            if (ip != null)
            {
                if (client == null)
                {
                    client = new LocalHueClient(ip);
                }

                else if (client.CheckConnection().Result == false)
                {
                    txtResults.BackColor = Color.Red;
                    txtResults.Show();
                    txtResults.Text = "Connection failed, please make sure you are connected to the internet and have pressed connect.";
                }
            }
            else
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed, please make sure you are connected to the internet and have pressed connect.";
            }
        }

        public async Task GetBridgeIps()
        {
            IBridgeLocator locator = new HttpBridgeLocator();
            IEnumerable<LocatedBridge> bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));

            foreach (var item in bridgeIPs)
            {
                string listFormat = string.Format("{0} ({1})", item.BridgeId, item.IpAddress);
                lstHubs.Items.Add(listFormat);
            }

            lstHubs.SelectedIndex = 0;
        }

        private void lstHubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ip = lstHubs.SelectedItem.ToString().Split('(')[1].Trim(')');
            }

            catch
            {

            }
        }

        private void btnNewColour_Click(object sender, EventArgs e)
        {
            try
            {
                bool c = client.CheckConnection().Result;

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
            await client.SendCommandAsync(command, selectedLights);
        }

        public async Task sceneSender(string sceneName)
        {

            string id = "";

            foreach (var item in scenes)
            {
                if (item.Name == sceneName)
                {
                    id = item.Id;
                }
            }

            await client.RecallSceneAsync(id,"0");
        }

        public async Task RegisterTask()
        {
            clientConnection();

            if (client != null)
            {
                try
                {
                    var appKey = await client.RegisterAsync("PCHueController", "***REMOVED***");
                    txtResults.Show();
                    txtResults.Text = "App registered successfully." + Environment.NewLine + appKey;
                    txtInputKey.Text = appKey;
                    txtResults.BackColor = Color.Green;
                }
                catch
                {
                    txtResults.BackColor = Color.Red;
                    txtResults.Show();
                    txtResults.Text = "App not registered, make sure button was pressed within 2 mins before registering.";
                }
            }
            else
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed ensure you have internet connection.";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                bool c = client.CheckConnection().Result;

                RegisterTask();
            }

            catch
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed, please make sure you are connected to the internet and have pressed connect.";
            }
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
                clientConnection();

                if (client != null)
                {                      
                    pnlCurrentSwatch.BackColor = MyDialog.Color;

                    RGBColor convert = new RGBColor(MyDialog.Color.R, MyDialog.Color.G, MyDialog.Color.B);

                    LightCommand command = new LightCommand();
                    
                    command.Effect = Effect.None;

                    commandSender(command);

                    command.Effect = null;

                    command.TurnOn().SetColor(convert);

                    commandSender(command);
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            clientConnection();

            if (client != null)
            {
                try
                {
                    client.Initialize(txtInputKey.Text);

                    if (client.CheckConnection().Result == true)
                    {
                        txtResults.Show();
                        txtResults.Text = "Connected successfully.";
                        txtResults.BackColor = Color.Green;

                        try
                        {
                            lights = client.GetLightsAsync().Result;

                            Color col = new Color();

                            lstLights.Items.Clear();
                            
                            selectedLights.Clear();

                            scenes = null;

                            lstScenes.Items.Clear();

                            lstLights.Items.Add("All");

                            int lightsOn = 0;

                            foreach (var item in lights)
                            {
                                lstLights.Items.Add(item.Name);

                                string id= item.ModelId;
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

                            pnlCurrentSwatch.BackColor = col;

                            lstScenes.Items.Add("Color loop");
                            lstScenes.Items.Add("Disco");

                            scenes = client.GetScenesAsync().Result.Where(s => !s.Name.Contains("Scene"));

                            foreach (var item2 in scenes)
                            {
                                lstScenes.Items.Add(item2.Name);
                            }
                        }
                        catch
                        {

                        }
                    }

                    else
                    {
                        txtResults.BackColor = Color.Red;
                        txtResults.Show();
                        txtResults.Text = "Connection failed ensure you have choosen the right device and that your key is correct.";
                    }
                }

                catch
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

        private void lstLights_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = null;

            try
            {
                selectedIndex = lstLights.SelectedItem.ToString();
                lights = client.GetLightsAsync().Result;
            }
            catch
            {

            }

            selectedLights.Clear();

            int lightsOn = 0;

            foreach (var item in lights)
            {
                if (selectedIndex == "All")
                {
                    selectedLights.Add(item.Id);

                    if(item.State.On == true)
                    {
                        lightsOn++;
                    }
                }

                else if (item.Name == selectedIndex)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                bool c = client.CheckConnection().Result;

                scenes = null;

                lstScenes.Items.Clear();

                lstScenes.Items.Add("Color loop");
                lstScenes.Items.Add("Disco");

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
            string sceneIndex = "";

            try
            {
                sceneIndex = lstScenes.SelectedItem.ToString();

                if (sceneIndex == "Color loop")
                {
                    discoToggle = false;
                    var command = new LightCommand();
                    command.TurnOn().Effect = Effect.ColorLoop;
                    command.TransitionTime = new TimeSpan(0,0,0,1);
                    commandSender(command);
                    btnOnOff.BackgroundImage = Properties.Resources.On;
                }

                else if (sceneIndex == "Disco")
                {
                    btnOnOff.BackgroundImage = Properties.Resources.On;
                    discoToggle = true;
                    discoThread();
                }

                else
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
                lights = client.GetLightsAsync().Result;

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

                if (lightsOn > 0 && isAll == true)
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
            while (discoToggle == true)
            {
                List<RGBColor> colorList = new List<RGBColor>();

                Random rnd = new Random();

                foreach (var item in lights)
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                    RGBColor convert = new RGBColor(randomColor.R, randomColor.G, randomColor.B);

                    pnlCurrentSwatch.BackColor = randomColor;

                    colorList.Add(convert);
                }

                await discoThread2(colorList);
            }
        }

        public async Task discoThread2(List<RGBColor> colorList)
        {
            for (int i = 0; i < lights.Count(); i++)
            {
                var command = new LightCommand();

                command.TurnOn().SetColor(colorList[i]);

                await client.SendCommandAsync(command, new List<string> { (i + 1).ToString() });
            }
        }
    }
}

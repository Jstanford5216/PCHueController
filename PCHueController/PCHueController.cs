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
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.OriginalWithModel;

namespace PCHueController
{
    public partial class PCHueController : Form
    {
        public static string ip { get; set; }

        static ILocalHueClient client = null;

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
                    txtResults.Text = "Connection failed ensure you have internet connection.";
                }
            }
            else
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed ensure you have internet connection.";
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
            LoadColorPick();
        }


        public async Task commandSender(LightCommand command)
        {
            await client.SendCommandAsync(command);
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
                    txtResults.BackColor = Color.Green;
                    client.Initialize(appKey);
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
            RegisterTask();
        }

        public void LoadColorPick()
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
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

                    command.TurnOn().SetColor(convert).Brightness = MyDialog.Color.A;

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
                            IEnumerable<Light> lights = client.GetLightsAsync().Result;

                            Color col = new Color();

                            foreach (var item in lights)
                            {
                                string id= item.ModelId;
                                col = ColorTranslator.FromHtml("#" + item.State.ToHex(id));
                            }

                            pnlCurrentSwatch.BackColor = col;
                        }
                        catch
                        {

                        }
                    }

                    else
                    {
                        txtResults.BackColor = Color.Red;
                        txtResults.Show();
                        txtResults.Text = "Connection failed ensure you have choosen a device and that your key is correct.";
                    }
                }

                catch
                {
                    txtResults.BackColor = Color.Red;
                    txtResults.Show();
                    txtResults.Text = "Connection failed ensure you have choosen a device and that your key is correct.";
                }
            }
            else
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed ensure you have internet connection.";
            }
        }

        private void btnColorloop_Click(object sender, EventArgs e)
        {
            clientConnection();

            if (client != null)
            {
                var command = new LightCommand();
                command.TurnOn().Effect = Effect.ColorLoop;
                commandSender(command);
            }

            else
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed ensure you have internet connection.";
            }
        }

        private void btnOceanM_Click(object sender, EventArgs e)
        {
            clientConnection();

            if (client != null)
            {
                var command = new SceneCommand();
                command.Scene = "Ocean Mist";
                sceneSender(command);
            }

            else
            {
                txtResults.BackColor = Color.Red;
                txtResults.Show();
                txtResults.Text = "Connection failed ensure you have internet connection.";
            }
        }
    }
}

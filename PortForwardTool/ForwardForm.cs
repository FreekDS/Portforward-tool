using Open.Nat;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortForwardTool
{
    public partial class MainWindow : Form
    {

        private string _forwardType = "Not able to forward!";
        private NatDevice _device = null;
        private readonly FirewallDevice _firewall = new FirewallDevice();

        private bool ForwardEnabled { get => _forwardType != "Not able to forward!" && portInput.Value > 0;  }

        public MainWindow()
        {
            InitializeComponent();
            forwardButton.MaximumSize = forwardButton.Size;
            forwardButton.Enabled = false;
            _ = InitializeOpenNAT();
            
        }
        
        private async Task InitializeOpenNAT()
        {
            NatDiscoverer discoverer = new NatDiscoverer();
            _device = await discoverer.DiscoverDeviceAsync();
            var ip = await _device.GetExternalIPAsync();
            publicIp.Text = ip.ToString();
            if (_device.GetType().ToString() == "Open.Nat.UpnpNatDevice")
            {
                _forwardType = "UPnP";
                forwardingType.Text = _forwardType;
                forwardButton.Enabled = true;

            }
            else if (_device.GetType().ToString() == "Open.Nat.PmpNatDevice") {
                _forwardType = "PMP";
                forwardingType.Text = _forwardType;
                forwardButton.Enabled = true;
            }
        }

        private void Forward_click(object sender, EventArgs e)
        {
            try
            {
                int port = (int)portInput.Value;
                Task t = Task.Run(async () =>
                {
                    await _device.CreatePortMapAsync(new Mapping(Protocol.Tcp, port, port));
                });
                t.Wait();
                if(!portList.Items.Contains(port))
                    portList.Items.Add(port);

                if (createFirewallRule.Checked)
                    _firewall.AllowPort(port);

                successLabel.Visible = true;
                successLabel.Text = "Forwarded " + port.ToString();
            }
            catch(Exception)
            {
                successLabel.Visible = true;
                successLabel.ForeColor = Color.Red;
                successLabel.Text = "Can't forward";
            }
        }

        private void OnPortValueChanged(object sender, EventArgs e)
        {
            forwardButton.Enabled = ForwardEnabled;
        }

        private void OnPortItemSelectionChange(object sender, EventArgs e)
        {
            deleteButton.Visible = portList.CheckedItems.Count > 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(int port in portList.CheckedItems)
            {
                var t = Task.Run(async () =>
                {
                    var toRemove = new Mapping(Protocol.Tcp, port, port);
                    await _device.DeletePortMapAsync(toRemove);
                });
                t.Wait();
                _firewall.RemoveRule(port);
            }
            while (portList.CheckedItems.Count > 0)
            {
                portList.Items.RemoveAt(portList.CheckedIndices[0]);
            }
            deleteButton.Visible = false;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (portList.Items.Count == 0)
                return;
                
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if(MessageBox.Show("Closing the program closes all opened ports", "Exit tool?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    e.Cancel = true;
                } 
            }
        }

    }
}

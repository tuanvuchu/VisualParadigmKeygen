using System.Security.Principal;
using System.Text.Json;
using System.Web;

namespace VisualParadigmKeygen
{
    public partial class Main : Form
    {
        private readonly Keygen keygen = new();
        private readonly HostsHelper hostsHelper = new();
        private string edition;
        private string build;
        private string installationId;
        private string email;
        private string name;

        private static readonly HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://raw.githubusercontent.com/"),
        };

        public Main()
        {
            InitializeComponent();
        }

        private async Task GetAsync()
        {
            try
            {
                using HttpResponseMessage response = await sharedClient.GetAsync(
                    "tuanvuchu/VisualParadigmKeygen/refs/heads/main/version.json"
                );
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var versions = JsonSerializer.Deserialize<List<VersionInfo>>(jsonResponse);

                CbbVersion.DataSource = versions;
                CbbVersion.DisplayMember = "version";
                CbbVersion.ValueMember = "build_number";
            }
            catch (Exception ex)
            {
                TbOutput.Text = ex.Message;
            }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            RunAsAdministrator runAsAdministrator = new();
            if (!IsAdministrator())
            {
                runAsAdministrator.ShowDialog();
                Application.Exit();
                return;
            }

            hostsHelper.AddToHosts();
            CbbEdition.SelectedIndex = 0;
            await GetAsync();
        }
        private void BtnGenerateKey_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new(TbInput.Text);
                var query = HttpUtility.ParseQueryString(uri.Query);
                name = query["name"];
                email = query["email"];
                installationId = query["inst"];
                string license = keygen.License(installationId, email, name, edition, CbbVersion.Text, build);
                TbOutput.Text = license;
            }
            catch (Exception ex)
            {
                TbOutput.Text = ex.Message;
            }
        }

        private void TbKeyInput_TextChanged(object sender, EventArgs e)
        {
            TbOutput.Text = null;
        }

        private void TbOutput_DoubleClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbOutput.Text))
            {
                Clipboard.SetText(TbOutput.Text);
            }
        }

        private void TsMiAbout_Click(object sender, EventArgs e)
        {
            About fAbout = new();
            fAbout.ShowDialog();
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void CbbEdition_SelectedIndexChanged(object sender, EventArgs e)
        {
            edition = CbbEdition.Text switch
            {
                "Standard" => "Visual Paradigm Standard Edition",
                "Professional" => "Visual Paradigm Professional Edition",
                "Enterprise" => "Visual Paradigm Enterprise Edition",
                _ => "Visual Paradigm Enterprise Edition",
            };
        }

        private void CbbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbVersion.SelectedItem is VersionInfo versionInfo)
            {
                build = versionInfo.build_number;
            }
        }

        private void RestoreHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hostsHelper.RemoveFromHosts();
            MessageBox.Show("The hosts file has been successfully restored.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
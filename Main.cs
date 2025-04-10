using System.Security.Principal;
using System.Web;

namespace VisualParadigmKeygen
{
    public partial class FMain : Form
    {
        private readonly Keygen keygen = new();
        private readonly HostsHelper hostsHelper = new();
        private string edition;
        private string build;
        private string installationId;
        private string email;
        private string name;
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            FRunAsAdministrator fRunAsAdministrator = new();
            if (!IsAdministrator())
            {
                fRunAsAdministrator.ShowDialog();
                Application.Exit();
            }
            hostsHelper.AddToHosts();
            CbbEdition.SelectedIndex = 0;
            CbbVersion.SelectedIndex = 0;
        }
        private void GenerateKey_Click(object sender, EventArgs e)
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

        private void TsmiHowToUse_Click(object sender, EventArgs e)
        {
            FHowToUse fHowToUse = new();
            fHowToUse.ShowDialog();
        }
        private void TsMiAbout_Click(object sender, EventArgs e)
        {
            FAbout fAbout = new();
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
                _ => "Visual Paradigm Professional Edition",
            };
        }

        private void CbbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            build = CbbVersion.Text switch
            {
                "17.0" => "20230401",
                "17.1" => "20240501",
                "17.2" => "20250321",
                _ => "20250321",
            };
        }
    }
}
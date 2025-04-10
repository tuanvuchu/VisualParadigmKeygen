namespace VisualParadigmKeygen
{
    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
        }

        private void FAbout_Load(object sender, EventArgs e)
        {
            LbFooter.Text = DateTime.Now.Year.ToString();
        }
    }
}

namespace VisualParadigmKeygen
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void FAbout_Load(object sender, EventArgs e)
        {
            LbFooter.Text = DateTime.Now.Year.ToString();
        }
    }
}

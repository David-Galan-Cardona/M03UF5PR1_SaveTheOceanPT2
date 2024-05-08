namespace M03UF5PR1_SaveTheOcean
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //cierra la app
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Index index = new Index(this);
            index.Show();
            this.Hide();
        }
    }
}

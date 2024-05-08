using M03UF5PR1_SaveTheOcean.DTO;

namespace M03UF5PR1_SaveTheOcean
{
    public partial class Index : Form
    {
        private Start start;
        public Index(Start start)
        {
            InitializeComponent();
            this.start = start;
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            start.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Player jugador = new Player(this, start);
            jugador.Show();
            this.Hide();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSpecies editar = new EditSpecies(this, start);
            editar.Show();
            this.Hide();
        }

        private void btnAddSpecies_Click(object sender, EventArgs e)
        {
            AddSpecies afegir = new AddSpecies(this, start);
            afegir.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IDSearch search = new IDSearch(this, start);
            search.Show();
            this.Hide();
        }
    }
}

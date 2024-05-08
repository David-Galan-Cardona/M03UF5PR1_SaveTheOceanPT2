using M03UF5PR1_SaveTheOcean.DTO;
using M03UF5PR1_SaveTheOcean.Persistence.DAO;
using M03UF5PR1_SaveTheOcean.Persistence.Mapping;
using M03UF5PR1_SaveTheOcean.Persistence.Utils;
using Npgsql;

namespace M03UF5PR1_SaveTheOcean
{
    public partial class Report : Form
    {
        private Start start;
        private PlayerDTO player;
        public Report(Start start, PlayerDTO player)
        {
            InitializeComponent();
            this.start = start;
            this.player = player;
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            start.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string[] cities = { "Barcelona", "Valencia", "Alicante", "Malaga", "Cadiz", "La Coruña", "Gijon", "Santander", "Bilbao", "San Sebastian" };
            Random random = new Random();
            int num = random.Next(1, 1000);
            if (num % 10 == 0)
            {
                lblResAnimal.Text = "RES00" + num;
            }
            else if (num % 100 == 0)
            {
                lblResAnimal.Text = "RES0" + num;
            }
            else
            {
                lblResAnimal.Text = "RES" + num;
            }
            lblDateAnimal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblGAAnimal.Text = random.Next(1, 100).ToString();
            lblLocAnimal.Text = cities[random.Next(0, cities.Length)];
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                connection.Open();
                AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
                IEnumerable<AnimalDTO> animals = animalDAO.GetAllAnimals();
                AnimalDTO animal = animals.ElementAt(random.Next(0, animals.Count()));
                lblNameAnimal.Text = animal.Name;
                lblSpeciesAnimal.Text = animal.Species;
                lblSuperFamAnimal.Text = animal.Superfamily;
                lblPesAnimal.Text = animal.Wheight.ToString();
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            int NewGA = 0;
            if (lblSuperFamAnimal.Text == "Cetaci")
            {
                NewGA = int.Parse(lblGAAnimal.Text) - (int.Parse(lblGAAnimal.Text) / 5) - 50;
            }
            else if (lblSuperFamAnimal.Text == "Tortuga Marina")
            {
                NewGA = (2 * int.Parse(lblGAAnimal.Text) + 3) - ((int.Parse(lblGAAnimal.Text) - 20) * 2) - 15;
            }
            else
            {
                NewGA = (int.Parse(lblGAAnimal.Text) - 5) / 5;
            }
            if (NewGA < 0)
            {
                NewGA = 0;
            }
            if (NewGA <= 30)
            {
                player.Exp += 50;
                MessageBox.Show("El tractament aplicat ha reduït el GA fins al  " + NewGA + "%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP\nAra tens "+player.Exp+" punts d'experiència");
            }
            else
            {
                player.Exp -= 20;
                MessageBox.Show("El tractament aplicat ha reduït el GA fins al " + NewGA + "%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP\nAra tens " + player.Exp + " punts d'experiència");
            }
            XMLHelper.CreateXMLFileWithLINQ(player, lblResAnimal.Text, lblDateAnimal.Text, lblSuperFamAnimal.Text, lblLocAnimal.Text, int.Parse(lblGAAnimal.Text), NewGA, lblSpeciesAnimal.Text);
            start.Show();
            this.Close();
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            int NewGA = 0;
            if (lblSuperFamAnimal.Text == "Cetaci")
            {
                NewGA = int.Parse(lblGAAnimal.Text) - (int.Parse(lblGAAnimal.Text) / 5);
            }
            else if (lblSuperFamAnimal.Text == "Tortuga Marina")
            {
                NewGA = (2 * int.Parse(lblGAAnimal.Text) + 3) - ((int.Parse(lblGAAnimal.Text) - 20) * 2) - 15;
            }
            else
            {
                NewGA = (int.Parse(lblGAAnimal.Text)) / 5;
            }
            if (NewGA < 0)
            {
                NewGA = 0;
            }
            if (NewGA <= 30)
            {
                player.Exp += 50;
                MessageBox.Show("El tractament aplicat ha reduït el GA fins al  " + NewGA + "%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP\nAra tens " + player.Exp + " punts d'experiència");
            }
            else
            {
                player.Exp -= 20;
                MessageBox.Show("El tractament aplicat ha reduït el GA fins al " + NewGA + "%. No ha estat prou efectiu i tristament l'animal ha mort. La teva experiència s’ha reduït en -20XP\nAra tens " + player.Exp + " punts d'experiència");
            }
            XMLHelper.CreateXMLFileWithLINQ(player, lblResAnimal.Text, lblDateAnimal.Text, lblSuperFamAnimal.Text, lblLocAnimal.Text, int.Parse(lblGAAnimal.Text), NewGA, lblSpeciesAnimal.Text);
            start.Show();
            this.Close();
        }
    }
}

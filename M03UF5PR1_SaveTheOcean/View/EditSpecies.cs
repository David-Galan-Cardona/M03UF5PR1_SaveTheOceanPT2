using M03UF5PR1_SaveTheOcean.DTO;
using M03UF5PR1_SaveTheOcean.Persistence.DAO;
using M03UF5PR1_SaveTheOcean.Persistence.Mapping;
using M03UF5PR1_SaveTheOcean.Persistence.Utils;
using Npgsql;

namespace M03UF5PR1_SaveTheOcean
{
    public partial class EditSpecies : Form
    {
        private Index index;
        private Start start;
        public EditSpecies(Index index, Start start)
        {
            InitializeComponent();
            this.index = index;
            this.start = start;
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            index.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //validate form
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                //search database for animals with the same species name and assign the new values
                using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
                {
                    connection.Open();
                    AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
                    AnimalDTO animal = animalDAO.GetAnimalBySpecies(cmbSpecies.Text);
                    if (animal != null)
                    {
                        animal.Name = txtName.Text;
                        animal.Wheight = int.Parse(txtWheight.Text);
                        animalDAO.UpdateAnimal(animal);
                    }
                    else { MessageBox.Show("Animal not found");}
                }
            }
        }

        private void txtSpecies_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbSpecies.SelectedIndex == -1)
            {
                errSpecies.SetError(cmbSpecies, "Please enter a species");
                e.Cancel = true;
            }
            else
            {
                errSpecies.SetError(cmbSpecies, null);
                e.Cancel = false;
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errName.SetError(txtName, "Please enter a name");
                e.Cancel = true;
            }
            else
            {
                errName.SetError(txtName, null);
                e.Cancel = false;
            }
        }

        private void txtWheight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWheight.Text))
            {
                errWheight.SetError(txtWheight, "Please enter a wheight");
                e.Cancel = true;
            }
            else if (!int.TryParse(txtWheight.Text, out int wheight))
            {
                errWheight.SetError(txtWheight, "Please enter a valid wheight");
                e.Cancel = true;
            }
            else
            {
                errWheight.SetError(txtWheight, null);
                e.Cancel = false;
            }
        }

        private void EditSpecies_Load(object sender, EventArgs e)
        {
            //haz una consulta a la base de datos para obtener los datos del animal y guarda las especies en los items de cmbspecies
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                connection.Open();
                AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
                IEnumerable<AnimalDTO> animals = animalDAO.GetAllAnimals();
                foreach (AnimalDTO animal in animals)
                {
                    cmbSpecies.Items.Add(animal.Species);
                }
            }
        }
    }
}

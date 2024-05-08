using M03UF5PR1_SaveTheOcean.Persistence.Utils;
using Npgsql;
using M03UF5PR1_SaveTheOcean.DTO;
using M03UF5PR1_SaveTheOcean.Persistence.Mapping;

namespace M03UF5PR1_SaveTheOcean
{
    public partial class AddSpecies : Form
    {
        private Index index;
        private Start start;
        public AddSpecies(Index index, Start start)
        {
            InitializeComponent();
            this.index = index;
            this.start = start;
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            index.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate form
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                //search database for animals with the same species name and assign the new values
                using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
                {
                    connection.Open();
                    AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
                    AnimalDTO animal = animalDAO.GetAnimalBySpecies(txtSpecies.Text);
                    if (animal == null)
                    {
                        animal = new AnimalDTO
                        {
                            Name = txtName.Text,
                            Superfamily = cmbSuperfamily.Text,
                            Species = txtSpecies.Text,
                            Wheight = int.Parse(txtWheight.Text)
                        };
                        animalDAO.AddAnimal(animal);
                    }
                    else { MessageBox.Show("Animal already exists"); }
                }
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

        private void txtSpecies_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSpecies.Text))
            {
                errSpecies.SetError(txtSpecies, "Please enter a species");
                e.Cancel = true;
            }
            else
            {
                errSpecies.SetError(txtSpecies, null);
                e.Cancel = false;
            }
        }

        private void cmbSuperfamily_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbSuperfamily.SelectedIndex == -1)
            {
                errSuperfamily.SetError(cmbSuperfamily, "Please enter a superfamily");
                e.Cancel = true;
            }
            else
            {
                errSuperfamily.SetError(cmbSuperfamily, null);
                e.Cancel = false;
            }
        }

        private void txtWheight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWheight.Text))
            {
                errWheight.SetError(txtWheight, "Please enter a weight");
                e.Cancel = true;
            }
            else if (!int.TryParse(txtWheight.Text, out int wheight))
            {
                errWheight.SetError(txtWheight, "Please enter a valid weight");
                e.Cancel = true;
            }
            else
            {
                errWheight.SetError(txtWheight, null);
                e.Cancel = false;
            }
        }
    }
}

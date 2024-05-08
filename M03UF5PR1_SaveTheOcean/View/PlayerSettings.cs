using M03UF5PR1_SaveTheOcean.DTO;

namespace M03UF5PR1_SaveTheOcean
{
    public partial class Player : Form
    {
        private Index index;
        private Start start;
        public Player(Index index, Start start)
        {
            InitializeComponent();
            this.index = index;
            this.start = start;
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            index.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                PlayerDTO player = null;
                if (cmbJob.SelectedIndex == 0)
                {
                    player = new PlayerDTO(txtName.Text, 45);
                }
                else if (cmbJob.SelectedIndex == 1)
                {
                    player = new PlayerDTO(txtName.Text, 80);
                }
                Report game = new Report(start, player);
                game.Show();
                this.Hide();
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errName.SetError(txtName, "Please enter your name");
                e.Cancel = true;
            }
            else
            {
                errName.SetError(txtName, null);
                e.Cancel = false;
            }
        }

        private void cmbJob_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbJob.SelectedIndex == -1)
            {
                errJob.SetError(cmbJob, "Please select a job");
                e.Cancel = true;
            }
            else
            {
                errJob.SetError(cmbJob, null);
                e.Cancel = false;
            }
        }
    }
}

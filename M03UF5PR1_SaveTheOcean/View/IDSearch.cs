using M03UF5PR1_SaveTheOcean.DTO;

namespace M03UF5PR1_SaveTheOcean
{
    public partial class IDSearch : Form
    {
        private Index index;
        private Start start;
        public IDSearch(Index index, Start start)
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
                //busca el rescat amb el codi introduit
                XMLHelper.ReadXMLFileWithLINQ(cmbRes.Text);
            }
        }

        private void cmbJob_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbRes.SelectedIndex == -1)
            {
                errRes.SetError(cmbRes, "Please select a job");
                e.Cancel = true;
            }
            else
            {
                errRes.SetError(cmbRes, null);
                e.Cancel = false;
            }
        }

        private void IDSearch_Load(object sender, EventArgs e)
        {
            //carrega RES de tots els rescats de k'XML en el combobox
            string[] rescues = XMLHelper.ReturnAllRES();
            foreach (string res in rescues)
            {
                cmbRes.Items.Add(res);
            }
        }
    }
}

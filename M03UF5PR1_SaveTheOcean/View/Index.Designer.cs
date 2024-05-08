namespace M03UF5PR1_SaveTheOcean
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlay = new Button();
            btnSearch = new Button();
            btnEdit = new Button();
            btnAddSpecies = new Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(483, 314);
            btnPlay.Margin = new Padding(3, 4, 3, 4);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(288, 115);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "JUGAR";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(483, 131);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(288, 115);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Buscar per ID";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(87, 131);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(288, 115);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar Espècie";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAddSpecies
            // 
            btnAddSpecies.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSpecies.Location = new Point(87, 314);
            btnAddSpecies.Margin = new Padding(3, 4, 3, 4);
            btnAddSpecies.Name = "btnAddSpecies";
            btnAddSpecies.Size = new Size(288, 115);
            btnAddSpecies.TabIndex = 4;
            btnAddSpecies.Text = "Afegir Espècie";
            btnAddSpecies.UseVisualStyleBackColor = true;
            btnAddSpecies.Click += btnAddSpecies_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAddSpecies);
            Controls.Add(btnPlay);
            Controls.Add(btnSearch);
            Controls.Add(btnEdit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Index";
            Text = "Index";
            FormClosing += Index_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button btnPlay;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnAddSpecies;
    }
}

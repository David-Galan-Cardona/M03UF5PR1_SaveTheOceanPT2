namespace M03UF5PR1_SaveTheOcean
{
    partial class AddSpecies
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
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            txtName = new TextBox();
            lblName = new Label();
            lblSuperfamily = new Label();
            cmbSuperfamily = new ComboBox();
            lblSpecies = new Label();
            txtWheight = new TextBox();
            lblWheight = new Label();
            txtSpecies = new TextBox();
            errName = new ErrorProvider(components);
            errSpecies = new ErrorProvider(components);
            errSuperfamily = new ErrorProvider(components);
            errWheight = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSpecies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSuperfamily).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errWheight).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(302, 199);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Afegeix";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 64);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 27);
            txtName.TabIndex = 6;
            txtName.Validating += txtName_Validating;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15F);
            lblName.Location = new Point(29, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 35);
            lblName.TabIndex = 5;
            lblName.Text = "Nom:";
            // 
            // lblSuperfamily
            // 
            lblSuperfamily.AutoSize = true;
            lblSuperfamily.Font = new Font("Segoe UI", 15F);
            lblSuperfamily.Location = new Point(29, 132);
            lblSuperfamily.Name = "lblSuperfamily";
            lblSuperfamily.Size = new Size(158, 35);
            lblSuperfamily.TabIndex = 7;
            lblSuperfamily.Text = "Superfamília:";
            // 
            // cmbSuperfamily
            // 
            cmbSuperfamily.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuperfamily.FormattingEnabled = true;
            cmbSuperfamily.Items.AddRange(new object[] { "Au Marina", "Cetaci", "Tortuga Marina" });
            cmbSuperfamily.Location = new Point(193, 139);
            cmbSuperfamily.Name = "cmbSuperfamily";
            cmbSuperfamily.Size = new Size(123, 28);
            cmbSuperfamily.TabIndex = 8;
            cmbSuperfamily.Validating += cmbSuperfamily_Validating;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Font = new Font("Segoe UI", 15F);
            lblSpecies.Location = new Point(394, 57);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(103, 35);
            lblSpecies.TabIndex = 9;
            lblSpecies.Text = "Espècie:";
            // 
            // txtWheight
            // 
            txtWheight.Location = new Point(535, 141);
            txtWheight.Margin = new Padding(3, 4, 3, 4);
            txtWheight.Name = "txtWheight";
            txtWheight.Size = new Size(66, 27);
            txtWheight.TabIndex = 12;
            txtWheight.Validating += txtWheight_Validating;
            // 
            // lblWheight
            // 
            lblWheight.AutoSize = true;
            lblWheight.Font = new Font("Segoe UI", 15F);
            lblWheight.Location = new Point(394, 132);
            lblWheight.Name = "lblWheight";
            lblWheight.Size = new Size(135, 35);
            lblWheight.TabIndex = 11;
            lblWheight.Text = "Pes Aprox.:";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(503, 66);
            txtSpecies.Margin = new Padding(3, 4, 3, 4);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(212, 27);
            txtSpecies.TabIndex = 15;
            txtSpecies.Validating += txtSpecies_Validating;
            // 
            // errName
            // 
            errName.ContainerControl = this;
            // 
            // errSpecies
            // 
            errSpecies.ContainerControl = this;
            // 
            // errSuperfamily
            // 
            errSuperfamily.ContainerControl = this;
            // 
            // errWheight
            // 
            errWheight.ContainerControl = this;
            // 
            // AddSpecies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 264);
            Controls.Add(txtSpecies);
            Controls.Add(txtWheight);
            Controls.Add(lblWheight);
            Controls.Add(lblSpecies);
            Controls.Add(cmbSuperfamily);
            Controls.Add(lblSuperfamily);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddSpecies";
            Text = "Afegeix una espècie";
            FormClosing += Index_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSpecies).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSuperfamily).EndInit();
            ((System.ComponentModel.ISupportInitialize)errWheight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private TextBox txtName;
        private Label lblName;
        private Label lblSuperfamily;
        private ComboBox cmbSuperfamily;
        private Label lblSpecies;
        private TextBox txtWheight;
        private Label lblWheight;
        private TextBox txtSpecies;
        private ErrorProvider errName;
        private ErrorProvider errSpecies;
        private ErrorProvider errSuperfamily;
        private ErrorProvider errWheight;
    }
}

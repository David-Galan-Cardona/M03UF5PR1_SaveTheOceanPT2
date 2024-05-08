namespace M03UF5PR1_SaveTheOcean
{
    partial class EditSpecies
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
            btnEdit = new Button();
            txtName = new TextBox();
            lblName = new Label();
            lblSpecies = new Label();
            txtWheight = new TextBox();
            lblWheight = new Label();
            errSpecies = new ErrorProvider(components);
            errName = new ErrorProvider(components);
            errWheight = new ErrorProvider(components);
            cmbSpecies = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errSpecies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errWheight).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(346, 195);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 35);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edita";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(210, 141);
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
            lblName.Location = new Point(77, 132);
            lblName.Name = "lblName";
            lblName.Size = new Size(126, 35);
            lblName.TabIndex = 5;
            lblName.Text = "Nou nom:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Font = new Font("Segoe UI", 15F);
            lblSpecies.Location = new Point(191, 37);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(103, 35);
            lblSpecies.TabIndex = 9;
            lblSpecies.Text = "Espècie:";
            // 
            // txtWheight
            // 
            txtWheight.Location = new Point(619, 141);
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
            lblWheight.Location = new Point(465, 132);
            lblWheight.Name = "lblWheight";
            lblWheight.Size = new Size(135, 35);
            lblWheight.TabIndex = 11;
            lblWheight.Text = "Pes Aprox.:";
            // 
            // errSpecies
            // 
            errSpecies.ContainerControl = this;
            // 
            // errName
            // 
            errName.ContainerControl = this;
            // 
            // errWheight
            // 
            errWheight.ContainerControl = this;
            // 
            // cmbSpecies
            // 
            cmbSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecies.FormattingEnabled = true;
            cmbSpecies.Location = new Point(300, 46);
            cmbSpecies.Name = "cmbSpecies";
            cmbSpecies.Size = new Size(207, 28);
            cmbSpecies.TabIndex = 13;
            // 
            // EditSpecies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 264);
            Controls.Add(cmbSpecies);
            Controls.Add(txtWheight);
            Controls.Add(lblWheight);
            Controls.Add(lblSpecies);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnEdit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditSpecies";
            Text = "Edita una espècie";
            FormClosing += Index_FormClosing;
            Load += EditSpecies_Load;
            ((System.ComponentModel.ISupportInitialize)errSpecies).EndInit();
            ((System.ComponentModel.ISupportInitialize)errName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errWheight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEdit;
        private TextBox txtName;
        private Label lblName;
        private Label lblSpecies;
        private TextBox txtWheight;
        private Label lblWheight;
        private ErrorProvider errSpecies;
        private ErrorProvider errName;
        private ErrorProvider errWheight;
        private ComboBox cmbSpecies;
    }
}

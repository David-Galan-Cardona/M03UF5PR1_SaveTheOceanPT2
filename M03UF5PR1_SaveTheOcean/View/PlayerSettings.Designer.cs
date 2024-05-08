namespace M03UF5PR1_SaveTheOcean
{
    partial class Player
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
            btnPlay = new Button();
            txtName = new TextBox();
            lblName = new Label();
            lblJob = new Label();
            cmbJob = new ComboBox();
            errName = new ErrorProvider(components);
            errJob = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errJob).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(196, 199);
            btnPlay.Margin = new Padding(3, 4, 3, 4);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(120, 35);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Comença";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
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
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Font = new Font("Segoe UI", 15F);
            lblJob.Location = new Point(29, 132);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(71, 35);
            lblJob.TabIndex = 7;
            lblJob.Text = "Ofici:";
            // 
            // cmbJob
            // 
            cmbJob.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJob.FormattingEnabled = true;
            cmbJob.Items.AddRange(new object[] { "Tècnic", "Veterinari" });
            cmbJob.Location = new Point(104, 139);
            cmbJob.Name = "cmbJob";
            cmbJob.Size = new Size(210, 28);
            cmbJob.TabIndex = 8;
            cmbJob.Validating += cmbJob_Validating;
            // 
            // errName
            // 
            errName.ContainerControl = this;
            // 
            // errJob
            // 
            errJob.ContainerControl = this;
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 264);
            Controls.Add(cmbJob);
            Controls.Add(lblJob);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnPlay);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Player";
            Text = "Jugador";
            FormClosing += Index_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errJob).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPlay;
        private TextBox txtName;
        private Label lblName;
        private Label lblJob;
        private ComboBox cmbJob;
        private ErrorProvider errName;
        private ErrorProvider errJob;
    }
}

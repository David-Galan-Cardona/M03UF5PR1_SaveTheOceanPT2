namespace M03UF5PR1_SaveTheOcean
{
    partial class IDSearch
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
            btnSearch = new Button();
            lblRes = new Label();
            cmbRes = new ComboBox();
            errRes = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errRes).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(106, 157);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Busca";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnPlay_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 15F);
            lblRes.Location = new Point(29, 57);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(61, 35);
            lblRes.TabIndex = 5;
            lblRes.Text = "RES:";
            // 
            // cmbRes
            // 
            cmbRes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRes.FormattingEnabled = true;
            cmbRes.Location = new Point(106, 66);
            cmbRes.Name = "cmbRes";
            cmbRes.Size = new Size(210, 28);
            cmbRes.TabIndex = 8;
            cmbRes.Validating += cmbJob_Validating;
            // 
            // errRes
            // 
            errRes.ContainerControl = this;
            // 
            // IDSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 264);
            Controls.Add(cmbRes);
            Controls.Add(lblRes);
            Controls.Add(btnSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IDSearch";
            Text = "Jugador";
            FormClosing += Index_FormClosing;
            Load += IDSearch_Load;
            ((System.ComponentModel.ISupportInitialize)errRes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private Label lblRes;
        private ComboBox cmbRes;
        private ErrorProvider errRes;
    }
}

namespace M03UF5PR1_SaveTheOcean
{
    partial class Start
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
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(254, 97);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(252, 86);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "JUGAR";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(254, 229);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(252, 86);
            btnExit.TabIndex = 1;
            btnExit.Text = "SORTIR";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnPlay);
            Name = "Start";
            Text = "Start";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button btnExit;
    }
}

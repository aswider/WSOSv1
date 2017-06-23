namespace WSOS_v0._1
{
    partial class FormularzLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularzLogIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.ZalogujBTN = new System.Windows.Forms.Button();
            this.ZamknijBTN = new System.Windows.Forms.Button();
            this.IdentyfikatorLabel = new System.Windows.Forms.Label();
            this.hasloLabel = new System.Windows.Forms.Label();
            this.PasswordBoxN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WSOS_v0._1.Properties.Resources.oie_transparent__2_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginBox.Location = new System.Drawing.Point(202, 180);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(222, 23);
            this.LoginBox.TabIndex = 8;
            // 
            // ZalogujBTN
            // 
            this.ZalogujBTN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZalogujBTN.Location = new System.Drawing.Point(444, 180);
            this.ZalogujBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZalogujBTN.Name = "ZalogujBTN";
            this.ZalogujBTN.Size = new System.Drawing.Size(82, 62);
            this.ZalogujBTN.TabIndex = 9;
            this.ZalogujBTN.Text = "Zaloguj";
            this.ZalogujBTN.UseVisualStyleBackColor = true;
            this.ZalogujBTN.Click += new System.EventHandler(this.ZalogujBTN_Click);
            // 
            // ZamknijBTN
            // 
            this.ZamknijBTN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamknijBTN.Location = new System.Drawing.Point(538, 13);
            this.ZamknijBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZamknijBTN.Name = "ZamknijBTN";
            this.ZamknijBTN.Size = new System.Drawing.Size(87, 28);
            this.ZamknijBTN.TabIndex = 10;
            this.ZamknijBTN.Text = "Zamknij";
            this.ZamknijBTN.UseVisualStyleBackColor = true;
            this.ZamknijBTN.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // IdentyfikatorLabel
            // 
            this.IdentyfikatorLabel.AutoSize = true;
            this.IdentyfikatorLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IdentyfikatorLabel.Location = new System.Drawing.Point(82, 182);
            this.IdentyfikatorLabel.Name = "IdentyfikatorLabel";
            this.IdentyfikatorLabel.Size = new System.Drawing.Size(114, 21);
            this.IdentyfikatorLabel.TabIndex = 11;
            this.IdentyfikatorLabel.Text = "Identyfikator:";
            // 
            // hasloLabel
            // 
            this.hasloLabel.AutoSize = true;
            this.hasloLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloLabel.Location = new System.Drawing.Point(138, 221);
            this.hasloLabel.Name = "hasloLabel";
            this.hasloLabel.Size = new System.Drawing.Size(58, 21);
            this.hasloLabel.TabIndex = 12;
            this.hasloLabel.Text = "Hasło:";
            // 
            // PasswordBoxN
            // 
            this.PasswordBoxN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordBoxN.Location = new System.Drawing.Point(202, 219);
            this.PasswordBoxN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordBoxN.Name = "PasswordBoxN";
            this.PasswordBoxN.PasswordChar = '*';
            this.PasswordBoxN.Size = new System.Drawing.Size(222, 23);
            this.PasswordBoxN.TabIndex = 13;
            // 
            // FormularzLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 305);
            this.Controls.Add(this.PasswordBoxN);
            this.Controls.Add(this.hasloLabel);
            this.Controls.Add(this.IdentyfikatorLabel);
            this.Controls.Add(this.ZamknijBTN);
            this.Controls.Add(this.ZalogujBTN);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularzLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wydziałowy System Obsługi Studiów";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button ZalogujBTN;
        private System.Windows.Forms.Button ZamknijBTN;
        private System.Windows.Forms.Label IdentyfikatorLabel;
        private System.Windows.Forms.Label hasloLabel;
        private System.Windows.Forms.TextBox PasswordBoxN;
    }
}


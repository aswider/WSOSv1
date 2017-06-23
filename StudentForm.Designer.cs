namespace WSOS_v0._1
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.planPicture = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.listaOcen = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label40 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WyszukajStBox = new System.Windows.Forms.ComboBox();
            this.WyszukajStBTN = new System.Windows.Forms.Button();
            this.listaWyszukiwanychStudentow = new System.Windows.Forms.ListBox();
            this.WyszukajPracBox = new System.Windows.Forms.ComboBox();
            this.WyszukajPracBTN = new System.Windows.Forms.Button();
            this.listaWyszukiwanychPracownikow = new System.Windows.Forms.ListBox();
            this.PobierzDaneBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planPicture)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(951, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Wyloguj
            // 
            this.Wyloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyloguj.Location = new System.Drawing.Point(1019, 192);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(132, 45);
            this.Wyloguj.TabIndex = 3;
            this.Wyloguj.Text = "Wyloguj się";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 572);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.planPicture);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plan zajęć";
            this.tabPage1.ToolTipText = "Zobacz swój plan zajęć";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // planPicture
            // 
            this.planPicture.Image = global::WSOS_v0._1.Properties.Resources._default;
            this.planPicture.Location = new System.Drawing.Point(7, 7);
            this.planPicture.Name = "planPicture";
            this.planPicture.Size = new System.Drawing.Size(626, 516);
            this.planPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planPicture.TabIndex = 0;
            this.planPicture.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.listaOcen);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oceny";
            this.tabPage2.ToolTipText = "Zobacz swoje oceny";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data            Przedmiot                     Ocena                 Prowadzący   " +
    "                Uwagi";
            // 
            // listaOcen
            // 
            this.listaOcen.FormattingEnabled = true;
            this.listaOcen.Location = new System.Drawing.Point(7, 20);
            this.listaOcen.Name = "listaOcen";
            this.listaOcen.Size = new System.Drawing.Size(650, 264);
            this.listaOcen.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.WyszukajStBox);
            this.tabPage3.Controls.Add(this.WyszukajStBTN);
            this.tabPage3.Controls.Add(this.listaWyszukiwanychStudentow);
            this.tabPage3.Controls.Add(this.WyszukajPracBox);
            this.tabPage3.Controls.Add(this.WyszukajPracBTN);
            this.tabPage3.Controls.Add(this.listaWyszukiwanychPracownikow);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(915, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Wyszukaj";
            this.tabPage3.ToolTipText = "Zobacz informacje o pracownikach";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(10, 3);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(457, 13);
            this.label40.TabIndex = 20;
            this.label40.Text = "Aby wyszukać osobę należy wybrać jej imię i nazwisko z odpowiedniej listy i klikn" +
    "ąć \"Wyszukaj\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(735, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nr Indeksu   Imię Nazwisko                   Email                            Pro" +
    "gram studiów    Kierunek                    Specjalność                         " +
    "            Rodzaj studiów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(707, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tytuł       Imię Nazwisko                                  Email                 " +
    "                      WWW                                   NrTel               " +
    "        Pokoj               Katedra";
            // 
            // WyszukajStBox
            // 
            this.WyszukajStBox.FormattingEnabled = true;
            this.WyszukajStBox.Location = new System.Drawing.Point(10, 171);
            this.WyszukajStBox.Name = "WyszukajStBox";
            this.WyszukajStBox.Size = new System.Drawing.Size(371, 21);
            this.WyszukajStBox.TabIndex = 5;
            // 
            // WyszukajStBTN
            // 
            this.WyszukajStBTN.Location = new System.Drawing.Point(402, 171);
            this.WyszukajStBTN.Name = "WyszukajStBTN";
            this.WyszukajStBTN.Size = new System.Drawing.Size(130, 21);
            this.WyszukajStBTN.TabIndex = 4;
            this.WyszukajStBTN.Text = "Wyszukaj studenta";
            this.WyszukajStBTN.UseVisualStyleBackColor = true;
            this.WyszukajStBTN.Click += new System.EventHandler(this.WyszukajStBTN_Click);
            // 
            // listaWyszukiwanychStudentow
            // 
            this.listaWyszukiwanychStudentow.FormattingEnabled = true;
            this.listaWyszukiwanychStudentow.Location = new System.Drawing.Point(10, 227);
            this.listaWyszukiwanychStudentow.Name = "listaWyszukiwanychStudentow";
            this.listaWyszukiwanychStudentow.Size = new System.Drawing.Size(902, 56);
            this.listaWyszukiwanychStudentow.TabIndex = 3;
            // 
            // WyszukajPracBox
            // 
            this.WyszukajPracBox.FormattingEnabled = true;
            this.WyszukajPracBox.Location = new System.Drawing.Point(10, 51);
            this.WyszukajPracBox.Name = "WyszukajPracBox";
            this.WyszukajPracBox.Size = new System.Drawing.Size(371, 21);
            this.WyszukajPracBox.TabIndex = 2;
            // 
            // WyszukajPracBTN
            // 
            this.WyszukajPracBTN.Location = new System.Drawing.Point(402, 51);
            this.WyszukajPracBTN.Name = "WyszukajPracBTN";
            this.WyszukajPracBTN.Size = new System.Drawing.Size(130, 21);
            this.WyszukajPracBTN.TabIndex = 1;
            this.WyszukajPracBTN.Text = "Wyszukaj pracownika";
            this.WyszukajPracBTN.UseVisualStyleBackColor = true;
            this.WyszukajPracBTN.Click += new System.EventHandler(this.WyszukajPracBTN_Click);
            // 
            // listaWyszukiwanychPracownikow
            // 
            this.listaWyszukiwanychPracownikow.FormattingEnabled = true;
            this.listaWyszukiwanychPracownikow.Location = new System.Drawing.Point(10, 107);
            this.listaWyszukiwanychPracownikow.Name = "listaWyszukiwanychPracownikow";
            this.listaWyszukiwanychPracownikow.Size = new System.Drawing.Size(902, 56);
            this.listaWyszukiwanychPracownikow.TabIndex = 0;
            // 
            // PobierzDaneBTN
            // 
            this.PobierzDaneBTN.Location = new System.Drawing.Point(1019, 243);
            this.PobierzDaneBTN.Name = "PobierzDaneBTN";
            this.PobierzDaneBTN.Size = new System.Drawing.Size(132, 45);
            this.PobierzDaneBTN.TabIndex = 8;
            this.PobierzDaneBTN.Text = "Pobierz dane";
            this.PobierzDaneBTN.UseVisualStyleBackColor = true;
            this.PobierzDaneBTN.Click += new System.EventHandler(this.PobierzPlan_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(88, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Witamy w Wydziałowym Systemie Obsługi Studiów!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSOS_v0._1.Properties.Resources.oie_YH3Bj3ucrixn;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PobierzDaneBTN);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wyloguj);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wydziałowy System Obsługi Studiów - Student";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planPicture)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox planPicture;
        private System.Windows.Forms.ListBox listaOcen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PobierzDaneBTN;
        private System.Windows.Forms.ComboBox WyszukajPracBox;
        private System.Windows.Forms.Button WyszukajPracBTN;
        private System.Windows.Forms.ListBox listaWyszukiwanychPracownikow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox WyszukajStBox;
        private System.Windows.Forms.Button WyszukajStBTN;
        private System.Windows.Forms.ListBox listaWyszukiwanychStudentow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
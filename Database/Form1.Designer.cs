﻿namespace Database {
    partial class Form1 {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rok_wydania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tytul_albumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wykonawca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pochodzenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_stanie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.i_ocena = new System.Windows.Forms.TextBox();
            this.i_nastanie = new System.Windows.Forms.CheckBox();
            this.i_cena = new System.Windows.Forms.TextBox();
            this.i_pochodzenie = new System.Windows.Forms.TextBox();
            this.i_tytulalbumu = new System.Windows.Forms.TextBox();
            this.i_wykonawca = new System.Windows.Forms.TextBox();
            this.i_rokwydania = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.i_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.i_iloscrekordow = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.Rok_wydania,
            this.Tytul_albumu,
            this.Wykonawca,
            this.Pochodzenie,
            this.Cena,
            this.Ocena,
            this.Na_stanie});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 559);
            this.dataGridView1.TabIndex = 0;
            // 
            // idd
            // 
            this.idd.HeaderText = "ID";
            this.idd.Name = "idd";
            // 
            // Rok_wydania
            // 
            this.Rok_wydania.HeaderText = "Rok wydania";
            this.Rok_wydania.Name = "Rok_wydania";
            // 
            // Tytul_albumu
            // 
            this.Tytul_albumu.HeaderText = "Tytuł albumu";
            this.Tytul_albumu.Name = "Tytul_albumu";
            // 
            // Wykonawca
            // 
            this.Wykonawca.HeaderText = "Wykonawca";
            this.Wykonawca.Name = "Wykonawca";
            // 
            // Pochodzenie
            // 
            this.Pochodzenie.HeaderText = "Pochodzenie";
            this.Pochodzenie.Name = "Pochodzenie";
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // Ocena
            // 
            this.Ocena.HeaderText = "Ocena (1-10)";
            this.Ocena.Name = "Ocena";
            // 
            // Na_stanie
            // 
            this.Na_stanie.HeaderText = "Na stanie";
            this.Na_stanie.Name = "Na_stanie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.i_ocena);
            this.groupBox1.Controls.Add(this.i_nastanie);
            this.groupBox1.Controls.Add(this.i_cena);
            this.groupBox1.Controls.Add(this.i_pochodzenie);
            this.groupBox1.Controls.Add(this.i_tytulalbumu);
            this.groupBox1.Controls.Add(this.i_wykonawca);
            this.groupBox1.Controls.Add(this.i_rokwydania);
            this.groupBox1.Location = new System.Drawing.Point(867, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(151, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Błędne dane";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(17, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Błędne dane";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(151, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Błędne dane";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(17, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Błędne dane";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(151, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Błędne dane";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(17, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Błędne dane (xxxx)";
            this.label7.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ocena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pochodzenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wykonawca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tytuł albumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rok wydania";
            // 
            // i_ocena
            // 
            this.i_ocena.Location = new System.Drawing.Point(128, 172);
            this.i_ocena.Name = "i_ocena";
            this.i_ocena.Size = new System.Drawing.Size(107, 20);
            this.i_ocena.TabIndex = 6;
            // 
            // i_nastanie
            // 
            this.i_nastanie.AutoSize = true;
            this.i_nastanie.Location = new System.Drawing.Point(105, 198);
            this.i_nastanie.Name = "i_nastanie";
            this.i_nastanie.Size = new System.Drawing.Size(71, 17);
            this.i_nastanie.TabIndex = 5;
            this.i_nastanie.Text = "Na stanie";
            this.i_nastanie.UseVisualStyleBackColor = true;
            // 
            // i_cena
            // 
            this.i_cena.Location = new System.Drawing.Point(15, 172);
            this.i_cena.Name = "i_cena";
            this.i_cena.Size = new System.Drawing.Size(107, 20);
            this.i_cena.TabIndex = 4;
            // 
            // i_pochodzenie
            // 
            this.i_pochodzenie.Location = new System.Drawing.Point(126, 111);
            this.i_pochodzenie.Name = "i_pochodzenie";
            this.i_pochodzenie.Size = new System.Drawing.Size(107, 20);
            this.i_pochodzenie.TabIndex = 3;
            // 
            // i_tytulalbumu
            // 
            this.i_tytulalbumu.Location = new System.Drawing.Point(126, 52);
            this.i_tytulalbumu.Name = "i_tytulalbumu";
            this.i_tytulalbumu.Size = new System.Drawing.Size(107, 20);
            this.i_tytulalbumu.TabIndex = 2;
            // 
            // i_wykonawca
            // 
            this.i_wykonawca.Location = new System.Drawing.Point(13, 111);
            this.i_wykonawca.Name = "i_wykonawca";
            this.i_wykonawca.Size = new System.Drawing.Size(107, 20);
            this.i_wykonawca.TabIndex = 1;
            // 
            // i_rokwydania
            // 
            this.i_rokwydania.Location = new System.Drawing.Point(13, 52);
            this.i_rokwydania.Name = "i_rokwydania";
            this.i_rokwydania.Size = new System.Drawing.Size(107, 20);
            this.i_rokwydania.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.i_id);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(867, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuwanie";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(37, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Błędne dane";
            this.label14.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 20;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // i_id
            // 
            this.i_id.Location = new System.Drawing.Point(13, 41);
            this.i_id.Name = "i_id";
            this.i_id.Size = new System.Drawing.Size(100, 20);
            this.i_id.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(867, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 80);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pliki";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 25);
            this.button4.TabIndex = 22;
            this.button4.Text = "Eksport";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 25);
            this.button3.TabIndex = 21;
            this.button3.Text = "Import";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.i_iloscrekordow);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(864, 455);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 81);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Losowanie";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(100, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Błędne dane";
            this.label16.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(167, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 25);
            this.button5.TabIndex = 21;
            this.button5.Text = "Losuj";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // i_iloscrekordow
            // 
            this.i_iloscrekordow.Location = new System.Drawing.Point(16, 42);
            this.i_iloscrekordow.Name = "i_iloscrekordow";
            this.i_iloscrekordow.Size = new System.Drawing.Size(100, 20);
            this.i_iloscrekordow.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Ilość rekordów:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 585);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox i_ocena;
        private System.Windows.Forms.CheckBox i_nastanie;
        private System.Windows.Forms.TextBox i_cena;
        private System.Windows.Forms.TextBox i_pochodzenie;
        private System.Windows.Forms.TextBox i_tytulalbumu;
        private System.Windows.Forms.TextBox i_wykonawca;
        private System.Windows.Forms.TextBox i_rokwydania;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rok_wydania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tytul_albumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wykonawca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pochodzenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Na_stanie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox i_id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox i_iloscrekordow;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}


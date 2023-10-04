namespace Mozaika_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Mozaika = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImageName = new System.Windows.Forms.TextBox();
            this.Wybierz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Historia = new System.Windows.Forms.TabPage();
            this.Miniaturki = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.Mozaika.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Mozaika);
            this.tabControl1.Controls.Add(this.Historia);
            this.tabControl1.Controls.Add(this.Miniaturki);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1214, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // Mozaika
            // 
            this.Mozaika.BackColor = System.Drawing.Color.Transparent;
            this.Mozaika.Controls.Add(this.groupBox1);
            this.Mozaika.Controls.Add(this.button1);
            this.Mozaika.Controls.Add(this.progressBar1);
            this.Mozaika.Controls.Add(this.comboBox4);
            this.Mozaika.Controls.Add(this.label5);
            this.Mozaika.Controls.Add(this.comboBox3);
            this.Mozaika.Controls.Add(this.label4);
            this.Mozaika.Controls.Add(this.comboBox2);
            this.Mozaika.Controls.Add(this.label3);
            this.Mozaika.Controls.Add(this.comboBox1);
            this.Mozaika.Controls.Add(this.label2);
            this.Mozaika.Controls.Add(this.textBoxImageName);
            this.Mozaika.Controls.Add(this.Wybierz);
            this.Mozaika.Controls.Add(this.label1);
            this.Mozaika.Location = new System.Drawing.Point(4, 22);
            this.Mozaika.Name = "Mozaika";
            this.Mozaika.Padding = new System.Windows.Forms.Padding(3);
            this.Mozaika.Size = new System.Drawing.Size(1206, 484);
            this.Mozaika.TabIndex = 0;
            this.Mozaika.Text = "Mozaika";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ListView1);
            this.groupBox1.Location = new System.Drawing.Point(92, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 143);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miniatury";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListView1
            // 
            this.ListView1.BackgroundImageTiled = true;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(38, 24);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(456, 84);
            this.ListView1.TabIndex = 10;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.List;
            this.ListView1.VirtualMode = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stwórz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(173, 404);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 28);
            this.progressBar1.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(222, 221);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(354, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rozdzielczość:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(222, 179);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(354, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Efekt:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(354, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rozmiar miniatury:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rozmiar mozaiki:";
            // 
            // textBoxImageName
            // 
            this.textBoxImageName.Location = new System.Drawing.Point(222, 16);
            this.textBoxImageName.Multiline = true;
            this.textBoxImageName.Name = "textBoxImageName";
            this.textBoxImageName.ReadOnly = true;
            this.textBoxImageName.Size = new System.Drawing.Size(595, 45);
            this.textBoxImageName.TabIndex = 2;
            // 
            // Wybierz
            // 
            this.Wybierz.Location = new System.Drawing.Point(92, 16);
            this.Wybierz.Name = "Wybierz";
            this.Wybierz.Size = new System.Drawing.Size(113, 45);
            this.Wybierz.TabIndex = 1;
            this.Wybierz.Text = "Wybierz";
            this.Wybierz.UseVisualStyleBackColor = true;
            this.Wybierz.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obraz:";
            // 
            // Historia
            // 
            this.Historia.Location = new System.Drawing.Point(4, 22);
            this.Historia.Name = "Historia";
            this.Historia.Padding = new System.Windows.Forms.Padding(3);
            this.Historia.Size = new System.Drawing.Size(1206, 484);
            this.Historia.TabIndex = 1;
            this.Historia.Text = "Historia";
            this.Historia.UseVisualStyleBackColor = true;
            // 
            // Miniaturki
            // 
            this.Miniaturki.Location = new System.Drawing.Point(4, 22);
            this.Miniaturki.Name = "Miniaturki";
            this.Miniaturki.Padding = new System.Windows.Forms.Padding(3);
            this.Miniaturki.Size = new System.Drawing.Size(1206, 484);
            this.Miniaturki.TabIndex = 2;
            this.Miniaturki.Text = "Miniaturki";
            this.Miniaturki.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 612);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.Mozaika.ResumeLayout(false);
            this.Mozaika.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Mozaika;
        private System.Windows.Forms.TabPage Historia;
        private System.Windows.Forms.TabPage Miniaturki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Wybierz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxImageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}


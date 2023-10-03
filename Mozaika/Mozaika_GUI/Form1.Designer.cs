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
            this.Wybierz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Historia = new System.Windows.Forms.TabPage();
            this.Miniaturki = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Mozaika.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Mozaika);
            this.tabControl1.Controls.Add(this.Historia);
            this.tabControl1.Controls.Add(this.Miniaturki);
            this.tabControl1.Location = new System.Drawing.Point(144, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // Mozaika
            // 
            this.Mozaika.Controls.Add(this.textBox1);
            this.Mozaika.Controls.Add(this.Wybierz);
            this.Mozaika.Controls.Add(this.label1);
            this.Mozaika.Location = new System.Drawing.Point(4, 22);
            this.Mozaika.Name = "Mozaika";
            this.Mozaika.Padding = new System.Windows.Forms.Padding(3);
            this.Mozaika.Size = new System.Drawing.Size(1040, 470);
            this.Mozaika.TabIndex = 0;
            this.Mozaika.Text = "Mozaika";
            this.Mozaika.UseVisualStyleBackColor = true;
            // 
            // Wybierz
            // 
            this.Wybierz.Location = new System.Drawing.Point(72, 16);
            this.Wybierz.Name = "Wybierz";
            this.Wybierz.Size = new System.Drawing.Size(113, 35);
            this.Wybierz.TabIndex = 1;
            this.Wybierz.Text = "Wybierz";
            this.Wybierz.UseVisualStyleBackColor = true;
            this.Wybierz.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
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
            this.Historia.Size = new System.Drawing.Size(1040, 470);
            this.Historia.TabIndex = 1;
            this.Historia.Text = "Historia";
            this.Historia.UseVisualStyleBackColor = true;
            // 
            // Miniaturki
            // 
            this.Miniaturki.Location = new System.Drawing.Point(4, 22);
            this.Miniaturki.Name = "Miniaturki";
            this.Miniaturki.Padding = new System.Windows.Forms.Padding(3);
            this.Miniaturki.Size = new System.Drawing.Size(1040, 470);
            this.Miniaturki.TabIndex = 2;
            this.Miniaturki.Text = "Miniaturki";
            this.Miniaturki.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 612);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Mozaika.ResumeLayout(false);
            this.Mozaika.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
    }
}


using System;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Mozaika = new System.Windows.Forms.TabPage();
            this.groupBox_Miniatures = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListView();
            this.CreateMosaic = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Resolution = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Effect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiniatureSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MosaicSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImageName = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Historia = new System.Windows.Forms.TabPage();
            this.Miniaturki = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Mozaika.SuspendLayout();
            this.groupBox_Miniatures.SuspendLayout();
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
            this.Mozaika.Controls.Add(this.groupBox_Miniatures);
            this.Mozaika.Controls.Add(this.CreateMosaic);
            this.Mozaika.Controls.Add(this.progressBar1);
            this.Mozaika.Controls.Add(this.Resolution);
            this.Mozaika.Controls.Add(this.label5);
            this.Mozaika.Controls.Add(this.Effect);
            this.Mozaika.Controls.Add(this.label4);
            this.Mozaika.Controls.Add(this.MiniatureSize);
            this.Mozaika.Controls.Add(this.label3);
            this.Mozaika.Controls.Add(this.MosaicSize);
            this.Mozaika.Controls.Add(this.label2);
            this.Mozaika.Controls.Add(this.textBoxImageName);
            this.Mozaika.Controls.Add(this.SelectButton);
            this.Mozaika.Controls.Add(this.label1);
            this.Mozaika.Location = new System.Drawing.Point(4, 22);
            this.Mozaika.Name = "Mozaika";
            this.Mozaika.Padding = new System.Windows.Forms.Padding(3);
            this.Mozaika.Size = new System.Drawing.Size(1206, 484);
            this.Mozaika.TabIndex = 0;
            this.Mozaika.Text = "Mozaika";
            // 
            // groupBox_Miniatures
            // 
            this.groupBox_Miniatures.Controls.Add(this.button3);
            this.groupBox_Miniatures.Controls.Add(this.button2);
            this.groupBox_Miniatures.Controls.Add(this.Lista);
            this.groupBox_Miniatures.Location = new System.Drawing.Point(92, 254);
            this.groupBox_Miniatures.Name = "groupBox_Miniatures";
            this.groupBox_Miniatures.Size = new System.Drawing.Size(519, 143);
            this.groupBox_Miniatures.TabIndex = 13;
            this.groupBox_Miniatures.TabStop = false;
            this.groupBox_Miniatures.Text = "Miniatury";
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
            // Lista
            // 
            this.Lista.BackgroundImageTiled = true;
            this.Lista.FullRowSelect = true;
            this.Lista.GridLines = true;
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(38, 24);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(456, 84);
            this.Lista.TabIndex = 10;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.List;
            this.Lista.VirtualMode = true;
            // 
            // CreateMosaic
            // 
            this.CreateMosaic.Location = new System.Drawing.Point(92, 403);
            this.CreateMosaic.Name = "CreateMosaic";
            this.CreateMosaic.Size = new System.Drawing.Size(75, 29);
            this.CreateMosaic.TabIndex = 12;
            this.CreateMosaic.Text = "Stwórz";
            this.CreateMosaic.UseVisualStyleBackColor = true;
            this.CreateMosaic.Click += new System.EventHandler(this.CreateMosaic_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(173, 404);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 28);
            this.progressBar1.TabIndex = 11;
            // 
            // Resolution
            // 
            this.Resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Resolution.FormattingEnabled = true;
            this.Resolution.Location = new System.Drawing.Point(222, 221);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(354, 21);
            this.Resolution.TabIndex = 9;
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
            // Effect
            // 
            this.Effect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Effect.FormattingEnabled = true;
            this.Effect.Location = new System.Drawing.Point(222, 179);
            this.Effect.Name = "Effect";
            this.Effect.Size = new System.Drawing.Size(354, 21);
            this.Effect.TabIndex = 7;
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
            // MiniatureSize
            // 
            this.MiniatureSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MiniatureSize.FormattingEnabled = true;
            this.MiniatureSize.Location = new System.Drawing.Point(222, 139);
            this.MiniatureSize.Name = "MiniatureSize";
            this.MiniatureSize.Size = new System.Drawing.Size(354, 21);
            this.MiniatureSize.TabIndex = 5;
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
            // MosaicSize
            // 
            this.MosaicSize.BackColor = System.Drawing.SystemColors.Menu;
            this.MosaicSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MosaicSize.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MosaicSize.FormattingEnabled = true;
            this.MosaicSize.Location = new System.Drawing.Point(222, 96);
            this.MosaicSize.Name = "MosaicSize";
            this.MosaicSize.Size = new System.Drawing.Size(354, 21);
            this.MosaicSize.TabIndex = 3;
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
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(92, 16);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(113, 45);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Wybierz";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
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
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            this.groupBox_Miniatures.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Mozaika;
        private System.Windows.Forms.TabPage Historia;
        private System.Windows.Forms.TabPage Miniaturki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxImageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MosaicSize;
        private System.Windows.Forms.ComboBox Resolution;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Effect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MiniatureSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox_Miniatures;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CreateMosaic;
        private System.Windows.Forms.Timer Timer;
    }
}


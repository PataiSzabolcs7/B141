namespace WindowsFormsAlapok
{
    partial class Form_teruletekatlaga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_teruletekatlaga));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Forrasfajl = new System.Windows.Forms.TextBox();
            this.Button_Betoltes = new System.Windows.Forms.Button();
            this.ListBox_orszagok = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox_szamol = new System.Windows.Forms.GroupBox();
            this.RadioButton_nagyobb = new System.Windows.Forms.RadioButton();
            this.RadioButton_kisebb = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Button_megszamolas = new System.Windows.Forms.Button();
            this.Label_eredmeny = new System.Windows.Forms.Label();
            this.TextBox_eredmeny = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Button_kiiras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Buttom_maximum_minimum = new System.Windows.Forms.Button();
            this.Label_orszag = new System.Windows.Forms.Label();
            this.TextBox_orszagkereses = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Button_Kereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox_szamol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forrásfájl Neve:";
            // 
            // TextBox_Forrasfajl
            // 
            this.TextBox_Forrasfajl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBox_Forrasfajl.Location = new System.Drawing.Point(13, 76);
            this.TextBox_Forrasfajl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_Forrasfajl.Name = "TextBox_Forrasfajl";
            this.TextBox_Forrasfajl.Size = new System.Drawing.Size(222, 29);
            this.TextBox_Forrasfajl.TabIndex = 1;
            // 
            // Button_Betoltes
            // 
            this.Button_Betoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Betoltes.Location = new System.Drawing.Point(14, 124);
            this.Button_Betoltes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Betoltes.Name = "Button_Betoltes";
            this.Button_Betoltes.Size = new System.Drawing.Size(221, 24);
            this.Button_Betoltes.TabIndex = 2;
            this.Button_Betoltes.Text = "Betöltés";
            this.Button_Betoltes.UseVisualStyleBackColor = true;
            this.Button_Betoltes.Click += new System.EventHandler(this.Button_Betoltes_Click);
            // 
            // ListBox_orszagok
            // 
            this.ListBox_orszagok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBox_orszagok.FormattingEnabled = true;
            this.ListBox_orszagok.ItemHeight = 18;
            this.ListBox_orszagok.Location = new System.Drawing.Point(15, 167);
            this.ListBox_orszagok.Name = "ListBox_orszagok";
            this.ListBox_orszagok.Size = new System.Drawing.Size(220, 328);
            this.ListBox_orszagok.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(15, 523);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Területek Átlaga";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GroupBox_szamol
            // 
            this.GroupBox_szamol.Controls.Add(this.RadioButton_kisebb);
            this.GroupBox_szamol.Controls.Add(this.RadioButton_nagyobb);
            this.GroupBox_szamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBox_szamol.Location = new System.Drawing.Point(330, 33);
            this.GroupBox_szamol.Name = "GroupBox_szamol";
            this.GroupBox_szamol.Size = new System.Drawing.Size(200, 100);
            this.GroupBox_szamol.TabIndex = 5;
            this.GroupBox_szamol.TabStop = false;
            this.GroupBox_szamol.Text = "Mit számoljunk?";
            // 
            // RadioButton_nagyobb
            // 
            this.RadioButton_nagyobb.AutoSize = true;
            this.RadioButton_nagyobb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButton_nagyobb.Location = new System.Drawing.Point(7, 26);
            this.RadioButton_nagyobb.Name = "RadioButton_nagyobb";
            this.RadioButton_nagyobb.Size = new System.Drawing.Size(167, 17);
            this.RadioButton_nagyobb.TabIndex = 0;
            this.RadioButton_nagyobb.TabStop = true;
            this.RadioButton_nagyobb.Text = "100.000-nél nagyobb Területű";
            this.RadioButton_nagyobb.UseVisualStyleBackColor = true;
            // 
            // RadioButton_kisebb
            // 
            this.RadioButton_kisebb.AutoSize = true;
            this.RadioButton_kisebb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButton_kisebb.Location = new System.Drawing.Point(7, 58);
            this.RadioButton_kisebb.Name = "RadioButton_kisebb";
            this.RadioButton_kisebb.Size = new System.Drawing.Size(154, 17);
            this.RadioButton_kisebb.TabIndex = 1;
            this.RadioButton_kisebb.TabStop = true;
            this.RadioButton_kisebb.Text = "legfejlebb 100.000 Területű";
            this.RadioButton_kisebb.UseVisualStyleBackColor = true;
            // 
            // Button_megszamolas
            // 
            this.Button_megszamolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_megszamolas.Location = new System.Drawing.Point(330, 138);
            this.Button_megszamolas.Margin = new System.Windows.Forms.Padding(2);
            this.Button_megszamolas.Name = "Button_megszamolas";
            this.Button_megszamolas.Size = new System.Drawing.Size(200, 24);
            this.Button_megszamolas.TabIndex = 6;
            this.Button_megszamolas.Text = "Megszámolás";
            this.Button_megszamolas.UseVisualStyleBackColor = true;
            // 
            // Label_eredmeny
            // 
            this.Label_eredmeny.AutoSize = true;
            this.Label_eredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_eredmeny.Location = new System.Drawing.Point(330, 171);
            this.Label_eredmeny.Name = "Label_eredmeny";
            this.Label_eredmeny.Size = new System.Drawing.Size(172, 24);
            this.Label_eredmeny.TabIndex = 7;
            this.Label_eredmeny.Text = "Eredményfájl neve:";
            // 
            // TextBox_eredmeny
            // 
            this.TextBox_eredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBox_eredmeny.Location = new System.Drawing.Point(330, 209);
            this.TextBox_eredmeny.Name = "TextBox_eredmeny";
            this.TextBox_eredmeny.Size = new System.Drawing.Size(200, 26);
            this.TextBox_eredmeny.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox1.Location = new System.Drawing.Point(330, 323);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 26);
            this.comboBox1.TabIndex = 9;
            // 
            // Button_kiiras
            // 
            this.Button_kiiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_kiiras.Location = new System.Drawing.Point(330, 250);
            this.Button_kiiras.Margin = new System.Windows.Forms.Padding(2);
            this.Button_kiiras.Name = "Button_kiiras";
            this.Button_kiiras.Size = new System.Drawing.Size(200, 24);
            this.Button_kiiras.TabIndex = 10;
            this.Button_kiiras.Text = "Ki írás";
            this.Button_kiiras.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(333, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Minimum vagy Maximum?";
            // 
            // Buttom_maximum_minimum
            // 
            this.Buttom_maximum_minimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buttom_maximum_minimum.Location = new System.Drawing.Point(330, 363);
            this.Buttom_maximum_minimum.Margin = new System.Windows.Forms.Padding(2);
            this.Buttom_maximum_minimum.Name = "Buttom_maximum_minimum";
            this.Buttom_maximum_minimum.Size = new System.Drawing.Size(200, 24);
            this.Buttom_maximum_minimum.TabIndex = 12;
            this.Buttom_maximum_minimum.Text = "Minimum/Maximum kiválsztása";
            this.Buttom_maximum_minimum.UseVisualStyleBackColor = true;
            // 
            // Label_orszag
            // 
            this.Label_orszag.AutoSize = true;
            this.Label_orszag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_orszag.Location = new System.Drawing.Point(330, 409);
            this.Label_orszag.Name = "Label_orszag";
            this.Label_orszag.Size = new System.Drawing.Size(133, 20);
            this.Label_orszag.TabIndex = 13;
            this.Label_orszag.Text = "Ország keresése:";
            // 
            // TextBox_orszagkereses
            // 
            this.TextBox_orszagkereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBox_orszagkereses.Location = new System.Drawing.Point(330, 441);
            this.TextBox_orszagkereses.Name = "TextBox_orszagkereses";
            this.TextBox_orszagkereses.Size = new System.Drawing.Size(200, 26);
            this.TextBox_orszagkereses.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(330, 473);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(210, 22);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Találatok kijelölése a listába";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Button_Kereses
            // 
            this.Button_Kereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Kereses.Location = new System.Drawing.Point(330, 526);
            this.Button_Kereses.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Kereses.Name = "Button_Kereses";
            this.Button_Kereses.Size = new System.Drawing.Size(200, 24);
            this.Button_Kereses.TabIndex = 16;
            this.Button_Kereses.Text = "Keresés";
            this.Button_Kereses.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_teruletekatlaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1306, 714);
            this.Controls.Add(this.Button_Kereses);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TextBox_orszagkereses);
            this.Controls.Add(this.Label_orszag);
            this.Controls.Add(this.Buttom_maximum_minimum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_kiiras);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextBox_eredmeny);
            this.Controls.Add(this.Label_eredmeny);
            this.Controls.Add(this.Button_megszamolas);
            this.Controls.Add(this.GroupBox_szamol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListBox_orszagok);
            this.Controls.Add(this.Button_Betoltes);
            this.Controls.Add(this.TextBox_Forrasfajl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form_teruletekatlaga";
            this.Text = "Példa Windows Form Alkalmazás";
            this.GroupBox_szamol.ResumeLayout(false);
            this.GroupBox_szamol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Forrasfajl;
        private System.Windows.Forms.Button Button_Betoltes;
        private System.Windows.Forms.ListBox ListBox_orszagok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GroupBox_szamol;
        private System.Windows.Forms.RadioButton RadioButton_kisebb;
        private System.Windows.Forms.RadioButton RadioButton_nagyobb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Button_megszamolas;
        private System.Windows.Forms.Label Label_eredmeny;
        private System.Windows.Forms.TextBox TextBox_eredmeny;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Button_kiiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buttom_maximum_minimum;
        private System.Windows.Forms.Label Label_orszag;
        private System.Windows.Forms.TextBox TextBox_orszagkereses;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Button_Kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


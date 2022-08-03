namespace ECF_UNTEL_MILLETRE.ui
{
    partial class FrmHome
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
            this.lbProcessorList = new System.Windows.Forms.ListBox();
            this.gbProcessorList = new System.Windows.Forms.GroupBox();
            this.gbProcessorSpecs = new System.Windows.Forms.GroupBox();
            this.gbFamilySpecs = new System.Windows.Forms.GroupBox();
            this.lReferency = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lFrequency = new System.Windows.Forms.Label();
            this.lReleaseDate = new System.Windows.Forms.Label();
            this.lFamilyName = new System.Windows.Forms.Label();
            this.lFamilyArch = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.gbProcessorList.SuspendLayout();
            this.gbProcessorSpecs.SuspendLayout();
            this.gbFamilySpecs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProcessorList
            // 
            this.lbProcessorList.FormattingEnabled = true;
            this.lbProcessorList.ItemHeight = 15;
            this.lbProcessorList.Location = new System.Drawing.Point(6, 22);
            this.lbProcessorList.Name = "lbProcessorList";
            this.lbProcessorList.Size = new System.Drawing.Size(188, 154);
            this.lbProcessorList.TabIndex = 0;
            // 
            // gbProcessorList
            // 
            this.gbProcessorList.Controls.Add(this.lbProcessorList);
            this.gbProcessorList.Location = new System.Drawing.Point(12, 12);
            this.gbProcessorList.Name = "gbProcessorList";
            this.gbProcessorList.Size = new System.Drawing.Size(200, 187);
            this.gbProcessorList.TabIndex = 2;
            this.gbProcessorList.TabStop = false;
            this.gbProcessorList.Text = "Modèles";
            // 
            // gbProcessorSpecs
            // 
            this.gbProcessorSpecs.Controls.Add(this.textBox6);
            this.gbProcessorSpecs.Controls.Add(this.textBox5);
            this.gbProcessorSpecs.Controls.Add(this.textBox4);
            this.gbProcessorSpecs.Controls.Add(this.textBox3);
            this.gbProcessorSpecs.Controls.Add(this.textBox2);
            this.gbProcessorSpecs.Controls.Add(this.lPrice);
            this.gbProcessorSpecs.Controls.Add(this.lReleaseDate);
            this.gbProcessorSpecs.Controls.Add(this.lFrequency);
            this.gbProcessorSpecs.Controls.Add(this.lName);
            this.gbProcessorSpecs.Controls.Add(this.lReferency);
            this.gbProcessorSpecs.Location = new System.Drawing.Point(218, 12);
            this.gbProcessorSpecs.Name = "gbProcessorSpecs";
            this.gbProcessorSpecs.Size = new System.Drawing.Size(294, 187);
            this.gbProcessorSpecs.TabIndex = 0;
            this.gbProcessorSpecs.TabStop = false;
            this.gbProcessorSpecs.Text = "Spécifications";
            // 
            // gbFamilySpecs
            // 
            this.gbFamilySpecs.Controls.Add(this.textBox7);
            this.gbFamilySpecs.Controls.Add(this.lFamilyName);
            this.gbFamilySpecs.Controls.Add(this.lFamilyArch);
            this.gbFamilySpecs.Controls.Add(this.textBox1);
            this.gbFamilySpecs.Location = new System.Drawing.Point(518, 12);
            this.gbFamilySpecs.Name = "gbFamilySpecs";
            this.gbFamilySpecs.Size = new System.Drawing.Size(181, 86);
            this.gbFamilySpecs.TabIndex = 0;
            this.gbFamilySpecs.TabStop = false;
            this.gbFamilySpecs.Text = "Famille";
            // 
            // lReferency
            // 
            this.lReferency.AutoSize = true;
            this.lReferency.Location = new System.Drawing.Point(6, 49);
            this.lReferency.Name = "lReferency";
            this.lReferency.Size = new System.Drawing.Size(59, 15);
            this.lReferency.TabIndex = 0;
            this.lReferency.Text = "Référence";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(6, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(34, 15);
            this.lName.TabIndex = 1;
            this.lName.Text = "Nom";
            // 
            // lFrequency
            // 
            this.lFrequency.AutoSize = true;
            this.lFrequency.Location = new System.Drawing.Point(6, 78);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(62, 15);
            this.lFrequency.TabIndex = 2;
            this.lFrequency.Text = "Fréquence";
            // 
            // lReleaseDate
            // 
            this.lReleaseDate.AutoSize = true;
            this.lReleaseDate.Location = new System.Drawing.Point(6, 107);
            this.lReleaseDate.Name = "lReleaseDate";
            this.lReleaseDate.Size = new System.Drawing.Size(79, 15);
            this.lReleaseDate.TabIndex = 3;
            this.lReleaseDate.Text = "Date de sortie";
            // 
            // lFamilyName
            // 
            this.lFamilyName.AutoSize = true;
            this.lFamilyName.Location = new System.Drawing.Point(6, 22);
            this.lFamilyName.Name = "lFamilyName";
            this.lFamilyName.Size = new System.Drawing.Size(34, 15);
            this.lFamilyName.TabIndex = 4;
            this.lFamilyName.Text = "Nom";
            // 
            // lFamilyArch
            // 
            this.lFamilyArch.AutoSize = true;
            this.lFamilyArch.Location = new System.Drawing.Point(6, 49);
            this.lFamilyArch.Name = "lFamilyArch";
            this.lFamilyArch.Size = new System.Drawing.Size(72, 15);
            this.lFamilyArch.TabIndex = 5;
            this.lFamilyArch.Text = "Architecture";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(6, 136);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(82, 15);
            this.lPrice.TabIndex = 4;
            this.lPrice.Text = "Prix catalogue";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(65, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(164, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(164, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(164, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(103, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(164, 23);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(103, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(164, 23);
            this.textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(85, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(65, 23);
            this.textBox7.TabIndex = 6;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 217);
            this.Controls.Add(this.gbProcessorSpecs);
            this.Controls.Add(this.gbFamilySpecs);
            this.Controls.Add(this.gbProcessorList);
            this.Name = "FrmHome";
            this.Text = "Liste des micro-proceseurs";
            this.gbProcessorList.ResumeLayout(false);
            this.gbProcessorSpecs.ResumeLayout(false);
            this.gbProcessorSpecs.PerformLayout();
            this.gbFamilySpecs.ResumeLayout(false);
            this.gbFamilySpecs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbProcessorList;
        private GroupBox gbProcessorList;
        private GroupBox gbProcessorSpecs;
        private Label lReferency;
        private GroupBox gbFamilySpecs;
        private Label lReleaseDate;
        private Label lFrequency;
        private Label lName;
        private Label lFamilyName;
        private Label lFamilyArch;
        private Label lPrice;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox7;
        private TextBox textBox1;
    }
}
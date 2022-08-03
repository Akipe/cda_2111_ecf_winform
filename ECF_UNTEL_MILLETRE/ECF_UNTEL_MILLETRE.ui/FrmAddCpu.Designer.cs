namespace ECF_UNTEL_MILLETRE.ui
{
    partial class FrmAddCpu
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
            this.bAdd = new System.Windows.Forms.Button();
            this.gbProcessorSpecs = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lProcRefMsg = new System.Windows.Forms.Label();
            this.lProcNameMsg = new System.Windows.Forms.Label();
            this.lProcPriceMsg = new System.Windows.Forms.Label();
            this.lProcReleaseDateMsg = new System.Windows.Forms.Label();
            this.lProcFrecMsg = new System.Windows.Forms.Label();
            this.tbProcReleaseDate = new System.Windows.Forms.TextBox();
            this.tbProcName = new System.Windows.Forms.TextBox();
            this.tbProcRef = new System.Windows.Forms.TextBox();
            this.tbProcFrec = new System.Windows.Forms.TextBox();
            this.tbProcPrice = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.lReleaseDate = new System.Windows.Forms.Label();
            this.lFrequency = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lReferency = new System.Windows.Forms.Label();
            this.gbFamilySpecs = new System.Windows.Forms.GroupBox();
            this.cbFamilyArch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lFamArchMsg = new System.Windows.Forms.Label();
            this.lFamNameMsg = new System.Windows.Forms.Label();
            this.lFamilyName = new System.Windows.Forms.Label();
            this.lFamilyArch = new System.Windows.Forms.Label();
            this.tbFamilyName = new System.Windows.Forms.TextBox();
            this.BClose = new System.Windows.Forms.Button();
            this.lCorporationInfo = new System.Windows.Forms.Label();
            this.gbProcessorSpecs.SuspendLayout();
            this.gbFamilySpecs.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAdd.Location = new System.Drawing.Point(714, 216);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(76, 35);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Valider";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // gbProcessorSpecs
            // 
            this.gbProcessorSpecs.Controls.Add(this.label5);
            this.gbProcessorSpecs.Controls.Add(this.label4);
            this.gbProcessorSpecs.Controls.Add(this.label3);
            this.gbProcessorSpecs.Controls.Add(this.label2);
            this.gbProcessorSpecs.Controls.Add(this.label1);
            this.gbProcessorSpecs.Controls.Add(this.lProcRefMsg);
            this.gbProcessorSpecs.Controls.Add(this.lProcNameMsg);
            this.gbProcessorSpecs.Controls.Add(this.lProcPriceMsg);
            this.gbProcessorSpecs.Controls.Add(this.lProcReleaseDateMsg);
            this.gbProcessorSpecs.Controls.Add(this.lProcFrecMsg);
            this.gbProcessorSpecs.Controls.Add(this.tbProcReleaseDate);
            this.gbProcessorSpecs.Controls.Add(this.tbProcName);
            this.gbProcessorSpecs.Controls.Add(this.tbProcRef);
            this.gbProcessorSpecs.Controls.Add(this.tbProcFrec);
            this.gbProcessorSpecs.Controls.Add(this.tbProcPrice);
            this.gbProcessorSpecs.Controls.Add(this.lPrice);
            this.gbProcessorSpecs.Controls.Add(this.lReleaseDate);
            this.gbProcessorSpecs.Controls.Add(this.lFrequency);
            this.gbProcessorSpecs.Controls.Add(this.lName);
            this.gbProcessorSpecs.Controls.Add(this.lReferency);
            this.gbProcessorSpecs.Location = new System.Drawing.Point(12, 12);
            this.gbProcessorSpecs.Name = "gbProcessorSpecs";
            this.gbProcessorSpecs.Size = new System.Drawing.Size(494, 297);
            this.gbProcessorSpecs.TabIndex = 4;
            this.gbProcessorSpecs.TabStop = false;
            this.gbProcessorSpecs.Text = "Spécifications";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(270, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "nombre avec au max 2 décimales, virgule ou point";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "date au format jour/mois/année (ex: 21/04/2020)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(273, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "nombre avec au max 4 decimales, virgule ou point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(273, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "4 chiffres et 1 lettre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "lettre uniquement, sans espace";
            // 
            // lProcRefMsg
            // 
            this.lProcRefMsg.AutoSize = true;
            this.lProcRefMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProcRefMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lProcRefMsg.Location = new System.Drawing.Point(11, 100);
            this.lProcRefMsg.Name = "lProcRefMsg";
            this.lProcRefMsg.Size = new System.Drawing.Size(0, 15);
            this.lProcRefMsg.TabIndex = 12;
            // 
            // lProcNameMsg
            // 
            this.lProcNameMsg.AutoSize = true;
            this.lProcNameMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProcNameMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lProcNameMsg.Location = new System.Drawing.Point(11, 45);
            this.lProcNameMsg.Name = "lProcNameMsg";
            this.lProcNameMsg.Size = new System.Drawing.Size(0, 15);
            this.lProcNameMsg.TabIndex = 11;
            // 
            // lProcPriceMsg
            // 
            this.lProcPriceMsg.AutoSize = true;
            this.lProcPriceMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProcPriceMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lProcPriceMsg.Location = new System.Drawing.Point(11, 268);
            this.lProcPriceMsg.Name = "lProcPriceMsg";
            this.lProcPriceMsg.Size = new System.Drawing.Size(0, 15);
            this.lProcPriceMsg.TabIndex = 8;
            // 
            // lProcReleaseDateMsg
            // 
            this.lProcReleaseDateMsg.AutoSize = true;
            this.lProcReleaseDateMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProcReleaseDateMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lProcReleaseDateMsg.Location = new System.Drawing.Point(11, 215);
            this.lProcReleaseDateMsg.Name = "lProcReleaseDateMsg";
            this.lProcReleaseDateMsg.Size = new System.Drawing.Size(0, 15);
            this.lProcReleaseDateMsg.TabIndex = 9;
            // 
            // lProcFrecMsg
            // 
            this.lProcFrecMsg.AutoSize = true;
            this.lProcFrecMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProcFrecMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lProcFrecMsg.Location = new System.Drawing.Point(11, 159);
            this.lProcFrecMsg.Name = "lProcFrecMsg";
            this.lProcFrecMsg.Size = new System.Drawing.Size(0, 15);
            this.lProcFrecMsg.TabIndex = 10;
            // 
            // tbProcReleaseDate
            // 
            this.tbProcReleaseDate.Location = new System.Drawing.Point(100, 189);
            this.tbProcReleaseDate.Name = "tbProcReleaseDate";
            this.tbProcReleaseDate.Size = new System.Drawing.Size(164, 23);
            this.tbProcReleaseDate.TabIndex = 3;
            this.tbProcReleaseDate.Text = "10/10/1990";
            // 
            // tbProcName
            // 
            this.tbProcName.Location = new System.Drawing.Point(103, 19);
            this.tbProcName.Name = "tbProcName";
            this.tbProcName.Size = new System.Drawing.Size(164, 23);
            this.tbProcName.TabIndex = 0;
            this.tbProcName.Text = "Ector";
            // 
            // tbProcRef
            // 
            this.tbProcRef.Location = new System.Drawing.Point(103, 74);
            this.tbProcRef.Name = "tbProcRef";
            this.tbProcRef.Size = new System.Drawing.Size(164, 23);
            this.tbProcRef.TabIndex = 1;
            this.tbProcRef.Text = "1000A";
            // 
            // tbProcFrec
            // 
            this.tbProcFrec.Location = new System.Drawing.Point(103, 133);
            this.tbProcFrec.Name = "tbProcFrec";
            this.tbProcFrec.Size = new System.Drawing.Size(164, 23);
            this.tbProcFrec.TabIndex = 2;
            this.tbProcFrec.Text = "2,7";
            // 
            // tbProcPrice
            // 
            this.tbProcPrice.Location = new System.Drawing.Point(100, 242);
            this.tbProcPrice.Name = "tbProcPrice";
            this.tbProcPrice.Size = new System.Drawing.Size(164, 23);
            this.tbProcPrice.TabIndex = 4;
            this.tbProcPrice.Text = "245";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(3, 245);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(82, 15);
            this.lPrice.TabIndex = 4;
            this.lPrice.Text = "Prix catalogue";
            // 
            // lReleaseDate
            // 
            this.lReleaseDate.AutoSize = true;
            this.lReleaseDate.Location = new System.Drawing.Point(3, 192);
            this.lReleaseDate.Name = "lReleaseDate";
            this.lReleaseDate.Size = new System.Drawing.Size(79, 15);
            this.lReleaseDate.TabIndex = 3;
            this.lReleaseDate.Text = "Date de sortie";
            // 
            // lFrequency
            // 
            this.lFrequency.AutoSize = true;
            this.lFrequency.Location = new System.Drawing.Point(6, 136);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(62, 15);
            this.lFrequency.TabIndex = 2;
            this.lFrequency.Text = "Fréquence";
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
            // lReferency
            // 
            this.lReferency.AutoSize = true;
            this.lReferency.Location = new System.Drawing.Point(6, 77);
            this.lReferency.Name = "lReferency";
            this.lReferency.Size = new System.Drawing.Size(59, 15);
            this.lReferency.TabIndex = 0;
            this.lReferency.Text = "Référence";
            // 
            // gbFamilySpecs
            // 
            this.gbFamilySpecs.Controls.Add(this.cbFamilyArch);
            this.gbFamilySpecs.Controls.Add(this.label6);
            this.gbFamilySpecs.Controls.Add(this.lFamArchMsg);
            this.gbFamilySpecs.Controls.Add(this.lFamNameMsg);
            this.gbFamilySpecs.Controls.Add(this.lFamilyName);
            this.gbFamilySpecs.Controls.Add(this.lFamilyArch);
            this.gbFamilySpecs.Controls.Add(this.tbFamilyName);
            this.gbFamilySpecs.Location = new System.Drawing.Point(512, 12);
            this.gbFamilySpecs.Name = "gbFamilySpecs";
            this.gbFamilySpecs.Size = new System.Drawing.Size(354, 130);
            this.gbFamilySpecs.TabIndex = 5;
            this.gbFamilySpecs.TabStop = false;
            this.gbFamilySpecs.Text = "Famille";
            // 
            // cbFamilyArch
            // 
            this.cbFamilyArch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamilyArch.FormattingEnabled = true;
            this.cbFamilyArch.Items.AddRange(new object[] {
            "x86",
            "x64"});
            this.cbFamilyArch.Location = new System.Drawing.Point(85, 69);
            this.cbFamilyArch.Name = "cbFamilyArch";
            this.cbFamilyArch.Size = new System.Drawing.Size(65, 23);
            this.cbFamilyArch.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(156, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "lettre uniquement, sans espace";
            // 
            // lFamArchMsg
            // 
            this.lFamArchMsg.AutoSize = true;
            this.lFamArchMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lFamArchMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lFamArchMsg.Location = new System.Drawing.Point(12, 95);
            this.lFamArchMsg.Name = "lFamArchMsg";
            this.lFamArchMsg.Size = new System.Drawing.Size(0, 15);
            this.lFamArchMsg.TabIndex = 11;
            // 
            // lFamNameMsg
            // 
            this.lFamNameMsg.AutoSize = true;
            this.lFamNameMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lFamNameMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lFamNameMsg.Location = new System.Drawing.Point(12, 45);
            this.lFamNameMsg.Name = "lFamNameMsg";
            this.lFamNameMsg.Size = new System.Drawing.Size(0, 15);
            this.lFamNameMsg.TabIndex = 12;
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
            this.lFamilyArch.Location = new System.Drawing.Point(6, 72);
            this.lFamilyArch.Name = "lFamilyArch";
            this.lFamilyArch.Size = new System.Drawing.Size(72, 15);
            this.lFamilyArch.TabIndex = 5;
            this.lFamilyArch.Text = "Architecture";
            // 
            // tbFamilyName
            // 
            this.tbFamilyName.Location = new System.Drawing.Point(85, 19);
            this.tbFamilyName.Name = "tbFamilyName";
            this.tbFamilyName.Size = new System.Drawing.Size(65, 23);
            this.tbFamilyName.TabIndex = 5;
            this.tbFamilyName.Text = "LAKE";
            // 
            // BClose
            // 
            this.BClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BClose.Location = new System.Drawing.Point(585, 216);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(76, 35);
            this.BClose.TabIndex = 8;
            this.BClose.Text = "Fermer";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // lCorporationInfo
            // 
            this.lCorporationInfo.AutoSize = true;
            this.lCorporationInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lCorporationInfo.Location = new System.Drawing.Point(796, 296);
            this.lCorporationInfo.Name = "lCorporationInfo";
            this.lCorporationInfo.Size = new System.Drawing.Size(69, 13);
            this.lCorporationInfo.TabIndex = 8;
            this.lCorporationInfo.Text = "Untel - 2022";
            // 
            // FrmAddCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 318);
            this.Controls.Add(this.lCorporationInfo);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.gbProcessorSpecs);
            this.Controls.Add(this.gbFamilySpecs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmAddCpu";
            this.Text = "Ajout d\'un processeur - Untel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddCpu_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddCpu_Load);
            this.gbProcessorSpecs.ResumeLayout(false);
            this.gbProcessorSpecs.PerformLayout();
            this.gbFamilySpecs.ResumeLayout(false);
            this.gbFamilySpecs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bAdd;
        private GroupBox gbProcessorSpecs;
        private TextBox tbProcReleaseDate;
        private TextBox tbProcName;
        private TextBox tbProcRef;
        private TextBox tbProcFrec;
        private TextBox tbProcPrice;
        private Label lPrice;
        private Label lReleaseDate;
        private Label lFrequency;
        private Label lName;
        private Label lReferency;
        private GroupBox gbFamilySpecs;
        private Label lFamilyName;
        private Label lFamilyArch;
        private TextBox tbFamilyName;
        private Button BClose;
        private Label lProcNameMsg;
        private Label lProcRefMsg;
        private Label lProcPriceMsg;
        private Label lProcReleaseDateMsg;
        private Label lProcFrecMsg;
        private Label lFamArchMsg;
        private Label lFamNameMsg;
        private Label lCorporationInfo;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private ComboBox cbFamilyArch;
    }
}
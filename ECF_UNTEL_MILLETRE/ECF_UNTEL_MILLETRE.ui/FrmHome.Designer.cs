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
            this.tbFamilyArch = new System.Windows.Forms.TextBox();
            this.lFamilyName = new System.Windows.Forms.Label();
            this.lFamilyArch = new System.Windows.Forms.Label();
            this.tbFamilyName = new System.Windows.Forms.TextBox();
            this.bAddProc = new System.Windows.Forms.Button();
            this.tbFamilyId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbProcessorList.SelectedIndexChanged += new System.EventHandler(this.lbProcessorList_ProcSelectChanged);
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
            this.gbProcessorSpecs.Location = new System.Drawing.Point(218, 12);
            this.gbProcessorSpecs.Name = "gbProcessorSpecs";
            this.gbProcessorSpecs.Size = new System.Drawing.Size(294, 187);
            this.gbProcessorSpecs.TabIndex = 0;
            this.gbProcessorSpecs.TabStop = false;
            this.gbProcessorSpecs.Text = "Spécifications";
            // 
            // tbProcReleaseDate
            // 
            this.tbProcReleaseDate.Location = new System.Drawing.Point(103, 104);
            this.tbProcReleaseDate.Name = "tbProcReleaseDate";
            this.tbProcReleaseDate.ReadOnly = true;
            this.tbProcReleaseDate.Size = new System.Drawing.Size(164, 23);
            this.tbProcReleaseDate.TabIndex = 10;
            // 
            // tbProcName
            // 
            this.tbProcName.Location = new System.Drawing.Point(103, 19);
            this.tbProcName.Name = "tbProcName";
            this.tbProcName.ReadOnly = true;
            this.tbProcName.Size = new System.Drawing.Size(164, 23);
            this.tbProcName.TabIndex = 9;
            // 
            // tbProcRef
            // 
            this.tbProcRef.Location = new System.Drawing.Point(103, 46);
            this.tbProcRef.Name = "tbProcRef";
            this.tbProcRef.ReadOnly = true;
            this.tbProcRef.Size = new System.Drawing.Size(164, 23);
            this.tbProcRef.TabIndex = 8;
            // 
            // tbProcFrec
            // 
            this.tbProcFrec.Location = new System.Drawing.Point(103, 75);
            this.tbProcFrec.Name = "tbProcFrec";
            this.tbProcFrec.ReadOnly = true;
            this.tbProcFrec.Size = new System.Drawing.Size(164, 23);
            this.tbProcFrec.TabIndex = 7;
            // 
            // tbProcPrice
            // 
            this.tbProcPrice.Location = new System.Drawing.Point(103, 133);
            this.tbProcPrice.Name = "tbProcPrice";
            this.tbProcPrice.ReadOnly = true;
            this.tbProcPrice.Size = new System.Drawing.Size(164, 23);
            this.tbProcPrice.TabIndex = 6;
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
            // lReleaseDate
            // 
            this.lReleaseDate.AutoSize = true;
            this.lReleaseDate.Location = new System.Drawing.Point(6, 107);
            this.lReleaseDate.Name = "lReleaseDate";
            this.lReleaseDate.Size = new System.Drawing.Size(79, 15);
            this.lReleaseDate.TabIndex = 3;
            this.lReleaseDate.Text = "Date de sortie";
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
            this.lReferency.Location = new System.Drawing.Point(6, 49);
            this.lReferency.Name = "lReferency";
            this.lReferency.Size = new System.Drawing.Size(59, 15);
            this.lReferency.TabIndex = 0;
            this.lReferency.Text = "Référence";
            // 
            // gbFamilySpecs
            // 
            this.gbFamilySpecs.Controls.Add(this.tbFamilyId);
            this.gbFamilySpecs.Controls.Add(this.label1);
            this.gbFamilySpecs.Controls.Add(this.tbFamilyArch);
            this.gbFamilySpecs.Controls.Add(this.lFamilyName);
            this.gbFamilySpecs.Controls.Add(this.lFamilyArch);
            this.gbFamilySpecs.Controls.Add(this.tbFamilyName);
            this.gbFamilySpecs.Location = new System.Drawing.Point(518, 12);
            this.gbFamilySpecs.Name = "gbFamilySpecs";
            this.gbFamilySpecs.Size = new System.Drawing.Size(181, 110);
            this.gbFamilySpecs.TabIndex = 0;
            this.gbFamilySpecs.TabStop = false;
            this.gbFamilySpecs.Text = "Famille";
            // 
            // tbFamilyArch
            // 
            this.tbFamilyArch.Location = new System.Drawing.Point(85, 46);
            this.tbFamilyArch.Name = "tbFamilyArch";
            this.tbFamilyArch.ReadOnly = true;
            this.tbFamilyArch.Size = new System.Drawing.Size(65, 23);
            this.tbFamilyArch.TabIndex = 6;
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
            // tbFamilyName
            // 
            this.tbFamilyName.Location = new System.Drawing.Point(85, 19);
            this.tbFamilyName.Name = "tbFamilyName";
            this.tbFamilyName.ReadOnly = true;
            this.tbFamilyName.Size = new System.Drawing.Size(65, 23);
            this.tbFamilyName.TabIndex = 5;
            // 
            // bAddProc
            // 
            this.bAddProc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddProc.Location = new System.Drawing.Point(568, 128);
            this.bAddProc.Name = "bAddProc";
            this.bAddProc.Size = new System.Drawing.Size(110, 53);
            this.bAddProc.TabIndex = 3;
            this.bAddProc.Text = "Ajouter nouveau";
            this.bAddProc.UseVisualStyleBackColor = true;
            this.bAddProc.Click += new System.EventHandler(this.bAddProc_Click);
            // 
            // tbFamilyId
            // 
            this.tbFamilyId.Location = new System.Drawing.Point(85, 75);
            this.tbFamilyId.Name = "tbFamilyId";
            this.tbFamilyId.ReadOnly = true;
            this.tbFamilyId.Size = new System.Drawing.Size(65, 23);
            this.tbFamilyId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 217);
            this.Controls.Add(this.bAddProc);
            this.Controls.Add(this.gbProcessorSpecs);
            this.Controls.Add(this.gbFamilySpecs);
            this.Controls.Add(this.gbProcessorList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.Text = "Liste des micro-proceseurs";
            this.Load += new System.EventHandler(this.FrmHome_Load);
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
        private TextBox tbProcReleaseDate;
        private TextBox tbProcName;
        private TextBox tbProcRef;
        private TextBox tbProcFrec;
        private TextBox tbProcPrice;
        private TextBox tbFamilyArch;
        private TextBox tbFamilyName;
        private Button bAddProc;
        private TextBox tbFamilyId;
        private Label label1;
    }
}
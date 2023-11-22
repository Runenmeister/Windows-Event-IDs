
namespace Windows_Event_IDs
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.CbDanger = new System.Windows.Forms.ComboBox();
            this.TbLegacyID = new System.Windows.Forms.TextBox();
            this.TbAktWinID = new System.Windows.Forms.TextBox();
            this.DgvIDs = new System.Windows.Forms.DataGridView();
            this.GbActions = new System.Windows.Forms.GroupBox();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnClearAllFields = new System.Windows.Forms.Button();
            this.BtnLöschen = new System.Windows.Forms.Button();
            this.BtnÄndern = new System.Windows.Forms.Button();
            this.BtnNeu = new System.Windows.Forms.Button();
            this.BtnKontakt = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblDCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIDs)).BeginInit();
            this.GbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Alien Encounters", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows Event IDs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.TbDescription);
            this.panel1.Controls.Add(this.CbDanger);
            this.panel1.Controls.Add(this.TbLegacyID);
            this.panel1.Controls.Add(this.TbAktWinID);
            this.panel1.Location = new System.Drawing.Point(18, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 87);
            this.panel1.TabIndex = 1;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(110, 4);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(524, 76);
            this.TbDescription.TabIndex = 3;
            this.TbDescription.Text = "Description";
            // 
            // CbDanger
            // 
            this.CbDanger.FormattingEnabled = true;
            this.CbDanger.Items.AddRange(new object[] {
            "",
            "Low",
            "Middel",
            "High"});
            this.CbDanger.Location = new System.Drawing.Point(3, 56);
            this.CbDanger.Name = "CbDanger";
            this.CbDanger.Size = new System.Drawing.Size(101, 21);
            this.CbDanger.TabIndex = 2;
            this.CbDanger.Text = "Danger";
            // 
            // TbLegacyID
            // 
            this.TbLegacyID.Location = new System.Drawing.Point(4, 30);
            this.TbLegacyID.Name = "TbLegacyID";
            this.TbLegacyID.Size = new System.Drawing.Size(100, 20);
            this.TbLegacyID.TabIndex = 1;
            this.TbLegacyID.Text = "Legacy ID";
            // 
            // TbAktWinID
            // 
            this.TbAktWinID.Location = new System.Drawing.Point(4, 4);
            this.TbAktWinID.Name = "TbAktWinID";
            this.TbAktWinID.Size = new System.Drawing.Size(100, 20);
            this.TbAktWinID.TabIndex = 0;
            this.TbAktWinID.Text = "Current ID";
            // 
            // DgvIDs
            // 
            this.DgvIDs.AllowUserToAddRows = false;
            this.DgvIDs.AllowUserToDeleteRows = false;
            this.DgvIDs.AllowUserToResizeColumns = false;
            this.DgvIDs.AllowUserToResizeRows = false;
            this.DgvIDs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvIDs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvIDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIDs.Location = new System.Drawing.Point(18, 225);
            this.DgvIDs.MultiSelect = false;
            this.DgvIDs.Name = "DgvIDs";
            this.DgvIDs.ReadOnly = true;
            this.DgvIDs.RowHeadersVisible = false;
            this.DgvIDs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIDs.Size = new System.Drawing.Size(644, 193);
            this.DgvIDs.TabIndex = 2;
            this.DgvIDs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIDs_CellContentClick);
            // 
            // GbActions
            // 
            this.GbActions.BackColor = System.Drawing.Color.LightSlateGray;
            this.GbActions.Controls.Add(this.BtnInfo);
            this.GbActions.Controls.Add(this.BtnClearAllFields);
            this.GbActions.Controls.Add(this.BtnLöschen);
            this.GbActions.Controls.Add(this.BtnÄndern);
            this.GbActions.Controls.Add(this.BtnNeu);
            this.GbActions.Controls.Add(this.BtnKontakt);
            this.GbActions.Controls.Add(this.BtnExit);
            this.GbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbActions.Location = new System.Drawing.Point(18, 179);
            this.GbActions.Name = "GbActions";
            this.GbActions.Size = new System.Drawing.Size(644, 40);
            this.GbActions.TabIndex = 3;
            this.GbActions.TabStop = false;
            this.GbActions.Text = "ACTIONS";
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.Khaki;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnInfo.Location = new System.Drawing.Point(393, 11);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(75, 23);
            this.BtnInfo.TabIndex = 6;
            this.BtnInfo.Text = "INFO";
            this.BtnInfo.UseVisualStyleBackColor = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnClearAllFields
            // 
            this.BtnClearAllFields.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnClearAllFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearAllFields.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnClearAllFields.Location = new System.Drawing.Point(312, 11);
            this.BtnClearAllFields.Name = "BtnClearAllFields";
            this.BtnClearAllFields.Size = new System.Drawing.Size(75, 23);
            this.BtnClearAllFields.TabIndex = 5;
            this.BtnClearAllFields.Text = "Leeren";
            this.BtnClearAllFields.UseVisualStyleBackColor = false;
            this.BtnClearAllFields.Click += new System.EventHandler(this.BtnClearAllFields_Click);
            // 
            // BtnLöschen
            // 
            this.BtnLöschen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLöschen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnLöschen.Location = new System.Drawing.Point(231, 11);
            this.BtnLöschen.Name = "BtnLöschen";
            this.BtnLöschen.Size = new System.Drawing.Size(75, 23);
            this.BtnLöschen.TabIndex = 4;
            this.BtnLöschen.Text = "Löschen";
            this.BtnLöschen.UseVisualStyleBackColor = false;
            this.BtnLöschen.Click += new System.EventHandler(this.BtnLöschen_Click);
            // 
            // BtnÄndern
            // 
            this.BtnÄndern.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnÄndern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnÄndern.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnÄndern.Location = new System.Drawing.Point(150, 11);
            this.BtnÄndern.Name = "BtnÄndern";
            this.BtnÄndern.Size = new System.Drawing.Size(75, 23);
            this.BtnÄndern.TabIndex = 3;
            this.BtnÄndern.Text = "Ändern";
            this.BtnÄndern.UseVisualStyleBackColor = false;
            this.BtnÄndern.Click += new System.EventHandler(this.BtnÄndern_Click);
            // 
            // BtnNeu
            // 
            this.BtnNeu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNeu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnNeu.Location = new System.Drawing.Point(69, 11);
            this.BtnNeu.Name = "BtnNeu";
            this.BtnNeu.Size = new System.Drawing.Size(75, 23);
            this.BtnNeu.TabIndex = 2;
            this.BtnNeu.Text = "Neu";
            this.BtnNeu.UseVisualStyleBackColor = false;
            this.BtnNeu.Click += new System.EventHandler(this.BtnNeu_Click);
            // 
            // BtnKontakt
            // 
            this.BtnKontakt.BackColor = System.Drawing.Color.Khaki;
            this.BtnKontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKontakt.Location = new System.Drawing.Point(478, 11);
            this.BtnKontakt.Name = "BtnKontakt";
            this.BtnKontakt.Size = new System.Drawing.Size(75, 23);
            this.BtnKontakt.TabIndex = 1;
            this.BtnKontakt.Text = "Kontakt";
            this.BtnKontakt.UseVisualStyleBackColor = false;
            this.BtnKontakt.Click += new System.EventHandler(this.BtnKontakt_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Tomato;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(559, 11);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aufstellung aller Event ID´s  für Windows Betriebsysteme.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(410, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wer in der Analyse eine ID findet und nicht weis was sich dahinter verbirgt. Der " +
    "wird hier fündig werden.";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.BackColor = System.Drawing.Color.Transparent;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.ForeColor = System.Drawing.Color.Navy;
            this.LblCount.Location = new System.Drawing.Point(502, 421);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(19, 15);
            this.LblCount.TabIndex = 6;
            this.LblCount.Text = "...";
            // 
            // LblDCount
            // 
            this.LblDCount.AutoSize = true;
            this.LblDCount.BackColor = System.Drawing.Color.Transparent;
            this.LblDCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDCount.ForeColor = System.Drawing.Color.Navy;
            this.LblDCount.Location = new System.Drawing.Point(512, 153);
            this.LblDCount.Name = "LblDCount";
            this.LblDCount.Size = new System.Drawing.Size(19, 15);
            this.LblDCount.TabIndex = 7;
            this.LblDCount.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Event_IDs.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.LblDCount);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GbActions);
            this.Controls.Add(this.DgvIDs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Event ID´s | by Runenmeister (c) 11/2023";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIDs)).EndInit();
            this.GbActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.ComboBox CbDanger;
        private System.Windows.Forms.TextBox TbLegacyID;
        private System.Windows.Forms.TextBox TbAktWinID;
        private System.Windows.Forms.DataGridView DgvIDs;
        private System.Windows.Forms.GroupBox GbActions;
        private System.Windows.Forms.Button BtnLöschen;
        private System.Windows.Forms.Button BtnÄndern;
        private System.Windows.Forms.Button BtnNeu;
        private System.Windows.Forms.Button BtnKontakt;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClearAllFields;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblDCount;
    }
}


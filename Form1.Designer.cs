namespace BackupTool
{
    partial class UiMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UiMain));
            this.mtlConfig = new MetroFramework.Controls.MetroTile();
            this.mtlBackup = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.pnlConfig = new MetroFramework.Controls.MetroPanel();
            this.btnSalvarConfig = new MetroFramework.Controls.MetroButton();
            this.txtDatabase = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtServidor = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.txtDestino = new MetroFramework.Controls.MetroTextBox();
            this.chkDestino = new MetroFramework.Controls.MetroCheckBox();
            this.backupConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFolder = new MetroFramework.Controls.MetroButton();
            this.pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupConfigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtlConfig
            // 
            this.mtlConfig.ActiveControl = null;
            this.mtlConfig.Location = new System.Drawing.Point(23, 95);
            this.mtlConfig.Name = "mtlConfig";
            this.mtlConfig.Size = new System.Drawing.Size(118, 109);
            this.mtlConfig.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtlConfig.TabIndex = 0;
            this.mtlConfig.Text = "Configurações";
            this.mtlConfig.TileImage = ((System.Drawing.Image)(resources.GetObject("mtlConfig.TileImage")));
            this.mtlConfig.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtlConfig.UseSelectable = true;
            this.mtlConfig.UseTileImage = true;
            this.mtlConfig.Click += new System.EventHandler(this.mtlConfig_Click);
            // 
            // mtlBackup
            // 
            this.mtlBackup.ActiveControl = null;
            this.mtlBackup.Location = new System.Drawing.Point(23, 210);
            this.mtlBackup.Name = "mtlBackup";
            this.mtlBackup.Size = new System.Drawing.Size(242, 109);
            this.mtlBackup.TabIndex = 0;
            this.mtlBackup.Text = "Backup";
            this.mtlBackup.UseSelectable = true;
            this.mtlBackup.Click += new System.EventHandler(this.mtlBackup_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(147, 95);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(118, 109);
            this.metroTile3.TabIndex = 0;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.UseSelectable = true;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.btnFolder);
            this.pnlConfig.Controls.Add(this.chkDestino);
            this.pnlConfig.Controls.Add(this.txtDestino);
            this.pnlConfig.Controls.Add(this.btnSalvarConfig);
            this.pnlConfig.Controls.Add(this.txtDatabase);
            this.pnlConfig.Controls.Add(this.metroLabel1);
            this.pnlConfig.Controls.Add(this.txtServidor);
            this.pnlConfig.Controls.Add(this.label1);
            this.pnlConfig.HorizontalScrollbarBarColor = true;
            this.pnlConfig.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlConfig.HorizontalScrollbarSize = 10;
            this.pnlConfig.Location = new System.Drawing.Point(292, 95);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(282, 224);
            this.pnlConfig.TabIndex = 1;
            this.pnlConfig.VerticalScrollbarBarColor = true;
            this.pnlConfig.VerticalScrollbarHighlightOnWheel = false;
            this.pnlConfig.VerticalScrollbarSize = 10;
            // 
            // btnSalvarConfig
            // 
            this.btnSalvarConfig.Location = new System.Drawing.Point(3, 162);
            this.btnSalvarConfig.Name = "btnSalvarConfig";
            this.btnSalvarConfig.Size = new System.Drawing.Size(276, 52);
            this.btnSalvarConfig.TabIndex = 6;
            this.btnSalvarConfig.Text = "Salvar Configuração";
            this.btnSalvarConfig.UseSelectable = true;
            this.btnSalvarConfig.Click += new System.EventHandler(this.btnSalvarConfig_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Lines = new string[] {
        "metroTextBox1"};
            this.txtDatabase.Location = new System.Drawing.Point(3, 84);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.Size = new System.Drawing.Size(276, 23);
            this.txtDatabase.TabIndex = 5;
            this.txtDatabase.Text = "metroTextBox1";
            this.txtDatabase.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Database";
            // 
            // txtServidor
            // 
            this.txtServidor.Lines = new string[] {
        "metroTextBox1"};
            this.txtServidor.Location = new System.Drawing.Point(3, 35);
            this.txtServidor.MaxLength = 32767;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '\0';
            this.txtServidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServidor.SelectedText = "";
            this.txtServidor.Size = new System.Drawing.Size(276, 23);
            this.txtServidor.TabIndex = 3;
            this.txtServidor.Text = "metroTextBox1";
            this.txtServidor.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servidor";
            // 
            // txtDestino
            // 
            this.txtDestino.Lines = new string[0];
            this.txtDestino.Location = new System.Drawing.Point(3, 133);
            this.txtDestino.MaxLength = 32767;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.PasswordChar = '\0';
            this.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDestino.SelectedText = "";
            this.txtDestino.Size = new System.Drawing.Size(233, 23);
            this.txtDestino.TabIndex = 8;
            this.txtDestino.UseSelectable = true;
            // 
            // chkDestino
            // 
            this.chkDestino.AutoSize = true;
            this.chkDestino.Location = new System.Drawing.Point(3, 114);
            this.chkDestino.Name = "chkDestino";
            this.chkDestino.Size = new System.Drawing.Size(126, 15);
            this.chkDestino.TabIndex = 9;
            this.chkDestino.Text = "Pasta Personalizada";
            this.chkDestino.UseSelectable = true;
            this.chkDestino.CheckedChanged += new System.EventHandler(this.chkDestino_CheckedChanged);
            // 
            // backupConfigBindingSource
            // 
            this.backupConfigBindingSource.DataSource = typeof(BackupTool.Config.BackupConfig);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(242, 133);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(37, 23);
            this.btnFolder.TabIndex = 10;
            this.btnFolder.Text = "...";
            this.btnFolder.UseSelectable = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // UiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 375);
            this.Controls.Add(this.pnlConfig);
            this.Controls.Add(this.mtlBackup);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.mtlConfig);
            this.Name = "UiMain";
            this.Text = "Backup Tool";
            this.Load += new System.EventHandler(this.uiMain_Load);
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupConfigBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtlConfig;
        private MetroFramework.Controls.MetroTile mtlBackup;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroPanel pnlConfig;
        private MetroFramework.Controls.MetroButton btnSalvarConfig;
        private MetroFramework.Controls.MetroTextBox txtDatabase;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtServidor;
        private MetroFramework.Controls.MetroLabel label1;
        private System.Windows.Forms.BindingSource backupConfigBindingSource;
        private MetroFramework.Controls.MetroCheckBox chkDestino;
        private MetroFramework.Controls.MetroTextBox txtDestino;
        private MetroFramework.Controls.MetroButton btnFolder;
    }
}


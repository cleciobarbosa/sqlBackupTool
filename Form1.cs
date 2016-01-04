using System;
using System.Drawing;
using System.Windows.Forms;
using BackupTool.Config;
using MetroFramework;

namespace BackupTool
{
    public partial class UiMain : MetroFramework.Forms.MetroForm
    {
        private readonly BackupConfig _config;

        public UiMain()
        {
            InitializeComponent();
            _config = BackupConfig.Load();
        }

        private void uiMain_Load(object sender, EventArgs e)
        {
            pnlConfig.Visible = false;
            txtServidor.Text = _config.Servidor;
            txtDatabase.Text = _config.Database;
            txtDestino.Text = _config.DestinoPersonalizado;
            chkDestino.Checked = _config.UsarDestinoPersonalizado;
        }

        private void btnSalvarConfig_Click(object sender, EventArgs e)
        {
            if (chkDestino.Enabled && string.IsNullOrEmpty(txtDestino.Text))
            {
                MetroMessageBox.Show(this, "Você deve Informar um Diretorio para Salvar os Arquivos.");
                txtDestino.BackColor = Color.Coral;
                txtDestino.Focus();
            }

            pnlConfig.Visible = false;
            _config.Servidor = txtServidor.Text;
            _config.Database = txtDatabase.Text;
            _config.DestinoPersonalizado = txtDestino.Text;
            _config.UsarDestinoPersonalizado = chkDestino.Checked;
            _config.Salvar();
        }

        private void mtlConfig_Click(object sender, EventArgs e)
        {
            pnlConfig.Visible = true;
        }

        private void mtlBackup_Click(object sender, EventArgs e)
        {
            try
            {
                var servidor = new Microsoft.SqlServer.Management.Smo.Server(txtServidor.Text);

                if (_config.UsarDestinoPersonalizado && !string.IsNullOrEmpty(_config.DestinoPersonalizado))
                {
                    servidor.BackupDirectory = _config.DestinoPersonalizado;
                }

                var backup = new Microsoft.SqlServer.Management.Smo.Backup
                {
                    Database = txtDatabase.Text,
                    Incremental = false
                };
                var filename = $"{txtDatabase.Text}_{DateTime.Now:g}.bak";

                backup.Devices.AddDevice(filename, Microsoft.SqlServer.Management.Smo.DeviceType.File);
                backup.SqlBackup(servidor);

                MetroMessageBox.Show(this, $"Backup '{filename}' Concluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void chkDestino_CheckedChanged(object sender, EventArgs e)
        {
            txtDestino.Enabled = chkDestino.Checked;
            btnFolder.Enabled = chkDestino.Checked;

            if (chkDestino.Checked && string.IsNullOrEmpty(txtDestino.Text))
            {
                var folder = new FolderBrowserDialog();
                var result = folder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtDestino.Text = folder.SelectedPath;
                }
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (!chkDestino.Checked) return;

            var folder = new FolderBrowserDialog();
            var result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDestino.Text = folder.SelectedPath;
            }
        }
    }
}

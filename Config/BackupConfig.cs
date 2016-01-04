using System.Xml.Serialization;

namespace BackupTool.Config
{
    [XmlRoot("BackupToolConfig")]
    public class BackupConfig : ConfigBase<BackupConfig>
    {
        public BackupConfig()
        {
            Database = "Database";
            Servidor = "localhost";
            UsarDestinoPersonalizado = false;
        }
        [XmlElement("Servidor")]
        public string Servidor { get; set; }
        [XmlElement("Database")]
        public string Database { get; set; }
        [XmlElement("UsarDiretorio")]
        public bool UsarDestinoPersonalizado { get; set; }

        [XmlElement("Diretorio")]
        public string DestinoPersonalizado { get; set; }

        [XmlIgnore]
        public static BackupConfig Config { get; set; }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace Windows_Event_IDs
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            LoadInfoDocument();
        }

        private void LoadInfoDocument()
        {
            try
            {
                // Der Pfad zum Info.rtf-Dokument im Hauptverzeichnis des Programms
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Info.rtf");

                // Überprüfen, ob die Datei existiert, bevor sie geladen wird
                if (File.Exists(filePath))
                {
                    // Den Inhalt der Datei in das Richtextfeld laden
                    RtbInfo.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    MessageBox.Show("Die Info.rtf-Datei konnte nicht gefunden werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Info.rtf-Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

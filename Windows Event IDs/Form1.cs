using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Windows_Event_IDs
{
    

    public partial class Form1 : Form
    {
        private SqlConnection dbconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Runen\OneDrive\Dokumente\WindowsEventIDs.mdf;Integrated Security=True;Connect Timeout=30");
        private int lastSelectedWEID;

        public Form1()
        {
            InitializeComponent();
            ShowList();
            ClearAllFields();
            // Zähle die Zeilen im DataGridView und aktualisiere das Label
            int rowCount = DgvIDs.Rows.Count;
            LblCount.Text = $"Anzahl der Zeilen: {rowCount}";
            UpdateCharacterCountLabel();
        }

        private void ShowList()
        {
            // Loading Database
            dbconnection.Open();
            string query = "select * from WEID";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, dbconnection);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            DgvIDs.DataSource = dataset.Tables[0];

            // Disable Columns
            DgvIDs.Columns[0].Visible = false;

            // Arrange Columns
            DgvIDs.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvIDs.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvIDs.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvIDs.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvIDs.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvIDs.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dbconnection.Close();
        }

        private void ClearAllFields()
        {
            TbAktWinID.Text = "";
            TbLegacyID.Text = "";
            CbDanger.Text = "";
            TbDescription.Text = "";
        }

        private void ExecuteQuery(string query)
        {
            dbconnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, dbconnection);
            sqlCommand.ExecuteNonQuery();
            dbconnection.Close();
        }

        private void UpdateCharacterCountLabel()
        {
            int characterCount = TbDescription.Text.Length;
            LblDCount.Text = "Character Count: " + characterCount.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNeu_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbAktWinID.Text == "" || TbLegacyID.Text == "")
                {
                    MessageBox.Show("Not all fields have been filled.");
                    return;
                }

                string currentID = TbAktWinID.Text;
                string legacyID = TbLegacyID.Text;
                string danger = CbDanger.Text;
                string description = TbDescription.Text;

                // Überprüfe die Zeicheneingabe-Länge im Feld "TbDescription"
                if (description.Length > 3000)
                {
                    throw new ArgumentException("Zu viele Zeichen im Feld Description.");
                }

                string query = string.Format("insert into WEID values('{0}', '{1}', '{2}', '{3}')",
                    currentID, legacyID, danger, description);

                ExecuteQuery(query);

                // Show List
                ShowList();
                ClearAllFields();
                UpdateCharacterCountLabel();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BtnÄndern_Click(object sender, EventArgs e)
        {
            if (lastSelectedWEID == 0)
            {
                MessageBox.Show("Please select software.");
                return;
            }

            string currentID = TbAktWinID.Text;
            string legacyID = TbLegacyID.Text;
            string danger = CbDanger.Text;
            string description = TbDescription.Text;

            string query = string.Format("update WEID set CurrentID='{0}', LegacyID='{1}', Dangerous='{2}', Description='{3}' where id={4}",
                currentID, legacyID, danger, description, lastSelectedWEID);
            ExecuteQuery(query);

            ShowList();
            ClearAllFields();
        }

        private void BtnLöschen_Click(object sender, EventArgs e)
        {
            if (lastSelectedWEID == 0)
            {
                MessageBox.Show("Please select software.");
                return;
            }

            string query = string.Format("delete from WEID where id={0};", lastSelectedWEID);
            ExecuteQuery(query);

            // Show List
            ShowList();
            ClearAllFields();
        }

        private void BtnKontakt_Click(object sender, EventArgs e)
        {
            string toAddress = "itsupport@mdagehrmann.de";
            string subject = "Kontaktaufnahme: Windows Event IDs";
            string body = "Sehr geehrter Herr Gehrmann,%0D%0A " +
                "ich komme heute auf Sie zu mit einer bestimmten Anfrage. " +
                "%0D%0A" +
                "%0D%0A" +
                "%0D%0A" +
                "Mit freundlichen Grüßen";

            MailMessage mail = new MailMessage();
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;

            try
            {
                System.Diagnostics.Process.Start("mailto:" + toAddress + "?subject="
                + subject + "&body=" + body);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen der E-Mail: " + ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DgvIDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbAktWinID.Text = DgvIDs.SelectedRows[0].Cells[1].Value.ToString();
            TbLegacyID.Text = DgvIDs.SelectedRows[0].Cells[2].Value.ToString();
            CbDanger.Text = DgvIDs.SelectedRows[0].Cells[3].Value.ToString();
            TbDescription.Text = DgvIDs.SelectedRows[0].Cells[4].Value.ToString();

            lastSelectedWEID = (int)DgvIDs.SelectedRows[0].Cells[0].Value;
        }

        private void BtnClearAllFields_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}

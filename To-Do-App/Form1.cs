using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using System.Globalization;

// Leider hatte ich keine Zeit mehr für die CRUD-Funktion "Edit".
// Ich wollte Max jedoch nicht zu viel Zeit für die Dokumentation nehmen.
namespace To_Do_App
{
    public partial class Form1 : Form
    {

        private string dataFilePath = Path.Combine(@"C:\Users\meier\source\repos\To-Do-App\To-Do-App\data\data.csv");//Pfad selber anpassen,konnte nicht herausfinden wie ich diesen Dateipfad hardcoden kann
        public Form1()
        {
            InitializeComponent();

          
            Datenladen();
        }

        private void Datenladen()
        {
            if (File.Exists(dataFilePath))
            {
                List<string[]> gespeichertedaten = new List<string[]>();
                string[] lines = File.ReadAllLines(dataFilePath);

                foreach (string line in lines)
                {
                    gespeichertedaten.Add(line.Split(';'));
                }

                foreach (string[] row in gespeichertedaten)
                {
                    dgv.Rows.Add(row);
                }



            }
        }

        //Die Save Methode wurde mit Hilfe von ChatGPT geschrieben.
        //ChatGPT hat mir bei der Fehlerabfangung geholfen. (try chatch)

        private void SaveData()
        {
            try
            {
                List<string> Datenzuspeichern = new List<string>();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    List<string> rowData = new List<string>();

                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        if (cell.Value != null)
                        {
                            rowData.Add(cell.Value.ToString());
                        }
                        else
                        {

                            rowData.Add("");
                        }
                    }

                    Datenzuspeichern.Add(string.Join(";", rowData));
                }


                string directoryPath = Path.GetDirectoryName(dataFilePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.WriteAllLines(dataFilePath, Datenzuspeichern);

                MessageBox.Show("Daten erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)

        {

            string neueKategorie = comboBox1.Text;

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text) && comboBox1.Text != "Kategorie Auswählen" && dateTimePicker1.Value >= DateTime.Now.AddDays(-1))
            {
                dgv.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text, dateTimePicker1.Text);
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Felder korrekt aus.");
            }




            if (!comboBox1.Items.Contains(neueKategorie))
            {
                comboBox1.Items.Add(neueKategorie);
            }





        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                int letzezeile = dgv.Rows.Count - 1;
                dgv.Rows.RemoveAt(letzezeile);
            }
            else
            {
                MessageBox.Show("Es ist nicht möglich, eine Zeile zu löschen, da keine vorhanden ist.");
            }
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            SaveData();
        }






    }
}
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Form1 : Form
{
    private DatabaseHelper dbHelper;
    private string connectionString = "Server=localhost;Database=vozovy_park;Uid=root;Pwd=;";



    public Form1()
    {
        InitializeComponent();
        dbHelper = new DatabaseHelper();

    }

    // Načítání dat při spuštění formuláře
    private void Form1_Load(object sender, EventArgs e)
    {
        LoadVozidla();
    }

    // Načítání vozidel do DataGridView
    private void LoadVozidla()
    {
        var vozidla = dbHelper.GetVozidla();
        dataGridView1.DataSource = vozidla;
    }

    // Přidání nového vozidla
    private void btnAdd_Click(object sender, EventArgs e)
    {
        Vozidlo newVozidlo = new Vozidlo
        {
            SPZ = txtSPZ.Text,
            Model = txtModel.Text,
            Vyrobce = txtVyrobce.Text,
            Rok = int.Parse(txtRok.Text),
            Stav = txtStav.Text
        };

        dbHelper.AddVozidlo(newVozidlo);
        LoadVozidla();
    }

    // Úprava vybraného vozidla
    private void btnEdit_Click(object sender, EventArgs e)
    {
        // Zkontroluj, zda je nějaký řádek vybrán
        if (dataGridView1.SelectedRows.Count > 0)
        {
            // Získání ID vozidla, které se má upravit
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            // Získání hodnot z textových polí
            string spz = txtSPZ.Text;
            string model = txtModel.Text;
            string vyrobce = txtVyrobce.Text;
            int rok = int.Parse(txtRok.Text); // Ověření, zda je to číslo
            string stav = txtStav.Text;

            // SQL dotaz pro aktualizaci záznamu
            string query = "UPDATE Vozidla SET SPZ = @spz, Model = @model, Vyrobce = @vyrobce, Rok = @rok, Stav = @stav WHERE Id = @id";

            // Vytvoření připojení k databázi
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Přiřazení hodnot parametrů
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@spz", spz);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@vyrobce", vyrobce);
                cmd.Parameters.AddWithValue("@rok", rok);
                cmd.Parameters.AddWithValue("@stav", stav);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); // Provést aktualizaci

                    MessageBox.Show("Záznam byl úspěšně upraven.");
                    RefreshDataGrid(); // Aktualizuj DataGridView, aby ukázal nové hodnoty
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při aktualizaci záznamu: " + ex.Message);
                }
            }
        }
        else
        {
            MessageBox.Show("Vyberte prosím záznam, který chcete upravit.");
        }
    }



    // Mazání vybraného vozidla
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            dbHelper.DeleteVozidlo(id);
            LoadVozidla();
        }
    }

    // Hledání vozidla podle SPZ
    private void btnSearch_Click(object sender, EventArgs e)
    {
        string searchTerm = txtSearch.Text;

        var vozidla = dbHelper.GetVozidla().Where(v => v.SPZ.Contains(searchTerm)).ToList();
        dataGridView1.DataSource = vozidla;
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            // Získání vybraného řádku
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Naplnění textových polí hodnotami z řádku
            txtSPZ.Text = selectedRow.Cells["SPZ"].Value.ToString();
            txtModel.Text = selectedRow.Cells["Model"].Value.ToString();
            txtVyrobce.Text = selectedRow.Cells["Vyrobce"].Value.ToString();
            txtRok.Text = selectedRow.Cells["Rok"].Value.ToString();
            txtStav.Text = selectedRow.Cells["Stav"].Value.ToString();
        }
    }

    private void RefreshDataGrid()
    {
        // Vytvoření SQL dotazu pro získání všech dat
        string query = "SELECT * FROM Vozidla";

        // Vytvoření připojení k databázi
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataTable); // Naplní DataTable s novými daty
                dataGridView1.DataSource = dataTable; // Nastaví nová data do DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}

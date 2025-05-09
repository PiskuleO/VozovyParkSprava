using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

public class DatabaseHelper
{
    private MySqlConnection connection;

    public DatabaseHelper()
    {
        // Zadejte správné připojení k databázi
        string connectionString = "Server=localhost;Database=vozovy_park;Uid=root;Pwd=;";
        connection = new MySqlConnection(connectionString);
    }

    // Načítání vozidel
    public List<Vozidlo> GetVozidla()
    {
        List<Vozidlo> vozidla = new List<Vozidlo>();

        try
        {
            connection.Open();
            string query = "SELECT * FROM vozidla";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Vozidlo vozidlo = new Vozidlo
                {
                    Id = reader.GetInt32("Id"),
                    SPZ = reader.GetString("SPZ"),
                    Model = reader.GetString("Model"),
                    Vyrobce = reader.GetString("Vyrobce"),
                    Rok = reader.GetInt32("Rok"),
                    Stav = reader.GetString("Stav")
                };
                vozidla.Add(vozidlo);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Chyba při načítání vozidel: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }

        return vozidla;
    }

    // Přidání vozidla
    public void AddVozidlo(Vozidlo vozidlo)
    {
        try
        {
            connection.Open();
            string query = "INSERT INTO vozidla (SPZ, Model, Vyrobce, Rok, Stav) VALUES (@SPZ, @Model, @Vyrobce, @Rok, @Stav)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@SPZ", vozidlo.SPZ);
            cmd.Parameters.AddWithValue("@Model", vozidlo.Model);
            cmd.Parameters.AddWithValue("@Vyrobce", vozidlo.Vyrobce);
            cmd.Parameters.AddWithValue("@Rok", vozidlo.Rok);
            cmd.Parameters.AddWithValue("@Stav", vozidlo.Stav);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Chyba při přidávání vozidla: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    // Úprava vozidla
    public void UpdateVozidlo(Vozidlo vozidlo)
    {
        try
        {
            connection.Open();
            string query = "UPDATE vozidla SET SPZ = @SPZ, Model = @Model, Vyrobce = @Vyrobce, Rok = @Rok, Stav = @Stav WHERE Id = @Id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", vozidlo.Id);
            cmd.Parameters.AddWithValue("@SPZ", vozidlo.SPZ);
            cmd.Parameters.AddWithValue("@Model", vozidlo.Model);
            cmd.Parameters.AddWithValue("@Vyrobce", vozidlo.Vyrobce);
            cmd.Parameters.AddWithValue("@Rok", vozidlo.Rok);
            cmd.Parameters.AddWithValue("@Stav", vozidlo.Stav);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Chyba při úpravě vozidla: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    // Smazání vozidla
    public void DeleteVozidlo(int id)
    {
        try
        {
            connection.Open();
            string query = "DELETE FROM vozidla WHERE Id = @Id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Chyba při mazání vozidla: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}

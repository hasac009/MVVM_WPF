using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testMvvm.Model;
using testMvvm.View;

namespace testMvvm.ViewModels
{
   public class Office
    {
        private static NpgsqlConnection connection;

        private static ObservableCollection<Driver> Drivers { get; } = new ObservableCollection<Driver>();

        public Office(string connectString)
        {
            connection = new NpgsqlConnection(connectString);


        }

        public ObservableCollection<Driver> GetAll() 
        {
            Drivers.Clear();
            connection.Open();
            using (var command = new NpgsqlCommand("SELECT * FROM drivers", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Driver driver = new Driver
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            name = reader.GetString(reader.GetOrdinal("name")),
                            phone = reader.GetString(reader.GetOrdinal("phone")),
                            car_id = reader.GetInt32(reader.GetOrdinal("car_id")),
                            status = reader.GetBoolean(reader.GetOrdinal("status"))
                        };
                        if(driver.status)
                            Drivers.Add(driver);
                    }
                }
            }
            connection.Close();
            return Drivers;
        }


        public void Add(Driver newDriver)
        {
            connection.Open();
            using (var command = new NpgsqlCommand(
                "INSERT INTO drivers (name, phone, car_id) VALUES (@name, @phone, @car_id)", connection))
            {
                command.Parameters.AddWithValue("@name", newDriver.name);
                command.Parameters.AddWithValue("@phone", newDriver.phone);
                command.Parameters.AddWithValue("@car_id", newDriver.car_id);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void del(Driver driver)
        {
            connection.Open();
            using (var command = new NpgsqlCommand("UPDATE drivers SET status = false WHERE id = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", driver.id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

    }
}

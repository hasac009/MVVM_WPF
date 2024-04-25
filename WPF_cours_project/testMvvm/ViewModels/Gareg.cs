using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using testMvvm.Model;
using testMvvm.View;

namespace testMvvm.ViewModels
{
    public  class  Gareg 
    {
        private static NpgsqlConnection connection;

        private static ObservableCollection<Car> Cars { get; } = new ObservableCollection<Car>();

        public Gareg(string connectString)
        {
            connection = new NpgsqlConnection(connectString);
           
 
        }

      
       
        public  ObservableCollection<Car> GetAll()
        {
            Cars.Clear();
            connection.Open();
            using (var command = new NpgsqlCommand("SELECT * FROM cars3", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Car car = new Car
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            name = reader.GetString(reader.GetOrdinal("name")),
                            number = reader.GetString(reader.GetOrdinal("number")),
                            ImagePathCar = reader.GetString(reader.GetOrdinal("image")),
                            driver = reader.IsDBNull(reader.GetOrdinal("driver")) ? null : reader.GetString(reader.GetOrdinal("driver")),
                            dataTO = reader.IsDBNull(reader.GetOrdinal("datato")) ? null : reader.GetString(reader.GetOrdinal("datato")),
                            dataTOnext = reader.IsDBNull(reader.GetOrdinal("datatonext")) ? null : reader.GetString(reader.GetOrdinal("datatonext")),
                            dataCT = reader.IsDBNull(reader.GetOrdinal("datact")) ? null : reader.GetString(reader.GetOrdinal("datact")),
                            dataCTnext = reader.IsDBNull(reader.GetOrdinal("datactnext")) ? null : reader.GetString(reader.GetOrdinal("datactnext")),
                            status = reader.GetBoolean(reader.GetOrdinal("status"))
                        };
                        if (car.status)
                            Cars.Add(car);
                    }
                }
            }

            connection.Close();

            return Cars;
        }

        public void Add(Car car)
        {
            connection.Open();
            using (var command = new NpgsqlCommand("INSERT INTO cars3 (name, number, image, driver, datato, datatonext, datact, datactnext) " +
                                                   "VALUES (@name, @number, @image, @driver, @datato, @datatonext, @datact, @datactnext)", connection))
            {
                command.Parameters.AddWithValue("@name", car.name);
                command.Parameters.AddWithValue("@number", car.number);
                command.Parameters.AddWithValue("@image", car.ImagePathCar);
                command.Parameters.AddWithValue("@driver", car.driver ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@datato", car.dataTO ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@datatonext", car.dataTOnext ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@datact", car.dataCT ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@datactnext", car.dataCTnext ?? (object)DBNull.Value);

                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public  Car GetCar(string number)
        {
            
            return Cars.FirstOrDefault(x => x.number == number);
        }

        public void del(string number)
        {
            connection.Open();
            using (var command = new NpgsqlCommand("UPDATE cars3 SET status = false WHERE number = @CarNumber", connection))
            {
                command.Parameters.AddWithValue("@CarNumber", number);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        //  update
    }
}

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
    public class Storage
    {
        private static NpgsqlConnection connection;

        private static ObservableCollection<SparePart> SpareParts { get; } = new ObservableCollection<SparePart>();
        private static ObservableCollection<SparePart> SparePartsOnCars { get; } = new ObservableCollection<SparePart>();
        

        public Storage(string connectString)
        {
            connection = new NpgsqlConnection(connectString);

        }

        public ObservableCollection<SparePart> GetAll()
        {
            SpareParts.Clear();
            connection.Open();
            using (var command = new NpgsqlCommand("SELECT * FROM sp", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SparePart sp = new SparePart
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            name = reader.GetString(reader.GetOrdinal("name")),
                            count = reader.GetInt32(reader.GetOrdinal("count")),
                            car_id = reader.GetInt32(reader.GetOrdinal("car_id")),
                            type_sp = reader.GetString(reader.GetOrdinal("type_sp")),
                            status = reader.GetBoolean(reader.GetOrdinal("status"))

                        };
                        if(sp.status)
                            SpareParts.Add(sp);
                    }
                }
            }

            connection.Close();
            return SpareParts;
        }

        public ObservableCollection<SparePart> GetPartsByCarId(int carId)
        {
            SparePartsOnCars.Clear();
            connection.Open();

            string query = "SELECT sp.id, sp.name, spOnCars.count AS part_count " +
                   "FROM sp " +
                   "INNER JOIN spOnCars ON sp.id = spOnCars.sp_id " +
                   "WHERE spOnCars.cars_id = @carId";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@carId", carId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SparePart sp = new SparePart
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            name = reader.GetString(reader.GetOrdinal("name")), 
                            count = reader.GetInt32(reader.GetOrdinal("part_count")), 
                            car_id = carId 
                        };


                        SparePartsOnCars.Add(sp);
                    }
                }
            }

            connection.Close();
            return SparePartsOnCars;
        }

        public void InsertSparePartOnCar(int sparePartId, int carId, int count)
        {
            connection.Open();

            string query = "INSERT INTO public.sponcars (cars_id, sp_id, count) VALUES (@carId, @spId, @count)";

            using (var command = new NpgsqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@carId", carId);
                command.Parameters.AddWithValue("@spId", sparePartId);
                command.Parameters.AddWithValue("@count", count);

              command.ExecuteNonQuery();
                 
            }

            connection.Close();
        }

        public void Add(SparePart newSparePart)
        {
            connection.Open();
            using (var command = new NpgsqlCommand(
                "INSERT INTO sp (name, count, car_id, type_sp) VALUES (@name, @count, @car_id, @type_sp)", connection))
            {
                command.Parameters.AddWithValue("@name", newSparePart.name);
                command.Parameters.AddWithValue("@count", newSparePart.count);
                command.Parameters.AddWithValue("@car_id", newSparePart.car_id);
                command.Parameters.AddWithValue("@type_sp", newSparePart.type_sp);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void UpdateSparePart(SparePart updatedSparePart)
        {
            connection.Open();

            using (var command = new NpgsqlCommand(
                "UPDATE sp SET name = @name, count = @count, car_id = @car_id WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("name", updatedSparePart.name);
                command.Parameters.AddWithValue("count", updatedSparePart.count);
                command.Parameters.AddWithValue("car_id", updatedSparePart.car_id);
                command.Parameters.AddWithValue("id", updatedSparePart.Id);

                command.ExecuteNonQuery();
               
                   
            }

            connection.Close();
        }

        public void del(SparePart sp)
        {
            connection.Open();
            using (var command = new NpgsqlCommand("UPDATE sp SET status = false WHERE id = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", sp.Id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

    }
}

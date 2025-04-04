using GestionEmpresa.clases;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpresa.db
{
    class dbQuerys
    {
        db.dbConnection DbConnection = new db.dbConnection();

        public static usuario user1;
        public async Task<usuario> Login(string stringUsuario, string userPassword)
        {
            string query = "SELECT id, nombre, apellidos, cuenta, contraseña, rol FROM Usuario WHERE cuenta = @Usuario";
            int usuario = int.Parse(stringUsuario);
            try
            {
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string stringPassword = reader["contraseña"].ToString();
                            string stringCuenta = reader["cuenta"].ToString();
                            string stringNombre = reader["nombre"].ToString();
                            string stringApellidos = reader["apellidos"].ToString();
                            string stringRol = reader["rol"].ToString();
                            string stringId = reader["id"].ToString();

                            if (stringPassword == userPassword)
                            {
                                usuario usuario1 = new usuario(
                                    int.Parse(stringId),
                                    stringNombre,
                                    stringApellidos,
                                    stringCuenta,
                                    stringPassword,
                                    stringRol
                                );

                                user1 = usuario1;

                                return usuario1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
            return null;
        }

        public List<tipo> GetTipos()
        {
            List<tipo> tipos = new List<tipo>();
            string query = "SELECT id, nombre FROM tipo";
            try
            {
                
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tipo dataRow = new tipo(
                            reader.GetInt32(reader.GetOrdinal("id")),
                            reader.GetString(reader.GetOrdinal("nombre"))
                        );
                        tipos.Add(dataRow);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
            return tipos;
        }

        public List<metodo_pago> GetMetodoPago()
        {
            List<metodo_pago> metodosPagos = new List<metodo_pago>();
            string query = "SELECT id, nombre FROM metodo_pago";
            try
            {
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        metodo_pago dataRow = new metodo_pago(
                            reader.GetInt32(reader.GetOrdinal("id")),
                            reader.GetString(reader.GetOrdinal("nombre"))
                        );
                        metodosPagos.Add(dataRow);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
            return metodosPagos;
        }

        public List<categoria> GetCategorias(int id_tipo)
        {
            List<categoria> categorias = new List<categoria>();
            string query = "SELECT id, nombre, id_tipo FROM Categoria WHERE id_tipo = @ID_TIPO";

            try
            {
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_TIPO", id_tipo);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoria dataRow = new categoria(
                                reader.GetInt32(reader.GetOrdinal("id")),
                                reader.GetString(reader.GetOrdinal("nombre")),
                                reader.GetInt32(reader.GetOrdinal("id_tipo"))
                            );
                            categorias.Add(dataRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }

            return categorias;
        }

        public List<transaccionDetallada> GetTransactions(string nombre_tipo)
        {
            List<transaccionDetallada> transacciones = new List<transaccionDetallada>();

            string query = @"SELECT t.id, t.concepto, t.monto, t.fecha, t.descripcion,  
               u.nombre AS usuario, c.nombre AS categoria, mp.nombre AS metodo_pago,
               tp.nombre AS tipo
            FROM transaccion t  
            JOIN usuario u ON t.id_usuario = u.id  
            JOIN categoria c ON t.id_categoria = c.id  
            JOIN metodo_pago mp ON t.id_metodo_pago = mp.id
            JOIN tipo tp ON c.id_tipo = tp.id
            WHERE tp.nombre = @NOMBRE_TIPO
            ORDER BY t.fecha DESC;";

            try
            {
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NOMBRE_TIPO", nombre_tipo);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transaccionDetallada dataRow = new transaccionDetallada(
                                reader.GetInt32(reader.GetOrdinal("id")),
                                reader.GetString(reader.GetOrdinal("concepto")),
                                reader.GetDecimal(reader.GetOrdinal("monto")),
                                reader.GetDateTime(reader.GetOrdinal("fecha")),
                                reader.GetString(reader.GetOrdinal("descripcion")),
                                reader.GetString(reader.GetOrdinal("usuario")),
                                reader.GetString(reader.GetOrdinal("categoria")),
                                reader.GetString(reader.GetOrdinal("metodo_pago")),
                                reader.GetString(reader.GetOrdinal("tipo"))
                            );
                            transacciones.Add(dataRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }

            return transacciones;
        }

        public async void createTransaction(int id_usuario, int id_categoria, int id_metodo_pago, string concepto, double monto, DateTime fecha, string descripcion)
        {
            string query = "INSERT INTO transaccion (id_usuario, id_categoria, id_metodo_pago, concepto, monto, fecha, descripcion) " +
                           "VALUES (@id_usuario, @id_categoria, @id_metodo_pago, @concepto, @monto, @fecha, @descripcion)";
            try
            {
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                    cmd.Parameters.AddWithValue("@id_metodo_pago", id_metodo_pago);
                    cmd.Parameters.AddWithValue("@concepto", concepto);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    
                }

                MessageBox.Show("Transaccion guardada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
        }

        public string DeleteTransaction(int id)
        {
            string query = "DELETE FROM transaccion WHERE id = @Id";
            try
            {
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return "Transacción eliminada correctamente.";
                    }
                    else
                    {
                        return "No se encontró la transacción con el ID especificado.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error en la base de datos: " + ex.Message;
            }
        }

        public void UpdateTransaction(int id_transaccion, int id_usuario, int id_categoria, int id_metodo_pago, string concepto, double monto, DateTime fecha, string descripcion)
        {
            string query = "UPDATE transaccion SET id_usuario = @id_usuario, id_categoria = @id_categoria, id_metodo_pago = @id_metodo_pago, " +
                           "concepto = @concepto, monto = @monto, fecha = @fecha, descripcion = @descripcion WHERE id = @id_transaccion";
            try
            {
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_transaccion", id_transaccion);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                    cmd.Parameters.AddWithValue("@id_metodo_pago", id_metodo_pago);
                    cmd.Parameters.AddWithValue("@concepto", concepto);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Transacción actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la transacción con el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos al actualiza transaccion: " + ex);
            }
        }

        public double GetMontosTotales(int categoria_id)
        {
            string query = "SELECT SUM(t.monto) AS total " +
               "FROM transaccion t " +
               "JOIN categoria c ON t.id_categoria = c.id " +
               "WHERE c.id_tipo = @id";
            double totalIngresos = 0;
            try
            {
                using (var conn = DbConnection.CreaeConexion())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", categoria_id);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalIngresos = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos al obtener ingresos: " + ex.Message);
            }
            return totalIngresos;
        }
    }
}

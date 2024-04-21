using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion_II
{
    internal class ClientesConsulta
    {
      
            private ConexionMysql conexionMysql = new ConexionMysql();

            #region Where
            public Clientes Where(string comparator, string campo = "id", string action = "=")
            {
                string query = "SELECT * FROM clientes WHERE " + campo + " " + action + " @comparator";

                using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@comparator", comparator);

                    try
                    {
                        using (MySqlDataReader mReader = mCommand.ExecuteReader())
                        {
                            if (mReader.Read())
                            {
                                Clientes mClientes = new Clientes();
                                mClientes.id = mReader.GetInt16(0);
                                mClientes.nombrecli = mReader.GetString(1);
                                mClientes.apellidocli = mReader.GetString(2);
                                mClientes.telefonocli = mReader.GetString(3);
                                mClientes.direccioncli = mReader.GetString(4);
                                mClientes.estatuscli = mReader.GetString(5);
                                return mClientes;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Manejar excepciones específicas de MySQL
                        throw new Exception("Error en la consulta SQL: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Manejar otras excepciones
                        throw new Exception("Error inesperado: " + ex.Message);
                    }
                }
            }
        #endregion

        #region Get
        public List<Clientes> Get()
        {
            List<Clientes> Clientes = new List<Clientes>();

            string query = "SELECT *  FROM Clientes";


            using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
            {


                try
                {
                    MySqlDataReader mReader = mCommand.ExecuteReader();
                    while (mReader.Read())
                    {
                        Clientes mClientes = new Clientes();
                        mClientes.id = mReader.GetInt32(0);
                        mClientes.nombrecli = mReader.GetString(1);
                        mClientes.apellidocli = mReader.GetString(2);
                        mClientes.telefonocli = mReader.GetString(3);
                        mClientes.direccioncli = mReader.GetString(4);
                        mClientes.estatuscli = mReader.GetString(5);
                        Clientes.Add(mClientes);
                    }

                    mReader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en el query " + ex.Message);
                }
            }

            return Clientes;
        }
        #endregion


        #region Add
        public void Add(Clientes nuevoCliente)
        {
            string query = "INSERT INTO clientes (nombrecli, apellidocli, telefofonocli, direccioncli, estatuscli) " +
                           "VALUES (@nombrecli, @apellidocli, @telefofonocli, @direccioncli, @estatuscli)";

            using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
            {
                mCommand.Parameters.AddWithValue("@nombrecli", nuevoCliente.nombrecli);
                mCommand.Parameters.AddWithValue("@apellidocli", nuevoCliente.apellidocli);
                mCommand.Parameters.AddWithValue("@telefofonocli", nuevoCliente.telefonocli);
                mCommand.Parameters.AddWithValue("@direccioncli", nuevoCliente.direccioncli);
                mCommand.Parameters.AddWithValue("@estatuscli", nuevoCliente.estatuscli);

                try
                {
                    mCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Manejar excepciones específicas de MySQL
                    throw new Exception("Error al agregar un nuevo cliente: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Manejar otras excepciones
                    throw new Exception("Error inesperado al agregar un nuevo cliente: " + ex.Message);
                }
            }
        }
        #endregion

    }

}

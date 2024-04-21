using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion_II
{
    internal class ProductosConsulta
    {
        private ConexionMysql conexionMysql = new ConexionMysql();

        #region Where
        public Productos Where(string comparator, string campo = "id", string action = "=")
        {
            string query = "SELECT * FROM productos WHERE " + campo + " " + action + " @comparator";

            using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
            {
                mCommand.Parameters.AddWithValue("@comparator", comparator);

                try
                {
                    using (MySqlDataReader mReader = mCommand.ExecuteReader())
                    {
                        if (mReader.Read())
                        {
                            Productos mProductos = new Productos();
                            mProductos.id = mReader.GetInt16(0);
                            mProductos.descripcionpro = mReader.GetString(1);
                            mProductos.costopro = mReader.GetInt16(2);
                            mProductos.preciopro = mReader.GetInt16(3);
                            mProductos.existenciapro = mReader.GetInt16(4);
                            mProductos.estatuspro = mReader.GetString(5);
                            return mProductos;
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
        public List<Productos> Get()
        {
            List<Productos> Productos = new List<Productos>();

            string query = "SELECT *  FROM productos";


            using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
            {


                try
                {
                    MySqlDataReader mReader = mCommand.ExecuteReader();
                    while (mReader.Read())
                    {
                        Productos mProductos = new Productos();
                        mProductos.id = mReader.GetInt32(0);
                        mProductos.descripcionpro = mReader.GetString(1);
                        mProductos.costopro = mReader.GetInt16(2);
                        mProductos.preciopro = mReader.GetInt16(3);
                        mProductos.existenciapro = mReader.GetInt16(4);
                        mProductos.estatuspro = mReader.GetString(5);
                        Productos.Add(mProductos);
                    }

                    mReader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en el query " + ex.Message);
                }
            }

            return Productos;
        }
        #endregion


        #region Add
        public void Add(Productos nuevoProducto)
        {
            string query = "INSERT INTO productos (descripcionpro, costopro, preciopro, existenciapro, estatuspro) " +
                           "VALUES (@descripcionpro, @costopro, @preciopro, @existenciapro, @estatuspro)";

            using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
            {
                mCommand.Parameters.AddWithValue("@descripcionpro", nuevoProducto.descripcionpro);
                mCommand.Parameters.AddWithValue("@costopro", nuevoProducto.costopro);
                mCommand.Parameters.AddWithValue("@preciopro", nuevoProducto.preciopro);
                mCommand.Parameters.AddWithValue("@existenciapro", nuevoProducto.existenciapro);
                mCommand.Parameters.AddWithValue("@estatuspro", nuevoProducto.estatuspro);

                try
                {
                    mCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Manejar excepciones específicas de MySQL
                    throw new Exception("Error al agregar un nuevo producto: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Manejar otras excepciones
                    throw new Exception("Error inesperado al agregar un nuevo producto: " + ex.Message);
                }
            }
        }
        #endregion

    }
}

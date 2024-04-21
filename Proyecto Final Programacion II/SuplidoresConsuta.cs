using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Proyecto_Final_Programacion_II
{
    internal class SuplidoresConsulta
    {
        private ConexionMysql conexionMysql = new ConexionMysql();

        #region Where
        public Suplidores Where(string comparator, string campo = "id", string action = "=")
        {
            string query = "SELECT * FROM suplidores WHERE " + campo + " " + action + " @comparator";

            using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
            {
                mCommand.Parameters.AddWithValue("@comparator", comparator);

                try
                {
                    using (MySqlDataReader mReader = mCommand.ExecuteReader())
                    {
                        if (mReader.Read())
                        {
                            Suplidores mSuplidores = new Suplidores();
                            mSuplidores.id = mReader.GetInt16(0);
                            mSuplidores.nombresup = mReader.GetString(1);
                            mSuplidores.telefonosup = mReader.GetString(2);
                            mSuplidores.direccionsup = mReader.GetString(3);
                            mSuplidores.estatussup = mReader.GetString(4);
                            return mSuplidores;
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
        public List<Suplidores> Get()
        {
            List<Suplidores> Suplidores = new List<Suplidores>();

            string query = "SELECT *  FROM suplidores";


            using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
            {


                try
                {
                    MySqlDataReader mReader = mCommand.ExecuteReader();
                    while (mReader.Read())
                    {
                        Suplidores mSuplidores = new Suplidores();
                        mSuplidores.id = mReader.GetInt32(0);
                        mSuplidores.nombresup = mReader.GetString(1);
                        mSuplidores.telefonosup = mReader.GetString(2);
                        mSuplidores.direccionsup = mReader.GetString(3);
                        mSuplidores.estatussup = mReader.GetString(4);
                        Suplidores.Add(mSuplidores);
                    }

                    mReader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en el query " + ex.Message);
                }
            }

            return Suplidores;
        }
        #endregion


        #region Add
        public void Add(Suplidores Suplidores)
        {
            string query = "INSERT INTO suplidores (nombresup, telefonosup, direccionsup, estatussup) " +
                           "VALUES (@nombresup, @telefofonosup, @direccionsup, @estatussup)";

            using (MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection()))
            {
                mCommand.Parameters.AddWithValue("@nombresup", Suplidores.nombresup);
                mCommand.Parameters.AddWithValue("@telefonosup", Suplidores.telefonosup);
                mCommand.Parameters.AddWithValue("@direccionsup", Suplidores.direccionsup);
                mCommand.Parameters.AddWithValue("@estatussup", Suplidores.estatussup);

                try
                {
                    mCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Manejar excepciones específicas de MySQL
                    throw new Exception("Error al agregar un nuevo suplidor: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Manejar otras excepciones
                    throw new Exception("Error inesperado al agregar un nuevo suplidor: " + ex.Message);
                }
            }
        }
        #endregion

    }

}

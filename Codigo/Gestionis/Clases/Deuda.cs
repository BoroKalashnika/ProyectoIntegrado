﻿using MySql.Data.MySqlClient;
using System.Data;

namespace Gestionis.Clases
{
    class Deuda
    {
        private int? idDeuda;
        private int numCuenta;
        private string titulo;
        private string descripcion;
        private bool debo;
        private decimal cantidad;
        private DateTime fechaCreacion;
        private DateTime fechaVencimiento;
        private bool anyadirRecordatorio;

        #region Propiedades
        public string Titulo { get { return titulo; } }
        public string Descripcion { get { return descripcion; } }
        public bool Debo { get { return debo; } }
        public decimal Cantidad { get { return cantidad; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } }
        public DateTime FechaVencimiento { get { return fechaVencimiento; } }
        #endregion

        #region Constructores
        public Deuda() { }

        public Deuda(string tit, string descrip, bool deb, decimal cant, DateTime fechaCrea, DateTime fechaVenc, bool record)
        {
            idDeuda = null;
            numCuenta = Sesion.Instance.NumCuenta;
            titulo = tit;
            descripcion = descrip;
            debo = deb;
            cantidad = cant;
            fechaCreacion = fechaCrea;
            fechaVencimiento = fechaVenc;
            anyadirRecordatorio = record;
        }
        #endregion

        public int Add()
        {
            int resultado = 0;
            string fechaVencimiento = this.fechaVencimiento.ToString("yyyy/MM/dd");
            string fechaCreacion = this.fechaCreacion.ToString("yyyy/MM/dd");

            string queryString = "INSERT INTO deuda (idDeuda, numCuenta, titulo, descripcion," +
                "debo, cantidad, fechaCreacion, fechaVencimiento, anyadirRecordatorio) " +
                "VALUES (@idDeuda, @numCuenta, @titulo, @descripcion, @debo, @cantidad," +
                "@fechaCreacion, @fechaVencimiento, @anyadirRecordatorio);";

            try
            {
                using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
                {
                    query.Parameters.AddWithValue("@idDeuda", idDeuda);
                    query.Parameters.AddWithValue("@numCuenta", numCuenta);
                    query.Parameters.AddWithValue("@titulo", titulo);
                    query.Parameters.AddWithValue("@descripcion", descripcion);
                    query.Parameters.AddWithValue("@debo", debo);
                    query.Parameters.AddWithValue("@cantidad", cantidad);
                    query.Parameters.AddWithValue("@fechaCreacion", fechaCreacion);
                    query.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                    query.Parameters.AddWithValue("@anyadirRecordatorio", anyadirRecordatorio);

                    ConexionDB.AbrirConexion();

                    resultado = query.ExecuteNonQuery();

                    ConexionDB.CerrarConexion();
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public static bool ExisteDeuda(string tit)
        {
            string queryString = $"SELECT titulo FROM deuda WHERE titulo = @titulo AND numCuenta = {Sesion.Instance.NumCuenta};";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@titulo", tit);

            ConexionDB.AbrirConexion();

            bool existe;

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                existe = reader.HasRows;
            }

            ConexionDB.CerrarConexion();

            return existe;
        }

        public static Deuda GetDeuda(string tit, Deuda deuda)
        {
            string queryString = $"SELECT descripcion, debo, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE titulo = @titulo AND numCuenta = {Sesion.Instance.NumCuenta};";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@titulo", tit);

                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        deuda.descripcion = reader.GetString(0);
                        deuda.debo = reader.GetBoolean(1);
                        deuda.cantidad = reader.GetDecimal(2);
                        deuda.fechaCreacion = Convert.ToDateTime(reader.GetDateTime(3).ToString("dd/MM/yyyy"));
                        deuda.fechaVencimiento = Convert.ToDateTime(reader.GetDateTime(4).ToString("dd/MM/yyyy"));
                    }
                }                
                ConexionDB.CerrarConexion();
            }
            return deuda;
        }        

        public static int EliminarDeuda(string tit)
        {
            int resultado = 0;

            string consulta = $"DELETE FROM deuda WHERE titulo = '{tit}' AND numCuenta = {Sesion.Instance.NumCuenta};";

            ConexionDB.AbrirConexion();
            using (MySqlCommand comando = new MySqlCommand(consulta, ConexionDB.Conexion))
            {
                resultado = comando.ExecuteNonQuery();
            }
            ConexionDB.CerrarConexion();

            return resultado;
        }

        public static int DeudasTotales()
        {
            int resultado = 0;

            string queryString = "SELECT COUNT(idDeuda) FROM deuda WHERE numCuenta = @numCuenta AND debo = TRUE;";

            try
            {
                using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
                {
                    query.Parameters.AddWithValue("@numCuenta", Sesion.Instance.NumCuenta);

                    ConexionDB.AbrirConexion();
                    resultado = Convert.ToInt32(query.ExecuteScalar());
                    ConexionDB.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return resultado;
        }

        public void GetProximaDeuda(Deuda deuda)
        {
            string queryString = "SELECT titulo, debo, MIN(fechaVencimiento) FROM deuda WHERE numCuenta = @numCuenta;";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@numCuenta", Sesion.Instance.NumCuenta);

                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        deuda.titulo = reader.GetString(0);
                        deuda.debo = reader.GetBoolean(1);
                        deuda.fechaVencimiento = Convert.ToDateTime(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                    }
                }
                ConexionDB.CerrarConexion();
            }            
        }

        public static string[] Filtros()
        {
            string[] filtro = { "Título", "Precio max.", "Precio min.", "Fecha deuda", "Fecha vencim" };
            return filtro;
        }

        public static DataTable RecargarTabla()
        {
            return Utilidades.RellenarDatos($"SELECT titulo, descripcion, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE numCuenta = {Sesion.Instance.NumCuenta}");
        }

        public static DataTable RecargarTabla(bool debo)
        {
            return Utilidades.RellenarDatos($"SELECT titulo, descripcion, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE numCuenta = {Sesion.Instance.NumCuenta} AND debo = {debo}");
        }

        public static DataTable CargarFiltro(string filtro, bool debo, string titulo)
        {
            int numCuenta = Sesion.Instance.NumCuenta;
            string consulta = $"SELECT titulo, descripcion, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo}";
            switch (filtro)
            {
                case "Título":
                    consulta += $" AND titulo = '{titulo}'";
                    break;
                case "Precio max.":
                    consulta += $" AND cantidad = (SELECT MAX(cantidad) FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo})";
                    break;
                case "Precio min.":
                    consulta += $" AND cantidad = (SELECT MIN(cantidad) FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo})";
                    break;
                case "Fecha deuda":
                    consulta += $" AND fechaCreacion = (SELECT MIN(fechaCreacion) FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo})";
                    break;
                case "Fecha vencim":
                    consulta += $" AND fechaVencimiento = (SELECT MIN(fechaVencimiento) FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo})";
                    break;

                default:
                    break;
            }

            return Utilidades.RellenarDatos(consulta);
        }

        public static float CalcularTotal(bool debo)
        {
            float resultado = 0;
            string consulta = $"SELECT SUM(cantidad) FROM deuda WHERE numCuenta = {Sesion.Instance.NumCuenta} AND debo = {debo}";

            try
            {
                using (MySqlCommand query = new MySqlCommand(consulta, ConexionDB.Conexion))
                {
                    ConexionDB.AbrirConexion();
                    resultado = Convert.ToInt32(query.ExecuteScalar());
                    ConexionDB.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return resultado;
        }
    }
}

﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Gestionis.Formularios;

namespace Gestionis.Clases
{
    public class Cuenta
    {
        private int? numCuenta;
        private string apodoUsuario;
        private float pasivos;
        private List<Notificacion> notificaciones = new List<Notificacion>();

        public Cuenta(string apodoUsuario)
        {
            this.numCuenta = null;
            this.apodoUsuario = apodoUsuario;
            this.pasivos = 0;
        }

        public Cuenta(int numCuenta, string apodoUsuario, float pasivos)
        {
            this.numCuenta = numCuenta;
            this.apodoUsuario = apodoUsuario;
            this.pasivos = pasivos;
        }

        public List<Notificacion> Notificaciones { get { return notificaciones; } }

        public static int IDCuentaUsuario(string apodoUsuario)
        {
            int numCuenta;
            string queryString = "SELECT numCuenta FROM cuenta WHERE apodoUsuario = @apodoUsuario;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodoUsuario", apodoUsuario);

            ConexionDB.AbrirConexion();

            numCuenta = Convert.ToInt32(query.ExecuteScalar());

            ConexionDB.CerrarConexion();

            return numCuenta;
        }

        public void Add()
        {
            string queryString = "INSERT INTO cuenta (numCuenta, apodoUsuario, pasivos) " +
                "VALUES (@numCuenta, @apodoUsuario, @pasivos);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@apodoUsuario", apodoUsuario);
            query.Parameters.AddWithValue("@pasivos", pasivos);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        public void AddNotificacion()
        {
            for (int i = 0; i < notificaciones.Count; i++)
            {

                if (Gasto.CrearNotificacion(notificaciones[i].Categoria, i) && !Notificacion.ExisteNotif(notificaciones[i].Categoria))
                {
                    notificaciones[i].Add();
                }
            }


            if (Gasto.NotifRestaurante() && !Notificacion.ExisteNotif("Restaurante"))
            {
                Notificacion nRes = new Notificacion(
                    null,
                    Sesion.Instance.NumCuenta,
                    "Gasto elevado en Restaurantes",
                    CategoriaGasto.DevuelveIDCategoria("Restaurante"),
                    "+5 gastos en restaurantes",
                    "Considera cocinar en casa",
                    DateTime.Now
                    );

                nRes.Add();
            }

            if (Gasto.NotifEntretenimiento() && !Notificacion.ExisteNotif("Entretenimiento"))
            {
                Notificacion nEnt = new Notificacion(
                    null,
                    Sesion.Instance.NumCuenta,
                    "Gasto elevado en Entretenimiento",
                    CategoriaGasto.DevuelveIDCategoria("Entretenimiento"),
                    "+50€ gastados",
                    "Considera cancelar suscripciones a servicios de series/películas",
                    DateTime.Now
                    );

                nEnt.Add();
            }

            if (Gasto.NotifLuz() && !Notificacion.ExisteNotif("Luz"))
            {
                Notificacion nLuz = new Notificacion(
                    null,
                    Sesion.Instance.NumCuenta,
                    "Gasto elevado en Luz",
                    CategoriaGasto.DevuelveIDCategoria("Luz"),
                    "+ 15% de gastos destinados a luz",
                    "Considera reducir el consumo eléctrico con bombillas LED",
                    DateTime.Now
                );

                nLuz.Add();
            }

            if (Gasto.NotifSuper() && !Notificacion.ExisteNotif("Supermercado"))
            {
                Notificacion nSup = new Notificacion(
                    null,
                    Sesion.Instance.NumCuenta,
                    "Gasto elevado en Alimentación",
                    CategoriaGasto.DevuelveIDCategoria("Supermercado"),
                    "+ 300€ gastados en Supermercados",
                    "Considera comprar en supermercados con ofertas",
                    DateTime.Now
                );

                nSup.Add();
            }

            if (Gasto.NotifGasolina() && !Notificacion.ExisteNotif("Gasolina"))
            {
                Notificacion nGas = new Notificacion(
                    null,
                    Sesion.Instance.NumCuenta,
                    "Gasto elevado en Gasolina",
                    CategoriaGasto.DevuelveIDCategoria("Gasolina"),
                    "+ 200€ gastados en Gasolina",
                    "Considera viajar en transporte público",
                    DateTime.Now
                );

                nGas.Add();
            }
        }

        #region Métodos para ver / recuperar gastos e ingresos
        public List<Gasto> DevuelveGastos()
        {
            string queryString = "SELECT * FROM gasto WHERE numCuenta = @numCuenta";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);

            return EjecutarConsultaGastos(query);
        }

        public List<Gasto> DevuelveGastos(string nombre, string tipo, decimal cantidad, string categoria)
        {
            string queryString = "SELECT * FROM gasto WHERE nombre = @nombre AND tipo = @tipo AND cantidad >= @cantidad " +
                "AND categoria IN (SELECT idcategoria FROM categoriagasto WHERE nombre = @nombreCategoria);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@tipo", tipo);
            query.Parameters.AddWithValue("@cantidad", cantidad);
            query.Parameters.AddWithValue("@nombreCategoria", categoria);

            return EjecutarConsultaGastos(query);
        }

        public List<Ingreso> DevuelveIngresos()
        {
            string queryString = "SELECT * FROM ingreso WHERE numCuenta = @numCuenta";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);

            return EjecutarConsultaIngresos(query);
        }

        public List<Ingreso> DevuelveIngresos(string nombre, string tipo, decimal cantidad, string categoria)
        {
            string queryString = "SELECT * FROM ingreso WHERE nombre = @nombre AND tipo = @tipo AND cantidad >= @cantidad AND categoria ";

            if (categoria == string.Empty)
            {
                queryString += "IS NULL;";
            }
            else
            {
                queryString += "IN (SELECT idcategoria FROM categoriaIngreso WHERE nombre = @nombreCategoria);";
            }

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@tipo", tipo);
            query.Parameters.AddWithValue("@cantidad", cantidad);
            query.Parameters.AddWithValue("@nombreCategoria", categoria);

            return EjecutarConsultaIngresos(query);
        }

        public double DineroTotal()
        {
            return TotalIngresos() - TotalGastos();
        }

        public double TotalGastos()
        {
            List<Gasto> gastos = DevuelveGastos();
            double totalGastos = 0;
            for (int i = 0; i < gastos.Count; i++)
            {
                totalGastos += gastos[i].Cantidad;
            }
            return totalGastos;
        }

        public double TotalIngresos()
        {
            List<Ingreso> ingresos = DevuelveIngresos();
            double totalIngresos = 0;
            for (int i = 0; i < ingresos.Count; i++)
            {
                totalIngresos += ingresos[i].Cantidad;
            }
            return totalIngresos;
        }

        private List<Gasto> EjecutarConsultaGastos(MySqlCommand query)
        {
            List<Gasto> gastos = new List<Gasto>();

            ConexionDB.AbrirConexion();

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    gastos.Add(new Gasto(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetFloat(3),
                        reader.GetInt32(4),
                        reader.GetString(5),
                        reader.GetSafeString(6),
                        reader.GetDateTime(7),
                        reader.GetTimeSpan(8)
                    ));
                }
            }

            ConexionDB.CerrarConexion();

            return gastos;
        }

        private List<Ingreso> EjecutarConsultaIngresos(MySqlCommand query)
        {
            List<Ingreso> ingresos = new List<Ingreso>();

            ConexionDB.AbrirConexion();

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    ingresos.Add(new Ingreso(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetFloat(3),
                        reader.GetString(4),
                        reader.GetSafeInt32(5),
                        reader.GetSafeString(6),
                        reader.GetDateTime(7),
                        reader.GetTimeSpan(8)
                    ));
                }
            }

            ConexionDB.CerrarConexion();

            return ingresos;
        }
        #endregion
    }
}

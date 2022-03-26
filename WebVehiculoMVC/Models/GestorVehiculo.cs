using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebVehiculoMVC.Models
{
    public class GestorVehiculo
    {
        public List<Marca>ObtenerMarcas()
        {
            List<Marca> lista = new List<Marca>();

            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-E8FRIUV\\SQLEXPRESS; Initial Catalog = Vehiculos; User ID = sa; password= giandjoe");
            conn.Open();

            SqlCommand comm = new SqlCommand("SELECT * FROM Marcas", conn);

            SqlDataReader dr = comm.ExecuteReader();

            while(dr.Read())
            {
                int idM = dr.GetInt32(0);
                string nombreM = dr.GetString(1);

                Marca M = new Marca(idM, nombreM);
                lista.Add(M);
            }

            conn.Close();
            return lista;
        }

        public void Agregar(Vehiculo nuevoVehiculo)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-E8FRIUV\\SQLEXPRESS; Initial Catalog = Vehiculos; User ID = sa; password= giandjoe");
            conn.Open();

            SqlCommand comm = new SqlCommand("INSERT INTO Vehiculos (denominacion, modelo, marca_id) VALUES (@denominacion, @modelo, @marca_id)", conn);

            comm.Parameters.Add(new SqlParameter("@denominacion", nuevoVehiculo.NombreV));
            comm.Parameters.Add(new SqlParameter("@modelo", nuevoVehiculo.ModeloV));
            comm.Parameters.Add(new SqlParameter("@marca_id", nuevoVehiculo.IdM));

            comm.ExecuteNonQuery();

            conn.Close();
        }

        public void Modificar(Vehiculo cambiarVehiculo)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-E8FRIUV\\SQLEXPRESS; Initial Catalog = Vehiculos; User ID = sa; password= giandjoe");
            conn.Open();

            SqlCommand comm = new SqlCommand("UPDATE Vehiculos SET denominacion=@denominacion, modelo=@modelo, marca_id=@marca_id WHERE id=@id", conn);

            comm.Parameters.Add(new SqlParameter("@denominacion", cambiarVehiculo.NombreV));
            comm.Parameters.Add(new SqlParameter("@modelo", cambiarVehiculo.ModeloV));
            comm.Parameters.Add(new SqlParameter("@marca_id", cambiarVehiculo.IdM));
            comm.Parameters.Add(new SqlParameter("@id", cambiarVehiculo.IdV));

            comm.ExecuteNonQuery();

            conn.Close();
        }
        public void Eliminar(Vehiculo borrarVehiculo)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-E8FRIUV\\SQLEXPRESS; Initial Catalog = Vehiculos; User ID = sa; password= giandjoe");
            conn.Open();

            SqlCommand comm = new SqlCommand("DELETE FROM Vehiculos WHERE id=@id", conn);

            comm.Parameters.Add(new SqlParameter("@id", borrarVehiculo.IdV));

            comm.ExecuteNonQuery();

            conn.Close();
        }

        public List<Vehiculo> Listar()
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-E8FRIUV\\SQLEXPRESS; Initial Catalog = Vehiculos; User ID = sa; password= giandjoe");
            conn.Open();

            SqlCommand comm = new SqlCommand("SELECT * FROM Vehiculos", conn);

            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int idV = dr.GetInt32(0);
                string nombreV = dr.GetString(1);
                string modeloV = dr.GetString(2);
                int idM = dr.GetInt32(3);

                Vehiculo V = new Vehiculo(idV, nombreV, modeloV, idM);
                lista.Add(V);
            }

            conn.Close();
            return lista;
        }
    }
}
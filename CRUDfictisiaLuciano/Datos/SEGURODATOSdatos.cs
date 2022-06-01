using CRUDfictisiaLuciano.Models;
using System.Data.SqlClient;
using System.Data;

namespace CRUDfictisiaLuciano.Datos
{
    public class SEGURODATOSdatos
    {
        public List<DATOSSEGUROmodel> Listar()
        {
            var oLista = new List<DATOSSEGUROmodel>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Listar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new DATOSSEGUROmodel()
                        {
                            identificacion = Convert.ToInt32(dr["identificacion"]),
                            nombrecompleto = dr["nombrecompleto"].ToString(),
                            edad = Convert.ToInt32(dr["edad"]),
                            genero = dr["genero"].ToString(),
                            estado = dr["estado"].ToString(),
                            maneja = dr["maneja"].ToString(),
                            lentes = dr["lentes"].ToString(),
                            diabetico = dr["diabetico"].ToString(),
                            otraenfermedad = dr["otraenfermedad"].ToString(),
                        });

                    }
                }
            }
            return oLista;
        }
        public DATOSSEGUROmodel Obtener(int identificacion)
        {
            var oContacto = new DATOSSEGUROmodel();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Obtener", conexion);
                cmd.Parameters.AddWithValue("identificacion", identificacion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oContacto.identificacion = Convert.ToInt32(dr["identificacion"]);
                        oContacto.nombrecompleto = dr["nombrecompleto"].ToString();
                        oContacto.edad = Convert.ToInt32(dr["edad"]);
                        oContacto.genero = dr["genero"].ToString();
                        oContacto.estado = dr["estado"].ToString();
                        oContacto.maneja = dr["maneja"].ToString();
                        oContacto.lentes = dr["lentes"].ToString();
                        oContacto.diabetico = dr["diabetico"].ToString();
                        oContacto.otraenfermedad = dr["otraenfermedad"].ToString();
                    }
                }
            }
            return oContacto;
        }
        public bool Guardar(DATOSSEGUROmodel ocontacto)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Guardar", conexion);
                    cmd.Parameters.AddWithValue("nombrecompleto", ocontacto.nombrecompleto);
                    cmd.Parameters.AddWithValue("edad", ocontacto.edad);
                    cmd.Parameters.AddWithValue("genero", ocontacto.genero);
                    cmd.Parameters.AddWithValue("estado", ocontacto.estado);
                    cmd.Parameters.AddWithValue("maneja", ocontacto.maneja);
                    cmd.Parameters.AddWithValue("lentes", ocontacto.lentes);
                    cmd.Parameters.AddWithValue("diabetico", ocontacto.diabetico);
                    cmd.Parameters.AddWithValue("otraenfermedad", ocontacto.otraenfermedad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;


            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;

            }



            return rpta;
        }
        public bool Editar(DATOSSEGUROmodel ocontacto)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Editar", conexion);
                    cmd.Parameters.AddWithValue("identificacion", ocontacto.identificacion);
                    cmd.Parameters.AddWithValue("nombrecompleto", ocontacto.nombrecompleto);
                    cmd.Parameters.AddWithValue("edad", ocontacto.edad);
                    cmd.Parameters.AddWithValue("genero", ocontacto.genero);
                    cmd.Parameters.AddWithValue("estado", ocontacto.estado);
                    cmd.Parameters.AddWithValue("maneja", ocontacto.maneja);
                    cmd.Parameters.AddWithValue("lentes", ocontacto.lentes);
                    cmd.Parameters.AddWithValue("diabetico", ocontacto.diabetico);
                    cmd.Parameters.AddWithValue("otraenfermedad", ocontacto.otraenfermedad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;


            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;

            }



            return rpta;
        }
        public bool Eliminar(int identificacion)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Eliminar", conexion);
                    cmd.Parameters.AddWithValue("identificacion", identificacion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;


            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;

            }
            return rpta;
        }
    }
}
    




        

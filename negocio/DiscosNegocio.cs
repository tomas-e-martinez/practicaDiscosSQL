using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscosNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select d.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, t.Descripcion as Formato, e.Descripcion as Genero, d.IdEstilo, d.IdTipoEdicion  From DISCOS D, TIPOSEDICION T, ESTILOS E where d.IdEstilo = e.Id and d.IdTipoEdicion = t.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];

                    if (!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];

                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Id = (int)lector["IdTipoEdicion"];
                    aux.TipoEdicion.Descripcion = (string)lector["Formato"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)lector["Genero"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa) values ('" + nuevo.Titulo + "', @fechaLanzamiento , "+ nuevo.CantidadCanciones +", @idEstilo, @idTipoEdicion, @urlImagenTapa)");
                datos.setearParametro("@idEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@idTipoEdicion", nuevo.TipoEdicion.Id);
                datos.setearParametro("@urlImagenTapa", nuevo.UrlImagenTapa);
                datos.setearParametro("@fechaLanzamiento", nuevo.FechaLanzamiento);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {   
                datos.cerrarConexion();
            }
        }

        public void modificar(Disco modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @titulo, FechaLanzamiento = @fechaLanzamiento, CantidadCanciones = @cantCanciones, UrlImagenTapa = @urlImagen, IdEstilo = @idEstilo, IdTipoEdicion = @idTipo where Id = @id");
                datos.setearParametro("@titulo", modificar.Titulo);
                datos.setearParametro("@fechaLanzamiento", modificar.FechaLanzamiento);
                datos.setearParametro("@cantCanciones", modificar.CantidadCanciones);
                datos.setearParametro("@urlImagen", modificar.UrlImagenTapa);
                datos.setearParametro("@idEstilo", modificar.Estilo.Id);
                datos.setearParametro("@idTipo", modificar.TipoEdicion.Id);
                datos.setearParametro("@id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(Disco eliminar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("delete DISCOS where Id = @id");
                datos.setearParametro("@id", eliminar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

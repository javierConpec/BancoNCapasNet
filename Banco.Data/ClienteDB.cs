using Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Banco.Data
{
    public class ClienteDB
    {
        //Listar todos los clientes
        public List<Cliente> Listar()
        {
            var listados = new List<Cliente>();

            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Cliente", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Cliente cliente;
                            while (lector.Read())
                            {
                                //crear un nuevo objeto cliente
                                cliente = new Cliente();
                                cliente.ID = int.Parse(lector["ID"].ToString());
                                cliente.Nombres = lector["Nombres"].ToString();
                                cliente.Apellidos = lector["Apellidos"].ToString();
                                cliente.RazonSocial = lector["RazonSocual"].ToString();
                                cliente.NumeroDocumento = lector["NumeroDoc"].ToString();
                                cliente.IDTipodocumento = (int)lector["IdTipoDoc"];
                                cliente.IDTipoCliente = (int)lector["IdTipoCliente"];
                                cliente.Direccion = lector["Direccion"].ToString();
                                cliente.Referencia = lector["Referencia"].ToString();
                                cliente.Telefono = lector["Telefono"].ToString();
                                cliente.Email = lector["Email"].ToString();
                                //agregar el cliente al listado
                                listados.Add(cliente);
                            }
                        }
                    }
                }

            }
            return listados;


        }
        public int Insertar(Cliente cliente)
        {
            int filas = 0;
            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                var query = "INSERT INTO [dbo].[Cliente]" +
                    "([Nombres],[Apellido],[RazonSocial],[NumeroDoc],[IdTipoDoc],[IdTipoCliente]" +
                    "[Direccion],[Referencia],[Telefono],[Email])" +
                    "VALUES(@Nombres,@Aellidos,@RazonSocial,@NumeroDoc,@IdTipoDoc,@IdTipoCliente,@Direcion,@Referencia,@Telefono,@Email)";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                    comando.Parameters.AddWithValue("@RazonSocial", cliente.RazonSocial);
                    comando.Parameters.AddWithValue("@NumeroDoc", cliente.NumeroDocumento);
                    comando.Parameters.AddWithValue("@IdTipoDoc", cliente.IDTipodocumento);
                    comando.Parameters.AddWithValue("@IdTipoCliente", cliente.IDTipoCliente);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Referencia", cliente.Referencia);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Email", cliente.Email);
                    filas = comando.ExecuteNonQuery();
                   
                }
            }
            return filas;
        }
    }
}
            
           
            
        


    


          
        
    



        
            
        

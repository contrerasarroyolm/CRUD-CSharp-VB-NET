using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CRUD_CSharp
{
    public class ClientController
    {
        Conexion conexion = new Conexion();

        public void AddClient(Client client)
        {
            using (SqlConnection con = conexion.GetConexion())
            {
                string consulta = "insert into Clients (FullName, Email, PhoneNumber) values (@FullName, @Email, @PhoneNumber) ";
                SqlCommand comando = new SqlCommand(consulta, con);
                //comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@FullName", client.FullName);
                comando.Parameters.AddWithValue("@Email", client.Email);
                comando.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);
                SqlDataReader lector = comando.ExecuteReader();
                lector.Close();
            }
        }

        public List<Client> GetClient()
        {
            List<Client> _client = new List<Client>();
            SqlConnection con = conexion.GetConexion();
            string consulta = "select * from Clients";
            SqlCommand comando = new SqlCommand(consulta, con);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet datos = new DataSet();
            adaptador.Fill(datos);
            if (datos != null)
            {
                foreach (DataRow item in datos.Tables[0].Rows)
                {
                    Client c = new Client();
                    c.ClientId = (int)item["ClientId"];
                    c.FullName = (string)item["FullName"];
                    c.Email = (string)item["Email"];
                    c.PhoneNumber = (string)item["PhoneNumber"];
                    _client.Add(c);
                }
                con.Close();
            }
            return _client;
        }

        public List<Client> getClient()
        {
            using (SqlConnection cnn = conexion.GetConexion())
            {
                List<Client> clientes = new List<Client>();
                SqlCommand cmd = new SqlCommand(
                    $"select * from Clients",
                    cnn);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    Client c = new Client();
                    while (sdr.Read())
                    {
                        c.ClientId = (int)sdr["ClientId"];
                        c.FullName = (string)sdr["FullName"];
                        c.Email = (string)sdr["Email"];
                        c.PhoneNumber = (string)sdr["PhoneNumber"];
                        clientes.Add(c);
                    }
                    cnn.Close();
                }
                return clientes;
            }

        }

        public void DelClient(Client client)
        {
            using (SqlConnection con = conexion.GetConexion())
            {
                string query = "Delete Clients where ClientId=" + client.ClientId;
                SqlCommand command = new SqlCommand(query, con);
                Client c = new Client();
                c.ClientId = client.ClientId;
                SqlDataReader reader = command.ExecuteReader();
                con.Close();
            }
        }

        public void UpdateClient(Client client)
        {
            using (SqlConnection con = conexion.GetConexion())
            {
                string query = @"Update Clients set FullName=@FullName where ClientId=@ClientId";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@FullName", client.FullName);
                command.Parameters.AddWithValue("@ClientId", client.ClientId);
                SqlDataReader reader = command.ExecuteReader();
                con.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


namespace Pia_Programacion_C_
{
    public class DataAccessLayer
    {

        //AQUI VA LA CONEXION A LA BASE DE DATOS
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MagicVilla;Data Source=DESKTOP-6G2I3CU\\SQLEXPRESS");
        public void InsertContact(Contact contact) 
        {

            try
            {
                conn.Open();
                string query = @" 
                                INSERT INTO Villas(Nombre, Detalle, Tarifa, Ocupantes, MetrosCuadrados, FechaCreacion, FechaActualizacion, ImagenUrl, Amenidad)
                                VALUES(@Nombre, @Detalle, @Tarifa, @Ocupantes, @MetrosCuadrados, @FechaCreacion, @FechaActualizacion, @ImagenUrl, @Amenidad)";
                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.Value = contact.Nombre;
                Nombre.DbType = System.Data.DbType.String;

                SqlParameter detalle = new SqlParameter("@Detalle", contact.Detalle);
                SqlParameter tarifa = new SqlParameter("@Tarifa", contact.Tarifa);
                SqlParameter ocupantes = new SqlParameter("@Ocupantes", contact.Ocupantes);
                SqlParameter metroscuadrados = new SqlParameter("@MetrosCuadrados", contact.MetrosCuadrados);
                // Asignar los valores de las fechas a los parámetros SqlParameter
                SqlParameter fechacreacion = new SqlParameter("@FechaCreacion", contact.FechaCreacion);
                SqlParameter fechaactualizacion = new SqlParameter("@FechaActualizacion", contact.FechaActualizacion);
                SqlParameter imagenurl = new SqlParameter("@ImagenUrl", contact.ImagenUrl);
                SqlParameter amenidad = new SqlParameter("@Amenidad",contact.Amenidad);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(detalle);
                command.Parameters.Add(tarifa);
                command.Parameters.Add(ocupantes);
                command.Parameters.Add(metroscuadrados);
                command.Parameters.Add(fechacreacion);
                command.Parameters.Add(fechaactualizacion);
                command.Parameters.Add(imagenurl);
                command.Parameters.Add(amenidad);
                command.ExecuteNonQuery();
                // Configuración de Twilio
                const string accountSid = "AC3cb001583be6dd3d8660978a22405dc6";
                const string authToken = "3e44d44fb068b1d54902d728038d594d";

                // Inicializar el cliente de Twilio
                TwilioClient.Init(accountSid, authToken);

                // Número de teléfono de origen y destino
                var fromPhoneNumber = new PhoneNumber("+12705696305");
                var toPhoneNumber = new PhoneNumber("+528180822052");

                // Contenido del mensaje
                var message = MessageResource.Create(
                    body: "¡Se ha insertado una nueva localidad desde escritorio!",
                    from: fromPhoneNumber,
                    to: toPhoneNumber
                );

                // Obtener el ID del mensaje enviado
                var messageId = message.Sid;

                MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            catch (Exception)
            {
                throw;
            }
            finally 
            { 
                conn.Close(); 
            }
        }

        public void UpdateContact(Contact contact) 
        {
            try
            {
                conn.Open();
                string query = @" UPDATE Villas
                                  SET Nombre = @Nombre,
                                      Detalle = @Detalle,
                                      Tarifa = @Tarifa,
                                      Ocupantes = @Ocupantes,
                                      MetrosCuadrados = @MetrosCuadrados,
                                      FechaCreacion = @FechaCreacion,
                                      FechaActualizacion = @FechaActualizacion,
                                      ImagenUrl = @ImagenUrl,
                                      Amenidad = @Amenidad
                                  WHERE Id = @Id";

                SqlParameter Id = new SqlParameter("@Id", contact.Id);
                SqlParameter nombre = new SqlParameter("@Nombre",contact.Nombre);
                SqlParameter detalle = new SqlParameter("@Detalle", contact.Detalle);
                SqlParameter tarifa = new SqlParameter("@Tarifa", contact.Tarifa);
                SqlParameter ocupantes = new SqlParameter("@Ocupantes", contact.Ocupantes);
                SqlParameter metroscuadrados = new SqlParameter("@MetrosCuadrados", contact.MetrosCuadrados);
                SqlParameter fechacreacion = new SqlParameter("@FechaCreacion", contact.FechaCreacion);
                SqlParameter fechaactualizacion = new SqlParameter("@FechaActualizacion", contact.FechaActualizacion);
                SqlParameter imagenurl = new SqlParameter("@ImagenUrl", contact.ImagenUrl);
                SqlParameter amenidad = new SqlParameter("@Amenidad", contact.Amenidad);


                SqlCommand command = new SqlCommand(@query, conn);
                command.Parameters.Add(Id);
                command.Parameters.Add(nombre);
                command.Parameters.Add(detalle);
                command.Parameters.Add(tarifa);
                command.Parameters.Add(ocupantes);
                command.Parameters.Add(metroscuadrados);
                command.Parameters.Add(fechacreacion);
                command.Parameters.Add(fechaactualizacion);
                command.Parameters.Add(@imagenurl);
                command.Parameters.Add(@amenidad);
                // Configuración de Twilio
                const string accountSid = "AC3cb001583be6dd3d8660978a22405dc6";
                const string authToken = "3e44d44fb068b1d54902d728038d594d";

                // Inicializar el cliente de Twilio
                TwilioClient.Init(accountSid, authToken);

                // Número de teléfono de origen y destino
                var fromPhoneNumber = new PhoneNumber("+12705696305");
                var toPhoneNumber = new PhoneNumber("+528180822052");

                // Contenido del mensaje
                var message = MessageResource.Create(
                    body: "¡Se ha modificado una localidad desde escritorio!",
                    from: fromPhoneNumber,
                    to: toPhoneNumber
                );

                // Obtener el ID del mensaje enviado
                var messageId = message.Sid;

                MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void DeleteContact(int Id)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM Villas WHERE Id = @Id";
                SqlCommand command = new SqlCommand(@query, conn);
                command.Parameters.Add(new SqlParameter("@Id", Id));
                // Configuración de Twilio
                const string accountSid = "AC3cb001583be6dd3d8660978a22405dc6";
                const string authToken = "3e44d44fb068b1d54902d728038d594d";

                // Inicializar el cliente de Twilio
                TwilioClient.Init(accountSid, authToken);

                // Número de teléfono de origen y destino
                var fromPhoneNumber = new PhoneNumber("+12705696305");
                var toPhoneNumber = new PhoneNumber("+528180822052");

                // Contenido del mensaje
                var message = MessageResource.Create(
                    body: "¡Se ha eliminado una localidad desde escritorio!",
                    from: fromPhoneNumber,
                    to: toPhoneNumber
                );

                // Obtener el ID del mensaje enviado
                var messageId = message.Sid;

                MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public List<Contact> GetContacts(string search = null)
        {
            List<Contact> contacts = new List<Contact>();
            try 
            {
                conn.Open();
                string query = @"SELECT Id, Nombre, Detalle, Tarifa, Ocupantes,
                                MetrosCuadrados, FechaCreacion, FechaActualizacion, ImagenUrl,
                                Amenidad
                                FROM Villas";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(search))
                {
                    query += @" WHERE Nombre LIKE @Search OR Detalle LIKE @Search OR Tarifa LIKE @Search
                              OR Amenidad LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    contacts.Add(new Contact
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Detalle = reader["Detalle"].ToString(),
                        Tarifa = int.Parse(reader["Tarifa"].ToString()),
                        Ocupantes = int.Parse(reader["Ocupantes"].ToString()),
                        MetrosCuadrados =int.Parse(reader["MetrosCuadrados"].ToString()),
                        FechaCreacion =DateTime.Parse(reader["FechaCreacion"].ToString()),
                        FechaActualizacion = DateTime.Parse(reader["FechaActualizacion"].ToString()),
                        ImagenUrl = reader["ImagenUrl"].ToString(),
                        Amenidad = reader["Amenidad"].ToString()
                    });  
                }
            } 

            catch (Exception)
            {
                throw;
            } 
            finally 
            { conn.Close(); }

            return contacts;
        }   
            
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
     public class Chats : ConexionBD
    {
        public static MySqlCommand ComandoC { get; set; }
        public static DataTable TablaC { get; set; }
        public static DataTable Conectados { get; set; }
        public static string TituloChat { get; set; }
        public static int SalaID { get; set; }
        public static string MensajeA { get; set; }
        public static string MensajeP { get; set; }
        public static string estatus { get; set;}
        public static string MateriaChat { get; set; }
        public static string ResumenChat { get; set; }

        public DataTable RellenarDataGrid(MySqlCommand Rellenar)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = Rellenar;
            DataTable Tabla = new DataTable();
            adaptador.Fill(Tabla);
            TablaC = Tabla;
            return TablaC;
        }

        public DataTable RellenarDataGridConectados(MySqlCommand Rellenar)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = Rellenar;
            DataTable Tabla = new DataTable();
            adaptador.Fill(Tabla);
            Conectados = Tabla;
            return Conectados;
        }

        public static bool BuscarConectados(int IDsalaBI)
        {
            try
            {
                conectar.Open();
                MySqlCommand BuscarIntegrantes = new MySqlCommand("Select Crea.estatus, Crea.ciA, Persona.Nombre, Persona.Apellido from Crea, Persona where idSala = '" + IDsalaBI + "' and Crea.ciA = Persona.CI;", conectar);
                BuscarIntegrantes.ExecuteNonQuery();
                Chats nuevo = new Chats();
                nuevo.RellenarDataGridConectados(BuscarIntegrantes);
                Error = false;
            } catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se pudo mostrar los integrantes de la sala" + e;
            } finally
            {
                conectar.Close();
            }
            return Error;
        }

        public bool BuscarEstatus(int CIbe, int IDbe)
        {
            try
            {
                conectar.Open();
                MySqlCommand BuscarEstatus = new MySqlCommand("Select estatus from Crea where idSala = '" + IDbe + "'", conectar);
                BuscarEstatus.ExecuteNonQuery();
                if (BuscarEstatus.ExecuteScalar().ToString() == "NULL")
                {
                    estatus = "Participante";
                    MySqlCommand crea = new MySqlCommand("insert into Crea (ciA, idSala, estatus) values ('" + CIbe + "', '" + IDbe + "', '" + estatus + "')", conectar);
                    crea.ExecuteNonQuery();
                } else if (BuscarEstatus.ExecuteScalar().ToString() == "Participante")
                {
                    mensaje = "Alumno registrado como participante";
                } else
                {
                    mensaje = "Alumno registrado como Anfitrion";
                }
                Error = false;

            }
            catch (MySqlException ea)
            {
                Error = true;
                mensaje = "Ocurrio un error al intentar ingresar a la sala " + ea;
            }finally
            {
                conectar.Close();
            }
            return Error;
        }


        public bool IngresaraSala(int CIisa, int IDis, string estatusIS)
        {
            try
            {
                conectar.Open();
                MySqlCommand crea = new MySqlCommand("insert into Crea (ciA, idSala, estatus) values ('" + CIisa + "', '" + IDis + "', '" + estatusIS + "')", conectar);
                crea.ExecuteNonQuery();
                estatus = estatusIS;
                Error = false;
            }
            catch (MySqlException e)
            {
                Error = false;
                mensaje = "Error al ingresar a la sala" + e;
            } finally
            {
                conectar.Close();
            }
            return Error;
        }

      
        public bool Verificar(string DocenteV, string GrupoV)
        {
            
                conectar.Open();
                MySqlCommand buscarProfesor = new MySqlCommand("Select usuarioP from Saladechat where usuarioP = '" + DocenteV + "' and grupo = '" + GrupoV + "';", conectar);
                MySqlCommand buscarGrupo = new MySqlCommand("Select grupo from Saladechat where usuarioP = '" + DocenteV + "' and grupo = '" + GrupoV + "';", conectar);
                buscarProfesor.ExecuteNonQuery();
                buscarGrupo.ExecuteNonQuery();
            try
            {
                buscarProfesor.ExecuteScalar().ToString();
                buscarGrupo.ExecuteScalar().ToString();
                Error = false;
            } catch (MySqlException e)
            {
                Error = true;
            }
            finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool CrearSalaChat(string GrupoCSC, string usuarioPSC, string nombreSC)
        {
            DateTime momento = new DateTime();
            int dia = momento.Day;
            int hour = momento.Hour;
            int anio = momento.Year;
            int mes = momento.Month;
            string cadenaTiempo = dia.ToString() + "-" + mes.ToString() + "-" + anio.ToString() + "-" + hour.ToString();
                     
            if (ConexionBD.Error == false)
            { 
                try { 
                    ConexionBD.conectar.Open();
                    MySqlCommand CrearSaladeChat = new MySqlCommand("insert into Saladechat (usuarioP, materia, nombre, grupo) values ('" + usuarioPSC + "', '" + ConexionBD.MateriaP + "', '" + nombreSC + "', '" + GrupoCSC + "')", ConexionBD.conectar);
                    CrearSaladeChat.ExecuteNonQuery();
                    MySqlCommand buscarid = new MySqlCommand("Select idSala from Saladechat where grupo = '" + GrupoCSC + "' and usuarioP = '" + usuarioPSC + "'", conectar);
                    buscarid.ExecuteNonQuery();
                    SalaID = Convert.ToInt32(buscarid.ExecuteScalar().ToString());
                    MySqlCommand CrearChat = new MySqlCommand("insert into Chat (idSala, resumen, fecha) values ('" + SalaID + "', 'TITULO CHAT: " + nombreSC + "', '" + cadenaTiempo + "')", ConexionBD.conectar);
                    CrearChat.ExecuteNonQuery();
                    conectar.Close();
                    Chats nuevo = new Chats();
                    nuevo.IngresaraSala(ConexionBD.CI, SalaID, "Anfitrion");
                    ConexionBD.Error = false;
                    ConexionBD.mensaje = "Sala creada correctamente";
                } catch (MySqlException e)
                {
                    ConexionBD.Error = true;
                    ConexionBD.mensaje = "Ocurrio un error al intetar crear la sala \n" + e;
                
                }finally
                {
                    conectar.Close();
                }
            } else
            {
                Error = true;
                mensaje = "Ya existe una sala con ese profesor";
            }
            return Error;
        }


        public bool DevolverSalaChat(int IDdsc)
        {
            try
            {
                conectar.Open();
                MySqlCommand TituloSala = new MySqlCommand("Select Nombre from Saladechat where idSala = '" + IDdsc + "'", conectar);
                MySqlCommand MateriaSala = new MySqlCommand("Select materia from Saladechat where idSala = '" + IDdsc + "'", conectar);
                MySqlCommand Resumen = new MySqlCommand("Select resumen from Chat where idSala = '" + IDdsc + "'", conectar);

                MateriaSala.ExecuteNonQuery();
                TituloSala.ExecuteNonQuery();
                Resumen.ExecuteNonQuery();
                TituloChat = TituloSala.ExecuteScalar().ToString();
                MateriaChat = MateriaSala.ExecuteScalar().ToString();
                ResumenChat = Resumen.ExecuteScalar().ToString();
                SalaID = IDdsc;
                Error = false;
                return Error;
            }
            catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se encontre el titulo del chat";
                return Error;
            }finally
            {
                conectar.Close();
            }
        }

        public bool EnviarMensajeA(string mensaje, int idEMA, string usuarioEMA)
        {
            
            try
            {
                conectar.Open();
                MySqlCommand InsertarMensaje = new MySqlCommand("update Chat set mensajeAc = '" + mensaje + "', resumen = concat(resumen,'\n    " + usuarioEMA + " : " + mensaje + "'), usuario = '" + usuarioEMA + "' where idSala = '" + idEMA + "'", ConexionBD.conectar);
                InsertarMensaje.ExecuteNonQuery();
                MensajeA = InsertarMensaje.ExecuteScalar().ToString();
                conectar.Close();
                
                Error = false;
                
            }catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se pudo enviar el mensaje";
                
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public bool EnviarMensajeP(string mensaje, int idEMP, string usuarioEMP)
        {
            try
            {
                conectar.Open();
                MySqlCommand InsertarMensajeP = new MySqlCommand("update Chat set mensajeRes = '" + mensaje + "', resumen = concat(resumen,'\n    " + usuarioEMP + " : " + mensaje + "'), usuario = '" + usuarioEMP + "' where idSala = '" + idEMP + "'", ConexionBD.conectar);
                InsertarMensajeP.ExecuteNonQuery();
                MensajeP = InsertarMensajeP.ExecuteScalar().ToString();
                Error = false;
                return Error;
            }
            catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se pudo enviar el mensaje";
                return Error;
            }
            finally
            {
                conectar.Close();
            }
        }

        public static bool MostrarSalasA(string GrupoMSA) 
        {
            try
            {
                conectar.Open();
                MySqlCommand mostrarSalaA = new MySqlCommand("Select Nombre, usuarioP, Materia, idSala from Saladechat where grupo = '" + GrupoMSA + "';", conectar);
                mostrarSalaA.ExecuteNonQuery();
                Chats nuevo = new Chats();
                nuevo.RellenarDataGrid(mostrarSalaA);
                Error = false;
                return Error;
            }
            catch (MySqlException e)
            {
                ConexionBD.Error = true;
                ConexionBD.mensaje = "No se pudo mostrar las salas";
                return Error;
            }
            finally
            {
                ConexionBD.conectar.Close();
            }
        }

        public static bool MostrarSalasP(string usuarioMSP)
        {
            try
            {
                conectar.Open();
                MySqlCommand mostrarSalaP = new MySqlCommand("Select Nombre, Grupo, idSala from Saladechat where usuarioP = '" + usuarioMSP + "'", conectar);
                mostrarSalaP.ExecuteNonQuery();
                Chats nueva = new Chats();
                nueva.RellenarDataGrid(mostrarSalaP);
                return Error;
            }
            catch (MySqlException e)
            {
                ConexionBD.Error = true;
                ConexionBD.mensaje = "No se pudo mostrar las salas";
                return Error;
            }
            finally
            {
                ConexionBD.conectar.Close();
            }
        }

        public static bool CerrarChat(int IDcc)
        {
            try
            {
                conectar.Open();
                MySqlCommand eliminarCrea = new MySqlCommand("delete from Crea where idSala = '" + IDcc + "';", conectar);
                eliminarCrea.ExecuteNonQuery();
                MySqlCommand eliminarChat = new MySqlCommand("delete from Chat where idSala = '" + IDcc + "';", conectar);
                eliminarChat.ExecuteNonQuery();
                MySqlCommand eliminarSala = new MySqlCommand("delete from Saladechat where idSala = '" + IDcc + "';", conectar);
                eliminarSala.ExecuteNonQuery();
                Error = false;
                mensaje = "Sala eliminada correctamente";
            } catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se puedo eliminar la sala" + e;
            } finally
            {
                conectar.Close();
            }
            return Error;
        }


    }
}

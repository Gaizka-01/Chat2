using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
    public class Consultas : ConexionBD
    {
        
        public static MySqlCommand Comando { get; set; }
        public static MySqlCommand ComandoMensajeA { get; set; }
        public static MySqlCommand ComandoMensajeP { get; set; }
        public static DataTable Tabla { get; set; }
        public static DataTable TablaMensajeA { get; set; }
        public static DataTable TablaMensajeP { get; set; }
        public static int IDCONSULTA { get; set; }


        public DataTable RellenarDataGrid(MySqlCommand Rellenar)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = Rellenar;
            DataTable TablaMA = new DataTable();
            adaptador.Fill(TablaMA);
            Tabla = TablaMA;
            return Tabla;
        }

        public DataTable RellenarDataGridMensajeA(MySqlCommand RellenarMA)
        {
            ComandoMensajeA = RellenarMA;
            MySqlDataAdapter adaptadorA = new MySqlDataAdapter();
            adaptadorA.SelectCommand = RellenarMA;
            DataTable TablaMA = new DataTable();
            adaptadorA.Fill(TablaMA);
            TablaMensajeA = TablaMA;
            return TablaMensajeA;
        }

        public DataTable RellenarDataGridMensajeP(MySqlCommand RellenarMP)
        {
            ComandoMensajeP = RellenarMP;
            MySqlDataAdapter adaptadorP = new MySqlDataAdapter();
            adaptadorP.SelectCommand = RellenarMP;
            DataTable TablaMP = new DataTable();
            adaptadorP.Fill(TablaMP);
            TablaMensajeP = TablaMP;
            return TablaMensajeP;
        }

        public static bool MostrarConsultasA(int CImca)
        {
            try
            {
                ConexionBD.conectar.Open();
                MySqlCommand mostrarConsultasA = new MySqlCommand("Select Consulta.temas, Persona.usuario, Consulta.id_consulta From Consulta, Persona where Consulta.ciA = '" + CImca + "' and Consulta.ciD = Persona.CI group by temas;", conectar);
                mostrarConsultasA.ExecuteNonQuery();
                Consultas nueva = new Consultas();
                nueva.RellenarDataGrid(mostrarConsultasA);
                ConexionBD.Error = false;
                return Error;
            } catch (MySqlException e)
            {
                ConexionBD.Error = true;
                ConexionBD.mensaje = "No se pudo mostrar las consultas";
                return Error;
            } finally
            {
                ConexionBD.conectar.Close();
            }
            
        }

        public static bool MostrarMensajeConsultaA(int idConsultaA)
        {
            IDCONSULTA = idConsultaA; 
            try
            {

                ConexionBD.conectar.Open();
                MySqlCommand mostrarMensajeA = new MySqlCommand("Select mensajeA as 'Mensaje Alumno' From Consulta where id_consulta = '" + IDCONSULTA + "'", conectar);
                mostrarMensajeA.ExecuteNonQuery();
                Consultas nuevaA = new Consultas();
                nuevaA.RellenarDataGridMensajeA(mostrarMensajeA);
                ConexionBD.Error = false;
                return Error;
            }
            catch (MySqlException e)
            {
                ConexionBD.Error = true;
                ConexionBD.mensaje = "No se pudo mostrar las consultas";
                return Error;
            } finally
            {
                ConexionBD.conectar.Close();
            }
        }

        public static bool EnviarMensajeA(string temaEA, string mensajeEA, int CIEA, string usuarioEAP)
        {
            DateTime momento = new DateTime();
            int dia = momento.Day;
            int hour = momento.Hour;
            int anio = momento.Year;
            int mes = momento.Month;
            string cadenaTiempo = dia.ToString() + "-" + mes.ToString() + "-" + anio.ToString() + "-" + hour.ToString();
            CapaLogica.Consultas.devolverPersona(usuarioEAP);
            try
            {
                conectar.Open();
                MySqlCommand insertarMensajeA = new MySqlCommand("insert into Consulta (temas, mensajeA, ciA, ciD, mensajeD, fecha) values ('" + temaEA +"', '" + mensajeEA + "', '" + CIEA +"', '" + CIP + "', 'NULL', '" + cadenaTiempo + "')", conectar);
                insertarMensajeA.ExecuteNonQuery();
                MySqlCommand buscarID = new MySqlCommand("select id_consulta from Consulta where temas = '" + temaEA + "' and ciA = '" + CI + "' and ciD = '" + CIP + "' and mensajeA = '" + mensajeEA + "'", conectar);
                buscarID.ExecuteNonQuery();
                IDCONSULTA = Convert.ToInt32(buscarID.ExecuteScalar());
                MySqlCommand LegajoMensaje = new MySqlCommand("update Legajo set mensajes = concat(mensajes,'\n " + mensajeEA + "') where CI = '" + CI + "'", CapaLogica.ConexionBD.conectar);
                LegajoMensaje.ExecuteNonQuery();
                conectar.Close();
                MostrarMensajeConsultaA(IDCONSULTA);
                CapaLogica.ConexionBD.RellenarLegajo(mensajeEA, CIEA);
                Error = false;
                mensaje = "Consulta Enviada";
                return Error;
            }catch (MySqlException e)
            {
                mensaje = "Hubo un error al intentar enviar el mensaje " + e;
                ConexionBD.Error = true;
                return Error;
            }


        }
        

        public static bool MostrarConsultasP(int CImcp)
        {
            try
            {
                ConexionBD.conectar.Open();
                MySqlCommand mostrarConsultasP = new MySqlCommand("Select Consulta.temas, Consulta.ciA, Persona.Grupo, Consulta.id_consulta From Consulta, Persona where Consulta.ciD = '" + CImcp + "' and Consulta.ciD = Persona.CI;", conectar);
                mostrarConsultasP.ExecuteNonQuery();
                Consultas nuevaP = new Consultas();
                nuevaP.RellenarDataGrid(mostrarConsultasP);
                ConexionBD.Error = false;
                return Error;
            }
            catch (MySqlException e)
            {
                ConexionBD.Error = true;
                ConexionBD.mensaje = "No se pudo mostrar las consultas";
                return Error;
            }
            finally
            {
                ConexionBD.conectar.Close();
            }

        }

        public static bool MostrarMensajeConsultaP(int idConsultaP)
        {
            IDCONSULTA = idConsultaP;
            try
            {
                ConexionBD.conectar.Open();
                MySqlCommand mostrarMensajeP = new MySqlCommand("Select mensajeD as 'Mensaje Docente' From Consulta where id_consulta = '" + IDCONSULTA + "'", conectar);
                mostrarMensajeP.ExecuteNonQuery();
                Consultas nuevaP = new Consultas();
                nuevaP.RellenarDataGridMensajeP(mostrarMensajeP);
                ConexionBD.Error = false;
                return Error;
            }
            catch (MySqlException e)
            {
                ConexionBD.Error = true;
                ConexionBD.mensaje = "No se pudo mostrar la respuesta del profesor";
                return Error;
            }
            finally
            {
                ConexionBD.conectar.Close();
            }
        }

        public static bool EnviarMensajeP(int idConsultEP, string MensajeP)
        {
            IDCONSULTA = idConsultEP;
            try
            {
                ConexionBD.conectar.Open();
                MySqlCommand insertarMensajeP = new MySqlCommand("update Consulta set mensajeD = '" + MensajeP + "' where id_consulta = '" + IDCONSULTA +"'", conectar);
                insertarMensajeP.ExecuteNonQuery();
                ConexionBD.Error = false;
                ConexionBD.mensaje = "Mensaje Enviado";
                return Error;
            }
            catch (MySqlException e)
            {
                mensaje = "Hubo un error al intentar enviar el mensaje";
                ConexionBD.Error = true;
                return Error;
            } finally
            {
                ConexionBD.conectar.Close();
            }
        }
    }
}

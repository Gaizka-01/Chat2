 using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaLogica
{
    public class ConexionBD
    {
        public static MySqlConnection conectar = new MySqlConnection("server = 192.168.5.50; port = 3306; database = south_technology; Uid = gabriel.acosta; pwd = 51154167;");
        public static DataTable Integrantes { get; set; }
        public static DataTable IDocentes { get; set; }


        public static int CI { get; set; }
        public static string usuario { get; set; }
        public static string usuarioP { get; set; }

        public static int CIP { get; set; }
        public static string Nombre { get; set; }
        public static string NombreP { get; set; }
        public static string Nickname { get; set; }

        public static string Apellido { get; set; }
        public static string ApellidoP { get; set; }

        public static string Grupo { get; set; }
        public static string GrupoP { get; set; }

        public static string Contrasenia { get; set; }
        public static string Materia { get; set; }
        public static string MateriaP { get; set; }
        public static string MensajeL { get; set; }

        public static bool Error = true;
        public static string mensaje;
        public static string Condicion;
        

        public static bool Conexion()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server = 192.168.5.50; port = 3306; database = south_technology; Uid = gabriel.acosta; pwd = 51154167;");
                conectar.Open();
                Error = false;
                
                
            }
            catch (MySqlException ex)
            {
                Error = true;
                
            }
            return Error;
        }

        public static bool CerrarConexion()
        {
                conectar.Close();
                return false; 
        }

        public DataTable RellenarDataGridIntegrantes(MySqlCommand Rellenar)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = Rellenar;
            DataTable Tabla = new DataTable();
            adaptador.Fill(Tabla);
            Integrantes = Tabla;
            return Integrantes;
        }

        public DataTable RellenarDataGridDocentes(MySqlCommand Rellenar)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = Rellenar;
            DataTable Tabla = new DataTable();
            adaptador.Fill(Tabla);
            IDocentes = Tabla;
            return IDocentes;
        }
        public static bool CambiarNickname (string CambiarN, int CIcn)
        {
            try
            {
                conectar.Open();
                MySqlCommand nuevoNick = new MySqlCommand("update Alumno set Nickname = '" + CambiarN + "' where CI = '" + CIcn + "';", conectar);
                nuevoNick.ExecuteNonQuery();
                Nickname = nuevoNick.ExecuteScalar().ToString();
                Error = false;
                mensaje = "Nickname actualizado";
            }
            catch (MySqlException e)
            {
                Error = true;
                mensaje = "Hubo un error al intentar actualizar el nickname";
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool CambiarMateriaP (int CIcgp, string GrupoCGP)
        {
            try
            {
                conectar.Open();
                MySqlCommand cambiardatosP = new MySqlCommand("update Docente set Materia = '" + GrupoCGP + "' where CI = '" + CIcgp + "';", conectar);
                cambiardatosP.ExecuteNonQuery();
                Error = false;
                mensaje = "Grupo actualizado";
            } catch (MySqlException e )
            {
                Error = true;
                mensaje = "No se pudo actualizar el grupo";
            } finally
            {
                conectar.Close();
            }
            return Error;

        }

        public static bool DevolverGrupo(string GrupoDG)
        {
            try
            {
                conectar.Open();
                MySqlCommand retornarIntegrantes = new MySqlCommand("Select Nombre, Apellido, CI From persona where Grupo = '" + GrupoDG + "' and activo = '1'", conectar);
                retornarIntegrantes.ExecuteNonQuery();
                ConexionBD nuevo = new ConexionBD();
                nuevo.RellenarDataGridIntegrantes(retornarIntegrantes);
                Error = false;
            }
            catch (MySqlException r)
            {
                Error = true;
                mensaje = "No se pudo mostrar la lista del grupo";
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public bool BuscarNickname(int CIbn)
        {
            try
            {
                conectar.Open();
                MySqlCommand NicknameA = new MySqlCommand("Select Nickname From alumno where CI = '" + CI + "'", conectar);
                NicknameA.ExecuteNonQuery();
                Nickname = NicknameA.ExecuteScalar().ToString();
                Error = false;
            } catch (MySqlException e)
            {
                Error = true;
                mensaje = "no se encontro ningun nickname";
            }
            return Error;
        }

        public static bool BajaUsuario(int CIbu)
        {
            try
            {
                conectar.Open();
                MySqlCommand Baja = new MySqlCommand("update Persona set activo = '0' where CI = '" + CIbu + "';", conectar);
                Baja.ExecuteNonQuery();
                Error = false;
                mensaje = "Usuario eliminado";
            }
            catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se pudo eliminar el usuario" + e;
            }finally
            {
                conectar.Close();
            }
            return Error;
        }
        public static bool DevolverAlumno(int CIDA)
        {
            CI = CIDA;
        try
        { 
            conectar.Open();
            MySqlCommand Nombreusu = new MySqlCommand("Select Nombre From Persona where CI = '" + CI + "' and activo = '1'", conectar);
            MySqlCommand Apellidousu = new MySqlCommand("Select Apellido From Persona where CI = '" + CI + "' and activo = '1'", conectar);
            MySqlCommand Grupousu = new MySqlCommand("Select Grupo From Persona where CI = '" + CI + "' and activo = '1'", conectar);
            Nombreusu.ExecuteNonQuery();
            Apellidousu.ExecuteNonQuery();
            Grupousu.ExecuteNonQuery();
            Nombre = Nombreusu.ExecuteScalar().ToString();
            Apellido = Apellidousu.ExecuteScalar().ToString();
            Grupo = Grupousu.ExecuteScalar().ToString();
            conectar.Close();
            ConexionBD nuevo = new ConexionBD();
                nuevo.BuscarNickname(CI);
                Error = false;
        } catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se encontro el alumno";
            } finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool devolverProfesor(int CIdp)
        {
            CIP = CIdp;
            try
            {
                conectar.Open();
                MySqlCommand Nombreusu = new MySqlCommand("Select Nombre From Persona where CI = '" + CIdp + "' and activo = '1'", conectar);
                MySqlCommand Apellidousu = new MySqlCommand("Select Apellido From Persona where CI = '" + CIdp + "' and activo = '1'", conectar);
                MySqlCommand Grupousu = new MySqlCommand("Select Grupo From Persona where CI = '" + CIdp + "' and activo = '1'", conectar);
                MySqlCommand Materia = new MySqlCommand("Select Materia From Docente where CI = '" + CIdp + "'", conectar);
                MySqlCommand UsuarioP = new MySqlCommand("Select usuario From Persona where CI = '" + CIdp + "' and activo = '1'", conectar);
                Nombreusu.ExecuteNonQuery();
                Apellidousu.ExecuteNonQuery();
                Grupousu.ExecuteNonQuery();
                Materia.ExecuteNonQuery();
                UsuarioP.ExecuteNonQuery();
                NombreP = Nombreusu.ExecuteScalar().ToString();
                ApellidoP = Apellidousu.ExecuteScalar().ToString();
                GrupoP = Grupousu.ExecuteScalar().ToString();
                MateriaP = Materia.ExecuteScalar().ToString();
                usuarioP = UsuarioP.ExecuteScalar().ToString();
                
                Error = false;
                return Error;
            } catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se encontro el profesor" + e;
                return Error;
            }finally
            {
                conectar.Close();
            }
        }

        public static bool devolverPersona(string usuarioDP)
        {
            try
            {
                conectar.Open();
                MySqlCommand cedulaP = new MySqlCommand("Select CI From Persona where usuario = '" + usuarioDP + "' and activo = '1'", conectar);
                cedulaP.ExecuteNonQuery();
                CIP = Convert.ToInt32(cedulaP.ExecuteScalar());                
                Error = false;
                return Error;

            }
            catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se encontro la persona" + e;
                return Error;
            }
            finally
            {
                conectar.Close();
            }
        }
        public static bool InsertarUsuario(string Inombre, string Iapellido, string Igrupo, string Icontrasenia, string Iusuario, int ICI)
        {
            Nombre = Inombre;
            Apellido = Iapellido;
            Grupo = Igrupo;
            Contrasenia = Icontrasenia;
            usuario = Iusuario;
            CI = ICI;
            conectar.Open();
            try
            {
                MySqlCommand Persona = new MySqlCommand("insert into Persona(CI, Nombre, Apellido, Grupo, Contraseña, usuario, activo) values ('" + CI + "', '" + Nombre + "', '" + Apellido + "', '" + Grupo + "', '" + Contrasenia + "', '" + usuario + "', '1');", conectar);
                Persona.ExecuteNonQuery();
                mensaje = "Usuario ingresado correctamente";
                conectar.Close();
                Error = false;  
                return Error;
            }
            catch (MySqlException e)
            {
                mensaje = "No se pudo ingresar la Persona a la Base de datos \n" + e;              
                Error = true;
                conectar.Close();
                return Error;
            }

                
        }

        public static bool InsertarAlumno(int ACI)
        {
            CI = ACI;
            conectar.Open();
            DateTime momento = new DateTime();
            int dia = momento.Day;
            int hour = momento.Hour;
            int anio = momento.Year;
            int mes = momento.Month;
            string cadenaTiempo = dia.ToString() + "-" + mes.ToString() + "-" + anio.ToString();
            try
            {
                MySqlCommand Alumno = new MySqlCommand("insert into Alumno(CI, Nickname) values ('" + CI + "', 'NULL');", CapaLogica.ConexionBD.conectar);
                Alumno.ExecuteNonQuery();
                MySqlCommand LegajoA = new MySqlCommand("insert into Legajo(CI, mensajes) values ('" + CI + "', ' ');", CapaLogica.ConexionBD.conectar);
                LegajoA.ExecuteNonQuery();
                mensaje = mensaje + "\n Alumno ingresado correctamente";
                conectar.Close();
                Error = false;
                return Error;
            } catch (MySqlException e)
            {
                mensaje = mensaje + "\n No se pudo ingresar el Alumno a la Base de datos \n" + e;
                Error = true;
                conectar.Close();               
                return Error; 
            }
           
        }

        public static bool InsertarProfesor(int CIP, string Pmateria)
        {
            CI = CIP;
            Materia = Pmateria;
            
            conectar.Open();
            try
            {
                MySqlCommand Profesor = new MySqlCommand("insert into Docente(CI, Materia) values ('" + CI + "','" + Materia + "');", conectar);
                Profesor.ExecuteNonQuery();
                mensaje = mensaje + "\n Profesor ingresado correctamente";
                conectar.Close();
                Error = false;
                return Error;
            } catch (MySqlException e)
            {
                mensaje = mensaje + "\n No se pudo ingresar el Profesor a la Base de datos \n" + e;
                Error = true;
                conectar.Close();
                return Error;
            }
            
        }

        public static bool BuscarUsuario (string NombreUsuB, int CIB, string ContraseniaB, string CondicionB)
        {
            usuario = NombreUsuB;
            CI = CIB;
            Contrasenia = ContraseniaB;
            Condicion = CondicionB;
            conectar.Open();
            MySqlCommand buscarusu = new MySqlCommand("Select usuario, Contraseña from Persona where usuario = '" + usuario + "' and Contraseña = '" + Contrasenia + "' and activo = '1'", conectar);
            buscarusu.ExecuteNonQuery();
            MySqlDataReader verificarusu = buscarusu.ExecuteReader();
            if (verificarusu.Read())
            {
                conectar.Close();
                switch (Condicion)
                {
                    case "Alumno":
                        conectar.Open();
                        MySqlCommand buscarA = new MySqlCommand("Select CI from Alumno where CI = '" + CI + "'", conectar);
                        buscarA.ExecuteNonQuery();
                        MySqlDataReader verificarA = buscarA.ExecuteReader();
                        if (verificarA.Read())
                        {

                            Error = false;
                            mensaje = "Usuario registrado como Alumno";
                            
                        }
                        else
                        {
                            mensaje = "Usuario no registrado como Alumno";
                            Error = true;
                            
                        }
                        conectar.Close();
                        break;

                    case "Docente":
                        conectar.Open();
                        MySqlCommand buscarP = new MySqlCommand("Select CI from Docente where CI = '" + CI + "'", conectar);
                        buscarP.ExecuteNonQuery();
                        MySqlDataReader verificarP = buscarP.ExecuteReader();
                        if (verificarP.Read())
                        {
                            Error = false;
                            mensaje = "Usuario registrado como Docente";
                            
                        }
                        else
                        {
                            mensaje = "Usuario no registrado como Docente";
                            Error = true;
                        }
                        conectar.Close();
                        break;
                }
            } else
            {
                mensaje = "Usuario no registrado";
            }
            conectar.Close();
            return Error;
        }

        public static bool RellenarLegajo(string mensajeRL, int CIrl)
        {
            try
            {
                conectar.Open();
                MySqlCommand rellenar = new MySqlCommand("update Legajo set mensajes = concat(mensajes,' \n " + mensajeRL + "') where CI = '" + CIrl + "';", conectar);
                rellenar.ExecuteNonQuery();
                Error = false;
            } catch (MySqlException E)
            {
                Error = true;
                mensaje = "No se pudo actualizar el legajo" + E;
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool MensajesLegajo(int CIml)
        {
            try
            {
                conectar.Open();
                MySqlCommand buscarMensaje = new MySqlCommand("Select mensajes from Legajo where CI = '" + CIml + "'", conectar);
                buscarMensaje.ExecuteNonQuery();
                MensajeL = buscarMensaje.ExecuteScalar().ToString();
                Error = false;
            } catch (MySqlException e)
            {
                Error = true;
                mensaje = "No hay mensajes para mostrar" + e;
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool Docentes()
        {
            try
            {
                conectar.Open();
                MySqlCommand docentes = new MySqlCommand("Select * from Docente", conectar);
                docentes.ExecuteNonQuery();
                ConexionBD nuevo = new ConexionBD();
                nuevo.RellenarDataGridDocentes(docentes);
                Error = false;

            } catch (MySqlException a)
            {
                Error = true;
            } finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool MostrarCambiarDatosA(string GrupoCDA)
        {
            try
            {
                conectar.Open();
                MySqlCommand retornarIntegrantesMCDA = new MySqlCommand("Select Persona.Nombre, Persona.Apellido, Alumno.Nickname, Persona.Grupo, Persona.CI From Persona, Alumno where Grupo = '" + GrupoCDA + "' and Persona.CI = Alumno.CI and Persona.activo = '1'", conectar);
                retornarIntegrantesMCDA.ExecuteNonQuery();
                ConexionBD nuevo = new ConexionBD();
                nuevo.RellenarDataGridIntegrantes(retornarIntegrantesMCDA);
                Error = false;
            }
            catch (MySqlException e)
            {
                Error = true;
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool CambiarDatosA (int CIcda, string NombreCDA, string ApellidoCDA, string NicknameCDA)
        {
            try
            {
                conectar.Open();
                MySqlCommand cambiardatos = new MySqlCommand("update Persona set Nombre = '" + NombreCDA + "', Apellido = '" + ApellidoCDA + "' where CI = '" + CIcda + "';", conectar);
                cambiardatos.ExecuteNonQuery();
                MySqlCommand cambiardatosA = new MySqlCommand("update Alumno set Nickname = '" + NicknameCDA + "' where CI = '" + CIcda + "';", conectar);
                cambiardatosA.ExecuteNonQuery();
                Error = false;
                mensaje = "Datos actualizados";
            }
            catch (MySqlException a)
            {
                Error = true;
                mensaje = "No se pudieron actualizar los datos" + a;
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool CambiarDatosP(int CIcdp, string NombreCDP, string ApellidoCDP, string NicknameCDP)
        {
           try{ 
                conectar.Open();
                MySqlCommand cambiardatos = new MySqlCommand("update Persona set Nombre = '" + NombreCDP + "', Apellido = '" + ApellidoCDP + "' where CI = '" + CIcdp + "';", conectar);
                cambiardatos.ExecuteNonQuery();
                MySqlCommand cambiardatosP = new MySqlCommand("update Docente set Materia = '" + NicknameCDP + "' where CI = '" + CIcdp + "';", conectar);
                cambiardatosP.ExecuteNonQuery();
                Error = false;
                mensaje = "Datos actualizados";
            }
            catch (MySqlException a)
            {
                Error = true;
                mensaje = "No se pudieron actualizar los datos" + a;
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool RellenarAgenda(int CIra, string DiasRA)
        {
            try
            {
                conectar.Open();
                MySqlCommand Agenda = new MySqlCommand("insert into Agenda(CI, diaConexion) values ('" + CIra + "', '" + DiasRA + "');", CapaLogica.ConexionBD.conectar);
                Agenda.ExecuteNonQuery();
                Error = false;
                mensaje = "Agenda actualizada";

            }
            catch (MySqlException e)
            {
                Error = true;
                mensaje = "Error al intentar actualizar la agenda";
            }finally
            {
                conectar.Close();
            }
            return Error;
        }

        public static bool MostrarAgenda()
        {
            try
            {
                conectar.Open();
                MySqlCommand mostrarAgenda = new MySqlCommand("select * from Agenda;", conectar);
                mostrarAgenda.ExecuteNonQuery();
                ConexionBD nuevo = new ConexionBD();
                nuevo.RellenarDataGridDocentes(mostrarAgenda);
                Error = false;
            }
            catch (MySqlException e)
            {
                Error = true;
                mensaje = "No se pudo mostrar la agenda";
            }
            finally
            {
                conectar.Close();
            }
            return Error;

        }

        public static bool MostrarCambiarDatosP()
        {
            try
            {
                conectar.Open();
                MySqlCommand retornarIntegrantesMCDA = new MySqlCommand("Select Persona.Nombre, Persona.Apellido, Docente.Materia, Persona.Grupo, Persona.CI From Persona, Docente where Persona.CI = Docente.CI and Persona.activo = '1'", conectar);
                retornarIntegrantesMCDA.ExecuteNonQuery();
                ConexionBD nuevo = new ConexionBD();
                nuevo.RellenarDataGridIntegrantes(retornarIntegrantesMCDA);
                Error = false;
            }
            catch (MySqlException e)
            {
                Error = true;
            }
            finally
            {
                conectar.Close();
            }
            return Error;
        }

    }

    
}

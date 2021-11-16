using System;
using System.Collections.Generic;
using System.Text;
using CapaLogica;
using System.Data;
using CapaLogica;
namespace CapaDatos
{
    public class Usuario
    {
        public static int CI { get; set; }
        public static int CIP { get; set; }
        public static string usuario { get; set; }
        public static string usuarioP { get; set; }
        public static DataTable Integrantes { get; set; }

        public static string Nombre { get; set; }
        public static string NombreP { get; set; }
        public static string Nickname { get; set; }

        public static string Apellido { get; set; }
        public static string ApellidoP { get; set; }

        public static string Grupo { get; set; }
        public static string GrupoP { get; set; }
        public static string MensajeL { get; set; }

        public static string Materia { get; set; }
        public static string materiaP { get; set; }
        public static string Contrasenia { get; set; }
        public static string Condicion { get; set; }
        public static bool Error = true;
        public static string mensaje;

        public static string Persona(int PCI, string Pnombre, string Papellido, string Pgrupo, string Pcontrasenia, string Pusuario)
        {
            CI = PCI;
            Nombre = Pnombre;
            Apellido = Papellido;
            usuario = Pusuario;
            Grupo = Pgrupo;
            Contrasenia = Pcontrasenia;
            CapaLogica.ConexionBD.InsertarUsuario(Nombre, Apellido, Grupo, Contrasenia, usuario, CI);
            if (CapaLogica.ConexionBD.Error == false)
            {
                mensaje = CapaLogica.ConexionBD.mensaje;
                Error = false;
                return mensaje;
            } else
            {
                mensaje = CapaLogica.ConexionBD.mensaje; 
                Error = true;
                return mensaje;
            }

        }

    


        public static bool DevolverGrupo(string GrupoDG)
        {
            try
            {
                CapaLogica.ConexionBD.DevolverGrupo(GrupoDG);
                Integrantes = CapaLogica.ConexionBD.Integrantes;
                Error = false;
            }catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }


        public static bool DevolverAlumno(int CIDA)
        {
            CI = CIDA;
            try {
                CapaLogica.ConexionBD.DevolverAlumno(CI);
                Nombre = CapaLogica.ConexionBD.Nombre;
                Apellido = CapaLogica.ConexionBD.Apellido;
                Grupo = CapaLogica.ConexionBD.Grupo;
                Nickname = CapaLogica.ConexionBD.Nickname;
                Error = false;
                return Error;
            }catch (Exception e)
            {
                Error = true;
            }
            return Error;


        }

        public static bool DevolverProfesor(int CIdp)
        {
            try
            {
                
                CapaLogica.ConexionBD.devolverProfesor(CIdp);
                Usuario.NombreP = CapaLogica.ConexionBD.NombreP;
                Usuario.ApellidoP = CapaLogica.ConexionBD.ApellidoP;
                Usuario.GrupoP = CapaLogica.ConexionBD.GrupoP;
                Usuario.usuarioP = CapaLogica.ConexionBD.usuarioP;
                Usuario.materiaP = CapaLogica.ConexionBD.MateriaP;
                Usuario.CIP = CapaLogica.ConexionBD.CIP;
                Error = false;
                
            }
            catch (Exception e)
            {
                Error = true;
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                
            }
            return Error;
        }

        public static bool DevolverPersona(string usuDP)
        {
            try
            {

                CapaLogica.ConexionBD.devolverPersona(usuDP);                
                Usuario.CIP = CapaLogica.ConexionBD.CIP;
                Error = false;
                
            }
            catch (Exception e)
            {
                Error = true;
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                
            }

            return Error;
        }





        public static string Alumno(int ACI)
        {
           
            CI = ACI;
           
           CapaLogica.ConexionBD.InsertarAlumno(CI);
            if (CapaLogica.ConexionBD.Error == false)
            {
                mensaje = mensaje + "\n " + CapaLogica.ConexionBD.mensaje;
                Error = false;
                return mensaje;
            }
            else
            {
                mensaje = mensaje + "\n " + CapaLogica.ConexionBD.mensaje;
                Error = true;
                return mensaje;
            }
        }

        public static string Profesor(int CIP, string Pmateria)
        {
            CI = CIP;
            Materia = Pmateria;
            
            CapaLogica.ConexionBD.InsertarProfesor(CI, Materia);
            if (CapaLogica.ConexionBD.Error == false)
            {
                mensaje = mensaje + "\n " + CapaLogica.ConexionBD.mensaje;
                Error = false;
                return mensaje;
            }
            else
            {
                mensaje = mensaje + "\n " + CapaLogica.ConexionBD.mensaje;
                Error = true;
                return mensaje;
            }
        }

        public static string BuscarUsuario(string NombreUsuB, int CIB, string ContraseniaB, string CondicionB)
        {
            usuario = NombreUsuB;
            CI = CIB;
            Contrasenia = ContraseniaB;
            Condicion = CondicionB;
            CapaLogica.ConexionBD.BuscarUsuario(usuario, CIB, ContraseniaB, Condicion);
            if (CapaLogica.ConexionBD.Error == false && Condicion == "Alumno")
            {
                mensaje = CapaLogica.ConexionBD.mensaje;
                
                CapaDatos.Usuario.DevolverAlumno(CI);
                
                Error = false;
                return mensaje;
            } else if (CapaLogica.ConexionBD.Error == false && Condicion == "Docente")
            {
                mensaje = CapaLogica.ConexionBD.mensaje;
                
                CapaDatos.Usuario.DevolverProfesor(CI);
                Error = false;
                return mensaje;
            }
            else
            {
                mensaje = CapaLogica.ConexionBD.mensaje;
                Error = true;
                return mensaje;
            }
        }

        public static bool CambiarNickname(string CambiarN, int CIcn)
        {
            try
            {
                CapaLogica.ConexionBD.CambiarNickname(CambiarN, CIcn);
                Usuario.Nickname = CapaLogica.ConexionBD.Nickname;
                Error = false;
            }
            catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }

        public static bool BajaUsuario(int CIbu)
        {
            try
            {
                CapaLogica.ConexionBD.BajaUsuario(CIbu);
                Usuario.Error = false;
                mensaje = CapaLogica.ConexionBD.mensaje; 
            }catch (Exception e)
            {
                Usuario.Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }

        public static bool MensajesLegajo(int CIml)
        {
            try
            {
                CapaLogica.ConexionBD.MensajesLegajo(CIml);
                MensajeL = CapaLogica.ConexionBD.MensajeL;
                Error = false;
            } catch (Exception e)
            {
                Usuario.Error = true;
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
            
        }

        public static bool Docentes()
        {
            CapaLogica.ConexionBD.Docentes();
            Integrantes = CapaLogica.ConexionBD.IDocentes;
            Error = false;
            return Error;
        }

        public static bool MostrarCambiarDatosA(string GrupoCDA)
        {
            try
            {
                CapaLogica.ConexionBD.MostrarCambiarDatosA(GrupoCDA);
                Integrantes = CapaLogica.ConexionBD.Integrantes;
                Error = false;
            } catch (Exception a)
            {
                Error = true;
                mensaje = "No se pueden mostrar los alumnos";
            }
            return Error;
        }

        public static bool CambiarDatosA(int CIcda, string NombreCDA, string ApellidoCDA, string NicknameCDA)
        {
            try
            {
                CapaLogica.ConexionBD.CambiarDatosA(CIcda, NombreCDA, ApellidoCDA, NicknameCDA);
                Error = false;
                mensaje = CapaLogica.ConexionBD.mensaje;
            } catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }
        public static bool CambiarDatosP(int CIcdp, string NombreCDP, string ApellidoCDP, string MateriaCDP)
        {
            try
            {
                CapaLogica.ConexionBD.CambiarDatosP(CIcdp, NombreCDP, ApellidoCDP, MateriaCDP);
                Error = false;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }

        public static bool MostrarCambiarDatosP()
        {
            try
            {
                CapaLogica.ConexionBD.MostrarCambiarDatosP();
                Integrantes = CapaLogica.ConexionBD.Integrantes;
                Error = false;
            }
            catch (Exception a)
            {
                Error = true;
                mensaje = "No se pueden mostrar los docentes";
            }
            return Error;
        }

        public static bool CambiarMateriaP(int CIcgp, string GrupoCGP)
        {
            try
            {
                CapaLogica.ConexionBD.CambiarMateriaP(CIcgp, GrupoCGP);
                Error = false;
                mensaje = CapaLogica.ConexionBD.mensaje;
            } catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }
        
        public static bool RellenarAgenda(int CIra, string DiaRA)
        {
            try
            {
                CapaLogica.ConexionBD.RellenarAgenda(CIra, DiaRA);
                Error = false;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }catch (Exception asa)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }

        public static bool MostrarAgenda()
        {
            try
            {
                CapaLogica.ConexionBD.MostrarAgenda();
                Integrantes = CapaLogica.ConexionBD.IDocentes;
                Error = false;
            } catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }

    }



}

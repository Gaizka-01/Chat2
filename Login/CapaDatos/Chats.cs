using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaLogica;

namespace CapaDatos
{
    public class Chats : Usuario
    {
        public static DataTable TablaC { get; set; }
        public static DataTable Conectados { get; set; }
        public static string MensajeA { get; set; }
        public static string TituloChat { get; set; }
        public static string MateriaChat { get; set; }
        public static int IDsala { get; set; }
        public static string ResumenChat { get; set; }
        public static string estatus { get; set; }

        public static bool IngresaraSala(int CIisa, int IDis, string estatusIS)
        {
            try
            {
                CapaLogica.Chats nuevo = new CapaLogica.Chats();
                nuevo.IngresaraSala(CIisa, IDis, estatusIS);
                estatus = estatusIS;
                Error = false;
            }catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }


        public static bool BuscarEstatus(int CIbe, int IDbe)
        {
            try
            {
                CapaLogica.Chats nuevo = new CapaLogica.Chats();
                nuevo.BuscarEstatus(CIbe, IDbe);
                Error = false;
            }catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }

        public static bool BuscarConectados(int IDsalaBI)
        {
            try
            {
                CapaLogica.Chats.BuscarConectados(IDsalaBI);
                Conectados = CapaLogica.Chats.Conectados;
                Error = false;
            }catch (Exception E)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }




        public bool InsertarMensaje(string mensaje, int IDim, string usuarioIM)
        {
            try
            {
                CapaLogica.Chats nuevo = new CapaLogica.Chats();
                nuevo.EnviarMensajeA(mensaje, IDim, usuarioIM);
                Error = false;
                return Error;
            }catch (Exception e)
            {
                mensaje = "No se pudo insertar el mensaje";
                return Error; 
            }
        }

        public bool InsertarMensajeP(string mensaje, int IDimp, string usuarioIMP)
        {
            try
            {
                CapaLogica.Chats nuevo = new CapaLogica.Chats();
                nuevo.EnviarMensajeP(mensaje, IDimp, usuarioIMP);
                Error = false;
                return Error;
            }
            catch (Exception e)
            {
                mensaje = "No se pudo insertar el mensaje";
                return Error;
            }
        }

        public bool BuscarSala(int IDbs)
        {
            try
            {
                CapaLogica.Chats nuevo = new CapaLogica.Chats();
                nuevo.DevolverSalaChat(IDbs);
                TituloChat = CapaLogica.Chats.TituloChat;
                MateriaChat = CapaLogica.Chats.MateriaChat;
                IDsala = CapaLogica.Chats.SalaID;
                ResumenChat = CapaLogica.Chats.ResumenChat;
                Error = false;
                return Error;

            }catch (Exception e)
            {
                Error = true;
                CapaDatos.Usuario.mensaje = "No se encontro la sala";
                return Error;
            }
        }
        public static string CrearSalaChat(string GrupoCSC, string usuarioPSC, string nombreSC)
        {

            CapaLogica.Consultas.devolverPersona(usuarioPSC);
            CapaLogica.Consultas.devolverProfesor(CapaLogica.ConexionBD.CIP);
            CapaLogica.Chats.CrearSalaChat(GrupoCSC, ConexionBD.usuarioP, nombreSC);

            if (CapaLogica.ConexionBD.Error == false)
            {
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                return Usuario.mensaje;
            }else
            {
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                return Usuario.mensaje;
            }
        }


        public static bool MostrarSalasA(string GrupoMSA)
        {
            CapaLogica.Chats.MostrarSalasA(GrupoMSA);
            if (CapaLogica.ConexionBD.Error == false)
            {
                CapaDatos.Chats.TablaC = CapaLogica.Chats.TablaC;
                CapaDatos.Usuario.Error = false;
                return Error;
            } else
            {
                CapaDatos.Usuario.Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
                return Error;
            }
        }

        public static bool MostrarSalasP(string usuMSP)
        {
            CapaLogica.Chats.MostrarSalasP(usuMSP);
            if (CapaLogica.ConexionBD.Error == false)
            {
                DataTable MSP = new DataTable();
                MSP = CapaLogica.Chats.TablaC;
                CapaDatos.Chats.TablaC = MSP;
                CapaDatos.Usuario.Error = false;
                return Error;
            }
            else
            {
                CapaDatos.Usuario.Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
                return Error;
            }
        }

        public static bool CerrarChat(int IDcc)
        {
            try
            {
                CapaLogica.Chats.CerrarChat(IDcc);
                Error = false;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }catch (Exception e)
            {
                Error = true;
                mensaje = CapaLogica.ConexionBD.mensaje;
            }
            return Error;
        }


    }


}

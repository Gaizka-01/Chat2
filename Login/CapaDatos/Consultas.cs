using System;
using System.Collections.Generic;
using System.Text;
using CapaLogica;
using System.Data;
using CapaLogica;

namespace CapaDatos
{
    public class Consultas : Usuario
    {
        public static DataTable Tabla { get; set; }
        public static DataTable TablaMensajeA { get; set; }
        public static DataTable TablaMensajeP { get; set; }
        public static int IDCONSULTA { get; set; }


        public static bool MostrarConsultasA(int CImc)
        {
            CapaLogica.Consultas.MostrarConsultasA(CImc);
            if (CapaLogica.ConexionBD.Error == false)
            {
                Consultas.Tabla = CapaLogica.Consultas.Tabla;
                Usuario.Error = false;
                return Error;
            }
            else
            {
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                Usuario.Error = true;
                return Error;
            }
        }

        public static bool MostrarMensajeConsultaA(int idConsultaA)
        {
            Consultas.IDCONSULTA = idConsultaA;
            CapaLogica.Consultas.MostrarMensajeConsultaA(Consultas.IDCONSULTA);
            if (CapaLogica.ConexionBD.Error == false)
            {
                Consultas.TablaMensajeA = CapaLogica.Consultas.TablaMensajeA;
                Usuario.Error = false;
                return Error;
            }
            else
            {
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                Usuario.Error = true;
                return Error;
            }
        }

        public static bool EnviarMensajeA(string temaEA, string mensajeEA, int CIEA, string usuarioEAP)
        {
            CapaLogica.Consultas.EnviarMensajeA(temaEA, mensajeEA, CIEA, usuarioEAP);
            if (CapaLogica.ConexionBD.Error == false)
            {
                DataTable TablaMMC = new DataTable();
                TablaMMC = CapaLogica.Consultas.TablaMensajeA;
                Consultas.TablaMensajeA = TablaMMC;
                CapaDatos.Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                CapaDatos.Usuario.Error = false;
                return CapaDatos.Usuario.Error;
            }
            else
            {
                CapaDatos.Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                CapaDatos.Usuario.Error = true;
                return CapaDatos.Usuario.Error;
            }
        }

        public static bool MostrarConsultasP(int CImcp)
        {
            CapaLogica.Consultas.MostrarConsultasP(CImcp);
            if (CapaLogica.ConexionBD.Error == false)
            {
                DataTable TablaMCP = new DataTable();
                TablaMCP = CapaLogica.Consultas.Tabla;
                Consultas.Tabla = TablaMCP;
                Usuario.Error = false;
                return Error;
            }
            else
            {
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                Usuario.Error = true;
                return Error;
            }
        }

        public static bool MostrarMensajeConsultaP(int idConsultaP)
        {
            CapaDatos.Consultas.IDCONSULTA = idConsultaP;
            CapaLogica.Consultas.MostrarMensajeConsultaP(CapaDatos.Consultas.IDCONSULTA);
            if (CapaLogica.ConexionBD.Error == false)
            {
                DataTable TablaMMP = new DataTable();
                TablaMMP = CapaLogica.Consultas.TablaMensajeP;
                Consultas.TablaMensajeP = TablaMMP;
                Usuario.Error = false;
                return Error;
            }
            else
            {
                Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                Usuario.Error = true;
                return Error;
            }
        }

        public static bool EnviarMensajeP(int idConsultEP, string MensajeP)
        {
            CapaDatos.Consultas.IDCONSULTA = idConsultEP;
            CapaLogica.Consultas.EnviarMensajeP(CapaDatos.Consultas.IDCONSULTA, MensajeP);
            if (CapaLogica.ConexionBD.Error == false)
            {
                CapaDatos.Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                CapaDatos.Usuario.Error = false;
                return CapaDatos.Usuario.Error;
            }
            else
            {
                CapaDatos.Usuario.mensaje = CapaLogica.ConexionBD.mensaje;
                CapaDatos.Usuario.Error = true;
                return CapaDatos.Usuario.Error;
            }
        }
    }
}

using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace WebService
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public void RegistrarAparato(Aparatos aparato)
        {
            WebServEntities db = new WebServEntities();
            db.Database.BeginTransaction();
            try
            {
                db.RegistrarAparato(aparato.Pais, aparato.Ciudad, aparato.Magnitud, aparato.Profundidad, aparato.Geolocalizacion);
                log.Info($"Llamada desde Windows Service {DateTime.Now}");
                db.Database.CurrentTransaction.Commit();
            }
            catch (Exception ex)
            {
                db.Database.CurrentTransaction.Rollback();

                log.Error($"Error en llamada desde Windows Service {DateTime.Now}",ex);
                throw;
            }
        }
    }
}

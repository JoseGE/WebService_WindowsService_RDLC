using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected override void OnStart(string[] args)
        {
            System.Timers.Timer MyTimer = new System.Timers.Timer();
            MyTimer.Interval = int.Parse(ConfigurationManager.AppSettings["intervalo"]); // 45 mins
            MyTimer.Elapsed += new ElapsedEventHandler(timer1_Tick);
            MyTimer.Enabled = true;
            MyTimer.Start();

        }

        protected override void OnStop()
        {
            log.Info("SERVICIO DETENIDO");
            timer1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            WebServ.WebServiceSoapClient webService = new WebServ.WebServiceSoapClient();
            WebServ.Aparatos aparato = new WebServ.Aparatos();
            aparato.Pais = "";
            aparato.Ciudad = "";
            aparato.Geolocalizacion = "";
            aparato.Magnitud = 0;
            aparato.Profundidad = 0;
            webService.RegistrarAparato(aparato);
        }
    }
}

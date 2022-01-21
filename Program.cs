using log4net.Config;
using log4net.Repository;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Log4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new FileInfo("C:\\Users\\XXXXX\\source\\repos\\Log4\\Log4\\Log4net.config"));
            Type type = MethodBase.GetCurrentMethod().DeclaringType;
            var log = LogManager.GetLogger(type);
            var repository = log?.Logger.Repository;
            if (repository != null)
            {
                var st = repository.GetAppenders();

                var _adoAppender = repository.GetAppenders()
                    .FirstOrDefault(a => a is AdoNetAppender) as AdoNetAppender;
                    
                if (_adoAppender != null && string.IsNullOrEmpty(_adoAppender.ConnectionStringName))
                {
                    _adoAppender.ConnectionString = "Data Source=desktop-5g6mqfc;Initial Catalog=GermanyDB;User ID=desa;Password=123456;";
                    _adoAppender.ActivateOptions();
                }
            }

            log.Error("asdfasdfasdf");
            log.Info("Shutting down");
            log.Error("Starting up");
            log.Info("Shutting down");
            log.Debug("Starting up");
            log.Debug("Shutting down");
            Console.Read();
        }
    }
}

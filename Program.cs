using log4net;
using log4net.Config;
using LoggingLog4Net;
using System.Runtime.CompilerServices;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

var builder = WebApplication.CreateBuilder(args);

XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

var app = builder.Build();

ILog log = LogManager.GetLogger(typeof(Program));

log.Info("Entering application");

Bar bar = new Bar();

bar.DoIt();

bar.ConnectionCheck();

log.Info("Exiting application.");

app.MapGet("/", () => "Hello World!");

app.Run();

using System;
using Serilog;

namespace HelloDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .CreateLogger();

            LogData logObj = new LogData{Message="message with Serilog!", Number=123};
            Log.Information("{Message}{number}", logObj.Message, logObj.Number);

            Log.Information("{@log}", logObj);

            // var number =123;
            // Log.Information("Hello First Docker Console with Serilog!{number}", number);
            // Log.Warning("Hello First Docker Console with Serilog!{number}", number);
            //Log.Error(new ArgumentOutOfRangeException(), "Hello First Docker Console with Serilog!");
            Console.WriteLine("Hello First Docker Console!");
        }
    }
    class LogData
    {
        public string Message { get; set; }
        public int Number { get; set; }
    }
}

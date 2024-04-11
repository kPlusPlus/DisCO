using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog.Windows.Forms;
using NLog;

namespace DisCO
{
    public static class Globals
    {
        // --- NLOG ---
        public static bool ShowHideLog = false;        
        public static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();


        public static void NLOG_Config(string sFileName = "Nlog.log")
        {
            var config = new NLog.Config.LoggingConfiguration();
            RichTextBoxTarget target = new RichTextBoxTarget();

            target.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}";            

            target.ControlName = "rtbLog2";
            target.FormName = "frmMainAkdamar";

            target.UseDefaultRowColoringRules = true;
            target.ToolWindow = true;
            target.ShowMinimized = true;
            config.AddTarget("rtbLog", target);

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = sFileName };

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, target);

            // Apply config
            NLog.LogManager.Configuration = config;
        }

        public static void NLOG_ConfigShow(string sFileName = "Nlog.log")
        {
            var config = new NLog.Config.LoggingConfiguration();
            RichTextBoxTarget target = new RichTextBoxTarget();

            //target.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}";
            target.Layout = @"${longdate} ${logger} ${message}";

            target.ControlName = "rtbLog2";
            target.FormName = "frmMainAkdamar";

            target.UseDefaultRowColoringRules = true;
            target.ToolWindow = true;
            //target.ShowMinimized = true;
            config.AddTarget("rtbLog", target);

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = sFileName };

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, target);

            // Apply config
            NLog.LogManager.Configuration = config;

            // Initialize NLog
            LogManager.ReconfigExistingLoggers();
        }

        public static void NLOG_ConfigHide(string sFileName = "Nlog.log")
        {
            var config = new NLog.Config.LoggingConfiguration();
            RichTextBoxTarget target = new RichTextBoxTarget();

            target.Layout = "${longdate} ${logger} ${message}";

            target.ControlName = "rtbLog2";
            target.FormName = "frmMainAkdamar";

            target.UseDefaultRowColoringRules = true;
            target.ToolWindow = true;
            target.ShowMinimized = true;
            config.AddTarget("rtbLog", target);

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = sFileName };

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, target);

            // Apply config
            NLog.LogManager.Configuration = config;

            // Initialize NLog
            LogManager.ReconfigExistingLoggers();
        }
    }
}

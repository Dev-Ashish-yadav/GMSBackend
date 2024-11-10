using log4net.Core;
using log4net.Layout;
using Newtonsoft.Json;

namespace GymBackendServices.Middelware
{
    public class Jsonlayout : LayoutSkeleton
    {
        private bool isFirstEntry = true;
        public override void ActivateOptions()
        {
            // No options to activate
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            if (!isFirstEntry) { writer.WriteLine(","); }
            else { isFirstEntry = false; }
            var logEntry = new
            {
                Timestamp = loggingEvent.TimeStamp.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                Level = loggingEvent.Level.DisplayName,
                Logger = loggingEvent.LoggerName,
                Message = loggingEvent.RenderedMessage
            };

            var json = JsonConvert.SerializeObject(logEntry, Newtonsoft.Json.Formatting.None);
            writer.WriteLine(json);
        }
    }
}

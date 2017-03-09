using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace BackT.VoiceCommands
{
    public sealed class TechtanaService : IBackgroundTask
    {
        
        
        {
            var builder = new BackgroundTaskBuilder();
            builder.Name = "TechtanaService ";
            builder.SetTrigger(new TimeTrigger(15, true));
            // Do not set builder.TaskEntryPoint for in-process background tasks
            // Here we register the task and work will start based on the time trigger.
            BackgroundTaskRegistration task = builder.Register();


        }



    }
}

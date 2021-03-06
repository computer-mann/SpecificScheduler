using SpecificScheduler.BackgroundService;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SpecificScheduler.ScheduleTask
{
    public class SampleTask1 : ScheduledProcessor
    {

        public SampleTask1(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
                
        }

        protected override string Schedule => "*/1 * * * *"; // every 1 min 

        public override async Task ProcessInScope(IServiceProvider scopeServiceProvider)
        {
            Console.WriteLine("SampleTask1 : " + DateTime.Now.ToString());

            // return Task.CompletedTask;


            await Task.Run(() => {
                return Task.CompletedTask;
            });
        }
    }
}

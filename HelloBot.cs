using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace BotBuilderBot
{
    public class HelloBot : IBot
    {
        public async Task OnReceiveActivity(IBotContext context)
        {
            if (context.Request.Type is ActivityTypes.Message)
            {
                await context.SendActivity($"Hello world.");
            }
        }
    }
}
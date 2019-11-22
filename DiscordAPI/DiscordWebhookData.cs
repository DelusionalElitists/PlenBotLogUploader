﻿using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace PlenBotLogUploader.DiscordAPI
{
    public class DiscordWebhookData
    {
        /// <summary>
        /// Tells if the webhook is currently active
        /// </summary>
        public bool Active { get; set; } = false;
        /// <summary>
        /// Name of the webhook
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// URL for the webhook
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// Tells if the webhook is executed only if the ecounter is a success
        /// </summary>
        public bool OnlySuccess { get; set; } = false;
        /// <summary>
        /// Tells if players are showed in the webhook
        /// </summary>
        public bool ShowPlayers { get; set; } = true;

        /// <summary>
        /// Tests if webhook is valid
        /// </summary>
        /// <param name="httpController">HttpClientController class used for using http connection</param>
        /// <returns>True if webhook is valid, false otherwise</returns>
        public async Task<bool> TestWebhookAsync(Tools.HttpClientController httpController)
        {
            try
            {
                string response = await httpController.DownloadFileToStringAsync(URL);
                DiscordAPIJSONWebhookResponse pingtest = new JavaScriptSerializer().Deserialize<DiscordAPIJSONWebhookResponse>(response);
                return pingtest.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}

﻿using System.Collections.Generic;
using System.IO;

namespace PlenBotLogUploader.DiscordAPI
{
    class DiscordWebhooks
    {
        private static Dictionary<int, DiscordWebhookData> _all = null;
        /// <summary>
        /// Returns the main dictionary with all webhooks.
        /// </summary>
        /// <returns>A dictionary with all webhooks</returns>
        public static Dictionary<int, DiscordWebhookData> All
        {
            get
            {
                if (_all == null)
                {
                    _all = new Dictionary<int, DiscordWebhookData>();
                }
                return _all;
            }
        }

        /// <summary>
        /// Loads all webhooks from a specified file.
        /// </summary>
        /// <param name="file">The file from which the webhooks are loaded from</param>
        /// <returns>A dictionary with all webhooks</returns>
        public static Dictionary<int, DiscordWebhookData> FromFile(string file)
        {
            var allWebhooks = All;
            if (allWebhooks.Count > 0)
            {
                allWebhooks.Clear();
            }
            using (var reader = new StreamReader(file))
            {
                string line = reader.ReadLine(); // skip the first line
                while ((line = reader.ReadLine()) != null)
                {
                    allWebhooks.Add(allWebhooks.Count + 1, DiscordWebhookData.FromSavedFormat(line));
                }
            }
            return allWebhooks;
        }
    }
}

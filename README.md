# PlenBotLogUploader [![Build status](https://ci.appveyor.com/api/projects/status/qdx2bmsj54yg0c0y?svg=true)](https://ci.appveyor.com/project/Plenyx/plenbotloguploader)
An open source uploader to dps.report which post the links to Twitch chat or not, depending on the setting and more.

*Maintained by Plenyx.*

**Requires .NET Framework 4.5 ([link](https://www.microsoft.com/en-us/download/details.aspx?id=30653))**
* v4.6 is preinstalled on Windows 10 by default, so you don't need to download it if you own Windows 10, it is backwards compatible

## Installation
To install the uploader, I recommend creating a new folder and putting the executable in.

The uploader will create a file called "logs.csv" which will contain all previous and latest upload links.

For the flawless experience with the bot working with Twitch I recommend giving a VIP to the username "gw2loguploader". Do not mod it, since the bot is used by many people and everyone has access to its credentials (because of the open source code). You can also use a custom name for your bot which requires a use of another Twitch account.

If you are using the uploader with Twitch integration, you can customise bot messages in the "Edit Twitch log messages" dialog window. Settings are saved in "twitch_messages.txt" file.

I recommend using the compress feature in the arc settings. Otherwise the bot will try to archive it itself, which can be more unstable.

## Update
The uploader keeps track of its version and the online available version. When you start the executable, it will check for updates. If update is found a prompt will be displayed.

To update the bot just overwrite the previous version.

## Uninstall/Reinstall
To fully remove all the saved settings in the registry, use the enclosed "ResetSettings.reg" file in the release tab.

To remove all the saved logs remove the "logs.csv" file located in the directory of the executable.

To remove all the saved Twitch messages remove the "twitch_messages.txt" file located in the directory of the executable.

## Features
* uploading arcdps logs to dps.report as soon as they are made
* uploading arcdps logs to GW2Raidar when set up
* drag & drop directly to the executable or to the running application itself to quickly upload a log
* pinging links to Twitch chat with customisable messages
* pinging links to in Discord (via remote server ping; using my server is in private beta, contact me directly)
* custom name for the bot, otherwise "gw2loguploader" is being used
* update reminder
* arcdps update auto-updater & reminder

## Future updates
I plan to finish the following features:
* remote server ping
  * creating a back server for collecting logs
  * can be used to further process uploaded logs, like pinging to a Discord server as an example
    * if you want to use pinging to Discord via my server, contact me directly, it requires manual approval and a "sign" given by me for it to work
* *adding additional features based on feedback*
  * I am always looking to provide more features to the users, if you have any ideas of how to improve the uploader, don't be afraid to contact me directly.

## Remote server ping
Remote server ping allows you to send log data to a custom server.

If you wish to create your own server, follow the [MAKE-CUSTOM-REMOTE-SERVER-README](https://github.com/Plenyx/PlenBotLogUploader/blob/master/MAKE-CUSTOM-REMOTE-SERVER-README.md) readme.

## TwitchIrcClient
A client I developed for Irc which Twitch uses.

Initially built on .NET Framework 4.7, but I made it work on 4.5 and .NET Core 2.1.

*Maintained by Plenyx.*

**Requires either .NET Framework 4.5 or .NET Core 2.1**

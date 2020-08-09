﻿using ChatterBot.Core.Auth;
using ChatterBot.Core.Extensions;
using TwitchLib.Client.Models;

namespace ChatterBot.Infra.Twitch.Extensions
{
    public static class CredentialsExtensions
    {
        public static ConnectionCredentials ToTwitchLib(
            this TwitchCredentials credentials, IDataProtection dataProtection)
            => new ConnectionCredentials(credentials.Username,
                dataProtection.Unprotect(credentials.AuthToken).BytesToString());
    }
}
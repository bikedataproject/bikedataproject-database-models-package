using System;
using System.Collections.Generic;

namespace BDPDatabase
{
    public class User
    {
        public int Id { get; set; }

        public Guid UserIdentifier { get; set; }

        public string Provider { get; set; }

        public string ProviderUser { get; set; }

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public DateTime TokenCreationDate { get; set; }

        public int ExpiresAt { get; set; }

        public int ExpiresIn { get; set; }

        public bool IsHistoryFetched {get; set; }

        public List<UserContribution> UserContributions { get; set; }

    }
}
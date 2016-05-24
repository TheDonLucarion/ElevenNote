using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ElevenNote.Models.Contracts;

namespace ElevenNote.Web.Models
{
    public class AppSettings : IAppSettings
    {
        public int Auth_MinimumPasswordLength { get; set; } = int.Parse(ConfigurationManager.AppSettings["Site.Auth.RequiredDigits"]);
        public bool Auth_RequireNonLetterOrDigit { get; set; } = bool.Parse(ConfigurationManager.AppSettings["Site.Auth.RequireNonLetterOrDigit"]);
        public bool Auth_RequireDigit { get; set; } = bool.Parse(ConfigurationManager.AppSettings["Site.Auth.RequireDigit"]);
        public bool Auth_RequireLowercase { get; set; } = bool.Parse(ConfigurationManager.AppSettings["Site.Auth.RequireLowercase"]);
        public bool Auth_RequireUppercase { get; set; } = bool.Parse(ConfigurationManager.AppSettings["Site.Auth.RequireUppercase"]);
        public string Auth_Facebook_AppId { get; set; } = ConfigurationManager.AppSettings["Site.Auth.Facebook.AppId"];
        public string Auth_Facebook_AppSecret { get; set; } = ConfigurationManager.AppSettings["Site.Auth.Facebook.AppSecret"];
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models.Contracts
{
    /// <summary>
    /// Represents application settings.
    /// </summary>
    public interface IAppSettings
    {
        /// <summary>
        /// The minimum password length.
        /// </summary>
        int Auth_MinimumPasswordLength { get; set; }

        /// <summary>
        /// Flag whether to require a non-letter or digit.
        /// </summary>
        bool Auth_RequireNonLetterOrDigit { get; set; }

        /// <summary>
        /// Flag whether to require at least one digit.
        /// </summary>
        bool Auth_RequireDigit { get; set; }

        /// <summary>
        /// Flag whether to require at least one lowercase character.
        /// </summary>
        bool Auth_RequireLowercase { get; set; }

        /// <summary>
        /// Flag whether to require at least one uppercase character.
        /// </summary>
        bool Auth_RequireUppercase { get; set; }

        string Auth_Facebook_AppId { get; set; }

        string Auth_Facebook_AppSecret { get; set; }
    }
}

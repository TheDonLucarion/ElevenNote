using ElevenNote.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElevenNote.Web.Models
{
    public class NicksCookieRecipe : IChocolateChipCookie
    {
        public bool Bake()
        {
            return true;
        }

        public bool Prepare()
        {
            return true;
        }

        public bool Serve()
        {
            return true;
        }
    }
}
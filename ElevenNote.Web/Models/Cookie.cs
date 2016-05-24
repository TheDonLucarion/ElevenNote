using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElevenNote.Web.Models
{
    public abstract class Cookie
    {
        public virtual bool Prepare()
        {
            throw new NotImplementedException();
        }

        public bool Bake()
        {
            // We'll bake for 12 minutes at 350 degrees.
            return true;
        }

        public virtual bool Serve()
        {
            throw new NotImplementedException();
        }

    }

    public class SugarCookie : Cookie
    {
        public new bool Prepare()
        {
            return true;
        }

        public new bool Serve()
        {
            return true;
        }

    }

    public class ChocolateChipCookie : Cookie
    {
        public override bool Prepare()
        {
            return true;
        }

        public override bool Serve()
        {
            return true;
        }
    }

    public class SpoiledCookie : Cookie
    {
    }

    public class CookieTest
    {
        public CookieTest()
        {
            var cookie = new ChocolateChipCookie();
        }

        public void Eat(Cookie anyKindOfCookie)
        {
            if (anyKindOfCookie is SpoiledCookie)
                Console.Write("Gross!");
            else
                Console.Write("Yum!");

        }
    }
}
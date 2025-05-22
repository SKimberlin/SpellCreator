using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model
{
    class BaseSpell : ISpell
    {
        public int GetDamage()
        {
            return 0;
        }

        public List<string> GetModifiers()
        {
            return new();
        }

        public int GetManaCost()
        {
            return 0;
        }
    }
}

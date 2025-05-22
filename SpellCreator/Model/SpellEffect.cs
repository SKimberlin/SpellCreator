using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model
{
    public abstract class SpellEffect : ISpell
    {
        protected ISpell wrapped;
        public SpellEffect(ISpell spell)
        {
            wrapped = spell;
        }
        public abstract int GetDamage();

        public abstract List<string> GetModifiers();

        public abstract int GetManaCost();
    }
}

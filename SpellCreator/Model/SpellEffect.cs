using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model
{
    class SpellEffect : ISpell
    {
        protected ISpell wrapped;
        public SpellEffect(ISpell spell)
        {
            wrapped = spell;
        }
        public int GetDamage()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public int GetManaCost()
        {
            throw new NotImplementedException();
        }
    }
}

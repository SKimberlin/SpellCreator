using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model.Effects
{
    class AcidEffect : SpellEffect
    {
        public AcidEffect(ISpell spell) : base(spell)
        {
        }
        public override int GetDamage()
        {
            return 8 + wrapped.GetDamage();
        }
        public override List<string> GetModifiers()
        {
            var modifiers = wrapped.GetModifiers();
            modifiers.Add("acidic");
            return modifiers;
        }
        public override int GetManaCost()
        {
            return 8 + wrapped.GetManaCost();
        }
    }
}

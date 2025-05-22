using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model.Effects
{
    class LightningEffect : SpellEffect
    {
        public LightningEffect(ISpell spell) : base(spell)
        {
        }
        public override int GetDamage()
        {
            return 20 + wrapped.GetDamage();
        }
        public override List<string> GetModifiers()
        {
            var modifiers = wrapped.GetModifiers();
            modifiers.Add("charged");
            return modifiers;
        }
        public override int GetManaCost()
        {
            return 12 + wrapped.GetManaCost();
        }
    }
}

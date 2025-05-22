using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model.Effects
{
    class PoisonEffect : SpellEffect
    {
        public PoisonEffect(ISpell spell) : base(spell)
        {
        }
        public override int GetDamage()
        {
            return 5 + wrapped.GetDamage();
        }
        public override List<string> GetModifiers()
        {
            var modifiers = wrapped.GetModifiers();
            modifiers.Add("poisonous");
            return modifiers;
        }
        public override int GetManaCost()
        {
            return 9 + wrapped.GetManaCost();
        }
    }
}

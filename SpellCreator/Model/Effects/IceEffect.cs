using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model.Effects
{
    class IceEffect : SpellEffect
    {
        public IceEffect(ISpell spell) : base(spell)
        {
        }
        public override int GetDamage()
        {
            return 10 + wrapped.GetDamage();
        }
        public override List<string> GetModifiers()
        {
            var modifiers = wrapped.GetModifiers();
            modifiers.Add("frosty");
            return modifiers;
        }
        public override int GetManaCost()
        {
            return 10 + wrapped.GetManaCost();
        }
    }
}

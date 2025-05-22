using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model
{
    public class SpellBuilder
    {
        private ISpell currentSpell;
        private List<Type> addedEffects = new();

        public SpellBuilder()
        {
            currentSpell = new BaseSpell();
        }

        public bool AddEffect<T>() where T : SpellEffect
        {
            var type = typeof(T);

            if (addedEffects.Contains(type))
            {
                // Use View to show a message that the effect is already added
                return false;
            }

            var newSpell = Activator.CreateInstance(type, currentSpell) as T;

            if (newSpell == null)
            {
                // Use View to show a message that the effect could not be added
                return false;
            }

            currentSpell = newSpell;
            addedEffects.Add(type);
            return true;
        }

        public ISpell Build()
        {
            var spell = currentSpell;
            currentSpell = new BaseSpell();
            addedEffects.Clear();
            return spell;
        }
    }
}

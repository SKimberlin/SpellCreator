using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.View
{
    public class ConsoleView : IView
    {
        public void ShowSpell(ISpell spell, int index)
        {
            Console.WriteLine($"   Spell {index}");
            var modifiers = spell.GetModifiers();
            if (modifiers.Any())
            {
                Console.WriteLine($"   Modifiers: {string.Join(", ", modifiers)}.");
            }

            Console.WriteLine($"   Damage: {spell.GetDamage()}");
            Console.WriteLine($"   Mana Cost: {spell.GetManaCost()}");
        }


        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadInput()
        {
            return Console.ReadLine()?.ToLower().Trim() ?? "";
        }
    }
}


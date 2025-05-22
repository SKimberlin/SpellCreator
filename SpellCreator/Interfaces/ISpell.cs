using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Interfaces
{
    interface ISpell
    {
        string GetDescription();
        int GetDamage();
        int GetManaCost();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Interfaces
{
    public interface ISpell
    {
        List<string> GetModifiers();
        int GetDamage();
        int GetManaCost();
    }
}

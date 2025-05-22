using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Interfaces
{
    public interface IView
    {
        void ShowSpell(ISpell spell, int index);
        void ShowMessage(string message);
        string ReadInput();
    }
}


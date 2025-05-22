using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Interfaces
{
    public interface ISingleView
    {
        private static IView instance;
        public static IView Instance => instance;
        public static void Register(IView view)
        {
            instance = view;
        }
        void ShowSpell(ISpell spell, int index);
        void ShowMessage(string message);
        string ReadInput();
    }
}


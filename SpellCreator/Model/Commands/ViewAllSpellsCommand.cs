using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model.Commands
{
    class ViewAllSpellsCommand : ICom
    {
        private readonly List<ISpell> spellList;
        private readonly IView view;

        public ViewAllSpellsCommand(List<ISpell> spellList, IView view)
        {
            this.spellList = spellList;
            this.view = view;
        }

        public void Execute()
        {
            if (spellList.Count == 0)
            {
                view.ShowMessage("No spells have been built yet.");
                return;
            }

            for (int i = 0; i < spellList.Count; i++)
            {
                view.ShowSpell(spellList[i], i + 1);
            }
        }
    }

}

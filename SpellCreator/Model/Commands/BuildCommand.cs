using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model.Commands
{
    class BuildCommand : ICom
    {
        private readonly SpellBuilder builder;
        private readonly List<ISpell> spellList;
        public BuildCommand(SpellBuilder builder, List<ISpell> spellList)
        {
            this.builder = builder;
            this.spellList = spellList;
        }
        public void Execute()
        {
            spellList.Add(builder.Build());
        }
    }
}

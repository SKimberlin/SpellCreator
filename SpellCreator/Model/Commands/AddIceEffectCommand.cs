using SpellCreator.Interfaces;
using SpellCreator.Model.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model.Commands
{
    public class AddIceEffectCommand : ICom
    {
        private readonly SpellBuilder builder;
        public AddIceEffectCommand(SpellBuilder builder)
        {
            this.builder = builder;
        }
        public void Execute()
        {
            builder.AddEffect<IceEffect>();
        }
    }
}

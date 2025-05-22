using SpellCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCreator.Model.Commands
{
    class ApplicationExitCommand : ICom
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}

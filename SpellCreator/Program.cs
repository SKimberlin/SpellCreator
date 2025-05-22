using SpellCreator.Interfaces;
using SpellCreator.Model;
using SpellCreator.Model.Commands;
using SpellCreator.View;

IView view = new ConsoleView();
List<ISpell> builtSpells = new();
SpellBuilder builder = new();
Dictionary<string, ICom> commands = new()
        {
            { "acid", new AddAcidEffectCommand(builder) },
            { "fire", new AddFireEffectCommand(builder) },
            { "ice", new AddIceEffectCommand(builder) },
            { "lightning", new AddLightningEffectCommand(builder) },
            { "poison", new AddPoisonEffectCommand(builder) },
            { "build", new BuildCommand(builder, builtSpells) },
            { "showall", new ViewAllSpellsCommand(builtSpells, view) },
            { "exit", new ApplicationExitCommand() },
        };

string welcomeMessage = "Available commands: ";


foreach (var command in commands)
{
    welcomeMessage += $"{command.Key}, ";
}

view.ShowMessage("Welcome to the Spell Creator!");
view.ShowMessage(welcomeMessage);

while (true)
{
    view.ShowMessage("> ");
    string input = view.ReadInput();

    if (commands.TryGetValue(input, out ICom command))
        command.Execute();
    else
        view.ShowMessage("Unknown command. Please try again.");
}
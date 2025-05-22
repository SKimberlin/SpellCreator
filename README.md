# SpellCreator

## Description

This is a C# console application using multiple design patterns that allows you to build spells by adding various components such as effects.

## Design Patterns

- **Builder Pattern**: Used to construct complex objects step by step. In this case, it is used to build spells with various components and check for duplicates or contradictions.
- **Decorator Pattern**: Used to add new functionality to an object without altering its structure. In this case, it is used to add effects to spells.
- **Command Pattern**: Used to encapsulate a request as an object, thereby allowing for parameterization of clients with queues, requests, and operations. In this case, it is used to execute commands related to spell creation and modification.

## Future Improvements

- Add save and load functionality to persist spells.
- Implement a user interface for easier interaction.
- Add more spell components and effects to increase complexity.
- Add redo and undo functionality to the command pattern for better user experience.
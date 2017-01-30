7 kyu
PatternCraft - Adapter

23497% of 37114 of 178brunolm
C#TRAINNEXT KATA
Details
Solutions
Discourse (17)
Add to Collection|Share this kata:
Description:

The Adapter Design Pattern can be used, for example in the StarCraft game, to insert an external character in the game.

The pattern consists in having a wrapper class that will adapt the code from the external source.

Your Task

The adapter receives an instance of the object that it is going to adapt and handles it in a way that works with our application.

In this example we have the pre-loaded classes:

public class Target
{
    public int Health { get; set; }
}
public interface IUnit
{
    void Attack(Target target);
}

public class Marine : IUnit
{
    public void Attack(Target target)
    {
        target.Health -= 6;
    }
}

public class Zealot : IUnit
{
    public void Attack(Target target)
    {
        target.Health -= 8;
    }
}

public class Zergling : IUnit
{
    public void Attack(Target target)
    {
        target.Health -= 5;
    }
}

public class Mario
{
    public int jumpAttack()
    {
        Console.WriteLine("Mamamia!");
        return 3;
    }
}
Complete the code so that we can create a MarioAdapter that can attack as other units do.

Note to calculate how much damage mario is going to do you have to call the jumpAttack method.

Resouces

PatternCraft > Adapter
SourceMaking > Adapter
Wikipedia > Adapter
PatternCraft series

State Pattern
Strategy Pattern
Visitor Pattern
Decorator Pattern
Adapter Pattern
Command Pattern
The original PatternCraft series (by John Lindquist) is a collection of Youtube videos that explains some of the design patterns and how they are used (or could be) on StarCraft.
FUNDAMENTALSDESIGN PATTERNSDESIGN PRINCIPLES
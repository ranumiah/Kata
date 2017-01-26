6 kyu
PatternCraft - Decorator

33883% of 6694 of 258brunolm
C#TRAINNEXT KATA
Details
Solutions
Discourse (18)
Add to Collection|Share this kata:
Description:

The Decorator Design Pattern can be used, for example, in the StarCraft game to manage upgrades.

The pattern consists in "incrementing" your base class with extra functionality.

A decorator will receive an instance of the base class and use it to call the add the new things you want.

Your Task

Complete the code so that when a Marine gets a WeaponUpgrade it increases the damage by 1, and if it is a ArmorUpgrade then increase the armor by 1.

You have 3 classes:

Marine: has a damage and an armor properties
MarineWeaponUpgrade and MarineArmorUpgrade: upgrades to apply on marine. Accepts a Marine in the constructor and has the same properties as the Marine
Resouces

PatternCraft > Decorator
SourceMaking > Decorator
Wikipedia > Decorator
PatternCraft series

State Pattern
Strategy Pattern
Visitor Pattern
Decorator Pattern
Adapter Pattern
Command Pattern
The original PatternCraft series (by John Lindquist) is a collection of Youtube videos that explains some of the design patterns and how they are used (or could be) on StarCraft.
FUNDAMENTALSDESIGN PATTERNSDESIGN PRINCIPLES









Raise Me to The Third Power, Search My Divisors... .....Could You Believe that?

30093% of 1511 of 108raulbc777
C#TRAINNEXT KATA
Details
Solutions
Discourse (25)
Add to Collection|Share this kata:
Description:

The number six has this interesting property, and is the smallest number in having it (after the integer 1 that obviously fulfills this condition): Its cube, is divisible by the sum of its divisors. Let's see it:

6 ^ 3 = 216
divisors of 6: 1, 2, 3, 6
sum of its divisors= 1 + 2 + 3 + 6 = 12
And 216 / 12 = 18 (integer) and 18.12 = 216
The first terms of this sequence are:

n    a(n)
1       6 
2      28
3      30
4      84
5     102
Your challenge is to create a function int_cube_sum_div() (or similar in other languages), that may receive, n, the ordinal number of the term of the sequence, as an argument, and outputs the corresponding value of the term of that sequece of integers. Or explained in this way:

int_cube_sum_div(n) -------> a(n)
Let's see some cases:

int_cube_sum_div(4) ------> 84
/// divisors of 84 : 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42, 84
    sum of divisors = 1 + 2 + 3 + 4 + 6 + 7 + 12 + 14 + 21 + 28 + 42 + 84 = 224
    cube of 84 = 84^3 = 592704
    592704 is a multiple of 224///

int_cube_sum_div(5) ------> 102
Your code should use memoization in order to have higher speed for testing. Does your code reach up to the 120-th term? We can get this upper limit in the tests.

Enjoy it and happy coding!!











6 kyu
Find the First Number in Having a Certain Number of Divisors I

33093% of 2036 of 151raulbc777
C#TRAINNEXT KATA
Details
Solutions
Discourse (25)
Add to Collection|Share this kata:
Description:

The number 12 is the first number in having six divisors, they are: 1, 2, 3, 4, 6 and 12. Your challenge for this kata is to find the minimum number that has a certain number of divisors. For this purpose we have to create the function

find_min_num() or findMinNum() or similar in the other languages

that receives the wanted number of divisors num_div, and outputs the smallest number having an amount of divisors equals to num_div.

Let's see some cases:

find_min_num(10) = 48 # divisors are: 1, 2, 3, 4, 6, 8, 12, 16, 24 and  48
find_min_num(12) = 60
In this kata all the tests will be with numDiv < 80

(There will be a next kata with numDiv < 10000, Find the First Number Having a Certain Number of Divisors II, should have the help of number theory)

Enjoy it and happy coding! (Memoization is advisable)




6 kyu
PatternCraft - State

42692% of 53181 of 366brunolm
C#TRAINNEXT KATA
Details
Solutions
Discourse (9)
Add to Collection|Share this kata:
Description:

The State Design Pattern can be used, for example, to manage the state of a tank in the StarCraft game.

The pattern consists in isolating the state logic in different classes rather than having multiple ifs to determine what should happen.

Your Task

Complete the code so that when a Tank goes into SiegeMode it cannot move and its damage goes to 20. When it goes to TankMode it should be able to move and the damage should be set to 5.

You have 3 classes:

Tank: has a state, canMove and damage properties
SiegeState and TankState: has canMove and damage properties
Note: The tank initial state should be TankState.

Resouces

PatternCraft > State
SourceMaking > State
Wikipedia > State
PatternCraft series

State Pattern
Strategy Pattern
Visitor Pattern
Decorator Pattern
Adapter Pattern
Command Pattern
The original PatternCraft series (by John Lindquist) is a collection of Youtube videos that explains some of the design patterns and how they are used (or could be) on StarCraft.
FUNDAMENTALSDESIGN PATTERNSDESIGN PRINCIPLES










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









7 kyu
PatternCraft - Visitor

30594% of 32131 of 367brunolm
C#TRAINNEXT KATA
Details
Solutions
Discourse (19)
Add to Collection|Share this kata:
Description:

The Visitor Design Pattern can be used, for example, to determine how an attack deals a different amount of damage to a unit in the StarCraft game.

The pattern consists of delegating the responsibility to a different class.

When a unit takes damage it can tell the visitor what to do with itself.

Your Task

Complete the code so that when a Tank attacks a Marine it takes 21 damage and when a Tank attacks a Marauder it takes 32 damage.

The Marine's initial health should be set to 100 and the Marauder's health should be set to 125.

You have 3 classes:

Marine: has a health property and accept(visitor) method
Marauder: has a health property and accept(visitor) method
TankBullet: the visitor class. Has visitLight(unit) and visitArmored(unit) methods
Resouces

PatternCraft > Visitor
SourceMaking > Visitor
Wikipedia > Visitor
PatternCraft series

State Pattern
Strategy Pattern
Visitor Pattern
Decorator Pattern
Adapter Pattern
Command Pattern
The original PatternCraft series (by John Lindquist) is a collection of Youtube videos that explains some of the design patterns and how they are used (or could be) on StarCraft.
FUNDAMENTALSDESIGN PATTERNSDESIGN PRINCIPLES







6 kyu
PatternCraft - Strategy

22697% of 31153 of 304brunolm
C#TRAINNEXT KATA
Details
Solutions
Discourse (13)
Add to Collection|Share this kata:
Description:

The Strategy Design Pattern can be used, for example, to determine how a unit moves in the StarCraft game.

The pattern consists in having a different strategy to one functionality. A unit, for example, could move by walking or flying.

Your Task

Complete the code so that when a Viking is flying its position increases by 10 each time it moves. If it is walking then the position is increased by 1.

In this Kata, Viking starts as a ground unit when it is created.

You have 3 classes:

Viking: has a position, moveBehavior and move method.
Fly and Walk: the move behaviors with the move(unit) method. Fly has to move 10 positions at a time and Walk has to move 1.
Resouces

PatternCraft > Strategy
SourceMaking > Strategy
Wikipedia > Strategy
PatternCraft series

State Pattern
Strategy Pattern
Visitor Pattern
Decorator Pattern
Adapter Pattern
Command Pattern
The original PatternCraft series (by John Lindquist) is a collection of Youtube videos that explains some of the design patterns and how they are used (or could be) on StarCraft.
FUNDAMENTALSDESIGN PATTERNSDESIGN PRINCIPLES
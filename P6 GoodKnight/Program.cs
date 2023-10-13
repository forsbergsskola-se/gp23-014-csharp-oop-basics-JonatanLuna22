/*
These are the rules of battle:

If the attacker has no Sword, he attacks with his bare hands

If the defender has a Shield, he can fend off the strike
Else, he is hit
If the attacker has a Sword, he attacks with it

If the defender has a Shield, he can fend off the strike, but the Shield is pierced and removed
Else, he is wounded
Create a project named P6GoodKnight

Create an Shield class

Create a Sword class

Create a Knight class.

With an Shield Field.
With a Sword Field.
With a GetHit Method with a Sword Parameter.
With an Attack Method with a Knight Parameter.
Create two Knight, attcker and defender.

Give defender an Shield

Let attacker Attack defender

Give attacker a Sword

Let attacker Attack defender

Let attacker Attack defender
*/

Knight knightAttack = new Knight();
Knight knightDefend = new Knight();

// knightDefend.Shield

knightAttack.Attack(knightDefend);

// knightAttack.Sword

knightAttack.Attack(knightDefend);
knightAttack.Attack(knightDefend);

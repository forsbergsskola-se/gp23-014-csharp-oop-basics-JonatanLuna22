/*
Define a class named ScoreCounter
It was a Field named Score for counting the Score
It has a Method named IncreaseScore for increasing the Score
Instantiate the class and assign it to Variable one
Assign Variable one to Variable two
Assign Variable two to Variable three
Assign Variable three to Variable four
Invoke IncreaseScore once on each Variable
Print each Variable's Score to the Console
Notice that they all have the Same Score of 4 (not one!)
*/

ScoreCounter score1 = new ScoreCounter();
ScoreCounter score2 = score1;
ScoreCounter score3 = score2;
ScoreCounter score4 = score3;

score1.IncreaseScore();
score2.IncreaseScore();
score3.IncreaseScore();
score4.IncreaseScore();

Console.WriteLine(score1.counter);
Console.WriteLine(score2.counter);
Console.WriteLine(score3.counter);
Console.WriteLine(score4.counter);
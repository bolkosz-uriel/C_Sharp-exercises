
//exercise 5 -Dice Game-

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice rolls: {roll1} + {roll2} + {roll3} = {total}");

if(roll1 == roll2 && roll1 == roll3){
    Console.WriteLine("Oh baby! a triple! +6 bonuse");
}

else if(roll1 == roll2 || roll3 == roll1 || roll3 == roll2){
    Console.WriteLine("You rolled a double! +2 bonus");
    total += 2;
}


if (total >= 12){

    Console.WriteLine("You win!");
}

if (total < 12){
    Console.WriteLine("Sorry, you lost.");
}

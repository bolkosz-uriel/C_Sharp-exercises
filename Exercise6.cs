// See https://aka.ms/new-console-template for more information

 /*
 In this exercise you need to create a code that checks when a users account is about to expire and offer 
 a discount accordingly
 If the user's subscription will expire in 10 days or less, display the message:
 Your subscription will expire soon. Renew now!
 If the user's subscription will expire in five days or less, display the messages:
 Your subscription expires in _ days.
 Renew now and save 10%!
 If the user's subscription will expire in one day, display the messages:
 Your subscription expires within a day!
 Renew now and save 20%!
 If the user's subscription has expired, display the message:
 Your subscription has expired.
  */
//exercise 6 -Business promotion-
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine("" + daysUntilExpiration);
if (daysUntilExpiration > 10){
    
}
else if (daysUntilExpiration == 0){
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1){
    discountPercentage += 20;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5){
    discountPercentage += 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

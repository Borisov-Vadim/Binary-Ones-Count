using BinaryCountFunction;

Console.WriteLine("Enter number:");
var number = Convert.ToInt32(Console.ReadLine());
var byteNumber = BinaryCount.CountBits(number);
Console.WriteLine(byteNumber);

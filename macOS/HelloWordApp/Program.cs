// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("What is your name?: ");
string name = Console.ReadLine() ?? "";
if(name != ""){
    Console.WriteLine("Nice to meet you, " + name + "!");
}
else{
    Console.WriteLine("Nice to meet you!");
}   

Console.ReadLine();



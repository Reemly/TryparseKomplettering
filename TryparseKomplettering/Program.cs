
int age = 0;
bool question = false;

while (question != true)
{
  Console.WriteLine("Din ålder:");
  string input = Console.ReadLine();

  // int age = int.Parse(input);

  question = int.TryParse(input, out age);
}

if (question == true)
{
  if (age < 21)
  {
    Console.WriteLine("Du får inte köpa alkohol på systemet.");
  }
  else
  {
    Console.WriteLine("Du får köpa alkohol på systemet.");
  }
}


Console.ReadLine();


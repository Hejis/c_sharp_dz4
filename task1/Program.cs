// Напишите цикл, который принимает 
//на вход два числа (A и B)
// и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int Prompt(string message)
{
  Console.Write(message);
  string StringValue = Console.ReadLine() ?? "0";
  bool isNumber = int.TryParse(StringValue, out int value);
  if (isNumber)
  {
    return value;
  }
  throw new Exception("Данное значение невозможно преобразовать в число");

}


int Stepen(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}

  
  int numberA =Prompt("Введите число A: ");

  int numberB = Prompt("Введите число B: ");

  int stepen = Stepen(numberA, numberB);
  Console.WriteLine($"{numberA}^{numberB} =  {stepen}");

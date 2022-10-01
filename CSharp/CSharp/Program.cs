// Введите 3 числа и выведите значение суммы и произведения этих чисел

double ferstnumber, secondnumber, thirdnumber;

Console.WriteLine("Введите первое число: ");
ferstnumber = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
secondnumber = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
thirdnumber = double.Parse(Console.ReadLine());

double sum = ferstnumber + secondnumber + thirdnumber;
double product = ferstnumber * secondnumber * thirdnumber;

Console.WriteLine("Сумма трех чисел: " + sum);
Console.WriteLine("Произведение трех чисел: " + product);

Console.WriteLine();

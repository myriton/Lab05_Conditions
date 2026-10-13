// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0)
// {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0)
// {
//     Console.WriteLine("Число отрицательное.");
// }
// else
// {
//     Console.WriteLine("Число равно нулю.");
// }

// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91)
// {
//     Console.WriteLine("Оценка: Отличное (5)");
// }
// else if (score >= 71)
// {
//     Console.WriteLine("Оценка: Хорошо (4)");
// }
// else if (score >= 51)
// {
//     Console.WriteLine("Оценка: Удовлетворительно (3)");
// }
// else
// {
//     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }

// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14;
// bool goodGrades = practiceGpa >= 3.0;
// if (goodAttendance && goodGrades)
// {
//     Console.WriteLine("+ Допуск к экзамену разрешен.");
// }
// else if (!goodAttendance && goodGrades)
// {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades)
// {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else
// {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценкам. Срочно к преподавателю");
// }

// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");
// Console.Write("\nВведите температуру за окном (°С): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");
// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "четное" : "нечетное";
// Console.WriteLine($"Число {n} - {parity}.");

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();
// switch (choice)
// {
//     case "1": 
//         Console.WriteLine("Расписание: ИСП-242, каб. 136, 13:50");
//         break;
//     case "2": 
//         Console.WriteLine("Ваши оценки: ИСРПО - 20, РМП - 35,");
//         break;
//     case "3": 
//         Console.WriteLine("Email: nikasevcenko642@gmail.com");
//         break;
//     case "4": 
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт '{choice}' не существует. Введите число от 1 до 4.");
//         break;
// }
// Console.Write("\nВведите номер месяца (1-12): ");
// int seasons = int.Parse(Console.ReadLine());
// switch (seasons)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("Зима");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Весна");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("Лето");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("Осень");
//         break;
//     default:
//         Console.WriteLine("Введите месяц от 1 до 12");
//         break;
// }
// 
// 1
Console.WriteLine("Проверка пароля");
Console.Write("Введите пароль: ");
string password = Console.ReadLine();

Console.Write("Подтвердите пароль: ");
string confirmPassword = Console.ReadLine();

if (password == confirmPassword)
{
    Console.WriteLine("Пароль принят");
}
else
{
    Console.WriteLine("Пароль не принят");
}
// 2
Console.WriteLine("Роскомнадзор ");
Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}
// 3
Console.WriteLine("Простой калькулятор");

Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите операцию (+, -, *, /): ");
string op = Console.ReadLine();

double result;

switch (op)
{
    case "+":
        result = a + b;
        Console.WriteLine($"{a} + {b} = {result}");
        break;

    case "-":
        result = a - b;
        Console.WriteLine($"{a} - {b} = {result}");
        break;

    case "*":
        result = a * b;
        Console.WriteLine($"{a} * {b} = {result}");
        break;

    case "/":
        if (b == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно.");
        }
        else
        {
            result = a / b;
            Console.WriteLine($"{a} / {b} = {result}");
        }
        break;

    default:
        Console.WriteLine($"Ошибка: операция «{op}» не поддерживается.");
        break;
}
// 4
Console.WriteLine("Только положительные");

Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int n3 = int.Parse(Console.ReadLine());

int sum = 0;

if (n1 > 0) sum += n1;
if (n2 > 0) sum += n2;
if (n3 > 0) sum += n3;

Console.WriteLine($"Сумма положительных чисел: {sum}");
// 5
Console.WriteLine("Путешествие в Тёмный Лабиринт\n");
Console.WriteLine("Вы стоите перед первой дверью.");
Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
Console.WriteLine("Путь В: Пойти по тёмному коридору.");
Console.Write("Ваш выбор (A/B): ");

string path = Console.ReadLine();

if (path == "A")
{
    // === Путь А: загадка дракона ===
    Console.WriteLine("\nДракон преграждает вам путь и говорит:");
    Console.WriteLine("\"Кто не дышит, но живёт;");
    Console.WriteLine(" хоть не нужно — много пьёт;");
    Console.WriteLine(" и в жизни, и в смерти тело как лёд.\"");
    Console.Write("Ваш ответ: ");

    string answer = Console.ReadLine();

    if (answer == "рыба")
    {
        Console.WriteLine("\nДракон довольно кивает и открывает дверь в следующую комнату!");
        Console.WriteLine("Вы прошли испытание и приблизились к Dungeon Master’у.");
    }
    else
    {
        Console.WriteLine("\nНеверный ответ! Дракон вас съел... Игра окончена.");
    }
}
else if (path == "B")
{
    // === Путь В: две двери ===
    Console.WriteLine("\nВы входите в тёмную комнату и видите две двери.");
    Console.WriteLine("Дверь 1: За ней скрыты сокровища Dungeon Master’а.");
    Console.WriteLine("Дверь 2: За ней — ловушка с ядовитыми шипами.");
    Console.Write("Какую дверь выберете? (1/2): ");

    string door = Console.ReadLine();

    switch (door)
    {
        case "1":
            Console.WriteLine("\nВы нашли сокровища Dungeon Master’а! Победа!");
            break;

        case "2":
            Console.WriteLine("\nЛовушка! Ядовитые шипы пронзили вас... Игра окончена.");
            break;

        default:
            Console.WriteLine("\nВы замешкались в темноте и не решились выбрать дверь. Лабиринт остался непройденным.");
            break;
    }
}
else
{
    Console.WriteLine("\nВы не решились войти ни в одну из дверей и покинули лабиринт ни с чем.");
}
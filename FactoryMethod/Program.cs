using FactoryMethod.Example;

Console.WriteLine("Выберите тип запускаемого проекта:\n" +
                  "1. Учебный пример\n" +
                  "2. Реальный пример\n" +
                  "Любой другой символ. Завершить работу программы");

var projectType = Console.ReadKey().KeyChar;

Console.WriteLine();

switch (projectType)
{
    case '1':
        new Client().Main();
        break;
    case '2':
        Console.WriteLine("Я хз как тут может быть практическая реализация :)");
        break;
}

Console.WriteLine("Завершение работы программы");      
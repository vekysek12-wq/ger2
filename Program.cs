// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero margarita = new Hero("Маргарита", 80);

// Console.WriteLine(">>> Герой 1 <<<");
// Console.WriteLine($"Имя: {yaroslav.Name}");
// Console.WriteLine($"Здоровье: {yaroslav.Heal}");
// Console.WriteLine($"Уровень: {yaroslav.Lvl}");
// Console.WriteLine($"Опыт: {yaroslav.Exp}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 2 <<<");
// Console.WriteLine($"Имя: {anastasia.Name}");
// Console.WriteLine($"Здоровье: {anastasia.Heal}");
// Console.WriteLine($"Уровень: {anastasia.Lvl}");
// Console.WriteLine($"Опыт: {anastasia.Exp}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 3 <<<");
// Console.WriteLine($"Имя: {artem.Name}");
// Console.WriteLine($"Здоровье: {artem.Heal}");
// Console.WriteLine($"Уровень: {artem.Lvl}");
// Console.WriteLine($"Опыт: {artem.Exp}");


// margarita.TakeDamage(30);
// margarita.Heal(15);
// margarita.GainExperience(50);

// bool margaritaAlive = margarita.IsAlive();
// Console.WriteLine($"Маргарита жива: {margaritaAlive}");
// Console.WriteLine(margarita.GetInfo());

// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 100);

// yaroslav.TakeDamage(40);
// anastasia.TakeDamage(10);

// Console.WriteLine($"Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Анастасия: {anastasia.Health}");


// Console.WriteLine($"До вызовов: {yaroslav.Heal}, {anastasia.Heal}, {artem.Heal}");

// yaroslav.TakeDamage(25);
// anastasia.TakeDamage(30);

// Console.WriteLine($"После вызовов: {yaroslav.Heal}, {anastasia.Heal}, {artem.Heal}");

// yaroslav.TakeDamage(-20);
// Console.WriteLine($"После неверного урона: {yaroslav.Heal}");

// artem.TakeDamage(200);
// Console.WriteLine($"После сильного урона, Артём: {artem.Heal}");

// yaroslav.Heall(10);
// yaroslav.GainExp(40);
// yaroslav.GainExp(25);

// Console.WriteLine($"После лечения, Ярослав: {yaroslav.Heal}");
// Console.WriteLine($"Опыт Ярослава: {yaroslav.Exp}");

// bool yaroslavAlive = yaroslav.IsAlive();
// Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
// Console.WriteLine($"Артём жив: {artem.IsAlive()}");

// if (yaroslavAlive) {
//     Console.WriteLine("Ярослав может продолжать приключение.");
// } else {
    
//     Console.WriteLine("Ярослав больше не может сражаться.");

// }

// string info = yaroslav.GetInfo();
// Console.WriteLine("Строка получена. Сейчас выведем её:");
// Console.WriteLine(info);

// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());


Product laptop = new Product("Ноутбук", 5, 65000);
Product mouse = new Product("Мышь", 10, 1500);

laptop.Sell(2);
mouse.Restock(5);

Console.WriteLine($">>> {laptop.Title} <<<\nОстаток: {laptop.Quantity}, Стоимость склада: {laptop.GetTotalValue()}");
Console.WriteLine();
Console.WriteLine($">>> {mouse.Title} <<<\nОстаток: {mouse.Quantity}, Стоимость склада: {mouse.GetTotalValue()}");




// Game q = new Game("qq");
// Game w = new Game("ww");
// Game e = new Game("ee");

// Console.WriteLine(">>> 1 <<<");
// Console.WriteLine($"название: {q.Name}");
// Console.WriteLine($"жанр: {q.Sh}");
// Console.WriteLine($"год выхода: {q.age}");
// Console.WriteLine($"рейтинг: {q.P}");

// Console.WriteLine();

// Console.WriteLine(">>> 2 <<<");
// Console.WriteLine($"название: {w.Name}");
// Console.WriteLine($"жанр: {w.Sh}");
// Console.WriteLine($"год выхода: {w.age}");
// Console.WriteLine($"рейтинг: {w.P}");

// Console.WriteLine();

// Console.WriteLine(">>> 3 <<<");
// Console.WriteLine($"название: {e.Name}");
// Console.WriteLine($"жанр: {e.Sh}");
// Console.WriteLine($"год выхода: {e.age}");
// Console.WriteLine($"рейтинг: {e.P}");

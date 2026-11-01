//Шаг 2. Первый void-метод
PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();
void PrintHeader() {
Console.WriteLine("^_^");
Console.WriteLine("Лабораторная работа №6");
Console.WriteLine("0_0");
}
void PrintFooter() {
Console.WriteLine(">_<");
Console.WriteLine(" Конец программы");
Console.WriteLine("X_X");
}
//Шаг 4. Параметризованное приветствие
PrintStudentCard("Иванов Иван", "ИСП-221", 2);
PrintStudentCard("Смирнова Анна", "ИСП-222", 2);
void PrintStudentCard(string name, string group, int course) {
Console.WriteLine($"Студент: {name}, группа {group}, курс {course}");
}
//Шаг 5. Несколько параметров разных типов
PrintPurchase("Ноутбук", 65000, true);
PrintPurchase("Мышь", 1200, false);
void PrintPurchase(string itemName, double price, bool hasDiscount) {
string discountLabel = hasDiscount ? " (со скидкой)" : "";
Console.WriteLine($"{itemName}: {price} руб.{discountLabel}");
}
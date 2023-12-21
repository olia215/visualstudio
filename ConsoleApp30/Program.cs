using ConsoleApp30;

internal class Program
{
    private static void Main(string[] args)
    {/*задание 1*/

        //try
        //{
        //    Student st1 = new Student("Иванов", "Иван", 2, 20);
        //    st1.ShowInfo(); 
        //    Student st2 = new Student("Сидоров", "Петр", 3, 25);
        //    st2.ShowInfo(); 

        //    Student st3 = new Student("Петров", "Петр", -7, 120); 
        //    st3.ShowInfo();
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //Console.ReadLine();


        //задание 2
        //Auto avto1 = new Auto();
        //avto1.Brand = "Toyota";
        //avto1.Color = "Red";
        //avto1.Skor = 80;

        //Auto avto2 = new Auto();
        //avto2.Brand = "Ford";
        //avto2.Color = "Blue";
        //avto2.Skor = 150;

        //Console.WriteLine("Марка: {0}, Цвет: {1}, Скорость: {2}", avto1.Brand, avto1.Color, avto1.Skor);
        //Console.WriteLine("Марка: {0}, Цвет: {1}, Скорость: {2}", avto2.Brand, avto2.Color, avto2.Skor);


        //задание 3
        //Computer comp1 = new Computer();
        //comp1.Model = "Dell";
        //comp1.Ram = 16;
        //comp1.Hdd = 1000;

        //Computer comp2 = new Computer();
        //comp2.Model = "HP";
        //comp2.Ram = 64;
        //comp2.Hdd = 500;

        //Console.WriteLine("Модель: {0}, ОЗУ: {1} Гб, HDD: {2} Гб", comp1.Model, comp1.Ram, comp1.Hdd);
        //Console.WriteLine("Модель: {0}, ОЗУ: {1} Гб, HDD: {2} Гб", comp2.Model, comp2.Ram, comp2.Hdd);


        //задание 4
        Tovar item1 = new Tovar();
        item1.Name = "Книга";
        item1.Price = 5;
        item1.Kvo = 3;

        Tovar item2 = new Tovar();
        item2.Name = "Ручка";
        item2.Price = 2;
        item2.Kvo = 15;

        Console.WriteLine("Название: {0}, Цена: {1} руб, Количество: {2}, Стоимость: {3} руб", item1.Name, item1.Price, item1.Kvo, item1.TC());
        Console.WriteLine("Название: {0}, Цена: {1} руб, Количество: {2}, Стоимость: {3} руб", item2.Name, item2.Price, item2.Kvo, item2.TC());
    }

}

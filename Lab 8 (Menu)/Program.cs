using Lab_8__Menu_;

public class Program
{
    static void Main()
    {

     
        var chickenDish = new Dish("Шашлык из курицы");
        var beefDish = new Dish("Стейк из говядины");
        var salmonDish = new Dish("Лосось на гриле");
        var pastaDish = new Dish("Наполеон");

   
        var meatSection = new Section("Мясо");
        meatSection.Add(chickenDish);
        meatSection.Add(beefDish);

        var seafoodSection = new Section("Рыба");
        seafoodSection.Add(salmonDish);

        var pastaSection = new Section("Десерты");
        pastaSection.Add(pastaDish);

        
        var menu = new Menu("Ресторан");
        menu.Add(meatSection);
        menu.Add(seafoodSection);
        menu.Add(pastaSection);

       
        menu.Print();
        Console.ReadLine();
    }
}







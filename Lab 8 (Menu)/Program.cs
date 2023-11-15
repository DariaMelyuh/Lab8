using Lab_8__Menu_;

public class Program
{
    static void Main()
    {

     
        var chickenDish = new Dish("Шашлык из курицы");
        var beefDish = new Dish("Стейк из говядины");
        var salmonDish = new Dish("Лосось на гриле");
        var napoleonCake = new Dish("Наполеон");

   
        var meatSection = new Section("Мясо");
        meatSection.Add(chickenDish);
        meatSection.Add(beefDish);

        var seafoodSection = new Section("Рыба");
        seafoodSection.Add(salmonDish);

        var cakeSection = new Section("Десерты");
        cakeSection.Add(napoleonCake);

        
        var menu = new Menu("Ресторан");
        menu.Add(meatSection);
        menu.Add(seafoodSection);
        menu.Add(cakeSection);

       
        menu.Print();
        Console.ReadLine();
    }
}







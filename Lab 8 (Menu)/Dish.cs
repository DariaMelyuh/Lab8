namespace Lab_8__Menu_
{
    public class Dish : IComponent
    {
        public string Name { get; private set; }

        public Dish(string name)
        {
            Name = name;
        }

        public void Add(IComponent component)
        {
            throw new InvalidOperationException("Нельзя добавить к блюду");
        }

        public void Remove(IComponent component)
        {
            throw new InvalidOperationException("Нельзя удалить из блюда");
        }

        public void Print()
        {
            Console.WriteLine($"- {Name}");
        }
    }
}

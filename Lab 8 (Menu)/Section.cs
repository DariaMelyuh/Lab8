namespace Lab_8__Menu_
{
    public class Section : IComponent
    {
        private readonly List<IComponent> _menuComponents = new List<IComponent>();
        public string Name { get; private set; }

        public Section(string name)
        {
            Name = name;
        }

        public void Add(IComponent component)
        {
            if (component is null)
            {
                throw new ArgumentNullException(nameof(component), "Компонент не может быть null");
            }

            _menuComponents.Add(component);
        }

        public void Remove(IComponent component)
        {
            if (component is null)
            {
                throw new ArgumentNullException(nameof(component), "Компонент не может быть null");
            }

            if (!_menuComponents.Contains(component))
            {
                throw new InvalidOperationException("Указанный компонент не найден в секции");
            }

            _menuComponents.Remove(component);
        }

        public void Print()
        {
            Console.WriteLine($"{Name}:");
            _menuComponents.ForEach(component => component.Print());
        }

    }
}

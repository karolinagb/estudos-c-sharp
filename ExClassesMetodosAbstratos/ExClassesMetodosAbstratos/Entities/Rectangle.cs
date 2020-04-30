using ExClassesMetodosAbstratos.Entities.Enums;

namespace ExClassesMetodosAbstratos.Entities
{
    //Classe herdando de uma abstract obrigatoriamente tem que implementar o método que é abstract na outra:
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}

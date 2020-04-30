using ExClassesMetodosAbstratos.Entities.Enums;

namespace ExClassesMetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        //Método abstract já vem com o override, por isso nao boto o virtual aqui:
        //método abstrato não tem corpo:
        public abstract double Area();
    }
}

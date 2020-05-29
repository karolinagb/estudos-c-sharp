using InterfaceHeranca.Model.Enums;

namespace InterfaceHeranca.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        /*Mesmo sendo uma classe abstrata, o C# exige que a mesma implemente a interface. 
         * Só que ela pode ser implementada de forma abstrata também:*/
        public abstract double Area();
    }
}

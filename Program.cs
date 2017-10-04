using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labl2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rec = new Rectangle(5, 4);
            rec.Print();

            Square squ = new Square(5, 5);
            squ.Print();

            Circle cir = new Circle(4);
            cir.Print();
        }
    }

    /// <summary>
    /// Класс фигура
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        /// Приведение к строке, переопределение метода Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
    }

    ////////////////////////////////////////////////////////////////
    interface IPrint
    {
        void Print();
    }

    ////////////////////////////////////////////////////////////////
    class Rectangle : Figure, IPrint
    {
        /// <summary>
        /// Высота
        /// </summary>
        public double height { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        public double width { get; set; }

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Rectangle(double ph, double pw)
        {
            this.height = ph;
            this.width = pw;
            this.Type = "Прямоугольник";
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }

        public void Print()
        {
            string str = this.ToString() + " ширина=" + this.width.ToString() + " высота=" + this.height.ToString();
            Console.WriteLine(str);
        }
    }

    class Square : Rectangle, IPrint
    {
        public double length { get; set; }
        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="lh"></param>      
        public Square(double lh, double k): base (lh,lh)
        {
            this.length = lh;
            this.Type = "Квадрат";
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double Result = this.length * this.length;
            return Result;
        }
        public void Print()
        {
            string str = this.ToString() + " длина стороны=" + this.length.ToString();
            Console.WriteLine(str);
        }
    }
    class Circle : Figure, IPrint
    {
        public double radius { get; set; }
        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="r"></param>      
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double Result = this.radius * this.radius*3.14;
            return Result;
        }
        public void Print()
        {
            string str = this.ToString() + " радиус=" + this.radius.ToString();
            Console.WriteLine(str);
        }
    }

}

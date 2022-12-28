using System;

namespace Figures
{
        public class Elipsoid //Класс для обрабоки окружностей
    {
        private double firstRadious; // радиус круга
        private double secondRadious = 0; // если радиуса 2, это элипс

        #region Конструкторы элипса
        public Elipsoid(double firstRadious) //конструктоор круга
        {
            this.firstRadious = firstRadious;
        }

        public Elipsoid(double firstRadious, double secondRadious) //Конструктор элипса
        {
            this.firstRadious = firstRadious;
            this.secondRadious = secondRadious;
        }
        #endregion

        #region Методы получения площади
        public double GetSquare() //Получаем радиус элипса или круга
        {
            if (this.secondRadious == 0) 
            {
                return Math.PI*this.firstRadious*this.firstRadious; // формула для круга, если нет второго радиуса
            }
            else 
            {
                return Math.PI * this.firstRadious * this.secondRadious; // формула для элипса, если есть второй радиус
            }
        }

        public static double GetSquare(double radious) // формула для круга, по данному радусу 
        {
            return Math.PI*radious*radious;
        }

        public static double GetSquare(double firstRadious, double secondRadious) // формула для элипса, по двум данным радиусам
        {
            return Math.PI*firstRadious*secondRadious;
        }
        #endregion
    }

    public class Polygon //класс для обработки многоугольников
    {
        private double[] sides; //Сторон может быть несколько

        #region Конструкторы полигона
        public Polygon(double[] sides) //конструктор полигона по заданыму массиву сторон
        {
            if (IsValide(sides))
            {
                this.sides = sides;
            }
            else 
            {
                throw new Exception("Rectangle with this sides can't exist");
            }
        }

        public Polygon(double a, double b, double c) //конструктор полигона по заданым сторонам
        {
            if (IsValide(a, b, c))
            {
                double[] sides = { a, b, c };
                this.sides = sides;
            }
            else
            {
                throw new Exception("Rectangle with this sides can't exist");
            }

        }
        #endregion

        #region Методы получения площади
        public double GetSquare()  //вычисление площади по трем сторнам через полупириметр
        {
            var p = (this.sides[0] + this.sides[1] + this.sides[2]) / 2; // Полупериметр

            return Math.Sqrt(p*(p - this.sides[0]) *(p - this.sides[1]) *(p - this.sides[2]));
        }

        public static double GetSquare(double[] sides)
        {
            var p = (sides[0] + sides[1] + sides[2]) / 2; // Полупериметр

            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }

        public static double GetSquare(double a, double b, double c)
        {
            var p = (a + b + c) / 2; // Полупериметр

            if (IsValide(a, b, c))
            {
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else 
            {
                return -1;
            }
        }
        #endregion

        #region Методы проверки треугольника на прямой угол
        public bool IsRectangular() // проверка прямогульный ли треугольник 
        {
            return (sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2])
                | (sides[1] * sides[1] == sides[2] * sides[2] + sides[0] * sides[0])
                | (sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1]);
        }

        public static bool IsRectangular(double[] sides) // проверка прямогульный ли треугольник 
        {
            return (sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2]) 
                | (sides[1] * sides[1] == sides[2] * sides[2] + sides[0] * sides[0]) 
                |(sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1]);
        }

        public static bool IsRectangular(double a, double b, double c) // проверка прямогульный ли треугольник 
        {
            return (a*a == b*b + c*c) | (b*b == c*c + a*a) | (c*c == a*a + b*b);
        }
        #endregion

        #region Проверка существования подобного треугольника
        public bool IsValide() //Валидация собственных значений
        {
            return (sides[0] < sides[1]  + sides[2])
                & (sides[1] < sides[2] + sides[0])
                & (sides[2] < sides[0] + sides[1]);
        }

        public static bool IsValide(double a, double b, double c) //Валидация по трем сторонам
        {
            return (a < b + c) 
                & (b < c + a) 
                & (c < a + b);
        }

        public static bool IsValide(double[] sides) //Валидация по трем сторонам из массива
        {
            return (sides[0] < sides[1] + sides[2])
                & (sides[1] < sides[2] + sides[0])
                & (sides[2] < sides[0] + sides[1]);
        }
        #endregion
    }
}
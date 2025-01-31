﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Classe_Triangulo
{
    class Retangulo
    {

        public double Largura;
        public double Altura;


        public double Area()
        {

            double area = (Largura * Altura);
            return area;
        }


        public double Perimetro()
        {
            double perimetro = ((Largura * 2) + (Altura * 2));
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = (Math.Sqrt(Math.Pow(Largura,2)+Math.Pow(Altura,2)));
            return diagonal;
        }

        public override string ToString()
        {
            return ($"Area: " + Area() 
                + "\nPerímetro: " + Perimetro()
                + "\nDiagonal: " + Diagonal());
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    public class Aluno
    {
        public string nome {  get; private set; }

        private double[] _notas;

        public double Media
        {
            get
               {
                return CalcularMedia();
               }
        }

        public Aluno(string nome, int provas)
        {
            this.nome = nome;
            _notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }

            return total /_notas.Length;
        }

    }
}

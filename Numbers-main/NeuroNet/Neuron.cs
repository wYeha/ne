using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.NeuroNet
{
    class Neuron
    {
        //Поля класса
        private NeuroType _type;        //тип нейронa (Hidden,Output)
        private double[] _weights;      //массив весов нейронов
        private double[] _inputs;       //массив входов нейронов
        private double _output;         //выход нейрона


        //Свойства класса (константы для функции активации нейрона)
        public double[] Weights         //массив весов функции активации нейрона
        {
            get { return _weights; }   
            set { _weights = value; }
        }

        public double[] Inputs
        {
            get { return _inputs; } 
            set { _inputs = value; }  
        }

        private double Output
        {
            get { return _output; }
            set { _output = value; }    
        }
    }
}

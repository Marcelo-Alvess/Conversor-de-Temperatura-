using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit
{
    class Conversor
    {
        //Atributos da classe Conversor.
        private double temperaturaC;
        private double temperaturaF;
        private double temperaturaK;

        //Encapsulamento dos atributos.
        public double TemperaturaC { get => temperaturaC; set => temperaturaC = value; }
        public double TemperaturaF { get => temperaturaF; set => temperaturaF = value; }
        public double TemperaturaK { get => temperaturaK; set => temperaturaK = value; }

        //Métodos

        public double calcularCkelvin()
        {
            double ConversaoK = (TemperaturaC + 273.15);
            return (ConversaoK);
        }

        public double calcularCfahrenheit()
        {
            double ConversaoF = (TemperaturaC * 1.8) + 32;
            return (ConversaoF);
        }

        public double calcularFcelsius()
        {
            double ConversaoC = (TemperaturaF - 32) / 1.8;
            return (ConversaoC);
        }

        public double calcularFkelvin()
        {
            double ConversaoK = (TemperaturaF - 32) / 1.8 + 273.15;
            return (ConversaoK);
        }

        public double calcularKcelsius()
        {
            double ConversaoC = (TemperaturaK - 273.15);
            return (ConversaoC);
        }

        public double calcularKfahrenheit()
        {
            double ConversaoF = (TemperaturaK - 273.15) * 1.8 + 32;
            return (ConversaoF);
        }
    }
}

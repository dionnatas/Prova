using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Nome: Dionnatas Santa Fe Filho
 * RA: 20580595
*/
namespace ProvaDionnatas
{
    class Consumidor
    {
        private String nome;
        private Double salario;
        private Double consumo_Quilowatts;
        private int tipo;
        private Double valor_Quilowatts;
        private Double valor_Conta;



        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Double Consumo_Quilowatts
        {
            get { return consumo_Quilowatts; }
            set { consumo_Quilowatts = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Double Valor_Quilowatts
        {
            get { return valor_Quilowatts; }
            //set { valor_Quilowatts = value; }
        }

        public Double Valor_Conta
        {
            get { return valor_Conta; }
            //set { valor_Conta = value; }
        }

        public Consumidor()
        {

        }

        public Consumidor(String nome, Double salario, Double consumo_Quilowatts, int tipo)
        {
            this.nome = nome;
            this.salario = salario;
            this.consumo_Quilowatts = consumo_Quilowatts;
            this.tipo = tipo;
            this.valor_Quilowatts = calculaValorQuilowatts(salario);
            this.valor_Conta = calculaValorConta(tipo, consumo_Quilowatts, valor_Quilowatts);
        }


        public Double calculaValorQuilowatts(Double valor)
        {
            return valor / 800;
        }

        public Double calculaValorConta(int tipo, Double consumo, Double valorQuilowatts)
        {
            Double valorParcial = 0;
            switch(tipo){
                case 1:
                valorParcial = (consumo * valorQuilowatts);
                return (valorParcial * 105) / 100;

                case 2:
                valorParcial = (consumo * valorQuilowatts);
                return (valorParcial * 110) / 100;

                case 3:
                valorParcial = (consumo * valorQuilowatts);
                return (valorParcial * 115) / 100;

                default:
                Console.WriteLine("Tipo Consumidor invaluido, não será calculado o valor do Quilowatts!");
                return 0;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_C_
{
    public struct Professor
    {
        public string nome;
        public string idade;
        public int carga_horaria;
        public int salario;
        public int qtd_faltas;
        public int valor_falta;
        public int valor_hora_extra;

        public Professor(string nome, string idade, int carga_horaria, int salario, int qtd_faltas, int valor_falta, int valor_hora_extra)
        {
            this.nome = nome;
            this.idade = idade;
            this.carga_horaria = carga_horaria;
            this.salario = salario;
            this.qtd_faltas = qtd_faltas;
            this.valor_falta = valor_falta;
            this.valor_hora_extra = valor_hora_extra;
        }

        public string reajusteSalarialEmValor(int reajuste){
            return "\n\nSalario Atual -> R$"+this.salario+"\nReajuste Salarial em Valor ficou em: R$"+ (this.salario - reajuste);
        }

        public string reajusteSalarialEmPorcentagem(int reajuste){
            int resultado = this.salario - ((this.salario * reajuste)/100);
            return "\n\nSalario Atual -> R$"+this.salario+"\nReajuste Salarial em Porcentagem ficou em: R$"+ (this.salario - resultado);
        }

        public string descontoSalarialPorFaltaEmValor(){
            int resultado = this.salario - (this.qtd_faltas * this.valor_falta);
            return "\n\nSalario Atual -> R$"+this.salario+"\nReajuste Salarial por falta em valor ficou em: R$"+ resultado;
        }

        public string descontoSalarialPorFaltaEmPorcentagem(int reajuste){
                int resultado = this.qtd_faltas * ((this.salario * reajuste)/100);
                return "\n\nSalario Atual -> R$"+this.salario+"\nReajuste Salarial por falta em Porcentagem ficou em: R$"+ (this.salario - resultado);
        }

        public string aumentarCargaHorariaDeTrabalho(int aumento){
            
            int horas_tb = this.carga_horaria + aumento;
            int reajuste = ((this.salario * aumento)/100);
            int resultado = this.salario + reajuste;
            return "\n\nSalario Atual -> R$"+this.salario+"\nAumento de Carga Horaria --> "+aumento+"\nValor Horas Extras -> R$"+reajuste+"\n Salario com Reajuste -> R$"+resultado;
        } 


    }
}
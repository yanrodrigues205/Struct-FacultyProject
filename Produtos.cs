using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_C_
{
    public struct Produtos
    {
        public string nome;
        public int quantidade;
        public int valor;
        
        public Produtos(string nome, int quantidade, int valor)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public string aplicarCupomDescontoValor(int desconto){
            return "\n Valor com cupom de desconto -> R$"+ (valor - desconto);
        }

        public string aplicarPorcentagemDesconto(int percent){
            return "\n Valor com percentual de desconto -> R$"+ (valor - ((valor * percent)/100));
        }

        public string verificarQuantidade(){
            if(this.quantidade <= 20){
                return "em falta";
            }else{
                return "quantidade boa no estoque";
            }
        }

        public string Imprimir(){
            return "Produto -> " + this.nome+ " Quantidade -> "+this.quantidade+" Valor Original -> R$"+this.valor+"\n\nEstoque -> "+verificarQuantidade(); 
        }
    }
}
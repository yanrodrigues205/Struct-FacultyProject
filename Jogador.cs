using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Struct
{
    public struct Jogador
    {
        public string nome;
        public string cpf;
        public string camisa;
        public string posicao;
        public string telefone;
        public string email;
        
        public string clube = "";
        public string tem_clube = "";
        public int cartao_amarelo_qtd = 0;
        public int cartao_vermelho_qtd = 0;


        public Jogador(string nome, string cpf, string camisa, string posicao, string telefone, string email, string clube)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.camisa = camisa;
            this.posicao = posicao;
            this.telefone = telefone;
            this.email = email;
            this.clube = clube;

        }


        public void cartao_amarelo(){
            cartao_amarelo_qtd = cartao_amarelo_qtd + 1;
            
        }
        public void cartao_vermelho(){
            cartao_vermelho_qtd = cartao_vermelho_qtd + 1;
            
        }

        public string resposta(){
            if(this.clube != ""){
                tem_clube = "Sim";
            }else{
                tem_clube = "Nao";
            }
            return "quantidade de cartoes vermelho: "+cartao_vermelho_qtd+"quantidade de cartoes amarelos: "+cartao_amarelo_qtd+" nome -> "+this.nome+"  camisa -> "+ this.camisa+" posicao -> "+this.posicao+ " telefone -> "+ this.telefone+" cpf -> "+ this.cpf+" email -> "+ this.email+"\n possui clube? "+tem_clube;
        }   
        

      
    }
}
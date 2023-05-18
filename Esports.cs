using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_C_
{
    public struct Esports
    {
        public string nome;
        public string game;
        public int qtd_membros;
        public int campeonatos = 0;
        public int saldo = 0;
        public string data_estreia;

        public Esports(string nome, string game, int qtd_membros, int campeonatos, int saldo, string data_estreia)
        {
            this.nome = nome;
            this.game = game;
            this.qtd_membros = qtd_membros;
            this.campeonatos = campeonatos;
            this.saldo = saldo;
            this.data_estreia = data_estreia;
        }
        public int ValorTotalPremiacoes(int premio){
           return saldo = saldo + premio;
        }
        public void resgistrarCampeonatosVencidos(int premio){
            campeonatos = campeonatos + 1;
            ValorTotalPremiacoes(premio);
        }

       

        public string verificaAnoEstreia(){
            string[] dados = this.data_estreia.Split("/");

            if (dados[1] == "2023"){
                return "novata";
            }else{
                return "veterano";
            }
        }

        public string Imprimir(){
            return "nome equipe -> "+this.nome+" jogadores de -> "+this.game+" quantidade de membros -> "+this.qtd_membros+" campeonatos ganhos -> "+this.campeonatos+"\nSaldo Ganho: R$"+this.saldo+"\n Verifica ano estreia -> "+verificaAnoEstreia();
        }
    }
}
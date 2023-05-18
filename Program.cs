using Struct;
using System;

namespace projeto_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador();
            for(int i =0; i < 5; i++){
                jogador.cartao_amarelo();
            }

            for(int i =0; i < 3; i++){
                jogador.cartao_vermelho();
            }
            jogador.nome = "romario do pele";    
            jogador.email = "romariodopele@hotmail.com";    
            jogador.cpf = "123.456.789-90";    
            jogador.camisa = "11";    
            jogador.telefone = "01899289038";  
            jogador.posicao = "lateral";
           jogador.clube = "bragantino";

            Console.WriteLine(jogador.resposta());

            Esports esports = new Esports();
            esports.nome = "Equipe Ganha Pao";
            esports.game = "league of legends";
            esports.qtd_membros = 23; 
            esports.data_estreia = "06/10/2010";

            esports.resgistrarCampeonatosVencidos(340);
            esports.resgistrarCampeonatosVencidos(102);

            Console.WriteLine(esports.Imprimir());
            
        
        Produtos produtos = new Produtos();
        produtos.nome = "Sabao em po";
        produtos.quantidade = 22;
        produtos.valor = 10;
        Console.WriteLine(produtos.aplicarCupomDescontoValor(2));
        Console.WriteLine(produtos.aplicarPorcentagemDesconto(50));
        Console.WriteLine(produtos.Imprimir());
        }
    }
}

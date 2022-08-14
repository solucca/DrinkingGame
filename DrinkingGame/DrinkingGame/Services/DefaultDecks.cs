﻿using DrinkingGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkingGame.Services
{
    public class DefaultDecks
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public List<Baralho> Baralhos { get; set; } = new List<Baralho>();
        public DefaultDecks()
        {
            AddDefaultCards();
            AddDefaultBaralhos();
        }
        public void AddDefaultBaralhos()
        {
            Baralhos.Add(new Baralho() { Nome = "Padrão", Descr = "Baralho tradicional para situações normais do dia a dia", Filename = "Padrao",                               Cards = Cards.FindAll(c => c.Baralho == "Padrão") });
            Baralhos.Add(new Baralho() { Nome = "Parque", Descr = "Gleis ou Kleiner Tiergarten, o importante é passar vergonha em público!", Filename = "Parque",               Cards = Cards.FindAll(c => c.Baralho == "Parque") });
            Baralhos.Add(new Baralho() { Nome = "Trevas", Descr = "Aqui estão as cartas rejeitadas por serem pesadas demais para o jogo. Fica o aviso...", Filename = "Trevas", Cards = Cards.FindAll(c => c.Baralho == "Trevas") });
            Baralhos.Add(new Baralho() { Nome = "Apê"   , Descr = "Tem coisa que só dá para fazer em casa, por exemplo passar vergonha em casa.", Filename = "Ape",             Cards = Cards.FindAll(c => c.Baralho == "Apê") });
        }
        public void AddDefaultCards()
        {
            Cards.Add(new Card { Id = 0, Tipo = "Desafio", Nome = "Deixe <jogador_x> preparar um drink para você", Legenda = "", Shots = 4, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 1, Tipo = "Desafio", Nome = "Dê um selinho no <jogador_x>", Legenda = "", Shots = 1, Pontos = 1, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 2, Tipo = "Desafio", Nome = "Dê seu número para um estranho", Legenda = "Se lembre de ligar amanhã", Shots = 1, Pontos = 3, Baralho = "Parque" });
            Cards.Add(new Card { Id = 3, Tipo = "Desafio", Nome = "Chupe o dedão de alguém", Legenda = "", Shots = 3, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 4, Tipo = "Desafio", Nome = "Coloque uma colher de açucar nas suas roupas de baixo", Legenda = "", Shots = 1, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 5, Tipo = "Desafio", Nome = "Deixe alguém esfregar a bunda na sua cara", Legenda = "", Shots = 3, Pontos = 4, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 6, Tipo = "Desafio", Nome = "Selinho em todos os jogadores", Legenda = "", Shots = 3, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 7, Tipo = "Desafio", Nome = "Retire as meias de alguém usando os dentes", Legenda = "O que é um chulé?", Shots = 2, Pontos = 4, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 8, Tipo = "Desafio", Nome = "Plante bananeira por 15 segundos", Legenda = "", Shots = 2, Pontos = 2, Baralho = "Parque" });
            Cards.Add(new Card { Id = 9, Tipo = "Desafio", Nome = "Coloque uma venda e dance no colo de alguém", Legenda = " Você nunca saberá quem é.", Shots = 3, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 10, Tipo = "Desafio", Nome = "Posicione ambas as mãos nos glúteos máximos da pessoa com maior volume nessa região", Legenda = "Aproveite a experiencia", Shots = 2, Pontos = 2, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 11, Tipo = "Desafio", Nome = "Sorteie três jogadores e escolha um para beijar", Legenda = "Use o botão de sortear", Shots = 2, Pontos = 2, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 12, Tipo = "Desafio", Nome = "Coma um guardanapo inteiro", Legenda = "É saudável, confia", Shots = 1, Pontos = 1, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 13, Tipo = "Desafio", Nome = "Conte com que frequência você se masturba", Legenda = "Não precisa ter vergonha", Shots = 3, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 14, Tipo = "Desafio", Nome = "Com qual jogador você transaria?", Legenda = "Juro que é um elogio", Shots = 2, Pontos = 2, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 15, Tipo = "Desafio", Nome = "Tire uma peça (de roupa)", Legenda = "Ta calor", Shots = 2, Pontos = 2, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 16, Tipo = "Desafio", Nome = "Morda a orelha do <jogador_x>", Legenda = "Delicinha", Shots = 1, Pontos = 1, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 17, Tipo = "Desafio", Nome = "Deixa alguém gritar alto no seu ouvido", Legenda = "O QUE? EU NÃO OUVI", Shots = 2, Pontos = 2, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 18, Tipo = "Desafio", Nome = "Tome três colheres de azeite", Legenda = "Quatro se você for extra-virgem", Shots = 3, Pontos = 3, Baralho = "Apê" });
            Cards.Add(new Card { Id = 19, Tipo = "Desafio", Nome = "Coloque sua bebida em uma camisinha e tome", Legenda = "O gosto fica melhor", Shots = 1, Pontos = 4, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 20, Tipo = "Desafio", Nome = "De olhos vendados beije de lingua três objetos escolhidos pelos outros jogadores", Legenda = "Vale objetificar o amiguinho?", Shots = 2, Pontos = 2, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 21, Tipo = "Desafio", Nome = "Faça o <jogador_x> rir", Legenda = "Você tem um minuto", Shots = 3, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 22, Tipo = "Desafio", Nome = "De um beijo de lingua em algum jogador", Legenda = "Só 5 segundos já vale", Shots = 2, Pontos = 4, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 23, Tipo = "Desafio", Nome = "Conte o que te excita", Legenda = "Ouvi dizer que tem gente interessada nessa roda aqui", Shots = 2, Pontos = 2, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 24, Tipo = "Desafio", Nome = "Peça para tirar uma foto com uma pessoa estranha", Legenda = "Diga xis", Shots = 2, Pontos = 2, Baralho = "Parque" });
            Cards.Add(new Card { Id = 25, Tipo = "Desafio", Nome = "Beba 4 vezes", Legenda = "kkkk", Shots = 4, Pontos = 4, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 26, Tipo = "Desafio", Nome = "Deixe desenharem uma piroca na sua testa", Legenda = "Com veias e pelinhos", Shots = 2, Pontos = 2, Baralho = "Apê" });
            Cards.Add(new Card { Id = 27, Tipo = "Desafio", Nome = "Deixe seus amigos fazerem o seu penteado", Legenda = "Vai ficar chave", Shots = 1, Pontos = 1, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 28, Tipo = "Desafio", Nome = "Deixa alguém cuspir água na sua cara", Legenda = "Ta calor, vai ser bom", Shots = 3, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 29, Tipo = "Desafio", Nome = "Explique como você quer que seja a sua próxima transa", Legenda = "Quem quando e onde", Shots = 2, Pontos = 2, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 30, Tipo = "Desafio", Nome = "Cante uma musica sertaneja", Legenda = "Gustavo Lima não vale", Shots = 1, Pontos = 1, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 31, Tipo = "Desafio", Nome = "Mande um \"oi, como que tão as coisas ? \" para seu/sua Ex", Legenda = "Vai dar bom", Shots = 3, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 32, Tipo = "Desafio", Nome = "Coloque Ketchup na sua bebida", Legenda = "Tudo fica melhor quem Ketchup", Shots = 1, Pontos = 1, Baralho = "Apê" });
            Cards.Add(new Card { Id = 33, Tipo = "Desafio", Nome = "Finja um orgasmo", Legenda = "Igual você faz na cama", Shots = 3, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 34, Tipo = "Desafio", Nome = "Faça um boquete.... Na garrafa", Legenda = "Pense nisso como um treinamento", Shots = 3, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 35, Tipo = "Desafio", Nome = "Dê a luz a uma garrafa", Legenda = "Parto natural, obviamente", Shots = 3, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 36, Tipo = "Desafio", Nome = "Demonstre sua posição sexual favorita", Legenda = "Vai que tem alguém interessado...", Shots = 3, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 37, Tipo = "Desafio", Nome = "Passe batom", Legenda = "Ta muito foda", Shots = 2, Pontos = 2, Baralho = "Apê" });
            Cards.Add(new Card { Id = 38, Tipo = "Desafio", Nome = "Roa a unha de outro jogador", Legenda = "É tempero", Shots = 1, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 39, Tipo = "Desafio", Nome = "Cheire uma carreira de sal", Legenda = "Anarcos", Shots = 3, Pontos = 3, Baralho = "Apê" });
            Cards.Add(new Card { Id = 40, Tipo = "Desafio", Nome = "Beba do seu sapato", Legenda = "Você ta de chinelo? Se vira!", Shots = 2, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 41, Tipo = "Desafio", Nome = "Escolha alguém para beber 3 shots", Legenda = "Você pode se salvar", Shots = 1, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 42, Tipo = "Desafio", Nome = "Coloque o dedo de dois jogadores na sua boca e chupe devagar", Legenda = "A gente tava na duvida sobre essa carta", Shots = 1, Pontos = 4, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 43, Tipo = "Desafio", Nome = "<jogador_x> tira uma peça de roupa sua", Legenda = "Você não escolhe qual", Shots = 1, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 44, Tipo = "Desafio", Nome = "Passe um cubo de gelo para <jogador_x>", Legenda = "Não vale usar as mãos", Shots = 1, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 45, Tipo = "Desafio", Nome = "Conte o lugar mais inusitado onde você já transou", Legenda = "Eles te conhecem, ninguém vai ficar surpreso", Shots = 2, Pontos = 2, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 46, Tipo = "Desafio", Nome = "Encene o início de um filme pornô", Legenda = "Pode chamar alguém para contracenar", Shots = 2, Pontos = 2, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 47, Tipo = "Desafio", Nome = "Dê em cima de alguém", Legenda = "Do seu próprio genero", Shots = 1, Pontos = 2, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 48, Tipo = "Desafio", Nome = "Cherinho no caongote de <jogador_x>", Legenda = "Hummmm, cherinho de susexo", Shots = 2, Pontos = 2, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 49, Tipo = "Desafio", Nome = "Deixe todo mundo cuspir um pouco de bebida no seu copo", Legenda = "Abraço Covid", Shots = 1, Pontos = 4, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 50, Tipo = "Desafio", Nome = "Tire a sua roupa de baixo e dê para algum jogador", Legenda = "Nem ta tão fedida", Shots = 1, Pontos = 5, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 51, Tipo = "Desafio", Nome = "Deixe alguém te dar um chupão", Legenda = "Saudades chupe-chupe", Shots = 2, Pontos = 4, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 52, Tipo = "Desafio", Nome = "Feche os olhos e espere um selinho.", Legenda = "Se você acertar pode ganhar mais pontos sem beber.", Shots = 2, Pontos = 2, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 53, Tipo = "Desafio", Nome = "Lamba um sabonete", Legenda = "Limpa essa sua boca suja", Shots = 2, Pontos = 2, Baralho = "Apê" });
            Cards.Add(new Card { Id = 54, Tipo = "Desafio", Nome = "Vire meio litro d'água", Legenda = "É importante se hidratar", Shots = 2, Pontos = 2, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 55, Tipo = "Desafio", Nome = "Sente no colo de outro jogador até o seu próximo turno", Legenda = "Pra ficar mais confortável", Shots = 1, Pontos = 1, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 56, Tipo = "Desafio", Nome = "Beba no umbigo de alguém", Legenda = "Body shot", Shots = 2, Pontos = 3, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 57, Tipo = "Desafio", Nome = "Coloque a sua bebida no microondas por 30 segundo", Legenda = "Cuidado pra não por metal", Shots = 2, Pontos = 2, Baralho = "Apê" });
            Cards.Add(new Card { Id = 58, Tipo = "Jogo", Nome = "Quem é mais provável de ser preso.", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 59, Tipo = "Jogo", Nome = "Quem é mais provável de roubar um banco", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 60, Tipo = "Jogo", Nome = "Quem é mais provável de virar politico", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 61, Tipo = "Jogo", Nome = "Quem é mais provável de chutar um cachorro", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 62, Tipo = "Jogo", Nome = "Jogo do cartão: Passem o cartão de boca em boca", Legenda = "A dupla que deiar cair da um selinho", Shots = 0, Pontos = 0, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 63, Tipo = "Jogo", Nome = "Ursinho", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 64, Tipo = "Regra", Nome = "Até a sua próxima rodada você não pode falar a palavra \"não\"", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 65, Tipo = "Regra", Nome = "Termine todas as suas frases com câmbio.", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 66, Tipo = "Regra", Nome = "Gire 10 vezes e ande em linha reta", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Parque" });
            Cards.Add(new Card { Id = 67, Tipo = "Regra", Nome = "Você não pode chamar ninguém pelo nome proprio", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 68, Tipo = "Regra", Nome = "Se atire quando alguém gritar granada", Legenda = "Fire in the hole!", Shots = 0, Pontos = 0, Baralho = "Parque" });
            Cards.Add(new Card { Id = 69, Tipo = "Regra", Nome = "Use seus sapatos como luvas", Legenda = "Avant-garde da moda", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 70, Tipo = "Regra", Nome = "Quando alguém fizer um desafio de quatro pontos beba uma vez", Legenda = "Companheiro é companheiro", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 71, Tipo = "Regra", Nome = "Grite saúde antes de beber", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 72, Tipo = "Regra", Nome = "Fique de mãos fechadas", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 73, Tipo = "RNG", Nome = "\"Racismo não é bacana\" quem concorda bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 74, Tipo = "RNG", Nome = "Quem for ateu bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 75, Tipo = "RNG", Nome = "Todo mundo bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 76, Tipo = "RNG", Nome = "Quem já esteve em um acidente de carro bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 77, Tipo = "RNG", Nome = "Mulheres bebem", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 78, Tipo = "RNG", Nome = "Os homens bebem", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 79, Tipo = "RNG", Nome = "Quem for não cis bebe dois shots", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 80, Tipo = "RNG", Nome = "O jogador mais mal vestido bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 81, Tipo = "RNG", Nome = "Os desempregados bebem", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 82, Tipo = "RNG", Nome = "Quem tá de verde bebe", Legenda = "Foda-se o Unwelt", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 83, Tipo = "RNG", Nome = "Quem bater na testa por ultimo bebe", Legenda = "Com força", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 84, Tipo = "RNG", Nome = "Quem já teve experiencia de quase morte bebe", Legenda = "Força ai", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 85, Tipo = "RNG", Nome = "Quem estiver usando sutiã bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 86, Tipo = "RNG", Nome = "Os jogadores mais pesado e mais leve bebem", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 87, Tipo = "RNG", Nome = "Quem já andou de ambulância bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 88, Tipo = "RNG", Nome = "Todos os solteiros bebem", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 89, Tipo = "RNG", Nome = "Filhos unicos bebem", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 90, Tipo = "RNG", Nome = "Quem tem irmão/irmã bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 91, Tipo = "RNG", Nome = "Quem namora bebe", Legenda = "Namora não da", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 92, Tipo = "Jogo", Nome = "Quem é mais provável de trair", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 93, Tipo = "Jogo", Nome = "Quem é mais provável de ser traido", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 94, Tipo = "Jogo", Nome = "Quem é mais provável de ser preso", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 95, Tipo = "Jogo", Nome = "Quem é mais provável de mandar nudes", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 96, Tipo = "RNG", Nome = "Quem já mandou nudes bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 97, Tipo = "Jogo", Nome = "Quem é mais provável de ficar com crush de amigo", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 98, Tipo = "Jogo", Nome = "Quem é mais provável de se safar de um assassinato", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 99, Tipo = "Jogo", Nome = "Quem é mais provável de se atrasar do próprio casamento", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 100, Tipo = "Jogo", Nome = "Quem mente melhor do grupo", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 101, Tipo = "Jogo", Nome = "Quem é mais provável de chorar em filme triste", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 102, Tipo = "Jogo", Nome = "Quem é mais provável de cair em Fake News", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 103, Tipo = "Jogo", Nome = "Quem é mais provável de correr pelado", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 104, Tipo = "Jogo", Nome = "Quem é mais gado", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 105, Tipo = "Jogo", Nome = "Quem é mais provável de se casar primeiro", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 106, Tipo = "Jogo", Nome = "Quem é mais provável de ter um coma alcoólico", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 107, Tipo = "Jogo", Nome = "Quem é mais provável de ter uma overdose", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 108, Tipo = "Jogo", Nome = "Quem é mais provavel de costas", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 109, Tipo = "Jogo", Nome = "Eu nunca tive \"relações\" com uma pessoa de que eu não gostava", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 110, Tipo = "Jogo", Nome = "Eu nunca beijei um crush de amigo", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 111, Tipo = "Jogo", Nome = "Eu nunca transei na piscina", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 112, Tipo = "Jogo", Nome = "Eu nunca tive um wet dream com alguém da roda", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 113, Tipo = "Jogo", Nome = "Eu nunca transei em lugar público", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 114, Tipo = "Jogo", Nome = "Eu nunca quis pegar alguém casado", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 115, Tipo = "Jogo", Nome = "Eu nunca fiquei com irmão/irmã de amigx", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 116, Tipo = "Jogo", Nome = "Eu nunca pedi pra volta com EX", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 117, Tipo = "Jogo", Nome = "Eu nunca usei algemas na cama", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 118, Tipo = "Jogo", Nome = "Eu nunca fiquei com uma pessoa e nunca mais falei com ela", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 119, Tipo = "Jogo", Nome = "Eu nunca comi durante o sexo", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 120, Tipo = "Jogo", Nome = "Eu nunca me arrependi de namorar alguém", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 121, Tipo = "Jogo", Nome = "Eu nunca flertei com barista para ganhar bebida de graça", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 122, Tipo = "RNG", Nome = "A pessoa mais gata da roda bebe", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 123, Tipo = "Jogo", Nome = "Eu nunca sai sem roupa de baixo", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 124, Tipo = "Jogo", Nome = "Eu nunca fiquei com alguém só pra deixar a outra com ciúmes", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 125, Tipo = "Jogo", Nome = "Eu nunca fiquei com algéum que beija mal", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 126, Tipo = "Jogo", Nome = "Eu nunca fiz \"sacanagens\" na escola/ trabalho/ uni", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 127, Tipo = "Jogo", Nome = "Eu nunca fiquei com alguém que namorava", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 128, Tipo = "Jogo", Nome = "Eu nunca criei uma playlist para transar", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 129, Tipo = "Jogo", Nome = "Eu nunca treinei beijo de lingua", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 130, Tipo = "Jogo", Nome = "Eu nunca fiquei com alguém no banheiro de uma festa", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 131, Tipo = "Jogo", Nome = "Eu nunca estive em um threesome", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 132, Tipo = "Jogo", Nome = "Eu nunca acordei sem saber onde eu estava", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 133, Tipo = "Jogo", Nome = "Eu nunca comprei um \"brinquedo\"", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 134, Tipo = "Jogo", Nome = "Eu nunca dormi chorando por causa de alguém", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 135, Tipo = "Jogo", Nome = "Eu nunca beijei na escola", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 136, Tipo = "Jogo", Nome = "Eu nunca fui pego transando", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 137, Tipo = "Jogo", Nome = "Eu nunca falhei depois de me arranjarem pro @", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 138, Tipo = "Jogo", Nome = "Eu nunca dei PT na casa do @", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 139, Tipo = "Jogo", Nome = "Quem é mais provavel de ser cancelado", Legenda = "", Shots = 0, Pontos = 0, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 140, Tipo = "Desafio", Nome = "Lamba o umbigo de <jogador_x>", Legenda = "", Shots = 4, Pontos = 4, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 141, Tipo = "Desafio", Nome = "Mostre um mamilo para a pessoa na sua direita", Legenda = "UM MAMILO APENAS", Shots = 4, Pontos = 5, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 142, Tipo = "Desafio", Nome = "Beijo triplo com duas pessoas de sua escolha", Legenda = "", Shots = 4, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 143, Tipo = "Desafio", Nome = "Beijo quádruplo ", Legenda = "Inlcuir no mínimo uma pessoa de cada identidade de gênero presente", Shots = 4, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 144, Tipo = "Desafio", Nome = "Chupao de 3 segundos na pessoa da sua esquerda", Legenda = "", Shots = 4, Pontos = 4, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 145, Tipo = "Desafio", Nome = "Lamba a orelha de <jogador_x>", Legenda = "", Shots = 3, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 146, Tipo = "Desafio", Nome = "Morda a canela de <jogador_x>", Legenda = "", Shots = 3, Pontos = 4, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 147, Tipo = "Desafio", Nome = "Dance quadradinho de 8 ao som de Vamos Pra Gaiola", Legenda = "", Shots = 4, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 148, Tipo = "Desafio", Nome = "Striptease sensual de uma peça de roupa ao som de Pony", Legenda = "Caso a pessoa se sinta desconfortável em ficar sem camiseta, é permitido fazer com um casaco", Shots = 4, Pontos = 5, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 149, Tipo = "Desafio", Nome = "Melhor de 3 rounds de batalha de rima com <jogador_x>", Legenda = "", Shots = 4, Pontos = 4, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 150, Tipo = "Desafio", Nome = "Imite uma personalidade famosa da TV brasileira", Legenda = "Os outros participantes tem que adivinhar quem é", Shots = 4, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 151, Tipo = "Desafio", Nome = "Troque sua peça de roupa superior com uma pessoa de outro gênero por 1 rodada", Legenda = "", Shots = 4, Pontos = 5, Baralho = "Trevas" });
            Cards.Add(new Card { Id = 152, Tipo = "Desafio", Nome = "Cante I will always love you da Whitney Houston com vontade", Legenda = "Tente acertar as notas de verdade sem desafinar", Shots = 4, Pontos = 4, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 153, Tipo = "Desafio", Nome = "Simule um 69 em pé com <jogador_x> ", Legenda = "Você deve ser a pessoa de ponta cabeça", Shots = 4, Pontos = 4, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 154, Tipo = "Desafio", Nome = "Fique de 4 e deixe <jogador_x> te dar um tapasso na bunda", Legenda = "", Shots = 4, Pontos = 3, Baralho = "Padrão" });
            Cards.Add(new Card { Id = 155, Tipo = "Desafio", Nome = "Dê um pega de um beck e passe na boca de uma pessoa à sua escolha", Legenda = "", Shots = 4, Pontos = 4, Baralho = "Padrão" });
        }
    }
}

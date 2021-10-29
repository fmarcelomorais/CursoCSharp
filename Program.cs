using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;



namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // FUNDAMENTOS
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Conversôes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},

                // ESTRUTURA DE CONTROLE
                {"Estrutura If - Fundamentos", EstruturaIf.Executar},
                {"Estrutura If e Else - Fundamentos", EstruturaIfElse.Executar},
                {"Estrutura If e Else If - Fundamentos", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Fundamentos", EstruturaSwitch.Executar},

                // ESTRUTURA DE ITERAÇÃO
                {"Estrutura While - Fundamentos", EstruturaWhile.Executar},
                {"Estrutura Do While - Fundamentos", EstruturaDoWhile.Executar},
                {"Estrutura For- Fundamentos", EstruturaFor.Executar},
                {"Estrutura ForEach- Fundamentos", EstruturaForEach.Executar},
                {"Usando Breack- Fundamentos", UsandoBreack.Executar},
                {"Usando Continue- Fundamentos", UsandoContinue.Executar},

                // CLASSES E METODOS
                {"Membros - Classes e Metodos", Membors.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Parametros - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametroNomeado.Executar},
                {"Getters e Setters - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Atributos ReadOnly - Classes e Metodos", ReadOnly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Metodos", ClasseVsStruct.Executar},
                {"Valor vs Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                // COLEÇÕES
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Fila - Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dicionario - Coleções", ColecoesDicionario.Executar},
                //
                {"Herança - POO", Heranca.Executar},
                {"Construtor THIS - POO", ConstrutorThis.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
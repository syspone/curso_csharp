using System;
using System.Collections.Generic;

using AppCurso.Fundamentos;

namespace AppCurso {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis - Fundamentos", Variaveis.Executar},
                {"Tipos de Dados - Fundamentos", TiposDados.Executar},
                {"****Continuacao Tipos - Fundamentos", TiposDados.Executar2},
                {"Tipos de Dados Integrais - Fundamentos", TiposInter.Executar},
                {"Tipos de Dados Integrais2 - Fundamentos", TiposInter.Executar2},
                {"Tipos de Dados Ponto Fluante - Fundamentos", TiposFlutuantes.Executar},
                {"Processamento e Casting - Fundamentos", ProcessCasting.Executar},
                {"ExCasting - Fundamentos", ProcessCasting.ExCasting},
                {"Entrada de Dados - Fundamentos", InputDate.Executar},
                {"Entrada de Varios Dados - Fundamentos", InputDates.Executar},
                {"Funcoes Matematicas - Fundamentos", FuncMat.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}
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
                {"Tipos de Dados Integrais2 - Fundamentos", TiposInter.Executar2}
            });

            central.SelecionarEExecutar();
        }
    }
}
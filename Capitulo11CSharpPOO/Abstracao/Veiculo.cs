using System;

namespace Capitulo11CSharpPOO.Abstracao
{
    public abstract class Veiculo
    {
        public string TipoModelo { get; private set; }

        public Veiculo(string tipoModelo)
        {
            TipoModelo = tipoModelo;
        }

        public abstract void Mover();

        public abstract void Parar();

        public void Ligar()
        {
            Console.WriteLine("Fonte de propulsão ativada.");
        }
    }
}

// Qual a difereça dessa classe Veículo Abstrata para a classe Veículo Não Abstrata?
// 1º Não se pode instanciar uma classe Abstrata (criar um objeto abstrato não existe).
// 2º Classes abstratas podem ser herdadas e esse é seu propósito.
// 3º Uma classe abstrata pode conter métodos comuns, somente será obrigatórios para as classes filhas implementar os métodos abstratos.
//  *Remover um método sobrescrito de uma das classes filhas para entender!
// 4º Um método marcado como abstract já é virtual, então não podemos adicionar a palavra abstract na sua assinatura.
// 5º Por ser um método virtual é obrigatório o uso de overrides nos métodos das classes filhas.
//  *Remover o termo override de uma das classes filhas para entender!

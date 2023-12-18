using btg_testes_auto;
using NSubstitute.ExceptionExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
    public class MotoristaTest
    {
        [Fact]
        public void EncontrarMotorista_RespostaMotoristaEncontrado()
        {
            //Arrange
            Motorista motorista = new();
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){ Nome = "Karen", Idade = 30, PossuiHabilitaçãoB = true},
                new Pessoa(){ Nome = "Luciana", Idade = 15, PossuiHabilitaçãoB = false},
                new Pessoa(){ Nome = "Liliane", Idade = 20, PossuiHabilitaçãoB = true},
                new Pessoa(){ Nome = "Paulo", Idade = 15, PossuiHabilitaçãoB = false},
            };

            //Act
            string resultado = motorista.EncontrarMotoristas(pessoas);

            //Assert
            Assert.Contains("Uhuu!", resultado);

        }

        [Fact]
        public void EncontrarMotorista_Resposta1MotoristaEncontrado()
        {
            //Arrange
            Motorista motorista = new();
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){ Nome = "Karen", Idade = 30, PossuiHabilitaçãoB = true},
                new Pessoa(){ Nome = "Luciana", Idade = 15, PossuiHabilitaçãoB = false},
                new Pessoa(){ Nome = "Liliane", Idade = 20, PossuiHabilitaçãoB = false},
                new Pessoa(){ Nome = "Paulo", Idade = 15, PossuiHabilitaçãoB = false},
            };

            //Act
            Action resultado = () => motorista.EncontrarMotoristas(pessoas);

            //Assert
            Assert.Throws<Exception>(resultado);

        }

        [Fact]
        public void EncontrarMotorista_RespostaNenhumMotoristaEncontrado()
        {
            //Arrange
            Motorista motorista = new();
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){ Nome = "Karen", Idade = 30, PossuiHabilitaçãoB = false},
                new Pessoa(){ Nome = "Luciana", Idade = 15, PossuiHabilitaçãoB = false},
                new Pessoa(){ Nome = "Liliane", Idade = 20, PossuiHabilitaçãoB = false},
                new Pessoa(){ Nome = "Paulo", Idade = 15, PossuiHabilitaçãoB = false},
            };

            //Act
            Action resultado = () => motorista.EncontrarMotoristas(pessoas);

            //Assert
            Assert.Throws<Exception>(resultado);

        }
    }
}

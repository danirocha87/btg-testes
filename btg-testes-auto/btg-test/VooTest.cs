using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
    public class VooTest
    {
        Voo voo = new("tam", "157", new DateTime(2024, 10, 10, 07, 07, 0));

        [Fact]
        public void ProximoLivre_Sucesso()
        {
            int resultado = voo.ProximoLivre();

            Assert.InRange(resultado, 0, 100);
        }

        [Fact]
        public void AssentoDisponivel_Sucesso()
        {
            bool resultado = voo.AssentoDisponivel(45);

            Assert.True(resultado);
        }

        [Fact]
        public void AssentoDisponivel_AssentoOcupado()
        {
            voo.OcupaAssento(86);

            bool resultado = voo.AssentoDisponivel(86);

            Assert.False(resultado);
        }

        [Fact]

        public void OcupaAssento_Sucesso()
        {
            bool resultado = voo.OcupaAssento(45);

            Assert.True(resultado);
        }

        [Fact]
        public void QuantidadeVagasDisponivel_Sucesso()
        {
            int resultado = voo.QuantidadeVagasDisponivel();

            Assert.InRange(resultado, 0, 100);
        }

       
        [Fact]
        public void ExibirInformacaoVoo_Sucesso()
        {
            string resultado = voo.ExibeInformacoesVoo();

            Assert.Equal(resultado, "Aeronave Tam registrada  voo de número 157 para o dia e hora 10/10/2024 07:07:00");
        }
    }
}

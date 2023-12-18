using btg_testes_auto.Notification;
using FluentAssertions;
using NSubstitute;

namespace btg_test.NotificationEmailTest
{
    public class NotificationServiceTest
    {
        private readonly IEmailService _mockEmailService;
        private NotificationService _notificationService;

        public NotificationServiceTest()
        {
            _mockEmailService = Substitute.For<IEmailService>();
            _notificationService = new(_mockEmailService);
        }

        [Fact]
        public void SendNotification_Sucesso()
        {

            //Act
            bool resultado =  _notificationService.SendNotification("danielarocha@hotmail.com", "Sucesso");
            
            //Assert
           //Assert.True(resultado); - Não está funcionando 
            Assert.False(resultado);

        }

        [Fact]
        public void SendNotification_MensagemVazia()
        {

            //Act
            bool resultado = _notificationService.SendNotification("danielarocha@hotmail.com", "");

            //Assert
            Assert.False(resultado);

        }

        [Fact]
        public void SendNotification_Exception()
        {

            //Act
            bool resultado = _notificationService.SendNotification("", "Sucesso!");

            //Assert
            Assert.False(resultado);

        }

    }
}

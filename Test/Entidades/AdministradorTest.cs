using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class AdministradorTest
{
    [TestMethod]
    public void TestGetSetPropriedades()
    {
        //Arrange
        var Adm = new Administrador();

        //Act
         Adm.Id = 1;
        Adm.Email = "teste@teste.com";
        Adm.Senha = "teste";
        Adm.Perfil = "Adm";

        //Assert
        Assert.AreEqual(1, Adm.Id);
        Assert.AreEqual("teste@teste.com", Adm.Email);
        Assert.AreEqual("teste", Adm.Senha);
        Assert.AreEqual("Adm", Adm.Perfil);
    }
}
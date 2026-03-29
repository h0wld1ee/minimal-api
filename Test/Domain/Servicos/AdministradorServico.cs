using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Testing.Platform.Configurations;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore.InMemory;


namespace Test.Domain.Entidades;

[TestClass] 
[DoNotParallelize]
public sealed class AdministradorServicoTest
 { 
    private DbContexto CriarContextoDeTeste()
    { var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); 
    var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", "..")); 
    var builder = new ConfigurationBuilder() 
    .SetBasePath(path ?? Directory.GetCurrentDirectory()) 
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) 
    .AddEnvironmentVariables(); 
    var configuration = builder.Build(); 
    return new DbContexto(configuration); 
    }


     [TestMethod] 
     public void TestandoSalvarAdministrador() 
     {
    //Arrange 
     var context = CriarContextoDeTeste(); context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores"); 
     var adm = new Administrador(); adm.Id = 1; adm.Email = "teste@teste.com"; adm.Senha = "teste"; adm.Perfil = "Adm"; 
     var administradorServico = new AdministradorServico(context); 

     //Act 
     administradorServico.Incluir(adm);

     //Assert

      var lista = administradorServico.Todos(0);
      Assert.AreEqual(1, lista.Count());
       } 
     
     
     
      [TestMethod] 
      public void TestandoBuscaPorId() 
      { 
      //Arrange 
      var context = CriarContextoDeTeste(); 
      context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores"); 
      var adm = new Administrador(); 
      adm.Id = 1; 
      adm.Email = "teste@teste.com"; 
      adm.Senha = "teste"; 
      adm.Perfil = "Adm"; 
      var administradorServico = new AdministradorServico(context); 

      //Act 
      administradorServico.Incluir(adm); 
      var admDoBanco = administradorServico.BuscaPorId(adm.Id); 

      //Assert 
      Assert.IsNotNull(admDoBanco);
      Assert.AreEqual(1, admDoBanco.Id); 
      
      } 
     
      }








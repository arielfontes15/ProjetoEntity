using AplicacaoAPI.Controllers;
using AplicacaoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace TesteAplicacao
{
    public class CategoriasControllerTest
    {

        ////Para criar um objeto Mock e nao um objeto real quando for testar
        //private readonly Mock<DbSet<Categoria>> _mockSet;
        //private readonly Mock<Context> _mockContext;
        //private readonly Categoria _categoria;

        //public CategoriasControllerTest()
        //{
        //    //Inicialização do test
        //    _mockSet = new Mock<DbSet<Categoria>>();
        //    _mockContext = new Mock<Context>();
        //    _categoria = new Categoria { Descricao = "Teste 2" };

        //    _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);
        //    _mockContext.Setup(m => m.Categorias.FindAsync(1))
        //        .ReturnsAsync(_categoria);

        //    _mockContext.Setup(m => m.SetModified(_categoria));
        //    _mockContext.Setup(m => m.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);


        //}

        ////Testando o Metodo GET
        //[Fact]
        //public async Task Get_Categoria()
        //{
        //    var service = new CategoriasController(_mockContext.Object);

        //    await service.GetCategoria(1);

        //    _mockSet.Verify(m => m.FindAsync(1),
        //        Times.Once());
        //}

        //[Fact]
        //public async Task Put_Categoria()
        //{
        //    var service = new CategoriasController(_mockContext.Object);

        //    await service.PutCategoria(1, _categoria);

        //    _mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
        //        Times.Once());
        //}
    }
}

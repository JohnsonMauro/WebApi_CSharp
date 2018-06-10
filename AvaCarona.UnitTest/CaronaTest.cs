using AvaCarona.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AvaCarona.UnitTest
{
  [TestClass]
  public class CaronaTest
  {
    [TestMethod]
    public void VerificarCarona_SePossuiDataEHoraRIO_IsTrue()
    {
      Carona carona = new Carona();

      var esperado = carona.CriarCarona(carona.DataHoraSaida);

      Assert.IsTrue(esperado);
    }
  }
}

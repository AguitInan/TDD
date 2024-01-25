using Exercice03.Core;
using Xunit;

namespace Exercice03.Tests
{
    public class RechercheVilleTest
    {
        [Fact]
        public void TestRechercheLongueurMinimale()
        {
            var rechercheVille = new RechercheVille();
            Assert.Throws<NotFoundException>(() => rechercheVille.Rechercher("a"));
        }
    }
}

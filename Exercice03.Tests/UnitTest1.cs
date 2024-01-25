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

        [Fact]
        public void TestRechercheCorrespondanceExacte()
        {
            var rechercheVille = new RechercheVille();
            var result = rechercheVille.Rechercher("Va");
            Assert.Contains("Valence", result);
            Assert.Contains("Vancouver", result);
            Assert.Equal(2, result.Count);

        }

        [Fact]
        public void TestRecherchePartielle()
        {
            var rechercheVille = new RechercheVille();
            var result = rechercheVille.Rechercher("ape");
            Assert.Contains("Budapest", result);
        }
    }
}

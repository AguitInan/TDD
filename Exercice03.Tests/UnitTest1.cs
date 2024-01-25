using Xunit;

namespace Exercice03.Tests
{
    public class RechercheVilleTest
    {
        [Fact]
        public void Rechercher_DonneNotFoundException_SiRechercheTropCourte()
        {
            var rechercheVille = new RechercheVille();
            Assert.Throws<NotFoundException>(() => rechercheVille.Rechercher("a"));
        }

        [Fact]
        public void Rechercher_RetourneVillesCorrespondantes_PourPartieRecherche()
        {
            var rechercheVille = new RechercheVille();
            var result = rechercheVille.Rechercher("Va");
            Assert.Contains("Valence", result);
            Assert.Contains("Vancouver", result);
            Assert.Equal(2, result.Count);

        }

        [Fact]
        public void Rechercher_EstInsensibleALaCasse()
        {
            var rechercheVille = new RechercheVille();
            var lowerCaseResult = rechercheVille.Rechercher("valence");
            var upperCaseResult = rechercheVille.Rechercher("VALENCE");

            Assert.Equal(lowerCaseResult.Count, upperCaseResult.Count);
            Assert.Contains("Valence", lowerCaseResult);
            Assert.Contains("Valence", upperCaseResult);
        }

        [Fact]
        public void Rechercher_TrouveVillesAvecCorrespondancePartielle()
        {
            var rechercheVille = new RechercheVille();
            var result = rechercheVille.Rechercher("ape");
            Assert.Contains("Budapest", result);
        }

        [Fact]
        public void Rechercher_RetourneToutesLesVilles_PourAsterisque()
        {
            var rechercheVille = new RechercheVille();
            var result = rechercheVille.Rechercher("*");
            Assert.Equal(rechercheVille._villes.Count, result.Count);
        }
    }
}

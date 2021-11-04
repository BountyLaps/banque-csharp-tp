using NUnit.Framework;

namespace banque_simple
{
    [TestFixture]
    public class CompteTest 
    {
        // Référence de l'objet à tester
        private Compte compte;

        [SetUp]
        public void SetUp()
        {
            // Initialisation des données avant chaque test
            compte = new Compte(123456789, 10000, "rdupont@gmail.com");
        }

        [TearDown]
        public void TearDown()
        {
            // Supression du jeu de données après chaque test
        }

        [Test]
        public void TestGetNumero()
        {
            var numero = compte.Numero;
            Assert.AreEqual(123456789, numero);
        }

        [Test]
        public void TestSetNumero()
        {
            compte.Numero = 456789;
            var numero = compte.Numero;
            Assert.AreEqual(456789, numero);
        }

        [Test]
        public void TestGetSolde()
        {
            Assert.AreEqual(10000,  compte.Solde);
        }

        [Test]
        public void TestSetSolde()
        {
            compte.Solde += 500;
            Assert.AreEqual(10500, compte.Solde);
        }

        [Test]
        public void TestGetReferenceClient()
        {
            Assert.AreEqual("rdupont@gmail.com",  compte.ReferenceClient);
        }

        [Test]
        public void TestSetReferenceClient()
        {
            compte.ReferenceClient = "r.dupont@gmail.com";
            Assert.AreEqual("r.dupont@gmail.com", compte.ReferenceClient);
        }
    
        [Test]
        public void TestCompte()
        {
            // Test du constructeur sans paramètres...
            Compte compte = new Compte();
            Assert.NotNull(compte);
        }

        [Test]
        public void TestCompteParams()
        {
            // Test du constructeur avec paramètres...
            Compte compte = new Compte(789, 25, "refClient");
            Assert.NotNull(compte);
            Assert.AreEqual(789, compte.Numero);
            Assert.AreEqual(25, compte.Solde);
            Assert.AreEqual("refClient", compte.ReferenceClient);
        }
    }

}

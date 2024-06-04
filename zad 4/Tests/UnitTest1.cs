using Xunit;
using TDD;
using System;

namespace Tests
{
    public class UnitTest1 : IDisposable
    {

        TDD testCase;

        public UnitTest1() { 
            


        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void TestTDD()
        {
            // Przygotuj dane testowe i warunki

            // Wywo�aj metod�, kt�r� chcesz przetestowa�
            wynik = new TDD();
            wynik.metoda();

            // Sprawd� oczekiwane rezultaty
            Assert.AreEqual(oczekiwanyWynik, wynik);

        }
    }
}
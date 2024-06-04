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

            // Wywo³aj metodê, któr¹ chcesz przetestowaæ
            wynik = new TDD();
            wynik.metoda();

            // SprawdŸ oczekiwane rezultaty
            Assert.AreEqual(oczekiwanyWynik, wynik);

        }
    }
}
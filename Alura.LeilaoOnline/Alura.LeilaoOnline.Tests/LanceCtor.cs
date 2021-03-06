﻿using Xunit;
using Alura.LeilaoOnline.Core;


namespace Alura.LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LanceArgumentExceptionDadoValorNegativo()
        {
            //Arranje
            var valorNegativo = -100;

            //Assert
            Assert.Throws<System.ArgumentException>(
                () => new Lance(null, valorNegativo)
            );
        }
    }
}

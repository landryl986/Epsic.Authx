using Epsic.Authx.Enums;
using System;

namespace Epsic.Authx.Models
{
    public class TestCovid
    {
        public Guid Id { get; set; }
        public DateTime DateTest { get; set; }
        public bool Resultat { get; set; }
        public TypeTestCovid TypeDeTest { get; set; }
    }
}

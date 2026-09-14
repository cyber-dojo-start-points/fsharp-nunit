module HikerTest.``example``

open NUnit.Framework

[<Test>]
let ``life, the universe, and everything.`` () =
   Assert.That(Hiker.theAnswer, Is.EqualTo(42))

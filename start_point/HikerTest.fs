module HikerTest.``example``

open NUnit.Framework

[<Test>]
let ``life, the universe, and everything.`` () =
   Assert.That(Hiker.answer, Is.EqualTo(42))
   
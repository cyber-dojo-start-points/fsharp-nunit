module HikerTest.``example``

open NUnit.Framework

[<Test>]
let ``life, the universe, and everything.`` () =
   Assert.That(Hiker.answer, Is.EqualTo(42))

[<Test>]
let ``the answer is a multiple of seven.`` () =
   Assert.That(Hiker.answer % 7, Is.EqualTo(0))

[<Test>]
let ``the answer reads as forty two.`` () =
   Assert.That(string Hiker.answer, Is.EqualTo("42"))

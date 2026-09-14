module HikerTest.``example``

open NUnit.Framework

[<Test>]
let ``life, the universe, and everything.`` () =
   Assert.That(Hiker.answer (), Is.EqualTo(42))

[<Test>]
let ``the answer is two digits long.`` () =
   Assert.That(Hiker.answerSize (), Is.EqualTo(2))

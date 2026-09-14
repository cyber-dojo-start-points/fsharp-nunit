module HikerTest.``example``

open NUnit.Framework

[<Test>]
let ``the digits of the answer add up to six.`` () =
   Assert.That(Checksum.of' Hiker.answer, Is.EqualTo(6))

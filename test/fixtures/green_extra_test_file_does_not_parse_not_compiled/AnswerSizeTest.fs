module AnswerSizeTest.``example``

open NUnit.Framework

// The bracket that is missing below is never noticed. cyber-dojo.sh names
// Hiker.fs and HikerTest.fs on the compiler command line and this file is
// not one of them, so nothing reads it.
[<Test>]
let ``the answer is two digits long.`` () =
   Assert.That((string Hiker.answer).Length, Is.EqualTo(2)

module AnswerSizeTest.``example``

open NUnit.Framework

// A fourth test, in a second test file. The count in the summary stays at
// three: cyber-dojo.sh names HikerTest.fs and this file is not it, so the
// only tests that run are the ones in the file the compiler was given.
[<Test>]
let ``the answer is three digits long.`` () =
   Assert.That((string Hiker.answer).Length, Is.EqualTo(3))

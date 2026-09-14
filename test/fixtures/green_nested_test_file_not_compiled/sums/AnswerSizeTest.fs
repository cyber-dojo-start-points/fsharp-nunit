module AnswerSizeTest.``example``

open NUnit.Framework

// A test file in a directory of its own. The directory changes nothing: the
// compiler is handed the two files cyber-dojo.sh names and looks nowhere
// else, so a subdirectory is not searched. The test below is one that would
// fail, so a green says it really did not run.
[<Test>]
let ``the answer is three digits long.`` () =
   Assert.That((string Hiker.answer).Length, Is.EqualTo(3))

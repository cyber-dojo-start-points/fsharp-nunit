module AnswerSizeTest.``example``

open NUnit.Framework

// This file is written correctly and holds a test that would fail. It stays
// green all the same: cyber-dojo.sh names Hiker.fs and HikerTest.fs on the
// compiler command line, so this file is never compiled, nothing of it
// reaches dojo.dll, and NUnit gathers tests from dojo.dll alone. The test
// below is one that would fail, so a green says it really did not run
// rather than that it ran and passed.
[<Test>]
let ``the answer is three digits long.`` () =
   Assert.That((string Hiker.answer).Length, Is.EqualTo(3))

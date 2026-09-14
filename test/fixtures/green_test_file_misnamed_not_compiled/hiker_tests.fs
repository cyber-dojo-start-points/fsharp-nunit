module ``hiker tests``.``example``

open NUnit.Framework

// Named hiker_tests.fs rather than HikerTest.fs. The name is exactly what
// decides here: cyber-dojo.sh names the files it compiles one by one, and a
// file called anything else is never handed over. The test below is one that
// would fail, so a green says it really did not run.
[<Test>]
let ``the answer is three digits long.`` () =
   Assert.That((string Hiker.answer).Length, Is.EqualTo(3))

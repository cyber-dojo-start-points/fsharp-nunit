module FizzBuzzTest.``example``

open NUnit.Framework

// Both files are written correctly. cyber-dojo.sh names Hiker.fs and
// HikerTest.fs on the compiler command line, so renaming them leaves the
// compiler asking for files that are no longer there and these two are
// never read.
[<Test>]
let ``fifteen says fizz buzz.`` () =
   Assert.That(FizzBuzz.say 15, Is.EqualTo("FizzBuzz"))

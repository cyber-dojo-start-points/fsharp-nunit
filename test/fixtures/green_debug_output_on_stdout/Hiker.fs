module Hiker

// printfn writes to stdout, and NUnit gathers what a test printed and writes
// it out again ahead of its own summary, which comes on stdout too. So one
// stream carries the debugging and the result both.
let answer =
  printfn "answer was called"
  6 * 7

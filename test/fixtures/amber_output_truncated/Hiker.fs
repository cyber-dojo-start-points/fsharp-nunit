module Hiker

// The learner put a print inside a loop to see what was happening, and it
// prints far more than the 50K the runner keeps of a stream. NUnit gathers
// what a test printed and writes the lot out ahead of its own summary, and
// both land on stdout, so the summary is what falls off the end.
let answer =
  for i in 0 .. 9999 do
    printfn "debug: i is %d" i
  6 * 7

module Checksum

// This file is written correctly and still cannot be used. F# compiles the
// files cyber-dojo.sh names, in the order it names them, and a file can only
// use what a file before it defined. cyber-dojo.sh names Hiker.fs and
// HikerTest.fs, so adding a third file means editing that line too.
let of' (n: int) =
  let mutable left = n
  let mutable sum = 0
  while left > 0 do
    sum <- sum + left % 10
    left <- left / 10
  sum

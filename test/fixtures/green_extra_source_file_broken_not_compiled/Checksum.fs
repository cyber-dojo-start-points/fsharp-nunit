module Checksum

// F# compiles the files cyber-dojo.sh names, in the order it names them, and
// it names Hiker.fs and HikerTest.fs. This file is not one of them, so the
// compiler never opens it and the bracket it is missing costs nothing. A
// language whose build gathers every source file would stop here instead.
let of' (n: int) =
  n % (10

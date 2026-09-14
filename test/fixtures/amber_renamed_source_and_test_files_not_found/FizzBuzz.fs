module FizzBuzz

let say (n: int) =
  if n % 15 = 0 then "FizzBuzz"
  elif n % 3 = 0 then "Fizz"
  elif n % 5 = 0 then "Buzz"
  else string n

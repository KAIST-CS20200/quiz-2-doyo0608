module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let isEven (x : int64) = x % (int64 2) = 0
  let num = int64 n
  let rec iter (a : int64) count =
    if a = 1 then count
    else  if isEven a then iter (a/(int64 2)) (count+1)
          else iter ((int64 3)*a+(int64 1)) (count+1)
  iter num 0
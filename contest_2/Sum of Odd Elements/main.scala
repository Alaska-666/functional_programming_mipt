def f(arr: List[Int]): Int = {
    arr.filter((_).abs % 2 == 1).sum
  }

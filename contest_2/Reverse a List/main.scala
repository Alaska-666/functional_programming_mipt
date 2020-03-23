  def f(arr: List[Int]): List[Int] = {
    @scala.annotation.tailrec
    def iter(xs: List[Int], ys: List[Int]): List[Int] = xs match {
      case Nil => ys
      case x :: rest => iter(rest, x :: ys)
    }
    iter(arr, List.empty)
  }

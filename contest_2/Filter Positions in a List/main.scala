  def f(arr: List[Int]): List[Int] = {
    @scala.annotation.tailrec
    def iter(counter: Int, xs: List[Int], ys: List[Int]): List[Int] = xs match {
      case Nil => ys
      case x :: rest => if (counter % 2 == 0) iter(counter + 1, rest, x :: ys) else iter(counter + 1, rest, ys)
    }
    iter(1, arr, List.empty).reverse
  }

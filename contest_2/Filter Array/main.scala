  def f(delim:Int,arr:List[Int]):List[Int] = {
    @scala.annotation.tailrec
    def iter(xs:List[Int], ys: List[Int]): List[Int] = xs match {
      case Nil => ys
      case x :: rest => if (x < delim) iter(rest, x :: ys) else iter(rest, ys)
    }
    iter(arr, List.empty).reverse
  }

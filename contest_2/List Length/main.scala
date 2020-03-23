  def f(arr: List[Int]): Int = {
    @scala.annotation.tailrec
    def iter(length: Int, xs: List[Int]): Int = xs match {
      case Nil => length
      case xs :: rest => iter(length + 1, rest)
    }
    iter(0, arr)
  }

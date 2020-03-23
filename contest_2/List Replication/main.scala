def f(num: Int, arr: List[Int]): List[Int] = {
    arr.map(el => List.fill(num)(el)).reduce((a, b) => a ::: b)
}

import scala.io.StdIn.readLine
  
def f(coefficients:List[Int],powers:List[Int],x:Double):Double = coefficients.zip(powers).map { case (coef, power) => coef * Math.pow(x, power) }.sum

def area(coefficients:List[Int],powers:List[Int],x:Double):Double = Math.PI * Math.pow(f(coefficients, powers, x), 2)

def summation(func:(List[Int],List[Int],Double)=>Double, upperLimit:Int,lowerLimit:Int,coefficients:List[Int],powers:List[Int]):Double =
  {
    val subinterval = 0.001
    BigDecimal(lowerLimit).to(upperLimit).by(subinterval).map(x => subinterval * func(coefficients, powers, x.toDouble)).sum
  }

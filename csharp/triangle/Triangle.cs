using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

public static class Triangle
{
   public static bool IsScalene(double a, double b, double c) => IsTriangle(a,b,c) && a != b && b != c && c != a;
   public static bool IsIsosceles(double a, double b, double c) => IsTriangle(a, b, c) && (a == b || b == c || c == a);
   public static bool IsEquilateral(double a, double b, double c) => IsTriangle(a,b,c) && a == b && b == c;
   private static bool IsTriangle(double a, double b, double c) => (a > 0 && b > 0 && c > 0) && Math.Abs(a - b) < c && c < (a + b);

}

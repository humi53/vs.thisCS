using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace thisCS.Chapter14.ExpressionTree
{
    class ExpressionTreeViaLambda
    {
        //static void Main(string[] args)
        //{
        //    Expression<Func<int, int, int>> expression =
        //        (a, b) => 1 * 2 + (a - b);
        //    Func<int, int, int> func = expression.Compile();

        //    //x =7, y = 8
        //    Console.WriteLine($"1*2+({7}-{8}) = {func(7, 8)}");
        //}
    }
}
/* 식 트리
 * 람다식을 이용하면 더 간편하게 식 트리를 만들수 있다.
 * 하지만 이렇게 쓰면 "동적으로" 식트리를 만들기는 어려워진다
 * Expression 형식은 불변이기 때문에 한번 
 *          인스턴스가 만들어지고 난 후에는 변경할 수가 없기 때문이다.
 * 
 * 식트리는 코드를 "데이터"로써 보관할 수 있게된다.
 * 그래서 파일로 저장할수도 있고
 *          네트워크를 통해 다른 프로세스에 전달 할수도 있다.
 *          심지어 코드를 담고 있는 식 트리 데이터를 데이터베이스 서버에 보내서 실행 할수도 있다.
 *          
 * ******** 데이터베이스 처리를 위한 식트리는 LINQ에서 사용된다.
 *          이번 식트리는 LINQ 단원을 위한 포석이었고, 
 *          LINQ를 이해하려면 람다식과 식트리를 이해하고 있어야 한다.
 *          */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace thisCS.Chapter14.ExpressionTree
{
    class UsingExpressionTree
    {
        //static void Main(string[] args)
        //{
        //    //1*2+(x-y)
        //    Expression cons1 = Expression.Constant(1);
        //    Expression cons2 = Expression.Constant(2);

        //    Expression leftExp = Expression.Multiply(cons1, cons2); //1*2

        //    Expression param1 = Expression.Parameter(typeof(int)); //x를 위한 변수
        //    Expression param2 = Expression.Parameter(typeof(int)); //y를 위한 변수

        //    Expression rightExp = Expression.Subtract(param1, param2);  // x- y

        //    Expression exp = Expression.Add(leftExp, rightExp);

        //    Expression<Func<int, int, int>> expression =        // <= :Lable1 설명참조주석.
        //        Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
        //            exp, new ParameterExpression[]
        //            {
        //                (ParameterExpression)param1,
        //                (ParameterExpression)param2
        //            });

        //    Func<int, int, int> func = expression.Compile();

        //    // x = 7, y = 8
        //    Console.WriteLine($"1*2+({7}-{8}) = {func(7,8)}");

        //}
    }
}
/* 식 트리
 * 식을 트리로 표현한 자료구조로 이진트리형식이다.
 * .NET 프레임워크의 System.Linq.Expressions 네임스페이스 안에 준비되어 있다.
 * Expression 클래스와 파생클래스들.
 * Expression은 abstract로 생성불가 하지만 정적 팩토리메소드를 제공하여 파생인스턴스를 생성할수 있다.
 * Expression.Constant() = ConstExpression
 * Expression.Parameter() = ParameterExpression
 * Expression.Add() = BinaryExpression
 * 완성된 exp는 그저 식을 트리로 표현한것에 불과
 * 데이터 상태로 머물고 있을뿐이기 때문에 람다식으로 컴파일 되어야 한다.
 * 컴파일은 Expression<TDelegate> 클래스를 이용하여 컴파일해 실행가능 상태로 만들수 있다.
 * Expression<TDelegate> = LambdaExpression 클래스의 파생클래스이다.
 * :Lable1 부분이 Expression<TDelegate>를 이용하고 있는부분.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter03
{
    class FloatToIntegral
    {
        //생략...
    }
}
/* 부동 소수점 형식과 정수 형식 사이의 변환
 * 크기가 다르면 데이터가 잘릴수 있따 오버플로
 * 부호가 다르면 데이터가 밑의 수로 변형 언더플로
 * 부동소수점과 정수사이의 변환은 2진수 -> 10진수 -> 16진수 로 변환하기 때문에 
 *      2진수로 표현하기 힘든 숫자라면 문제가 생길수 있다.
 */

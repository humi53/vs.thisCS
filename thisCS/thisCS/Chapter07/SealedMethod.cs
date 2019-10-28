using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07b
{
    class Base
    {
        public virtual void SealMe()
        {

        }
    }
    class Derived : Base
    {
        public sealed override void SealMe()
        {
            base.SealMe();
        }
    }

    class WantToOverrid : Derived
    {
        //public override void SealMe()
        //{

        //}
    }
    class SealedMethod
    {
        //static void Main(string[] args) { }
    }
}
/* 오버라이딩 봉인하기
 * sealed 키워드
 */

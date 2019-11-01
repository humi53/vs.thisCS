using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter13
{
    delegate void Notify(string message);
    class Notifier
    {
        public Notify EventOccured;
    }
    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }
        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappened : {message}");
        }
    }
    class DelegateChains
    {
        //static void Main(string[] args)
        //{
        //    Notifier notifier = new Notifier();
        //    EventListener listener1 = new EventListener("Listener1");
        //    EventListener listener2 = new EventListener("Listener2");
        //    EventListener listener3 = new EventListener("Listener3");

        //    notifier.EventOccured += listener1.SomethingHappend;
        //    notifier.EventOccured += listener2.SomethingHappend;
        //    notifier.EventOccured += listener3.SomethingHappend;
        //    notifier.EventOccured("You've got mail.");

        //    Console.WriteLine();

        //    notifier.EventOccured -= listener2.SomethingHappend;
        //    notifier.EventOccured("Download complete.");

        //    Console.WriteLine();

        //    Notify notify1 = new Notify(listener1.SomethingHappend);
        //    Notify notify2 = new Notify(listener2.SomethingHappend);

        //    notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
        //    notifier.EventOccured("Fire!!");

        //    Console.WriteLine();

        //    notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
        //    notifier.EventOccured("RPG!");
        //}
    }
}
/* 대리자 체인
 * 
 * 실행할 대리자와 같은타입의 메소드를 바로 넘긴다.
 * 대리자변수 += 객체.대리자와같은타임의 메소드        체인할당.
 * 대리자변수 -= 객체.대리자와같은타임의 메소드        체인끊기.
 * 대리자변수() 메소드 타입형식에 따른 실행.         대리자체인전부실행.
 * 
 * 실행할 메소드로 대리자를 생성해서 실행할 대리자에 Comebine으로 넘긴다. Remove로 지운다.
 * 대리자변수 = (대리자타입)Delegate.Combine(new 대리자(메소드), 생성된대리자타입의변수)   : 맴버변수로 대리자를 넘긴다.
 * Delegate.Remove()
 * 
 * **체인을 끊을땐 넘겼던 대리자or 메소드를 가지고있는 객체가 있어야 끊을수 있다.
 * 즉석으로 new로 생성해서 넘기면 지울수 있을까? 현재 지식으론 없다고 생각된다. 추후 수정가능.
 */

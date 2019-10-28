using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();
        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }
        public string GetConfig(string item)
        {
            foreach(ItemValue iv in listConfig)
            {
                if(iv.GetItem() == item)
                {
                    return iv.GetValue();
                }
            }
            return "";
        }
        private class ItemValue
        {
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if(found == false)
                {
                    config.listConfig.Add(this);
                }
            }
            public string GetItem()
            {
                return item;
            }
            public string GetValue()
            {
                return value;
            }            
        }
    }
    class NestedClass
    {
        //static void Main(string[] args)
        //{
        //    Configuration config = new Configuration();
        //    config.SetConfig("Version", "V 5.0");
        //    config.SetConfig("Size", "655,324 KB");

        //    Console.WriteLine(config.GetConfig("Version"));
        //    Console.WriteLine(config.GetConfig("Size"));

        //    config.SetConfig("Version", "V 5.0.1");
        //    Console.WriteLine(config.GetConfig("Version"));
        //}
    }
}
/* 중첩 클래스
 * 클래스 외부에 공개하고 싶지 않은 형식을 만들고자 할때
 * 현재의 클래스의 일부분처럼 표현할 수 있는 클래스를 만들고자 할때
 */
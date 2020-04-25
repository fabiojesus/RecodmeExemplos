using System;
using System.Collections.Generic;
using System.Text;

namespace DemonstracaoV1
{
    public class Lists
    {
        public void ImplementarLista()
        {
            var list = new List<int>();
            list.Add(23);
            list.Add(41);
            list.Add(93);
            var second = list[1];
            list.Remove(41); //remove 41
            list.RemoveAt(1); //remove o segundo elemento
            var lst = new List<object>();
            lst.Add(1);
            lst.Add("aosd");
            lst.Add('c');
        }
    }
}

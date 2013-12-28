using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySinglList
{
    class SinglList
    {
        private int itemvalue;
        private SinglList nextitem;

        public int ItemValue
        {
            get { return itemvalue; }
            set { itemvalue = value; }
        }

        public SinglList NextItem
        {
            get { return nextitem; }
            set { nextitem = value; }
        }

        public SinglList(int NewValue)
        {
            ItemValue = NewValue;
            NextItem = null;
        }

        public SinglList(int NewValue, SinglList NewNextItem)
        {
            ItemValue = NewValue;
            NextItem = NewNextItem;
        }

        public void ShowList()
        {
            if (NextItem == null)
            {
                Console.WriteLine(ItemValue);
            }
            else
            {
                Console.Write(ItemValue+" ");
                NextItem.ShowList();
            }
        }

        public int GetValue(int position)
        {
            try
            {
                if (position == 1)
                {
                    return ItemValue;
                }
                else
                {
                    return NextItem.GetValue(position - 1);
                }
            }
            catch
            {
                Console.WriteLine("Неверное значение позиции. Возвращен 0");
                return 0;
            }
        }

        public void PastIn(int NewValue, int position)
        {
            try
            {
                if (position == 1)
                {
                    SinglList ThisItem = new SinglList(ItemValue, NextItem);
                    this.ItemValue = NewValue;
                    this.NextItem = ThisItem;
                }
                else
                {
                    if (NextItem != null)
                    {
                        NextItem.PastIn(NewValue, position - 1);
                    }
                    else
                    {
                        NextItem = new SinglList(NewValue);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Неверное значение позиции.");
            }
        }

        public void Delete(int position)
        {
            try
            {
                if (position == 1)
                {
                    this.ItemValue = NextItem.ItemValue;
                    this.NextItem = NextItem.NextItem;
                }
                else
                {
                    if ((position - 1 == 1) & (NextItem.NextItem == null))
                    {
                        NextItem = null;
                    }
                    else
                    {
                        NextItem.Delete(position - 1);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Неверное значение позиции.");
            }
        }
    }
}

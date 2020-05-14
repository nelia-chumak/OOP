using System;

namespace Queue_library
{
    public class Queue<T>
    {
        public delegate void QueueHandler(string message);
        public event QueueHandler SuccessfulAction;
        public event QueueHandler EndQueue;

        public class Element<T>
        {
            internal T record;
            internal Element<T> Next;
            public Element(T info) { record = info; }
        }
        Element<T> first;
        Element<T> last;
        int count;
        public Queue() { }
        public Queue(T[] info)
        {
            for (int i = 0; i < info.Length; i++)
                Add(info[i]);
        }
        public void Add(T info)
        {
            Element<T> el = new Element<T>(info);
            Element<T> temp = last;
            last = el;
            if (count == 0) first = last;
            else temp.Next = last;
            count++;
            SuccessfulAction?.Invoke($"Добавлен элемент: {info}");
        }
        public T Del()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T del_el = first.record;
            first = first.Next;
            count--;
            SuccessfulAction?.Invoke($"Удален элемент: {del_el}");
            if (count == 0)
                EndQueue?.Invoke($"Очередь пуста");
            return del_el;
        }
    }

}

using System.Linq;
namespace Eventtestliping_wang
{
    public class genericClass
    {
        public class MYCollection<T> where T : struct
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                return items[index];
            }

            public List<T> GetDes()
            {
                return items.OrderByDescending(x => x).ToList();
            }
        }
    }
}

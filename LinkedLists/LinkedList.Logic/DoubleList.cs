namespace LinkedList.Logic
{
    public class DoubleList<T>
    {
        private DoubleNode<T>? _first;

        private DoubleNode<T>? _last;

        public DoubleList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;
            }
            return output;
        }

        public void Add(T item)
        {
            var node = new DoubleNode<T>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }

        /*public Response GetBrand(string brand)
        {
            var array = new T[Count];
            int i = 0;
            var pointer = _first;
            while (pointer != null)
            {
                if (brand!.Equals(pointer.Data))
                {
                    array[i] = pointer.Data!;
                    i++;
                    pointer = pointer.Right;
                }
                pointer = pointer!.Right;
            }
            return new Response
            {
                IsScucced = false,
                Message = $"The brand: {brand} not found."
            };
        }*/

        public T[] GetBrand(string brand)
        {
            var array = new T[Count];
            int i = 0;
            var pointer = _first;
            while (pointer != null)
            {
                if (brand.Equals(pointer.Data!))
                {
                    array[i] = pointer.Data!;
                    i++;
                    //pointer = pointer.Right;
                }
                pointer = pointer.Right;
            }
            return array;
        }
    }
}

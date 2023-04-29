namespace LinkedList.Logic
{
    public class Car
    {
        public string? brand { get; set; }
        public string? model { get; set; }
        public string? year { get; set; }
        public string? color { get; set; }
        public decimal price { get; set; }

        public override string ToString()
        {
            return $"{brand} - {model} - {year} - {color} - {price:C2}";
        }
    }
}
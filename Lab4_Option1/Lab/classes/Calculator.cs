namespace Lab.classes
{
    public class Calculator
    {
        public int Value { get; set; }
        public string Operation { get; set; }

        public Calculator(int value)
        {
            Value = value;
        }

        public Calculator(int value, string operation)
        {
            Value = value;
            Operation = operation;
        }

        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            return new Calculator((c1.Value + c2.Value), "Sum");
        }

        public static Calculator operator -(Calculator c1, Calculator c2)
        {
            return new Calculator((c1.Value - c2.Value), "Sub");
        }

        public static bool operator >(Calculator c1, Calculator c2)
        {
            return c1.Value > c2.Value;
        }

        public static bool operator <(Calculator c1, Calculator c2)
        {
            return c1.Value < c2.Value;
        }

        public static Calculator operator ++(Calculator c) 
        {
            return new Calculator(c.Value += 1, "Increment");
        }

        public static Calculator operator --(Calculator c)
        {
            return new Calculator(c.Value -= 1, "Decrement");
        }

        public static bool operator true(Calculator c)
        {
            return c.Value == 0;
        }

        public static bool operator false(Calculator c)
        {
            return c.Value != 0;
        }

        public override string ToString()
        {
            return $"{this.Operation}: {this.Value}";
        }
    }
}

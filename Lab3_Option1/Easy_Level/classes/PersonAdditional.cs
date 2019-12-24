namespace Easy_Level.classes
{
    public partial class Person
    {
        public string Phone { get; set; }

        public void SetPhone(string number)
        {
            this.Phone = number;
        } 

        public string GetPhone()
        {
            return this.Phone;
        }
    }
}

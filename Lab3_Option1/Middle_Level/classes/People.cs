namespace Middle_Level.classes
{
    public class People
    {
        Person[] data;

        public People()
        {
            data = new Person[5];
        }

        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}

namespace High_Level.classes
{
    public class OS
    {
        private static OS entity;

        public string Name { get; private set; }

        public OS(string name)
        {
            this.Name = name;
        }

        public static OS GetOS(string name)
        {
            if (entity == null)
            {
                entity = new OS(name);
            }

            return entity;
        }
    }
}

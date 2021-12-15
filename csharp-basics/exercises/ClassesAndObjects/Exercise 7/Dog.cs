namespace Exercise_7
{
    internal class Dog
    {
        private string _name { get; set; }
        private string _sex { get; set; }
        private string _mother { get; set; }
        private string _father { get; set; }

        public Dog(string name, string sex, string mother, string father)
        {
            _father = father;
            _mother = mother;
            _name = name;
            _sex = sex;
        }

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
            _father = "Unknown";
        }

        public string FathersName()
        {
            return _father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return Equals(this._mother, otherDog._mother);
        }
    }
}

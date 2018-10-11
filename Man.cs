namespace EPAM_TK_3
{
    class Man
    {
        protected string _name;
        protected int _age;
        protected string _gender;
        protected int _weight;

        public  Man(string name, int age, string gender, int weight)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _weight = weight;
        }

        public Man():this("John", 20, "male", 70)
        {

        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public string GetName()
        {
            return _name;
        }

        public int SetAge()
        {
            return _age;
        }

        public int GetWeight()
        {
           return _weight; 
        }

        public string GetGender()
        {
            return _gender;
        }
    }
}

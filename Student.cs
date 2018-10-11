namespace EPAM_TK_3
{
    class Student:Man
    {
        protected int _aducationYear;

        public Student() : base()
        {

        }

        public Student(int year) : base()
        {
            _aducationYear = year;
        }

        public void SetAducationYear(int year)
        {
            _aducationYear = year;
        }

        public int GetAducationYear()
        {
           return _aducationYear;
        }

        public void IncAducationYear(int num)
        {
            _aducationYear += num;
        }
    }
}

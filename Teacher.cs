using System.Collections.Generic;

namespace EPAM_TK_3
{
    class Teacher:Student
    {
        private List<List<Student>> _groups;
        private int _groupCount;

        public Teacher() : base()
        {

        }

        public Teacher(List<List<Student>> group) : base()
        {
            _groups = group;
        }

        public void AddStudent(int groupNum, Student s)
        {
            _groups[groupNum].Add(s);
        }

        public void AddGroup(int groupNum, List<Student> gr)
        {
            _groups.Add(gr);
        }

        public List<List<Student>> GetGroups()
        {
            return _groups;
        }
    }
}

namespace Lab___3
{
    class Instructor
    {
        #region Instructor Variables
        private string teacherFirstName;
        private string teacherLastName;
        private string courseName;
        private int studentGrade = 0;

        #endregion

        #region Class Methods

        public void SetStudentGrade(string student, int studentGrade)
        {

        }
        public void 
        public string Print()
        {
            string fullNameAndCourse;
            fullNameAndCourse = "";
            fullNameAndCourse += this.teacherFirstName;
            fullNameAndCourse += " ";
            fullNameAndCourse += this.teacherLastName;
            fullNameAndCourse += " ";
            fullNameAndCourse += this.courseName;
            return fullNameAndCourse;
        }

        #endregion
    }
}

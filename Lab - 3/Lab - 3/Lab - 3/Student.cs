namespace Lab___3
{
    class Student
    {
        #region Student Variables

        private string studentName;
        private int studentGrade = 0;

        #endregion

        private Instructor

        public string Print()
        {
            string studentDetails;
            studentDetails = "";
            studentDetails += this.studentName;
            studentDetails += " ";
            studentDetails += "Grade: ";
            studentDetails += this.studentGrade;
            studentDetails += " ";
            studentDetails += "Teacher: ";
            studentDetails += this.Instructor.teacher;
            return studentDetails;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace chapter7Final
{
    class Instructor
    {
        public string FirstName {get; set;}

        public string LastName {get; set;}
        private string InstructorSlackHandle { get; set; }

        public Cohort InstructorCohort { get; set; }

        public string Specialty { get; set; }


    public void AssignExercise(Student student, Exercise exercise )
        {
            student.Assignments.Add(exercise);
        }
    }
}

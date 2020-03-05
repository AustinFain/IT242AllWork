
using System;

using System.Collections.Generic;

namespace chapter7Final

{

    class Program
    {

        static void Main(string[] args)
        {

            Exercise blender = new Exercise()
            {
                exerciseName = "Cycles",
                languageOfExercise = "Python"

            };
              
            Exercise cinema4d = new Exercise()
            {
                exerciseName = "Redshift",
                languageOfExercise = "C++"

            };
             
            Exercise maya = new Exercise()
            {
                exerciseName = "RealMan",
                languageOfExercise = "C#"

            };   
            
            Exercise poopyscoopy = new Exercise()
            {
                exerciseName = "RealMan",
                languageOfExercise = "C#"

            };

            Cohort co1 = new Cohort("Cohort 1");
            Cohort co2 = new Cohort("Cohort 2");
            Cohort co3 = new Cohort("Cohort 3");

            Student a1 = new Student("Austin", "Clevenger")
            {
                StudentCohort = co1
            };
            Student a2 = new Student("George", "Newman")
            {
                StudentCohort = co1
            };
            Student a3 = new Student("Russel", "Miller")
            {
                StudentCohort = co2
            };
            Student a4 = new Student("Matthew", "Crutchfield")
            {
                StudentCohort = co3
            };

            Instructor b1 = new Instructor()
            {
                FirstName = "mister",
                LastName = "sir",
                InstructorCohort = co1

            };


            Instructor b2 = new Instructor()
            {
                FirstName = "Dude",
                LastName = "Bro",
                InstructorCohort = co2
            };
           
            Instructor b3 = new Instructor()
            {
                FirstName = "Tommy",
                LastName = "Boy",
                InstructorCohort = co3
            };

            b1.AssignExercise(a1, blender);
            b1.AssignExercise(a1, poopyscoopy);
            b1.AssignExercise(a2, maya);
            b1.AssignExercise(a2, cinema4d);
            b2.AssignExercise(a3, cinema4d);
            b2.AssignExercise(a3, cinema4d);
            b3.AssignExercise(a4, cinema4d);
            b3.AssignExercise(a4, poopyscoopy);


            /*Create 4, or more, exercises.
Create 3, or more, cohorts.
Create 4, or more, students and assign them to one of the cohorts.
Create 3, or more, instructors and assign them to one of the cohorts.
Have each instructor assign 2 exercises to each of the students.*/
        }

    }


}


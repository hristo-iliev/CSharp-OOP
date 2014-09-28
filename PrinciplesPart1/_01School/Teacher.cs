namespace _01School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People, IComantable
    {
        private List<Discipline> setOfDisciplines;

        public List<Discipline> SetOfDisciplines
        {
            get 
            {
                return this.setOfDisciplines;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("The List of disciplines is empty");
                }

                this.setOfDisciplines = value;
            }
        }
    }
}

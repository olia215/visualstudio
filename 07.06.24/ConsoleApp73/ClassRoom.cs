using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    internal class ClassRoom
    {// Массив учеников
        private Pupil[] pupils;

        // Конструктор, принимающий от 2 до 4 учеников
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 2 || pupils.Length > 4)
            {
                throw new ArgumentException("A classroom must have 2 to 4 pupils.");
            }

            this.pupils = pupils;
        }

        // Метод для вывода информации о навыках всех учеников
        public void ShowPupilsActivities()
        {
            foreach (var pupil in pupils)
            {
                Console.WriteLine($"Ученик {pupil.Surname}:");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}

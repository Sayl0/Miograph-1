using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miograph
{
    using System;

    public class PatientCard
    {
        // Declare the fields for the class
        private long id;
        private long p_id;
        private string surname;
        private string name;
        private string patronymic;
        private string gender;
        private DateTime birth;
        private int height;
        private int weight;
        private DateTime registration_DT;

        // Define the properties for the fields
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public long P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) // Check the height is positive
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height must be positive.");
                }
            }
        }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0) // Check the weight is positive
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Weight must be positive.");
                }
            }
        }

        public DateTime Registration_DT
        {
            get { return registration_DT; }
            set { registration_DT = value; }
        }

        // Define a constructor for the class
        public PatientCard(long id, long p_id, string surname, string name, string patronymic, string gender, DateTime birth, int height, int weight, DateTime registration_DT)
        {
            this.Id = id;
            this.P_id = p_id;
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Gender = gender;
            this.Birth = birth;
            this.Height = height;
            this.Weight = weight;
            this.Registration_DT = registration_DT;
        }
    }

}

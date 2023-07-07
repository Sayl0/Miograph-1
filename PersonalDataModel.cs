using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miograph
{
    public class PersonalDataModel
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int LeftHipGirth { get; set; }
        public int LeftMuscleStrength { get; set; }
        public int LeftShinStrength { get; set; }
        public int LeftKneeMobility { get; set; }
        public int LeftFootMobility { get; set; }
        public int RightHipGirth { get; set; }
        public int RightMuscleStrength { get; set; }
        public int RightShinStrength { get; set; }
        public int RightKneeMobility { get; set; }
        public int RightFootMobility { get; set; }

        public PersonalDataModel(int id, int pId, int leftHipGirth, int leftMuscleStrength, int leftShinStrength, int leftKneeMobility, int leftFootMobility, int rightHipGirth, int rightMuscleStrength, int rightShinStrength, int rightKneeMobility, int rightFootMobility)
        {
            Id = id;
            PId = pId;
            LeftHipGirth = leftHipGirth;
            LeftMuscleStrength = leftMuscleStrength;
            LeftShinStrength = leftShinStrength;
            LeftKneeMobility = leftKneeMobility;
            LeftFootMobility = leftFootMobility;
            RightHipGirth = rightHipGirth;
            RightMuscleStrength = rightMuscleStrength;
            RightShinStrength = rightShinStrength;
            RightKneeMobility = rightKneeMobility;
            RightFootMobility = rightFootMobility;
        }
    }
}

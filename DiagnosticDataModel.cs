using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miograph
{
    public class DiagnosticDataModel
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int DiagNumber { get; set; }
        public DateTime DiagnosisDateTime { get; set; }
        public int MaxFlexionAngleKnee { get; set; }
        public int MaxFlexionAnglePelvic { get; set; }
        public int MaxFlexionAngleFoot { get; set; }
        public int MaxStrengthAnkleFlexors { get; set; }
        public int MaxStrengthAnkleExtensors { get; set; }
        public int MaxStrengthHipFlexors { get; set; }
        public int MaxStrengthHipExtensors { get; set; }

        public DiagnosticDataModel(int id, int pId, int diagNumber, DateTime diagnosisDateTime, int maxFlexionAngleKnee, int maxFlexionAnglePelvic, int maxFlexionAngleFoot, int maxStrengthAnkleFlexors, int maxStrengthAnkleExtensors, int maxStrengthHipFlexors, int maxStrengthHipExtensors)
        {
            Id = id;
            PId = pId;
            DiagNumber = diagNumber;
            DiagnosisDateTime = diagnosisDateTime;
            MaxFlexionAngleKnee = maxFlexionAngleKnee;
            MaxFlexionAnglePelvic = maxFlexionAnglePelvic;
            MaxFlexionAngleFoot = maxFlexionAngleFoot;
            MaxStrengthAnkleFlexors = maxStrengthAnkleFlexors;
            MaxStrengthAnkleExtensors = maxStrengthAnkleExtensors;
            MaxStrengthHipFlexors = maxStrengthHipFlexors;
            MaxStrengthHipExtensors = maxStrengthHipExtensors;
        }
    }
}

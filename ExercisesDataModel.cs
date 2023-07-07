using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miograph
{
    public class ExercisesData
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int ExerciseId { get; set; }
        public int ExerciseNumber { get; set; }
        public DateTime ExerciseStartDt { get; set; }
        public DateTime ExerciseEndDt { get; set; }
        public int Duration { get; set; }
        public int Steps { get; set; }
        public int Velocity { get; set; }
        public int MaxFlexAngle { get; set; }

        public ExercisesData(int id, int pId, int exerciseId, int exerciseNumber, DateTime exerciseStartDt, DateTime exerciseEndDt, int duration, int steps, int velocity, int maxFlexAngle)
        {
            Id = id;
            PId = pId;
            ExerciseId = exerciseId;
            ExerciseNumber = exerciseNumber;
            ExerciseStartDt = exerciseStartDt;
            ExerciseEndDt = exerciseEndDt;
            Duration = duration;
            Steps = steps;
            Velocity = velocity;
            MaxFlexAngle = maxFlexAngle;
        }
    }
}

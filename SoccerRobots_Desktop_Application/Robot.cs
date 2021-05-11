namespace SoccerRobots_Desktop_Application
{
    public enum RobotState { ChargeOff,Injured, Sleeping, Running, Other }
    public class Robot
    {
        public int Code { get; set; }  //ctrl + E+V
        public double XPosition { get; set; }
        public double YPosition { get; set; }
        public bool HaveBall { get; set; }
        public RobotState State;

        //tow robots are equal if its have the same code
        //to compare objects we have to redefine (give an other definition) to Equals

        public override bool Equals(object obj)//Equals compare tow objects by reference(default case)
        {
            return obj is Robot robot &&
                   Code == robot.Code;
        }

        public override int GetHashCode()
        {
            return -434485196 + Code.GetHashCode();
        }

    }
}
namespace ClassLibrary1
{
    public class Plane : Air
    {
        //field
        int _numberOfJets;

        public Plane(string color, int numberOfJets) : base(color)
        {
            _numberOfJets = numberOfJets;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets: {_numberOfJets}";
        }
    }
}
namespace Calculator
{
    public class ZetaCalculator
    {
        private int _existingProjects = 0;

        public void Init(int existingProjects) => _existingProjects = existingProjects;
        public void Buzo(int myprojects)
        {
            _existingProjects *= myprojects;
        }
    }
}

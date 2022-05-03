namespace Calculator
{
    public class ZetaCalculator
    {
        private int _existingProjects = 0;

        public void Init(int existingProjects) => _existingProjects = existingProjects;

        public void Addprojekt(int newProject)
        {
            _existingProjects += newProject;
            /// UDA Änderung!
        }

        public void Sub(int otherProjects)
        {
            _existingProjects -= otherProjects;
        }
        public void Buzo(int myprojects)
        {
            _existingProjects *= myprojects;
        }
        public void Herbert()
        {
            /// Test Neu
            //Version 2.0
        }
    }
}

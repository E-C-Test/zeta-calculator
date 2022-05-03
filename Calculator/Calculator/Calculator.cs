namespace Calculator
{
    public class ZetaCalculator
    {
        private int _existingProjects = 0;

        public void Init(int existingProjects) => _existingProjects = existingProjects;

        public void Addprojekt(int newProject)
        {
            _existingProjects += newProject;
        }
    }
}

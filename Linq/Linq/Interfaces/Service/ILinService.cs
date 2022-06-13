namespace Linq.Interfaces.Service
{
    internal interface ILinService
    {
        public void FirstOrDefault(IReadOnlyCollection<string> con);
        public void SelectWhere(IReadOnlyCollection<string> con);
        public void Distinct(IReadOnlyCollection<string> con);
        public void Count(IReadOnlyCollection<string> con);
        public void Reverse(IReadOnlyCollection<string> con);
    }
}

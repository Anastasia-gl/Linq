using Linq.Info.Linqs;
using Linq.Services.Linqs;

namespace Linq
{
    internal class Run
    {
        private LinService service;
        private Lin contacts;

        public Run()
        {
            service = new LinService();
            contacts = new Lin();
        }

        public void Start()
        {
            service.FirstOrDefault(contacts.Contacts);
            service.SelectWhere(contacts.Contacts);
            service.Distinct(contacts.Contacts);
            service.Count(contacts.Contacts);
            service.Reverse(contacts.Contacts);
        }
    }
}

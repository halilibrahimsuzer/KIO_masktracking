using System;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class PharmacyManager : ISupplierService
	{
        private IApplicantService _applicantService;

        public PharmacyManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
                Console.WriteLine(person.FirstName + " için eczaneden " +
                    "maske verildi.");
        }
    }
}


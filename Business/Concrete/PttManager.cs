using System;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class PttManager : ISupplierService
	{
		private IApplicantService _applicantService;

		public PttManager(IApplicantService applicantService)
		{
			_applicantService = applicantService;

        }
		public void GiveMask(Person person)
		{
			if (_applicantService.CheckPerson(person))
				Console.WriteLine(person.FirstName + " için PTT'den maske " +
					"verildi.");
			else
                Console.WriteLine(person.FirstName + " için T.C. Kimlik numarası " +
					"doğrulaması başarısız! Lütfen Bilgilerinizi kontrol edip " +
					"tekrar deneyiniz.");
        }
	}
}


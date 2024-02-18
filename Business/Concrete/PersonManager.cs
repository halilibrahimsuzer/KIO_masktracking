using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Business.Abstract;
using Business.Services;
using Entities.Concrete;

namespace Business.Concrete
{

	public class PersonManager : IApplicantService
	{
		public void ApplyForMask(Person person)
		{

		}

		public List<Person> GetList()
		{
			return new List<Person>();
		}

		public bool CheckPerson(Person person)
		{
            //Mernis check will be made
            return TCIdentityNumberVerify.CheckTCIdentityNumber(person.NationalIdentity
				, person.FirstName, person.LastName, person.DateOfBirthYear);
		}

        
    }
}


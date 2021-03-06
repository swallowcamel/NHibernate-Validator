using System;
using NHibernate.Validator.Constraints;

namespace NHibernate.Validator.Tests.Base
{
	public class Building
	{
		[Length(Min = 1, 
			Message = "{notpresent.Key} and #{key.notPresent} and {key.notPresent2} {min}")] 
		private String address;

		private long id;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public long Id
		{
			get { return id; }
			set { id = value; }
		}
	}
}
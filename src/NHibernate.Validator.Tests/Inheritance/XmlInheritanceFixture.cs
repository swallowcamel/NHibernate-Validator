using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Tests.Inheritance
{
	public class XmlInheritanceFixture : InheritanceFixture
	{
		public override IClassValidator GetClassValidator(System.Type type)
		{
			return UtilValidatorFactory.GetValidatorForUseExternalTest(type);
		}
	}
}

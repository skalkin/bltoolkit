﻿using System;
using System.Linq;

using NUnit.Framework;

namespace Data.Linq
{
	[TestFixture]
	public class VisualBasicTest : TestBase
	{
		[Test]
		public void CompareString()
		{
			ForEachProvider(db => AreEqual(
				from p in db.Person where p.FirstName == "John" select p,
				CompilerServices.CompareString(db)));
		}

		[Test]
		public void ParameterName()
		{
			ForEachProvider(db => AreEqual(
				from p in Parent where p.ParentID == 1 select p,
				VisualBasicCommon.ParamenterName(db)));
		}
	}
}

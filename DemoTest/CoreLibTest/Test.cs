using NUnit.Framework;
using System;
using CoreLib;
namespace CoreLibTest
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			Assert.AreEqual(1, 0);
		}
		[Test()]
		public void TestCase1()
		{
			Assert.AreEqual(1, 1);
		}
		[Test()]
		public void TestPessoa()
		{
			Pessoa p = new Pessoa();
			p.Nome = "test";
			Assert.AreEqual(p.Nome, "Test");
		}

		[Test()]
		public void TestPessoaIdade()
		{
			Pessoa p = new Pessoa();

			p.Idade = 10;
			Assert.AreEqual(p.Idade, 10);
		}



	}
}

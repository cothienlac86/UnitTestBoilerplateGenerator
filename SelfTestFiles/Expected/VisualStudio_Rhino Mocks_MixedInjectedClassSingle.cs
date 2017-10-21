using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using UnitBoilerplate.Sandbox.Classes;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestClass]
	public class MixedInjectedClassSingleTests
	{
		private IInterface3 stubInterface3;
		private ISomeInterface stubSomeInterface;

		[TestInitialize]
		public void TestInitialize()
		{
			this.stubInterface3 = MockRepository.GenerateStub<IInterface3>();
			this.stubSomeInterface = MockRepository.GenerateStub<ISomeInterface>();
		}

		[TestMethod]
		public void TestMethod1()
		{
			// Arrange


			// Act
			MixedInjectedClassSingle mixedInjectedClassSingle = this.CreateMixedInjectedClassSingle();


			// Assert

		}

		private MixedInjectedClassSingle CreateMixedInjectedClassSingle()
		{
			return new MixedInjectedClassSingle(
				this.stubSomeInterface)
			{
				Interface3Property = this.stubInterface3,
			};
		}
	}
}

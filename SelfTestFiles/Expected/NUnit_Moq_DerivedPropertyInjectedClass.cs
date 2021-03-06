using Moq;
using NUnit.Framework;
using UnitBoilerplate.Sandbox.Classes;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestFixture]
	public class DerivedPropertyInjectedClassTests
	{
		private MockRepository mockRepository;

		private Mock<IInterface3> mockInterface3;
		private Mock<ISomeInterface> mockSomeInterface;
		private Mock<ISomeOtherInterface> mockSomeOtherInterface;

		[SetUp]
		public void SetUp()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);

			this.mockInterface3 = this.mockRepository.Create<IInterface3>();
			this.mockSomeInterface = this.mockRepository.Create<ISomeInterface>();
			this.mockSomeOtherInterface = this.mockRepository.Create<ISomeOtherInterface>();
		}

		[TearDown]
		public void TearDown()
		{
			this.mockRepository.VerifyAll();
		}

		[Test]
		public void TestMethod1()
		{
			// Arrange


			// Act
			DerivedPropertyInjectedClass derivedPropertyInjectedClass = this.CreateDerivedPropertyInjectedClass();


			// Assert

		}

		private DerivedPropertyInjectedClass CreateDerivedPropertyInjectedClass()
		{
			return new DerivedPropertyInjectedClass
			{
				Interface3Property = this.mockInterface3.Object,
				MyProperty = this.mockSomeInterface.Object,
				Property2 = this.mockSomeOtherInterface.Object,
			};
		}
	}
}

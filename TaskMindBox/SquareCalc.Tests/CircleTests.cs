namespace SquareCalc.Tests
{
    [TestFixture]
    public class CircleTests
    {
        /// <summary>
        /// ���� ������ ������ ����
        /// </summary>
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>new Circle(-4));
        }

        /// <summary>
        /// ���� ���������� ������� ����� � �������� 10
        /// </summary>
        [Test]
        public void CircleCalcSquare()
        {
            Circle circle = new Circle(10);

            double circleSquare = circle.GetSquare;

            Assert.That(circleSquare, Is.EqualTo(314.16));
        }
    }
}
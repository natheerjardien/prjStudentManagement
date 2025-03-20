using prjStudentManagement;

namespace TestStudentManagement
{
    [TestClass]
    public sealed class TestStudentManager
    {
        private StudentManager studentManager;

        [TestInitialize]
        public void setUp()
        {
            studentManager = new StudentManager();
        }
        [TestMethod]
        public void AddStudent_ValidInput_ReturnsCorrectStudent()
        {
            // Arrange
            string name = "John Doe";
            int age = 20;

            // Act
            var student = studentManager.AddStudent(name, age);
            Assert.AreEqual(1, student.iId);
            Assert.AreEqual(name, student.strName);
            Assert.AreEqual(age, student.iAge);
        }
        [TestMethod]
        public void GetStudents_WhenCalled_ReturnsAllStudents()
        {
            // Arrange
            studentManager.AddStudent("Alice", 20);
            studentManager.AddStudent("Bob", 21);

            // Act
            List<Student> students = studentManager.GetStudents();

            // Assert
            Assert.AreEqual(2, students.Count);
            Assert.AreEqual("Alice", students[0].strName);
            Assert.AreEqual("Bob", students[1].strName);
        }
    }
}

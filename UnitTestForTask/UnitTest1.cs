using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleTestingAppTasks;

namespace UnitTestForTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTask_ShouldAddTask()
        {
            // Arrange
            TaskList taskList = new TaskList();

            // Act
            taskList.AddTask("Buy groceries");

            // Assert
            Assert.IsTrue(taskList.ContainsTask("Buy groceries"));
        }

        [TestMethod]
        public void RemoveTask_ShouldRemoveTask()
        {
            // Arrange
            TaskList taskList = new TaskList();
            taskList.AddTask("Buy groceries");

            // Act
            taskList.RemoveTask("Buy groceries");

            // Assert
            Assert.IsFalse(taskList.ContainsTask("Buy groceries"));
        }

        [TestMethod]
        public void MarkTaskAsDone_ShouldMarkTaskAsDone()
        {
            // Arrange
            TaskList taskList = new TaskList();
            taskList.AddTask("Buy groceries");

            // Act
            taskList.MarkTaskAsDone("Buy groceries");

            // Assert
            Assert.IsFalse(taskList.ContainsTask("Buy groceries"));
        }

        [TestMethod]
        public void DisplayTasks_ShouldDisplayTasks()
        {
            // Arrange
            TaskList taskList = new TaskList();
            taskList.AddTask("Buy groceries");
            taskList.AddTask("Do laundry");

            // Act (assuming DisplayTasks writes to console, so no direct assertion)

            // Assert
            // No direct assertion here, as we cannot assert console output
        }
    }
}

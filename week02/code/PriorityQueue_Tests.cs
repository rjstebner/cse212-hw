using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("C", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 1);
        priorityQueue.Enqueue("C", 2);
        priorityQueue.Enqueue("D", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("A", result);
    }

    // Add more test cases as needed below.
}
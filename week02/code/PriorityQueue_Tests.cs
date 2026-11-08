using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 items with different scenarios
    // Expected Result:items are removed from highest to lowest pririty 
    // Defect(s) Found: Dequeue does not check the last item  and does not remove items
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Apple", 2);
    priorityQueue.Enqueue("Banana", 5);
    priorityQueue.Enqueue("Mango", 3);

    Assert.AreEqual("Banana", priorityQueue.Dequeue());
    Assert.AreEqual("Mango", priorityQueue.Dequeue());
    Assert.AreEqual("Apple", priorityQueue.Dequeue());
            
    }

    [TestMethod]
    // Scenario: Athempt to dequeue from an empty queue
    // Expected Result: an invalidOperationException is thrown
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
    }

    // Add more test cases as needed below.
}
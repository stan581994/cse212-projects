using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue elements and check the order of dequeue
    // Expected Result: Elements should be dequeued in priority order
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 3);
        priorityQueue.Enqueue("medium", 2);
        priorityQueue.Enqueue("high", 1);

        Assert.AreEqual("high", priorityQueue.Dequeue());
        Assert.AreEqual("medium", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue elements with the same priority and check the order of dequeue
    // Expected Result: Elements with the same priority should be dequeued in the order they were enqueued
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 1);
        priorityQueue.Enqueue("second", 1);
        priorityQueue.Enqueue("third", 1);

        Assert.AreEqual("first", priorityQueue.Dequeue());
        Assert.AreEqual("second", priorityQueue.Dequeue());
        Assert.AreEqual("third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: InvalidOperationException should be thrown
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue a single element and dequeue it
    // Expected Result: The single element should be dequeued correctly
    public void TestPriorityQueue_SingleElement()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("only", 1);
        Assert.AreEqual("only", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue elements with mixed priorities and check the order of dequeue
    // Expected Result: Elements should be dequeued in priority order
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 3);
        priorityQueue.Enqueue("high", 1);
        priorityQueue.Enqueue("medium", 2);
        priorityQueue.Enqueue("medium-high", 1);

        Assert.AreEqual("high", priorityQueue.Dequeue());
        Assert.AreEqual("medium-high", priorityQueue.Dequeue());
        Assert.AreEqual("medium", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }
}
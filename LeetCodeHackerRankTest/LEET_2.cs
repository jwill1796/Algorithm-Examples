using Shouldly;
using Xunit;
using LeetCodeHackerRankProbs;

namespace LeetCodeHackerRankTest;

public class AddTwoNumbersTest
{
    [Theory]
    [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
    [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    public void AddTwoNumbers_ShouldReturnCorrectSum_WhenTwoNumbersAreGiven(int[] l1, int[] l2, int[] expected)
    {
        // Arrange 
        var addTwoNumbers = new AddTwoNumbers();
        var list1 = CreateListNode(l1);
        var list2 = CreateListNode(l2);
        var expectedList = CreateListNode(expected);

        // Act
        var result = addTwoNumbers.Add(list1, list2);
        
        // Assert
        CompareListNodes(result, expectedList);
    }

    private AddTwoNumbers.ListNode CreateListNode(int[] values)
    {
        AddTwoNumbers.ListNode head = null;
        AddTwoNumbers.ListNode current = null;
        
        foreach (var value in values)
        {
            var newNode = new AddTwoNumbers.ListNode(value);
            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                current.next = newNode;
                current = current.next;
            }
        }
        return head;
    }

   private void CompareListNodes(AddTwoNumbers.ListNode actual, AddTwoNumbers.ListNode expected)
    {
        while (actual != null && expected != null)
        {
            actual.val.ShouldBe(expected.val);
            actual = actual.next;
            expected = expected.next;
        }
        actual.ShouldBeNull();
        expected.ShouldBeNull();

    }
}

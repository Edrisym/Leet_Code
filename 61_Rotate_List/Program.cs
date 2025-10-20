using LeetCode_Models;

namespace _61_Rotate_List;

public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }

        int length = 1;
        var tail = head;
        while (tail.next != null)
        {
            tail = tail.next;
            length++;
        }

        tail.next = head;

        k %= length;
        var stepsToNewHead = length - k;

        var newTail = head;
        for (int i = 1; i < k; i++)
        {
            newTail = newTail.next;
        }

        var newHead = newTail.next;

        newTail.next = null;

        return newHead;
    }
}
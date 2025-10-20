using LeetCode_Models;

namespace _203_Remove_Linked_List_Elements;

public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var dummy = new ListNode();
        var listNode = dummy;

        var currentNode = head;

        while (currentNode != null)
        {
            if (currentNode.value != val)
            {
                listNode.next = currentNode;
                listNode = listNode.next;
            }

            currentNode = currentNode.next;
        }

        listNode.next = null;
        return dummy.next;
    }
}
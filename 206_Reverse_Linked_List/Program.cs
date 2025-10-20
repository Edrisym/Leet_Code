using LeetCode_Models;

var last = new ListNode(5);
var forth = new ListNode(4, last);
var third = new ListNode(3, forth);
var second = new ListNode(2, third);
var first = new ListNode(1, second);


var s = ReverseList(first);
Console.WriteLine(s);

static ListNode ReverseList(ListNode head)
{
    ListNode next;
    ListNode current = head;
    ListNode perv = null;

    while (current != null)
    {
        next = current.next;
        current.next = perv;
        perv = current;
        current = next;
    }

    return perv;
}
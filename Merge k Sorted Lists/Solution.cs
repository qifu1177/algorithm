
//Definition for singly - linked list.

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        ListNode head = null;
        ListNode current = null;
        int currentIndex = 0;
        bool b = true;
        while (b)
        {
            b = false;
            ListNode selected = null;

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] == null)
                    continue;
                b = true;
                if (selected == null)
                {
                    selected = lists[i];
                    currentIndex = i;
                }
                else
                {
                    if (selected.val > lists[i].val)
                    {
                        selected = lists[i];
                        currentIndex = i;
                    }
                }
            }
            if (b)
            {
                lists[currentIndex] = lists[currentIndex].next;
                if (head == null)
                {
                    current = selected;
                    head = current;
                }
                else
                {
                    current.next = selected;
                    current = selected;
                }

            }
        }
        return head;
    }
}
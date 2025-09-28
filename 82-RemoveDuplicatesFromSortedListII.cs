public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var dummy = new ListNode(0, head);
        ListNode prev = dummy, current = head;
        while (current != null) {
            bool duplicate = false;
            while (current.next != null && current.val == current.next.val) {
                current = current.next;
                duplicate = true;
            }
            if (duplicate) prev.next = current.next;
            else prev = prev.next;
            current = current.next;
        }
        return dummy.next;
    }
}

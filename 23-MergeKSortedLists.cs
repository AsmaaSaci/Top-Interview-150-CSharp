public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;
        return MergeRange(lists, 0, lists.Length - 1);
    }

    private ListNode MergeRange(ListNode[] lists, int left, int right) {
        if (left == right) return lists[left];
        int mid = left + (right - left) / 2;
        ListNode l1 = MergeRange(lists, left, mid);
        ListNode l2 = MergeRange(lists, mid + 1, right);
        return MergeTwo(l1, l2);
    }

    private ListNode MergeTwo(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0), curr = dummy;
        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                curr.next = l1;
                l1 = l1.next;
            } else {
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;
        }
        curr.next = l1 ?? l2;
        return dummy.next;
    }
}

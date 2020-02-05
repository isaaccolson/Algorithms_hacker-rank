/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers (ListNode l1, ListNode l2) {
        var l1Count = ListCount (l1);
        var l2Count = ListCount (l2);

        if (l1Count >= l2Count) {
            return Add (l2, l1, l1Count);
        } else {
            return Add (l1, l2, l2Count);
        }
    }

    public ListNode Add (ListNode smallList, ListNode biggerList, int bigCount) {

        var currentBigList = biggerList;
        var currentCarry = 0;

        for (var i = 0; i < bigCount; i++) {

            var newVal = currentBigList.val + smallList.val + currentCarry;

            if (newVal >= 10) {
                newVal -= 10;
                currentCarry = 1;
            } else {
                currentCarry = 0;
            }

            currentBigList.val = newVal;

            if (currentBigList.next != null) {
                currentBigList = currentBigList.next;
            } else {
                if (currentCarry == 1) {
                    currentBigList.next = new ListNode (1);
                }
            }

            if (smallList.next != null) {
                smallList = smallList.next;
            } else {
                smallList = new ListNode (0);
            }

        }

        return biggerList;
    }

    public int ListCount (ListNode ln) {

        var count = 0;
        var currentListNode = ln;

        while (currentListNode != null) {
            count++;
            currentListNode = currentListNode.next;
        }
        return count;
    }
}
public class ListNode {
    public string val;
    public ListNode prev;
    public ListNode next;

    public ListNode(string val, ListNode prev = null, ListNode next = null) {
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}

public class BrowserHistory {
    ListNode page;

    public BrowserHistory(string homepage) {
        page = new ListNode(homepage);
    }
    
    public void Visit(string url) {
        ListNode node = new ListNode(url, page);
        page.next = node;
        page = page.next;
    }
    
    public string Back(int steps) {
        for(int i = 0; i < steps && page.prev != null; i++){
            page = page.prev;
        }
        return page.val;
    }
    
    public string Forward(int steps) {
        for(int i = 0; i < steps && page.next != null; i++){
            page = page.next;
        }
        return page.val;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */
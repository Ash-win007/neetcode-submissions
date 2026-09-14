public class MyLinkedList {
    int val;
    public MyLinkedList next;
    public MyLinkedList prev;
    public MyLinkedList head;
    int size;

    public MyLinkedList() {
        this.next = null;
        this.prev = null;
        this.head = null;
        this.size = 0;
    }
    
    public int Get(int index) {
        if (index < 0 || index >= size) return -1;
        var temp = head;
        for (int i = 0; i < index; i++){
            temp = temp.next;
        }
        return temp.val;
    }
    
    public void AddAtHead(int val) {
        AddAtIndex(0, val);
    }
    
    public void AddAtTail(int val) {
        AddAtIndex(size, val);
    }
    
    public void AddAtIndex(int index, int val) {
        if (index < 0 || index > size) return;
        MyLinkedList node = new MyLinkedList();
        node.val = val;
        if (index == 0) {
            node.next = head;
            if (head != null) head.prev = node;
            head = node;
        } else {
            var temp = head;
            for (int i = 0; i < index - 1; i++) temp = temp.next;
            node.next = temp.next;
            if (temp.next != null) temp.next.prev = node;
            temp.next = node;
            node.prev = temp;
        }
        size++;
    }
    
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= size) return;
        if (index == 0) {
            head = head.next;
            if (head != null) head.prev = null;
        } else {
            var temp = head;
            for (int i = 0; i < index - 1; i++) temp = temp.next;
            temp.next = temp.next.next;
            if (temp.next != null) temp.next.prev = temp;
        }
        size--;
    }
}
public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        int right = 0, n = arr.Length, maxLen = 0, curLen = 1;
        bool isAsc = false;
        if (n < 2) return n;
        if (n == 2 && arr[right] == arr[right + 1])
            return 1;
        else if (n == 2){
            return 2;
        }

        isAsc = arr[right] < arr[right + 1] ? true : false;

        while (right < n - 1){

            if ((isAsc && arr[right] < arr[right + 1]) 
                || (!isAsc && arr[right] > arr[right + 1])){

                right++;
                curLen++;
                isAsc = !isAsc;
            }
            else {
                maxLen = Math.Max(maxLen, curLen);
                curLen = 1;
                if (arr[right] == arr[right + 1])
                    right++;
                if (right + 1 < n)
                    isAsc = arr[right] < arr[right + 1] ? true : false;

            }

        }

        return Math.Max(maxLen, curLen);
;
    }
}
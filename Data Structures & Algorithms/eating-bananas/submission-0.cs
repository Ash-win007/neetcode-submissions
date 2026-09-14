public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int min = 1, max = piles.Max(), ans = max;
        while (min <= max){
            int mid = min + (max - min) / 2;
            if (Validate(piles, h, mid) <= 0) {
                ans = mid;
                max = mid - 1;
            } else {
                min = mid + 1;
            }
        }
        return ans;
    }

    public int Validate(int[] piles, int h, int rate){
        if (rate == 0) return 1;
        long time = 0;
        for (int i = 0; i < piles.Length; i++){
            time += (long)Math.Ceiling((double)piles[i] / rate);
        }
        if (time <= h){
            return -1;
        }
        return 1;
    }
}

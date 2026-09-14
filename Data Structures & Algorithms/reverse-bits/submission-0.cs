public class Solution {
    public uint ReverseBits(uint n) {
        uint res = 0;
        for (int i = 0; i < 32; i++) {
            res = (res << 1) | (n & 1);  // Shift res left, add lowest bit of n
            n >>= 1;                     // Move to next bit in n
        }
        return res;
    }
}
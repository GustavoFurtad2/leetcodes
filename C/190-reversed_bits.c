int reverseBits(int n) {
    
    int reversedBitNumber = 0;

    for (int i = 0; i < 32; i++) {

        int inversedBit = (n >> i) & 1;

        reversedBitNumber = reversedBitNumber | inversedBit << (31 - i);
    }

    return reversedBitNumber;
}
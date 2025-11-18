//*****************************************************************************
//** 717. 1-bit and 2-bit Characters                                leetcode **
//*****************************************************************************
//** A trail of bits, where ones step two and zeros glide one,               **
//** We walk the path to find if the final light is done.                    **
//** If we land on the last lone spark, the truth shines clear and bright    **
//** A single-bit character standing softly in the night.                    **
//*****************************************************************************

bool isOneBitCharacter(int* bits, int bitsSize) {
    if(bitsSize == 1)
    {
        return true;
    }

    int i = 0;

    while(1)
    {
        if(bits[i] == 0)
        {
            i += 1;
        }
        else
        {
            i += 2;
        }

        if(i == bitsSize - 1)
        {
            return true;
        }
        else if(i == bitsSize)
        {
            return false;
        }
    }
}
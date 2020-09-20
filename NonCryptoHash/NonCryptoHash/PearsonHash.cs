using System;
using System.Security.Cryptography;
using System.Text;
using Hash;

namespace Hash.NonCryptoHash
{
    public static class PearsonHash
    {
        private byte[] PermutationTable;

        public static PearsonHash(int length = 256)
        {
            PermutationTable = new byte[length];
            for (int i = 0; i < length; i++)
            {
                PermutationTable[i] = (byte)i;
            }
            Tools.Shuffle(PermutationTable, length);
        }
        public byte Feed(string s)
        {
            byte h = 0;
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            foreach(var b in bytes)
            {
                h = PermutationTable[(byte)(h ^ b)];
            }
            return h;
        }
    }
}

//// TASK 5
//// Define a class BitArray64 to hold 64 bit values inside an ulong value.
//// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace TestProgram
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;
        private int[] bits;

        public BitArray64(ulong num)
        {
            this.number = num;
            this.bits = this.GetBits();
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.bits[index];
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.GetBits();
            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }      
             
        public override bool Equals(object obj)
        {
            var bitArr = obj as BitArray64;
            if (bitArr == null)
            {
                return false;
            }

            if (!object.Equals(this.number, bitArr))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode() ^ (this.number / 2).GetHashCode();
        }

        private int[] GetBits()
        {
            int[] bits = new int[64];

            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = (int)((this.number >> i) & 1);
            }

            return bits;
        }
    }
}

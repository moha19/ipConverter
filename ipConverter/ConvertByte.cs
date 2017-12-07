using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipConverter
{
    public class ConvertByte
    {

        public static string toString(byte[] byteStream, int offset, int len)
        {
            byte[] nameBytes = new byte[len];
            Array.Copy(byteStream, offset, nameBytes, 0, len);
            string str = Encoding.BigEndianUnicode.GetString(nameBytes);
            str = str.Replace('\0', ' ');
            return str;
        }

        public static char[] toCharacter(byte[] byteStream, int offset, int len)
        {
            char[] ch = new char[len];
            for (int i = 0; i < len; i++)
            {
                ch[i] = (char)byteStream[i + offset];
            }
            return ch;
        }

        public static char toSingleCharacter(byte[] byteStream, int offset)
        {
            char ch;
            ch = (char)byteStream[offset];
            return ch;
        }

        public static short toShort(byte[] bytestream, int offset)
        {
            short value = 0;
            for (int i = 0; i < 2; i++)
            {
                int shift = (i) * 8;
                value += (short)((bytestream[i + offset] & 0x00FF) << shift);
            }
            return value;
        }

        public static int toUnsignedShort(byte[] bytestream, int offset)
        {
            short value = 0;
            for (int i = 0; i < 2; i++)
            {
                int shift = (i) * 8;
                value += (short)((bytestream[i + offset] & 0x00FF) << shift);
            }
            return (int)(value & 0x0000FFFF);
        }
        public static int toInt(byte[] bytestream, int offset)
        {
            int value = 0;
            for (int i = 0; i < 4; i++)
            {
                int shift = (i) * 8;
                value += (bytestream[i + offset] & 0x000000FF) << shift;
            }
            return value;
        }

        public static long toLong(byte[] b, int offset)
        {
            return ((b[0 + offset] & 0xFFL) << 0) +
                   ((b[1 + offset] & 0xFFL) << 8) +
                   ((b[2 + offset] & 0xFFL) << 16) +
                   ((b[3 + offset] & 0xFFL) << 24) +
                   ((b[4 + offset] & 0xFFL) << 32) +
                   ((b[5 + offset] & 0xFFL) << 40) +
                   ((b[6 + offset] & 0xFFL) << 48) +
                   (((long)b[7 + offset]) << 56);
        }

        // Added by Adel
        public static long toLongDynamic(byte[] b, int offset, short count)
        {

            long value = 0L;
            for (int i = 0; i < count; i++)
                value += ((b[i + offset] & 0xFFL) << (i * 8));
            return value;


        }
        // end of added by adel

        public static long toUnSignedInt(byte[] bytestream, int offset)
        {
            long value = 0;

            for (int i = 0; i < 4; i++)
            {
                int shift = (i) * 8;
                value += (bytestream[i + offset] & 0x000000FF) << shift;
            }
            return (value & 0xFFFFFFFFL);

        }


        public static int toUnSignedInt3Byte(byte[] bytestream, int offset)
        {
            int value = 0;

            for (int i = 0; i < 3; i++)
            {
                int shift = (i) * 8;
                value += (bytestream[i + offset] & 0x000000FF) << shift;
            }
            return (value);

        }


        public static DateTime toTime(byte[] byteStream, int offset)
        {
            long dateTime = 0;
            for (int i = 0; i < 8; i++)
            {

                dateTime += ((long)byteStream[offset + i] & 0xffL) << (8 * i);

            }

            DateTime time = new DateTime(dateTime);
            return time;


        }

        public static string toUnicode(byte[] byteStream, int offset, int len)
        {
            try
            {
                byte[] bytes = new byte[len + 2];



                for (int i = 0; i < len; i += 2)
                {
                    bytes[i + 1] = byteStream[offset + i];
                    bytes[i] = byteStream[offset + i + 1];
                }

                return Encoding.Unicode.GetString(bytes);
            }
            catch (Exception)
            {
                throw;
            }


        }




        // this method return absolute value of one integer written by teimoori
        public static long abs(int int1)
        {
            // TODO Auto-generated method stub

            if (int1 < 0)
                int1 = int1 * -1;

            return int1;
        }

        public static byte[] toBinary(byte[] byteStream, int offset, int len)
        {
            try
            {
                byte[] bytes = new byte[len];

                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = byteStream[offset + i];
                }

                return bytes;
            }
            catch
            {
                throw;
            }
        }
        public static DateTime toUnixTime(byte[] byteStream, int offset)
        {
            long dateTime = 0;
            for (int i = 0; i < 4; i++)
            {

                dateTime += ((long)byteStream[offset + i] & 0xffL) << (8 * i);

            }

            DateTime time = new DateTime(dateTime);
            return time;


        }
        public static void GetByte(byte[] byteStream, long offset, int count, byte[] inodeRec)
        {

            //inodeRec=new byte[count];
            if ((offset + count) < byteStream.Length)
            {


                int c = 0;
                for (int i = (int)offset; i < (offset + count); i++)
                {

                    inodeRec[c] = byteStream[i];
                    c++;
                }


            }
        }

        public static bool machSigniture(string signiture, byte[] content, int offset, int lenght)
        {
            if (signiture.CompareTo(toString(content, offset, lenght)) == 0)
            {
                return true;
            }
            else
                return true;
        }

        internal static int toUnsignedShort(byte[] content, int p1, int p2)
        {
            throw new NotImplementedException();
        }
    }

}



using System;
using System.Collections.Generic;
using System.Linq;

namespace SinglyLinkedList
{

    public static class MathOperations 
    {
        public static string ShrinkToFit(this string s, int val)
        {
            if (s.Length > val)
            {
                return s.Substring(0, val);
            }
            else
            {
                return s;
            }
        }
        public static decimal Avg<T>(this MyList<T> list)
        {
            if (typeof(T).IsNumericType())
            {
                decimal sum = Convert.ToDecimal(list.Sum());
                return sum / list.Size;
            }
            else
            {
                return default;
            }
        }

       public static T Min<T>(this MyList<T> list) where T : IComparable<T> //меня бы не поняли воспользуйся я расширениями из линка so..
        {
            T min = list[0];
            for (int i = 0; i < list.Size; i++)
                if (Comparer<T>.Default.Compare(list[i], min) < 0)
                {
                    min = list[i];
                }
            return min;

        }

        public static T Max<T>(this MyList<T> list) where T : IComparable<T>
        {
            T max = list[0];
            for (int i = 0; i < list.Size; i++)
                if (Comparer<T>.Default.Compare(list[i], max) > 0)
                {
                    max = list[i];
                }
            return max;
        }

        public static int Count<T>(this MyList<T> list)
        {
            int count = 0;
            foreach (T el in list)
            {
                count++;//господи чем я занимаюсь
            }
            return count;
        }
        public static T Sum<T>(this MyList<T> list)
        {
            if (typeof(T).IsNumericType())
            {
                decimal sum = 0;
                foreach (T el in list)
                {
                    sum += Convert.ToDecimal(el);
                }
                return (T)Convert.ChangeType(sum, typeof(T));

            }
            else
            {
                return default;
            }

        }
    }

}



public static class TypeExtensions
{
    public static bool IsNumericType(this Type type)
    {
        switch (Type.GetTypeCode(type))
        {
            case TypeCode.Byte:
            case TypeCode.SByte:
            case TypeCode.UInt16:
            case TypeCode.UInt32:
            case TypeCode.UInt64:
            case TypeCode.Int16:
            case TypeCode.Int32:
            case TypeCode.Int64:
            case TypeCode.Decimal:
            case TypeCode.Double:
            case TypeCode.Single:
                return true;
            default:
                return false;
        }
    }

    public static bool IsNumeric(this object o)
    {
        switch (Type.GetTypeCode(o.GetType()))
        {
            case TypeCode.Byte:
            case TypeCode.SByte:
            case TypeCode.UInt16:
            case TypeCode.UInt32:
            case TypeCode.UInt64:
            case TypeCode.Int16:
            case TypeCode.Int32:
            case TypeCode.Int64:
            case TypeCode.Decimal:
            case TypeCode.Double:
            case TypeCode.Single:
                return true;
            default:
                return false;
        }

    }
    public static bool IsUnsigned(this object o)
    {
        switch (Type.GetTypeCode(o.GetType()))
        {
            case TypeCode.UInt16:
            case TypeCode.UInt32:
            case TypeCode.UInt64:
                return true;
            default:
                return false;

        }
    }
}


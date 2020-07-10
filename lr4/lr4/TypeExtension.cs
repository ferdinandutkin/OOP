

using System;
using System.Linq;

namespace SinglyLinkedList
{
    public static class StringAndListExtension
    {
        public static string ShrinkToFit(this string s, int val)
        {
            if (s.Length > val)
            {
                return s.Substring(0, val);

            }
            else return s;
            
        }

        public static T Sum<T>(this MyList<T> list)
        {
                decimal sum = 0;
                foreach (T el in list)
                {
                    sum += Convert.ToDecimal(el);
                }
                return (T)Convert.ChangeType(sum, typeof(T));

            }
           
        }
    }


    public static class TypeExtension
    {
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


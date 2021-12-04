using System;
using System.Collections;
namespace pb3
{
    //provides a way to sort the elements of an array in descending order, using the .net features
    public class DescendingComparer : IComparer
    {
        //this could work with any object that can be compared with the comparison operators, for example <, but I will use it only for numbers
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }
}
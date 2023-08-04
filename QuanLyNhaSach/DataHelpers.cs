using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach
{
    public static class DataHelpers
{
   
    public static string GetNonNullString(object value, string defaultValue = "")
    {
        if (value == null || DBNull.Value.Equals(value))
        {
            return defaultValue;
        }
        else
        {
            return value.ToString();
        }
    }

    
    public static string GetNonNullInt(object value, string defaultValue = "")
    {
        if (value == null || DBNull.Value.Equals(value))
        {
            return defaultValue;
        }
        else
        {
             return ((int)value).ToString();
        }
    }

    
    public static string GetNonNullDouble(object value, string defaultValue = "")
    {
        if (value == null || DBNull.Value.Equals(value))
        {
            return defaultValue;
        }
        else
        {
            return ((double)value).ToString();
        }
    }
    }
}

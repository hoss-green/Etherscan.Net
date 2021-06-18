using System;

namespace EthScanNet.Test
{
    public static class TestExts
    {
        public static int ToEditorValue(this object value, object newValue)
        {
#if UNITY_EDITOR
            try
            {
                return (int) Convert.ChangeType(newValue, typeof(int));
            }
            catch (Exception e)
            {
                Console.WriteLine("cannot convert to int");
            }
#endif
            return (int) value;
        }
    }
}
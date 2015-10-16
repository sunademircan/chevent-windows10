using System;

namespace chevent.Windows10.Infrastructure.Core.Extensions
{
    public static class EnumExtensions
    {
        public static int ToInt(this Enum e)
        {
            //new Microsoft.SqlServer.Management.Smo.Table().IsSystemObject
            return Convert.ToInt32(e);
        }

        public static byte ToByte(this Enum e)
        {
            //new Microsoft.SqlServer.Management.Smo.Table().IsSystemObject
            return Convert.ToByte(e);
        }
    }
}

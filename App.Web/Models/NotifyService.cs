namespace App.Web.Models
{
    public static class NotifyService
    {
        public static string Success(string message)
        {
            return $"$.notify(\"{message}\", \"success\")";
        }
        public static string Warn(string message)
        {
            return $"$.notify(\"{message}\", \"warn\")";
        }
        public static string Info(string message)
        {
            return $"$.notify(\"{message}\", \"info\")";
        }
        public static string Error(string message)
        {
            return $"$.notify(\"{message}\", \"error\")";
        }
    }
}

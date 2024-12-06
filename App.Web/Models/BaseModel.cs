namespace App.Web.Models
{
    public class BaseModel
    {
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}

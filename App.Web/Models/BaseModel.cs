namespace App.Web.Models
{
    public class BaseModel
    {
        public string? CREATE_USER { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string? UPDATE_USER { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public int VERSION_NUMBER { get; set; }

        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}

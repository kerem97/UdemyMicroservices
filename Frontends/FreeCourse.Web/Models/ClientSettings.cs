namespace FreeCourse.Web.Models
{
    public class ClientSettings
    {
        public Client Webclient { get; set; }
        public Client WebClientForUser { get; set; }

    }

    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }


}

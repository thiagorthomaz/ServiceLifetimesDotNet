namespace ServiceLifetimes.Models
{
    public class OperationDTO
    {
        
        public string scopedFirstId { get; set; }
        
        public string scopedSecondId { get; set; }

        public string transcientFirstId { get; set; }

        public string transcientSecondId { get; set; }

        public string singletonFirstId { get; set; }

        public string singletonSecondId { get; set; }

    }
}

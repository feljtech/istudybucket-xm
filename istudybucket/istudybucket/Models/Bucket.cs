using System;

namespace istudybucket.Models
{
    public class Bucket
    {
        private string BucketTitle { get; set; }
        private string Description { get; set; }
        private string CreatorName { get; set; }
        private long Participants { get; set; }
        private string CreationDate { get; set; }
    }
}
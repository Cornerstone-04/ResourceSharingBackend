﻿namespace AcademicResourceApp.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CourseCode { get; set; }
        public string Author { get; set; }
        public string Format { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string FileUrl { get; set; }
        public DateTime UploadedAt { get; set; }
        public Guid? UploadedById { get; set; }
        public User UploadedBy { get; set; }

        // Hardcover-specific fields
        public string? PhysicalLocation { get; set; }
        public string? MeetupLocation { get; set; }
        public string? ImageUrl { get; set; } // For uploaded image
    }


}

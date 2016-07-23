namespace CourseOrganizer.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public virtual Department Department { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Credits { get; set; }
        public bool UniversityTransferable { get; set; }
        public bool OnlineOption { get; set; }
        public bool PreparatoryCourse { get; set; }
        //public virtual ICollection<> CourseFormat { get; set; }
        //public virtual ICollection<> Prerequisites { get; set; }

    }
}

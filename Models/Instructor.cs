namespace mvcprototype.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Degree { get; set; }
        public byte[] ProfilePicture { get; set; }

    }
}
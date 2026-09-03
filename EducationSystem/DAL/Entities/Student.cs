namespace EducationSystem.DAL.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ISSN { get; set; }
        public string Code { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

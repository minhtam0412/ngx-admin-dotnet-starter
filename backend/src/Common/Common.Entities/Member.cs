namespace Common.Entities
{
    public class Member : DeletableEntity
    {
        public int MemberId { get; set; }
        public string FullName { get; set; }
    }
}
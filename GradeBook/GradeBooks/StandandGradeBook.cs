
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandandGradeBook : BaseGradeBook
    {
        public StandandGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}

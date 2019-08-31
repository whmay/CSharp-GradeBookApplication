
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankGradeBook : BaseGradeBook
    {
       public RankGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Rank;
        }
    }
}

namespace GradeBook.GradeBooks
{
    class StandardGradeBook: BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted): base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}

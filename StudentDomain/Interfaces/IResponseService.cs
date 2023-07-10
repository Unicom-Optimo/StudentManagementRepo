namespace StudentDomain.Interfaces
{
    public interface IResponseService<T>
    {
        public IEnumerable<T> GetResponse();
    }
}

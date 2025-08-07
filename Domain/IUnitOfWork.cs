namespace PlataformaEstagios.Domain
{
    public interface IUnitOfWork
    {
        public Task Commit();
    }
}

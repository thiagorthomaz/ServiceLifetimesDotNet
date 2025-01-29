namespace ServiceLifetimes.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly Guid _operationId;

        public SingletonService()
        {
            _operationId = Guid.NewGuid();
        }

        public string GetOperationId()
        {
            return $"Singleton Service Operation ID: {_operationId}";
        }
    }
}

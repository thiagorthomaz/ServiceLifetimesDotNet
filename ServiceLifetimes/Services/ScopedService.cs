namespace ServiceLifetimes.Services
{
    public class ScopedService : IScopedService
    {
        private readonly Guid _operationId;

        public ScopedService()
        {
            _operationId = Guid.NewGuid();
        }

        public string GetOperationId()
        {
            return $"Scoped Service Operation ID: {_operationId}";
        }
    }
}

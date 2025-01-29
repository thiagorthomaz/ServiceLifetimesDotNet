namespace ServiceLifetimes.Services
{
    public class TransientService : ITransientService
    {
        private readonly Guid _operationId;

        public TransientService()
        {
            _operationId = Guid.NewGuid();
        }

        public string GetOperationId()
        {
            return $"Transient Service Operation ID: {_operationId}";
        }
    }
}

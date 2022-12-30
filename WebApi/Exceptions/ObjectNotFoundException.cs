namespace WebApi.Exceptions
{
    [Serializable]
    public class ObjectNotFoundException: Exception
    {
        public ObjectNotFoundException() { }

        public ObjectNotFoundException(string message)
            : base(message) { }
    }
}

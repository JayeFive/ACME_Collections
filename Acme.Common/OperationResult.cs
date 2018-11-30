namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<T>
    {
        public OperationResult()
        {
        }

        public OperationResult(T result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public T Result { get; set; }
        public string Message { get; set; }
    }

    public class OperationResultDecimal
    {
        public OperationResultDecimal()
        {
        }

        public OperationResultDecimal(decimal value, string message) : this()
        {
            this.Result = value;
            this.Message = message;
        }

        public decimal Result { get; set; }
        public string Message { get; set; }
    }
}

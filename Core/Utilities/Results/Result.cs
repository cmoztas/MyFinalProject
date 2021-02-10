namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // sadece getter'ı olan prop, ctor'da setlenip gösterilebilir.

        public Result(bool success)
        {
            Success = success;
        }

        // Success - D.R.Y.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public string Message { get; }
        public bool Success { get; }
    }
}
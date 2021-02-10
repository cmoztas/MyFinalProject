namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // sadece getter olan prop, ctor'da setlenebilir.

        public Result(bool success)
        {
            Success = success;
        }

        // Success - D.R.Y.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
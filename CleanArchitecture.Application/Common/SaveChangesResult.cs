using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Application.Common
{
    public class SaveChangesResult
    {
        public static SaveChangesResult Failure(SaveChangesResultType type, string message)
            => new()
            {
                Message = message,
                IsSuccess = false,
                ResultType = type
            };

        public static SaveChangesResult Success()
            => new()
            {
                IsSuccess = true,
            };

        public bool IsSuccess { get; set; }
        public SaveChangesResultType ResultType { get; set; }
        public string Message { get; set; }
    }

    public enum SaveChangesResultType : byte
    {
        [Display(Name = "Success")]
        Success = 1,

        [Display(Name = "UpdateException")]
        UpdateException = 2,

        [Display(Name = "UpdateConcurrencyException")]
        UpdateConcurrencyException = 3,
    }
}
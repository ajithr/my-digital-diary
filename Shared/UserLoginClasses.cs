namespace MyDigitalDiary.Shared
{
    using System.Text.Json.Serialization;
    using System.ComponentModel.DataAnnotations;

    public class UserLoginModel
    {
        [JsonPropertyName("userName")]
        [Required(ErrorMessage = "User name is required.")]
        [StringLength(15, ErrorMessage = "User name too long (15 character limit).")]
        public string UserName { get; set; }
        [JsonPropertyName("password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(10, ErrorMessage = "Password too long (10 character limit).")]
        public string Password { get; set; }
    }

    public class CreateAccountModel : UserLoginModel
    {
        [JsonPropertyName("phoneNumber")]
        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
    }

    public class ResetPasswordModel : UserLoginModel
    {
        [JsonIgnore]
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must be match.")]
        public string ConfirmPassword { get; set; }
    }

    public class UserLoginResponse
    {
        [JsonPropertyName("isUserAdded")]
        public bool IsUserAdded { get; set; }
        [JsonPropertyName("isDuplicateProfile")]
        public bool IsDuplicateProfile { get; set; }
        [JsonPropertyName("isValidUser")]
        public bool IsValidUser { get; set; }
        [JsonPropertyName("isUserProfileUpdated")]
        public bool IsUserProfileUpdated { get; set; }
        [JsonPropertyName("error")]
        public string ErrorMessage { get; set; }

    }
}

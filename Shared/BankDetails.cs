namespace MyDigitalDiary.Shared
{
    using System.Text.Json.Serialization;
    using System.ComponentModel.DataAnnotations;
    public class BankDetails
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
        [JsonPropertyName("bank_name")]
        [Required(ErrorMessage = "Bank name is required.")]
        public string BankName { get; set; }
        [JsonPropertyName("ifsc")]
        [Required(ErrorMessage = "IFSC code is required.")]
        [RegularExpression(@"^[A-Z]{4}0[A-Z0-9]{6}$", ErrorMessage = "Enter a valid IFSC code.")]
        public string IFSC { get; set; }
        [JsonPropertyName("account_holder_name")]
        [Required(ErrorMessage = "Account holder name is required.")]
        public string AccountHolderName { get; set; }
        [JsonPropertyName("account_number")]
        [Required(ErrorMessage = "Account number is required.")]
        [RegularExpression(@"^[0-9]{9,18}$", ErrorMessage = "Enter a valid account number.")]
        public string AccountNumber { get; set; }
        [JsonPropertyName("account_type")]
        [Required(ErrorMessage = "Account holder name is required.")]
        public string AccountType { get; set; }
        public string ImagePath { get; set; }
    }
    public class CardDetails
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
        [JsonPropertyName("bank_name")]
        [Required(ErrorMessage = "Bank name is required.")]
        public string BankName { get; set; }
        [JsonPropertyName("card_number")]
        [CreditCard(ErrorMessage ="Enter a valid card number.")]
        [Required(ErrorMessage = "Card number is required.")]
        public string CardNumber { get; set; }
        [JsonPropertyName("expiry_month")]
        [Required(ErrorMessage = "Expiry month is required.")]
        public string ExpiryMonth { get; set; }
        [JsonPropertyName("expiry_year")]
        [Required(ErrorMessage = "Expiry year is required.")]
        public string ExpiryYear { get; set; }
        [JsonPropertyName("card_holder_name")]
        [Required(ErrorMessage = "Card holder name is required.")]
        public string CardHolderName { get; set; }
        [JsonPropertyName("cvv")]
        [Required(ErrorMessage = "CVV is required.")]
        [RegularExpression(@"^[0-9]{3}$", ErrorMessage = "Not a valid cvv number.")]
        public int? CVV { get; set; }
        [JsonPropertyName("pin")]
        [Required(ErrorMessage = "Pin is required.")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Not a valid pin number.")]
        public int? Pin { get; set; }
        public string ImagePath { get; set; }
    }

    public class CardApiResponse
    {
        [JsonPropertyName("isCardAdded")]
        public bool IsCardAdded { get; set; }
        [JsonPropertyName("isCardUpdated")]
        public bool IsCardUpdated { get; set; }
        [JsonPropertyName("isCardDeleted")]
        public bool IsCardDeleted { get; set; }
        [JsonPropertyName("error")]
        public string ErrorMessage { get; set; }
    }

    public class BankAccountApiResponse
    {
        [JsonPropertyName("isAccountAdded")]
        public bool IsAccountAdded { get; set; }
        [JsonPropertyName("isAccountUpdated")]
        public bool IsAccountUpdated { get; set; }
        [JsonPropertyName("isAccountDeleted")]
        public bool IsAccountDeleted { get; set; }
        [JsonPropertyName("error")]
        public string ErrorMessage { get; set; }
    }

    public static class Banks
    {
        public static Dictionary<string, string> BankNames { get; set; } = new Dictionary<string, string>()
        {
            { "Add Custom Bank", "custom-bank.jpg" },
            { "Axis Bank", "axis.png" },
            { "Bank of Baroda", "bank-of-baroda.png" },
            { "Canara Bank", "canara.png" },
            { "Citi Bank", "citi.jpeg" },
            { "HDFC Bank", "hdfc.png" },
            { "HSBC", "hsbc.png" },
            { "ICICI Bank", "icici.png" },
            { "Indian Bank", "indian.png" },
            { "Indian Overseas Bank", "indian-overseas.png" },
            { "Karur Vysya Bank", "karur-vysya.jpg" },
            { "Kotak Mahendra Bank", "kotak-mahindra.jpg" },
            { "State Bank of India", "sbi.png" },
            { "Tamilnad Mercantile Bank", "tmb.webp" },
            { "Union Bank of India", "union.webp" }
        };

        public static List<string> AccountTypes { get; set; } = new List<string>()
        {
            "Saving Account",
            "Current Account",
            "Checking Account",
            "Women Saving Account",
            "Students Saving Account",
            "Kids Account",
            "Others"
        };
    }

    public enum CRUD
    {
        Add,
        Update,
        Delete
    }
}

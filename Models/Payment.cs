namespace SevenLand.Models;

/// <summary>
/// Stores payment details processed via RazorPay.
/// Includes transaction ID, amount, and status.
/// </summary>
public class Payment
{
    public string Id { get; set; } // RazorPay Payment ID
    public string OrderId { get; set; } // Links to Order model
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "CAD";
    public string Status { get; set; } // "Pending", "Completed", "Failed"
    public DateTime PaymentDate { get; set; } = DateTime.Now;
}
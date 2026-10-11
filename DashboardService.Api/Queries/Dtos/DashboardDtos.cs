namespace DashboardService.Api.Queries.Dtos;

public class SalesResult
{
    public decimal PremiumAmount { get; set; }
    public long PoliciesCount { get; set; }
}

public class PeriodSales
{
    public string Period { get; set; }
    public SalesResult Sales { get; set; }
}

public enum TimeUnit
{
    Month,
    Year
}
using DashboardService.Api.Queries.Dtos;

namespace DashboardService.Api.Queries;

public class GetTotalSalesQuery
{
    public string ProductCode { get; set; }
    public DateTime SalesDateFrom { get; set; }
    public DateTime SalesDateTo { get; set; }
}

public class GetTotalSalesResult
{
    public SalesResult Total { get; set; }
    public Dictionary<string, SalesResult> PerProductTotal { get; set; } = new();
}

public class GetAgentsSalesQuery
{
    public string ProductCode { get; set; }
    public DateTime SalesDateFrom { get; set; }
    public DateTime SalesDateTo { get; set; }
}

public class GetAgentsSalesResult
{
    public Dictionary<string, SalesResult> PerAgentTotal { get; set; } = new();
}

public class GetSalesTrendsQuery
{
    public string ProductCode { get; set; }
    public DateTime SalesDateFrom { get; set; }
    public DateTime SalesDateTo { get; set; }
    public TimeUnit Unit { get; set; }
}

public class GetSalesTrendsResult
{
    public List<PeriodSales> PeriodsSales { get; set; } = new();
}
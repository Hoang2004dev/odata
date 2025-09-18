using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OdataAssignment.Application.DTOs.Confirmed;
using OdataAssignment.Application.DTOs.DailyReport;
using OdataAssignment.Application.DTOs.Death;
using OdataAssignment.Application.DTOs.Location;
using OdataAssignment.Application.DTOs.Recovered;

namespace OdataAssignment.Api.ModelBuilder;

public static class EdmModelBuilder
{
    public static IEdmModel GetEdmModel()
    {
        var builder = new ODataConventionModelBuilder();

        // Map DTOs trả về qua OData
        builder.EntitySet<LocationResponseDto>("Locations");
        builder.EntitySet<ConfirmedResponseDto>("Confirmed");
        builder.EntitySet<DeathResponseDto>("Deaths");
        builder.EntitySet<RecoveredResponseDto>("Recovered");
        builder.EntitySet<DailyReportResponseDto>("DailyReports");

        return builder.GetEdmModel();
    }
}

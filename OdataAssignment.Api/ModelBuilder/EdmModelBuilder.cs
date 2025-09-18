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

        builder.EntitySet<LocationResponseDto>("Locations");
        builder.EntitySet<ConfirmedResponseDto>("Confirmed");
        builder.EntitySet<DeathResponseDto>("Deaths");
        builder.EntitySet<RecoveredResponseDto>("Recovered");
        builder.EntitySet<DailyReportResponseDto>("DailyReports");

        builder.EntityType<ConfirmedResponseDto>()
               .HasRequired(c => c.Location);

        builder.EntityType<DeathResponseDto>()
               .HasRequired(d => d.Location);

        builder.EntityType<RecoveredResponseDto>()
               .HasRequired(r => r.Location);

        builder.EntityType<DailyReportResponseDto>()
               .HasRequired(dr => dr.Location);

        return builder.GetEdmModel();
    }
}

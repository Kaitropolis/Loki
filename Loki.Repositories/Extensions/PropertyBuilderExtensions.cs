using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using JsonSerializer = Utf8Json.JsonSerializer;

namespace Loki.Repositories.Extensions
{
    public static class PropertyBuilderExtensions
    {
        public static PropertyBuilder<T> HasJsonConversion<T>(this PropertyBuilder<T> propertyBuilder)
        {
            var converter = new ValueConverter<T, string>(
                x => JsonSerializer.ToJsonString(x),
                x => JsonSerializer.Deserialize<T>(x));

            var comparer = new ValueComparer<T>(
                (l, r) => JsonSerializer.ToJsonString(l) == JsonSerializer.ToJsonString(r),
                v => v == null ? 0 : JsonSerializer.ToJsonString(v).GetHashCode(),
                v => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(v)));

            propertyBuilder.HasConversion(converter);

            propertyBuilder.Metadata.SetValueConverter(converter);
            propertyBuilder.Metadata.SetValueComparer(comparer);

            return propertyBuilder;
        }
    }
}

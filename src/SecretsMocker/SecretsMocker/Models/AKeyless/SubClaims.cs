using SecretsMocker.Models.Converters;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace SecretsMocker.Models.AKeyless;

[JsonConverter(typeof(SubClaimsConverter))]
public class SubClaims
{
    [JsonPropertyName("claim1"), AllowNull]
    public List<string> Claim1 { get; set; }
}
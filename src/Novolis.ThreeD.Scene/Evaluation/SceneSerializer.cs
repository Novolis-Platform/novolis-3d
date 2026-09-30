using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Novolis.ThreeD;

/// <summary>JSON load/save for <c>.nov3djson</c>.</summary>
public static class SceneSerializer
{
    public static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
    };

    public static string Serialize(SceneDocument document)
    {
        ArgumentNullException.ThrowIfNull(document);
        document.ModifiedAt = DateTimeOffset.UtcNow;
        return JsonSerializer.Serialize(document, JsonOptions);
    }

    public static SceneDocument Deserialize(string json)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(json);
        var doc = JsonSerializer.Deserialize<SceneDocument>(json, JsonOptions)
                  ?? throw new InvalidOperationException("Failed to deserialize scene document.");
        if (!string.Equals(doc.Format, "novolis.scene", StringComparison.Ordinal))
            throw new InvalidOperationException($"Unexpected format '{doc.Format}'.");
        return doc;
    }

    public static void Save(SceneDocument document, string path)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(path);
        File.WriteAllText(path, Serialize(document));
    }

    public static SceneDocument Load(string path)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(path);
        return Deserialize(File.ReadAllText(path));
    }
}

using System.Text.Json.Serialization;

namespace z3roco01.pitchedVocals;

public class Config {
    [JsonInclude] public float pitchFactor = 1.45f;
}
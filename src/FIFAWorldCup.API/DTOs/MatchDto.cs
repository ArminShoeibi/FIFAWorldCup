namespace FIFAWorldCup.API.DTOs;

public sealed record class MatchDto(byte MatchNumber, string TeamAName, string TeamBName, DateTimeOffset MatchDateTime);
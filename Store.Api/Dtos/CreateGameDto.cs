namespace Store.Api.Dtos;

public record CreateGameDto(
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate);
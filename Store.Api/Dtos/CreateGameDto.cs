using System.ComponentModel.DataAnnotations;

namespace Store.Api.Dtos;

public record CreateGameDto(
    [Required][StringLength(50)] string Name,
    int GenreId,
    [Range(1, 100)] decimal Price,
    DateOnly ReleaseDate);
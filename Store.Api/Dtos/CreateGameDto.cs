using System.ComponentModel.DataAnnotations;

namespace Store.Api.Dtos;

public record CreateGameDto(
    [Required][StringLength(50)] string Name,
    [Required][StringLength(20)] string Genre,
    [Range(1, 100)] decimal Price,
    DateOnly ReleaseDate);
﻿using System.ComponentModel.DataAnnotations;
using FilmesApi.Data;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O título do filme é obrigatorio")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "O título do Genero é obrigatorio")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]

    public int Duracao { get; set; }

}



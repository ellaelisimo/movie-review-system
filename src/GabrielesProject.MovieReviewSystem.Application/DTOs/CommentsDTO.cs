﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielesProject.MovieReviewSystem.Application.DTOs;

public record CommentsDTO
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Text { get; set; }
}

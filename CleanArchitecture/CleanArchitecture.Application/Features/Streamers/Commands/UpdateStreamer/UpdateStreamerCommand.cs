﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
    public class UpdateStreamerCommand: IRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }=String.Empty;
        public string Url { get; set; } = String.Empty;
    }
}
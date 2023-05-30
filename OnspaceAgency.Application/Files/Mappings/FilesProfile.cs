using AutoMapper;
using OnspaceAgency.Application.Files.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Files.Mappings
{
    public class FilesProfile : Profile
    {
        public FilesProfile() { 
         
            CreateMap<Domain.Entities.Files, FilesDto>();
            CreateMap<FilesDto,Domain.Entities.Files>();
        }
    }
}

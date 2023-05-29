using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Application.Files.Dto;
using OnspaceAgency.Application.Generic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Interfaces
{
    public interface IFilesService : IBaseCrudService<Domain.Entities.Files>
    {
        Task Put(FilesDto dto);
        Task Push(int filesId);
    }
}

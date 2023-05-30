using AutoMapper;
using OnspaceAgency.Application.Files.Dto;
using OnspaceAgency.Application.Generic.Handlers;
using OnspaceAgency.Application.Generic.Interfaces;
using OnspaceAgency.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Files.Handlers
{
    
        public interface IFilesHandler : IBaseCrudHandler<FilesDto, Domain.Entities.Files>
        {
            new Task<FilesDto> GetById(int id);
            new Task<FilesDto> Update(FilesDto dto);
            new Task<FilesDto> Update(int id, FilesDto dto);
            new Task<FilesDto> Create(FilesDto dto);
            new Task<List<FilesDto>> Get(int top);
        }
        public class FilesHandler : BaseCrudHandler<FilesDto, Domain.Entities.Files>, IFilesHandler
        {
            private readonly IFilesService _crudService;
            private readonly IMapper _mapper;

            public FilesHandler(IFilesService crudService, IMapper mapper) : base(crudService, mapper)
            {
                _crudService = crudService;
                _mapper = mapper;
            }

            public new async Task<FilesDto> GetById(int id)
            {
                var Files = await base.GetById(id);

                if (Files == null) throw new Exception("Files not found");

                return Files;

            }

            public new async Task<FilesDto> Update(FilesDto dto)
            {
                return await base.Update(dto);
            }

            public new async Task<FilesDto> Update(int id, FilesDto dto)
            {
                return await base.Update(id, dto);
            }

            public new async Task<FilesDto> Create(FilesDto dto)
            {

                return await base.Create(dto);

            }

            public async Task<List<FilesDto>> Get(int top)
            {
                return await base.Get(top);
            }

        }
   
}

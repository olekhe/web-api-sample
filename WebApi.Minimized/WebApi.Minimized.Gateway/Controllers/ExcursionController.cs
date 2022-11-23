using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Minimized.Core.Abstractions;
using WebApi.Minimized.Core.Entities;
using WebApi.Minimized.Services.Queries;

namespace WebApi.Minimized.Gateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcursionController : ControllerBase
    {
        private readonly ILogger<ExcursionController> _logger;
        private readonly IGenericRepository _repository;

        public ExcursionController(ILogger<ExcursionController> logger, IGenericRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("get-excursion")]
        public IEnumerable<Excursion> GetExcursion()
        {
            return _repository
                .Query<Excursion>()
                .AllExcursion()
                .ToList();
        }

        [HttpGet("get-excursion/{id:excursionId}")]
        public IEnumerable<Excursion> GetExcursionDetails(int id)
        {
            return _repository
                .Query<Excursion>()
                .ExcursionDetails(id)
                .ToList();
        }

    }
}

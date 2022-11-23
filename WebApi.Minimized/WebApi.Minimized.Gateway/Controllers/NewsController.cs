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
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> _logger;
        private readonly IGenericRepository _repository;

        public NewsController(ILogger<NewsController> logger, IGenericRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("get-news")]
        public IEnumerable<News> GetNews()
        {
            var news = _repository
                .Query<News>()
                .AllNews()
                .ToList();

            return news;
        }

    }
}

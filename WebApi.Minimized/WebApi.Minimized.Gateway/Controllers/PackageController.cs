﻿using Microsoft.AspNetCore.Mvc;
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
    public class PackageController : ControllerBase
    {
        private readonly ILogger<PackageController> _logger;
        private readonly IGenericRepository _repository;

        public PackageController(ILogger<PackageController> logger, IGenericRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("get-packages")]
        public IEnumerable<Package> GetAllPackages()
        {
            return _repository
                .Query<Package>()
                .AllPackages()
                .ToList();
        }

        [HttpGet("get-packages/{id:categoryPackageId}")]
        public IEnumerable<Package> GetCategoryPackages(int categoryPackageId)
        {
            return _repository
                .Query<Package>()
                .CategoryPackages(categoryPackageId)
                .ToList();
        }

        [HttpGet("get-packages/{id:packageId}")]
        public IEnumerable<Package> GetPackageDetailsQueriesExtensions(int packageId)
        {
            return _repository
                .Query<Package>()
                .CategoryPackages(packageId)
                .ToList();
        }
    }
}

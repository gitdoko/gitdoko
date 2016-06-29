﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gitdoko.Controllers
{
    public class IssueController : TopicController
    {
        public override Task<IActionResult> Mine( int page = 1 )
        {
            return Task.FromResult((IActionResult)View("List"));
        }

        public override Task<IActionResult> Involved( int page = 1 )
        {
            return Task.FromResult((IActionResult)View("List"));
        }

        public override Task<IActionResult> InvolvedInProject( int page = 1 )
        {
            return Task.FromResult((IActionResult)View("List"));
        }

        public override Task<IActionResult> Index( int page = 1 )
        {
            return Task.FromResult((IActionResult)Content($"Issues for {ProjectOwner}/{ProjectName}, page {page}"));
        }

        public override Task<IActionResult> Create()
        {
            return Task.FromResult((IActionResult)Content($"Create issue for {ProjectOwner}/{ProjectName}"));
        }
    }
}

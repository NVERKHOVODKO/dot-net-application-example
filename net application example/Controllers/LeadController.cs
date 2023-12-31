﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeadController : ControllerBase 
    {
        private readonly ILeadService _leadService;

        public LeadController(ILeadService leadService)
        {
            _leadService = leadService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var lead = await _leadService.Get(id);
            
            return Ok(lead);
        }
        
        [HttpPost("create")]
        public async Task<IActionResult> Create(LeadModel leadModel)
        {
            var leadId = await _leadService.Create(leadModel);
            
            return Ok(leadId);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(LeadModel leadModel)
        {
            await _leadService.Update(leadModel);
            
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _leadService.Delete(id);
            
            return Ok();
        }
    }
}
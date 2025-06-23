using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using mycompany_project.Companies;
using System.Collections.Generic;
using System;
using System.Linq;


namespace mycompany_project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyController : AbpController
{
    private static readonly List<CompanyDto> _companies = new();

    [HttpGet]
    public ActionResult<List<CompanyDto>> GetList()
    {
        return _companies;
    }

    [HttpPost]
    public ActionResult<CompanyDto> Create(CreateUpdateCompanyDto input)
    {
        var company = new CompanyDto
        {
            Id = Guid.NewGuid(),
            Name = input.Name,
            Location = input.Location
        };
        _companies.Add(company);
        return company;
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, CreateUpdateCompanyDto input)
    {
        var company = _companies.FirstOrDefault(x => x.Id == id);
        if (company == null) return NotFound();

        company.Name = input.Name;
        company.Location = input.Location;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var company = _companies.FirstOrDefault(x => x.Id == id);
        if (company == null) return NotFound();

        _companies.Remove(company);
        return NoContent();
    }
}

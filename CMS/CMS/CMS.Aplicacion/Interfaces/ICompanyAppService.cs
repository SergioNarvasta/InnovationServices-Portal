﻿using CMS.Dominio.Entidades;

namespace CMS.Aplicacion.Interfaces
{
	public interface ICompanyAppService
	{
		Task DeleteCompany(string id);
		Task<IEnumerable<Company>> GetAllCompany();
		Task<Company> GetCompanyById(string id);
		Task InsertCompany(Company company);
		Task UpdateCompany(Company company);
	}
}
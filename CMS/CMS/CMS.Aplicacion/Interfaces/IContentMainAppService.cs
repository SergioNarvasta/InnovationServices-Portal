﻿using CMS.Dominio.Entidades;

namespace CMS.Aplicacion.Interfaces
{
    public interface IContentMainAppService
    {
        Task Delete(string id);
        Task<IEnumerable<ContentMain>> GetAll();
		Task<ContentMain> GetById(string id);
		Task Insert(ContentMain sliderMain);
        Task Update(ContentMain sliderMain);
    }
}

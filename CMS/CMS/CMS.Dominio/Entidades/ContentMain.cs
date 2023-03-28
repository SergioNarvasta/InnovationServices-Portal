﻿using MongoDB.Bson;
using CMS.Dominio.Comunes;

namespace CMS.Dominio.Entidades
{
    public class ContentMain :FileUnit
    {
        public ObjectId ContentMain_Id { get; set; }

        public string ContentMain_Pk { get; set; }

        public string ContentMain_Titulo { get; set; }

        public string ContentMain_Descripcion { get; set; }
        public string ContentMain_Contenido { get; set; }

        public int ContentMain_Estado { get; set; }

        public int ContentMain_Orden { get; set; }
        public string Company_Pk { get; set; }
    }
}
﻿using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using VerificaXmlOutlook.Models;

namespace GetXml.Models
{
    public class DataRepository
    {
        private static IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

        protected string folderPendente = configuration.GetSection("FolderLocations:folderPendente").Value;
        protected string folderAprovado = configuration.GetSection("FolderLocations:folderAprovado").Value;
        protected string folderSemCertificado = configuration.GetSection("FolderLocations:folderSemCertificado").Value;
        protected string folderCertificadoInvalido = configuration.GetSection("FolderLocations:folderCertificadoInvalido").Value;
        protected string folderFalha = configuration.GetSection("FolderLocations:folderFalha").Value;
        protected string folderConcluido = configuration.GetSection("FolderLocations:folderConcluido").Value;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergyDef
{
    public interface ICalculEnergia
    {
        /// <summary>
        ///  Valida les dades introduides
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>retorna boolea</returns>
        bool ConfParametre();

        /// <summary>
        ///  Calcula l'energia
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>retorna double</returns>
        double CalcEnergia();

        /// <summary>
        ///  Mostra un informe complet
        /// </summary>
        /// <param>No parametres</param>
        /// <returns>no retorna res</returns>
        void MostraInforme();

        

    }
}

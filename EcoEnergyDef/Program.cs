﻿using System;
namespace EcoEnergyDef
{
    public class Program
    {
        public static void Main() {
            SistemaEolica prueba = new SistemaEolica(32);
            prueba.MostraInforme();
            SistemaSolar prueba2 = new SistemaSolar(32);
            prueba2.MostraInforme();
            SistemaHidroelectric prueba3 = new SistemaHidroelectric(32);
            prueba3.MostraInforme();
    } }
}
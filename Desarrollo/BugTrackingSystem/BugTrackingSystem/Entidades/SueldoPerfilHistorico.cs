﻿using System;

namespace BugTrackingSystem.Entidades
{
    public class SueldoPerfilHistorico
    {
        public Perfil Perfil { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Sueldo { get; set; }
    }
}

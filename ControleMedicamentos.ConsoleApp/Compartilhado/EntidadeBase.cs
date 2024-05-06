﻿using System.Collections;

namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    internal abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract string[] Validar();

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
    }
}

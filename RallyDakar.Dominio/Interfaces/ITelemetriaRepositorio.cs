﻿using RallyDakar.Dominio.Entidades;
using System.Collections.Generic;

namespace RallyDakar.Dominio.Interfaces
{
    public interface ITelemetriaRepositorio
    {
        void Adicionar(Telemetria telemetria);
        IEnumerable<Telemetria> ObterTodos();
        IEnumerable<Telemetria> ObterTodosPorEquipe(int equipeId);
        Telemetria ObterPor(int equipeId, int telemetriaId);
        Telemetria Obter(int telemetriaId);
        bool Existe(int telemetriaId);
        void Atualizar(Telemetria telemetria);
        void Deletar(Telemetria telemetria);
    }
}

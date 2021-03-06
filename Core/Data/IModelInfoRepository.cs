﻿using System.Collections.Generic;
using Core.Models;

namespace Core.Data
{
    public interface IModelInfoRepository
    {
        List<ModelInfo> Get();
        void Save(List<ModelInfo> models);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace BoilerPlateTemplate.EntityFramework.Repositories
{
    public abstract class BoilerPlateTemplateRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BoilerPlateTemplateDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class BoilerPlateTemplateRepositoryBase<TEntity> : BoilerPlateTemplateRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}

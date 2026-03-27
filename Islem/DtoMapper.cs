using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public static class DtoMapper
    {
        public static TEntity DtoToEntity<TEntity, TDto>(TDto dto) where TEntity : new()
        {
                TEntity entity = new TEntity();
                var dtoProperties = typeof(TDto).GetProperties();
                var entityProperties = typeof(TEntity).GetProperties();

            foreach (var dtoProp in dtoProperties)
            {
                var entityProp = entityProperties.FirstOrDefault(p => p.Name == dtoProp.Name && p.PropertyType == dtoProp.PropertyType);
                if (entityProp != null)
                {
                    var value = dtoProp.GetValue(dto);
                    entityProp.SetValue(entity, value);
                }
            }

            return entity;
        }
    }
}

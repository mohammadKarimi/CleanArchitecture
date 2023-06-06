using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CleanArchitecture.Infrastructure.Persistence.Extensions;

public static class ModelBuilderExtentions
{
    public static void RegisterAllEntities<BaseType>(this ModelBuilder modelBuilder,
                                                     params Assembly[] assemblies) where BaseType : class
    {
        IEnumerable<Type> types = assemblies.SelectMany(a => a.GetExportedTypes())
            .Where(c => c.IsClass && !c.IsAbstract && c.IsPublic);

        foreach (var type in types)
        {
            modelBuilder.Entity(type);
        }
    }
}
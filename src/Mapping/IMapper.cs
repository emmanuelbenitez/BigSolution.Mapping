using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace BigSolution.Infra.Mapping
{
    [UsedImplicitly]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IMapper<in TSource, out TDestination>
    {
        TDestination Map(TSource source);
    }
}

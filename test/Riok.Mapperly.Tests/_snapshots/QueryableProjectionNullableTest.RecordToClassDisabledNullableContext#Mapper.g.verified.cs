//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private partial global::System.Linq.IQueryable<global::B?>? Map(global::System.Linq.IQueryable<global::A?>? source)
    {
        if (source == null)
            return default;
#nullable disable
        return System.Linq.Queryable.Select(source, x => new global::B(x.Value));
#nullable enable
    }
}
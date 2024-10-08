//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private partial global::B Map(global::A source)
    {
        var target = new global::B();
        target.EnsureCapacity(source.Count);
        foreach (var item in source)
        {
            target[item.Key] = MapToListOfD(item.Value);
        }
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private global::D MapToD(global::C source)
    {
        var target = new global::D(source.Value);
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private global::System.Collections.Generic.List<global::D> MapToListOfD(global::System.Collections.Generic.IReadOnlyCollection<global::C> source)
    {
        var target = new global::System.Collections.Generic.List<global::D>(source.Count);
        foreach (var item in source)
        {
            target.Add(MapToD(item));
        }
        return target;
    }
}
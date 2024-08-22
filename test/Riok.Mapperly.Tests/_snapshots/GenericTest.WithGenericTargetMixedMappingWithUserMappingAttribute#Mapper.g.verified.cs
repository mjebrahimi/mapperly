﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    partial TTarget Map<TTarget>(object source)
    {
        return source switch
        {
            global::A x when typeof(TTarget).IsAssignableFrom(typeof(global::B)) => (TTarget)(object)MapToB(x),
            global::C x when typeof(TTarget).IsAssignableFrom(typeof(global::D)) => (TTarget)(object)MapToD(x),
            _ => throw new System.ArgumentException($"Cannot map {source.GetType()} to {typeof(TTarget)} as there is no known type mapping", nameof(source)),
        };
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    partial global::B MapToBInternal(global::A source)
    {
        var target = new global::B();
        target.Value = source.Value;
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    partial global::D MapToD(global::C source)
    {
        var target = new global::D(source.Value1);
        return target;
    }
}
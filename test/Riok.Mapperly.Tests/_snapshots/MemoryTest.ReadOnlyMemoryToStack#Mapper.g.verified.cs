﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private partial global::System.Collections.Generic.Stack<int> Map(global::System.ReadOnlyMemory<int> source)
    {
        return MapToStackOfInt32(source.Span);
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private global::System.Collections.Generic.Stack<int> MapToStackOfInt32(global::System.ReadOnlySpan<int> source)
    {
        var target = new global::System.Collections.Generic.Stack<int>(source.Length);
        foreach (var item in source)
        {
            target.Push(item);
        }
        return target;
    }
}
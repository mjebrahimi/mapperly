﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public partial void Map(global::A src, global::B trg)
    {
        switch (src, trg)
        {
            case (global::ASubType1 source, global::BSubType1 target):
                target.Value1 = source.Value1;
                target.BaseValue = source.BaseValue;
                break;
            case (global::ASubType2 source, global::BSubType2 target):
                target.Value1 = source.Value1;
                target.BaseValue = source.BaseValue;
                break;
            default:
                throw new System.ArgumentException($"Cannot map {src.GetType()} to {trg.GetType()} as there is no known derived type mapping", nameof(src));
        }
    }
}
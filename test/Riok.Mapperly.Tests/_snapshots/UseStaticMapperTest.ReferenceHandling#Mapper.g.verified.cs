﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private partial global::B Map(global::A source, global::Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler)
    {
        if (refHandler.TryGetReference<global::A, global::B>(source, out var existingTargetReference))
            return existingTargetReference;
        var target = new global::B(global::OtherMapper.ToBExternal(source.Value, refHandler));
        refHandler.SetReference<global::A, global::B>(source, target);
        return target;
    }
}
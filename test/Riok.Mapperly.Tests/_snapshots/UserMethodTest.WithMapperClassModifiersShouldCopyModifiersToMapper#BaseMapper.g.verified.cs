﻿//HintName: BaseMapper.g.cs
// <auto-generated />
#nullable enable
internal sealed abstract partial class BaseMapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public partial global::B AToB(global::A source)
    {
        var target = new global::B();
        target.Value = IntToString(source.Value);
        target.Value2 = IntToShort(source.Value2);
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    protected partial short IntToShort(int value)
    {
        return (short)value;
    }
}
﻿//HintName: BaseMapper2.g.cs
// <auto-generated />
#nullable enable
public partial class BaseMapper2
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public override partial global::B AToB(global::A source)
    {
        var target = new global::B();
        target.Value = source.Value.ToString();
        target.Value2 = IntToShort(source.Value2);
        return target;
    }
}
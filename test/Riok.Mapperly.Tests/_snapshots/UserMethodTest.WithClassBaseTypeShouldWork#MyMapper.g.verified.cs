﻿//HintName: MyMapper.g.cs
// <auto-generated />
#nullable enable
public partial class MyMapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public partial global::B Map(global::A source)
    {
        var target = new global::B();
        target.Value = MyMapping(source.Value);
        target.Value2 = ((global::BaseMapper2)this).MyMapping2(source.Value2);
        target.Value3 = ((global::BaseMapper3)this).MyMapping3(source.Value3);
        target.Value4 = MyIntToShortMapping(source.Value4);
        return target;
    }
}
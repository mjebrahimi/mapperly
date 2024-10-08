using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Riok.Mapperly.Symbols;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static Riok.Mapperly.Emit.Syntax.SyntaxFactoryHelper;

namespace Riok.Mapperly.Descriptors.Mappings.UserMappings;

/// <summary>
/// A mapping which has a <see cref="Type"/> as a second parameter describing the target type of the mapping.
/// Generates a switch expression based on the mapping types.
/// </summary>
public class UserDefinedNewInstanceRuntimeTargetTypeParameterMapping(
    IMethodSymbol method,
    RuntimeTargetTypeMappingMethodParameters parameters,
    bool enableReferenceHandling,
    ITypeSymbol targetType,
    NullFallbackValue? nullArm,
    ITypeSymbol objectType,
    bool enableAggressiveInlining
)
    : UserDefinedNewInstanceRuntimeTargetTypeMapping(
        method,
        parameters.Source,
        parameters.ReferenceHandler,
        targetType,
        enableReferenceHandling,
        nullArm,
        objectType,
        enableAggressiveInlining
    )
{
    protected override ParameterListSyntax BuildParameterList() =>
        ParameterList(
            IsExtensionMethod,
            [SourceParameter, parameters.TargetType, ReferenceHandlerParameter, .. AdditionalSourceParameters]
        );

    protected override ExpressionSyntax BuildTargetType() => IdentifierName(parameters.TargetType.Name);
}

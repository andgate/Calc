//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calc/Expression.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ExpressionParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IExpressionListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>parensExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParensExp([NotNull] ExpressionParser.ParensExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parensExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParensExp([NotNull] ExpressionParser.ParensExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>mulDivExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDivExp([NotNull] ExpressionParser.MulDivExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>mulDivExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDivExp([NotNull] ExpressionParser.MulDivExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>powExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPowExp([NotNull] ExpressionParser.PowExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>powExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPowExp([NotNull] ExpressionParser.PowExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>addSubExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSubExp([NotNull] ExpressionParser.AddSubExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addSubExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSubExp([NotNull] ExpressionParser.AddSubExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumExp([NotNull] ExpressionParser.NumExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numExp</c>
	/// labeled alternative in <see cref="ExpressionParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumExp([NotNull] ExpressionParser.NumExpContext context);
}

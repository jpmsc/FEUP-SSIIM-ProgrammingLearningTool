//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from JSON.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IJSONListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class JSONBaseListener : IJSONListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStart([NotNull] JSONParser.StartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStart([NotNull] JSONParser.StartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] JSONParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] JSONParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction([NotNull] JSONParser.FunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction([NotNull] JSONParser.FunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.function_use"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_use([NotNull] JSONParser.Function_useContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.function_use"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_use([NotNull] JSONParser.Function_useContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.function_inside_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_inside_function([NotNull] JSONParser.Function_inside_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.function_inside_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_inside_function([NotNull] JSONParser.Function_inside_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.function_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_declaration([NotNull] JSONParser.Function_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.function_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_declaration([NotNull] JSONParser.Function_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.for_cycle"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_cycle([NotNull] JSONParser.For_cycleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.for_cycle"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_cycle([NotNull] JSONParser.For_cycleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.param_id_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParam_id_list([NotNull] JSONParser.Param_id_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.param_id_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParam_id_list([NotNull] JSONParser.Param_id_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.param_decl_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParam_decl_list([NotNull] JSONParser.Param_decl_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.param_decl_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParam_decl_list([NotNull] JSONParser.Param_decl_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.param_decl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParam_decl([NotNull] JSONParser.Param_declContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.param_decl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParam_decl([NotNull] JSONParser.Param_declContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.param_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParam_id([NotNull] JSONParser.Param_idContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.param_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParam_id([NotNull] JSONParser.Param_idContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.statement_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement_list([NotNull] JSONParser.Statement_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.statement_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement_list([NotNull] JSONParser.Statement_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] JSONParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] JSONParser.StatementContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}

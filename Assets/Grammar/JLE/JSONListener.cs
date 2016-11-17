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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="JSONParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IJSONListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] JSONParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] JSONParser.StartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] JSONParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] JSONParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] JSONParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] JSONParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.function_use"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_use([NotNull] JSONParser.Function_useContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.function_use"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_use([NotNull] JSONParser.Function_useContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.function_inside_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_inside_function([NotNull] JSONParser.Function_inside_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.function_inside_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_inside_function([NotNull] JSONParser.Function_inside_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.function_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_declaration([NotNull] JSONParser.Function_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.function_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_declaration([NotNull] JSONParser.Function_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.param_id_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParam_id_list([NotNull] JSONParser.Param_id_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.param_id_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParam_id_list([NotNull] JSONParser.Param_id_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.param_decl_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParam_decl_list([NotNull] JSONParser.Param_decl_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.param_decl_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParam_decl_list([NotNull] JSONParser.Param_decl_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.param_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParam_decl([NotNull] JSONParser.Param_declContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.param_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParam_decl([NotNull] JSONParser.Param_declContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.param_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParam_id([NotNull] JSONParser.Param_idContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.param_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParam_id([NotNull] JSONParser.Param_idContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.statement_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement_list([NotNull] JSONParser.Statement_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.statement_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement_list([NotNull] JSONParser.Statement_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSONParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] JSONParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSONParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] JSONParser.StatementContext context);
}
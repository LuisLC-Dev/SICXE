//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\lopez\source\repos\Practica2LopezCastillo\Practica2LopezCastillo\sicxegram.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Practica2LopezCastillo {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="sicxegramParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IsicxegramListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] sicxegramParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] sicxegramParser.ProgContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInicio([NotNull] sicxegramParser.InicioContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInicio([NotNull] sicxegramParser.InicioContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFin([NotNull] sicxegramParser.FinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFin([NotNull] sicxegramParser.FinContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.entrada"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntrada([NotNull] sicxegramParser.EntradaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.entrada"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntrada([NotNull] sicxegramParser.EntradaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.proposiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProposiciones([NotNull] sicxegramParser.ProposicionesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.proposiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProposiciones([NotNull] sicxegramParser.ProposicionesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProposicion([NotNull] sicxegramParser.ProposicionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProposicion([NotNull] sicxegramParser.ProposicionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruccion([NotNull] sicxegramParser.InstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruccion([NotNull] sicxegramParser.InstruccionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectiva([NotNull] sicxegramParser.DirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectiva([NotNull] sicxegramParser.DirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipodirectiva([NotNull] sicxegramParser.TipodirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipodirectiva([NotNull] sicxegramParser.TipodirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.etiq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEtiq([NotNull] sicxegramParser.EtiqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.etiq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEtiq([NotNull] sicxegramParser.EtiqContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpinstruccion([NotNull] sicxegramParser.OpinstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpinstruccion([NotNull] sicxegramParser.OpinstruccionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.formato"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormato([NotNull] sicxegramParser.FormatoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.formato"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormato([NotNull] sicxegramParser.FormatoContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.f1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF1([NotNull] sicxegramParser.F1Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.f1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF1([NotNull] sicxegramParser.F1Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.f2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF2([NotNull] sicxegramParser.F2Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.f2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF2([NotNull] sicxegramParser.F2Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.f3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF3([NotNull] sicxegramParser.F3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.f3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF3([NotNull] sicxegramParser.F3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.f4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF4([NotNull] sicxegramParser.F4Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.f4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF4([NotNull] sicxegramParser.F4Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.simple3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple3([NotNull] sicxegramParser.Simple3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.simple3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple3([NotNull] sicxegramParser.Simple3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.indirecto3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndirecto3([NotNull] sicxegramParser.Indirecto3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.indirecto3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndirecto3([NotNull] sicxegramParser.Indirecto3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.inmediato3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInmediato3([NotNull] sicxegramParser.Inmediato3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.inmediato3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInmediato3([NotNull] sicxegramParser.Inmediato3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpdirectiva([NotNull] sicxegramParser.OpdirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpdirectiva([NotNull] sicxegramParser.OpdirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.consthex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConsthex([NotNull] sicxegramParser.ConsthexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.consthex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConsthex([NotNull] sicxegramParser.ConsthexContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.constcad"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstcad([NotNull] sicxegramParser.ConstcadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.constcad"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstcad([NotNull] sicxegramParser.ConstcadContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicxegramParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] sicxegramParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicxegramParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] sicxegramParser.CompileUnitContext context);
}
} // namespace Practica2LopezCastillo

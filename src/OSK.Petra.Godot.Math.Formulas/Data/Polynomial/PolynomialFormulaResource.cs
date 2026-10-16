using Godot;
using OSK.Petra.Math.Formulas;
using OSK.Petra.Math.Formulas.Polynomial;
using System;

namespace OSK.Petra.Godot.Math.Formulas.Data.Polynomial;

/// <summary>
/// Represents a formula resource that configures <see cref="PolynomialFormula"/>
/// </summary>
[GlobalClass]
[Tool]
public partial class PolynomialFormulaResource: FormulaResource
{
    #region Variables

    [Export]
    private PolynomialTermSourceResource? _term;

    #endregion

    #region FormulaResource Overrides

    /// <inheritdoc/>
    public override IFormula GetFormula()
        => _term is null
            ? throw new InvalidOperationException("Polynomial calculator requires a term resource")
            : new PolynomialFormula(_term.GetTerms());

    #endregion
}

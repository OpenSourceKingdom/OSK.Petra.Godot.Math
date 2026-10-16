using Godot;
using OSK.Petra.Math.Formulas;
using OSK.Petra.Math.Formulas.Logarithmic;

namespace OSK.Petra.Godot.Math.Formulas.Data.Logarithmic;

/// <summary>
/// Represents a formula resource that configures <see cref="LogarithmicFormula"/>
/// </summary>
[GlobalClass]
[Tool]
public partial class LogarithmicFormulaResource: FormulaResource
{
    #region Variables

    [Export]
    private double _coefficient;

    [Export]
    private double _logBase = 10;

    #endregion

    #region FormulaResource Overrides

    /// <inheritdoc/>
    public override IFormula GetFormula()
        => new LogarithmicFormula(_coefficient, _logBase);

    #endregion
}

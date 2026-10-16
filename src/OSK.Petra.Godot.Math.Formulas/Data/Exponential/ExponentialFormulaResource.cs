using Godot;
using OSK.Petra.Math.Formulas;
using OSK.Petra.Math.Formulas.Exponential;

namespace OSK.Petra.Godot.Math.Formulas.Data.Exponential;

/// <summary>
/// Represents a calculator resource that configures <see cref="ExponentialFormula"/>
/// </summary>
[GlobalClass]
[Tool]
public partial class ExponentialFormulaResource: FormulaResource
{
    #region Variables

    [Export]
    private double _constant;

    #endregion

    #region FormulaResource Overrides

    /// <inheritdoc/>
    public override IFormula GetFormula()
        => new ExponentialFormula(_constant);

    #endregion
}

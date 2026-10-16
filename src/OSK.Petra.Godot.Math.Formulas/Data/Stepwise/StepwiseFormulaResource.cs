using Godot;
using OSK.Petra.Math.Formulas;
using OSK.Petra.Math.Formulas.Stepwise;
using System.Linq;

namespace OSK.Petra.Godot.Math.Formulas.Data.Stepwise;

/// <summary>
/// Represents a formula resource that configures <see cref="StepwiseFormula"/>
/// </summary>
[GlobalClass]
[Tool]
public partial class StepwiseFormulaResource : FormulaResource
{
    #region Variables

    [Export]
    private StepResource[] _steps = [];

    #endregion

    #region FormulaResource Overrides

    /// <inheritdoc/>
    public override IFormula GetFormula()
        => new StepwiseFormula(_steps.Select(stepResource => stepResource.ToStep()));

    #endregion
}

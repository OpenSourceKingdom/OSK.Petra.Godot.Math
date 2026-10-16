using Godot;
using OSK.Petra.Math.Formulas.Stepwise;

namespace OSK.Petra.Godot.Math.Formulas.Data.Stepwise;

/// <summary>
/// Represents an inflationary step
/// </summary>
[GlobalClass]
[Tool]
public partial class StepResource: Resource
{
    #region Variables

    /// <summary>
    /// The step floor value to be considered valid to return the associated value
    /// </summary>
    [Export]
    public int Step { get; set; }

    /// <summary>
    /// The value this step returns
    /// </summary>
    [Export]
    public double Value { get; set; }

    #endregion

    #region Api

    /// <summary>
    /// Converts the resource into a useable step
    /// </summary>
    /// <returns>The converted step</returns>
    public Step ToStep()
        => new(Step, Value);

    #endregion
}

using Godot;
using OSK.Petra.Math.Formulas;

namespace OSK.Petra.Godot.Math.Formulas.Data;

/// <summary>
/// Represents a resource capable of creating various <see cref="IFormula"/>
/// </summary>
[GlobalClass]
public abstract partial class FormulaResource: Resource
{
    /// <summary>
    /// Gets the formula equvialent of the resource
    /// </summary>
    /// <returns>The configured formula</returns>
    public abstract IFormula GetFormula();
}

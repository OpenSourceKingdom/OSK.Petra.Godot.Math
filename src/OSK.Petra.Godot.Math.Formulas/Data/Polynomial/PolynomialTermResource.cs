using Godot;
using OSK.Petra.Math.Formulas.Polynomial;

namespace OSK.Petra.Godot.Math.Formulas.Data.Polynomial;

/// <summary>
/// A configurable polynomial term
/// </summary>
[GlobalClass]
[Tool]
public partial class PolynomialTermResource: Resource
{
    #region Variables

    [Export]
    private double _coefficient;

    [Export]
    private int _power;

    #endregion

    #region Helpers

    /// <summary>
    /// Converts the resource into a useable term
    /// </summary>
    /// <returns>The converted term</returns>
    public PolynomialTerm ToPolynomialTerm()
        => new(_coefficient, _power);

    #endregion
}

using Godot;
using OSK.Petra.Math.Formulas.Polynomial;
using System.Collections.Generic;
using System.Linq;

namespace OSK.Petra.Godot.Math.Formulas.Data.Polynomial;

/// <summary>
/// A polynomial source that derives its terms from a sequential coefficient power index array
/// </summary>
[GlobalClass]
[Tool]
public partial class PolynomialSequentialTermResource: PolynomialTermSourceResource
{
    #region Variables

    [Export]
    private double[] _coefficients = [];

    #endregion

    #region PolynomialTermSourceResource Overrides

    /// <inheritdoc/>
    public override IEnumerable<PolynomialTerm> GetTerms()
        => _coefficients.Select((coefficient, index) => new PolynomialTerm(coefficient, index));

    #endregion
}

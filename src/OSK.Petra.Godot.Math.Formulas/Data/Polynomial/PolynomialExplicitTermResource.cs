using Godot;
using OSK.Petra.Math.Formulas.Polynomial;
using System.Collections.Generic;
using System.Linq;

namespace OSK.Petra.Godot.Math.Formulas.Data.Polynomial;

/// <summary>
/// A polynomial source that derives its terms from an explicitly set <see cref="PolynomialTermResource"/> collection
/// </summary>
[GlobalClass]
[Tool]
public partial class PolynomialExplicitTermResource: PolynomialTermSourceResource
{
    #region Variables

    [Export]
    private PolynomialTermResource[] _terms = [];

    #endregion

    #region PolynomialTermSourceResource Overrides

    /// <inheritdoc/>
    public override IEnumerable<PolynomialTerm> GetTerms()
        => _terms.Select(term => term.ToPolynomialTerm()).GroupBy(term => term.Power).Select(termGroup => new PolynomialTerm(termGroup.Sum(term => term.Coefficient), termGroup.Key));

    #endregion
}

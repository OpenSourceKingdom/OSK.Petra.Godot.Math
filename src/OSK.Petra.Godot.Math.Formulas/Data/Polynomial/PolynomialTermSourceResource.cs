using Godot;
using OSK.Petra.Math.Formulas.Polynomial;
using System.Collections.Generic;

namespace OSK.Petra.Godot.Math.Formulas.Data.Polynomial;

/// <summary>
/// Specifies a configurable source of terms
/// </summary>
[GlobalClass]
[Tool]
public abstract partial class PolynomialTermSourceResource: Resource
{
    #region Helpers

    /// <summary>
    /// Gets the configured source of terms as a useable polynomial collection
    /// </summary>
    /// <returns>The collection of terms</returns>
    public abstract IEnumerable<PolynomialTerm> GetTerms();

    #endregion
}

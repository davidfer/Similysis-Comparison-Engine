﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Similysis
{
    /// <summary>
    /// The interface defining construction of similyzers intended to plug into the similysis engine
    /// </summary>
    interface ISimilyzer
    {
        /// <summary>
        /// Performs the comparison analysis on data submitted
        /// </summary>
        /// <returns>An XML encoded comparison report containing results, rankings, conclusions etc.</returns>
        string Evaluate();

        /// <summary>
        /// Obtains the most recent comparison report generated by this similyzer
        /// </summary>
        /// <returns>An XML encoded comparison report containing results, rankings, conclusions etc.</returns>
        string Report();

        /// <summary>
        /// Returns the current match function used in evaluation
        /// </summary>
        /// <returns></returns>
        MatchFunction MatchFunction();
    }
}

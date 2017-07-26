using System;
using Microsoft.Extensions.Logging;
using Xbim.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.TopologyResource
{
	public partial class IfcPath : IExpressValidatable
	{
		public enum IfcPathClause
		{
			IsContinuous,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPathClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPathClause.IsContinuous:
						retVal = Functions.IfcPathHeadToTail(this);
						break;
				}
			} catch (Exception ex) {
				var log = ApplicationLogging.CreateLogger<Xbim.Ifc4.TopologyResource.IfcPath>();
				log.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPath.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPathClause.IsContinuous))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPath.IsContinuous", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
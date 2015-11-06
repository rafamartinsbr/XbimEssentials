// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.TopologyResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPolyLoop
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPolyLoop : IIfcLoop
	{
		IEnumerable<IIfcCartesianPoint> @Polygon { get; }
		
	}
}

namespace Xbim.Ifc2x3.TopologyResource
{
	[ExpressType("IFCPOLYLOOP", 200)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolyLoop : IfcLoop, IInstantiableEntity, IIfcPolyLoop, IEqualityComparer<@IfcPolyLoop>, IEquatable<@IfcPolyLoop>
	{
		#region IIfcPolyLoop explicit implementation
		IEnumerable<IIfcCartesianPoint> IIfcPolyLoop.Polygon { get { return @Polygon; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolyLoop(IModel model) : base(model) 		{ 
			Model = model; 
			_polygon = new ItemSet<IfcCartesianPoint>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCartesianPoint> _polygon;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 3, -1)]
		public ItemSet<IfcCartesianPoint> @Polygon 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _polygon;
				((IPersistEntity)this).Activate(false);
				return _polygon;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_polygon == null) _polygon = new ItemSet<IfcCartesianPoint>( this );
					_polygon.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : SIZEOF(QUERY(Temp <* Polygon | Temp.Dim <> Polygon[1].Dim)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPolyLoop other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPolyLoop
            var root = (@IfcPolyLoop)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPolyLoop left, @IfcPolyLoop right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPolyLoop left, @IfcPolyLoop right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPolyLoop x, @IfcPolyLoop y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPolyLoop obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
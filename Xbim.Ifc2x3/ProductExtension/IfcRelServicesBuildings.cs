// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProductExtension;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelServicesBuildings
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelServicesBuildings : IIfcRelConnects
	{
		IIfcSystem @RelatingSystem { get; }
		IEnumerable<IIfcSpatialStructureElement> @RelatedBuildings { get; }
		
	}
}

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IFCRELSERVICESBUILDINGS", 600)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelServicesBuildings : IfcRelConnects, IInstantiableEntity, IIfcRelServicesBuildings, IEqualityComparer<@IfcRelServicesBuildings>, IEquatable<@IfcRelServicesBuildings>
	{
		#region IIfcRelServicesBuildings explicit implementation
		IIfcSystem IIfcRelServicesBuildings.RelatingSystem { get { return @RelatingSystem; } }	
		IEnumerable<IIfcSpatialStructureElement> IIfcRelServicesBuildings.RelatedBuildings { get { return @RelatedBuildings; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelServicesBuildings(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedBuildings = new ItemSet<IfcSpatialStructureElement>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcSystem _relatingSystem;
		private ItemSet<IfcSpatialStructureElement> _relatedBuildings;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSystem @RelatingSystem 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingSystem;
				((IPersistEntity)this).Activate(false);
				return _relatingSystem;
			} 
			set
			{
				SetValue( v =>  _relatingSystem = v, _relatingSystem, value,  "RelatingSystem");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcSpatialStructureElement> @RelatedBuildings 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedBuildings;
				((IPersistEntity)this).Activate(false);
				return _relatedBuildings;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingSystem = (IfcSystem)(value.EntityVal);
					return;
				case 5: 
					if (_relatedBuildings == null) _relatedBuildings = new ItemSet<IfcSpatialStructureElement>( this );
					_relatedBuildings.InternalAdd((IfcSpatialStructureElement)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelServicesBuildings other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelServicesBuildings
            var root = (@IfcRelServicesBuildings)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelServicesBuildings left, @IfcRelServicesBuildings right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelServicesBuildings left, @IfcRelServicesBuildings right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelServicesBuildings x, @IfcRelServicesBuildings y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelServicesBuildings obj)
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
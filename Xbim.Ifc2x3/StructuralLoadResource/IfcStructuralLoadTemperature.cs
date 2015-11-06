// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralLoadResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadTemperature
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadTemperature : IIfcStructuralLoadStatic
	{
		IfcThermodynamicTemperatureMeasure? @DeltaT_Constant { get; }
		IfcThermodynamicTemperatureMeasure? @DeltaT_Y { get; }
		IfcThermodynamicTemperatureMeasure? @DeltaT_Z { get; }
		
	}
}

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[ExpressType("IFCSTRUCTURALLOADTEMPERATURE", 36)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadTemperature : IfcStructuralLoadStatic, IInstantiableEntity, IIfcStructuralLoadTemperature, IEqualityComparer<@IfcStructuralLoadTemperature>, IEquatable<@IfcStructuralLoadTemperature>
	{
		#region IIfcStructuralLoadTemperature explicit implementation
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaT_Constant { get { return @DeltaT_Constant; } }	
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaT_Y { get { return @DeltaT_Y; } }	
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaT_Z { get { return @DeltaT_Z; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadTemperature(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcThermodynamicTemperatureMeasure? _deltaT_Constant;
		private IfcThermodynamicTemperatureMeasure? _deltaT_Y;
		private IfcThermodynamicTemperatureMeasure? _deltaT_Z;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @DeltaT_Constant 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _deltaT_Constant;
				((IPersistEntity)this).Activate(false);
				return _deltaT_Constant;
			} 
			set
			{
				SetValue( v =>  _deltaT_Constant = v, _deltaT_Constant, value,  "DeltaT_Constant");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @DeltaT_Y 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _deltaT_Y;
				((IPersistEntity)this).Activate(false);
				return _deltaT_Y;
			} 
			set
			{
				SetValue( v =>  _deltaT_Y = v, _deltaT_Y, value,  "DeltaT_Y");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @DeltaT_Z 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _deltaT_Z;
				((IPersistEntity)this).Activate(false);
				return _deltaT_Z;
			} 
			set
			{
				SetValue( v =>  _deltaT_Z = v, _deltaT_Z, value,  "DeltaT_Z");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_deltaT_Constant = value.RealVal;
					return;
				case 2: 
					_deltaT_Y = value.RealVal;
					return;
				case 3: 
					_deltaT_Z = value.RealVal;
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
        public bool Equals(@IfcStructuralLoadTemperature other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLoadTemperature
            var root = (@IfcStructuralLoadTemperature)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLoadTemperature left, @IfcStructuralLoadTemperature right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadTemperature left, @IfcStructuralLoadTemperature right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralLoadTemperature x, @IfcStructuralLoadTemperature y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralLoadTemperature obj)
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
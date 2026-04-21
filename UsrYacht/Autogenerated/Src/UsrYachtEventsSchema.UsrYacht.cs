namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("369cf915-71a1-48c6-b5f8-45039e8a9c9f");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b6da8ce-d4ed-4176-8e2f-b19666b88cfa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,111,107,219,48,16,198,223,23,250,29,14,191,178,33,136,246,109,187,21,150,52,45,133,178,141,217,25,140,177,23,138,124,113,84,244,199,72,114,186,108,244,187,239,36,37,109,234,116,208,131,16,235,244,232,119,247,28,103,184,70,223,115,129,208,160,115,220,219,85,96,51,107,86,178,27,28,15,210,154,211,147,191,167,39,64,49,120,105,58,168,183,62,160,190,60,76,29,62,212,218,154,255,94,58,100,115,19,100,144,232,223,163,97,243,13,154,176,151,254,76,233,109,202,221,75,106,194,160,43,107,177,70,205,63,147,7,248,8,197,194,187,31,92,172,67,81,253,202,111,250,97,169,164,0,161,184,247,144,174,222,128,192,5,76,185,199,55,110,50,100,103,255,128,103,55,212,176,108,17,54,86,182,240,197,212,124,67,54,74,187,124,64,17,192,163,105,209,77,32,3,167,184,34,79,9,251,201,117,30,176,122,193,29,144,99,44,169,11,246,76,219,99,176,186,124,45,203,92,216,70,59,228,186,204,231,42,235,71,218,22,133,212,92,65,239,164,136,35,74,143,216,45,134,102,219,99,59,179,106,208,230,59,87,3,126,216,41,175,202,56,197,175,81,94,140,11,203,21,148,25,116,5,231,103,41,170,215,138,145,161,24,200,238,252,140,27,129,10,91,106,32,184,1,9,123,172,243,193,197,85,160,101,244,188,195,6,117,175,120,136,45,27,124,132,123,43,184,146,127,248,82,97,157,116,101,54,178,240,232,104,89,13,141,157,54,149,125,67,111,7,39,72,99,29,65,38,199,85,98,60,175,73,94,175,98,2,197,17,223,179,52,149,59,223,88,59,149,93,62,21,21,107,236,174,126,245,14,19,212,124,78,176,27,235,52,15,229,200,28,21,62,7,26,98,250,45,234,235,163,129,199,8,107,103,31,211,16,230,191,5,246,209,231,158,51,150,63,189,28,119,159,244,247,244,15,22,31,23,130,225,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bfe175c1-0d17-a0d2-bc49-ee24a0366db7"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("6b6da8ce-d4ed-4176-8e2f-b19666b88cfa"),
				CreatedInSchemaUId = new Guid("369cf915-71a1-48c6-b5f8-45039e8a9c9f"),
				ModifiedInSchemaUId = new Guid("369cf915-71a1-48c6-b5f8-45039e8a9c9f")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("369cf915-71a1-48c6-b5f8-45039e8a9c9f"));
		}

		#endregion

	}

	#endregion

}


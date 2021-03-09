using System;

using SuperOffice;

using SuperOffice.Data;

using SuperOffice.Data.Meta;

using SuperOffice.Data.SQL;

using SuperOffice.HDB.Util;

using System.Text.RegularExpressions;

using System.Diagnostics;

using System.Collections.Generic;

 

namespace DevNet.Util

{

    ///

    /// User-Defined Field Lookup Class

    ///

    publicsealedclassUDFHelper

    {

        #region Private Members

 

        privatestaticvolatileUDFHelper instance;

        privateUserPreferenceTableInfo userPrefTbl;

        privateUDefFieldTableInfo udfTbl;

        privatestaticobject syncRoot = newObject();

        privateSoConnection con = null;

        privateSoCommand cmd = null;

 

        #endregion

 

        #region Ctor, Accessor, SyncRoot

        private UDFHelper()

        {

            userPrefTbl = TablesInfo.GetUserPreferenceTableInfo();

            udfTbl = TablesInfo.GetUDefFieldTableInfo();

        }

 

        ///

        /// Main entry point to methods.

        ///

        publicstaticUDFHelper Instance

        {

            get

            {

                if (instance == null)

                {

                    lock (syncRoot) { if (instance == null) instance = newUDFHelper(); }

                }

 

                return instance;

            }

        }

 

        ///

        /// Gets an object that can be used to synchronize access to the UDFHelper.

        ///

        publicstaticobject SyncRoot

        {

            get { return syncRoot; }

        }

        #endregion

 

        #region Public Methods

 

        #region Get Operations

 

        ///

        /// Gets the value of the user-defined field. (High Performance) REQUIRED TO

        /// CALL: GetUDFInfo(SuperOffice.HDB.Util.EUDefType entityTable,

        /// string udFieldName) FIRST!!!  (To populate the entity and UDF FieldInfo

        /// objects in the returned UDFInfo struct.

        ///

        /// UDFInfo struct that is prepopulated with Entity

        /// FieldInfo, Entity Identity, and User-Defined FieldInfo objects.

        ///UDFInfo that contains the value of the user defined        
        ///field.

        publicUDFInfo GetUDFInfo(UDFInfo properties)

        {

            return GetUDFInfo(properties.EntityId, properties.UDFieldName,

                properties.EntityField, properties.UsrDefField);

        }

 

        ///

        /// Gets the value of the user-defined field, of type Drop-Down List. (For

        /// High Performance) REQUIRED TO CALL: GetUDFInfo(

        /// SuperOffice.HDB.Util.EUDefType entityTable, string udFieldName) FIRST!!!

        /// (To populate the entity and UDF FieldInfo objects in the returned UDFInfo

        /// struct.

        ///

        /// UDFInfo struct that is prepopulated with Entity

        /// FieldInfo, Entity Identity, and User-Defined FieldInfo objects.

        ///When Type of a user-defined field is Drop 
        ///Down

        /// List, this argument should match the List name.

        ///UDFInfo that contains the value of the user defined 
        ///field.

        publicUDFInfo GetUDFInfo(UDFInfo properties, 
                                               UDFHelper.ListItemSource listSource)

        {

            return GetUDFInfo(properties.EntityId, properties.UDFieldName,

                properties.EntityField, properties.UsrDefField, listSource);

        }

 

        ///

        /// Gets a UDFInfo structure with all of the objects necessary to conduct one or more UDF lookups.

        /// Calling this before GetUdfField is favorable towards performance.

        ///

        ///The main entity table that contains the user-defined field. For example, Appointment or Contact

        ///The name of the user-defined field.

        ///UDFInfo struct, which contains all information about the user-defined field, and parent tables.

        ///

        publicUDFInfo GetUDFInfo(SuperOffice.HDB.Util.EUDefType entityTable,

            string udFieldName)

        {

            AssertNotNull(udFieldName, "udFieldName");

 

            UDFInfo properties;

            FieldInfo udfField = null;

            FieldInfo entField = null;

 

            int colId = GetUDFColumnID(entityTable, udFieldName);

            int tableNumber = colId >> 8;

 

            if (colId > 0)

            {

                udfField = GetSoField(tableNumber, colId, out entField);

 

                if (udfField != null && entField != null)

                {

                    return properties = newUDFInfo(entField, udfField, udFieldName);

                }

            }

            returnnewUDFInfo();

        }

 

        ///

        /// Gets the value of a user-defined field.

        ///

        ///The main entity table that contains the user-defined

        /// field. For example,  Appointment or Contact

        ///The row, or record, identity of the entity.

        ///The name of the user-defined field.

        ///UDFInfo struct, which contains all information about the user-defined

        /// field, and parent tables.

        ///

        publicUDFInfo GetUDFInfo(SuperOffice.HDB.Util.EUDefType entityTable,
            int entityId, string udFieldName)

        {

            AssertNotNull((Nullable<>int>)entityId, "entityId");

            //The following check is done in GetUDFInfo, therefore commented out here.

            //AssertNotNull(udFieldName, "udFieldName");

 

            UDFInfo info = GetUDFInfo(entityTable, udFieldName);

 

            info.EntityId = entityId;

 

            if (info.UsrDefField != null)

            {

                object[] obj = null;

 

                obj = (object[])GetUDFData(
                                       info.EntityId, info.UsrDefField, info.EntityField);

 

                if (obj != null) //No such field found, return an empty struct which gives

                                //empty string as FieldValue

                {

                    info.UDFieldValue = obj[0];

                    info.UsrDefId = Convert.ToInt32(obj[1]);

                }

            } // Could throw exception is UDF is not found.

            return info;

        }

 

        ///

        /// Gets the value of a user-defined field.

        ///

        ///The main entity table that contains the user-defined field. For example,  Appointment or Contact

        ///The row, or record, identity of the entity.

        ///The name of the user-defined field.

        ///When Type of a user-defined field is Drop Down List, this argument should match the List name.

        ///UDFInfo struct, which contains all information about the user-defined field, and parent tables.

        ///

        ///When user attempt to query for list item, but field name refers to non-list user-defined field.

        publicUDFInfo GetUDFInfo(SuperOffice.HDB.Util.EUDefType entityTable, 
                 int entityId, string udFieldName, ListItemSource listSource)

        {

            UDFInfo info = GetUDFInfo(entityTable, entityId, udFieldName);

            return GetUDFInfo(entityId, udFieldName, info.EntityField,
                                          info.UsrDefField, listSource);

        }

 

        ///

        /// Gets the value of the user-defined field.  (High Performance) Recommend 
        ///calling the following overload first,

        /// to get the FieldInfo objects needed to complete the query:

        /// GetUDFInfo(SuperOffice.HDB.Util.EUDefType entityTable, string udFieldName).

        /// (To populate the entity and UDF FieldInfo objects in the returned UDFInfo struct.

        ///The row, or record, identity of the entity.

        ///The name of the user-defined field, as defined in the Admin

        /// application. This argument only exists as to be copied into the returned UDInfo struct.

        ///FieldInfo object that is udField in the entity table

        /// userdef_id in ContactTableInfo.

        ///FieldInfo object that is the column in the user-defined table

        /// (for example long05, string05).

        ///UDFInfo struct, which contains all information about the user-defined field, and parent tables.

        publicUDFInfo GetUDFInfo(int entityId, string udFieldName,
            FieldInfo entityField, FieldInfo udField)

        {

            UDFInfo info = newUDFInfo(entityField, udField, udFieldName);

 

            AssertNotNull(entityField, "entityUDF");

            AssertNotNull(udField, "udField");

            AssertNotNull((Nullable<>int>)entityId, "entityId");

 

            Select select = S.NewSelect();

            select.ReturnFields.Add(udField, entityField);

 

            select.JoinRestriction.InnerJoin(entityField.Equal(udField.Parent.All[0]));

            select.Restriction = entityField.Parent.All[0].Equal(S.Parameter(entityId));

 

            object[] obj = (object[])ExecuteQuery(select, QueryType.ReaderPlus);

 

            if (obj != null) //No such field found, return an empty struct which gives 
                                 //empty string as FieldValue

            {

                info.UDFieldValue = obj[0];

                info.UsrDefId = Convert.ToInt32(obj[1]);

            }

 

            return info;

        }

 

        ///

        /// Gets the value of a user-defined field. (High Performance) Recommend 
        ///calling the following overload first,

        /// to get the FieldInfo objects needed to complete the query:

        /// GetUDFInfo(SuperOffice.HDB.Util.EUDefType entityTable, string udFieldName).

        /// (To populate the entity and UDF FieldInfo objects in the returned UDFInfo struct.

        ///

        ///The row, or record, identity of the entity.

        ///The name of the user-defined field, as defined in the Admin

        /// application.

        /// This argument only exists as to be copied into the returned UDInfo struct.

        ///FieldInfo object that is udField in the entity table

        /// userdef_id in ContactTableInfo.

        ///FieldInfo object that is the column in the user-defined table

        /// (for example long05, string05).

        ///When Type of a user-defined field is Drop Down List, this argument should match the List name.

        ///UDFInfo struct, which contains all information about the user-defined field, and parent tables.

        publicUDFInfo GetUDFInfo(int entityId, string udFieldName,
            FieldInfo entityField, FieldInfo udField, ListItemSource listSource)

        {

 

            UDFInfo info = newUDFInfo(entityField, udField, udFieldName, entityId);

 

            object[] obj = (object[])GetUDFData(
                                    info.EntityId, info.UsrDefField, info.EntityField);

 

            if (info.EntityField == null || info.UsrDefField == null)

                thrownewApplicationException("Unknown user-defined field.");

 

            if(obj == null)

                return info; // throw new ApplicationException("Unable to get UDF base on

                                 //supplied information.");

 

            info.UsrDefId = (int)obj[1];

 

            TableInfo searchTable = null;

 

            Select select = S.NewSelect();

 

            searchTable = GetSearchTableInfo(listSource);

 

            try

            {

                //select.ReturnFields.Add(searchTable.FindField("name"));

                //Seems to always be the second field (index = 1).

                select.ReturnFields.Add(searchTable.All[1]);

                select.Restriction = searchTable.All[0].Equal(S.Parameter((int)obj[0]));

 

                info.UDFieldValue = ExecuteQuery(select, QueryType.Reader);

            }

            catch (InvalidCastException ex)

            {

                thrownewApplicationException(

                    @"Can not query user-defined field. " +

                    @"Do not use the overload that includes the ListItemSource for " +
                    @"general user-defined fields. You only use this overload when the "+

                    @"UD field is a Type of Drop-Down list, that lookups up values in a " +

                    @"user-defined list.", ex);

            }

 

            return info;

        }

 

        #endregion

 

        #region Set Operations

 

        ///

        /// Sets a user-defined field. Should be used after GetUDFInfo has been called.

        /// Make sure to set the FieldValue before calling this method.

        ///

        ///UDFInfo object that contains both Entity and 
        ///User-Defined

        /// FieldInfo objects (Retreived by first populating a UDFIndo struct by using the

        /// method. Make sure to set the FieldValue before 
        ///calling this method.

        ///Return 1 if the value was updated. Returns 2 is the field was new 
        ///and required an insert. Otherwise 0.

        publicint SetUDFValue(UDFInfo properties)

        {

            //Do not check nulls here because they are done in the overload.

            return SetUDFValue(properties.EntityId, properties.UsrDefField,

                properties.EntityField, properties.UDFieldValue);

        }

 

        ///

        /// Sets the value of the specified user-defined field.

        ///

        ///The entity table that contains the user-defined
        ///field.

        ///The identity of the entity that contains the user-
        ///defined field.

        ///The field lable, or name, as defined in the 
        ///admin application.

        ///The new value of the user-defined 
        ///field.

        ///Return 1 if the value was updated. Returns 2 is the field was new 
        ///and required an insert. Otherwise 0.

        publicint SetUDFValue(EUDefType entityTable, int entityId,
                                string udFieldName, T udFieldValue)

        {

            AssertNotNull((Nullable<>int>)entityId, "entityId");

            AssertGenericArgumentNotNull(udFieldValue, "udFieldValue");

            //The following check is done in GetUDFInfo, therefore commented out here.

            //AssertNotNull(udFieldName, "udFieldName");

 

            UDFInfo info = GetUDFInfo(entityTable, udFieldName);

 

            return SetUDFValue(entityId, info.UsrDefField, info.EntityField, udFieldValue);

        }

 

        ///

        /// Sets a user-defined field. Should be used after GetUDFInfo has been called.

        /// Make sure to set the FieldValue before calling this method.

        ///

        ///Must be an Integer, Long, or String 
        ///type.

        ///The identity of the entity that contains the

        /// user-defined field.

        ///The user-defined FieldInfo object (for example 
        ///UDContactSmall.long05,

        /// string05).

        ///The entirt user-defined FieldInfo object (for example

        /// Contact.userdef_id, Contact.userdef_id2).

        ///The new value of the user-defined 
        ///field.

        ///Return 1 if the value was updated. Returns 2 is the field was new 
        ///and required an insert. Otherwise 0.

        publicint SetUDFValue(int entityIdentity, FieldInfo udfField,

            FieldInfo entityField, T udFieldValue)

        {

            AssertNotNull(entityField, "entityField");

            AssertNotNull(udfField, "udfField");

            AssertNotNull((Nullable<>int>)entityIdentity, "entityIdentity");

            AssertGenericArgumentNotNull(udFieldValue, "udFieldValue");

 

            object[] obj = null;

 

            if ((obj = (object[])GetUDFData(entityIdentity, udfField, entityField)) != null)

                return PerformUpdate(udfField, Convert.ToInt32(obj[1]), udFieldValue);

            else

                return PerformInsert(udfField, udFieldValue, entityField, entityIdentity);

        }

 

        #endregion

 

        #region Search Operations

        ///

        /// UDFSearch queries the entity tables user-defined field for the

        ///.

        ///

        ///Can be any type, for example string, int, double.

        ///The db entity (Appointment, Contact, Person) that links in the user-defined field.

        ///Then user-defined field label, or name,  specified in the admin application.

        ///The value of the user-defined field to search 
        ///for

        ///An integer array of entity IDs that contain the user-defined field of the specified value.

        ///Thrown when one of the arguments are null.

        ///Thrown when a user-defined field is not found, for example udFieldName

        /// can not be found in the database.

        ///

        /// int[] i = UDFHelper.Instance.UDFSearch(
        ///                                      EUDefType.Appnt, "Tekstfelt", "Interesting");

        /// int[] j = UDFHelper.Instance.UDFSearch(
        ///                                      EUDefType.Contact, "NewestUDField", 7);

        /// int[] k = UDFHelper.Instance.UDFSearch(
        ///                                      EUDefType.Contact, "Company ShortName",

        ///                                      new string[] { "Coords", "Fran" });

        ///

        ///

        /// If is an Array, the default Operation is 
        ///an In(,...) operation.

        ///

        publicint[] UDFSearch(SuperOffice.HDB.Util.EUDefType entityTable,

            string udFieldName, T searchValue)

        {

            AssertNotNull(udFieldName, "udFieldName");

            AssertGenericArgumentNotNull(searchValue, "searchValue");

 

            //Get the FieldInfo objects for both UDF (UDAppntSmall.string05) and Entity

            //(Appointment.userdef_id)

            UDFInfo info = GetUDFInfo(entityTable, udFieldName);

 

            if (info.EntityField == null || info.UsrDefField == null)

                thrownewApplicationException(

                    string.Format("Unable to find user-defined field: {0}, therefore search "                                                     + "for {1} can not continue.",

                    udFieldName, searchValue));

 

            //Select all rows where UDF equals searchValue

            Select select = S.NewSelect();

            select.ReturnFields.Add(info.UsrDefField.Parent.All[0]);

 

            if (searchValue.GetType().IsArray)

            {

                Argument[] argArr = GetArguments(
                                                     searchValue, info.UsrDefField.DataType);

                select.Restriction = info.UsrDefField.In(argArr);

            }

            else

                select.Restriction = info.UsrDefField.Equal(S.Parameter(searchValue,

                    info.UsrDefField.DataType));

 

            return DoSearchQuery(info, select);

        }

 

        ///

        /// UDFSearch queries the entity tables user-defined field for the searchValue.

        ///

        ///Can be any type, for example string, int, double, or an 
        ///array of types that match the operation.

        ///The db entity (Appointment, Contact, Person, that links in the user-defined field.

        ///Then user-defined field label, or name, specified in the admin application.

        ///The value of the user-defined field to search for.

        ///The type of search operation to 
        ///perform.

        ///An integer array of entity IDs that contain the user-defined field of

        /// the specified value.

        ///Thrown when one of the 
        ///argumentsare null.

        ///Thrown when a user-
        ///defined field is not found, for example udFieldName

        /// can not be found in the database.

        ///

        /// int[] a = UDFHelper.Instance.UDFSearch(EUDefType.Contact, "Start Date",

        /// new int[] { 1097107200, 1098144000 }, UDFHelper.Operation.Between);

        /// int[] j = UDFHelper.Instance.UDFSearch(EUDefType.Contact, 
        ///"NewestUDField", 7);

        ///

        ///

        /// If is an Array, the default Operation 
        ///is anIn(,...) operation.

        ///

        publicint[] UDFSearch(SuperOffice.HDB.Util.EUDefType entityTable,

            string udFieldName, T searchValue, Operation operation)

        {

            AssertNotNull(udFieldName, "udFieldName");

            if (operation != (Operation.IsNotNull | Operation.IsNull))

                AssertGenericArgumentNotNull(searchValue, "searchValue");

 

            //Get the FieldInfo objects for both UDF (UDAppntSmall.string05) and Entity

            //(Appointment.userdef_id)

            UDFInfo info = GetUDFInfo(entityTable, udFieldName);

 

            if (info.EntityField == null || info.UsrDefField == null)

                thrownewApplicationException(string.Format(

  "Unable to find user-defined field: {0}, therefore search for {1} can not continue.",

                    udFieldName, searchValue));

 

            //Select all rows where UDF equals searchValue

            Select select = S.NewSelect();

            select.ReturnFields.Add(info.UsrDefField.Parent.All[0]);

            select.Restriction =
                 GetSearchRestriction(info.UsrDefField, searchValue, operation);

 

            return DoSearchQuery(info, select);

 

        }

 

        #endregion

 

        #region Helper Methods

        ///

        /// Returns the string part of the specified culture from the multi language string

        /// These strings are typically used in SuperOffice list and description data

        ///

        /// String example from PrefDesc table:

        /// US:"Location and size";GE:"Position und Größe";NO:"Posisjon og størrelse"

        ///

        ///

        ///The multilanguage string to 
        ///parse

        ///The culturename, typically en-US, nb-NO, 
        ///but also US, NO is accepted

        ///Culture specific string part

        publicstring ParseMultiLanguageString(string multilangString,
                                                                string culturename)

        {

            string langName = string.Empty;

            if (culturename.Length == 0)

                langName = "US"; //Defaults to english

            elseif (culturename.Length == 2)

                langName = culturename;

            else

                langName = culturename.Substring(3).ToUpper();

 

            Regex regex = newRegex(@".*" + langName + @":\""([^\""]*)",
                               RegexOptions.IgnoreCase);

            Match match = regex.Match(multilangString);

 

            Debug.Assert(match != null);

 

            if (match.Success)

                return match.Groups[1].Value;

            else

                returnstring.Empty;

        }

        #endregion

 

        #endregion

 

        #region Private Methods

 

        privateint[] DoSearchQuery(UDFInfo info, Select select)

        {

            int[] i = (int[])ExecuteQuery(select, QueryType.ReaderLoop);

 

            if (i.Length > 0)

            {

                Argument[] args = newArgument[i.Length];

                for (int j = 0; j < i.Length; j++)

                {

                    args[j] = S.Parameter(i[j]);

                }

 

                select = S.NewSelect();

                select.ReturnFields.Add(info.EntityField.Parent.All[0]);

                select.Restriction = info.EntityField.In(args);

 

                i = (int[])ExecuteQuery(select, QueryType.ReaderLoop);

 

                return i;

            }

 

            returnnewint[0];

        }

 

        ///

        /// Gets the string representation of the user-defined table enumeration.

        ///

        ///SuperOffice.HDB.Util.EUDefType enum 
        ///value.

        ///String representation of the user-defined table 
        ///enumeration

        privatestring GetTableName(SuperOffice.HDB.Util.EUDefType ownerTableId)

        {

            if (ownerTableId == SuperOffice.HDB.Util.EUDefType.Appnt)
                 return"Appointment";

            elseif (ownerTableId == SuperOffice.HDB.Util.EUDefType.Doc)
                 return"Document";

            elsereturn ownerTableId.ToString();

        }

 

        ///

        /// Gets the version value for the specified table name.

        ///

        ///Main entity table name.

        ///The value of the version for the specified table name.

        privateint GetVersion(string tableName)

        {

            Select select = S.NewSelect();

            select.ReturnFields.Add(userPrefTbl.Prefvalue);

            select.Restriction =
                userPrefTbl.Prefsection.Equal(S.Parameter("System")).And(

                userPrefTbl.Prefkey.Equal(S.Parameter(tableName)));

            returnConvert.ToInt32(ExecuteQuery(select, QueryType.Scalar));

        }

 

 

        ///

        /// This method is used to retrieve the column if for a specific user-defined 
        ///field.

        ///

        ///The entity that contains the user-defined 
        ///field.

        ///The name of the user-defined field.

        ///The column identity of the supplied user-defined field.

        publicint GetUDFColumnID(SuperOffice.HDB.Util.EUDefType ownerTableId,
                         string fieldName)

        {

            AssertNotNull(fieldName, "fieldName");

 

            string tableName = 
            string.Concat("CurrentUdefVersion", GetTableName(ownerTableId));

            int version = GetVersion(tableName);

            int columnId = GetColumnId(version, ownerTableId, fieldName);

            return columnId;

        }

 

        ///

        /// Gets the value of the user-defined field. Called after GetUDFInfo.

        ///

        ///The identity value that corresponds to the 
        ///main entity

        /// table record.

        ///FieldInfo object that is the column in the user-
        ///defined table

        /// (for example long05, string05).

        ///FieldInfo object that is udField in the entity 
        ///table, for example, userdef_id in ContactTableInfo.

        ///Two element Object array. One element for the user-defined field 
        ///value, and one element for the udf row id.

        publicobject GetUDFData(int entityIdentity, FieldInfo udField,
                           FieldInfo entityField)

        {

            AssertNotNull((Nullable<>int>)entityIdentity, "entityIdentity");

            AssertNotNull(udField, "udfField");

            AssertNotNull(entityField, "entityField");

 

            Select select = S.NewSelect();

            select.ReturnFields.Add(udField, entityField);

 

            select.JoinRestriction.InnerJoin(entityField.Equal(udField.Parent.All[0]));

            select.Restriction =
                      entityField.Parent.All[0].Equal(S.Parameter(entityIdentity));

 

            return ExecuteQuery(select, QueryType.ReaderPlus);

        }

 

        ///

        /// Gets the column identity value for the specified user-defined field label.

        ///

        ///Value of the entity table version.

        ///SuperOffice.HDB.Util.EUDefType enum
        ///value.

        ///The field lable text.

        ///Column Integer of user-defined field label.

        privateint GetColumnId(int iVer,
              SuperOffice.HDB.Util.EUDefType ownerTableId, string fieldLabel)

        {

            Select select = S.NewSelect();

            select.ReturnFields.Add(udfTbl.ColumnId);

            select.Restriction = udfTbl.Version.Equal(S.Parameter(iVer))

                .And(udfTbl.OwnerTableId.Equal(S.Parameter((int)ownerTableId)))

                .And(udfTbl.FieldLabel.Equal(S.Parameter(fieldLabel))

                .Or(udfTbl.FieldLabel.Equal(S.Parameter(string.Concat(fieldLabel, ":")))));

            returnConvert.ToInt32(ExecuteQuery(select, QueryType.Scalar));

        }

 

        ///

        /// The magic. Gets the user-defined field as a FieldInfo object.

        ///

        ///The table number that corresponds to one of the 
        ///user-defined

        /// entity tables, for example 35 (UDContactSmall)

        ///The column number that is the field index (offset)
        ///in the user-defined entity table.

        ///FieldInfo object that becomes the entity field,
        ///  for exampleuserdef_id or userdef2_id.

        ///FieldInfo object that is the user-defined field index in the user-
        ///defined entity table, e.g long01 or string05.

        privateFieldInfo GetSoField(int tableId, int columId, outFieldInfo entityField)

        {

            FieldInfo srchField = null;

            TableInfo uDefTable = null;

            TableInfo entityTbl = null;

 

            entityField = null;

 

            switch (tableId)

            {

                case 230: //uddocsmall:

                    uDefTable = TablesInfo.GetUDDocSmallTableInfo();

                    entityTbl = TablesInfo.GetDocumentTableInfo();

                    break;

                case 231: //uddoclarge:

                    uDefTable = TablesInfo.GetUDDocLargeTableInfo();

                    entityTbl = TablesInfo.GetDocumentTableInfo();

                    break;

                case 158: //udsalesmall:

                    uDefTable = TablesInfo.GetUDSaleSmallTableInfo();

                    entityTbl = TablesInfo.GetSaleTableInfo();

                    break;

                case 159: //udsalelarge:

                    uDefTable = TablesInfo.GetUDSaleLargeTableInfo();

                    entityTbl = TablesInfo.GetSaleTableInfo();

                    break;

                case 228: //udappntsmall:

                    uDefTable = TablesInfo.GetUDAppntSmallTableInfo();

                    entityTbl = TablesInfo.GetAppointmentTableInfo();

                    break;

                case 229: //udappntlarge:

                    uDefTable = TablesInfo.GetUDAppntLargeTableInfo();

                    entityTbl = TablesInfo.GetAppointmentTableInfo();

                    break;

                case 140: //udpersonsmall:

                    uDefTable = TablesInfo.GetUDPersonSmallTableInfo();

                    entityTbl = TablesInfo.GetPersonTableInfo();

                    break;

                case 141: //udpersonlarge:

                    uDefTable = TablesInfo.GetUDPersonLargeTableInfo();

                    entityTbl = TablesInfo.GetPersonTableInfo();

                    break;

                case 35: //udcontactsmall:

                    uDefTable = TablesInfo.GetUDContactSmallTableInfo();

                    entityTbl = TablesInfo.GetContactTableInfo();

                    break;

                case 36: //udcontactlarge:

                    uDefTable = TablesInfo.GetUDContactLargeTableInfo();

                    entityTbl = TablesInfo.GetContactTableInfo();

                    break;

                case 142: //udprojectsmall:

                    uDefTable = TablesInfo.GetUDProjectSmallTableInfo();

                    entityTbl = TablesInfo.GetProjectTableInfo();

                    break;

                case 143: //udprojectlarge:

                    uDefTable = TablesInfo.GetUDProjectLargeTableInfo();

                    entityTbl = TablesInfo.GetProjectTableInfo();

                    break;

                default:

                    break;

            }

 

            srchField = uDefTable.All[columId % (tableId * 256)];

 

            if (uDefTable.TableName.ToLower().Contains("small")) entityField =

                entityTbl.FindField("userdef_id");

            else entityField = entityTbl.FindField("userdef2_id");

 

            return srchField;

        }

 

        privateTableInfo GetSearchTableInfo(ListItemSource listSource)

        {

            switch (listSource)

            {

                caseListItemSource.AcademicTitle:

                    returnTablesInfo.GetSalutationTableInfo();

                caseListItemSource.AmountClass:

                    returnTablesInfo.GetAmountClassTableInfo();

                caseListItemSource.Business:

                    returnTablesInfo.GetBusinessTableInfo();

                caseListItemSource.Category:

                    returnTablesInfo.GetCategoryTableInfo();

                caseListItemSource.CompanyInterest:

                    returnTablesInfo.GetContIntTableInfo();

                caseListItemSource.Competitor:

                    returnTablesInfo.GetComptrTableInfo();

                caseListItemSource.ContactInterest:

                    returnTablesInfo.GetPersIntTableInfo();

                caseListItemSource.Country:

                    returnTablesInfo.GetCountryTableInfo();

                caseListItemSource.Credited:

                    returnTablesInfo.GetCreditedTableInfo();

                caseListItemSource.Currency:

                    returnTablesInfo.GetCurrencyTableInfo();

                caseListItemSource.Function:

                    returnTablesInfo.GetPMembTypeTableInfo();

                caseListItemSource.Intent:

                    returnTablesInfo.GetIntentTableInfo();

                caseListItemSource.MrMrs:

                    returnTablesInfo.GetMrMrsTableInfo();

                caseListItemSource.Position:

                    returnTablesInfo.GetPersPosTableInfo();

                caseListItemSource.Priority:

                    returnTablesInfo.GetPriorityTableInfo();

                caseListItemSource.Rating:

                    returnTablesInfo.GetProbTableInfo();

                caseListItemSource.Reason:

                    returnTablesInfo.GetReasonTableInfo();

                caseListItemSource.Rejection:

                    returnTablesInfo.GetRejectReasonTableInfo();

                caseListItemSource.Relation:

                    returnTablesInfo.GetRelationDefinitionTableInfo();

                caseListItemSource.Associate:

                caseListItemSource.Resource:

                    returnTablesInfo.GetAssociateTableInfo();

                caseListItemSource.Source:

                    returnTablesInfo.GetSourceTableInfo();

                caseListItemSource.Status:

                    returnTablesInfo.GetProjStatusTableInfo();

                caseListItemSource.Template:

                    returnTablesInfo.GetDocTmplTableInfo();

                caseListItemSource.TypeFollowUp:

                    returnTablesInfo.GetTaskTableInfo();

                caseListItemSource.TypeProject:

                    returnTablesInfo.GetProjTypeTableInfo();

                caseListItemSource.TypeSelection:

                    returnTablesInfo.GetSearchCatTableInfo();

                caseListItemSource.UserDefined:

                    returnTablesInfo.GetUDListTableInfo();

                caseListItemSource.UserGroup:

                    returnTablesInfo.GetUserGroupTableInfo();

                default:

                    thrownewArgumentException(string.Format(

                        "{0} is an unknown ListItemSource.", listSource.ToString()));

            }

        }

 

 

        ///

        /// Helper method to submit SODBIF query to SuperOffice database.

        ///

        ///The SODBIF Select object that is the 
        ///query.

        ///A local enumeration to determine whether to 
        ///execute a Scalar or Reader command.

        ///Object result of the Select query.

        privateobject ExecuteQuery(Select select, QueryType qType)

        {

            using (con = ConnectionFactory.GetConnection())

            {

                using (cmd = con.CreateCommand())

                {

                    cmd.SqlCommand = select;

                    con.Open();

 

                    switch (qType)

                    {

                        caseQueryType.Scalar:

                            return cmd.ExecuteScalar();

 

                        caseQueryType.Reader:

 

                            object obj = null;

 

                            using (SoDataReader reader =

                                cmd.ExecuteReader(
                                         System.Data.CommandBehavior.CloseConnection))

                            {

                                if (reader != null && reader.Read())

                                {

                                    obj = reader.GetValue(0);

                                    reader.Close();

                                }

                            }

 

                            return obj;

 

                        caseQueryType.ReaderPlus:

 

                            object[] objArr = null;

 

                            using (SoDataReader reader =

                                cmd.ExecuteReader(
                                         System.Data.CommandBehavior.CloseConnection))

                            {

                                if (reader != null && reader.Read())

                                {

                                    objArr = newobject[2];

                                    objArr[0] = reader.GetValue(0);

                                    objArr[1] = reader.GetValue(1);

                                    reader.Close();

                                }

                            }

 

                            return objArr;

 

                        caseQueryType.ReaderLoop:

 

                            List<>int> temp = newList<>int>();

 

                            using (SoDataReader reader =

                                cmd.ExecuteReader(
                                         System.Data.CommandBehavior.CloseConnection))

                            {

                                while (reader.Read())

                                {

                                    temp.Add(reader.GetInt32(0));

                                }

                                reader.Close();

                            }

 

                            return temp.ToArray();

 

                        default:

                            break;

                    }

                    if (((System.Data.IDbConnection)con).State 
                                         == System.Data.ConnectionState.Open)

                        con.Close();

                }

            }

            returnnull;

        }

 

        privateRestriction GetSearchRestriction(FieldInfo fieldInfo, T searchValue,

            Operation operation)

        {

            Restriction restriction = null;

            Argument[] args = null;

           

                string errorMessage = string.Format(

                "Unable to conduct {0} query do to invalid arguments.",
                 operation.ToString());

 

            switch (operation)

            {

                caseOperation.Between:

                    if (searchValue.GetType().IsArray)

                    {

                        args = GetArguments(searchValue, fieldInfo.DataType);

                        if (args != null && args.Length == 2)

                            restriction = fieldInfo.Between(args[0], args[1]);

                        else

                            thrownewApplicationException(errorMessage);

                    }

                    else

                        thrownewApplicationException(errorMessage);

                    break;

 

                caseOperation.Equal:

                    if (!searchValue.GetType().IsArray)

                        restriction = fieldInfo.Equal(S.Parameter(searchValue,

                            fieldInfo.DataType));

                    else

                        thrownewApplicationException(errorMessage);

                    break;

 

                caseOperation.GreaterThan:

                    if (!searchValue.GetType().IsArray)

                        restriction = fieldInfo.GreaterThan(S.Parameter(searchValue,

                            fieldInfo.DataType));

                    else

                        thrownewApplicationException(errorMessage);

                    break;

 

                caseOperation.In:

                    if (searchValue.GetType().IsArray)

                    {

                        args = GetArguments(searchValue, fieldInfo.DataType);

                        if (args != null && args.Length > 0)

                            restriction = fieldInfo.In(args);

                        else

                            thrownewApplicationException(errorMessage);

                    }

                    else

                        thrownewApplicationException(errorMessage);

                    break;

 

                caseOperation.IsNotNull:

                    restriction = fieldInfo.IsNotNull();

                    break;

 

                caseOperation.IsNull:

                    restriction = fieldInfo.IsNull();

                    break;

 

                caseOperation.LessThen:

                    if (!searchValue.GetType().IsArray)

                        restriction = fieldInfo.LessThan(S.Parameter(searchValue,

                            fieldInfo.DataType));

                    else

                        thrownewApplicationException(errorMessage);

                    break;

 

                caseOperation.Like:

                    restriction = fieldInfo.Like(string.Concat("%",

                        searchValue.ToString(), "%"));

                    break;

 

                caseOperation.NotBetween:

                    if (searchValue.GetType().IsArray)

                    {

                        args = GetArguments(searchValue, fieldInfo.DataType);

                        if (args != null && args.Length == 2)

                            restriction = fieldInfo.NotBetween(args[0], args[1]);

                        else

                            thrownewApplicationException(errorMessage);

                    }

                    else

                        thrownewApplicationException(errorMessage);

                    break;

 

                caseOperation.NotEqual:

                    if (!searchValue.GetType().IsArray)

                        restriction = fieldInfo.UnEqual(S.Parameter(searchValue,

                            fieldInfo.DataType));

                    else

                        thrownewApplicationException(errorMessage);

                    break;

 

                caseOperation.NotIn:

                    if (searchValue.GetType().IsArray)

                    {

                        args = GetArguments(searchValue, fieldInfo.DataType);

                        if (args != null && args.Length > 0)

                            restriction = fieldInfo.NotIn(args);

                        else

                            thrownewApplicationException(errorMessage);

                    }

                    else

                        thrownewApplicationException(errorMessage);

                    break;

 

                default:

                    thrownewApplicationException(errorMessage);

            }

 

            return restriction;

        }

 

        privateArgument[] GetArguments(T genericArray, 
                                          FieldDataType fieldDataType)

        {

            List<>Argument> args = newList<>Argument>();

 

            switch (fieldDataType)

            {

                caseFieldDataType.dbDateTimeLocal:

                caseFieldDataType.dbDateTimeUTC:

                    if (genericArray isIEnumerable<>DateTime>)

                    {

                        IEnumerable<>DateTime> enumerable = 
                                         genericArray asIEnumerable<>DateTime>;

                        foreach (DateTime j in enumerable)

                        {

                            args.Add(S.Parameter(j));

                        }

                    }

                    else

                        thrownewInvalidOperationException(

                            "Unable to create Argument array of type DateTime");

                    break;

                caseFieldDataType.dbDouble:

                    if (genericArray isIEnumerable<>double>)

                    {

                        IEnumerable<>double> enumerable = 
                                         genericArray asIEnumerable<>double>;

                        foreach (double j in enumerable)

                        {

                            args.Add(S.Parameter(j));

                        }

                    }

                    else

                        thrownewInvalidOperationException(

                            "Unable to create Argument array of type Double");

                    break;

                caseFieldDataType.dbInt:

                caseFieldDataType.dbIntId:

                    if (genericArray isIEnumerable<>int>)

                    {

                        IEnumerable<>int> enumerable = 
                                         genericArray asIEnumerable<>int>;

                        foreach (int j in enumerable)

                        {

                            args.Add(S.Parameter(j));

                        }

                    }

                    else

                        thrownewInvalidOperationException(

                            "Unable to create Argument array of type Int");

                    break;

                caseFieldDataType.dbNull:

                    thrownewInvalidOperationException(

                        "Unable to create Argument array of type Null");

                    break;

                caseFieldDataType.dbShort:

                caseFieldDataType.dbShortId:

                    if (genericArray isIEnumerable<>short>)

                    {

                        IEnumerable<>short> enumerable =
                                          genericArray asIEnumerable<>short>;

                        foreach (short j in enumerable)

                        {

                            args.Add(S.Parameter(j));

                        }

                    }

                    else

                        thrownewInvalidOperationException(

                            "Unable to create Argument array of type Short");

                    break;

                caseFieldDataType.dbString:

                    if (genericArray isIEnumerable<>string>)

                    {

                        IEnumerable<>string> enumerable =
                                         genericArray asIEnumerable<>string>;

                        foreach (string j in enumerable)

                        {

                            args.Add(S.Parameter(j));

                        }

                    }

                    else

                        thrownewInvalidOperationException(

                            "Unable to create Argument array of type String");

                    break;

                caseFieldDataType.dbStringBlob:

                    thrownewInvalidOperationException(

                        "Unable to create Argument array of type Int");

                caseFieldDataType.dbUInt:

                    if (genericArray isIEnumerable<>uint>)

                    {

                        IEnumerable<>uint> enumerable = 
                                         genericArray asIEnumerable<>uint>;

                        foreach (uint j in enumerable)

                        {

                            args.Add(S.Parameter(j));

                        }

                    }

                    else

                        thrownewInvalidOperationException(

                            "Unable to create Argument array of type UInt");

                    break;

                caseFieldDataType.dbUShort:

                    if (genericArray isIEnumerable<>ushort>)

                    {

                        IEnumerable<>ushort> enumerable = 
                                         genericArray asIEnumerable<>ushort>;

                        foreach (ushort j in enumerable)

                        {

                            args.Add(S.Parameter(j));

                        }

                    }

                    else

                        thrownewInvalidOperationException(

                            "Unable to create Argument array of type Short");

                    break;

                default:

                    thrownewApplicationException(

                        "Unknown datatype. Unable to create Argument array from type:" +

                        fieldDataType.ToString());

            }

 

            return args.ToArray();

        }

 

        #region Insert and Update Methods

 

        ///

        /// Inserts a new record into a SuperOffice UD Table, for example UDContactSmall, 
        ///then updates the entity record udef field

        /// with the UDF record identity.

        ///

        ///FieldInfo object of the user-defined field to insert

        /// a value into.

        ///The value to insert into udField.

        ///FieldInfo object, used to access the entitys 
        ///TableInfo object.

        ///Entity identity, used to determine the entity

        /// record to update.

        ///1 if the insert was performed. 2 if the Insert and Update was
         ///performed. Otherwise 0.

        privateint PerformInsert(FieldInfo udField, object fieldValue,

            FieldInfo entityField, int entityIdentity)

        {

            int result = 0;

            int udIdentity = 0;

 

            using (con = ConnectionFactory.GetConnection())

            {

                using (cmd = con.CreateCommand())

                {

                    udIdentity = Sequence.GetNext(udField.Parent);

                    Insert insert = S.NewInsert();

                    insert.FieldValuePairs.Add(udField.Parent.All[0],
                                              S.Parameter(udIdentity));

 

                    //Loop over all fields in record,

                    //  - insert fieldValue into correct field

                    //  - insert default values for all others

                    for (int i = 1; i < udField.Parent.All.Length; i++)

                    {

                        if (udField.Parent.All[i].Name.Equals(udField.Name))

                        {

                            insert.FieldValuePairs.Add(udField.Parent.All[i],

                                S.Parameter(fieldValue, udField.Parent.All[i].DataType));

                        }

                        elseif (udField.Parent.All[i].Name.StartsWith("long"))

                        {

                            insert.FieldValuePairs.Add(udField.Parent.All[i],

                                S.Parameter(0, udField.Parent.All[i].DataType));

                        }

                        elseif (udField.Parent.All[i].Name.StartsWith("string"))

                        {

                            insert.FieldValuePairs.Add(udField.Parent.All[i],

                                S.Parameter("", udField.Parent.All[i].DataType));

                        }

                        elseif (udField.Parent.All[i].Name.StartsWith("double"))

                        {

                            insert.FieldValuePairs.Add(udField.Parent.All[i],

                                S.Parameter(0, udField.Parent.All[i].DataType));

                        }

                    }

 

                    cmd.SqlCommand = insert;

                    con.Open();

                    using (SoTransaction trans = con.BeginTransaction())

                    {

                        cmd.Transaction = trans;

                        result = cmd.ExecuteNonQuery();

                        trans.Commit();

                    }

                    con.Close();

                }

                // Update the main entity table udef field with new udf identity

                result += PerformUpdate(entityField, entityIdentity, udIdentity);

            }

            return result;

        }

 

        ///

        /// Performs the actual UPDATE for a specifided entity or user-defined field.

        ///

        ///The field to update. Could be Entity or UDF 
        ///field.

        ///The identity of the row, or record, to 
        ///update.

        ///The new field value.

        ///

        privateint PerformUpdate(FieldInfo field, int identity, object fieldValue)

        {

            int result = 0;

            using (con = ConnectionFactory.GetConnection())

            {

                using (cmd = con.CreateCommand())

                {

                    Update update = S.NewUpdate();

                    update.SetPrimaryKey(field.Parent.All[0]);

                    update.SetPrimaryKeyValue(S.Parameter(identity));

                    update.FieldValuePairs.Add(field,
                                        S.Parameter(fieldValue, field.DataType));

                    cmd.SqlCommand = update;

                    con.Open();

                    using (SoTransaction trans = con.BeginTransaction())

                    {

                        cmd.Transaction = trans;

                        result = cmd.ExecuteNonQuery();

                        trans.Commit();

                    }

                    con.Close();

                }

            }

 

            return result;

        }

        #endregion

 

        #region Assert Routines

        //for reference types

        privatestaticvoid AssertNotNull(T arg, string argName) where T : class

        {

            if (arg == null)

            {

                thrownewArgumentNullException(argName);

            }

        }

 

        //for Nullable types

        privatestaticvoid AssertNotNull(Nullable arg,
                                                             string argName) where T : struct

        {

            if (!arg.HasValue)

            {

                thrownewArgumentNullException(argName);

            }

        }

 

        //for generic arguments whose type you don't know

        privatestaticvoid AssertGenericArgumentNotNull(T arg, string argName)

        {

            Type type = typeof(T);

 

            if (type.IsClass || (type.IsGenericType &&
                           (type.GetGenericTypeDefinition() == typeof(Nullable<>))))

            {

                AssertNotNull((object)arg, argName);

            }

        }

        #endregion

 

        #endregion

 

        #region Enumerations

 

        ///

        /// ListItemSource refers to the Built-In Lists, as seen in the Admin application.

        ///

        publicenumListItemSource

        {

            AcademicTitle,

            AmountClass,

            Associate,

            Business,

            Category,

            CompanyInterest,

            Competitor,

            ContactInterest,

            Country,

            Credited,

            Currency,

            Function,

            Intent,

            MrMrs,

            Position,

            Priority,

            Rating,

            Reason,

            Rejection,

            Relation,

            Resource,

            Source,

            Status,

            Template,

            TypeFollowUp,

            TypeProject,

            TypeSelection,

            UserDefined,

            UserGroup

        }

 

        ///

        /// Operation enum is used to specify a search method.

        ///

        publicenumOperation

        {

            ///Between expects searchValue to be an array of exactly two 
            ///operandsto user as thresholds, for example a min and max.

            Between,

            ///Equal expects searchValue to be exactly one operand to 
            ///base a comparitive search.

            Equal,

            ///GreaterThan expects searchValue to be exactly one operand 
            ///tobase a comparitive search.

            GreaterThan,

            ///In expects searchValue to be an array of one or more 
            ///operandsto base a comparitive search.

            In,

            ///IsNotNull does not expect any searchValue, as searchValue 
            ///is ignored for this operation.

            IsNotNull,

            ///IsNull does not expect any searchValue, as searchValue is

            /// ignored for this operation.

            IsNull,

            ///LessThan expects searchValue to be exactly one operand to

            /// base a comparitive search.

            LessThen,

            ///Like expects searchValue to be exactly one string operand

            /// to base a comparitive search.

            Like,

            ///NotBetween expects searchValue to be an array of exactly

            /// two operands to user as thresholds, for example a min and max.

            NotBetween,

            ///NotEqual expects searchValue to be exactly one operand to

            /// base a comparitive search.

            NotEqual,

            ///NotIn expects searchValue to be an array of one or more

            /// operands to base a comparitive search.

            NotIn

        }

 

        privateenumQueryType { Scalar, Reader, ReaderPlus, ReaderLoop }

 

        #endregion

    }

 

    ///

    /// Structure to hold relevant UDF SODBIF query information.

    ///

    publicstructUDFInfo

    {

        #region Public Fields

        ///

        /// FieldInfo object of entity field (userdef_id & userdef2_id)

        ///

        publicFieldInfo EntityField;

 

        ///

        /// FieldInfo object of user-defined field (long05, string05, double05)

        ///

        publicFieldInfo UsrDefField;

 

        ///

        /// Identity of entity record.

        ///

        publicInt32 EntityId;

 

        ///

        /// Identity of user-defined record.

        ///

        publicInt32 UsrDefId;

 

        ///

        /// Name, or label, of user-defined field. This is the name of the UDF as

        /// defined in the superoffice admin application.

        ///

        publicString UDFieldName;

 

        ///

        /// The value of the user-defined field for the corresponding UDF.

        ///

        publicObject UDFieldValue;

        #endregion

 

        #region Ctors

        ///

        /// Constructor. This ctor is used by UDFHelper when calling

        /// UDFHelper.Instance.GetUDFInfo.

        ///

        ///

        ///

        ///

        public UDFInfo(FieldInfo entityField, FieldInfo usrDefField, String fieldName)

            : this(entityField, usrDefField, 0, 0, fieldName, null)

        { }

 

        ///

        /// Constructor.

        ///

        ///

        ///

        ///

        ///

        public UDFInfo(FieldInfo entityField, FieldInfo usrDefField,

            String fieldName, int entityId)

            : this(entityField, usrDefField, entityId, 0, fieldName, null)

        { }

 

        ///

        /// Constructor. This ctor is used to populate all the fields of the struct.

        ///

        ///

        ///

        ///

        ///

        ///

        ///

        public UDFInfo(FieldInfo entityField, FieldInfo usrDefField,

                                Int32 entityId, Int32 usrDefId, String fieldName,

            object fieldValue)

        {

            EntityField = entityField;

            UsrDefField = usrDefField;

            EntityId = entityId;

            UsrDefId = usrDefId;

            UDFieldName = fieldName;

            UDFieldValue = fieldValue;

        }

        #endregion

 

        #region Overrides

        ///

        /// Displays the value of UDFieldValue.

        ///

        ///Returns the string value of UDFieldValue. Otherwise returns

        /// string.Empty.

        publicoverridestring ToString()

        {

            if (UDFieldValue != null)

                returnConvert.ToString(UDFieldValue);

            returnstring.Empty;

        }

        #endregion

    }

}
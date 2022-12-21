/// Base class for fetching data from the Address table - no special processing at all
/// One possible feature would be to format Zip codes according to address format guidelines. Another
/// one would be to provide a 'formattedAddress' column, equivalent to a multi-line label...
public abstract class AddressExtenderBase : TableExtenderBase<AddressTableInfo>
{
  #region Columns to be picked up by reflection
  protected ArchiveColumnInfo _colAddressId = new ArchiveColumnInfo( "addressId", RC.SR_ADDRESS_ID, RC.SR_ADDRESS_ID_TOOLTIP, Constants.DisplayTypes.Int,
    AllowOrderBy, Invisible, ColumnHelper.DefaultNumberWidth, Constants.RestrictionTypes.Int );
  protected ArchiveColumnInfo _colLine1 = new ArchiveColumnInfo( "line1", RC.SR_AL_ADDRESS1, RC.SR_ADDRESS_LINE1_TOOLTIP, Constants.DisplayTypes.String,
    AllowOrderBy, Visible, ColumnHelper.DefaultStringWidth, Constants.RestrictionTypes.String );
  protected ArchiveColumnInfo _colLine2 = new ArchiveColumnInfo( "line2", RC.SR_AL_ADDRESS2, RC.SR_ADDRESS_LINE2_TOOLTIP, Constants.DisplayTypes.String,
    AllowOrderBy, Visible, ColumnHelper.DefaultStringWidth, Constants.RestrictionTypes.String );
  protected ArchiveColumnInfo _colLine3 = new ArchiveColumnInfo( "line3", RC.SR_AL_ADDRESS3, RC.SR_ADDRESS_LINE3_TOOLTIP, Constants.DisplayTypes.String,
    AllowOrderBy, Visible, ColumnHelper.DefaultStringWidth, Constants.RestrictionTypes.String );
  protected ArchiveColumnInfo _colCounty = new ArchiveColumnInfo( "county", RC.SR_SEARCH_COUNTY, RC.SR_SEARCH_CRITERION_CONTACT_COUNTY_TOOLTIPConstantsDisplayTypes.String,
    AllowOrderBy, Visible, ColumnHelper.DefaultStringWidth, Constants.RestrictionTypes.String );
  protected ArchiveColumnInfo _colCity = new ArchiveColumnInfo( "city", RC.SR_SEARCH_CITY, RC.SR_SEARCH_CRITERION_CONTACT_CITY_TOOLTIP,ConstantsDisplayTypesString,
    AllowOrderBy, Visible, ColumnHelper.DefaultStringWidth, Constants.RestrictionTypes.String );
  protected ArchiveColumnInfo _colZip = new ArchiveColumnInfo( "zip", RC.SR_SEARCH_ZIP, RC.SR_SEARCH_CRITERION_CONTACT_ZIP_TOOLTIP, ConstantsDisplayTypesString,
    AllowOrderBy, Visible, ColumnHelper.DefaultStringWidth, Constants.RestrictionTypes.String );
  protected ArchiveColumnInfo _colState = new ArchiveColumnInfo( "state", RC.SR_SEARCH_STATE, RC.SR_SEARCH_CRITERION_CONTACT_STATE_TOOLTIP,ConstantsDisplayTypesString,
    AllowOrderBy, Visible, ColumnHelper.DefaultStringWidth, Constants.RestrictionTypes.String );
  #endregion
  protected override void InnerModifyQuery()
  {
    MapIdField( _ourTable.AddressId );
    MapSimpleReturnField( _ourTable.AddressId, _colAddressId );
    MapSimpleReturnField( _ourTable.Address1, _colLine1 );
    MapSimpleReturnField( _ourTable.Address2, _colLine2 );
    MapSimpleReturnField( _ourTable.Address3, _colLine3 );
    MapSimpleReturnField( _ourTable.County, _colCounty );
    MapSimpleReturnField( _ourTable.City, _colCity );
    MapSimpleReturnField( _ourTable.Zipcode, _colZip );
    MapSimpleReturnField( _ourTable.State, _colState );
  }
  protected override void InnerPopulateRowFromReader( SoDataReader reader, ArchiveRow row )
  {
  }
}
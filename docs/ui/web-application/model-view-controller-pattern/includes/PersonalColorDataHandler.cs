using System;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Web;
using SuperOffice.CRM.Web.Data;

namespace ControlsAndDataHandlers
{
  ///
  /// Register in ObjectMapping.config
  ///

  public class PersonalColorDataHandler : DataHandlerBase
  {
    private const string PERSON_DATA_SOURCE = "PersonDataSourceName";
    private const string PERSON_UDF_PROG_ID = "UDFieldProgId";
    private const string PERSON_UDF_LIST_ID = "UDListId";
    private const string PERSONAL_COLOR     = "PersonalColorCarrier";
    private const string COLOR_LIST         = "PersonalColorList";
    private const string PERSON_CARRIER     = "PersonCarrier";
    private PersonalColorCarrier _personalColorCarrier = null;
    private PersonAgent _personAgent;
    public string PersonDataSourceName { get; set; }
    public string UDFieldProgId { get; set; }
    public string UDListId { get; set; }

    ///
    /// The PrimaryCurrent is set in the constructor.
    /// For the PersonalColorDataHandler 'person' is the primary current.
    ///
    public PersonalColorDataHandler() : base(ApplicationDefs.CurrentNames.Person)
    {
    }

    public override void Initialize(System.Xml.XmlNode config, string id)
    {
      foreach (System.Xml.XmlNode item in config.ChildNodes)
      {
        if (item.Name == PERSON_DATA_SOURCE)
          PersonDataSourceName = item.InnerText;
        elseif (item.Name == PERSON_UDF_PROG_ID)
          UDFieldProgId = item.InnerText;
        elseif (item.Name == PERSON_UDF_LIST_ID)
          UDListId = item.InnerText;
      }

      base.Initialize(config, id);

      _personAgent = new PersonAgent();

      this._dataCarriers.Add(PERSONAL_COLOR, null);
      this._dataCarriers.Add(COLOR_LIST, null);
      this._dataCarriers.Add(PERSON_CARRIER, null);
    }

    public override void Load(string CarrierId)
    {
      if (CarrierId == PERSONAL_COLOR && _dataCarriers[PERSONAL_COLOR] == null)
      {
        _personalColorCarrier = newPersonalColorCarrier();
        //"person", set in the ctor
        int currentPersonId = SuperStateManager.GetCurrentId(PrimaryCurrent); 
        string id = Id;

        if (currentPersonId > 0)
        {
          PersonEntity p = _personAgent.GetPersonEntity(currentPersonId);
          _dataCarriers[PERSON_CARRIER] = p;

          if (!string.IsNullOrEmpty(p.UserDefinedFields[UDFieldProgId + ":DisplayText"]))
          {
            _personalColorCarrier.SelectedColor = (BasicColor)Enum.Parse(typeof(BasicColor), p.UserDefinedFields[UDFieldProgId + ":DisplayText"]);
          }

          _personalColorCarrier.Name = p.FullName;
          _personalColorCarrier.BirthDate = p.BirthDate;
        }
        else
        {
          _personalColorCarrier.SelectedColor = BasicColor.White;
          _personalColorCarrier.Name = "";
          _personalColorCarrier.BirthDate = DateTime.MinValue;
        }
        _dataCarriers[PERSONAL_COLOR] = _personalColorCarrier;
      }
    }

    public overridevoid Save()
    {
      //TODO: Persist the values to the data store... (redundant here)
      _personalColorCarrier = (PersonalColorCarrier)_dataCarriers[PERSONAL_COLOR];

      //Save the PersonEntity
      _personAgent.SavePersonEntity((PersonEntity)_dataCarriers[PERSON_CARRIER]);
    }
  }
}
using SuperOffice.CRM;
using SuperOffice.ErpSync.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
namespace SuperOffice.Erp Sync.DummyConnector
{
  public class DummyArguments
  {
    [ConfigField("A String", FieldMetadataTypeInfo.Text, DisplayDescription = "This is just a string")] public string AString;
    [ConfigField("A Date", FieldMetadataTypeInfo.Datetime, DisplayDescription = "This is just a string")] public DateTime ADate;
    [ConfigField("A Password", FieldMetadataTypeInfo.Password, DisplayDescription = "This is just a string")] public string APassword;
    [ConfigField("Mandatory Int", FieldMetadataTypeInfo.Integer, DisplayDescription = "This is just a string", Access = FieldAccessInfo.Mandatory)]

    public int MandatoryInt;
  }

  [ErpConnector("DummyConnector")] public class DummyConnector : IErpConnector
  {
    public FieldMetadataInfoArrayPluginResponse GetConfigData()
    {
      var resp = ResponseHelper.CreateOkResponse<FieldMetadataInfoArrayPluginResponse>();
      resp.FieldMetaDataObjects = ConfigDataHelper.GetMetaData<DummyArguments>().ToDictionary(f => f.FieldKey);
      return resp;
    }

    public PluginResponseInfo TestConfigData(Dictionary<string,string> connectionInfo)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionInfo);
      var resp = ResponseHelper.CreateOkResponse<PluginResponseInfo>();
      return resp;
    }

    public PluginResponseInfo SaveConnection(Guid connectionID, Dictionary<string, string> connectionInfo)
    {
      ConfigDataHelper.SaveData<DummyArguments>(connectionID, connectionInfo);
      var resp = ResponseHelper.CreateOkResponse<PluginResponseInfo>();
      return resp;
    }

    public PluginResponseInfo TestConnection(Guid connectionID)
    {
      var info = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<PluginResponseInfo>();
      return resp;
    }

    public PluginResponseInfo DeleteConnection(Guid connectionID)
    {
      ConfigDataHelper.DeleteData(connectionID);
      var resp = ResponseHelper.CreateOkResponse<PluginResponseInfo>();
      return resp;
    }

    public StringArrayPluginResponse GetSupportedActorTypes(Guid connectionID)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<StringArrayPluginResponse>();
      // ...
      return resp;
    }

    public FieldMetadataInfoArrayPluginResponse GetSupportedActorTypeFields(Guid connectionID, string actorType)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<FieldMetadataInfoArrayPluginResponse>();
      // ...
      return resp;
    }

    public ActorArrayPluginResponse GetActors(Guid connectionID, string actorType, string[] erpKeys, string[] fieldKeys)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<ActorArrayPluginResponse>();
      // ...
      return resp;
    }

    public ActorArrayPluginResponse SearchActors(Guid connectionID, string actorType, string searchText, string[] fieldKeys)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<ActorArrayPluginResponse>();
      // ...
      return resp;
    }

    public ActorArrayPluginResponse SearchActorByParent(Guid connectionID, string actorType,
      string searchText, string parentActorType,
      string parentActorErpKey, string[] fieldKeys)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<ActorArrayPluginResponse>();
      // ...
      return resp;
    }

    public ActorPluginResponse CreateActor(Guid connectionID, ErpActor act)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<ActorPluginResponse>();
      // ...
      return resp;
    }

    public ActorArrayPluginResponse SaveActors(Guid connectionID, ErpActor[] actors)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<ActorArrayPluginResponse>();
      // ...
      return resp;
    }

    public ListItemArrayPluginResponse GetList(Guid connectionID, string listName)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<ListItemArrayPluginResponse>();
      // ...
      return resp;
    }

    public ListItemArrayPluginResponse GetListItems(Guid connectionID, string listName, string[] listItemKeys)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<ListItemArrayPluginResponse>();
      // ...
      return resp;
    }

    public ActorArrayPluginResponse GetActorsByTimestamp(Guid connectionID, string updatedOnOrAfter,
            string actorType, string[] fieldKeys)
    {
      var config = ConfigDataHelper.GetData<DummyArguments>(connectionID);
      var resp = ResponseHelper.CreateOkResponse<ActorArrayPluginResponse>();
      // ...
      return resp;
    }
  }
}
using System;
using SuperOffice.Data;
using SuperOffice.CRM.Web;
namespace ControlsAndDataHandlers
{
  public partial class PersonalInformation : SuperOffice.CRM.Web.UI.Controls.UserControlBase
  {
    public string PersonDataSourceName { get; set; }
    public string UDFieldProgId { get; set; }
    public string UDListId { get; set; }
    protectedvoid Page_Load(object sender, EventArgs e)
    {
    }
    public override void Initialize(System.Xml.XmlNode config, string id)
    {
      base.Initialize(config, id);
      Setup();
    }
    private void Setup()
    {
      FavoriteColorList.EditMode = true;
      FavoriteColorList.ListName = "udlist" + UDListId;
      FavoriteColorList.DataSourceName = PersonDataSourceName + ".UserDefinedFields." + UDFieldProgId;
      FavoriteColorList.DisplayTextDataSource = PersonDataSourceName + ".UserDefinedFields." + UDFieldProgId + ":DisplayText";
      BirthDate.ReadOnly = false;
      BirthDate.EditMode = true;
      BirthDate.DataSourceName = this.DataSourceName + ".BirthDate";
      BirthDate.FieldRight = DataDispatcherManager.GetDataDispatcher().GetFieldRight(this.DataSourceName + ".BirthDate");
    }
    public override void DataBind()
    {
      PersonalColorCarrier colorCarrier = (PersonalColorCarrier)this.DataSource;
      if (colorCarrier != null)
      {
        this.lblActualName.Text = colorCarrier.Name;
      }
      FavoriteColorList.DataBind();
      BirthDate.DataSource = SuperOffice.Globalization.ResourceManager.ConvertToShortDateString(colorCarrier.BirthDate);
      BirthDate.DataBind();
    }
    public override void UpdateDataSource()
    {
      FavoriteColorList.UpdateDataSource();
      BirthDate.UpdateDataSource();
    }
  }
}
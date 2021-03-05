public override void Initialize(System.Xml.XmlNode config, string id)
{
  base.Initialize(config, id);
  System.Xml.XmlNode node = config.SelectSingleNode("ForeignKeyDeviceId");
  if (node != null && !String.IsNullOrEmpty(node.InnerText))
  {
    _fkDeviceId = node.InnerText;
  }
  else
  {
    throw new SystemException("Missing Foreign Key Device Id");
  }
}

protected void Page_Load(object sender, EventArgs e)
{
  // Get current sale ID
  _saleId = SuperOffice.CRM.Web.SuperStateManager.GetCurrent("sale").Id;
  if (_saleId > 0)
  {
    // Get all foreign keys for current sale
    GetList();
  }
}

private void GetList()
{
  IForeignSystemAgent agent = new ForeignSystemAgent();
  ForeignKey[] fks = agent.GetDeviceKeysOnDeviceIdentifierTableRecordId("DevNet", "Demo", _fkDeviceId, "sale", _saleId);
  dgFkList.DataSource = fks;
  dgFkList.DataBind();
}
public override void Initialize(System.Xml.XmlNode config, string id)
{
  _dataCarriers.Add("ForeignKeyDeviceOne", null);
  _dataCarriers.Add("ForeignKeyDeviceTwo", null);

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
  ForeignSystemAgent agent = new ForeignSystemAgent();
  ForeignKey[] fks = agent.GetDeviceKeysOnDeviceIdentifierTableRecordId("DevNet", "Demo", _fkDeviceId, "sale", _saleId);
  dgFkList.DataSource = fks;
  dgFkList.DataBind();
}

public override void UpdateDataSource()
{
    base.DataSource = _fk;
    base.UpdateDataSource();
}

public override object Save()
{
  // Save the sale
  base.Save();
  SaleEntity saleEntity = (SaleEntity)_dataCarriers["SaleEntity"];
  if (saleEntity.SaleId > 0)
  {
    // Save foreign keys
    DevNetForeignKey devNetFkOne = (DevNetForeignKey)_dataCarriers["ForeignKeyDeviceOne"];
    DevNetForeignKey devNetFkTwo = (DevNetForeignKey)_dataCarriers["ForeignKeyDeviceTwo"];
    SaveForeignKey(devNetFkOne, saleEntity);
    SaveForeignKey(devNetFkTwo, saleEntity);
  }
}
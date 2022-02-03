using System;
using System.Collections.Generic;
using System.Text;

using SuperOffice.CRM.Web.Data;

namespace MyTestDataHandler
{
  ///<summary>
  ///The ContactEntityDataHandler handles the ContactEntity
  ///</summary>
  ///
  public class MyDataHandler : DataHandlerBase
  {
    #region IDataHandler Members

    /// <summary>
    /// Initializing the data handler
    /// </summary>
    /// <param name="config">Data handler configuration</param>
    /// <param name="id">Data handler ID</param>
    public override void Initialize(System.Xml.XmlNode config, string id)
    {
      base.Initialize(config, id);
      //Adds the specified key and value to the Dictionary
      _dataCarriers.Add("mySysDate", DateTime.Now);
    }
    #endregion
  }
}
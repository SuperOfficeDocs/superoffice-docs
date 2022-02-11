using System;
using System.Collections.Generic;
using System.Text;
using SuperOffice.CRM.Security;
using SuperOffice.Data.SQL;
using SuperOffice.CRM.Data;
using SuperOffice.CRM.Rows;
using SuperOffice.CRM.Entities;
using MyNetServerCode.Data;
namespace SentryForCustomTableDll
{
  [SentryPlugin("contact")] public class CustomSentryPlugin : ISentryPlugin
  {
    /// <summary>
    /// Storing reference to the sentry the plugin works on behalf of.
    /// </summary>
    SuperOffice.CRM.Security.Sentry _sentry = null;
    /// <summary>
    /// Default constructor, we do nothing here.
    /// </summary>
    public CustomSentryPlugin() { }

    #region ISentryPlugin Members

    /// <summary>
    /// Here we initialize sentry type we want. The parameter will give us the sentry type.
    /// </summary>
    /// <param name="sentry"></param>
    public void Init(Sentry sentry)
    {
        _sentry = sentry;
    }

    /// <summary>
    /// Modify field rights.
    /// </summary>
    public void ModifyFieldRights(FieldRights rights)
    {
      // No changes in field rights
    }

    /// <summary>
    /// Modify table rights.
    /// </summary>
    public void ModifyTableRights(TableRights rights)
    {
      // No changes in field rights
    }

    #endregion

    #region helpers
    /// <summary>
    /// Casting <see cref="sentry.SentryQueryInfo"/> to <see cref="ContactSentryQueryInfo"/>.
    /// </summary>
    private ContactSentryQueryInfo QueryInfo
    {
      get { return (ContactSentryQueryInfo)_sentry.SentryQueryInfo; }
    }

    /// <summary>
    /// Obtain value of a field without trigging sentry calculations.
    /// </summary>
    /// <param name="fieldInfo">Field to get value for</param>
    /// <returns>Value of the field.</returns>
    object GetFieldValue(FieldInfo fieldInfo)
    {
      using (_sentry.Lookups.BeginIgnoreSentryCheck())
      {
        return _sentry.Lookups.GetFieldValue(fieldInfo);
      }
    }
    #endregion
  }

  ///<summary>
  ///Demonstration of sentry plugin query table updater for table Contact.
  ///</summary>
  ///<remarks>Enforce the restriction contacts with the same business-id as the current user are visible to any user.</remarks>

  [SentryPluginQueryTableUpdater("contact")]
  public class SentryPluginQueryTableUpdaterContact : ISentryPluginQueryTableUpdater
  {
    #region ISentryPluginQueryTableUpdater Members

    public void ModifySelect(Select sql, TableInfo tableInfo)
    {
      // Get the ContactTableInfo and SuperOfficeTrainingTableTableInfo
      ContactTableInfo newConTable = (ContactTableInfo)tableInfo;
      SuperOfficeTrainingTableTableInfo newCustomTable = MyNetServerCode.Data.CustomTablesInfo.GetSuperOfficeTrainingTableTableInfo();
      // Set the restriction
      sql.RestrictionAnd(newCustomTable.AssociateId.Equal(SuperOffice.Data.S.Parameter(SuperOffice.SoContext.CurrentPrincipal.AssociateId)));
      // Join the tables Contact and the custom table
      sql.JoinRestriction.InnerJoin(newConTable.BusinessIdx.Equal(newCustomTable.BusinessId));
    }
    #endregion
  }
}
using System;
using System.Collections.Generic;
using System.Text;
using SuperOffice.CRM.Security;
using SuperOffice.Data.SQL;
using SuperOffice.CRM.Data;
using SuperOffice.CRM.Rows;
using SuperOffice.CRM.Entities;
namespace Sentry_Plugin
{
  [SentryPlugin("contact")]
  public class ContactSentryPlugin : ISentryPlugin
  {
    /// <summary>
    /// Storing reference to the sentry the plugin works on behalf of.
    /// </summary>
    SuperOffice.CRM.Security.Sentry _sentry = null;
    /// <summary>
    /// Default constructor, we do nothing here.
    /// </summary>
    public ContactSentryPlugin() { }
    #region ISentryPlugin Members
    /// <summary>
    /// Intialize sentry.
    /// </summary>
    /// <param name="sentry">The sentry type.</param>
    public void Init(Sentry sentry)
    {
      _sentry = sentry;
    }
    /// <summary>
    /// Modify field rights.
    /// </summary>
    /// <param name="rights">Rights object to modify</param>
    /// <remarks>Hide the post-it if <see cref="ModifyTableRights"/>
    /// made everything read only because of the trailing '_'.
    /// </remarks>
    public void ModifyFieldRights(FieldRights rights)
    {
      // no changes in field rights
    }
    /// <summary>
    /// Modify table rights.
    /// </summary>
    /// <param name="rights">Rights object to modify.</param>
    /// <remarks>Set everything to read only if department ends with '_'
    /// unless the current user is the owner.
    /// </remarks>
    public void ModifyTableRights(TableRights rights)
    {
      //get the value of the Dept
      string department = GetFieldValue(QueryInfo.MainTable.Department) as string;
      //check to see dept value not empty, ans the value ends with a
      //"_" and the logged in user is not the owner.
      if (!string.IsNullOrEmpty(department)
        && department.Trim().EndsWith("_")
        && _sentry.GetRecordOwnershipIndex() != EOwnershipIndex.Owner)
      {
        //modify the rights
        foreach (TableInfo ti in rights.Keys.ToArray())
          rights[ti] = rights[ti] & RightsFactory.Get(ETableRight.R,
            "make all read only since dept value ends with '_'");
      }
    }
    #endregion
    #region helpers
    /// <summary>
    /// Casting <see cref="sentry.SentryQueryInfo"/>to <see cref="ContactSentryQueryInfo"/>.
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
  ///Demonstration of sentry plugin query table updater for table contact.
  ///</summary>
  ///<remarks>The field Department is forced to be in queries so rights can be calculated.</remarks>
  [SentryPluginQueryTableUpdater("contact")]
  public class SentryPluginQueryTableUpdaterContact : ISentryPluginQueryTableUpdater
  {
    #region ISentryPluginQueryTableUpdater Members
    public void ModifySelect(Select sql, TableInfo tableInfo)
    {
      //we force dept field to return fields
      sql.ReturnFields.Add(((ContactTableInfo)tableInfo).Department);
    }
    #endregion
  }
}
---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: sentry_plugin       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Sentry plugin with user-defined tables # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 05.16.2008
keywords:
so.topic: article              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Sentry plugin with user-defined tables

In this article, you will learn how to create a custom table that contains foreign keys to existing tables. You also learn how to create a Sentry plugin that enforces additional restrictions on the contact table.

The objective is it to demonstrate how to control what the user is allowed to see. In this case, the user is only allowed to see contacts with a business type equal to that of the user’s company business type. The following diagram shows the relationship between the three tables namely contact, associate and the custom table `superofficetrainingtable`.

![x][img1]

## Create a Custom Table Using Dictionary SDK

This section focuses on how to create a user-defined table in the database using the Dictionary SDK. To use the SODictionary SDK, SODictionarySDK.dll needs to be registered using regsvr32. The DLL can be found in the SuperOffice installation directory. It is important to make sure the correct values are set in the Admin client replication screen because these values are used by the SODictionary whenever the manipulations are done in the database.

```csharp
using System;
using System.Collections.Generic;
using System.Text;
using SuperOffice.COM.DictionarySDK;

namespace CustomTableWithSentry
{
classProgram
    {
    staticvoid Main(string[] args)
        {
        try
            {
            // Create a new dictionary
            Dictionary dictionary = newDictionary();
            
            // set the database
            dictionary.SetDatabase("ODBC:SuperOffice", "TJE0", "tje0", "CRM5");
            
            // Create the table
            Table table;
            
            table = dictionary.CreateTable("SuperOfficeTrainingTable");
            
            table.Description = "Detailed information about the new table";
            table.NetServerName = "SuperOfficeTrainingTable";
            table.ReplicateDown = false;
            table.ReplicateToPrototype = false;
            table.ReplicateUp = false;
            
            // Create foreign keys
            Field fkField = table.CreateForeignKey("Associate", ERelationCardinality.enOneToMany);
            
            fkField.Description = "This is the key of the Associate table.";
            fkField.AddImportName(1034, "ImportNameOfASSForeignKey");
            fkField.NetServerName = "Associate";
            
            // Create foreign keys
            Field fkField2 = table.CreateForeignKey("Business", ERelationCardinality.enOneToMany);
            
            fkField2.Description = "This is the key of the Business table.";
            fkField2.AddImportName(1033, "ImportNameOfBusinessForeignKey");
            fkField2.NetServerName = "Business";                           
            dictionary.CommitChanges();
            
            Console.WriteLine("Done.");
                        }
            catch (Exception exp)
                        {
            Console.WriteLine(exp.Message);
            }
        }
    }
}
```
  
In the above code segment we have created a Dictionary object, with the use of which a table is created in the database. Further, two foreign keys namely the Associate-id and the Business-id are created and the table names and the relationship multiplicity are specified.

To read more information about how to use the DictionarySDK class library to create custom tables in the SuperOffice database, see [User-Defined-Tables-Part-I][1].

## Generate User-Defined Table Classes for Use in NetServer

To access the new User-Defined Table (UDT) using NetServer, we are required to generate NetServer OSQL and Row types that define the UDT. These types are easily generated using the on-line code generator hosted on DevNet.

![x][img2]

When the code generation is complete a visual studio solution with one project is created in the location specified by the user. This project contains two folders.  One folder contains class files for supporting the data access layer and one for supporting Rows.

This utility application is available for download from DevNet. See [Generate-User-Defined-Table-Classes-For-Use-in-NetServer][2] for more information.

## Create the Sentry Plugin

To begin creating a new Sentry plug-in, you must create a class that inherits from and implements the SuperOffice.CRM.Security.ISentryPlugin interface. In the plugin it is required to access the generated NetServer classes for the UDT. To accomplish this, compile the code generation solution and add a reference to the DLL in the Plugin project.

```csharp
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
    [SentryPlugin("contact", "CustomSentry.Sentry")] publicclassCustomSentryPlugin : ISentryPlugin
    {
        // Storing reference to the sentry the plugin works on behalf of.
        SuperOffice.CRM.Security.Sentry _sentry = null;

        // Default constructor, we do nothing here.
        public CustomSentryPlugin() { }
        
        #region ISentryPlugin Members
        
        // here we intialize sentry type we want. the parameter will give us the sentry type.
        publicvoid Init(Sentry sentry)
            {
                _sentry = sentry;
            }
    
        // Modify field rights.
        publicvoid ModifyFieldRights(FieldRights rights)
            {
                // no changes in field rights
            }

        // Modify table rights.
        publicvoid ModifyTableRights(TableRights rights)
            {
            // no changes in field rights
            }

        #endregion
            
        #region helpers
        
        // Casting to cref="ContactSentryQueryInfo"/>.
        private ContactSentryQueryInfo QueryInfo
            {
            get { return (ContactSentryQueryInfo)_sentry.SentryQueryInfo; }
            }

        // Obtain value of a field without trigging sentry calculations.
        object GetFieldValue(FieldInfo fieldInfo)
            {
            using (_sentry.Lookups.BeginIgnoreSentryCheck())
                {
                return _sentry.Lookups.GetFieldValue(fieldInfo);
                }
            }
        #endregion
    }

    // Demonstration of sentry plugin query table updater for table Contact.
    // Enforce the restriction contacts with the same business-id as the current user are visible to any user.
    [SentryPluginQueryTableUpdater("contact")] publicclassSentryPluginQueryTableUpdaterContact : ISentryPluginQueryTableUpdater
    {
        #region ISentryPluginQueryTableUpdater Members

        publicvoid ModifySelect(Select sql, TableInfo tableInfo)
            {
            // get the ContactTableInfo and the SuperOfficeTrainingTableTableInfo
            ContactTableInfo newConTable = (ContactTableInfo)tableInfo;
            SuperOfficeTrainingTableTableInfo newCustomTable = MyNetServerCode.Data.CustomTablesInfo.GetSuperOfficeTrainingTableTableInfo();

            // set the restriction
            sql.RestrictionAnd(newCustomTable.AssociateId.Equal(SuperOffice.Data.S.Parameter(SuperOffice.SoContext.CurrentPrincipal.AssociateId)));          

            // join the tables Contact and the custom table
                sql.JoinRestriction.InnerJoin(newConTable.BusinessIdx.Equal(newCustomTable.BusinessId));
            }
        #endregion
    }
}
```

As we can see in the above code segment, we have created another class called "SentryPluginQueryTableUpdaterContact" which implement the SuperOffice.CRM.Security.ISentryPluginQueryTableUpdater interface. This interface has a single method called "ModifySelect" where we have implemented the sentry restriction to retrieve only the contact information where the Business-id of which is same as the currently logged in user’s Business-id.

TableInfo objects are required for the tables of interest i.e., the Contact table and SuperOfficeTrainingTable. ContactTableInfo is retrieved by casting the TableInfo object passed to the ModifySelect method. Then the restriction is enforced to narrow the data selection to the current user’s business-id. Finally we have specified the join condition so that the custom table is joined in whenever the Contact table is queried upon.

You can see that this class is marked with the SentryPluginQueryTableUpdater attribute, specifying the Contact entity as the target sentry. Now, whenever the Contact table is queried upon, this method is raised to add custom binding.

## Using the Sentry Plugin

In order for us to use the plugin, modifications are required in the ‘config’ file signaling NetServer that we have our own plugin and mentioning where the DLL is located. Below is the section that we have to modify in the ‘app.config’ file.

```xml
<Factory>
  <DynamicLoad>
    <addkey="SentryPlugin"value="SentryForCustomTableDll.dll" />
  </DynamicLoad>
</Factory>
```

The following code snippet is an example that uses the plugin. Here we attempt to retrieve the Contact information logging on with different users and outputting the list of contacts that each user can see.

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;
using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;

privatevoid btnShowContacts_Click(object sender, EventArgs e)
{
try
    {
    using (SoSession session = SoSession.Authenticate(this.txtUserName.Text.Trim(), this.txtPWD.Text.Trim()))
        {
        // Retrive tableInfo for the ContactTable
        ContactTableInfo newConTable = TablesInfo.GetContactTableInfo();

        // Retrieve Data from a the tables in to an instance of the Select Class
        Select newSelect = S.NewSelect();
        
        // Choose the columns that should be retrieved
        newSelect.ReturnFields.Add(newConTable.ContactId, newConTable.Department, newConTable.Name);
        
        // Order the retrieved Data
        newSelect.OrderBy.SortOrder.Add(newConTable.ContactId, SuperOffice.Util.OrderBySortType.ASC);
        
        // Establish a Database Connection
        SoConnection myConn = ConnectionFactory.GetConnection();
        
        // Create SoCommand instance and assigning the Select statement
        SoCommand myComm = myConn.CreateCommand();
        myComm.SqlCommand = newSelect;
        myConn.Open();
        
        // Load the data into the DataReader
        SoDataReader myReader = myComm.ExecuteReader();
        ArrayList arrConData = newArrayList();
        
        // Retrieve the data from the reader
        while (myReader.Read())
            {
            int conID = myReader.GetInt32(0);
            string conDept = myReader.GetString(1);
            string conName = myReader.GetString(2);
            
            // Create a user defined contact object to be stored in the ArrayList
            ContactData contact = newContactData(conID, conName, conDept);
            arrConData.Add(contact);
            
            // Setting the results to the data grid
            this.grdContactData.DataSource = arrConData;
            
            // Close the Reader
            myReader.Close();
        }
    }

    catch (Exception exception)
    {
        // Clear textboxes and the data grid
        this.clearAll();
        MessageBox.Show("Invalid user.");
    }
}
```

We have first retrieved the TableInfo object for the Contact table. Next, a Select object is created to retrieve data. The columns to be included in the selection and the order in which the results to be sorted is specified next. The select command is executed against the Contact table to retrieve the Contact information. This is the point where our plugin come into the picture i.e., when we attempt to run a query against the Contact table, the NetServer sentry mechanism calls our sentry plugin and the plugin logic gets executed. With the restriction specified in the ModifySelect method of the plugin, any user can retrieve only the contact information where the BusinessId of which is the same as the currently logged-in user’s BusinessId.

The next step is to convert the retrieved contact data into a format that can be displayed in a data grid. The approach taken in this example is to iterate over the retrieved DataReader and encapsulate those data into a custom object type called "ContactData". These objects are stored in an ArrayList, which is set as the data source for the contact information data grid.

The following screenshots show the results of the same query run on the contact table for two users namely "SAL0" and "P".

![x][img3]

![x][img4]

<!-- Referenced links -->
[1]: http://devnet.superoffice.com/Library/Articles/Database/User-Defined-Tables-Part-I
[2]: http://devnet.superoffice.com/Library/Articles/NetServer-SDK/Archived-Articles/Generate-User-Defined-Table-Classes-For-Use-in-NetServer/

<!-- Referenced images -->
[img1]: media/image002.gif
[img2]: media/image003.png
[img3]: media/image005.jpg
[img4]: media/image006.jpg

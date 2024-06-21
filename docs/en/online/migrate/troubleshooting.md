---
title: Troubleshooting migration errors
uid: troubleshooting_migration_errors
description: Discusses potential problems after migration SuperOffice databases.
author: AnthonyYates
keywords: migrate
topic: guide
envir: onsite, online
# client:
---

# Troubleshooting Migration Errors

During customer migration to CRM Online we check the databasemodel for potential problems. A rare problem can result with this message.

![ErrorDatabaseModel][img1]

When this error message appears, it's generally the result of one or more custom tables created with the SuperOffice Dictionary SDK, a means to modify the database schema before we introduced  [Continuous Database (CDD)][1] with version 8.1.

In earlier versions, when using the SODictionarySDK (deprecated), all database scema changes also updated the dictionary tables. These are all tables with a negative tablenumber in Sequence:

![SequenceDictionary][img8]

From 8.1 the database dictionary is moved into the [databasemodel][2] table as a compressed json string.

Any current use of the old SODictionarySDK will change the physical database scema and update the obsolete dictionary tables. However, it ignores the CDD databasemodel table, leaving the database in sort of a corrupted state.

All databases affected by these issues must be fixed prior to migration to CRM Online.

## Solution

1. LINQPad will allow you to change the JSON of the databasemodel directy. [Download LINQPad][3].

   You need to download the version for .NET framework – currently LINQPad 5

2. Since we will be fixing this directly in the database, make sure you have a backup of the databasemodel. Use Management Studio (for Microsoft SQL databases) and run the following query to create a new database table (dbmb) where you store a copy of the current value:

    ```sql
    select * into dbmb from crm7.DATABASEMODEL
    ```

    If anything goes wrong, you may restore it later using:

    ```sql
    truncate table crm7.databasemodel
    insert into crm7.DATABASEMODEL select * from dbmb​
    ```

3. You will need some of the CDD files, these are all located in the [Database imp exp tool you may download][4] from this page. Unpack all files.

4. Start LINQPad and click F4 to bring up the Query Properties so you can add Additional References. Click browse and locate these 4 files from the download:

    ![LinqPad References][img3]

5. Go to Additional Namespace Imports and paste in these lines:

    ```csharp
    Newtonsoft.Json
    Newtonsoft.Json.Converters
    SuperOffice.CD.Database
    SuperOffice.CD.DSL.Database
    SuperOffice.CD.DSL.Models
    SuperOffice.CD.DSL.PhysicalDatabase
    SuperOffice.CD.DSL.V1.DatabaseModel
    System.Data.Sql
    ```

    ![Additional references][img2]

6. Now, paste the code below (written by Dr. Marek Vokáč) into the Query window. Update the connection in the first line with your database server name and database name.  Add the correct PREFIX in the second line.

    ```csharp
    var conn = DbConnectionProvider.GetConnection("Server=SERVERNAME;Database=DATABASENAME;Integrated Security=true", "MSSQL", "");
    var dbManagement = DatabaseManagement.CreateInstance("PREFIX", conn);
    var databaseModel = dbManagement.ReadDatabaseModel();
    var missingTables = databaseModel.Tables.Where(t => !dbManagement.VerifyTableExists(t.Name)).Select(t => t.Name).ToArray();

    Console.WriteLine("Tables missing in database:");
    Console.WriteLine("\t" + string.Join("\n\t", missingTables));

    if (missingTables.Length == 0)
    {
        Console.WriteLine("No tables missing in the database, no action needed");
        return;
    }

    Console.WriteLine("If you choose to delete these tables from the databasemodel, \nyou should REALLY have a backup of the databasemodel table.");
    Console.WriteLine("Really. \nPress y and [ENTER] to delete these tables from the database model:");

    var y = Util.ReadLine("");

    if (y == "y")
    {
        Console.WriteLine (y);
        foreach (var table in missingTables)
            databaseModel.Tables.Remove(databaseModel.FindTable(table));

        dbManagement.SaveDatabaseModel(databaseModel);
        Console.WriteLine("Tables deleted, model saved");}
    else
        Console.WriteLine("Nothing done, model untouched");
    ```

    > [!NOTE]
    > This example connectionstring use Integrated Security, you may replace the Integrated Security=true with User Id=myUsername;Password=myPassword

7. When run this will verify that all tables found in Databasemodel actually exists on the SQL Server and list those who do not:

    ![RunLinq][img6]

8. Press y and ENTER to confirm you want to remove the tables that appears as missing.

    ![MissingTableExample][img4]

    Next time you run this, these will be gone.

    ![MissingTable][img5]

    > [!NOTE]
    > In the zip you also get the nifty little DBUtil.exe - start it and read the helpfile. With this one you may actually choose to drop export of some database tables.

    [Download Database Import Export Tool][4]

<!-- Link reference -->

[1]: ../../database/dictionary/index.md
[2]: ../../database/tables/databasemodel.md
[3]: https://www.linqpad.net/Download.aspx
[4]: ../../../assets/downloads/database-imp-exp-tool.zip

<!-- Image reference -->

[img1]: media/errordatabasemodel.png
[img2]: media/linqpadadditionalnamespaceimports.png
[img3]: media/linqpadadditionalreferences.png
[img4]: media/linqpadmissingtablesexample.png
[img5]: media/linqpadnomissingtables.png
[img6]: media/linqpadrun.png
[img8]: media/sequencedictionary.png

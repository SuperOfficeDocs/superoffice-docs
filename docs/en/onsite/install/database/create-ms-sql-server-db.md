---
title: Create Microsoft SQL Server
uid: create_sql_server_db
description: Create a new Microsoft SQL Server database for SuperOffice onsite
author: {github-id}
keywords: database
topic: howto
envir: onsite
# client:
---

# SuperOffice CRM running on Microsoft SQL Server database

To be able to install SuperOffice CRM software on MS SQL database, you need to manually create a blank database and an ODBC data source.

> [!NOTE]
>
> If you want to take advantage of the [MS SQL Server full-text search][1] you need to [set this up][2] before running **DBSetup** or **ServerSetup** to create the new SuperOffice CRM database.

## Create a new Microsoft SQL Server database

Follow these steps to set up the target MS SQL database:

1. Create a new target database using the MS SQL Server Management studio.
Fill in the **Database name**, leave the **Owner** field to default.
![Add new DB -screenshot][img1]

2. Add a new login in **Security - Login**. The login name may be called CRM8 but you are free to name the login whatever you like. Switch to **SQL Server authentication** and fill in password. You can set the **Default database** to the SuperOffice one.
![Add new login -screenshot][img2]

3. Switch to **User Mapping** page and give the user **db_owner** permission on the new database.
![Add DB owner -screenshot][img3]

4. Go to the new database, expand **Security** and **Schemas**. Create a new schema, the name of the schema will be the table prefix.
![Create schema -screenshot][img4]

## Create a new 32-bit ODBC System Data Source

1. Go to Windows start menu - Windows Administrative tools and start **ODBC Data Sources (32-bit)**. It is important to select the 32-bit version and not the 64-bit of the ODBC manager.

    Select **System DSN** tab, click **Add** and from the list of available drivers select **SQL Server Native client**. Click **Finish** to start the Data source wizard.

    ![New ODBC -screenshot][img5]

1. Enter the ODBC source name and from the drop down list select the SQL server where SuperOffice database was created.

    ![Source name -screenshot][img6]

1. Switch to the **SQL Server authentication** option and enter the login name and password you created in the Step 2 of the database creation.

    ![Source login -screenshot][img7]

1. Tick the checkbox **Change the default database to** and from the drop down list select the SuperOffice database.

    ![Default DB -screenshot][img8]

1. On the next page leave the configuration options as they are and continue to the last screen. Click **Test Data Source** button to check if all entered values are OK and the data source is working. Click **OK** to finish the ODBC Data Source wizard.

    ![Finish -screenshot][img9]

Please refer to the manufacturer's web pages for more information.

***

[Previous][12] | [Next][11] | [Back to guide][13]

<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/sql/relational-databases/search/full-text-search?view=sql-server-2017
[2]: sql-server-full-text-search.md
[11]: ../iis/index.md
[12]: ../server/prepare.md
[13]: ../guide.md

<!-- Referenced images -->
[img1]: media/01-new-db.jpg
[img2]: media/02-add-login.jpg
[img3]: media/03-db-owner.jpg
[img4]: media/04-add-schema.jpg
[img5]: media/06-odbc-new.jpg
[img6]: media/07-odbc-name.jpg
[img7]: media/08-odbc-login.jpg
[img8]: media/09-odbc-database.jpg
[img9]: media/11-odbc-finish.jpg

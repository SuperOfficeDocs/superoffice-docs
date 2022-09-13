---
title: Create Microsoft SQL Server
uid: create_sql_server_db
description: Create a new Microsoft SQL Server database for SuperOffice onsite
author: {github-id}
keywords: database
so.topic: howto
so.envir: onsite
# so.client:
---

# Create a new Microsoft SQL Server database

Are you going to run SuperOffice on a Microsoft SQL Server, follow these steps to set up the target database:

1. Create a new target database using the SQL Management tool.
Fill in the **Database name**, leave the **Owner** field to default.
![Add new DB -screenshot][img1]

2. Add a new login in **Security > Login**. The login name may be called CRM8, but you are free to name the user whatever you like. Switch to **SQL Server authentication** and fill in password. You may set the **Default database** to the SuperOffice one.
![Add new login -screenshot][img2]

3. Switch to **User Mapping** page and give the user `db_owner` permission (lower list) on the new database.
![Add DB owner -screenshot][img3]

4. Go to the new database, expand **Security** and **Schemas**. Create a new schema, the name of the schema will be the table prefix.
![Create schema -screenshot][img4]

5. Create a new 32-bit ODBC System Data Source pointing to the new database.

> [!NOTE]
> If you want to take advantage of the [SQL Server full-text search][1] you need to [set this up][2] before you run **DBSetup** or **ServerSetup** to create the new SuperOffice CRM database.

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
---
title: Install database
uid: install_database
description: "How to prepare and install the SuperOffice database."
author: {github-id}
date: 09.12.2023
keywords: install, database, Oracle, MSQL
topic: howto
envir: onsite
# client:
---

# Prepare the database

The central database may be running on either Microsoft SQL Server or Oracle before you start the server installer.

## Supported databases

The latest versions are MS SQL Server 2019 and Oracle 18c. Also, check out the [complete list of supported databases][4] and our [compatibility reports][1].

## Unicode and ANSI database?

For new customers, we recommend using Unicode. This removes all ambiguity of future planning and ensures compatibility.

## Prepare your database

Choose one of:

* [Create Oracle database][5]
* [Create Microsoft SQL Server database][6]

> [!NOTE]
> The ODBC data source must be set up as a 32-bit system DSN.

When we describe how to set up the SQL database on your server, we will focus on how to prepare the database for a SuperOffice installation.

* Any advice we give is based on that this SQL server application is installed on the latest Windows server that is dedicated as a database application server.

* Any advice is also based on that the SuperOffice database is the only database served by this computer. If your environment is different from these preconditions, our advice may need to be reconsidered.

The more powerful the SQL Server computer is, the faster SuperOffice CRM will perform. This of course will depend on the amount of users this SQL server is going to serve.

***

[Previous][12] | [Next][11] | [Back to guide][13]

<!-- Referenced links -->
[1]: ../../compatibility/index.md
[4]: ../../compatibility/database.md
[5]: create-oracle-db.md
[6]: create-ms-sql-server-db.md
[11]: ../iis/index.md
[12]: ../server/prepare.md
[13]: ../guide.md

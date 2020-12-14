---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: prepare_win_client       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Prepare Win client computer # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client: win                # online, web, win, pocket, or mobile
---

# Prepare Win client computer

[!include[Warning legacy](../includes/warn-win-client-discontinued.md)]

**For Microsoft SQL Server:**

Make sure the ODBC driver you want to use is installed on the client.

**For Oracle:**

Make sure the the 32-bit version of Oracle Client is installed. Note - we require the Runtime installation. You also need to set up the Local Net Service Name from the Oracle Net Configuration Assistant.

The client installer will install all prerequisites, the .Net framework is a web download so the client needs access to the internet when installed.

## ODBC and ADO.NET connections

Most parts of SuperOffice product family use ADO.NET connection. There are some exceptions which for historical reasons use ODBC connection.

### Win client

Win client uses a mix of ODBC and ADO.NET connections. The new parts (e.g. selections, quote, bulk update, guide, archives) use ADO.NET, some parts like e.g. Diary are ODBC based.

Win Admin client uses a mix of ODBC and ADO.NET connections. E.g. Prototype generation uses ADO.NET, Import use ODBC.

Import in Win Admin is the only place which can benefit from SQL Native client driver with bulk copy capabilities. In other parts using ODBC the difference in performance between SQL Native Client and Microsoft ODBC Driver is insignificant.  
On SQL Server we are using the .NET version of the bulk copy functionality which is just as fast as the ODBC.
SORT.exe, SORTS.exe, SoTrvGate.exe, Reporter Studio - these use ODBC.

### DBSetup

DBSetup uses a mix of ODBC and ADO.NET connections. ODBC in DBsetup is mainly for historical reasons and is not actually used for database setup, upgrade, export and import; those have all been rewritten to C# and use ADO.net.

### **Web client / NetServer**

NetServer use ADO.NET connection only. Web client doesn't have its own database connection and uses NetServer to connect to a database and so\_arc. The only part of a Web client which has its own connection is Web Reporter and it uses ODBC connection.

### Service

Service uses both ODBC and NetServer connection.

### Migration Tool

Migration Tool uses ADO.NET to connect to the database. It also uses Win client to read some information from the SuperOffice database. If Win client is not installed a user will get the following dialog and will have to type in the answers manually.

![Migration Tool][img1]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/dd952b42-6d72-454f-a4de-8af1e500b04d.png
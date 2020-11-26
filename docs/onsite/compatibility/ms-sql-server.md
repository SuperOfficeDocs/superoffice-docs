---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tested_ms_sql_server  # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tested Microsoft SQL Server versions # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Tested Microsoft SQL Server

SuperOffice CRM has officially been tested on MS SQL Server 2012, 2014, 2016, 2017 and 2019.

| SQL Server | Server version | ODBC driver | Driver version |
|------------|----------------|-------------|----------------|
| SQL Server 2019 | 15.0.2000.5   | ODBC Driver 17 for SQL Server | 17.4.2.1 |
| SQL Server 2017 | 14.0.1000.169 | ODBC Driver 17 for SQL Server |2017.171.00.01
| SQL Server 2016 | 13.0.1601.5   | ODBC Driver 13 for SQL Server | 2015.131.811.168 |
| SQL Server 2014 | 12.0.2000.8   | ODBC Driver 13 for SQL Server | 2015.131.811.168 |
| SQL Server 2012 | 11.0.2100.60  | SQL Native Client 11.0 | 2011.110.1750.32<br/>SQLNCLI11.DLL |

## Compatibility

Our compatibility tests have been performed on both Enterprise and Standard editions of [SQL Server 2012][1]. When looking at the specification for the different versions, the other versions of SQL Server 2012 should also work. The only functionality we "may" use (not required), is "Full-text and semantic search". So when choosing your SQL Server 2012 version, make sure it covers your needs.

[!include[legend](./includes/caution-odbc-drivers.md)]

<!--Referenced links-->
[1]: http://msdn.microsoft.com/en-us/library/cc645993.aspx

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tested_databases         # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tested databases   # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                    # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Databases supported by SuperOffice CRM 8 and 9

Our experience tells us that other configurations also should work but SuperOffice will not guarantee for any other configurations than the ones listed below.

[!include[ODBC driver caution](./includes/caution-odbc-drivers.md)]

For database specific system requirements, check the vendor [Microsoft](https://msdn.microsoft.com/en-us/library/ms143506.aspx) or [Oracle](https://docs.oracle.com/en/database/).

| Database |8.0, 8.0 SR1 | 8.0 SR2 - SR6 | 8.1 | 8.2 | 8.3 | 8.4 | 8.5 | 9.1 |
|-------------------------|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| MS SQL Server 2019 | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][1] | ![][1] |
| MS SQL Server 2017 | ![][3] | ![][3]\* | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| MS SQL Server 2016 | ![][3] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| MS SQL Server 2014 | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| MS SQL Server 2012 SP1, SP2 | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| MS SQL Server 2008 R2\*\*\* | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][3] | ![][3] |
| Oracle 18c | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][3] | ![][1]\*\*| ![][1] |
| Oracle 12c | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] |
| Oracle 11g | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][1] | ![][3] | ![][3] |

\* See [compatibility reports](reports.md)

\*\* See Oracle 18c compatibility info

\*\*\* Microsoft has finished Extended support for this product

## Oracle 18c compatibility

[!include[Oracle 18c caution](./includes/oracle-18c-drivers.md)]

## Legend

[!include[legend](./includes/test-legend.md)]

<!--Referenced icons-->
[1]: ../../media/icons/testedyes.png
[2]: ../../media/icons/testedno.png
[3]: ../../media/icons/testednotyet.png
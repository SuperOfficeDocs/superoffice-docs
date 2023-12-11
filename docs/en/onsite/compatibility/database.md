---
title: Tested databases
uid: tested_databases
description: Tested databases
author: {github-id}
so.date: 09.12.2023
keywords:
so.topic: reference
so.envir: onsite
# so.client:
---

# Databases supported by SuperOffice CRM

Our experience tells us that other configurations also should work but SuperOffice will not guarantee any other configurations than the ones listed below.

[!include[ODBC driver caution](./includes/caution-odbc-drivers.md)]

For database-specific system requirements, check the vendor [Microsoft][1] or [Oracle][2].

| Database           | 8.0, SR1 | 8.0 SR2 - SR6 | 8.1 - 8.4 | 8.5 | 9 | 10 |
|--------------------|:--:|:--:|:--:|:--:|:--:|:--:|
| MS SQL Server 2022 | ![i][img3] | ![i][img3]   | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1] |
| MS SQL Server 2019 | ![i][img3] | ![i][img3]   | ![i][img3] | ![i][img1] | ![i][img1] | ![i][img1] |
| MS SQL Server 2017 | ![i][img3] | ![i][img3]\* | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] |
| MS SQL Server 2016 | ![i][img3] | ![i][img1]   | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] |
| MS SQL Server 2014 | ![i][img1] | ![i][img1]   | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] |
| MS SQL Server 2012 | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] |
| MS SQL Server 2008 R2 | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] | ![i][img3] | ![i][img3] |
| Oracle 18c         | ![i][img3] | ![i][img3] | ![i][img3] | ![i][img1]\*\*| ![i][img1]\*\* |  ![i][img1]\*\* |
| Oracle 12c         | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] |
| Oracle 11g         | ![i][img1] | ![i][img1] | ![i][img1] | ![i][img3] | ![i][img3] | ![i][img3] |

\* See the [compatibility reports][3].

\*\* See Oracle 18c compatibility info.

> [!NOTE]
> MS SQL Server 2012 reached end of support on July 12, 2022.
>
> MS SQL Server 2008 R2 reached end of support on July 9, 2019.
>
> Oracle 12c reached end of support on July 31, 2022.
>
> Oracle 11g reached end of support on December 31, 2020.

## Oracle 18c compatibility

[!include[Oracle 18c caution](./includes/oracle-18c-drivers.md)]

## Legend

[!include[legend](./includes/test-legend.md)]

<!--Referenced links-->
[1]: https://msdn.microsoft.com/en-us/library/ms143506.aspx
[2]: https://docs.oracle.com/en/database/
[3]: index.md

<!--Referenced icons-->
[img1]: ../../media/icons/testedyes.png
[img3]: ../../media/icons/testednotyet.png

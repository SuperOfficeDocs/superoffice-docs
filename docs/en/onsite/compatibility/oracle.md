---
title: Oracle versions
uid: tested_oracle
description: Tested Oracle versions
author: {github-id}
date: 09.12.2023
keywords:
topic: reference
envir: onsite
# client:
---

# Tested Oracle versions

SuperOffice CRM has been officially tested on Oracle 11g, 12c, and 18c.

| Server | Client | Version | ODBC driver |
|---|---|---|---|
| Oracle 18c | Oracle 18c Client | 18.3.0.0.0 | See Oracle 18c compatibility |
| Oracle 12c | Oracle 12c Client | 12.1.0.1.0 | Oracle in OraClient 12home 12.01.00.01 |
| Oracle 11g Release 2 | Oracle 11g Client |  11.2.0.1.0 | Oracle in Orahome11 v. 11.2.0.3.0 or 11.2.0.1.0 |
| Oracle 11g Release 1 | Oracle 11g Client | 11.1.0.7.0 or 11.1.0.6.0 | Oracle in Orahome11 v. 11.1.0.7.0 or 11.1.0.6.0 |

For Oracle 12c and 11g, use driver file *SQORA32.DLL*.

## Oracle 18c compatibility

[!include[Oracle 18c caution](./includes/oracle-18c-drivers.md)]

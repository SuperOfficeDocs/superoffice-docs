---
uid: help-en-parameter-examples
title: Parameter examples
description: Parameter examples
author: SuperOffice RnD
date: 06.29.2022
keywords: Settings and maintenance
topic: help
language: en
---

# Examples of the use of parameters in *.ini-files

The following gives you examples of how to use the parameters.

## Example 1

Example with a central ODBC database with Data Source Name SuperOffice, not Travel

**SuperOffice.ini:**

```txt
[SuperOffice]
Archivepath=\\Server\SuperOffice\SO-ARC
Datapath=ODBC:SuperOffice
```

## Example 2

Example with a central ODBC database, Data Source Name Saleserver, document archive and templates in different locations and Travel installed with a local ODBC database (MSDE or Sybase)

**SuperOffice.ini:**

```txt
[SuperOffice]
Archivepath=\\Server2\SuperOffice\SO-ARC
Datapath=ODBC:Saleserver
Templatepath=\\Server3\COMMON\TEMPLATE 
```

**SOUSER.INI:**

```txt
[SuperOffice]
Travel=TRUE
Local-archivepath=C:\"username"\AppData\Local\SuperOffice\So-Local
Local-datapath=ODBC:SuperOfficeLocal
```

> [!TIP]
> You can find the latest information about, among other things, settings in **SuperOffice.ini** and **SOUSER.INI** [in the onsite section][1].

<!-- Referenced links -->
[1]: ../../../../en/travel/index.md

<!-- Referenced images -->

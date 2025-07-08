---
uid: help-sv-parameter-examples
title: Parameterexempel
description: Parameterexempel
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar och underhåll
content_type: howto
language: sv
---

# Exempel på användning av parametrar i \*.ini-filer

Nedan visas några exempel på hur parametrar kan användas.

## Exempel 1

Exempel på en central ODBC-databas med Data Source Name SuperOffice, utan Travel

**SuperOffice.ini:**

```txt
[SuperOffice]
Archivepath=\\Server\SuperOffice\SO-ARC
Datapath=ODBC:SuperOffice
```

## Exempel 2

Exempel på en central ODBC-databas med Data Source Name Saleserver, dokumentarkiv och mallar på olika ställen och Travel installerat med lokal ODBC-bas (MSDE eller Sybase)

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
> Du hittar den senaste informationen om bland annat inställningar i **SuperOffice.ini** och **SOUSER.INI** [i det lokala avsnittet][1].

<!-- Referenced links -->
[1]: ../../../../en/onsite/travel/index.md

<!-- Referenced images -->

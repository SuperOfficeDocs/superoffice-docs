---
uid: help-da-parameter-examples
title: Eksempler på parametre
description: Eksempler på parametre
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger og vedligeholdelse
topic: help
language: da
---

# Eksempler på brug af parametre i \*.ini-filer

Følgende giver dig eksempler på, hvordan du skal bruge parametrene.

## Eksempel 1

Eksempel med en central ODBC-database med Data Source Name SuperOffice, ikke Travel

**SuperOffice.ini:**

```txt
[SuperOffice]
Archivepath=\\Server\SuperOffice\SO_ARC
Datapath=ODBC:SuperOffice
```

## Eksempel 2

Eksempel med en central ODBC-database, Data Source Name Saleserver, dokumentarkiv og skabeloner forskellige steder og Travel installeret med en lokal ODBC-database (MSDE eller Sybase)

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
> Du kan finde de nyeste informationer om blandt andet indstillinger i **SuperOffice.ini** og **SOUSER.INI** [i sektionen på stedet][1].

<!-- Referenced links -->
[1]: ../../../../en/travel/index.md

<!-- Referenced images -->

---
uid: help-no-parameter-examples
title: Eksempler på parametere
description: Eksempler på parametere
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger og vedlikehold
topic: help
language: no
---

# Eksempler på bruk av parametere i \*.ini-filer

Nedenfor finner du noen eksempler på hvordan parameterne kan brukes.

## Eksempel 1

Eksempel med sentral ODBC-database med Data Source Name SuperOffice, ikke Travel

**SuperOffice.ini:**

```txt
[SuperOffice]
Archivepath=\\Server\SuperOffice\SO-ARC
Datapath=ODBC:SuperOffice
```

## Eksempel 2

Eksempel med sentral ODBC-database, Data Source Name Saleserver, dokumentarkiv og maler på forskjellige steder og Travel installert med lokal ODBC-database (MSDE eller Sybase)

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
> Du finner helt oppdatert informasjon om blant annet innstillingene i **SuperOffice.ini** og **SOUSER. INI** [i onsite-seksjonen][1].

<!-- Referenced links -->
[1]: ../../../../en/travel/index.md

<!-- Referenced images -->

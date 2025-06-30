---
uid: help-de-parameter-examples
title: Parameterbeispiele
description: Parameterbeispiele
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen und Verwaltung
content_type: howto
language: de
---

# Beispiele für die Verwendung von Parametern in \*.ini-Dateien

Es folgen einige Beispiele für die Verwendung der Parameter.

## Beispiel 1

Beispiel einer zentralen ODBC-Datenbank mit dem Datenquellennamen SuperOffice (nicht Travel)

**SuperOffice.ini:**

```txt
[SuperOffice]
Archivepath=\\Server\SuperOffice\SO-ARC
Datapath=ODBC:SuperOffice
```

## Beispiel 2

Beispiel einer zentralen ODBC-Datenbank, Datenquellenname Saleserver, Dokumentarchiv und Vorlagen an verschiedenen Positionen und Travel mit einer lokalen ODBC-Datenbank installiert (MSDE oder Sybase)

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
> Die aktuellsten Informationen finden Sie unter anderem zu Einstellungen in der Datei **SuperOffice.ini** und **SOUSER.INI** [im Vor-Ort-Bereich][1].

<!-- Referenced links -->
[1]: ../../../../en/travel/index.md

<!-- Referenced images -->

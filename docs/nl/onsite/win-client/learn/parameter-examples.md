---
uid: help-nl-parameter-examples
title: Voorbeelden van parameters
description: Voorbeelden van parameters
author: SuperOffice RnD
date: 06.29.2022
keywords: Instellingen en onderhoud
content_type: howto
language: nl
---

# Voorbeelden van het gebruik van parameters in \*.ini-bestanden

Hieronder vindt u voorbeelden van de manier waarop u de parameters moet gebruiken.

## Voorbeeld 1

Voorbeeld met een centrale ODBC-database met de gegevensbronnaam SuperOffice, niet Travel

**SuperOffice.ini:**

```txt
[SuperOffice]
Archivepath=\\Server\SuperOffice\SO-ARC
Datapath=ODBC:SuperOffice
```

## Voorbeeld 2

Voorbeeld met een centrale ODBC-database, gegevensbronnaam-verkoopserver, documentarchief en sjablonen op verschillende locaties en Travel geïnstalleerd met een lokale ODBC-database (MSDE of Sybase)

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
> De laatste informatie over onder meer instellingen in **SuperOffice.ini** en **SOUSER.INI** vindt u [op de onsite sectie][1].

<!-- Referenced links -->
[1]: ../../../../en/onsite/travel/index.md

<!-- Referenced images -->

---
uid: help-sv-import-routines
title: Importrutiner
description: Importrutiner
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: concept
language: sv
client: win
envir: onsite
---

# Importrutiner

Det finns två viktiga saker att komma ihåg innan du importerar data:

* Om du har en befintlig SuperOffice-databas som du vill importera data till, måste du göra en säkerhetskopiera innan du börjar. Om något går fel under importen, är det bäst att börja om med den ursprungliga databasfilen. (Se [Rutiner för säkerhetskopiering][8].)

* Datafilen som du importerar från måste vara en textfil, och närmare bestämt en Windows-baserad [ANSI-fil][1]. Det innebär att om ditt kundindex till exempel sparas i Excel, måste du spara Excel-filen som en textfil innan du kan importera data från den till SuperOffice-databasen. Du kan kontrollera filformatet genom att öppna den i Excel. Filen ska vara av filtypen **TXT** (till exempel **IMPORT.TXT**), och du måste veta vilken mapp filen finns i.

> [!NOTE]
> Du kan inte importera filer med fält med fast längd till SuperOffice-databasen om inte fälten är avgränsade.

## Relaterade ämnen

* [ANSI-filer][1]
* [Importera filer][2]
* [Fälttilldelning][3]
* [Ange avancerade importinställningar][4]
* [Dubbletter][5]
* [Importbeskrivningar][6]
* [Uppdatera information i databasen][7]

<!-- Referenced links -->
[1]: ansi-files.md
[2]: importing-files.md
[3]: field-mapping.md
[4]: specifying-advanced-import-settings.md
[5]: duplicates-import.md
[6]: import-descriptions.md
[7]: ../update-database.md
[8]: ../backup-routines.md

<!-- Referenced images -->

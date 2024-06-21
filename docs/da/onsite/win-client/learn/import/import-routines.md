---
uid: help-da-import-routines
title: Importrutiner
description: Importrutiner
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Importrutiner

Der er to vigtige ting, du skal huske, før du importerer data:

* Hvis du har en eksisterende SuperOffice-database, som du vil importere data til, skal du udføre en sikkerhedskopiering, før du starter. Hvis noget går galt under importen, er det bedst at starte igen med den oprindelige databasefil. (Se [Rutiner for sikkerhedskopiering][8].)

* Den datafil, du importerer fra, skal være en tekstfil og specifikt en Windows-baseret [ANSI-fil][1]. Det betyder, at hvis dit kundeindeks f.eks. gemmes i Excel, skal du gemme Excel-filen som en tekstfil, før du kan importere dataene fra den til SuperOffice-databasen. Du kan kontrollere filformatet ved at åbne det i Excel. Filen skal have filtypen **TXT** (f.eks. **IMPORT.TXT**), og du skal vide, hvilken mappe filen er i.

> [!NOTE]
> Du kan ikke importere filer med felter med fast længde til SuperOffice-databasen, medmindre felterne er afgrænsede.

## Relaterede emner

* [ANSI-filer][1]
* [Import af filer][2]
* [Felttilknytning][3]
* [Angivelse af avancerede importindstillinger][4]
* [Dubletter][5]
* [Importbeskrivelser][6]
* [Opdatering af oplysninger i databasen][7]

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

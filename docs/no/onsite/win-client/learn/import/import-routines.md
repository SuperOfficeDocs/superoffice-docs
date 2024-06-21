---
uid: help-no-import-routines
title: Importrutiner
description: Importrutiner
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Importrutiner

Det er to ting som er svært viktig å huske på før du importerer data:

* Hvis du har en SuperOffice-database fra før som du vil importere data til, må du ta en sikkerhetskopi av den før du starter. Hvis noe går galt under importen, er det best å starte på nytt med den opprinnelige databasefilen. (Se [Rutiner for sikkerhetskopiering][8].)

* Datafilen du skal importere fra, må være en tekstfil, nærmere bestemt en Windows-basert [ANSI-fil][1]. Det betyr at hvis kunderegisteret ditt er laget i for eksempel Excel, må du lagre Excel-filen som en tekstfil før du kan importere dataene fra den og inn i SuperOffice-databasen. Du kan sjekke filformatet ved å åpne filen i Excel. Filen bør ha filtypen **TXT** (for eksempel **IMPORT.TXT**), og du må vite hvilken mappe filen ligger i.

> [!NOTE]
> Du kan ikke importere filer med fast lengde i SuperOffice-databasen hvis du ikke har skilletegn mellom feltene.

## Aktuelle emner

* [ANSI-filer][1]
* [Importere filer][2]
* [Felttilordning][3]
* [Angi avanserte importinnstillinger][4]
* [Duplikater][5]
* [Importbeskrivelser][6]
* [Oppdatere informasjon i databasen][7]

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

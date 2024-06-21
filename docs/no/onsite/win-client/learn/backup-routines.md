---
uid: help-no-backup-routines
title: Rutiner for sikkerhetskopiering
description: Rutiner for sikkerhetskopiering
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Rutiner for sikkerhetskopiering

Hvis det skulle oppstå en databasefeil, er det svært viktig at du har gode rutiner for sikkerhetskopiering. Sikkerhetskopiering kan virke som en triviell oppgave når du må bruke tid på det hver dag, men hvis noe går galt, kan feilen ofte rettes opp raskt hvis du har en kopi av databasen fra dagen før.

Tenk deg at du har bygget opp en firmadatabase med 1500 firmaer i løpet av et år. Du har brukt SuperOffice CRM hver dag og registrert firmaer som du ringer til og følger opp hver uke. Du har lagt inn avtaler for lang tid fremover, og du har registrert alle dokumenter og oppfølginger i SuperOffice CRM. Men du har du "glemt" å ta sikkerhetskopi de siste seks månedene.

En dag du kommer på jobb, har det oppstått en feil på harddisken som ikke kan rettes opp umiddelbart. Du ringer SuperOffice og får spørsmål om du tok sikkerhetskopi i går.

Se for deg at du må bruke en seks måneder gammel sikkerhetskopi. Hvor mange viktige firmaer har du lagt til etter det? Hvor mange viktige telefonnumre lå i databasen? Hvor mange adresser?

> [!NOTE]
> Husk at databaser og disker ikke er feilfrie. Feil kan oppstå, og ditt viktigste hjelpemiddel er gode rutiner for sikkerhetskopiering. Det anbefales å ta sikkerhetskopi hver dag.

## Slik sikkerhetskopierer du bare datafilen

* Hvis du vil ta sikkerhetskopi av en SQL-database, følger du retningslinjene for sikkerhetskopiering som er beskrevet i dokumentasjonen for den aktuelle SQL-databasen. Dette genererer en database som bare kan brukes sammen med databasen den er generert fra. Dette er den raskeste metoden for sikkerhetskopiering.

* Åpne filen **dbsetup.exe** i SuperOffice Server-mappen, og velg alternativet **Export a database to file**. Dette genererer en database som kan installeres på alle servertyper som støttes av SuperOffice CRM.

Hvis du også vil ta sikkerhetskopi av alle dokumenter og maler, må du lage en sikkerhetskopi av hele **SO_ARC**-mappen med tilhørende undermapper.

<!-- online --> Online customers must contact SuperOffice Support to create a backup.

---
uid: help-sv-backup-routines
title: Rutiner för säkerhetskopiering
description: Rutiner för säkerhetskopiering
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: concept
language: sv
client: win
deployment: onsite
---

# Rutiner för säkerhetskopiering

Om ett databasfel uppstår är det mycket viktigt att du har bra rutiner för säkerhetskopiering. Säkerhetskopiering kan verka omständigt när du måste avsätta tid för det varje dag, men om något går snett kan felen ofta snabbt korrigeras om du har en kopia av databasen från föregående dag.

Anta att du har byggt upp en företagsdatabas med 1500 företag under loppet av ett år. Du använder SuperOffice CRM varje dag och registrerar företag som du ringer till och följer upp varje vecka. Du har lagt in bokningar för lång tid framöver och du har registrerat alla dokument och händelser i SuperOffice CRM. Dessvärre har du "glömt" att ta en säkerhetskopia på de sista sex månaderna.

En dag när du kommer till jobbet har det uppstått ett fel på hårddisken som inte kan korrigeras utan vidare. Du ringer till SuperOffice, som frågar dig om du tog någon säkerhetskopia i går.

Anta att du måste använda en sex månader gammal säkerhetskopia. Hur många företag har du registrerat sedan dess? Hur många viktiga telefonnummer låg i databasen? Hur många adresser?

> [!NOTE]
> Kom ihåg att databaser och disketter inte är felsäkra. Fel kan uppstå och ditt viktigaste hjälpmedel är bra rutiner för säkerhetskopiering. Vi rekommenderar att du tar en säkerhetskopia varje dag.

## Om du enbart vill ta en säkerhetskopia av datafilen

* Om du vill ta en säkerhetskopia av en SQL-databas följer du de riktlinjer för säkerhetskopiering som står i dokumentationen för den aktuella SQL-databasen. Detta genererar en databas som bara kan användas tillsammans med den databas den är genererad från. Det är den snabbaste metoden för säkerhetskopiering.

* Öppna filen **dbsetup.exe** i SuperOffice Server-mappen och välj alternativet **Export a database to file**. Detta genererar en databas som kan installeras på alla servertyper som stöds av SuperOffice CRM.

Om du dessutom vill ta en säkerhetskopia av alla dokument och mallar måste du göra en säkerhetskopia av hela **SO_ARC**-mappen med tillhörande undermappar.

<!-- online --> Online customers must contact SuperOffice Support to create a backup.

---
uid: help-da-backup-routines
title: Rutiner for sikkerhedskopiering
description: Rutiner for sikkerhedskopiering
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Rutiner for sikkerhedskopiering

Hvis der opstår en databasefejl, er det ekstremt vigtigt, at du har gode backup-rutiner. Sikkerhedskopiering kan virke som en triviel opgave, fordi du skal bruge tid på det hver dag, men hvis noget går galt, kan fejlen ofte rettes hurtigt, hvis du har en kopi af databasen fra dagen før.

Forestil dig, at du har opbygget en firmadatabase med 1.500 firmaer i løbet af et år. Du bruger SuperOffice CRM hver dag og registrerer firmaer, som du ringer til og følger op på hver uge. Du har indtastet aftaler for lang tid fremover, og du har registreret alle dokumenter og opfølgninger i SuperOffice CRM. Desværre har du "glemt" at tage sikkerhedskopier de sidste seks måneder.

Da du en dag kommer på arbejde, er der sket en fejl på harddisken, der ikke uden videre kan rettes. Du ringer til SuperOffice og bliver spurgt, om du tog sikkerhedskopi i går.

Forestil dig, at du skal bruge en seks måneder gammel sikkerhedskopi. Hvor mange større virksomheder har du tilføjet efterfølgende? Hvor mange vigtige telefonnumre lå der i databasen? Hvor mange adresser?

> [!NOTE]
> Husk, at databaser og harddiske ikke er fejlfri. Der kan opstå fejl, og dit vigtigste hjælpemiddel er gode rutiner for sikkerhedskopiering. Det anbefales at tage sikkerhedskopi hver dag.

## Når du kun vil tage sikkerhedskopi af datafilen

* Hvis du vil tage sikkerhedskopi af en SQL-database, skal du følge de retningslinjer for sikkerhedskopiering, der er beskrevet i dokumentationen til den aktuelle SQL-database. Herved genereres en database, som kun kan bruges sammen med den database, den blev genereret fra. Dette er den hurtigste måde at sikkerhedskopiere på.

* Åbn filen **dbsetup.exe** i SuperOffice Server-mappen, og brug indstillingen **Eksporter en database til fil**. Herved genereres en database, som kan installeres på alle typer servere, der understøttes af SuperOffice CRM.

Hvis du derudover vil tage en sikkerhedskopi af alle dokumenter og skabeloner, skal du tage en sikkerhedskopi af hele **SO_ARC**-mappen med tilhørende undermapper.

<!-- online --> Online customers must contact SuperOffice Support to create a backup.

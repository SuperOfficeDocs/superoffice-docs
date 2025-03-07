---
uid: help-da-request-status
title: Sagsstatus
description: Alle sager i SuperOffice har en status, såsom Åben, Lukket eller Udsat. Lær, hvordan du administrerer sagsstatusser i Indstillinger og vedligeholdelse.
keywords: sagsstatus, status, sager, statusindstillinger
author: Hanne Gunnarsson
date: 03.07.2025
version: 10.5.2
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Sagsstatus

Alle sager, der er registreret i SuperOffice, har en status, for eksempel **Åben**, **Lukket** eller **Udsat**. Vælg **Sag** i navigatoren. På fanen **Sagsstatus** kan du se de sagsstatusser, der allerede er defineret i systemet, og du kan oprette yderligere sagsstatusser. En sagsstatus skal være knyttet til en af systemets interne statusser som for eksempel **Åben** eller **Lukket**. Hver interne status skal knyttes til mindst én sagsstatus.

Du kan f.eks. oprette en ny status, der hedder "Venter på svar", og som er en mere detaljeret variant af enten **Afsluttet** eller **Aktiv**, alt efter hvordan du ønsker, systemet internt skal behandle og rapportere denne status. Du kan også knytte en brugerdefineret logik til sådanne statusser for at optimere dine brancheprocesser.

## Indstillinger

| Indstilling | Beskrivelse |
|---|---|
| Navn | Navnet på sagsstatussen. Som standard har hver intern status en sagsstatus med samme navn. |
| Intern status | Systemets interne statusser. Hver interne status skal knyttes til mindst én sagsstatus. Systemstatusserne **Sammenlagt** og **Slettet** anvendes kun til henholdsvis flettede sager og slettede sager og er ikke synlige for brugerne. |
| Standard | Angiver, om dette er en standardstatus for den interne status. |
| Køstatus | Angiver, om sager med denne status skal anbringes i køen. Dette er relevant, hvis du bruger funktionen **Svar næste sag i køen** . |
| Registrer tid som | Bruges til at rapportere tidsforbrug i forskellige faser af sagsbehandlingen. Systemet beregner den brugte tid i forhold til definerede "åbningstider" og hele 24-timers perioden. Vælg mellem: i kø og afventer behandling; i den interne beslutningsfase; i den eksterne beslutningsfase |

## Relateret inhold

* [Opret sagsstatus][1]
* [Slet sagsstatus][2]
* [Opsæt Svar næste sag i køen][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../next-in-queue.md

---
uid: help-no-request-status
title: Saksstatus
description: Saksstatus
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: sak, status
so.topic: concept
so.user: admin
so.user.tooltip: Settings and maintenance
language: no
---

# Saksstatus

Alle saker som registreres i SuperOffice, har en status, for eksempel **Åpen**, **Avsluttet** eller **Utsatt**. Velg **Sak** i navigatoren, og i fanen **Saksstatus** kan du se saksstatusene som allerede er definert i systemet, og opprette flere saksstatuser. En saksstatus må knyttes til en av systemets interne statuser, for eksempel **Åpen** eller **Avsluttet**. Hver eneste interne status må være tilknyttet minst én saksstatus.

Du kan for eksempel opprette en ny status som heter "Venter på svar", og som er en mer detaljert variant av enten **Avsluttet** eller **Åpen**, avhengig av hvordan du vil at systemet internt skal behandle og rapportere denne statusen. Du kan også knytte egendefinert logikk til slike statuser for å strømlinjeforme prosessene i virksomheten.

## Innstillinger

| Innstilling | Beskrivelse |
|---|---|
| Navn | Navnet på saksstatus. Som standard har hver interne status en saksstatus med samme navn. |
| Intern status | Systemets interne statuser. Hver eneste interne status må være tilknyttet minst én saksstatus. Systemstatusene **Koblet** og **Slettet** brukes bare for henholdsvis sammenslåtte saker og slettede saker, og er ikke synlige for brukere. |
| Standard | Angir om dette er en standardstatus for den interne statusen. |
| Køstatus | Angir om saker med denne statusen skal plasseres i køen. Relevant hvis du bruker funksjonen **Hent neste sak i køen**. |
| Registrer tid som | Brukes til å rapportere tidsbruk i ulike faser av saksbehandlingen. Systemet beregner tid brukt både i henhold til fastsatte "åpningstider" samt hele døgn. Velg mellom i kø og venter på behandling; på internt beslutningsstadium; på eksternt beslutningsstadium |

## Hva vil du gjøre nå?

* [Opprette saksstatus][1]
* [Slette saksstatus][2]
* [Sett opp Hent neste sak i køen][3].

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../next-in-queue.md

<!-- Referenced images -->

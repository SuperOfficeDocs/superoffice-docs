---
uid: help-no-request-status
title: Saksstatus
description: Saksstatus
keywords: saksstatus, Saksstatus-fanen, sak, status
author: Hanne Gunnarsson
date: 02.05.2025
version: 10.5.1
topic: concept
license: serviceessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Saksstatus

Alle saker som registreres i SuperOffice, har en status, for eksempel **Åpen**, **Avsluttet** eller **Utsatt**. I **Saker**-bildet i **Innstillinger og vedlikehold**, under **Saksstatus**, kan du se hvilke saksstatuser som allerede er definert i systemet, samt opprette nye statuser.

Hver saksstatus må knyttes til én av systemets interne statuser, for eksempel **Åpen** eller **Avsluttet**. Hver interne status må ha minst én tilknyttet saksstatus.

For eksempel kan du opprette en ny status kalt "Venter på svar" som en mer detaljert variant av enten **Avsluttet** eller **Åpen**, avhengig av hvordan du ønsker at systemet skal behandle og rapportere denne statusen internt. Du kan også knytte egendefinerte regler til slike statuser for å optimalisere forretningsprosessene dine.

## Innstillinger

| Innstilling | Beskrivelse |
|---|---|
| Navn | Navnet på saksstatusen. Som standard har hver interne status en saksstatus med samme navn. |
| Intern status | Systemets interne statuser. Hver interne status må være knyttet til minst én saksstatus. Systemstatusene **Koblet** og **Slettet** brukes kun for henholdsvis sammenslåtte saker og slettede saker, og er ikke synlige for brukerne. |
| Standard | Angir om dette er standardstatusen for den interne statusen. |
| Køstatus | Angir om saker med denne statusen skal plasseres i køen. Dette er relevant hvis du bruker funksjonen **Hent neste sak i køen**. |
| Registrer tid som | Brukes til å rapportere tidsbruk i ulike faser av saksbehandlingen. Systemet beregner tidsbruk både ut fra fastsatte "åpningstider" og et 24-timers døgn. Velg mellom: i kø og venter på behandling, på internt beslutningsstadium, eller på eksternt beslutningsstadium. |

## Relatert innhold

* [Opprette saksstatus][1]
* [Slette saksstatus][2]
* [Sett opp Hent neste sak i køen][3]

<!-- Refererte lenker -->
[1]: create.md
[2]: delete.md
[3]: ../next-in-queue.md

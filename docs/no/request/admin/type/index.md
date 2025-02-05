---
uid: help-no-request-type
title: Sakstype
description: Sakstype
keywords: sakstype, fanen Sakstyper, type, sak
author: Bergfrid Dias
date: 02.05.2025
version: 10.5.1
topic: concept
license: servicepremium
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Sakstype

Alle saker som er registrert i SuperOffice har en type. Standardtypen er "Sak". For å se, legge til, oppdatere og slette sakstyper, gå til **Innstillinger og vedlikehold**.

> [!NOTE]
> Denne funksjonen krever en Service Premium-brukerplan (for å opprette og oppdatere sakstyper) og en Development Tools-lisens for å definere layouter basert på sakstyper i Skjermdesigner.

## Hvorfor bruke sakstyper?

Hovedfordelen med sakstyper er effektiv kundestøtte. En spesifikk sakstype tilpasses en bestemt prosess og de attributtene som kreves.

## Eksempel

Økonomiavdelingen bruker saker for å håndtere innkommende fakturakrav og må derfor ha et eget felt for fakturanummer. Salgsavdelingen bruker på sin side saker for å håndtere leads, hvor fakturanummer ikke er relevant og derfor bør skjules.

## Hvor finner jeg sakstypene?

* I **Innstillinger og vedlikehold**, velg **Saker** i navigatoren og deretter fanen **Sakstyper**.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Innstillinger

| Innstilling | Beskrivelse |
|---|---|
| Navn | Navnet på sakstypen. |
| Beskrivelse | Forklarer formålet med sakstypen. |
| Ikon | Visuell etikett for sakstypen. Velg fra forhåndsdefinerte alternativer. Standard: billettikon. |
| Bruk som standard | Angir om denne sakstypen skal være standard for nye saker. |
| Tilgjengelige statuser | Begrens listen over saksstatuser som er relevante for denne typen. Tomt felt betyr at alle statuser er tilgjengelige. |
| Standardstatus | Den [statusen][4] som settes når en agent oppretter en ny sak. Påkrevd hvis **Tilgjengelige statuser** er angitt. |
| Tilgjengelige prioriteter | Begrens listen over saksprioriteter som er relevante for denne typen. Tomt felt betyr at alle prioriteringer er tilgjengelige. |
| Standard prioritet | Den [prioriteten][3] som settes når en agent oppretter en ny sak. Påkrevd hvis **Tilgjengelige prioriteter** er angitt. |
| Svarmal | Den [svarmalen][5] som brukes når en agent svarer på en sak av denne typen. |

## Relatert innhold

* [Legg til sakstype][1]
* [Slett sakstype][2]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

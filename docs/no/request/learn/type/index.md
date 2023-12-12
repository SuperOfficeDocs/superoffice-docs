---
uid: help-no-request-type
title: Sakstype
description: Sakstype
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: sak, type
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Sakstype

Alle saker som er registrert i SuperOffice har en type. Standardtypen er "Request". For å se, legge til, oppdatere og slette sakstyper, gå til **Innstillinger og vedlikehold**.

> [!NOTE]
> Denne funksjonen krever en Service Premium brukerplan (for å opprette og oppdatere sakstyper) og en Development Tools lisens for å definere skjermlayouter basert på sakstyper i Screen Designer. (Bare tilgjengelig i pilot.)

## Hvorfor bruke sakstyper?

Den viktigste fordelen med sakstyper er effektiv kundestøtte. En spesifikk sakstype retter seg mot en rekke attributter som er nødvendige for en spesifikk prosess.

## Eksempel

Finansteamet bruker saker for å håndtere innkommende fakturakrav, noe som krever synlighet av fakturanummeret som et angitt felt. På den annen side bruker salgsteamet saker for å håndtere innkommende leads. I tilfeller der en sak gjelder et lead, har fakturanummeret ingen relevans og bør skjules.

## Hvor finner jeg sakstypene?

* I **Innstillinger og vedlikehold**, velg **Saker** i navigatøren og deretter fanen **Sakstyper**.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Innstillinger

| Innstilling | Beskrivelse |
|---|---|
| Navn | Navnet på sakstypen. |
| Beskrivelse | Forklarer formålet med sakstypen.|
| Ikon | Brukes som en visuell etikett for å vise typen. Velg fra et sett med forhåndsdefinerte alternativer. Standard: billettikon.|
| Bruk som standard | Indikerer om dette er standardtypen for nye saker. |
| Tilgjengelige statuser | En delmengde av saksstatuser som er relevante for denne typen. Brukes til å filtrere rullegardinlisten i brukergrensesnittet. Tomt felt betyr at alle statuser er tilgjengelige. |
| Standard status | Den [statusen][4] som er satt når en agent oppretter en ny sak. Går foran andre preferanser. Obligatorisk hvis **Tilgjengelige statuser** er satt. |
| Tilgjengelige prioriteter | En delmengde av saksprioriteter som er relevante for denne typen. Brukes til å filtrere rullegardinlisten i brukergrensesnittet. Tomt felt betyr at alle prioriteter er tilgjengelige. |
| Standard prioritet | Den [prioriteten][3] som er satt når en agent oppretter en ny sak. Går foran andre preferanser. Obligatorisk hvis **Tilgjengelige prioriteter** er satt. |
| Svarmal | Den [svarmalen][5] som vil bli brukt når en agent svarer på en sak av denne typen. |

## Aktuelt innhold

* [Legg til sakstype][1]
* [Slett sakstype][2]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->

---
uid: help-da-request-type
title: Sagstype
description: Sagstype
keywords: sag, sagstype, type
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
content_type: concept
license: servicepremium
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from: /da/request/learn/type/index
index: true
---

# Sagstype

Alle sager, der er registreret i SuperOffice, har en type. Standardtypen er "Request". For at se, tilføje, opdatere og slette sagstyper, gå til **Indstillinger og vedligeholdelse**.

> [!NOTE]
> Denne funktion kræver en Service Premium brugerplan (til at oprette og opdatere sagstyper) og en Development Tools licens for at definere skærmlayouts baseret på sagstyper i Screen Designer.

## Hvorfor bruge sagstyper?

Den primære fordel ved sagstyper er effektiv support. En specifik sagstype retter sig mod en række attributter, der er nødvendige for en specifik proces.

## Eksempel

Finansholdet bruger sager til at håndtere indkomne fakturakrav og kræver synligheden af fakturanummeret som et angivet felt. Omvendt bruger salgsteam sager til at håndtere indkomne leads. I tilfælde hvor en sag vedrører et lead, har fakturanummeret ingen relevans og bør forblive helt udeladt fra visningen.

## Hvor finder jeg sagstyperne?

* Gå til **Indstillinger og vedligeholdelse**, vælg **Sager** i navigatoren og derefter fanen **Sagstyper**.

[!include[Begrænset adgang](../../../learn/includes/note-insufficient-rights.md)]

## Indstillinger

| Indstilling | Beskrivelse |
|---|---|
| **Navn** | Navnet på sagstypen. |
| **Beskrivelse** | Forklarer formålet med sagstypen. |
| **Ikon** | Bruges som en visuel etiket for at vise typen. Vælg fra et sæt foruddefinerede muligheder. Standard: billetikon. |
| **Anvend som standard** | Angiver, om dette er standardtypen for nye sager. |
| **Tilgængelige statusser** | En delmængde af sagsstatusser, der er relevante for denne type. Bruges til at filtrere rullelisten i UI. Tomt felt betyder, at alle statusser er tilgængelige. |
| **Standardstatus** | Den [status][4], der sættes, når en agent opretter en ny sag. Har forrang over andre præferencer. Obligatorisk, hvis **Tilgængelige statusser** er sat. |
| **Tilgængelige prioriteter** | En delmængde af sagsprioriteter, der er relevante for denne type. Bruges til at filtrere rullelisten i UI. Tomt felt betyder, at alle prioriteter er tilgængelige. |
| **Standardprioritet** | Den [prioritet][3], der sættes, når en agent opretter en ny sag. Har forrang over andre præferencer. Obligatorisk, hvis **Tilgængelige prioriteter** er sat. |
| **Svarskabelon** | Den [svarskabelon][5], der vil blive brugt, når en agent svarer på en sag. |

## Relateret indhold

* [Tilføj sagstype][1]
* [Slet sagstype][2]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

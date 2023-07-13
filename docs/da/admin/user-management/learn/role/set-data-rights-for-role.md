---
uid: help-da-role-set-data-rights
title: Angiv datarettigheder for rolle
description: Angiv datarettigheder for rolle
author: Bergfrid Dias
so.date: 03.15.2023
keywords: brugerstyring, rolle, adgang, rettigheder
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Angivelse af datarettigheder for rolle

[!include[Requirement](../includes/note-anon-req.md)]

Du kan angive rettigheder for [dataobjekter][2] baseret på, hvem der ejer objektet. Alle brugere, der tilhører denne [rolle][2] tildeles rettigheder baseret på de indstillinger, du foretager her.

## Trin

1. [!include[Open Roles](includes/open-roles.md)]

2. Vælg fanen **Medarbejdere** eller fanen **Ekstern**.

    [Sådan redigerer du rollen for anonyme brugere.][1]

3. Vælg den ønskede rolle på listen **Roller** . Rettighederne for den valgte rolle vises under fanen **Datarettigheder** .

4. Klik på ![ikonpilen][img3] ud for den rettighed, du vil ændre, og vælg den ønskede rettighed.

    | Navn | Rettigheder | Værktøjstip |
    |---|---|---|
    | Ingen | Ingen rettigheder | |
    | Læs | Læs rettigheder | R |
    | Opret | Læs og opret rettigheder | CR |
    | Opdater | Læs, opret og opdater rettigheder | CRU |
    | Slet | Læs, opret, opdater og slet rettigheder | CRUD |

    **C** = Opret, **R** = Læs, **U** = Opdater, **D** = Slet

    Ændringerne gemmes automatisk.

## Hvad betyder de forskellige kolonner under Data ejet af?

| Data ejet af | Forklaring|
|---|---|
| Min egen | Oprettet af dig |
| Primærgruppe (A) | Oprettet af din primære gruppe (afdeling) |
| Kopiér kontakt (E) | Oprettet af en ekstern brugers firma |
| Andre grupper (A) | Hér vises den brugergruppe, du tilhører |
| Samme projekt (E) | Oprettet i et projekt, som en ekstern bruger tilhører |
| Andre medarbejdere | Oprettet af andre medarbejdere i virksomheden |
| Ekstern bruger | Oprettet af eksterne brugere (målgruppebrugere) |
| Anonym | Oprettet af anonyme brugere |

* A = Medarbejdere
* E = Ekstern

## Hvordan viser jeg dataobjekter for eksterne brugere?

Hvis dataobjekterne (firmaer, projekter, dokumenter osv.) skal gøres tilgængelige for eksterne brugere (målgruppebrugere), er det ikke nok blot at tildele de eksterne brugere læseadgang (eller højere). Dataobjekterne skal også publiceres i SuperOffice.

## Rettigheder til rapporter

Alle SuperOffice CRM-brugere har adgang til skærmbilledet Rapporter, men de enkelte rapporter, du kan få adgang til, afhænger af de rettigheder, du har (rolle) i forhold til opfølgninger, dokumenter, salg og aktivitetslisten. I praksis betyder det, at du ikke kan generere rapporter for indhold, du ikke har tilladelse til at se.

<!-- Referenced links -->
[1]: edit-rights-for-anonymous-users.md
[2]: index.md

<!-- Referenced images -->
[img3]: ../../../../../media/icons/arrow-down.png

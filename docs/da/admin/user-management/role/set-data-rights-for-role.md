---
uid: help-da-role-set-data-rights
title: Angiv datarettigheder for rolle
description: Angiv datarettigheder for rolle
keywords: brugerstyring, rolle, adgang, rettigheder
author: digitaldiina
date: 03.27.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /da/admin/user-management/learn/role/set-data-rights-for-role
language: da
---

# Angivelse af datarettigheder for rolle

Du kan angive rettigheder for dataobjekter baseret på, hvem der ejer objektet. Alle brugere, der tilhører denne [rolle][2] tildeles rettigheder baseret på de indstillinger, du foretager her.

## Trin

1. [!include[Open Roles](../includes/open-roles.md)]

1. Vælg fanen **Medarbejdere**.

1. Vælg den ønskede rolle på listen **Roller** . Rettighederne for den valgte rolle vises under fanen **Datarettigheder** .

1. Klik på <i class="ph ph-caret-down" aria-label="Chevron"></i> ud for den rettighed, du vil ændre, og vælg den ønskede rettighed.

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

| **Data ejet af** | **Dashboards og dokumenter** | **Salg og opfølgninger** | **Projekter** | **Firma og person** |
|---|---|---|---|---|
| Min egen | Oprettet af dig | Ejer-felt anvendes | Ansvarlig-felt anvendes | Du er "Vores kontakt" |
| Primærgruppe (A) | Oprettet af din primære gruppe (afdeling) | Ejer-felt anvendes | Ansvarlig-felt anvendes | "Vores kontakt" er en medarbejder i din primære gruppe |
| Andre grupper (A) | Oprettet af en brugergruppe, du tilhører | Ejer-felt anvendes | Ansvarlig-felt anvendes | "Vores kontakt" er en medarbejder i en gruppe, du tilhører |
| Andre medarbejdere | Oprettet af andre medarbejdere i virksomheden | Ejer-felt anvendes | Ansvarlig-felt anvendes | "Vores kontakt" er en medarbejder, du ikke deler gruppe med |
| Anonym | Oprettet af anonyme brugere | Ikke relevant | Ikke relevant | Ikke relevant |

**A** = medarbejdere

På personkortet hentes feltet **Vores kontakt** altid fra firmakortet, som personen tilhører.

## Relateret indhold

* [Datarettigheter][3]
* [Onsite-datarettigheder][4]

<!-- Referenced links -->

[2]: index.md
[3]: functional-rights.md
[4]: https://help.superoffice.com/docs/11/da/admin/user-management/role/set-data-rights-for-role.html

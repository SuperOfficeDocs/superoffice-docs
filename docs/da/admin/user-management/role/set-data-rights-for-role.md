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

[!include[Requirement](../includes/note-anon-req.md)]

Du kan angive rettigheder for dataobjekter baseret på, hvem der ejer objektet. Alle brugere, der tilhører denne [rolle][2] tildeles rettigheder baseret på de indstillinger, du foretager her.

## Trin

1. [!include[Open Roles](../includes/open-roles.md)]

1. Vælg fanen **Medarbejdere** eller fanen **Ekstern**.

    [Sådan redigerer du rollen for anonyme brugere.][1]

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
| Mit firma (E)<br />Kun ONSITE | Oprettet af en ekstern brugers firma | Ejer-felt anvendes | Ansvarlig-felt anvendes | "Vores kontakt" anvendes |
| Andre grupper (A) | Oprettet af en brugergruppe, du tilhører | Ejer-felt anvendes | Ansvarlig-felt anvendes | "Vores kontakt" er en medarbejder i en gruppe, du tilhører |
| Samme projekt (E)<br />Kun ONSITE | Oprettet i et projekt, som en ekstern bruger tilhører | Ejer-felt anvendes | Ansvarlig-felt anvendes | "Vores kontakt" anvendes |
| Andre medarbejdere | Oprettet af andre medarbejdere i virksomheden | Ejer-felt anvendes | Ansvarlig-felt anvendes | "Vores kontakt" er en medarbejder, du ikke deler gruppe med |
| Ekstern bruger | Oprettet af eksterne brugere (målgruppebrugere) | Ejer-felt anvendes | Ansvarlig-felt anvendes | "Vores kontakt" anvendes |
| Anonym | Oprettet af anonyme brugere | Ikke relevant | Ikke relevant | Ikke relevant |

**A** = medarbejdere, **E** = ekstern

På personkortet hentes feltet **Vores kontakt** altid fra firmakortet, som personen tilhører.

## Hvordan viser jeg dataobjekter for eksterne brugere?

Hvis dataobjekterne (firmaer, projekter, dokumenter osv.) skal gøres tilgængelige for eksterne brugere (målgruppebrugere), er det ikke nok blot at tildele de eksterne brugere læseadgang (eller højere). Dataobjekterne skal også publiceres i SuperOffice.

## Relateret indhold

* [Datarettigheter][3]

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[2]: index.md
[3]: functional-rights.md

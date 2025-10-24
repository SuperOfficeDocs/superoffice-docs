---
uid: help-no-role-set-data-rights
title: Angi datarettigheter for rolle
description: Angi datarettigheter for rolle
keywords: brukeradministrasjon, rolle, tilgang, rettigheter
author: digitaldiina
date: 03.27.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /no/admin/user-management/learn/role/set-data-rights-for-role
language: no
---

# Angi datarettigheter for rolle

[!include[Requirement](../includes/note-anon-req.md)]

Du kan angi rettigheter for dataobjekter  basert på hvem som eier objektet. Alle brukere som tilhører denne [rollen][2], tilordnes rettigheter basert på innstillingene du gjør her.

## Trinn

1. [!include[Open Roles](../includes/open-roles.md)]

1. Velg fanen **Medarbeidere** eller fanen **Eksterne** (onsite).

    [Slik redigerer du rollen for anonyme brukere.][1]

1. Merk ønsket rolle i listen **Roller**. Rettighetene for den valgte rollen vises i fanen **Datarettigheter**.

1. Klikk på <i class="ph ph-caret-down" aria-label="Chevron"></i> ved siden av rettigheten du vil endre, og velg deretter ønsket rettighet.

    | Navn | Rettigheter | Infoboks |
    |---|---|---|
    | Ingen | Ingen rettigheter | |
    | Les | Leserettigheter | L |
    | Opprett | Lese- og opprettingsrettigheter | CR |
    | Oppdater | Lese-, opprettings- og oppdateringsrettigheter | CRU |
    | Slett | Lese-, opprettings-, oppdaterings- og sletterettigheter | CRUD |

    **C** = Create, **R** = Read, **U** = Update, **D** = Delete

    Endringene lagres automatisk.

## Hva betyr de ulike kolonnene under Data eid av?

| **Data eid av** | **Dashbord og dokumenter** | **Salg og oppfølginger** | **Prosjekter** | **Firma og person** |
|---|---|---|---|---|
| Min egen | Opprettet av deg | Eierfeltet brukes | Ansvarlig-feltet brukes | Du er "Vår kontakt" |
| Primærgruppe (A) | Opprettet av din primærgruppe (avdeling) | Eierfeltet brukes | Ansvarlig-feltet brukes | "Vår kontakt" er en medarbeider i din primærgruppe |
| Mitt firma (E)<br />Kun ONSITE | Opprettet av en ekstern brukers firma | Eierfeltet brukes | Ansvarlig-feltet brukes | "Vår kontakt" gjelder |
| Andre grupper (A) | Opprettet av en brukergruppe du tilhører | Eierfeltet brukes | Ansvarlig-feltet brukes | "Vår kontakt" er en medarbeider i en gruppe du tilhører |
| Samme prosjekt (E)<br />Kun ONSITE | Opprettet i et prosjekt som en ekstern bruker tilhører | Eierfeltet brukes | Ansvarlig-feltet brukes | "Vår kontakt" gjelder |
| Andre medarbeidere | Opprettet av andre medarbeidere i bedriften | Eierfeltet brukes | Ansvarlig-feltet brukes | "Vår kontakt" er en medarbeider du ikke deler gruppe med |
| Ekstern bruker | Opprettet av eksterne brukere (Audience-brukere) | Eierfeltet brukes | Ansvarlig-feltet brukes | "Vår kontakt" gjelder |
| Anonyme | Opprettet av anonyme brukere | Ikke relevant | Ikke relevant | Ikke relevant |

**A** = medarbeidere, **E** = ekstern

I personkortet hentes feltet **Vår kontakt** alltid fra firmakortet som personen tilhører.

## Hvordan viser jeg dataobjekter for eksterne brukere?

Hvis dataobjekter (firmaer, prosjekter, dokumenter og så videre) skal gjøres tilgjengelige for eksterne brukere (Audience-brukere), holder det ikke bare å gi de eksterne brukerne lesetilgang eller høyere tilgang. Dataobjektene må i tillegg publiseres i SuperOffice.

## Relatert innhold

* [Datarettigheter][3]

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[2]: index.md
[3]: functional-rights.md

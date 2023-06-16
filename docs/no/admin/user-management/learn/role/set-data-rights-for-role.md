---
uid: help-no-role-set-data-rights
title: Angi datarettigheter for rolle
description: Angi datarettigheter for rolle
author: Bergfrid Dias
so.date: 03.15.2023
keywords: brukeradministrasjon, rolle, tilgang, rettigheter
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Angi datarettigheter for rolle

[!include[Requirement](../includes/note-anon-req.md)]

Du kan angi rettigheter for [dataobjekter][2] basert på hvem som eier objektet. Alle brukere som tilhører denne [rollen][2], tilordnes rettigheter basert på innstillingene du gjør her.

## Trinn

1. [!include[Open Roles](includes/open-roles.md)]

2. Velg fanen **Medarbeidere** eller fanen **Eksterne** (onsite).

    [Slik redigerer du rollen for anonyme brukere.][1]

3. Merk ønsket rolle i listen **Roller**. Rettighetene for den valgte rollen vises i fanen **Datarettigheter**.

4. Klikk på ![ikon][img3] pilen ved siden av rettigheten du vil endre, og velg deretter ønsket rettighet.

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

| Data eid av | Forklaring|
|---|---|
| Min egen | Opprettet av deg |
| Primærgruppe (A) | Opprettet av din primærgruppe (avdeling) |
| Mitt firma (E) | Opprettet av ekstern brukers firma |
| Andre grupper (A) | Opprettet av en brukergruppe du tilhører |
| Samme prosjekt (E) | Opprettet i et prosjekt som en ekstern bruker tilhører |
| Andre medarbeidere | Opprettet av andre medarbeidere i bedriften |
| Ekstern bruker | Opprettet av eksterne brukere (Audience-brukere) |
| Anonyme | Opprettet av anonyme brukere |

* A = Medarbeidere
* E = Eksterne

## Hvordan viser jeg dataobjekter for eksterne brukere?

Hvis dataobjekter (firmaer, prosjekter, dokumenter og så videre) skal gjøres tilgjengelige for eksterne brukere (Audience-brukere), holder det ikke bare å gi de eksterne brukerne lesetilgang eller høyere tilgang. Dataobjektene må i tillegg publiseres i SuperOffice.

## Rettigheter til rapporter

Alle SuperOffice CRM-brukere har tilgang til Rapporter-bildet, men hvilke individuelle rapporter du har tilgang til å lage, avhenger av hvilke rettigheter du har til oppfølginger, dokumenter, salg og sjekkliste. Dette betyr i praksis at du ikke kan generere rapporter med innhold du ikke har tilgang til å se.

<!-- Referenced links -->
[1]: edit-rights-for-anonymous-users.md
[2]: index.md

<!-- Referenced images -->
[img3]: ../../../../../media/icons/arrow-down.png

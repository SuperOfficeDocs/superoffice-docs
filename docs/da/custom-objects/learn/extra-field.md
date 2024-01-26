---
uid: help-da-extra-field
title: Ekstrafelt
description: Et ekstrafelt er et tilpasset felt som du legger til i en eksisterende SuperOffice-databasetabell i Service.
author: Bergfrid Dias
so.date: 01.26.2024
so.version: 10
keywords: ekstrafelt, tilpasset felt, Service
so.topic: concept
language: da
so.audience: user
so.audience.tooltip: SuperOffice CRM
---

# Ekstrafelt

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

En *ekstra felt* er et brugerdefineret felt, du tilføjer til en eksisterende SuperOffice-databasetabel. Du kan udvide følgende enheder:

* Kategori
* Firma
* Kontakt
* FAQ-kategori og -indgang
* Besked
* Anmodning
* Bruger
* Dine [brugerdefinerede tabeller][6]

> [!NOTE]
> Ekstra felter på virksomhed eller kontakt er ikke det samme som brugerdefinerede felter på disse enheder!

Ekstra felter administreres i **Indstillinger og vedligeholdelse**, på **Tabeller**-skærmen.

## <a id="field-types" />Felttyper

* Bool (ja/nej)
* Heltal
* Flydende tal
* Tekst (kort)
* Tekst (lang)
* Dato
* Dato og tid
* Tid
* Tidsrum
* Vedhæftning
* Dynamisk link

Desuden har hver enhed en relations type. For eksempel *kontaktrelationen*.

I modsætning til brugerdefinerede felter tilføjes ekstra felter som faktiske felter til databasetabellerne. Der er ingen foruddefinerede pladser, du skal tage hensyn til, og i princippet ingen begrænsninger.


Et *ekstra felt* er et tilpasset felt som du legger til i en eksisterende SuperOffice-databasetabell. Du kan utvide følgende enheter:

* Kategori
* Firma
* Person
* FAQ-kategori og -oppføring
* Melding
* Sak
* Bruker
* Dine [egendefinerte tabeller][6]

> [!NOTE]
> Ekstrafelt på firma eller kontakt er ikke det samme som brukerdefinerte felt på disse enhetene!

Ekstrafelt administreres i **Innstillinger og vedlikehold** > **Tabeller**.

### Relasjoner (fremmednøgler, FK)

Databasetabeller er koblet sammen med *fremmednøgler* (FK). Disse er felttypene som slutter på *relasjon*.

* Personrelasjon
* Firmarelasjon
* Brukerrelasjon
* Saksrelasjon
* Kategorirelasjon
* Prioritetsrelasjon
* FAQ-relasjon
* Salgsrelasjon
* Prosjektrelasjon
* Avtalerelasjon
* Relasjon til ekstra tabell

## Bruk

Ekstrafelt kan for eksempel brukes som søkekriterier og kolonner i salg i SuperOffice CRM.

## Relatert innhold

* [Vis ekstrafelt på detaljfanen][1]
* [Tilføj ekstra felter][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

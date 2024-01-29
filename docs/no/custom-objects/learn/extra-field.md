---
uid: help-no-extra-field
title: Ekstrafelt
description: Et ekstrafelt er et tilpasset felt som du legger til i en eksisterende SuperOffice-databasetabell i Service.
author: Bergfrid Dias
so.date: 01.25.2024
so.version: 10
keywords: ekstrafelt, tilpasset felt, Service
so.topic: concept
language: no
so.audience: user
so.audience.tooltip: SuperOffice CRM
---

# Ekstrafelt

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

Et *ekstra felt* er et tilpasset felt som du legger til i en eksisterende SuperOffice-databasetabell. Du kan utvide følgende enheter:

* Kategori
* Firma
* Person
* FAQ-kategori og -oppføring
* Melding
* Sak og saksbehandler
* Bruker
* Dine [egendefinerte tabeller][6]

> [!NOTE]
> Ekstrafelt på firma eller kontakt er ikke det samme som brukerdefinerte felt på disse enhetene!

Ekstrafelt administreres i **Innstillinger og vedlikehold** > **Tabeller**.

## <a id="field-types" />Felttyper

* Sannhetsverdi (ja/nei)
* Heltall
* Flyttall
* Tekststreng (kort)
* Tekststreng (lang)
* Dato
* Dato og klokkeslett
* Klokkeslett
* Tidsintervall
* Vedlegg
* Dynamisk kobling

I tillegg har hver enhet en relasjonstype. For eksempel *personrelasjonen*.

I motsetning til brukerdefinerte felt, legges ekstra felt til som faktiske felt i databasetabellene. Det er ingen forhåndsdefinerte spor du må ta hensyn til, og i prinsippet ingen begrensninger.

### Relasjoner (fremmednøkler, FK)

Databasetabeller er koblet sammen med *fremmednøkler* (FK). Disse er felttypene som slutter på *relasjon*.

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
* [Opprett ekstrafelt][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

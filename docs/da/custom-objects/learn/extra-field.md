---
uid: help-da-extra-field
title: Ekstrafelt
description: Et ekstrafelt er et tilpasset felt som du legger til i en eksisterende SuperOffice-databasetabell i Service.
author: Bergfrid Dias
date: 01.26.2024
version: 10
keywords: ekstrafelt, tilpasset felt, Service
topic: concept
language: da
audience: user
audience_tooltip: SuperOffice CRM
---

# Ekstrafelt

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

Et *ekstra felt* er et brugerdefineret felt, du tilføjer til en eksisterende SuperOffice-databasetabel. Du kan udvide følgende enheder:

* Kategori
* Firma
* Person
* FAQ-kategori og -post
* Meddelelse
* Sag og sagsbehandler
* Bruger
* Dine [brugerdefinerede tabeller][6]

> [!NOTE]
> Ekstra felter på firma eller person er ikke det samme som brugerdefinerede felter på disse enheder!

Ekstra felter administreres i **Indstillinger og vedligeholdelse**, på **Tabeller**-skærmen.

## <a id="field-types" />Felttyper

* Sandhedsværdi (ja/nej)
* Heltal
* Flydende tal
* Tekststreng (kort)
* Tekststreng (lang)
* Dato
* Dato og klokkeslæt
* Klokkeslæt
* Tidsinterval
* Vedhæft
* Dynamisk link

Desuden har hver enhed en relations type. For eksempel *kontaktrelationen*.

I modsætning til brugerdefinerede felter tilføjes ekstra felter som faktiske felter til databasetabellerne. Der er ingen foruddefinerede pladser, du skal tage hensyn til, og i princippet ingen begrænsninger.

### Relationer (fremmednøgler, FK)

Databasetabeller er forbundet med *fremmednøgler* (FK). Disse er felttyper, der slutter på *relation*.

* Personrelation
* Firmarelation
* Brugerrelation
* Sagsrelation
* Kategorirelation
* Prioritetsrelation
* FAQ-relation
* Salgsrelation
* Projektrelation
* Aftalerelation
* Relation til Ekstratabel

## Brug

Ekstra felter kan for eksempel bruges som søgekriterier og kolonner i salg i SuperOffice CRM.

## Relateret indhold

* [Vis ekstrafelt på detaljfanen][1]
* [Tilføj ekstra felter][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

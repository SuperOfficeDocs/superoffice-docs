---
uid: help-da-extra-field
title: Ekstrafelt
description: Et ekstrafelt er et tilpasset felt som du legger til i en eksisterende SuperOffice-databasetabell i Service.
keywords: ekstrafelt, tilpasset felt, Service
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: da
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

Ekstra felter administreres i Indstillinger og vedligeholdelse, på **Tabeller**-skærmen.

## <a id="field-types"></a>Felttyper

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

### <a id="relation"></a>Relationer (fremmednøgler, FK)

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

#### Tilgængelig i pilot fra version 10.3.4

Når et relationsfelt er sat til at vise én-til-mange relationer, tilføjer systemet automatisk et detaljekort i relaterede standardenheder. Dette er ikke det samme som fanen **Relationer** på Firma- og Person-skærmene.

![Detaljekort med ekstrafeltrelation -screenshot][img1]

#### Tilgængelig i pilot fra version 10.3.7

For at se detaljerne for elementerne på denne liste uden at åbne hver enkelt enhed:

1. Gå til sidepanelet, og vælg **Forhåndsvisning**.
2. Klik på et element i det relationsbaserede detaljekort. Sidepanelet viser en forhåndsvisning af den valgte enhed. I forhåndsvisningen kan du:

    * Klikke på en standardenhed for at gå til den.
    * Klikke på et brugerdefineret objekt for at åbne en dialog til visning eller redigering af yderligere oplysninger.

![Forhåndsvisning af ekstrafeltrelation -screenshot][img2]

## Brug

Ekstra felter kan for eksempel bruges som søgekriterier og kolonner i salg i SuperOffice CRM.

## Relateret indhold

* [Vis ekstrafelt på detaljfanen][1]
* [Tilføj ekstra felter][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/section-tab-for-relation.png
[img2]: ../../../media/loc/en/automation/preview-custom-object-from-side-panel.png

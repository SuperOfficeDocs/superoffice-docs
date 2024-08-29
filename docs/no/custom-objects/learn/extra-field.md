---
uid: help-no-extra-field
title: Ekstrafelt
description: Et ekstrafelt er et tilpasset felt som du legger til i en eksisterende SuperOffice-databasetabell i Service.
keywords: ekstrafelt, tilpasset felt
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
topic: concept
language: no
audience: user
audience_tooltip: SuperOffice CRM
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

## <a id="field-types"></a>Felttyper

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

### <a id="relation"></a>Relasjoner (fremmednøkler, FK)

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
* Relasjon til ekstratabell

#### Tilgjengelig i pilot fra versjon 10.3.4

Når et relasjonsfelt er satt til å vise én-til-mange-relasjoner, legger systemet automatisk til et detaljkort i relaterte standardenheter. Dette er ikke det samme som fanen **Relasjoner** på Firma- og Person-skjermene.

![Detaljkort med ekstrafeltrelasjon -screenshot][img1]

#### Tilgjengelig i pilot fra versjon 10.3.7

For å se detaljene for elementene i denne listen uten å åpne hver enkelt enhet:

1. Gå til sidepanelet og velg **Forhåndsvisning**.
2. Klikk på et element i det relasjonsbaserte detaljkortet. Sidepanelet viser en forhåndsvisning av den valgte enheten. I forhåndsvisningen kan du:

    * Klikke på en standardenhet for å gå til den.
    * Klikke på et tilpasset objekt for å åpne en dialog for visning eller redigering av tilleggsinformasjon.

![Forhåndsvisning ekstrafeltrelasjon -screenshot][img2]

## Bruk

Ekstrafelt kan for eksempel brukes som søkekriterier og kolonner i salg i SuperOffice CRM.

## Relatert innhold

* [Vis ekstrafelt på detaljfanen][1]
* [Opprett ekstrafelt][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/section-tab-for-relation.png
[img2]: ../../../media/loc/en/automation/preview-custom-object-from-side-panel.png

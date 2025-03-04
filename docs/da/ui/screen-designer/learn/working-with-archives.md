---
uid: help-da-screen-designer-archive
title: Arbejde med detaljekort (arkiver)
description: Skærmdesigner - arbejde med detaljekort (arkiver)
keywords: Skærmdesigner, layout, detaljekort, arkiv, arkivlayout, fane
author: Bergfrid Dias
date: 10.07.2024
version: 10.2.11
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Arbejde med detaljekort (arkiver)

Du kan tilpasse layoutet ved at tilføje eller fjerne detaljekort (også kaldet arkiver) på hovedkortene for Firma, Person, Salg, Projekt og Sags-skærme.

Tilpasning af detaljekort gøres typisk for at imødekomme de specifikke behov hos forskellige brugergrupper. Du kan oprette et layout, der er skræddersyet til en bestemt brugergruppe, og sikre, at detaljekortene viser relevant indhold for den gruppe.

![Tilføj navnet til den nye detaljekort/arkivlayout, og vælg de brugergrupper, det skal vises for -screenshot][img6]

## Forståelse af detaljekort

Detaljekort, der er placeret i bunden af de fleste SuperOffice CRM-skærme, viser relaterede data som personer, aktiviteter, projekter og salg. Selvom nogle detaljekort, såsom salgsguide og tilbud, ikke er arkiver, vil vi for nemheds skyld henvise til alle som arkiver eller arkivfaner.

Når du opretter et nyt layout til en brugergruppe, bør du overveje, hvilke data de har mest brug for. Ved at tilpasse arkiver kan du filtrere og prioritere informationer, hvilket gør det lettere for brugerne at finde det, de har brug for.

## Tilføj arkivfane

Du kan tilføje et nyt detaljekort på enhver skærm, der har et detaljekortområde. Afhængigt af den valgte skærm kan du tilføje en ny fane med indhold af: dokument, aftale, produkt, projekt, projektdeltager, salg, interessent, sag, person og relation.

![Vælg den type indhold, du vil vise i detaljekortet -screenshot][img5]

**Trin:**

1. Åbn Skærmdesigneren.

1. Vælg øverst en skærm, du vil tilpasse, og klik på **Arkiver**.

1. Vælg et layout fra listen, og klik på **Rediger layout** under forhåndsvisningen.

1. Klik på **Tilføj** for at åbne sektionen **Fane**.

1. Erstat "Ny fane" med arkivnavnet, og indtast en beskrivelse af det nye arkiv.

    Du kan også klikke på <i class="ph ph-translate" aria-label="Translate"></i> for at tilføje teksten på andre sprog.

1. Juster **Unikt navn til kortet** (soprotocol) efter behov.

1. Vælg i sektionen **Indstillinger** den datatype (indhold), der skal vises i arkivet.

    Data er begrænset til den aktuelle skærm. Hvis du f.eks. tilføjer et arkiv til Firmaskærmen, vil kun data, der er knyttet til den **aktuelle** virksomhed, blive vist.

1. Tilføj eller rediger kriterier under **Filter** for at forfine de viste data. Disse kriterier fungerer på samme måde som [søgefiltrene på **Find**-skærmen][2] og i udvælgelsen.

    Klik på **Opdater forhåndsvisning** for at se de filtrerede data.

1. (Valgfrit) Brug **Avancerede indstillinger** for at tilpasse enkeltklik- og dobbeltklik-handlinger. Som standard vil et enkeltklik vælge en række, og et dobbeltklik åbner en post/enhed i SuperOffice.

    > [!TIP]
    > Hold musemarkøren over <i class="ph ph-info" aria-label="Info"></i> for at se eksempler.

1. Træk arkivet til den ønskede position i forhåndsvisningen.

1. Vælg **Gem udkast** eller **Gem + Udgiv** for at gemme dine ændringer. Klik på **Afbryd** for at annullere dine ændringer.

## Rediger eksisterende detaljekort

For at ændre et eksisterende arkiv skal du vælge det og opdatere felterne og indstillingerne i sektionerne **Fane** og **Indstillinger**. Du kan også ændre fanens position ved at trække den til en ny placering.

### Begrænsninger

* Standardfaner kan ikke redigeres.

* Nogle faner, såsom **Tilbud**, **Salgsguide** og **Projektguide**, kan ikke redigeres, da de har specifikke funktioner.

## Fjern detaljekort

1. Vælg arkivet eller detaljekortet.

1. Klik på **Opgave** > **Fjern fane**.

1. Bekræft ved at klikke på **OK**. Fanen vil blive skjult, men ikke slettet.

![Klik på Opgave og derefter Fjern fane for at fjerne uønskede faner i detaljekortet (arkiv) -screenshot][img1]

For at fortryde disse ændringer skal du klikke på **Gendan faner**.

## Relateret indhold

* [Hvordan omorganiserer jeg felterne i Mere-fanen efter opgradering til SuperOffice version 10?][3] - FAQ
* [Opret nyt layout][4]

<!-- Referenced links -->
[2]: ../../../search-options/learn/search-criteria.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-reorganize-the-fields-in-the-more-tab-in-company-and-contact-screenscards-after-the-upgrade-to-superoffice-version-10/
[4]: add-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/admin-screendesigner-edit-archive.png
[img5]: ../../../../media/loc/en/ui/admin-screendesigner-edit-archive-add-tab.png
[img6]: ../../../../media/loc/en/ui/admin-screendesigner-add-archive-layout.png

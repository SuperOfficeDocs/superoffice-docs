---
uid: help-nl-selection-combine
title: Gecombineerde selectie maken
description: In deze instructie leert u hoe u een gecombineerde selectie kunt maken.
keywords: selecties combineren, gecombineerde selectie, selectie
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from: /nl/search-options/selection/learn/create/combine
---

# Gecombineerde selectie maken

De twee selecties die moeten worden gecombineerd, kunnen statisch of dynamisch zijn. Er zijn echter bepaalde beperkingen met betrekking tot wat kan worden gecombineerd:

* Als u ervoor kiest een gecombineerde selectie te maken die bestaat uit bedrijven, zijn alle selectietypen beschikbaar.
* Als u er echter voor kiest een gecombineerde selectie te maken die bestaat uit verkopen, projecten, documenten, producten en vervolgactiviteiten, zijn alleen selecties van het geselecteerde type beschikbaar.

## De gegevens zoeken

1. Open een van de selecties die u wilt combineren.

1. Klik op de knop **Taak** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) en selecteer **Selectie combineren met**. Er wordt een nieuw selectiescherm geopend.

1. Typ de naam van de nieuwe selectie in het veld waar de tekst *Selectienaam* wordt weergegeven. dit is een verplicht veld.

1. In het veld **Selectie van** geeft u aan wat de selectie moet bevatten. De keuzes hier zijn beperkt tot **Bedrijf/persoon** en het type selectie dat u hebt geselecteerd. U kunt deze niet wijzigen nadat deze in de database is opgeslagen.

1. In het veld **Selectie is** staat **Gecombineerd** standaard geselecteerd.

1. Bij **Selectie 2** kiest u de andere selectie waarmee u wilt combineren.

    > [!NOTE]
    > Als u **Bedrijven/personen** hebt geselecteerd onder **Selectie van**, kunt u hier kiezen uit alle typen selectie (een verkoopselectie bevat ook bedrijven/personen met betrekking tot de verkoop). Als de gecombineerde selectie echter Verkopen, Projecten, Documenten, Vervolgactiviteiten, Formulierverzendingen, Chatgesprekken, Mailings of Producten omvat, moet u dezelfde typen selectie kiezen voor **Selectie 1** en **Selectie 2**.

1. Selecteer bij **Vergelijken** de items uit de twee selecties die in de gecombineerde selectie moeten worden opgenomen.

| Pictogram | Optie | Beschrijving |
|:-:|---|---|
| <i class="ph ph-subtract" aria-label="Only in one selection icon"></i> | Alleen in selectie 1/ Alleen in selectie 2 | Toont items in selectie 1 of selectie 2 en sluit items uit die zowel in selectie 1 als in selectie 2 staan. |
| <i class="ph ph-intersect" aria-label="Common entries icon"></i> | Gemeenschappelijk | Toont alleen items die zowel in selectie 1 als in selectie 2 staan. |
| <i class="ph ph-exclude" aria-label="Difference icon"></i> | Verschil | Toont alleen items die óf in selectie 1 óf in selectie 2 staan. |
| <i class="ph ph-unite" aria-label="All entries icon"></i> | Alles | Toont alleen items in selectie 1 en selectie 2. |

## Details kiezen

Stel eigenschappen in volgens de instructies van stap 2 in de zelfstudie [Selectie maken][1].

## Voltooien

1. Klik eventueel op het sterpictogram (<i class="ph ph-star" aria-hidden="true"></i>) om de selectie aan [je favorieten][2] toe te voegen.

1. Klik op **Opslaan**.

Na het opslaan van de selectie, kunt u [deze bewerken][3] door het combinatietype en de selecties te wijzigen die zijn gecombineerd. Het is echter niet mogelijk de waarde in het veld **Selectie van** te wijzigen.

## Voorbeelden van gecombineerde selecties

### Bedrijven en verkopen

1. Maak een gecombineerde selectie van bedrijven/contactpersonen op basis van twee bestaande selecties: "Klanten in Zweden" (selectie 1) en "Verkopen vorig jaar" (selectie 2).
2. Selecteer het combinatietype **Alleen in selectie 1**. Het resultaat zal klanten in Zweden bevatten waaraan u vorig jaar niets hebt verkocht.
3. Sla het resultaat op als een statische selectie met de naam "Klanten in Zweden zonder verkopen" en maak een van uw medewerkers verantwoordelijk voor vervolgactiviteiten met betrekking tot deze klanten.

### Vervolgactiviteiten

1. Maak een gecombineerde selectie van vervolgactiviteiten op basis van twee bestaande selecties: "Vervolgactiviteiten gekoppeld aan mijn klanten" (selectie 1) en "Geplande vervolgactiviteiten volgende maand" (selectie 2).
2. Selecteer het combinatietype **Algemeen**. Het resultaat is een lijst met vervolgactiviteiten die u volgende maand moet uitvoeren. U kunt deze vervolgens exporteren naar een bestand met de taak **Exporteren naar bestand**.

> [!NOTE]
> als u de bedrijven die aan deze twee selecties zijn gekoppeld slechts wilt vergelijken, schakelt u het selectievakje **Alleen bedrijven vergelijken** in.

<!-- Referenced links -->
[1]: create.md
[3]: update/index.md
[2]: ../../../learn/basics/fav.md

---
uid: help-nl-dashboard-tile-sales-targets
title: Verkooptargets gebruiken in tegels
description: Gebruik dashboards en tegels om uw verkooptargets te vergelijken met uw werkelijke verkopen.
author: SuperOffice RnD
so.date: 12.13.2022
keywords: dashboard, verkoop, target, Grafiek
so.topic: howto
language: nl
---

# Targets gebruiken in tegels

Als u [verkooptargets][4] hebt gedefinieerd voor uw bedrijf, teams/groepen en/of verkopers  kunt u deze targets toevoegen aan uw dashboardtegels. U krijgt dan een visuele presentatie van uw werkelijke verkopen en uw targets.

Om uw targets in een dashboard te kunnen visualiseren, moet u eerst de tegels in het dashboard toevoegen of bewerken. Nadat u de juiste tegel hebt gekozen, kunt u de opmaak en het grafiektype van de tegels bewerken.

![Kies het tabblad Opmaak en selecteer Vergelijken met target in de sectie Groepering -screenshot][img7]

## Een tegel met verkooptargets aan dashboard toevoegen

1. Open het scherm **Dashboard**.

2. Selecteer het dashboard dat u wilt bewerken.

3. Klik op de knop **Taak** en selecteer **Tegel toevoegen/Opmaak bewerken**. Aan de rechterkant van het geselecteerde dashboard wordt de sectie **Tegel toevoegen/Opmaak bewerken** weergegeven.

4. Selecteer in de lijst **Tegels weergeven voor** de optie **Verkoop**.

5. Selecteer op het tabblad **Bibliotheek** een van de volgende grafieken:

    * ![pictogram][img2] \- Groot weergegeven getal
    * ![pictogram][img3] \- Staafdiagram
    * ![pictogram][img4] \- Kolomdiagram
    * ![pictogram][img5] \- Meterdiagram
    * Lege verkooptegel

    > [!TIP]
    > U kunt ook [een lege tegel selecteren][1] om een geheel nieuwe tegel te maken, maar het grafiektype moet een van de bovenstaande zijn.

6. Als u een tegel aan het dashboard wilt toevoegen, sleept u deze op de gewenste positie op het dashboard en zet u deze neer. U kunt ook op **Toevoegen** klikken om een tegel toe te voegen aan de volgende beschikbare positie. De tegel wordt automatisch aangepast aan de beschikbare ruimte en wordt uitgelijnd op basis van de instelling van het raster en de kolommen.

7. De tegels aan het dashboard aanpassen:

    * Houd de muisaanwijzer boven een tegel en klik en sleep het kader om de tegelgrootte aan te passen. Beschikbare uitsparingen/ruimtes binnen het dashboard worden geel gemarkeerd als de tegel in die positie past.

    * Klik op de koptekst van een tegel en sleep deze naar een andere positie.

8. Klik in het dashboard op het pictogram **Tegel bewerken** ![pictogram][img6] op de nieuwe tegel.

9. Stel op het tabblad **Gegevensset** de **Verkoopdatum** in op dit jaar, kwartaal of deze maand. Bewerk de andere [criteria][2] indien nodig. Vergeet niet om de naam van de tegel bij te werken om de wijzigingen weer te geven die hier zijn aangebracht.

10. Bewerk de opmaak in het tabblad **Opmaak**:

    * **Grafiektype**: U kunt dit wijzigen in elk grafiektype dat in stap 5 wordt vermeld.
    * **Functie**: selecteer **Som** of **Aantal**. Bijvoorbeeld de som van alle verkopen of het totaal (aantal) van alle verkopen.
    * **Van**: Als u hierboven **Aantal**  geselecteerd selecteert u **Verkoop-ID** in deze lijst. Als u **Som** hebt geselecteerd selecteert u **Bedrag** of **Gewogen bedrag**.
    * **Door**: selecteer **Verkoop &gt; Eigenaar** (eigenaar, volledige naam of groep) of **Verkoop &gt; Verkoopdatum**. Deze optie is alleen relevant voor staafdiagrammen en kolomdiagrammen.
    * **Groepering** of **Voettekst**: selecteer **Vergelijken met target**.
      * Als deze optie niet zichtbaar of inactief is, controleert u nogmaals of u de bovenstaande stappen hebt uitgevoerd. Als u de optie **Vergelijken met target** niet kunt selecteren (deze is uitgeschakeld), kunt u de muisaanwijzer boven de tekst houden. Hierdoor wordt knopinfo weergegeven waarin wordt uitgelegd wat u moet wijzigen om de optie in te schakelen en te selecteren.
    * **Doel**: selecteer het target dat u aan de tegel wilt toevoegen. (Niet relevant voor staafdiagrammen.)
    * **Weergeven als %**: selecteer deze optie om het percentage van het target weer te geven in plaats van de som of het aantal. (Niet relevant voor kolomdiagrammen en grote getallen.)

11. De opmaak bewerken. Op basis van het grafiektype dat u hebt geselecteerd, hebt u extra opties onder **Opmaak**:

    * Groot weergegeven getal: U kunt de kleuren bewerken die worden gebruikt om targets weer te geven.
    * Meterdiagram: gebruik de optie **Doel markeren bij** om het target in het meterdiagram in te stellen.

12. Klik op ![pictogram][img1] om een [vertaling toe te voegen][3] aan de naam, titels en labels van de tegel.

13. Klik op **Opslaan**. Klik dan op **Voltooid**.

## Waarom kan ik Vergelijken met target niet selecteren?

Als u het veld Vergelijken met target ziet, maar dit is uitgeschakeld, kunt u met uw muis over het veld bewegen om knopinfo te zien waarin wordt uitgelegd wat u moet wijzigen om het veld in te schakelen en te selecteren.

![Plaats de muisaanwijzer op het veld Vergelijken met target om knopinfo weer te geven -screenshot][img8]

Is Vergelijken met target helemaal niet zichtbaar, controleer dan of u het juiste grafiektype hebt geselecteerd en dat u de verkoopdatum als criteria hebt gebruikt op het tabblad Gegevensset.

## Aanverwant

* [Een nieuwe dashboard toevoegen][5]
* [Tegels bewerken of maken][2]
* [Verkooptargets instellen][7]
* [Dashboardgegevens][6]

<!-- Referenced links -->
[1]: edit-tile.md
[2]: ../../search-options/learn/using-search-criteria.md
[3]: ../../globalization-and-localization/learn/translate-fields.md
[4]: ../../sale/learn/sales-targets/index.md
[5]: create.md
[6]: working-with-tiles.md
[7]: ../../sale/learn/sales-targets/create.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/az.png
[img2]: ../../../../common/icons/big-numbers.png
[img3]: ../../../../common/icons/column-bar.png
[img4]: ../../../../common/icons/bar.png
[img5]: ../../../../common/icons/gauge.png
[img6]: ../../../../common/icons/edit-pen.png
[img7]: media/user-dashboard-tile-comparetotarget.png
[img8]: media/user-dashboard-tile-disabled-comparetotarget.png

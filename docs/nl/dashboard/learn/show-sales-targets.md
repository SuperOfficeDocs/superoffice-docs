---
uid: help-nl-dashboard-tile-sales-targets
title: Verkooptargets gebruiken in tegels
description: Gebruik dashboards en tegels om uw verkooptargets te vergelijken met uw werkelijke verkopen.
keywords: dashboard, verkooptarget, grafiek
author: SuperOffice Product and Engineering
date: 11.21.2025
version: 11.6
content_type: howto
license: salespremium
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Targets gebruiken in tegels

Zodra [verkooptargets][4] zijn ingesteld voor uw bedrijf, teams of individuele gebruikers, kunt u deze targets toevoegen aan dashboardtegels. Hiermee kunt u werkelijke verkopen vergelijken met targets direct in visuele grafieken zoals meters, staafdiagrammen en grote getallen.

Om te leren hoe dashboards en selecties u kunnen helpen bij het monitoren en voorspellen van verkopen, zie [Uw verkopen voorspellen][8].

![Kies het tabblad Opmaak en selecteer Vergelijken met target in de sectie Groepering -screenshot][img1]

## Een tegel met verkooptargets aan dashboard toevoegen

1. Open het scherm **Dashboard**.

2. Selecteer het dashboard dat u wilt bewerken.

3. Klik op <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> en selecteer **Dashboardtegels beverken**. Aan de rechterkant van het geselecteerde dashboard wordt de sectie **Dashboardtegels beverken** weergegeven.

4. Selecteer in de lijst **Tegels weergeven voor** de optie **Verkoop**.

5. Selecteer op het tabblad **Bibliotheek** een van de volgende grafieken:

    * <i class="ph ph-number-square-three" aria-hidden="true"></i> - Groot weergegeven getal
    * <i class="ph ph-chart-bar-horizontal" aria-hidden="true"></i> - Staafdiagram
    * <i class="ph ph-chart-bar" aria-hidden="true"></i> - Kolomdiagram
    * <i class="ph ph-gauge" aria-hidden="true"></i> - Meterdiagram
    * Lege verkooptegel

    > [!TIP]
    > U kunt ook een lege tegel selecteren om [een geheel nieuwe tegel te maken][6], maar het grafiektype moet een van de bovenstaande zijn.

6. Als u een tegel aan het dashboard wilt toevoegen, sleept u deze op de gewenste positie op het dashboard en zet u deze neer. U kunt ook op **Toevoegen** klikken om een tegel toe te voegen aan de volgende beschikbare positie. De tegel wordt automatisch aangepast aan de beschikbare ruimte en wordt uitgelijnd op basis van de instelling van het raster en de kolommen.

7. De tegels aan het dashboard aanpassen:

    * Houd de muisaanwijzer boven een tegel en klik en sleep het kader om de tegelgrootte aan te passen. Beschikbare uitsparingen/ruimtes binnen het dashboard worden geel gemarkeerd als de tegel in die positie past.

    * Klik op de koptekst van een tegel en sleep deze naar een andere positie.

8. Klik in het dashboard op  **Tegel bewerken** (<i class="ph ph-pencil" aria-hidden="true"></i>) op de nieuwe tegel.

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

12. Klik op <i class="ph ph-translate" aria-label="Translate"></i> om een [vertaling toe te voegen][3] aan de naam, titels en labels van de tegel.

13. Klik op **Opslaan**. Klik dan op **Voltooid**.

## Waarom kan ik Vergelijken met target niet selecteren?

Als u het veld Vergelijken met target ziet, maar dit is uitgeschakeld, kunt u met uw muis over het veld bewegen om knopinfo te zien waarin wordt uitgelegd wat u moet wijzigen om het veld in te schakelen en te selecteren.

Is Vergelijken met target helemaal niet zichtbaar, controleer dan of u het juiste grafiektype hebt geselecteerd en dat u de verkoopdatum als criteria hebt gebruikt op het tabblad Gegevensset.

## Gerelateerde inhoud

* [Een nieuwe dashboard toevoegen][5]
* [Tegels bewerken of maken][6]
* [Tegels met leads en UTM-gegevens][9]
* [Verkooptargets instellen][7]
* [Uw verkopen voorspellen][8]

<!-- Referenced links -->
[2]: ../../search-options/learn/search-criteria.md
[3]: ../../localization/learn/translate-fields.md
[4]: ../../sale/learn/sales-targets/index.md
[5]: create.md
[6]: working-with-tiles.md
[7]: ../../sale/learn/sales-targets/create.md
[8]: ../../sale/learn/forecasting.md
[9]: show-leads.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/team-forecast-vs-target.png

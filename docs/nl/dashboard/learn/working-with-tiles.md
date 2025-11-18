---
uid: help-nl-dashboard-tiles
title: Werken met tegels
description: Leer hoe u tegels kunt toevoegen, aanpassen en beheren in uw SuperOffice-dashboards.
keywords: tegel toevoegen, tegel bewerken, tegel kopiëren, tegel dupliceren, tegel verwijderen, tegel aanpassen, dataset, dashboard, tegel
author: digitaldiina
date: 11.21.2025
version: 11.6
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/dashboard/learn/add-tile
  - /nl/dashboard/learn/edit-tile
  - /nl/dashboard/learn/remove-tile
---

# Werken met tegels

Leer hoe u tegels kunt toevoegen, aanpassen en beheren in uw SuperOffice-dashboards. Tegels zijn visuele samenvattingen op basis van CRM-gegevens – ideaal voor het volgen van verzoeken, verkoop, activiteiten of marketingresultaten.

U kunt vooraf gedefinieerde tegels gebruiken of uw eigen tegels maken.

## Vereiste: overschakelen naar de opmaakmodus

Om tegels te beheren, moet u eerst de opmaakmodus activeren:

1. Open het dashboard dat u wilt aanpassen.

1. Klik in de koptekst van het dashboard op <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> en selecteer **Dashboardtegels beverken**.

    Het dashboard gaat naar de opmaakmodus:
    * De zijbalk **Dashboardtegels beverken** wordt rechts weergegeven.
    * Elke tegel toont een bewerkpictogram (<i class="ph ph-pencil" aria-hidden="true"></i>).
    * U kunt tegels toevoegen, verplaatsen, herschalen of bewerken.

## <a id="add"></a>Tegel toevoegen

1. Kies in de zijbalk **Dashboardtegels beverken** het gegevenstype (zoals bedrijf, verkoop of verzoek) uit de lijst **Tegels weergeven voor**.

    ![Dashboardtegels beverken -zijbalk -screenshot][img1]

1. Kies een tegel uit de tabbladen **Bibliotheek** (vooraf gedefinieerde tegels) of **Selecties** (tegels op basis van uw eigen dynamische selecties).

    * Gebruik het **zoekveld** om snel tegels te vinden.
    * Elke tegel heeft een pictogram dat het type aangeeft, zoals grafiek, lijst of groot getal.

1. Voeg de tegel toe aan het dashboard:
    * **Sleep** de tegel naar een beschikbare plek.
    * Of klik op het pictogram <i class="ph ph-plus" aria-label="+"></i> dat verschijnt wanneer u met de muis over de tegelnaam beweegt.

    De tegel wordt automatisch aangepast aan de beschikbare ruimte en uitgelijnd volgens de dashboardindeling.

1. Pas indien nodig de grootte of positie van de tegel aan.

1. Klik op **Gereed** om de opmaakmodus te verlaten.

### Een tegel helemaal zelf maken

1. Selecteer de optie **Lege tegel** voor het gegevenstype dat u wilt visualiseren.
1. Voeg deze toe aan het dashboard.
1. Geef in het dialoogvenster **Tegel bewerken** een beschrijvende naam op.
1. Ga naar het tabblad **Dataset** en [stel de criteria in][4] voor welke gegevens de tegel moet weergeven.

    ![Dialoogvenster Tegel bewerken, tabblad Dataset -screenshot][img2]

    Dit tabblad werkt net als [het scherm Zoeken][5]. Gebruik het om filters te definiëren zoals eigenaar, datumbereik of categorie.

1. Ga naar het tabblad **Opmaak** om het uiterlijk van de tegel te configureren. Kies het [grafiektype][3], labels, sortering en andere opmaakopties.

    ![Dialoogvenster Tegel bewerken, tabblad Opmaak -screenshot][img3]

1. Klik op **Opslaan** en vervolgens op **Gereed** om de opmaakmodus te verlaten.

### <a id="selection-chart"></a>Over selectie-gebaseerde tegels

Wanneer u een tegel toevoegt vanuit het tabblad **Selecties**, koppelt u de tegel niet aan een live selectie. In plaats daarvan wordt de huidige dataset en opmaak gekopieerd uit het [diagram dat in de selectie is gedefinieerd][6]. Vanaf dat moment zijn de tegel en selectie onafhankelijk van elkaar.

Het tabblad **Selecties** toont alleen:

* Dynamische selecties
* Selecties die overeenkomen met het geselecteerde type in **Tegels weergeven voor**
* Selecties met een opgeslagen diagram op het tabblad **Diagram**

Als een selectie ontbreekt in de lijst, controleer dan:

* Is het een statische selectie? Statische selecties worden hier niet ondersteund.
* Komt het gegevenstype (bedrijf, verkoop, enz.) overeen met het gekozen type?
* Is er een diagram gedefinieerd en opgeslagen op het tabblad **Diagram**?

Na het toevoegen van de tegel:

* Wijzigingen in de **criteria** of het **diagram** van de selectie hebben **geen** invloed op de tegel.
* Wijzigingen in de **dataset** of **opmaak** van de tegel hebben **geen** invloed op de selectie.
* De **tegel blijft niet gesynchroniseerd** met de selectie, maar wordt nog steeds dynamisch bijgewerkt op basis van zijn eigen dataset.

Als u wilt dat de tegel updates van een selectie weerspiegelt, pas dan de tegel handmatig aan of verwijder en voeg deze opnieuw toe vanuit de bijgewerkte selectie.

### Een tegel met een webpaneel toevoegen

Gebruik deze tegel om een webpagina in het dashboard op te nemen:

1. Stel **Tegels weergeven voor** in op **Overig**.
1. Selecteer in het tabblad **Bibliotheek** de optie **Webpaneel**.
1. Voer de URL in die u wilt weergeven.
1. Als de URL HTTP gebruikt (niet HTTPS), schakel dan **Onveilig adres toestaan** in.
1. Klik op **Opslaan** en vervolgens op **Gereed** om de opmaakmodus te verlaten.

### Een HTML-tegel toevoegen

Gebruik deze tegel om opgemaakte tekst in uw dashboard weer te geven, zoals een welkomstbericht, legenda of interne uitleg.

1. Stel **Tegels weergeven voor** in op **Overig**.
1. Selecteer in het tabblad **Bibliotheek** de optie **HTML**.
1. Klik op **Toevoegen** om ten minste één taal voor de inhoud te selecteren.
1. Gebruik de ingebouwde editor om uw inhoud in te voeren en op te maken.

    U kunt dezelfde opmaakopties gebruiken die beschikbaar zijn in Chat en Formulieren. Voeg inhoud toe in meerdere talen zodat de tegel correct wordt weergegeven voor alle gebruikers.

1. Klik op **Opslaan** en vervolgens op **Gereed** om de opmaakmodus te verlaten.

## <a id="edit"></a>Een tegel bewerken

1. Terwijl u zich in de opmaakmodus bevindt, klikt u op het pictogram **Bewerken** (<i class="ph ph-pencil" aria-hidden="true"></i>) op de tegel.
1. Pas op het tabblad **Dataset** de filters aan zoals gewenst.
1. Selecteer op het tabblad **Opmaak** het gewenste grafiektype en de visuele instellingen.
1. Werk de naam van de tegel bij zodat deze overeenkomt met de nieuwe gegevens of opmaak.
1. Klik op <i class="ph ph-translate" aria-label="Translate"></i> om een [vertaling toe te voegen][7] aan de tegelnaam en labels.
1. Klik op **Opslaan**.

## <a id="copy"></a>Een tegel dupliceren of kopiëren

U kunt een bestaande tegel opnieuw gebruiken door deze te dupliceren in hetzelfde dashboard of te kopiëren naar een ander dashboard. U moet **bewerkingstoegang tot het doeldashboard** hebben om een tegel daarheen te kopiëren.

1. Klik op <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> op de tegel en selecteer de optie dupliceren of kopiëren.

| Optie | Wat het doet | Wat u vervolgens doet | Gebruikssituatie |
|---|---|---|---|
| **Tegel dupliceren** | Maakt een kopie van de tegel in het huidige dashboard. De naam wordt bijgewerkt (bijvoorbeeld *Tegelnaam 2*). | Meestal bewerkt u de gedupliceerde tegel: wijzig de naam, pas het dataset of de opmaak aan. | Toon hetzelfde type gegevens in een andere opmaak, of toon vergelijkbare gegevens met dezelfde opmaak. |
| **Tegel kopiëren naar dashboard** | Voegt de tegel toe aan een ander dashboard. Kies een doeldashboard uit de lijst. Beweeg de muisaanwijzer over een dashboardnaam om een voorbeeld van de huidige tegels te bekijken voordat u kopieert. | Open eventueel het doeldashboard. Bewerk de tegel daar indien nodig. | Hergebruik een nuttige tegel die u hebt gevonden in het dashboard van een collega. Voeg deze toe aan een van uw eigen dashboards. |

**Tegel kopiëren naar dashboard** is ook beschikbaar buiten de opmaakmodus (normale dashboardweergave).

## <a id="move"></a>Tegels herschikken of formaat wijzigen

In de opmaakmodus:

* **Sleep een tegel via de koptekst** om deze naar een nieuwe positie te verplaatsen.
* **Wijzig het formaat van een tegel** door aan de onder- of rechterrand of de rechterbenedenhoek te slepen.

Tegels worden automatisch uitgelijnd op het raster van het dashboard.

Als u het aantal kolommen wilt wijzigen, verlaat u de opmaakmodus en werkt u de dashboardinstellingen bij.

## <a id="remove"></a>Een tegel verwijderen

U kunt tegels uit een dashboard verwijderen, zolang u bewerkingstoegang hebt.

1. Klik in de opmaakmodus op <i class="ph ph-dots-three-vertical" aria-label="Tile task menu"></i> op de tegel.
1. Selecteer **Tegel verwijderen**.
1. Bevestig de verwijdering.

> [!CAUTION]
> Aangepaste tegels, zoals HTML-, webpaneel- en selectie-gebaseerde tegels, worden permanent verwijderd als u ze verwijdert. Alleen vooraf gedefinieerde tegels uit de bibliotheek kunnen later opnieuw worden toegevoegd.

## <a id="export"></a>Tegels exporteren

### Tegelrapport downloaden of afdrukken

Klik op <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> in de koptekst van een tegel om toegang te krijgen tot de volgende opties:

* **PDF-document downloaden** / **PNG-document downloaden**: Download de tegel in PDF- of PNG-indeling. De exportbestanden worden gedownload naar uw browser (map **Downloads**).

    Voor andere indelingen (**SVG, CSV en XLS**), kies **Volledig scherm weergeven** in het menu.

* **Afdrukken**: Open de tegel in het afdrukvenster.

> [!TIP]
> Als u specifieke gegevens wilt verbergen voordat u een tegel exporteert of afdrukt, klikt u op de gegevenslabels (legenda) naast of onder de tegel om gegevens te verbergen.

### ALLE rijen in een dataset naar Excel exporteren

1. Klik op een gegevenspunt in de tegel om de bijbehorende gegevens te openen.

    Er wordt een nieuw venster geopend met de gerelateerde records.

1. Klik onder de lijst op <i class="ph ph-download-simple" aria-label="Download"></i> **Exporteren**.

1. Klik op **Ja** om te bevestigen.

    Deze bewerking kan even duren. U kunt ondertussen gewoon doorwerken in SuperOffice. U krijgt een melding zodra de export is voltooid.

## Tips

* **Valutalabels verbergen:** Als u ruimte wilt besparen op tegels die bedragen tonen, stelt u **Valuta** in op **Verbergen** in het tabblad Opmaak.

* **Vergelijken met doelstelling:** Voor verkoopdashboards kunt u **Vergelijken met doelstelling** inschakelen in het tabblad Opmaak om voortgang ten opzichte van verkoopdoelen weer te geven. Deze optie is afhankelijk van het grafiektype en de datasetconfiguratie.

* **Korte getallen voor betere leesbaarheid:** Voor tegels met grote waarden schakelt u de optie **Kort getal** in om waarden in miljoenen weer te geven (bijvoorbeeld *1,2M*).

* **Tegels met groot getal:** Gebruik deze voor kerncijfers, zoals omzet of open verzoeken. Houd de tegelnaam kort zodat het getal goed opvalt.

* **Duur tonen op vervolgactiviteittegels:** Stel bij vervolgactiviteittegels **Meten** in op **Duur** om bestede tijd beter te volgen.

## Problemen oplossen

* **Ik zie het bewerkingspictogram op de tegel niet**
  * Staat het dashboard in de opmaakmodus?

* **Ik vind de optie die ik zoek niet in het taakmenu**
  * Hebt u op de juiste taakknop geklikt? (dashboard versus tegel)
  * Staat het dashboard in de opmaakmodus?

* **Ik heb geen toegang tot het tabblad Opmaak of tot velden**
  * U hebt mogelijk niet de vereiste functionele rechten. Neem contact op met uw beheerder.

* **Een selectie ontbreekt in het tabblad Selecties**
  * Zie [Over selectie-gebaseerde tegels](#selection-chart)

* **Ik heb per ongeluk een aangepaste tegel verwijderd**
  * Deze tegels kunnen niet worden hersteld. Kopieer ze indien nodig naar een privé-dashboard (bijvoorbeeld "Gearchiveerde tegels") voordat u ze verwijdert.

## Gerelateerde inhoud

* [Een nieuw dashboard toevoegen][1]
* [Dashboards gebruiken om uw verkooppijplijn te beheren][2]

<!-- Referenced links -->
[1]: create.md
[2]: ../../search-options/selection/learn/howto/display-as-charts.md
[3]: index.md#charts
[4]: ../../search-options/learn/search-criteria.md
[5]: ../../search-options/learn/find-screen.md
[6]: ../../search-options/selection/learn/howto/display-as-charts.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/edit-dashboard-tiles-sidebar.png
[img2]: ../../../media/loc/en/dashboard/edit-tile-dataset.png
[img3]: ../../../media/loc/en/dashboard/edit-tile-layout.png

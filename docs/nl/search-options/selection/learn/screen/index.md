---
uid: help-nl-selection-screen
title: Sectietabbladen in het scherm Selectie
description: Sectietabbladen in het scherm Selectie
keywords: selectie
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: reference
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Het scherm Selectie

Het eerste tabblad in een selectie bevat een lijst met leden (records, gegevens) in de actieve selectie. Selectieleden kunnen bedrijven of personen, projecten, verkopen, documenten, vervolgactiviteiten, formulierverzendingen, chatgesprekken, mailings of producten zijn.

Het uiterlijk van de lijst met leden varieert iets, afhankelijk van de inhoud van de selectie. Alle selectietypen behalve **Bedrijf/persoon** hebben twee tabbladen met selectiegegevens.

> [!TIP]
> wanneer u dubbelklikt op een record in de lijst met leden, wordt de betreffende record weergegeven.

## Sectietabbladen in het scherm Selectie

| Tabblad | Beschrijving |
|---|---|
| De lijst met leden | Bevat selectiegegevens. |
| Bedrijf/contactpersoon | Bevat bedrijven en personen die zijn gekoppeld aan de lijst met leden. Bijvoorbeeld: alle personen of bedrijven die gekoppeld zijn aan de verkoop in een selectie. Als de selectie een selectie van bedrijven/personen is, is dit het enige tabblad met leden. |
| Criteria | Bekijk en [bewerk de criteria][3] voor een dynamische selectie. |
| Details | Bekijk en bewerk [algemene informatie voor een selectie][1]. |
| Grafieken | [Bekijk de selectiegegevens in een grafiek.][5] Grafieken van selecties kunnen ook in [dashboards][6] worden gebruikt. |
| Mailings | Een mailing maken voor personen in een selectie. [Bekijk de mailings](#mailing) die op deze selectie zijn gearchiveerd. |

> [!TIP]
> Klik op <i class="ph ph-gear" aria-label="Gear"></i> rechts van de kolomkoppen in een selectie om records te groeperen en te filteren, kolommen toe te voegen/te verwijderen, en berekeningen te specificeren. U kunt deze instellingen opslaan voor de actieve selectie door **Kolommen alleen opslaan voor huidige selectie** te selecteren. Zie ook [De sectietabbladen][9] voor extra functies.

Om tussen selecties te schakelen, klikt u op de knoppen vorige/volgende (<i class="ph ph-arrow-left" aria-hidden="true"></i><i class="ph ph-arrow-right" aria-hidden="true"></i>) rechtsboven op het scherm.

### <a id="filter"></a>Lijst met leden filteren

> [!NOTE]
> Voordat u de lijst met leden filtert (bijvoorbeeld op verkopen of vervolgactiviteiten), moet u op **Alles weergeven** klikken in de voettekst van het tabblad. Op deze manier bent u er zeker van dat het tabblad alle records binnen de selectie weergeeft. Ter optimalisering van de prestaties tijdens het werken met grote selecties worden meestal alleen de eerste 100 records geladen in de lijst met leden.

Om het kolomfilter te activeren, klikt u op <i class="ph ph-gear" aria-label="Gear"></i> rechts van de kolomkoppen en op **Kolomfilter inschakelen**. De filterknop (<i class="ph ph-funnel" aria-hidden="true"></i>) wordt nu weergegeven op kolom die kan worden [gefilterd][8].

### De knop Taak <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>

Gebruik de knop **Taak** om tegelijkertijd verschillende taken uit te voeren voor alle leden in de selectie of een deel hiervan. Voorbeelden: verzenden van e-mails, massabewerking en export. Welke taken worden weergegeven, is afhankelijk van het type records binnen de selectie (wat is geselecteerd in het veld **Selectie van**).

### Overige knoppen

* **Leden verwijderen**. deze optie is alleen beschikbaar voor statische selecties. Om [specifieke leden van de selectie te verwijderen][2], selecteert u de betreffende leden, klikt u met de rechtermuisknop en selecteert u **Verwijderen**.

* **Tellen: aantal**, het aantal leden in de actieve selectie.

* **Alles weergeven**. Gebruikt om alle selectieleden weer te geven.

    > [!NOTE]
    > Standaard geeft de lijst alleen de eerste 100 records in de selectie weer. Om deze waarde te wijzigen, gaat u naar <i class="ph ph-user-circle" aria-hidden="true"></i> **Persoonlijke instellingen** > **Voorkeuren** > **Functies** > **Paginagrootte archief**.

* <i class="ph ph-arrow-clockwise" aria-label="Refresh"></i>: Ververst de gegevens in de lijst.

### <a id="mailing"></a> Bekijk mailings gearchiveerd op selectie

Gebruik het tabblad **Mailings** in het scherm Selectie om alle mailings met betrekking tot een selectie bij te houden.

Dubbelklik op een mailing om deze te openen.

**Een mailing opstellen**: klik om een [nieuwe mailing te maken][7] voor de personen in deze selectie.

**Exporteren**: wordt gebruikt om de lijst te exporteren naar een spreadsheet.

## Gerelateerde inhoud

* [Taken uitvoeren met selecties][4]
* [Filters gebruiken in de sectietabbladen][8]
* [Selecties maken][1]

<!-- Referenced links -->
[1]: ../create/index.md
[2]: ../update/add-remove-members-static.md
[5]: ../howto/display-as-charts.md
[3]: ../../../learn/search-criteria.md
[6]: ../../../../dashboard/learn/create.md
[7]: ../../../../marketing/mailing/learn/create/index.md
[8]: ../../../../learn/section-tabs/filter.md
[9]: ../../../../learn/section-tabs/index.md
[4]: ../../../../learn/getting-started/index.md

---
uid: help-nl-manage-status-monitors
title: Statuscontroles beheren
description: Statuscontroles beheren
author: SuperOffice RnD
so.date: 02.22.2023
keywords: verkoop, SAINT
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Statuscontroles beheren

[!include[Requirement](../includes/note-saint-req.md)]

Wanneer u meerdere statuscontroles en verschillende perioden/tellers instelt, is het belangrijk om deze regelmatig te controleren. De tellers en statussen moeten namelijk opnieuw gegenereerd en bijgewerkt blijven en u moet controleren dat de [criteria][1] correct zijn voor de verschillende statussen.

In de onderstaande onderwerpen vindt u informatie over het in- en uitschakelen van statuscontroles en het opnieuw genereren van statussen en tellers. [!include[Define counter](../../../learn/includes/def-counter.md)]

## Algemene informatie over het bijwerken en opnieuw genereren van statussen en tellers

Onder aan het tabblad **Statuscontroles** bevinden zich indicatoren (tekst die de datum aangeeft waarop voor het laatst is gegenereerd, die aangeeft of de geselecteerde status of tellers nooit zijn gegenereerd of die aangeeft of de geselecteerde status opnieuw moet worden gegenereerd in verband met wijzigingen) voor het opnieuw genereren van statussen en tellers.

U moet statussen en/of tellers opnieuw genereren als de indicatoren aangeven dat het lang geleden is dat de laatste generatie lang geleden was of dat de statussen en/of tellers nooit zijn gegenereerd. Hetzelfde geldt als statussen worden gewijzigd. Statussen en tellers die niet worden bijgewerkt, worden toch ingeschakeld en kunnen in SuperOffice CRM worden gebruikt, maar de resultaten die deze opleveren, zijn mogelijk niet correct. In de onderstaande onderwerpen wordt beschreven hoe u statussen en tellers opnieuw kunt genereren.

### Hoe u kunt zien of het is bijgewerkt

Als een item niet wordt bijgewerkt, wordt het weergegeven als ![pictogram][img1] (statussen) en ![pictogram][img3] / ![pictogram][img4] / ![pictogram][img5] (tellers) in SuperOffice CRM.

## Statussen opnieuw genereren

Wanneer u een [criterium toevoegt, bewerkt of verwijdert][2], of bijvoorbeeld een intentie voor een taak in SuperOffice CRM bewerkt, staat er een rood kruis ( ![pictogram][img6] ) in de statuslijst links van de betreffende status(sen). Statussen die met een rood kruis zijn gemarkeerd, zijn niet beschikbaar.

U moet deze statussen dan opnieuw genereren door te klikken op een van deze knoppen:

| Pictogram | Naam | Beschrijving | Locatie
|---|---|---|---|
| ![pictogram][img2] | Geselecteerde statuscontrole opnieuw genereren | Selecteer om de geselecteerde statussen te regenereren | Onder aan het tabblad **Bedrijf**, **Persoon** of **Project** |
| ![pictogram][img2] | Alle statuscontroles opnieuw genereren | Selecteer om alle statussen te regenereren | Onder aan het tabblad **Status** |

## Tellerwaarden opnieuw genereren

| Pictogram | Naam | Beschrijving |
|---|---|---|
| ![pictogram][img2] | Alle tellers regenereren | Selecteer om alle tellers te regenereren |

<!-- Referenced links -->
[1]: ../../../../search-options/learn/search-criteria.md
[2]: select-status-criteria.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/status-inactive.png
[img2]: ../../../../../media/icons/arrow-right.png
[img3]: ../../../../../media/icons/admin/saint-counter-company-dis.png
[img4]: ../../../../../media/icons/admin/saint-counter-project-dis.png
[img5]: ../../../../../media/icons/admin/saint-counter-sale-disabled.png
[img6]: ../../../../../media/icons/admin/red-x.png

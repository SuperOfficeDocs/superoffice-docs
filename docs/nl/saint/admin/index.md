---
uid: help-nl-saint-admin
title: SAINT in Instellingen en onderhoud
description: Leer de belangrijkste concepten van SuperOffice SAINT, inclusief criteria, afbeeldingen, tellers en standaard vervolgactiviteiten.
keywords: SAINT, activiteitenbewaking, statusbewaking
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
index: true
redirect_from: /nl/sale/saint/learn/admin/index
---

# SAINT in Instellingen en onderhoud

SAINT (Sales Intelligence) helpt u bij het bewaken van bedrijven, personen en projecten zodat u op het juiste moment follow-up kunt doen. Een **activiteitenbewaking** (ook bekend als statusbewaking) combineert criteria, tellers en optionele eigenschappen om records uit te lichten die aandacht nodig hebben.

Voordat u SAINT implementeert, is het belangrijk om te weten wat u wilt verbeteren en hoe u dit gaat analyseren. Bedenk vervolgens welke proactieve acties uw organisatie kan ondernemen om de huidige situatie te verbeteren. Bijvoorbeeld:

* Een groepscampagne versturen
* Alle klanten in de SAINT-selectie bellen
* Alle verzoeken opvolgen

[!include[Requirement](../includes/note-saint-req.md)]

![SAINT-scherm met statuslijst, beschrijving, afbeelding en criteria -screenshot][img1]

## Statuslijst

De statuslijst op de tabbladen **Bedrijf**, **Persoon** en **Project** toont actieve statusmonitors voor dit record en – als **Verwijderde tonen** is geselecteerd – ook verwijderde.

| Element | Beschrijving |
|---|---|
| **Visualiseren-pictogram** <i class="ph ph-eye" aria-label="eye"></i> | Geeft aan of een statusafbeelding wordt weergegeven op bedrijfs-, persoon- of projectkaarten. Het pictogram verschijnt alleen als het **Visualiseren**-vakje is aangevinkt. |
| **Rode X** | Wordt weergegeven naast statussen die [geregenereerd][8] moeten worden. Deze statussen worden niet bijgewerkt en geven geen actuele gegevens terug. |
| **Naamkolom** | Toont de namen van de statussen. Verwijderde statussen worden rood weergegeven als **Verwijderde weergeven** is aangevinkt onder de lijst. |
| **Prioriteitskolom** | Bepaalt welke statusafbeelding op de kaart wordt weergegeven wanneer een bedrijf, persoon of project overeenkomt met de criteria voor meerdere statussen. De status met de hoogste prioriteit wordt weergegeven, terwijl andere actieve statussen beschikbaar zijn als koppelingen in het statusdialoogvenster. |

## Eigenschappen

Een statusmonitor combineert verschillende eigenschappen die bepalen hoe deze werkt:

* **Criteria:** Elke status moet een of meer criteria bevatten. Deze voorwaarden bepalen op welke bedrijven, personen of projecten de status van toepassing is. U kunt bijvoorbeeld een status definiëren voor klanten zonder verkopen in de afgelopen 90 dagen.

* **Statusafbeeldingen:** Een optionele afbeelding kan worden weergegeven op bedrijfs-, persoons- of projectkaarten die voldoen aan de criteria. Een spinnenweb kan bijvoorbeeld inactiviteit aangeven. Afbeeldingen verschijnen als lichte watermerken en kunnen worden aangeklikt voor meer details.

* **Standaard vervolgactiviteit:** Wanneer een gebruiker op de status klikt, kan deze een vervolgactiviteit aanmaken. Het type en de beschrijving kunnen vooraf gedefinieerd worden, zodat de vervolgactiviteit duidelijk aangeeft welke actie vereist is.

## Tellers en perioden

Tellers [volgen activiteit over tijd][5], zoals verkopen, verzoeken of voltooide vervolgactiviteiten.
U kunt tellers gebruiken in zoekopdrachten en selecties om records te identificeren die bepaalde drempelwaarden halen of missen.

U kunt maximaal drie verschillende perioden definiëren (bijvoorbeeld 30, 60 en 90 dagen).
Hiermee kunt u dezelfde teller, zoals "Aantal verkopen", toepassen op verschillende tijdspannes.

## <a id="database"></a>Hoe SAINT tellers en statussen opslaat

SAINT-tellers worden opgeslagen in de [countervalue][13]-tabel en automatisch bijgewerkt wanneer je acties uitvoert:

* Wanneer SAINT is ingeschakeld, worden er een aantal tellerregels aangemaakt telkens als een persoon of project wordt aangemaakt.

* Telkens wanneer een vervolgactiviteit, document of verkoop wordt aangemaakt, worden de bijbehorende tellerregels bijgewerkt.

SAINT-**waarden** zijn eenvoudige binaire waarden (aan of uit) die het uiterlijk van de bedrijfs- en projectkaarten bepalen. Deze waarden worden opgeslagen in de [statusvalue][14]-tabel.

## Gerelateerde inhoud

* [Nieuwe statusmonitor instellen][1]
* [Statussen visualiseren met afbeeldingen][2]
* [Tellers en tellerinstellingen][5]
* [Statusmonitors bijwerken, verwijderen en herstellen][7]
* [Statusmonitors en tellers regenereren][8]

<!-- Gerefereerde links -->
[1]: set-up.md
[2]: set-up.md#image
[5]: counter-settings.md
[7]: update.md
[8]: update.md#regen
[13]: ../../../en/database/tables/countervalue.md
[14]: ../../../en/database/tables/statusvalue.md

<!-- Gerefereerde afbeeldingen -->
[img1]: ../../../media/loc/en/saint/status-monitors-company-tab.png

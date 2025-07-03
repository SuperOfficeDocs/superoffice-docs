---
uid: help-nl-selection
title: Selectie
description: Selectie
keywords: statische selectie, dynamische selectie, gecombineerde selecties, scherm Selectie, selectieleden, selectie
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/search-options/selection/learn/combined-selections
  - /nl/search-options/selection/learn/dynamic-selections
  - /nl/search-options/selection/learn/static-selections
  - /nl/search-options/selection/learn/screen/index
---

# Selectie

U kunt selecties maken van records/gegevens waar u veel mee werkt. Als u eveneens een licentie hebt voor Sale Quote Access, kunt u ook selecties maken van producten.

> [!TIP]
> U kunt grafieken maken uit selecties en u kunt ook selecties gebruiken om mailings te maken.

Alle selecties bevatten tevens een overzicht met bedrijven en personen die zijn gekoppeld aan de records in de selectie. Bijvoorbeeld bedrijven en personen gekoppeld aan de verkoop in een verkoopselectie.

## <a id="types"></a>Typen

SuperOffice CRM bevat drie verschillende selectietypen:

* **Statische selectie:** Bevat alleen handmatig toegevoegde leden.
* **Dynamische selectie:** Wordt automatisch bijgewerkt met leden die aan de selectiecriteria voldoen.
* **Gecombineerde selectie:** Een combinatie van twee bestaande selecties.

### Statische selecties

Een statische selectie bevat alleen de leden die u individueel of via een zoekopdracht hebt toegevoegd, in tegenstelling tot een dynamische selectie. Nadat u een statische selectie hebt gemaakt en er leden aan hebt toegevoegd, blijft deze ongewijzigd totdat u handmatig leden toevoegt of verwijdert.

Gebruik een statische selectie als u altijd volledige controle wilt hebben over de leden. U kunt handmatig [leden toevoegen en verwijderen][7], afzonderlijk of via een zoekopdracht.

**Voorbeeld:** Een zorgvuldig samengestelde lijst van VIP-klanten voor een gepersonaliseerde marketingcampagne.

### Dynamische selecties

Een dynamische selectie werkt als een opgeslagen zoekopdracht die telkens wordt uitgevoerd wanneer u de selectie opent. Wanneer u records toevoegt aan SuperOffice CRM die voldoen aan de zoekcriteria van een dynamische selectie, wordt de selectie automatisch bijgewerkt met de nieuwe leden – in tegenstelling tot een statische selectie.

Gebruik een dynamische selectie als u een altijd bijgewerkte lijst wilt van bedrijven, personen, verkopen, projecten, documenten, vervolgactiviteiten, verzoeken of producten die voldoen aan specifieke criteria.

**Voorbeeld:** Een real-time lijst van alle openstaande verkoopkansen in het huidige kwartaal, die automatisch wordt bijgewerkt wanneer er nieuwe deals worden gecreëerd.

### Gecombineerde selecties

Een gecombineerde selectie is een combinatie van twee bestaande selecties (statisch of dynamisch). De gecombineerde selectie kan records bevatten die in beide selecties voorkomen, records die verschillen, records die uniek zijn voor één van de selecties of alle records uit beide selecties.

**Voorbeeld:** Een gefilterde lijst van alle klanten die een specifiek product hebben gekocht en tegelijkertijd een openstaand supportverzoek hebben, zodat u follow-ups kunt prioriteren.

Na het [maken van een gecombineerde selectie][4] kunt u ervoor kiezen deze om te zetten in een statische selectie.

## <a id="tabs"></a>Tabbladen in het scherm Selectie

| Tabblad | Beschrijving |
|---|---|
| De lijst met leden | Toont de lijst met records in de selectie. |
| Bedrijf/persoon | Toont bedrijven en personen die zijn gekoppeld aan selectieleden. Als de selectie bedrijven of personen bevat, is dit het enige tabblad met leden. |
| Criteria | Bekijk en [bewerk de criteria][9] voor een dynamische selectie. |
| Details | Bekijk en bewerk algemene selectiegegevens. |
| Grafieken | [Bekijk selectiegegevens als een grafiek.][3] Grafieken kunnen ook worden gebruikt in [dashboards][16]. |
| Mailings | Toont mailings die op deze selectie zijn gearchiveerd. [Maak een mailing][8] voor personen in de selectie. |

> [!TIP]
> Klik op <i class="ph ph-gear" aria-label="Gear"></i> rechts van de kolomkoppen in een selectie om records te groeperen en te filteren, kolommen toe te voegen/verwijderen en berekeningen in te stellen. U kunt deze instellingen opslaan voor de actieve selectie door **Kolommen alleen opslaan voor huidige selectie** te selecteren.

## <a id="members"></a>Selectieleden

Het eerste tabblad in een selectie toont de records in de selectie. Dubbelklik op een record om de details te openen en te bekijken.

De indeling varieert afhankelijk van de inhoud van de selectie. Alle selecties behalve **Bedrijf/persoon** hebben twee lijsten: een met selectiegegevens en een met gekoppelde bedrijven en personen.

> [!NOTE]
> Standaard worden alleen de eerste 100 records weergegeven. Om dit te wijzigen, gaat u naar <i class="ph ph-user-circle" aria-hidden="true"></i> **Persoonlijke instellingen** > **Voorkeuren** > **Functies** > **Paginagrootte archief**.

### <a id="filter"></a>De lijst met leden filteren

1. Klik op **Alles weergeven** in de voettekst van het tabblad om alle records in de selectie te tonen.

1. Om de [kolomfilter][12] te activeren, klikt u op <i class="ph ph-gear" aria-label="Gear"></i> en selecteert u **Kolomfilter inschakelen**. De filterknop (<i class="ph ph-funnel" aria-hidden="true"></i>) verschijnt in filterbare kolommen.

## Knoppen

| Knop | Naam | Beschrijving |
|---|---|---|
| <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i> | Takenmenu | Voer verschillende taken uit voor selectieleden, zoals e-mails verzenden, massabewerking en exporteren. De beschikbare taken zijn afhankelijk van het recordtype in het veld **Selectie van**. |
| <i class="ph ph-arrow-clockwise" aria-hidden="true"></i> | Vernieuwen | Vernieuwt de gegevens in de lijst. |
| **Aantal: getal** | | Toont het aantal leden in de actieve selectie. |
| <i class="ph ph-download-simple" aria-hidden="true"></i> | Exporteren | [Exporteert de lijst naar een spreadsheet.][6] |

## <a id="ex"></a>Voorbeelden van hoe u selecties kunt gebruiken

Selecties stellen u in staat om gegevens te groeperen en te filteren op basis van specifieke criteria. Hieronder vindt u voorbeelden van verschillende typen selecties en hun mogelijke toepassingen.

### Bedrijven

U kunt een dynamische selectie maken met alle bedrijven in de categorie *Leverancier* in Duitsland als u verdere activiteiten in Duitsland plant.

### Personen

* Alle personen die in de afgelopen 30 dagen zijn aangemaakt.
* Alle personen waarvoor *kerstkaart* of *nieuwsbrief* als interesse is ingesteld.

### Verkoop

Een selectie met alle verkopen die u in het eerste kwartaal hebt afgerond, of alle verkopen met de status **Vastgelopen**, helpt u om trends te identificeren en te bepalen waar u uw toekomstige verkoopinspanningen op moet richten.

> [!TIP]
> [Groepeer kolommen en som bedragen][10] om trends te ontdekken en een duidelijk overzicht van je gegevens te krijgen.

![Selectie van verkopen - groeperen en som van bedragen -screenshot][img3]

### Projecten

* Een selectie van alle actieve projecten van het type *Intern* helpt u om te beoordelen welke projecten kunnen worden afgesloten en welke verdere actie vereisen.

* Alle actieve projecten waaraan u deelneemt.

### Documenten

* Een selectie van alle documenten die u in de afgelopen maand hebt gemaakt, biedt u een overzicht van welke documenten zijn geproduceerd en helpt u eventuele vergeten documenten op te sporen.

* Alle contracten die in SuperOffice CRM zijn geregistreerd.

### Vervolgactiviteiten

* Een selectie van alle vervolgactiviteiten voor een specifieke klant geeft u inzicht in de relatie met de klant voordat u een verkoopgesprek voert.

* Een selectie van alle vervolgactiviteiten van deze maand helpt u om te zien welke afspraken u hebt en of u extra afspraken moet inplannen.

### Producten (vereist een Sales Premium-licentie)

* Een lijst van alle klanten die een specifiek product of een specifieke productcategorie hebben gekocht.

* Een selectie van alle producten die dit jaar zijn verkocht, gebaseerd op verkopen die offertes bevatten en de status **Verkocht** hebben. De selectie kan worden beperkt tot specifieke productcategorieën, productfamilies, enz., afhankelijk van de gewenste statistische output.

* Als u een productupgrade uitvoert van bijvoorbeeld versie 2 naar versie 3, kunt u een selectie maken van alle klanten die versie 2 hebben gekocht en deze gebruiken als basis voor een campagne.

### Verzoeken

* Een lijst van openstaande verzoeken met de prioriteit **Hoog** voor uw afdeling (categorie).

* Een selectie van alle openstaande verzoeken die langer dan een week niet zijn bijgewerkt, zodat u de verantwoordelijke verzoekbehandelaars kunt opvolgen.

### Selecties

* Alle actieve selecties waarvan u de eigenaar bent.
* Alle selecties met een specifieke categorie of van een specifiek type.

### Marketing en klantbetrokkenheid

* Niet-verwerkte formulierverzendingen voor uw klanten.
* Uw chatgesprekken.
* De chatgesprekken van uw klanten met specifieke waarderingen.
* Mailings met een bepaalde open-rate of klikratio.
* Mailings met een hoog bouncepercentage.

## Gerelateerde inhoud

* [Record toevoegen als een favoriet][11]
* [Selecties maken][2]
* [Selecties bewerken en verwijderen][5]
* [Taken uitvoeren met selecties][1]
* [Selecties weergeven als grafieken][3]

<!-- Referenced links -->
[1]: howto/index.md
[3]: howto/display-as-charts.md
[6]: howto/export.md
[8]: howto/create-mailings.md
[2]: create.md
[4]: combine.md
[5]: update.md
[7]: add-remove-members-static.md
[9]: ../../learn/search-criteria.md
[11]: ../../../learn/basics/fav.md
[10]: ../../../learn/section-tabs/configure-columns.md#calculate
[12]: ../../../learn/section-tabs/filter.md
[16]: ../../../dashboard/learn/create.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/sale/selection-sales-column-calculation-grouping.png

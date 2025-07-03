---
uid: help-nl-request-priority-create
title: Prioriteit maken
description: Prioriteit maken
keywords: verzoek, prioriteit
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/request/learn/priority/create
index: true
---

# Verzoekprioriteit maken

De standaardprioriteiten in het systeem zijn **Hoog**, **Gemiddeld** en **Laag**. U kunt echter zowel nieuwe prioriteiten toevoegen als de instellingen van bestaande prioriteiten bewerken.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Stappen

1. Ga in Instellingen en onderhoud naar **Verzoeken** in de navigator en selecteer het tabblad **Prioriteiten**.

1. Klik op de knop **Toevoegen**.

1. Voer een beschrijvende naam in in het veld **Prioriteitsnaam**.

1. Voer op het tabblad **Eigenschappen** de volgende informatie in:

    * Extern
    * Als standaard gebruiken
    * Deadline
    * Verwijderd

    Zie [Prioriteitsinstellingen](#priority-settings) voor meer informatie over elk veld.

1. Onder **Tijdsperiode** specificeert u de periode waarin verzoeken moeten worden verwerkt.

    * Geef tijdsintervallen op voor elke dag van de week.
    * Optioneel: voer dagen in om uit te sluiten in het veld **Feestdagen (dag/maand)**. Selecteer **Jaar opnemen** om het jaartal op te nemen.

1. Op het tabblad **Escalatiegebeurtenissen** stelt u in hoe de escalatieketen moet reageren op verschillende gebeurtenissen in het verzoek. Opties:

    * Verzoek gelezen door eigenaar
    * Andere eigenaar (handmatig)
    * Nieuwe informatie
    * Verzoek gesloten
    * Andere prioriteit

        > [!NOTE]
        > Als u **Doorgaan** selecteert, blijft het verzoek op hetzelfde niveau in de escalatieketen als voor de wijziging. De ingestelde tijdswaarden worden niet opnieuw toegepast.

    * Nieuw verzoek
    * Verzoeken escaleren volgens tijdsperiode

    Zie [Prioriteitsinstellingen](#escalation-options) voor meer details over elke optie.

1. Klik op **Opslaan**. De prioriteit wordt aangemaakt. U kunt nu bijvoorbeeld [escalatieniveaus aan deze prioriteit koppelen][1].

## <a id="priority-settings"></a>Prioriteitsinstellingen

| Instelling | Beschrijving |
|---|---|
| Naam | Een herkenbare naam voor de prioriteit. |
| Verwijderd | Is de prioriteit actief (normaal) of verwijderd (niet beschikbaar).|
| Extern | wanneer deze optie wordt ingeschakeld, wordt de prioriteit toegankelijk vanuit SuperOffice Customer Centre. |
| Als standaard gebruiken | wanneer deze optie wordt ingeschakeld, wordt dit de standaardprioriteit. |
| Deadline | De deadline voor verzoeken met deze prioriteit. Deze waarde wordt berekend op basis van de tijdsperiode voor de prioriteit en wordt voor elk verzoek afzonderlijk opgeslagen. De resulterende waarde geeft aan hoeveel tijd nog resteert tot de deadline. |
| Tijdsperiode | Tijdsintervallen voor elke dag van de week die van toepassing zijn op de verwerking van verzoeken. |
| Feestdagen (dag/maand) | Dagen uitgesloten van de tijdsperiode. Dit betreft normaalgesproken nationale feestdagen waarop escalaties niet moeten plaatsvinden. De lijst bestaat uit door komma's gescheiden waarden, met de notatie dag/maand. Als u bijvoorbeeld 25 en 26 december wilt uitsluiten, voert u in: 25/12, 26/12. U kunt ook datums toevoegen met behulp van het onderstaande datumveld. |
| Jaar toevoegen | als u dit activeert, wordt het jaartal toegevoegd aan de vakantiedatums. |
| Verzoeken escaleren volgens tijdsperiode | Als deze optie is ingeschakeld, worden aanvragen met deze prioriteit alleen geëscaleerd gedurende het gedefinieerde tijdsperiode van de prioriteit. Escalatie is niet mogelijk buiten de perioden die zijn opgegeven op het tabblad **Tijdsperiode**. |

## <a id="escalation-options"></a>Escalatie-opties

| Optie | Beschrijving |
|---|---|
| Verzoek gelezen door eigenaar | Indien ingeschakeld, wordt de escalatieketen uitgevoerd zoals aangegeven in de keuzelijst rechts, wanneer de eigenaar een verzoek heeft gelezen. In alle keuzelijsten op dit tabblad kunt u kiezen uit de volgende acties: **Stoppen**, **Doorgaan** en **Opnieuw starten**. |
| Andere eigenaar (handmatig) | Indien ingeschakeld, wordt de escalatieketen uitgevoerd zoals aangegeven in de keuzelijst rechts, wanneer een verzoek handmatig van eigenaar wisselt. |
| Nieuwe informatie | Indien ingeschakeld, wordt de escalatieketen op de via de keuzelijst rechts aangegeven manier uitgevoerd wanneer nieuwe informatie aan een verzoek wordt toegevoegd. Dit is bijvoorbeeld het geval wanneer de klant of gebruiker een nieuw bericht aan het verzoek toevoegt. |
| Verzoek gesloten | Indien ingeschakeld, wordt de escalatieketen uitgevoerd zoals aangegeven in de keuzelijst rechts, wanneer een verzoek wordt gesloten. |
| Andere prioriteit | Indien ingeschakeld, wordt de escalatieketen uitgevoerd zoals aangegeven in de keuzelijst rechts, wanneer de prioriteit van een verzoek in deze prioriteit wordt gewijzigd. |
| Nieuw verzoek | Indien ingeschakeld, wordt de escalatieketen uitgevoerd zoals aangegeven in de keuzelijst rechts, wanneer een nieuw verzoek met deze prioriteit in het systeem wordt geregistreerd. |

<!-- Referenced links -->
[1]: escalation-levels.md

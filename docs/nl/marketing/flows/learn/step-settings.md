---
uid: help-nl-flow-step-settings
title: Stap instellingen
description: Overzicht van instellingen voor de verschillende flowstappen.
keywords: stap, stap instelling, stapveld
author: Bergfrid Dias
date: 09.26.2025
version: 11.3
content_type: reference
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Stap instellingen

> [!NOTE]
> Veel velden hebben een lijst met vooraf gedefinieerde waarden waaruit je kunt kiezen. Klik op <i class="ph ph-caret-down" aria-label="Chevron"></i> om de lijst uit te vouwen. Selecteer vervolgens een waarde voor dat veld. Je kunt ook beginnen met typen in het veld om een specifieke waarde te zoeken, zoals een selectienaam.

## Toevoegen aan selectie/project

| Instelling | Beschrijving |
|---|---|
| Persoon toevoegen aan statische selectie | De deelnemer wordt lid van de opgegeven statische selectie. |
| Persoon toevoegen als projectlid | De deelnemer wordt lid van het opgegeven project. |

## Vervolgeaktiviteit maken

| Instelling | Beschrijving |
|---|---|
| Titel | Een beschrijvend label. Aanvullende details worden in de agenda geplaatst. |
| Type | Een vooraf gedefinieerde lijst van activiteiten zoals Vergadering (extern) en Telefoontje. Beschikbare velden zijn afhankelijk van het geselecteerde type vervolgeaktiviteit. |
| Project | Een project gekoppeld aan de vervolgeaktiviteit. |
| Datum | Wanneer de vervolgeaktiviteit begint of is gepland.<br />**Taakdatum:** Dit betekent een taak in de checklist van de gebruiker.<br />**Vergaderdatum:** Dit betekent een vervolgeaktiviteit in de agenda. "Eerstvolgende beschikbare" of "Eerstvolgende na x dagen/werkdagen/weken". |
| Toewijzen aan | De eigenaar van de vervolgeaktiviteit. De "onze contaktpersoon" of "onze servicecontactpersoon" van de deelnemer, of een specifiek genoemde medewerker. |
| Agenda | Aanvullende details over de vervolgeaktiviteit, zoals een agenda, een beschrijving, bestanden, afbeeldingen en links. Opties voor opmaak met opmaakopties voor rijke tekst zijn beschikbaar. |

## Verzoek maken

| Instelling | Beschrijving |
|---|---|
| Titel | Een beschrijvende naam voor het verzoek. |
| Verzoektype | Richt zich op een reeks attributen die nodig zijn voor een specifiek proces. Beïnvloedt de beschikbare statussen en prioriteiten. |
| Status | Geeft de fase van het verzoekbeheer aan (open of gesloten). |
| Categorie | Een set regels die bepalen hoe verzoeken worden verwerkt. |
| Prioriteit | Geeft de belangrijkheid van het verzoek weer. |
| Eigenaar | Aan wie het verzoek moet worden toegewezen. |
| Bericht | De inhoud van het verzoek. Opties voor opmaak met opmaakopties voor rijke tekst en sjabloonvariabelen voor persoon en het bedrijf van de contactpersoon zijn beschikbaar. |

## Verkoop maken

| Instelling | Beschrijving |
|---|---|
| Titel | Een beschrijvende naam van de verkoop. Details komen in de beschrijving. |
| Verkooptype | Een benoemde set informatie over het verkoopproces. Beïnvloedt standaard verkoopfase en geschatte verkoopdatum. Sommige verkoopsoorten zijn gekoppeld aan een [verkoopgids][14]. |
| Fase | De huidige fase van de verkoop (open, verloren, verkocht). |
| Bedrag | Verwacht bedrag voor de pijplijn. |
| Beschrijving | Een meer gedetailleerde beschrijving van de verkoop. |
| Project | Een project gekoppeld aan de verkoop. |
| Datum | De geschatte verkoopdatum. "Geschat door verkoop type" of "Na X dagen/werkdagen/weken". |
| Eigenaar | De persoon die verantwoordelijk is voor de verkoop. De "onze contactpersoon" of "onze servicecontactpersoon" van de deelnemer, of een specifiek genoemde medewerker. |

## Distribueer naar eigenaar

| Instelling | Beschrijving |
|---|---|
| Alleen nieuwe eigenaar toepassen als de contactpersoon momenteel niet is toegewezen | Zorgt ervoor dat eigenaarschap alleen wordt toegewezen als er nog geen eigenaar is. |
| Contactpersonen distribueren naar | Selecteer een of meer medewerkers of een primaire groep. Contactpersonen worden gelijkmatig verdeeld over de geselecteerde medewerkers of groepsleden. |
| Als er niemand beschikbaar is, wijs dan contactpersonen toe aan | Fallback optie. Kies een standaard eigenaar als alle geselecteerde medewerkers/groepsleden niet beschikbaar zijn. |

## Flow verlaaten

De flow-control stappen **Opsplitsen** en **wacht op actie** (en ook SMS versenden) hebben een **Flow verlaaten** optie om deelnemers die niet aan een voorwaarde voldoen uit de flow te halen. Indien geselecteerd, kan de dropout persoon worden verplaatst naar een andere flow en/of worden toegevoegd aan een selectie.

| Instelling | Beschrijving |
|---|---|
| Voeg deelnemer toe aan een andere flow na vertrek | Het dropout persoon wordt **voorgesteld** als deelnemer voor de opgegeven flow. Filters bepalen of ze die flow starten of niet. |
| Voeg deelnemer toe aan statische selectie na vertrek | Het dropout persoon wordt lid van de opgegeven selectie. Je kunt een nieuwe selectie maken vanuit de stapinstellingen. |

## Voltooid

Deelnemers die de voltooidstap bereiken, hebben het einde van de flow bereikt. De deelnemer kan de flow hebben voltooid met status = voltooid of voltooid met succes. Er worden geen verdere acties uitgevoerd op een deelnemer in deze flow bij het bereiken van de stap.

| Instelling | Beschrijving |
|---|-|
| Toevoegen aan een andere flow wanneer een succes criterium wordt voldaan | Voltooid met succes |
| Toevoegen aan een andere flow wanneer er geen succes criterium wordt voldaan | Voltooid |

## Melden via e-mail

| Instelling | Beschrijving |
|---|---|
| Aan | De ontvanger - "onze contactpersoon", "onze servicecontactpersoon" of een specifiek e-mailadres. |
| Onderwerp | Tekst voor het onderwerp van de e-mail. |
| Tekst | Voer het bericht in. |

U kunt het onderwerp en het bericht personaliseren met contactvariabelen (hetzelfde als samenvoegtags binnen de mailing-editor).

## Melden via SMS

| Instelling | Beschrijving |
|---|---|
| Aan | De ontvanger - "onze contactpersoon", "onze servicecontactpersoon" of specifieke contacten. |
| Van | Standaard ingesteld op de flowinstelling "SMS-verzender". |
| Tekst | Voer de SMS-tekst in. Je kunt het bericht personaliseren met contactvariabelen (hetzelfde als samenvoegtags binnen de mailing-editor). |

## E-mail versenden

| Instelling | Beschrijving |
|---|---|
| Maak nieuwe e-mail voor deze stap | Opent de mailing wizard. |
| Selecteer bestaande e-mail voor deze stap | Zie [Inhoud toevoegen][1]. |
| Onderwerp | Tekst voor het onderwerp van de e-mail. Je kunt het onderwerp personaliseren met contactvariabelen (hetzelfde als samenvoegtags binnen de mailing-editor). |
| Bijlage | Maximaal 25 MB totaal. |

## SMS versenden

| Instelling | Beschrijving |
|---|---|
| Van | Standaard ingesteld op de flowinstelling "SMS-verzender". |
| Tekst | Voer de SMS-tekst in. Je kunt het bericht personaliseren met contactvariabelen (hetzelfde als samenvoegtags binnen de mailing-editor). |
| Verlaat de flow indien geen mobiel nummer is geregistreerd | Wat moet er gebeuren als het persoon de SMS niet kan ontvangen? Indien waar, kun je ze toevoegen aan een andere flow of aan een statische selectie na vertrek. |

## Opsplitsen

| Instelling | Beschrijving |
|---|---|
| Titel | Een kort beschrijvend label. |
| Splitsen op basis van | De gegevens / gedrag om op te differentiëren. |
| Naam van tak| Een beschrijvende naam van de tak, waarbij wordt aangegeven welke deelnemers welke tak volgen. |
| Alle anderen | De tak voor het behandelen van deelnemers die niet voldoen aan de voorwaarden van een van de andere takken. |
| Flow verlaaten | Bepaalt of deelnemers die in de tak voor "alle anderen" belanden, de flow moeten verlaten. Indien waar, kun je ze toevoegen aan een andere flow of aan een statische selectie na vertrek. Indien onwaar, kun je meer stappen toevoegen aan deze tak. |

De overige velden voor het specificeren van takinstellingen zijn afhankelijk van waarop de split is gebaseerd.

## Trigger

| Instelling | Beschrijving |
|---|---|
| Een contactpersoon kan deze flow slechts eenmaal starten | Of een persoon opnieuw kan worden ingeschreven in deze flow. |
| Filter | Een set criteria die moeten worden voldaan voor een voorgesteld persoon om te worden toegelaten tot de flow. Slechts eenmaal gecontroleerd. |
| Uitsluitingslijst | Een statische selectie van personen die niet aan de flow worden toegevoegd, of die de flow verlaten als ze al deelnemen. |

## Persoon bijwerken

Dit werkt vergelijkbaar met [bulk update][10].

## Wachttijd

| Instelling | Beschrijving |
|---|---|
| Aantal dagen/uren na vorige stap | De **duur** van de pauze. Wacht een specifieke tijd. |
| Tot specifieke datum/tijd | Het **einde** van de pauze. Wacht tot een specifieke datum. |

## Wacht op actie

| Instelling | Beschrijving |
|---|---|
| Maximale wachttijd | Hoe lang te wachten op een actie (time-out). Standaard: 7 dagen. |
| Flow verlaaten indien geen acties binnen max wachttijd | Deelnemers die niet reageren verlaten de flow met de status "dropout". Indien waar, kun je ze toevoegen aan een andere flow of aan een statische selectie na vertrek. |

## Gerelateerde inhoud

* [Leer meer over activiteiten][11]

<!-- Referenced links -->
[1]: content.md
[10]: ../../../learn/basics/bulk-update.md
[11]: ../../../learn/basics/activity.md
[14]: ../../../sale/learn/sales-guides.md

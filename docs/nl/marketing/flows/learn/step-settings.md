---
uid: help-nl-flow-step-settings
title: Step settings
description:
keywords: Marketing, flow
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 06.17.2024
so.version: 10.3.5
so.topic: howto
language: nl
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Stap instellingen

> [!NOTE]
> Veel velden hebben een lijst met vooraf gedefinieerde waarden waaruit je kunt kiezen. Klik op de pijl ![icon][img4] om de lijst uit te vouwen. Selecteer vervolgens een waarde voor dat veld. Je kunt ook beginnen met typen in het veld om een specifieke waarde te zoeken, zoals een selectienaam.

## Toevoegen aan selectie en/of project

| Instelling | Beschrijving |
|---|---|
| Persoon toevoegen aan statische selectie | De deelnemer wordt lid van de opgegeven statische selectie. |
| Persoon toevoegen als projectlid | De deelnemer wordt lid van het opgegeven project. |

## Maak opvolging

| Instelling | Beschrijving |
|---|---|
| Titel | Een beschrijvend label. Aanvullende details worden in de agenda geplaatst. |
| Type | Een vooraf gedefinieerde lijst van activiteiten zoals Vergadering (extern) en Telefoontje. Beschikbare velden zijn afhankelijk van het geselecteerde type opvolging. |
| Project | Een project gekoppeld aan de opvolging. |
| Datum | Wanneer de opvolging begint of is gepland.<br />**Taakdatum:** Dit betekent een taak in de checklist van de gebruiker.<br />**Vergaderdatum:** Dit betekent een opvolging in de agenda. "Eerstvolgende beschikbare" of "Eerstvolgende na x dagen/werkdagen/weken". |
| Toewijzen aan | De eigenaar van de opvolging. De "onze persoon" of "onze service persoon" van de deelnemer, of een specifiek genoemde medewerker. |
| Agenda | Aanvullende details over de opvolging, zoals een agenda, een beschrijving, bestanden, afbeeldingen en links. Opties voor opmaak met opmaakopties voor rijke tekst zijn beschikbaar. |

## Maak verzoek

| Instelling | Beschrijving |
|---|---|
| Titel | Een beschrijvende naam voor het verzoek. |
| Type verzoek | Richt zich op een reeks attributen die nodig zijn voor een specifiek proces. Beïnvloedt de beschikbare statussen en prioriteiten. |
| Status | Geeft de fase van het verzoekbeheer aan (open of gesloten). |
| Categorie | Een set regels die bepalen hoe verzoeken worden verwerkt. |
| Prioriteit | Geeft de belangrijkheid van het verzoek weer. |
| Eigenaar | Aan wie het verzoek moet worden toegewezen. |
| Bericht | De inhoud van het verzoek. Opties voor opmaak met opmaakopties voor rijke tekst en sjabloonvariabelen voor persoon en het bedrijf van de contactpersoon zijn beschikbaar. |

## Maak verkoop

| Instelling | Beschrijving |
|---|---|
| Titel | Een beschrijvende naam van de verkoop. Details komen in de beschrijving. |
| Verkoop type | Een benoemde set informatie over het verkoopproces. Beïnvloedt standaard verkoopfase en geschatte verkoopdatum. Sommige verkoopsoorten zijn gekoppeld aan een [verkoopgids][14]. |
| Fase | De huidige fase van de verkoop (open, verloren, verkocht). |
| Bedrag | Verwacht bedrag voor de pijplijn. |
| Omschrijving | Een meer gedetailleerde beschrijving van de verkoop. |
| Project | Een project gekoppeld aan de verkoop. |
| Datum | De geschatte verkoopdatum. "Geschat door verkoop type" of "Na X dagen/werkdagen/weken". |
| Eigenaar | De persoon die verantwoordelijk is voor de verkoop. De "onze persoon" of "onze service persoon" van de deelnemer, of een specifiek genoemde medewerker. |

## Verlaat de flow

De flow-control stappen **split** en **wacht op actie** (en ook Verstuur SMS) hebben een **Verlaat de flow** optie om deelnemers die niet aan een voorwaarde voldoen uit de flow te halen. Indien geselecteerd, kan de afgevallen persoon worden verplaatst naar een andere flow en/of worden toegevoegd aan een selectie.

| Instelling | Beschrijving |
|---|---|
| Voeg deelnemer toe aan een andere flow na vertrek | Het afgevallen persoon wordt **voorgesteld** als deelnemer voor de opgegeven flow. Filters bepalen of ze die flow starten of niet. |
| Voeg deelnemer toe aan statische selectie na vertrek | Het afgevallen persoon wordt lid van de opgegeven selectie. Je kunt een nieuwe selectie maken vanuit de stapinstellingen. |

## Afronden

Deelnemers die de afrondstap bereiken, hebben het einde van de flow bereikt. De deelnemer kan de flow hebben voltooid met status = voltooid of voltooid met succes. Er worden geen verdere acties uitgevoerd op een deelnemer in deze flow bij het bereiken van de stap.

| Instelling | Beschrijving |
|---|-|
| Voeg toe aan een andere flow wanneer een succes criterium is behaald | Voltooid met succes |
| Voeg toe aan een andere flow wanneer er geen succes criterium is behaald | Voltooid |

## Verstuur e-mail

| Instelling | Beschrijving |
|---|---|
| Maak nieuwe e-mail voor deze stap | Opent de mailing wizard. |
| Selecteer bestaande e-mail voor deze stap | Zie [Content toevoegen][1]. |
| Onderwerp | Tekst voor het onderwerp van de e-mail. Je kunt het onderwerp personaliseren met contactvariabelen (hetzelfde als samenvoegtags binnen de mailing-editor). |
| Bijlage | Maximaal 25 MB totaal. |

## Verstuur SMS

| Instelling | Beschrijving |
|---|---|
| Van | Standaard ingesteld op de flowinstelling "SMS-verzender". |
| Tekst | Voer de SMS-tekst in. Je kunt het bericht personaliseren met contactvariabelen (hetzelfde als samenvoegtags binnen de mailing-editor). |
| Verlaat de flow indien geen mobiel nummer is geregistreerd | Wat moet er gebeuren als het persoon de SMS niet kan ontvangen? Indien waar, kun je ze toevoegen aan een andere flow of aan een statische selectie na vertrek. |

## Split

| Instelling | Beschrijving |
|---|---|
| Titel | Een kort beschrijvend label. |
| Splitsen op basis van | De gegevens / gedrag om op te differentiëren. |
| Takkennaam | Een beschrijvende naam van de tak, waarbij wordt aangegeven welke deelnemers welke tak volgen. |
| Iedereen anders | De tak voor het behandelen van deelnemers die niet voldoen aan de voorwaarden van een van de andere takken. |
| Verlaat de flow | Bepaalt of deelnemers die in de tak voor "iedereen anders" belanden, de flow moeten verlaten. Indien waar, kun je ze toevoegen aan een andere flow of aan een statische selectie na vertrek. Indien onwaar, kun je meer stappen toevoegen aan deze tak. |

De overige velden voor het specificeren van takinstellingen zijn afhankelijk van waarop de split is gebaseerd.

## Trigger

| Instelling | Beschrijving |
|---|---|
| Een persoon kan deze flow slechts één keer starten | Of een persoon opnieuw kan worden ingeschreven in deze flow. |
| Filter | Een set criteria die moeten worden voldaan voor een voorgesteld persoon om te worden toegelaten tot de flow. Slechts eenmaal gecontroleerd. |
| Uitsluitingslijst | Een statische selectie van personen die niet aan de flow worden toegevoegd, of die de flow verlaten als ze al deelnemen. |

## Update persoon

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
| Verlaat de flow indien geen acties binnen max wachttijd | Deelnemers die niet reageren verlaten de flow met de status "afgevallen". Indien waar, kun je ze toevoegen aan een andere flow of aan een statische selectie na vertrek. |

## Gerelateerde inhoud

* [Leer meer over activiteiten][11]

<!-- Referenced links -->
[1]: content.md
[10]: ../../../learn/basics/bulk-update.md
[11]: ../../../learn/basics/activity.md
[14]: ../../../sale/learn/sales-guide/index.md

<!-- Referenced images -->
[img4]: ../../../../../common/icons/dropdown-icon.png

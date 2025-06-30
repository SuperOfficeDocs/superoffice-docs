---
uid: help-nl-automation-script-tracing
title: Traceren
description: Traceren
author: Bergfrid Dias
date: 12.20.2023
version: 10.2.11
keywords: CRMScript, traceren, fout opsporen
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Traceren

De traceringsfunctie legt alle details van de uitvoering van een script of macro vast en slaat deze op in een logboek. Bij elk gebruik van het script of de macro wordt de uitvoering vastgelegd.

U kunt vervolgens de uitvoering van het script onderzoeken door de vastgelegde scriptuitvoering terug en vooruit te spoelen. U ontvangt een complete lijst met alle vastgelegde uitvoeringen van het script en met vermelding van degenen die het script hebben uitgevoerd. Op deze manier kunt u zien hoe uw scripts zich hebben gedragen en kunt u alle variabelen op elk willekeurig moment bekijken.

## Traceringen weergeven

Het tabblad **Traceren** bevat een lijst met alle traceringen. Klik op een tracering in de lijst om de details weer te geven.

## Script traceren

1. Doe een van de volgende:

    * Open een script of macro in **Foutopsporing** en klik op  **Script traceren**.
    * Open een script of macro in het tabblad **Macro's en scripts** en klik op **Script traceren**.

2. Voer een **beschrijving** van de trace in, om het gemakkelijker te maken te identificeren.
3. Optioneel, stel **Gebruikersfilter** in als je een gebruikersspecifieke trace wilt.
4. Optioneel, specificeer meldings- en opslageigenschappen. Zie [lijst van velden](#fields) hieronder.
5. Selecteer **Ingeschakeld** om de trace te activeren.
6. Klik op **OK** wanneer je klaar bent.

## Schakel alle ingeschakelde traces in/uit

1. Ga naar **CRMScript** > **Foutopsporingssessies**.
2. Klik op **Traceringsscripts starten** om de scripts in de lijst te traceren.
    Klik op **Traceringsscripts stoppen** om het traceren te pauzeren.

## Tracering bewerken

1. Klik op een tracering in de **Sporing** lijst om het te openen.
2. Klik op **Tracering bewerken**.
3. Werk de velden bij zoals nodig.
4. Klik op **OK** wanneer u klaar bent.

![Trace CRMScript -screenshot][img4]

### <a id="fields"></a>Veld

| Veld | Beschrijving |
|---|---|
| Beschrijving | Een uitleg van de tracering, om het gemakkelijker te maken te identificeren. |
| Gebruikersfilter | Beperkt het traceren tot een specifieke gebruiker. |
| Traceeroplossing | De metingsfrequentie in voor het traceringslogboek. 1 - traceer elke uitvoering van het script; 5 - traceer elke vijfde uitvoering; enzovoort. |
| Tracering bewaren | Hoe lang een tracering moet worden bewaard voordat het wordt verwijderd. |
| Ingeschakeld | Activeert de tracering. |
| Melden | Of meldingsmails moeten worden verzonden. |
| Maximumaantal meldingen | Beperkt aantal verzonden e-mails. |
| E-mailmelding | Waar meldingen naartoe moeten worden gestuurd. |
| Alleen opslaan als er een niet-behandelde uitzondering is | Beperkt traceren tot uitzonderingen. |

<!-- Referenced links -->

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/automation/trace.png

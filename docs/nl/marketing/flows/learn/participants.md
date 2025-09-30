---
uid: help-nl-flow-participants
title: Deelnemers
description: Een volledig overzicht van alle deelnemers binnen de flow.
keywords: Marketing, flow, deelnemer, inschrijvin, actief
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Deelnemers

## Stappen

Om de lijst met deelnemers voor een specifieke flow te bekijken:

1. Ga naar **Marketing** > **Flows**.
1. Klik om een flow te selecteren.
1. Selecteer het tabblad **Deelnemers**.
1. Kies optioneel hoe je de lijst wilt groeperen.

![Deelnemerslijst van de flow -screenshot][img1]

Gebruik het tandwielpictogram (<i class="ph ph-gear" aria-hidden="true"></i>) in de kop van de lijst om de kolommen aan te passen.

![Deelnemerslijst van de flow, kolommen aanpassen -screenshot][img2]

## Deelnemerstatus

| Status | Beschrijving |
|---|---|
| Actief | Deelnemer is actief in de flow​. |
| Voltooid | Deelnemer heeft alle stappen in de flow voltooid​. |
| Voltooid met succes | Deelnemer heeft de flow voltooid en het succescriterium vervuld. Opgenomen in het succespercentage van de flow​. |
| Dropout | Deelnemer is uitgevallen, altijd met een gespecificeerde reden voor uitval. |
| Geannuleerd | Deelnemer zal de flow niet voltooien omdat een beheerder de flow heeft beëindigd. |

## <a id="logic"></a>Inschrijving en voortgang door de flow

Voor elke stap evalueert SuperOffice CRM opnieuw of de deelnemer kan doorgaan.

Voor alle soorten stappen:

1. Is de status van de deelnemer *Actief*?
1. Voldoet de deelnemer aan het gedefinieerde succescriterium?
1. Is het persoon gemarkeerd als voormalig medewerker?
1. Is het persoon toegevoegd aan de uitsluitingslijst?

Extra voor e-mailstap:

1. Is hun toestemming geldig?​
1. Is het persoon geabonneerd op het type flowabonnement?
1. Heeft het persoon een geregistreerd e-mailadres?​
1. Is het e-mailadres al actief binnen de flow?​
1. Is het e-mailadres gedeblokkeerd?​

Extra voor SMS-stap:

1. Heeft het persoon een geregistreerd mobiel telefoonnummer voor SMS?

### Hoe beïnvloeden succescriteria de inschrijving?

* Contacten die al aan de succescriteria voldoen, worden nog steeds aan de flow toegevoegd en tellen als successen. Hun voortgang door de flowstappen hangt af van de configuratie.

* Contacten die de succescriteria behalen nadat ze een flow hebben voltooid, worden niet opgenomen in het succespercentage van de flow, omdat dit na hun actieve deelname plaatsvond.

### Welke tak volgt een deelnemer?

In een splitsing volgen deelnemers de eerste (meest linkse) tak waar ze aan de gespecificeerde voorwaarden voldoen.

## Taken

* Toevoegen aan selectie: Voegt de deelnemer toe aan een statische selectie.
* Toevoegen aan flow: Geeft aan dat dit persoon wordt voorgesteld voor inschrijving in een andere flow.
* Verwijderen uit flow: Verwijdert alle registraties van de deelname van het persoon aan de huidige flow.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-participants.png
[img2]: ../../../../media/loc/en/marketing/flow-participant-columns.png

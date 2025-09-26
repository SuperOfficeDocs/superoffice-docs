---
uid: help-nl-flow-run-pause-end
title: Flow uitvoeren, pauzeren en beëindigen
description: Hoe u een SuperOffice Marketing-automatiseringsflow start, pauzeert, hervat, beëindigt en verwijdert.
keywords: Marketing, flow, flow uitvoeren, flow pauzeren, flow beëindigen, wordt uitgevoerd, gepauzeerd
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

# Flow uitvoeren, pauzeren en beëindigen

## <a id="status"></a>Flow status

* **Wordt niet uitgevoerd:** Vertegenwoordigt een nieuwe flow die nog niet is gestart (of een beëindigde flow). Triggers zijn niet geactiveerd.

* **Wordt uitgevoerd:** Geen wijzigingen zijn toegestaan terwijl de flow bezig is. Geautomatiseerde triggers zijn geactiveerd en deelnemers worden aan de flow toegevoegd.

* **Gepauzeerd:** Triggers blijven geactiveerd. Deelnemers worden aan de flow toegevoegd, maar wachten op beweging naar de eerste stap. Bestaande deelnemers blijven op hun huidige stap wanneer de flow is gepauzeerd. Deze status wordt gebruikt bij het maken van wijzigingen of verbeteringen aan een flow.

![Marketingflows met verschillende statussen en statistieken -screenshot][img1]

## Starten van een flow voor de eerste keer

Om een nieuwe flow te starten:

1. Ga naar **Marketing** > **Flows**.
1. Selecteer de flow die je wilt starten.
1. Schakel de schakelaar in de header naar **AAN**. De status verandert naar **Wordt uitgevoerd**.

Hierdoor worden de triggers van de flow geactiveerd. Nieuwe deelnemers worden toegevoegd aan de deelnemerslijst van de flow op basis van deze triggers. Deelnemers zullen door de flow voortgang boeken, acties zullen worden uitgevoerd totdat ze voldoen aan de succescriteria van de flow, de laatste stap bereiken, of uitvallen.

## Flow pauzeren

Om een actieve flow tijdelijk te stoppen:

1. Open de flow die je wilt pauzeren.
1. Schakel de schakelaar in de header naar **UIT**. De status verandert naar **Gepauzeerd**.

* Deze actie bevriest de huidige status voor alle deelnemers, die blijven op hun huidige stap.
* **Triggers blijven actief**, waardoor de lijst met deelnemers blijft groeien. Nieuwe deelnemers schrijven zich in maar worden in de wachtrij geplaatst.
* De knop **Bewerken** is beschikbaar, waardoor flowbeheerders updates aan de flow kunnen maken (met enkele beperkingen).

## Hervatten van een gepauzeerde flow (gepauzeerd > wordt uitgevoerd)

Om een gepauzeerde flow te hervatten, schakel de schakelaar naar **AAN** op het scherm **Flow bekijken**.

* Alle deelnemers zullen verdergaan vanaf de stap waar ze waren toen de flow werd gepauzeerd.
* Deelnemers die zich hebben ingeschreven en in de wachtrij stonden tijdens de pauze, zullen naar de eerste stap worden verplaatst.
* Eventuele wijzigingen die zijn aangebracht aan de flow zijn van toepassing op een deelnemer als ze de relevante stap nog niet hebben gepasseerd.

## Flow beëindigen

Om de flow te beëindigen:

1. Open de flow.
1. Selecteer **Taak** > **Flow beëindigen**.

* De status van de flow verandert naar **Wordt niet uitgevoerd**.
* Alle triggers voor deze flow worden gedeactiveerd en inschrijving stopt. Er worden geen nieuwe deelnemers aan de flow toegevoegd.
* Actieve deelnemers krijgen de status = *Geannuleerd*. Ze zullen de flow niet voltooien.

> [!CAUTION]
> Deze taak moet alleen worden gebruikt voor flows die niet langer relevant zijn. Het beëindigen van een flow is niet bedoeld voor kleine aanpassingen - gebruik in plaats daarvan pauze. **Geannuleerde deelnemers zullen de flow niet voortzetten als je besluit deze opnieuw te starten.**

Als de flow opnieuw wordt gestart na beëindiging, zullen alleen nieuwe deelnemers door de flow gaan, oude deelnemers blijven geannuleerd.

## <a id="delete"></a>Flow verwijderen

1. Pauzeer de flow. De status verandert naar **Gepauzeerd**.
1. Beëindig de flow. De status verandert naar **Wordt niet uitgevoerd**.
1. Klik op <i class="ph ph-dots-three-circle-vertical" aria-label="Taakmenu"></i> en selecteer **Flow verwijderen**.
1. Bevestig de actie.

Deze optie is beschikbaar zowel in het scherm **Flow bekijken** als in het overzicht van alle flows.

## Probleemoplossing

### Kan de flow niet starten

Alle vereiste instellingen moeten geldig zijn voordat de flow kan worden gestart. Bijvoorbeeld, een flow met een e-mailstap kan niet worden gestart als e-mailinstellingen zoals afzenderadres of antwoordadres ontbreken. Zoek naar het waarschuwingspictogram - de tooltip beschrijft het probleem.

### Kan de flow niet verwijderen

Je kunt geen actieve flow verwijderen. Pauzeer eerst de flow. Beëindig vervolgens de flow, zodat de status verandert naar **Wordt niet uitgevoerd**. Daarna klik je op <i class="ph ph-dots-three-circle-vertical" aria-label="Taakmenu"></i> en selecteer je **Flow verwijderen**.

## Gerelateerde inhoud

* [Flow bijwerken][1]

<!-- Referenced links -->
[1]: update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-status.png

---
uid: help-nl-flow-update
title: Flow bewerken
description: Flow bewerken
keywords: Marketing, flow
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

# Flow bewerken

Het is handig om te beginnen met een eenvoudige flow en deze uit te breiden na het monitoren van de prestaties. Mogelijk wilt u ook een flow bijwerken tijdens het ontwerpen ervan.

Om wijzigingen aan te brengen:

1. [Pauzeer de flow][1].
2. Klik op **Bewerken**.
3. Maak de benodigde wijzigingen.
4. Klik op **Opslaan**.
5. Start de flow opnieuw.

> [!NOTE]
> De wijzigingen die u aanbrengt bij een stap hebben alleen invloed op nieuwe deelnemers en actieve deelnemers die die stap nog niet hebben bereikt.

## Flow-instellingen, succescriteria en/of trigger bewerken

Net zoals bij het [maken van een flow][2].

## Stap toevoegen

Net zoals bij het [maken van een flow][3].

## Stapinstellingen bewerken

1. Klik op een stap in het diagram om de stapinstellingen te openen.
2. Afhankelijk van het type stap kunt u:

    * Eigenschappen van nieuwe activiteiten bijwerken.
    * E-mailinhoud en/of bijlagen toevoegen.
    * Wachttijd verlengen of verkorten.
    * Acties toevoegen of verwijderen.
    * Een statische selectie, project of flow selecteren om de deelnemer naar over te brengen.
    * De volgorde van takken wijzigen, takken hernoemen, een tak toevoegen.
    * Voorwaarden in een split bijwerken.

3. Klik op **Opslaan**.

Handige bronnen:

* [Lijst van beschikbare instellingen voor elke stap][6].
* [Flow opsplitsen][5]
* [Wachttijd en wacht op actie][4]
* [Inhoud toevoegen][7]
* [Activiteit maken][9]
* [Persoon bijwerken][8]
* [Selectie maken][11]
* [Formulier maken][10]

## Stap verplaatsen, dupliceren of verwijderen

* **Verplaatsen:** Klik op een stap en sleep deze naar een nieuwe locatie.
* **Dupliceren:** Wijs naar een stap en klik op het **Dupliceren** pictogram (<i class="ph ph-copy" aria-hidden="true"></i>). Hiermee wordt een nieuwe stap gemaakt op basis van de huidige en toegevoegd als volgende stap. Gebruik deze optie om een stap opnieuw te gebruiken in dezelfde flow.
* **Verwijderen:** Wijs naar een stap en klik op het rode X-pictogram. Hiermee wordt de stap uit de flow verwijderd (maar de inhoud ervan niet).

> [!NOTE]
> Wanneer u een e-mailstap dupliceert, maakt de Flow-editor ook een **kopie van de e-mailinhoud**. U kunt deze nieuwe flowinhoud onafhankelijk bewerken van de e-mailinhoud in de stap die is gedupliceerd.
>
> Wanneer u een e-mailstap verwijdert, wordt alleen de stap uit de flow verwijderd. De e-mailinhoud wordt niet verwijderd.

## Flow verwijderen

[Zie *Flow uitvoeren, pauzeren en beëindigen*][1].

## Problemen oplossen

Er zijn enkele beperkingen wanneer u een flow bewerkt nadat deze is gestart om actieve deelnemers te beschermen (met andere woorden: om te voorkomen dat u een rommeltje maakt).

### Kan flow niet bewerken

* U kunt geen actieve flow bewerken. Pauzeer de flow en probeer opnieuw.
* Als de knop **Bewerken** nog steeds grijs is, heeft u niet de vereiste functionele rechten als 'Flow-administrator'.

### Kan stap niet verplaatsen of verwijderen

* U kunt een **Wachttijd**, **Wacht op actie** of **Opsplitsen** stap niet verplaatsen of verwijderen als er actieve deelnemers in de stap zijn.

Ga naar het tabblad **Deelnemers** en controleer de kolom **Huidige stap** om een geschikt moment te vinden om te pauzeren en de stappen in de flowcontrol te bijwerken.

### Kan tak niet verwijderen

* U kunt de tak 'Alle anderen' niet verwijderen.
* U kunt geen tak verwijderen als er actieve deelnemers op zitten.

Ga naar het tabblad **Flow** om te controleren of er iemand op de tak zit. Indien ja, ga dan naar het tabblad **Deelnemers** voor details. Hoe u deze deelnemers afhandelt, is aan u. Enkele opties om te overwegen:

* Voeg deelnemers toe aan een statische selectie voor later opvolgen.
* Voeg deelnemers toe aan de uitsluitingslijst van de flow.
* Verwijder deelnemers uit de flow met behulp van het **Taak** menu.
* Wacht tot de tak "leegloopt". Mogelijk moet u de voorwaarde van de tak bijwerken om te voorkomen dat nieuwe deelnemers binnenkomen.

<!-- Referenced links -->
[1]: run-pause-end.md
[2]: create.md
[3]: create.md#add-step
[4]: create.md#wait
[5]: split.md
[6]: step-settings.md
[7]: content.md
[8]: define-flow-actions.md#update
[9]: define-flow-actions.md#create
[10]: ../../forms/learn/create.md
[11]: ../../../search-options/selection/learn/create.md

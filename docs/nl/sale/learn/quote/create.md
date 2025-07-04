---
uid: help-nl-quote-create
title: Een offerte maken
description: In deze gids leert u hoe u een offerte kunt maken, een product in de offerte kunt toevoegen en bewerken en hoe u een offerte kunt verzenden.
keywords: een offerte maken, offerte kopiëren, product toevoegen, dialoogvenster Product toevoegen/bewerken, dialoogvenster Offerte bewerken, offerte
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/quote/learn/add-product
  - /nl/quote/learn/copy
  - /nl/quote/learn/create
  - /nl/quote/learn/screen/edit-quote-dialog
---

# Een offerte maken

In SuperOffice CRM kunt u een offerte vanaf nul maken of een bestaande offerte kopiëren vanuit een andere verkoop. Nadat u de offerte hebt gemaakt, kunt u producten toevoegen, prijzen aanpassen en het voorstel voorbereiden voor de klant.

## Een nieuwe offerte maken

1. [Maak een nieuwe verkoop][1] of open een bestaande verkoop (één die niet is gemarkeerd als Verkocht of Verloren).

1. Ga naar het sectietabblad **Offerte**.

1. Klik op **Een nieuwe offerte maken**.

1. Het dialoogvenster **Offerte bewerken** wordt geopend. Vanaf hier kunt u [producten toevoegen](#add-products) en de details van de offerte bewerken.

![Dialoogvenster Offerte bewerken -screenshot][img1]

## <a id="copy"></a>Een offerte kopiëren vanuit een andere verkoop

Om tijd te besparen kunt u een bestaande offerte hergebruiken vanuit een andere verkoop die dezelfde valuta gebruikt.

1. Open een verkoop zonder offerte en ga naar het sectietabblad **Offerte**.

1. Klik op **Offerte kopiëren vanuit andere verkoop**.

1. In het dialoogvenster **Nieuwe offerte maken door een bestaande offerte te kopiëren**:

    * Selecteer een verkoop uit de lijst (moet een offerte bevatten met dezelfde valuta).
    * Of, begin te typen om te zoeken op verkoopnaam.

1. Klik op **OK**. De offerte en alle alternatieven worden gekopieerd naar de huidige verkoop en weergegeven in het sectietabblad **Offerte** met de status **Concept**.

1. Klik op **Openen** om de offerte te bekijken of te bewerken in het dialoogvenster **Offerte bewerken**.

## <a id="add-products"></a>Producten aan de offerte toevoegen

### Eén product toevoegen

1. Ga in het tabblad **Producten** van de offerte naar **Toevoegen**.
    Het dialoogvenster **Product toevoegen/bewerken** wordt geopend.

1. Begin te typen in het veld **Product zoeken** om een product te vinden op naam of code.

1. Selecteer een product uit de lijst.

    De productvelden worden automatisch ingevuld op basis van de geselecteerde prijslijst.

1. Voer de **aantallen** in (verplicht).

1. Optioneel kunt u prijzen aanpassen via:

    * **Kortingspercentage**
    * **Kortingbedrag**
    * **Totaalprijs**

    Houd de muisaanwijzer boven een kortingsveld om eventuele systeemkortingen weer te geven (zoals volumekortingen die automatisch worden toegepast).

1. Ga naar het tabblad **Details** om:

    * **Winst** te bekijken of aan te passen (percentage of bedrag)
    * Optioneel **btw** in te stellen

    > [!NOTE]
    > Kortingen, totaalprijs en winst zijn met elkaar verbonden. Wanneer u één veld wijzigt, worden de andere automatisch bijgewerkt. Het laatst bewerkte veld wordt gemarkeerd.
    >
    > Als u een korting invoert die niet is toegestaan door het systeem, wordt er een waarschuwing of ander bericht weergegeven.

1. Optioneel: Bekijk productinformatie in de tabbladen **Beschrijving** of **Afbeelding**.

1. Klik op **Opslaan** om het product toe te voegen aan de offerte, of klik op **Opslaan + nieuw** om direct nog een product toe te voegen.

![Dialoogvenster Product toevoegen/bewerken -screenshot][img2]

### Meerdere producten toevoegen

Om meerdere producten tegelijk toe te voegen, moet u de geavanceerde zoekfunctie gebruiken.

1. Klik in het tabblad **Producten** op **Toevoegen**.

1. Klik op <i class="ph ph-magnifying-glass" aria-label="Zoekpictogram"></i> om het dialoogvenster **Producten zoeken** te openen.

1. Gebruik één of meer criteria om de lijst te verfijnen. Klik op **Criterium toevoegen** om extra filters toe te voegen.

    De zoekopdracht omvat alle actieve prijslijsten in de valuta van de verkoop.

1. Selecteer de producten die u wilt toevoegen: gebruik **Ctrl+klik** (Windows) of **Cmd+klik** (Mac) om meerdere producten te selecteren.

1. Klik op **OK**. Alle geselecteerde producten worden toegevoegd aan de offerte.

    U keert terug naar het dialoogvenster **Offerte bewerken**.

1. Om de aantallen in te stellen (en optioneel korting, prijs of winst bij te werken), dubbelklik op elke productregel.

## Betaal- en leveringsopties instellen

Voordat u de offerte verstuurt of het offertedocument genereert, gaat u naar het tabblad **Details** van de offerte.

Hier kunt u instellen:

* **Betalingsvoorwaarden** en **betalingstype**
* **Leveringsvoorwaarden** en **leveringstype**
* **Factuuradres** en **bezorgadres**

Deze velden worden opgenomen in het offertedocument en gebruikt bij het plaatsen van de order.

## Problemen oplossen

### Waarom wordt het dialoogvenster "ERP-verbinding selecteren" weergegeven?

Dit dialoogvenster verschijnt als:

* Er geen prijslijst bestaat voor de geselecteerde valuta.
* Er meerdere ERP-verbindingen beschikbaar zijn.

**Oplossing:** Kies een andere valuta of zorg ervoor dat er een geldige prijslijst bestaat. Selecteer daarna de juiste ERP-verbinding.

> [!NOTE]
> Om het selecteren van valuta in een verkoop mogelijk te maken, gaat u naar **Instellingen en onderhoud** > **Voorkeuren** en schakelt u **Gebruik van valuta** in.

### Waarom kan ik de verkoop waarvan ik wil kopiëren niet vinden?

Bij het kopiëren van een offerte toont de lijst **Verkopen** alleen verkopen die:

* Een bestaande offerte bevatten.
* Dezelfde valuta gebruiken als de huidige verkoop.

**Oplossing:**

* Controleer of de verkoop waaruit u wilt kopiëren een offerte bevat.
* Controleer of beide verkopen dezelfde valuta gebruiken.
* Indien nodig, wijzig de valuta van de huidige verkoop zodat deze overeenkomt.

Als de lijst nog steeds leeg is, zijn er geen overeenkomende verkopen beschikbaar om te kopiëren.

### Waarom is de knop OK uitgeschakeld bij het kopiëren?

U hebt mogelijk geen toegang tot de ERP-verbinding die wordt gebruikt in de offerte.
Plaats de muisaanwijzer op de knop **OK** om te zien welke verbinding beperkt is.

### <a id="warning"></a>Waarom zie ik waarschuwingen of fouten?

Wanneer u producten toevoegt of bewerkt in een offerte, kan SuperOffice een bericht weergeven als iets buiten de toegestane limieten valt.

Veelvoorkomende oorzaken zijn:

* Producten zijn niet beschikbaar in het assortiment
* Inactieve prijslijsten
* De korting is te hoog
* De winst is te laag
* De prijs is te laag of nul

Het systeem toont een van de volgende pictogrammen:

| Pictogram | Berichttype | Beschrijving | Wat te doen |
|:-:|---|---|---|
| <i class="ph ph-info" aria-label="Info-pictogram"></i> | Info | Er wordt een bericht weergegeven voor de offerte, maar deze kan wel worden verzonden. | Optioneel: Lees en los op indien nodig |
| <i class="ph ph-warning" aria-label="Waarschuwing-pictogram"></i> | Waarschuwing | De offerte moet worden goedgekeurd voordat deze kan worden verzonden. | [Goedkeuring is vereist][7] |
| <i class="ph ph-circle-wavy-warning" aria-label="Fout-pictogram"></i> | Fout | De offerte kan niet worden verzonden vanwege een fout. | Corrigeer de fout voordat u verzendt |

Deze berichten kunnen worden weergegeven in:

* Het dialoogvenster **Product toevoegen/bewerken**
* Het dialoogvenster **Offerte bewerken**
* Op productregels in het sectietabblad **Offerte**
* Op het tabblad **Producten** (en alternatieven) in de offerte
* Wanneer u probeert een offerte te verzenden of een order te plaatsen

## Gerelateerde inhoud

* [Alternatieven toevoegen aan een offerte][5]
* [Een offertedocument maken][6]
* [Een offerte verzenden][7]
* [Een order maken][8]
* [Uw producten en prijzen instellen in Instellingen en onderhoud][9]

<!-- Referenced links -->
[1]: ../create.md
[5]: add-alternative.md
[6]: create-quote-document.md
[7]: send.md
[8]: place-order.md
[9]: ../../admin/quote/price-list-and-products.md

<!-- Refererede billeder -->
[img1]: ../../../../media/loc/en/sale/edit-quote-dialog-empty.png
[img2]: ../../../../media/loc/en/sale/add-edit-product-dialog.png

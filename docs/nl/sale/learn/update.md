---
uid: help-nl-sale-update
title: Een verkoop bijwerken
description: Hoe u bestaande verkoopinformatie kunt bijwerken, de fase kunt wijzigen (inclusief markeren als vastgelopen, verkocht of verloren), of een verkoop kunt verwijderen als deze niet langer relevant is.
keywords: verkoop bijwerken, verkoop bewerken, verkoop verwijderen, vastgelopen, verloren, verkocht, verkoop
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from: /nl/sale/learn/delete
---

# Een verkoop bijwerken

U kunt bestaande verkoopinformatie bijwerken, de fase wijzigen (inclusief markeren als vastgelopen, verkocht of verloren), of een verkoop verwijderen als deze niet langer relevant is.

## Een verkoop bewerken

1. Open het scherm **Verkoop** voor de verkoop die u wilt bijwerken. Zie [Het scherm Zoeken gebruiken][5].

1. Klik op <i class="ph ph-pencil-simple" aria-hidden="true"></i> in de rechterbovenhoek van de verkoopkaart om de bewerkingsmodus te openen.

1. Breng de gewenste wijzigingen aan. U kunt tussen tabbladen schakelen zonder de bewerkingsmodus te verlaten.

    * **Velden Totale kosten, Winst en Percentage:** Het wijzigen van een veld zal automatisch de andere velden bijwerken om consistentie te garanderen.

    * **De fase wijzigen:** Het bijwerken van de fase past automatisch het veld **Waarschijnlijkheid** aan. U kunt deze waarde handmatig overschrijven indien nodig. Als het verkooptype is gekoppeld aan een [verkoopgids][1], worden de vorige fasen in de gids als voltooid gemarkeerd met een vinkje.

    > [!CAUTION]
    > Het wijzigen van **verkooptypen** die zijn gekoppeld aan een verkoopgids, zal de gids verwijderen. Activiteiten en documenten blijven beschikbaar in het sectietabblad **Activiteiten** en worden opnieuw gekoppeld als u terugkeert naar het oorspronkelijke type.

1. Klik op **Opslaan** om de wijzigingen toe te passen of op **Annuleren** om deze te negeren. Beide acties verlaten de bewerkingsmodus.

    > [!NOTE]
    > Als de knop **Opslaan** is uitgegrijsd, controleer dan of alle verplichte velden zijn ingevuld.

## <a id="stalled"></a>Een verkoop markeren als vastgelopen

Gebruik deze status wanneer een klant bijvoorbeeld de aankoopbeslissing uitstelt tot een latere datum, zoals het volgende jaar.

1. Vink het selectievakje **Vastgelopen** aan in het scherm **Verkoop**.

1. Vul de volgende aanvullende velden in:
    * **Datum heropening:** De datum waarop de verkoop opnieuw beoordeeld moet worden.
    * **Reden (vastgelopen):** Verklaring waarom de verkoop niet verder kan.

    ![Vastgelopen verkoop -screenshot][img1]

1. Klik op **Opslaan**. Het dialoogvenster **Vervolgactiviteit** wordt geopend, zodat u een toekomstige afspraak of oproep kunt plannen om de vastgelopen verkoop op te volgen.

> [!NOTE]
> De velden **Datum heropening** en **Reden** vervangen het veld **Volgende activiteit**.

## Een verkoop markeren als verkocht

1. Selecteer **Verkocht** in het dropdownmenu **Fase**.

1. Werk het veld **Datum** bij (standaard ingesteld op vandaag) naar de daadwerkelijke afsluitdatum, indien anders.

1. Selecteer de **Reden** waarom de verkoop is gelukt.

    ![Verkochte verkoop -screenshot][img2]

1. Pas het **Bedrag** van de verkoop aan en werk de financiële details bij op het tabblad **Details**.

1. Klik op **Opslaan**.

## Een verkoop markeren als verloren

1. Selecteer **Verloren** in het dropdownmenu **Fase**.

1. Kies de **Reden** waarom de verkoop is mislukt.

    ![Verloren verkoop -screenshot][img3]

1. Werk andere velden bij indien nodig.

1. Klik op **Opslaan**.

Als de verkoop de status **Verkocht** of **Verloren** heeft, kunt u het selectievakje **Voltooid** aanvinken.

## <a id="delete"></a>Een verkoop verwijderen

1. Open het scherm **Verkoop** voor de verkoop die u wilt verwijderen.

1. Klik op de knop **Taak** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) in de rechterbovenhoek van de verkoopkaart en selecteer **Verwijderen**.

1. Controleer in het dialoogvenster **Verkoop verwijderen** de verkoopdetails om er zeker van te zijn dat u de juiste verkoop verwijdert. **Dit kan niet ongedaan worden gemaakt.**

    > [!NOTE]
    > Als de optie **Verwijderen** niet beschikbaar is, hebt u mogelijk onvoldoende rechten om de verkoop te verwijderen. U kunt geen verkopen verwijderen die niet aan u toebehoren, tenzij u de juiste machtigingen hebt.

1. Klik op **Ja** om de verwijdering te bevestigen.

## Gerelateerde inhoud

* [Een verkoop registreren][2]
* [Verkoopgidsen][1]
* [Uitleg over de velden][3]

<!-- Referenced links -->
[1]: sales-guides.md
[2]: create.md
[3]: create.md#fields
[5]: ../../search-options/learn/find-screen.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/stalled-sale.png
[img2]: ../../../media/loc/en/sale/won-sale.png
[img3]: ../../../media/loc/en/sale/lost-sale.png

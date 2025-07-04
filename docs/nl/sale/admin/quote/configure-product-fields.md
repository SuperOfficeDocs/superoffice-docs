---
uid: help-nl-product-fields-configure
title: Velden configureren in het dialoogvenster Product toevoegen/bewerken
description: Leer hoe u kunt bepalen welke velden worden weergegeven in het dialoogvenster Product toevoegen/bewerken en hoe ze zich gedragen.
keywords: Dialoog Product configureren, Dialoog Product toevoegen/bewerken, Product configureren, Productdialoog, Productveld, Product, Offerte
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/quote/learn/admin/product/configure
index: true
---

# Velden configureren in het dialoogvenster Product toevoegen/bewerken

Gebruik het dialoogvenster **Product configureren** om te bepalen welke velden worden weergegeven wanneer gebruikers een product toevoegen of bewerken in een offerte. U kunt velden tonen of verbergen, labels wijzigen, knopinfo toevoegen en velden bewerkbaar en/of verplicht maken.

Deze instellingen zijn van toepassing op alle ERP-verbindingen van de Quote Connector en beïnvloeden twee dialoogvensters:

* **Dialoogvenster Product toevoegen/bewerken (gebruiker):** Wordt weergegeven wanneer gebruikers een product toevoegen aan een offertelijn.
* **Dialoogvenster Product toevoegen/bewerken (beheerder):** Wordt gebruikt op het tabblad **SuperOffice-producten** wanneer beheerders producten toevoegen aan een prijslijst.

## Stappen

1. Ga in Instellingen en onderhoud naar <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offerte/Synchroniseren**.

1. Open het tabblad **Instellingen**.

1. Klik op **Product configureren**.

    ![Dialoogvenster Product configureren -screenshot][img1]

1. Selecteer in het dialoogvenster de taal die u wilt configureren. U kunt labels en knopinfo lokaliseren per taal.

1. Voor elk veld in de lijst:

    * **Veld weergeven:** Bepaalt de zichtbaarheid in het dialoogvenster **Product toevoegen/bewerken** voor offertes. Velden zijn altijd zichtbaar in Instellingen en onderhoud. Sommige velden zijn grijs weergegeven en kunnen niet verborgen worden.

        Gebruik **Alles activeren** of **Alles deactiveren** om snel alle velden te tonen of te verbergen.

    * **Label:** Voer een gebruiksvriendelijke naam in voor het veld. Laat leeg om het standaardlabel te gebruiken.
    * **Knopinfo:** Voeg een korte hulpkoptekst toe die wordt weergegeven wanneer gebruikers met de muis over het veld bewegen. Gebruik de schuifbalk als de tekst lang is.
    * **Bewerkbaar:** Staat gebruikers toe de waarde te wijzigen.
    * **Verplicht:** Vereist dat gebruikers het veld invullen in de offertelijn. Activeert automatisch **Bewerkbaar**.

        U kunt de instellingen voor bewerkbaar en verplicht per product overschrijven. Voor systeemgestuurde velden zijn deze opties echter uitgeschakeld, zowel in het dialoogvenster **Product configureren** als in het dialoogvenster **Product toevoegen/bewerken**.

    * **Volgorde:** Gebruik de pijltjes <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i> om de volgorde van de velden in het dialoogvenster aan te passen.

        De volgorde heeft invloed op beide dialoogvensters. Sommige velden hebben echter een vaste positie in het dialoogvenster **Product toevoegen/bewerken** en kunnen niet verplaatst worden.

1. Klik op **OK** om uw wijzigingen op te slaan.

1. Herhaal deze procedure indien nodig voor extra talen.

## Tips

* Niet alle velden hoeven getoond te worden. U kunt velden verbergen die gebruikers niet hoeven in te vullen, zoals leverancierscodes.
* Gebruik duidelijke en beschrijvende labels en knopinfo voor extra velden.
* Labelwijzigingen worden actief na de volgende aanmelding.

## Gerelateerde inhoud

* [Een product toevoegen aan een prijslijst][1]
* [Een product toevoegen/bewerken in een offerte][2]

<!-- Referenced links -->
[1]: price-list-and-products.md
[2]: ../../learn/quote/create.md#add-products

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/configure-product-dialog.png

---
uid: help-nl-price-list-add
title: Prijslijst toevoegen
description: In deze hulpgids leert u hoe u een prijslijst kunt toevoegen en bewerken in SuperOffice Quote.
author: SuperOffice RnD
date: 02.23.2023
keywords: product, prijslijst
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Een prijslijst toevoegen

Het is niet ongebruikelijk om verschillende prijslijsten te gebruiken voor verschillende tijden van het jaar of voor specifieke campagnes die u mogelijk wilt houden.

Het aanpassen van prijslijsten helpt uw verkopers de juiste prijsdetails te gebruiken zonder tijd te verspillen aan het dubbel controleren ervan. U kunt als beheerder bepalen wanneer een bepaalde prijslijst moet worden gebruikt met behulp van de optie beperkte geldigheid.

![U kunt al uw prijslijsten toevoegen en bewerken op het tabblad SuperOffice-producten -screenshot][img1]

## Stappen

1. [!include[Go to products](../includes/goto-products.md)]

1. Klik op de knop **Toevoegen** onder aan het tabblad. Het dialoogvenster **Prijslijst toevoegen/bewerken** wordt weergegeven.

1. Vul de volgende velden in:

    * **Naam prijslijst**: geef de prijslijst een beschrijvende naam om deze te onderscheiden van andere prijslijsten.

    > [!NOTE]
    > U kunt de valuta niet wijzigen nadat u de prijslijst hebt gemaakt. Om valuta in te schakelen, gaat u naar **Voorkeuren** > **Systeem** > **Gebruik van valuta inschakelen**.

    * **Beschrijving**: geef een beschrijving voor de prijslijst.

    * **Actief**: hier inschakelen om de prijslijst te activeren en beschikbaar te maken voor offertes. U moet de prijslijst pas activeren als deze helemaal gereed is.

    * **Beperkte geldigheid**: vink hier aan indien de prijslijst alleen voor een beperkte periode geldig is. Bijvoorbeeld tijdens een tijdsbegrensde verkoopcampagne. U kunt een begin- en einddatum kiezen *OF* alleen een einddatum.

1. Voer een van de volgende handelingen uit:

    * Selecteer **Lege prijslijst toevoegen** om met een lege prijslijst te beginnen en alle producten handmatig in te voeren.
    * Selecteer **Bestaande prijslijst kopiëren** om een prijslijst met alle bijbehorende producten te kopiëren.

    1. Selecteer de vereiste prijslijst hieronder.

    2. Selecteer een van de volgende opties:

        * **Prijzen converteren vanuit oorspronkelijke prijslijst naar &lt;currency&gt;**: Selecteer deze optie om de bestaande prijzen in de prijslijst te gebruiken. Als u een prijslijst kopieert in een valuta die afwijkt van de gebruikte valuta voor de prijslijst die u maakt, worden de prijzen geconverteerd naar de juiste valuta.

        * **Prijzen instellen op nul &lt;currency&gt;**: Selecteer deze optie als u de prijzen niet wilt kopiëren vanuit de prijslijst. U moet u de prijzen van alle producten handmatig invoeren in de prijslijst.

1. Klik op **OK**.

    > [!NOTE]
    > nadat de prijslijst is gemaakt, kunt u de valuta en geldigheid niet meer wijzigen.

## Gerelateerde inhoud

* [Producten toevoegen aan een prijslijst][1]
* [Synchroniseren][2]
* [Een Sync Connector toevoegen][3]
* [Een ERP-verbinding toevoegen][4]

<!-- Referenced links -->
[1]: add-product-to-price-list.md
[2]: ../sync/index.md
[3]: ../sync/sync-connector-add.md
[4]: ../sync/sync-add-erp-connection.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/quote/add-price-list.png

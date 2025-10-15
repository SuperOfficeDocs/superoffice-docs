---
uid: help-nl-erp-add-connection
title: Een Sync Connector en ERP-verbinding toevoegen
description: Leer hoe u een synchronisatie-app installeert, een Sync Connector toevoegt en ERP-verbindingen aanmaakt om synchronisatie mogelijk te maken tussen SuperOffice CRM en een ERP-systeem.
keywords: ERP-synchronisatie instellen, sync connector toevoegen, ERP-verbinding toevoegen, ERP-verbinding testen, connector, ERP, synchroniseren
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
redirect_from:
  - /nl/quote/learn/admin/sync/sync-add-erp-connection
  - /nl/quote/learn/admin/sync/sync-connector-add
index: true
---

# Een Sync Connector en ERP-verbinding toevoegen

[!include[Requirement](../../includes/req-dev-tools.md)]

Om gegevens te synchroniseren tussen SuperOffice CRM en een ERP-systeem, moet u eerst een synchronisatie-app installeren. Daarna kunt u in Instellingen en onderhoud een Sync Connector configureren en een of meer ERP-verbindingen aanmaken.

## 1. Installeer de synchronisatie-app

Voordat u een Sync Connector kunt toevoegen, hebt u een synchronisatie-app nodig voor uw ERP-systeem.

1. Controleer de [SuperOffice App Store][7] voor een standaardapp die uw ERP-systeem ondersteunt.

    Als er geen standaardapp beschikbaar is of als u een aangepaste versie nodig hebt, kunt u er een laten [ontwikkelen door een SuperOffice-partner][8] of uw eigen team.

1. Volg de instructies van de app-provider om de connector te installeren en te registreren.

## <a id="connector"></a>2. Een Sync Connector toevoegen

1. In **Instellingen en onderhoud** kies <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offerte/Synchroniseren** van het navigator.

1. Open het tabblad **Synchroniseren**.

1. Klik op **Toevoegen** onder de lijst **Sync Connectors**.

1. Voer een naam en de connector-URL in.

1. Klik op **OK**.

De Sync Connector wordt toegevoegd aan de lijst.

![Synchroniseren-tabblad met één Sync Connector in Instellingen en onderhoud -screenshot][img1]

## <a id="connection"></a>3. Een ERP-verbinding toevoegen

1. Klik in het tabblad **Synchroniseren** onder de lijst **ERP-verbindingen** op **Toevoegen**.

    Het dialoogvenster **Een nieuwe ERP-verbinding definiëren** wordt geopend.

    ![Dialoogvenster ERP-verbinding definiëren met voorbeeldinvoer -screenshot][img2]

1. Geef een naam op voor de ERP-verbinding.

1. Selecteer de gewenste Sync Connector in de lijst.

1. Definieer de **Bereik**:

    * **Iedereen**: Alle gebruikers hebben toegang tot deze ERP-verbinding.
    * **Specifieke gebruikers + groepen**: Alleen geselecteerde gebruikers en groepen hebben toegang. Klik op de link om de dialoog voor toegang te openen.

        ![Dialoogvenster om bereik te configureren met gebruikersgroepselectie -screenshot][img3]

1. Vul de **Configuratievelden** in. Deze zijn afhankelijk van de gekozen connector en kunnen instellingen bevatten zoals authenticatie, paden, getallen of andere technische waarden.

1. Voeg eventueel een beschrijving toe waarin het doel van deze verbinding wordt toegelicht.

1. Klik op **ERP-verbinding testen**.

    Als de test mislukt, controleer dan de connector-URL en de configuratievelden. Los het probleem op voordat u verdergaat.

1. Klik op **OK** om de verbinding op te slaan. De nieuwe ERP-verbinding verschijnt in de lijst.

    Als de knop **OK** is uitgeschakeld, betekent dit dat de test nog niet is geslaagd of dat verplichte velden ontbreken.

> [!NOTE]
> Voordat u de ERP-verbinding kunt gebruiken, moet u synchronisatie-instellingen configureren en de verbinding activeren. Zie [ERP-verbinding configureren][1].

## Volgende stappen

* [Veldtoewijzing en lijsten configureren][1]
* [Standaardwaarden definiëren][3]
* [De volgorde van de ERP-velden selecteren][4] die op het ERP-tabblad in SuperOffice CRM worden weergegeven
* [Synchronisatieprioriteit instellen][5]
* [Gegevens importeren uit het ERP-systeem][6]

<!-- Referenced links -->
[1]: configure.md
[3]: configure.md#defaults
[4]: configure.md#rank
[5]: configure.md#priority
[6]: ../../admin/import/from-erp.md
[7]: https://online.superoffice.com/appstore/app/search?phrase=sync
[8]: ../../../en/developer-portal/custom-app/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/sync-connectors-list.png
[img2]: ../../../media/loc/en/erp/define-erp-connection.png
[img3]: ../../../media/loc/en/erp/configure-scope.png

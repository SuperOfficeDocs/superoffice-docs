---
uid: help-nl-quote-admin
title: Offertes en orders configureren
description: Ontdek hoe offertes, quote connectors en ERP-integratie werken in SuperOffice CRM en hoe u deze configureert op het scherm Offerte/Synchroniseren.
keywords: quote connector, ERP-verbinding, offerte-instellingen, prijslijst, product, Offerte/Synchroniseren, ERP-configuratie, quote connector-instellingen, offerte-integratie, verkoopconfiguratie, offerte, synchroniseren
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from:
  - /nl/quote/learn/admin/index
  - /nl/quote/learn/admin/quotesync-tab-erp-connections
  - /nl/quote/learn/admin/quotesync-tab-settings
index: true
---

# Offertes en orders configureren

Op het scherm **Offerte/Synchroniseren** onder Instellingen en onderhoud configureert u alles wat nodig is om offertes en orders mogelijk te maken in SuperOffice CRM.

> [!NOTE]
> Deze functie vereist het **Sales Premium** gebruikersplan.

## Producten en prijslijsten

Elke offerte in SuperOffice bevat één of meer producten, en elk product moet deel uitmaken van een **prijslijst**.

Er zijn twee manieren om producten en prijzen in SuperOffice CRM te beheren:

* **Handmatig**, via het ingebouwde SuperOffice-productregister (ook wel **SuperOffice Standalone connector** genoemd).

* **Automatisch**, door productgegevens op te halen uit een extern **ERP-systeem**.

## Quote connectors en ERP-verbindingen

Om productgegevens op te halen en prijzen te berekenen gebruikt SuperOffice **quote connectors** en **ERP-verbindingen**.

Een **quote connector** is een plug-in (webservice of DLL) die de integratie afhandelt. Deze communiceert met een specifiek ERP- of productinformatiesysteem en voert taken uit zoals:

* Product- en prijsgegevens ophalen
* Kortingen valideren
* Totale bedragen en btw berekenen
* Geaccepteerde offertes als orders doorsturen

Een **quote connector werkt pas** nadat deze is geconfigureerd. U moet daarvoor een **ERP-verbinding** aanmaken. Deze koppelt de connector aan:

* Toegangsbeheer (wie mag hem gebruiken)
* Authenticatie of eindpuntinstellingen
* Gedragsregels zoals afronding, waarschuwingen en goedkeuringslogica

Zie het als: **ERP-verbinding = quote connector + configuratie**

U kunt meerdere ERP-verbindingen aanmaken voor dezelfde connector, bijvoorbeeld als uw organisatie verschillende instellingen per markt of gebruikersgroep heeft.

> [!TIP]
> Alle ERP-verbindingen worden beheerd via het tabblad **ERP-verbindingen** op het scherm **Offerte/Synchroniseren**.

### SuperOffice Standalone connector

Dit is de standaardconfiguratie wanneer geen ERP-systeem is gekoppeld. Ideaal voor eenvoudig offrerteren of wanneer productgegevens niet elders worden beheerd. Alle gegevens worden opgeslagen in SuperOffice:

* [Definieer prijslijsten en voeg handmatig producten toe][2]
* Gebruik de ingebouwde rekentool
* Geen ondersteuning voor automatische orderverzending

> [!NOTE]
> U hebt nog steeds een ERP-verbinding nodig, maar die is lokaal in SuperOffice en maakt geen verbinding met een extern systeem.

### Offreren met ERP-integratie

Wanneer SuperOffice is gekoppeld aan een ERP-systeem, haalt de quote connector product- en prijsgegevens direct op uit het ERP:

* Producten worden in realtime opgehaald (niet opgeslagen in SuperOffice)
* Prijzen en kortingen volgen de ERP-regels
* Geaccepteerde offertes kunnen automatisch worden omgezet in ERP-orders

## <a id="tabs"></a>Tabbladen op het scherm Offerte/Synchroniseren

Het scherm Offerte/Synchroniseren bevat vier tabbladen waarmee u offertes, producten en ERP-integratie kunt configureren.

### ERP-verbindingen

Voor het beheren van ERP-verbindingen voor quote connectors.

* Toont alle beschikbare Quote Connectors (automatisch geladen na installatie). Beweeg de muis over een rij voor meer informatie.
* Geeft actieve ERP-verbindingen weer.
* Dubbelklik op een verbinding om instellingen zoals bereik, gedrag en validatieregels aan te passen.
* Selecteer een ERP-verbinding en klik op **ERP-verbinding testen** om de verbinding te controleren.

> [!TIP]
> Zie [Een ERP-verbinding instellen][1] voor stapsgewijze instructies.

### SuperOffice-producten

Voor het beheren van [prijslijsten en producten][2] die zijn opgeslagen in SuperOffice (wanneer u de standalone connector gebruikt). Deze gegevens worden **niet** opgeslagen in een ERP-systeem.

U kunt:

* Prijslijsten toevoegen, bewerken en verwijderen.
* Producten toevoegen of verwijderen uit lijsten. Dubbelklik op een product om het te bewerken.
* Productdetails zoals kostprijs, btw en marge instellen.
* Een miniatuurafbeelding selecteren voor gebruik in het offertescherm.

### Instellingen

Voor het configureren van globale offerte-instellingen en de [indeling van het productvenster][3].

* **Korting geven op totale waarde:** Hiermee wordt een extra veld geactiveerd voor korting op het totale offertebedrag (percentage of bedrag). Deze velden verschijnen onderaan het tabblad **Producten** in het dialoogvenster **Offerte bewerken**.

    > [!NOTE]
    > De totaalkorting wordt toegepast bovenop kortingen die al op de afzonderlijke producten zijn ingesteld.

* **Standaardtekst voor vervolgactiviteit:** Bepaalt de standaardtekst voor vervolgactiviteiten die worden aangemaakt bij het verzenden van offertes.

* **Verkooptypen openen:** Opent de lijst **Verkoop – Type, Fasen, Offerte**, waarin regels zijn gedefinieerd die gelden voor offertes. Elke verkoop moet een [verkooptype][5] hebben. Veel standaardinstellingen zoals geldigheid, goedkeuringsvereisten en de offerte-sjabloon zijn afhankelijk van het verkooptype.

Onder **Productvelden** configureert u welke velden worden weergegeven in het dialoogvenster product toevoegen/bewerken.

### Sync

Voor het [toevoegen van Sync Connectors en ERP-verbindingen][4] om bedrijven, personen en projecten te synchroniseren met het ERP-systeem. Alleen van toepassing als u gegevenssynchronisatie gebruikt.

## Gerelateerde inhoud

* [Een ERP-verbinding instellen][1]
* [Prijslijsten en producten toevoegen][2]
* [Productvenster aanpassen][3]
* [ERP-synchronisatie beheren][4]

<!-- Verwijzingen -->
[1]: set-up-quote-connector.md
[2]: price-list-and-products.md
[3]: configure-product-fields.md
[4]: ../../../erp/admin/index.md
[5]: ../sale-type.md

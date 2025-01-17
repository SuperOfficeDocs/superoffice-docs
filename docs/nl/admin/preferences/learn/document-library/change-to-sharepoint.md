---
uid: help-nl-document-library-change-to-sharepoint
title: SharePoint-documentbibliotheek configureren
description: SharePoint-documentbibliotheek configureren
author: SuperOffice RnD
so.date: 03.21.2023
keywords: document, SharePoint
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# SharePoint-documentbibliotheek configureren

> [!NOTE]
> Voordat u deze configuratie kunt starten, moet u uw SharePoint-site, bibliotheken en machtigingen instellen. Alle gebruikers moeten worden geverifieerd via Microsoft 365.

Wanneer u uw nieuwe documentbibliotheek configureert, geeft Admin een tussenstatus weer.

Wanneer u klaar bent en hebt bevestigd dat u SharePoint gaat gebruiken, verandert de status in Beheerder naar Microsoft SharePoint Online.

Het is mogelijk om later bepaalde instellingen in de Wizard te wijzigen

**Stappen:**

1. [!include[Open preferences](../includes/open-preferences.md)]
2. Selecteer het tabblad **Documentbibliotheek**.
3. Klik op **Wijzigen**. De pagina wordt bijgewerkt met informatie over de verbonden SharePoint-site. De wijziging is nog niet voltooid.
4. Klik op **De wijziging voltooien** om te bevestigen dat u SharePoint wilt gebruiken als de standaarddocumentbibliotheek. De wijziging is nu voltooid.
5. Klik op **Instellingen**.
6. Voer de vier stappen van de configuratiewizard uit die hieronder worden beschreven.

## Stap 1 - Sites en mappen

In deze stap moet u de locatie, mappen en bestandsnamen configureren voor uw SuperOffice-documenten en -sjablonen.

### SuperOffice-documenten - locatie, mappen en bestandsnamen

* **Site in SharePoint**: selecteer uw site in de lijst.
* **Documentbibliotheek**: selecteer de bibliotheek in de lijst.
* **Mapstructuur**: selecteer de gewenste mapstructuur (mapnamen).
* **De mappen in jaarlijkse submappen ordenen**: selecteer deze optie om per jaar submappen toe te voegen.
* **Bestandsnaam**: selecteer de voorkeursnaamgeving van bestanden.

### SuperOffice-documentsjablonen — Locatie

* **Site in SharePoint**: selecteer uw site in de lijst.
* **Documentbibliotheek**: selecteer de bibliotheek in de lijst.

Klik op **Volgende stap** om door te gaan.

## Stap 2 - Documenteigenschappen

In deze stap moet u selecteren welke documentvelden u wilt overbrengen als documenteigenschappen van SuperOffice naar SharePoint.

> [!NOTE]
> We raden u aan alle beschikbare velden te selecteren. Deze velden verschijnen als kolommen in uw SharePoint-documentbibliotheek.

Deze velden kunnen worden gebruikt om weergaven te maken in uw SharePoint-documentbibliotheek. U kunt op basis van deze velden ook zoeken en groeperen in SharePoint. Specifieke velden kunnen indien nodig worden verborgen.

> [!NOTE]
> Om wijzigingen in documenten in SuperOffice te bewaren, moeten we de ID van de velden opslaan. ID-kolommen kunnen worden verborgen in uw SharePoint-documentweergaven.

Klik op **Volgende stap** om door te gaan.

## Stap 3 - Groepen en toegang

In deze stap kunt u groepstoegang tot SharePoint-documenten inschakelen op basis van de instellingen bij "Zichtbaar voor" in SuperOffice.

Als u niet van plan bent om "Zichtbaar voor" te gebruiken, selecteert u deze optie niet.

1. Selecteer **Groepstoegang inschakelen voor SharePoint-documenten op basis van de instellingen "Zichtbaar voor" in SuperOffice**.

2. Om machtigingen voor documenten in SharePoint in te stellen, hebben we machtigingen voor lezen/schrijven nodig voor de geselecteerde site. Dit is een eenmalige autorisatie en omvat alleen de site die u hebt geselecteerd voor uw SuperOffice-documenten.

    > [!NOTE]
    > Alleen een globale Microsoft 365-beheerder kan deze machtigingen autoriseren. Bovendien moet de globale Microsoft 365-beheerder lid zijn van de eigenaarsgroep van de site, aangezien machtigingen als site-eigenaar vereist zijn om machtigingen voor lezen/schrijven in te stellen.

    Voer een van de volgende handelingen uit:

    * Als u een globale Microsoft 365-beheerder bent: klik op **Nu autoriseren** om te autoriseren.

    * Als u GEEN globale Microsoft 365-beheerder bent: klik op **De autorisatie-URL kopiëren** en stuur deze naar een globale Microsoft 365-beheerder in uw organisatie.

3. Als u moet wachten op een autorisatie, hebt u de volgende opties:

    * Klik op **Opslaan en sluiten** om de configuratie later voort te zetten. De paginatekst wordt bijgewerkt om aan te geven dat autorisatie in behandeling is.

    * Klik op **Status opnieuw controleren** om te zien of de globale Microsoft 365-beheerder de app heeft geautoriseerd.

4. Selecteer voor elke SuperOffice-gebruikersgroep de overeenkomende gebruikersgroep in SharePoint. Alle SuperOffice-gebruikersgroepen moeten worden toegewezen voordat u naar de volgende stap kunt gaan.

5. Klik op **Volgende stap** om door te gaan.

## Stap 4 - Controleren en bevestigen

Controleer de configuratie zorgvuldig en zorg ervoor dat de instellingen correct zijn.

Nadat u de instellingen bevestigt, kunnen ze niet meer worden bewerkt:

SuperOffice-documenten

* Site in SharePoint
* Documentbibliotheek

SuperOffice-documentsjablonen

* Site in SharePoint
* Documentbibliotheek

Klik op **Bevestigen** wanneer u klaar bent.

## Verwante onderwerpen

* [SharePoint-documenten][1] - technisch overzicht

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/index.html

<!-- Referenced images -->

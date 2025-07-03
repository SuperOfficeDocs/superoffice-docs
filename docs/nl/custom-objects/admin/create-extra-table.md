---
uid: help-nl-extra-table-create
title: Extra tabellen toevoegen
description: Extra tabellen toevoegen
keywords: extra tabellen, databasetabel, tabel, tabeleigenschappen
author: Bergfrid Dias
date: 01.30.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/custom-objects/learn/extra-table/create
index: true
---

# Extra tabellen toevoegen

U kunt extra tabellen maken in SuperOffice om verschillende soorten gegevens te registreren. Nadat u de tabel hebt gemaakt en er [extra velden][1] in hebt gemaakt, kunt u de tabel openen om er inhoud aan toe te voegen.

## Stappen

1. [!include[Ga naar Tabellen](includes/goto-tables.md)]

1. Klik op **Nieuwe tabel**.

    ![Maak een extra tabel aan -screenshot][img1]

1. In het veld **Tabeleigenschappen** voer gegevens in over de nieuwe tabel.

    * Voer een *naam* in die als label wordt gebruikt.
    * Voer een *databasetabel* in die begint met **y_** om het in het schema te identificeren.
    * Optioneel stel andere eigenschappen in. Zie details over de velden hieronder.

    > [!NOTE]
    > Sommige tabeleigenschappen kunnen niet worden ingesteld totdat u velden heeft toegevoegd.

1. Klik op **OK** om de nieuwe tabel op te slaan (voert `create table y_mynewtable ...` uit).

1. [Voeg velden toe aan uw nieuwe tabel][1].

1. Optioneel, pas tabeleigenschappen aan zoals sorteervolgorde. (Klik op de tabelnaam in de lijst om de bewerkingsmodus te betreden.)

1. Klik op **NetServer opnieuw starten**. Als Travel is geactiveerd, ziet u ook een bericht dat er een nieuwe Travel-database moet worden gegenereerd.

U kunt nu de tabel in de gebruikersinterface openen om er inhoud aan toe te voegen **of** het via de API's vullen.

## Velden

| Veld | Beschrijving |
|---|---|
| Map | Als u de tabel in een bestaande map wilt plaatsen, selecteert u een map in de lijst. |
| Naam | de naam van de tabel. |
| Databasetabel | De naam van de databasetabel. Kan alleen bij het maken worden opgegeven en kan niet worden gewijzigd. De tabelnaam mag onderstrepingstekens, de letters a-z en alleen cijfers bevatten en de naam moet beginnen met "y_". Een logische naam is het beste, omdat het dan makkelijker is om te zien wat de database bevat. |
| Zoekkoptekst | De koptekst die in het zoekscherm voor deze tabel wordt gebruikt. |
| Koptekst voor weergeven van item | De koptekst die wordt gebruikt wanneer u een item in deze tabel weergeeft. |
| Koptekst voor nieuw item | De koptekst die wordt gebruikt wanneer u een nieuw item in deze tabel maakt. |
| Koptekst voor bewerken van item | De koptekst die wordt gebruikt wanneer u een item in deze tabel bewerkt. |
| Sorteervolgorde | De kolom waarop de tabel is gesorteerd. Als u **Aflopend** aanvinkt, worden de waarden in aflopende volgorde gesorteerd. Voor numerieke waarden betekent dit dat de hoogste waarde boven aan de tabel wordt weergegeven. De tabel moet velden bevatten voordat u hier iets kunt selecteren. |
| Veld weergeven | Als gegevens uit deze tabel in een andere tabel (een relatie) worden weergegeven, moet u selecteren welk veld u in de andere tabel wilt weergeven. De tabel moet velden bevatten voordat u hier iets kunt selecteren. |
| Bovenliggend veld | Dit veld wordt gebruikt in samenhang met hiërarchische tabellen. |
| Volledige naam | Wanneer dit een hiërarchische tabel betreft, kunt u in dit veld een veld opgeven dat automatisch wordt bijgewerkt met de volledige naam van het item, op basis van het naamveld voor dit item en alle bovenliggende items. |
| Veld ID verbergen | Wanneer deze optie is ingeschakeld, wordt het veld ID niet weergegeven wanneer een gebruiker de items in de tabel bekijkt. |
| De tabel verbergen | Als deze optie is ingeschakeld, is de tabel niet zichtbaar via **Systeemontwerp** > **Tabellen**. |

## Tabelinformatie in webvensters bevatten

In SuperOffice CRM kunt u webvensters maken die tabelinformatie bevatten. Als u de relevante toegangsrechten wilt instellen, moet de gebruiker deel uitmaken van een rol met de functionele rechten **Tabellen weergeven** en **Tabellen bewerken**.

<!-- Referenced links -->
[1]: create-extra-field.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png

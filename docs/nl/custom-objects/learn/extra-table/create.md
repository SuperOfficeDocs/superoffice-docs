---
uid: help-nl-extra-table-create
title:  Extra tabellen definiëren
description:  Extra tabellen definiëren
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: extra tafel
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Extra tabellen toevoegen

U kunt extra tabellen maken in SuperOffice om verschillende soorten gegevens te registreren. Nadat u de tabel hebt gemaakt en er [extra velden][1] in hebt gemaakt, kunt u de tabel openen om er inhoud aan toe te voegen door naar **Systeemontwerp** &gt; **Tabellen** te gaan, de tabel aan te wijzen en op de knop ![pictogram][img1] te klikken.

> [!NOTE]
> In SuperOffice CRM kunt u webvensters maken die tabelinformatie bevatten. Als u de relevante toegangsrechten wilt instellen, moet de gebruiker deel uitmaken van een rol met de functionele rechten**Tabellen weergeven** en **Tabellen bewerken**.

**Stappen:**

1. Ga naar het scherm **Tabellen**.

    * In Instellingen en onderhoud: Klik op de knop ![pictogram][img3] **Systeemontwerp** in de navigator. Selecteer vervolgens het tabblad **Tabellen**.

2. Klik op de knop ![pictogram][img4]. Het scherm **Tabeleigenschappen** wordt geopend.

3. In het veld **Tabeleigenschappen** geeft u de gegevens in over de nieuwe tabel. Zie details over de onderstaande velden.

4. Klik op **OK** om de nieuwe tabel op te slaan.

## Velden

| Veld | Beschrijving |
|---|---|
| Map | Als u de tabel in een bestaande map wilt plaatsen, selecteert u een map in de lijst. |
| Naam | de naam van de tabel. |
| Databasetabel De naam van de databasetabel. Kan alleen bij het maken worden opgegeven en kan niet worden gewijzigd. De tabelnaam mag onderstrepingstekens, de letters a-z en alleen cijfers bevatten en de naam moet beginnen met "y_". Een logische naam is het beste, omdat het dan makkelijker is om te zien wat de database bevat. |
| Zoekkoptekst | De koptekst die in het zoekscherm voor deze tabel wordt gebruikt. |
| Koptekst voor weergeven van item | De koptekst die wordt gebruikt wanneer u een item in deze tabel weergeeft. |
| Koptekst voor nieuw item | De koptekst die wordt gebruikt wanneer u een nieuw item in deze tabel maakt. |
| Koptekst voor bewerken van item | De koptekst die wordt gebruikt wanneer u een item in deze tabel bewerkt. |
| Sorteervolgorde | De kolom waarop de tabel is gesorteerd. Als u **Aflopend** aanvinkt, worden de waarden in aflopende volgorde gesorteerd. Voor numerieke waarden betekent dit dat de hoogste waarde boven aan de tabel wordt weergegeven. De tabel moet velden bevatten voordat u hier iets kunt selecteren. |
| Veld weergeven | Als gegevens uit deze tabel in een andere tabel (een relatie) worden weergegeven, moet u selecteren welk veld u in de andere tabel wilt weergeven. De tabel moet velden bevatten voordat u hier iets kunt selecteren. |
| Bovenliggend veld | dit veld wordt gebruikt in samenhang met hiërarchische tabellen. |
| Volledige naam |  Wanneer dit een hiërarchische tabel betreft, kunt u in dit veld een veld opgeven dat automatisch wordt bijgewerkt met de volledige naam van het item, op basis van het naamveld voor dit item en alle bovenliggende items. |
| Veld ID verbergen | Wanneer deze optie is ingeschakeld, wordt het veld ID niet weergegeven wanneer een gebruiker de items in de tabel bekijkt. |
| De tabel verbergen | Als deze optie is ingeschakeld, is de tabel niet zichtbaar via ![pictogram][img3] **Systeemontwerp** &gt; **Tabellen**. |

## Wat wilt u nu doen?

* [Extra velden definiëren][1]

<!-- Referenced links -->
[1]: ../extra-field/create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/service/new-field.png
[img3]: ../../../../../common/icons/nav-admin-systemdesign-active.png
[img4]: ../../../../media/icons/service/new-table.png

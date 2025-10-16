---
uid: help-nl-import
title: Import
description: Import
keywords: import
author: SuperOffice Product and Engineering
date: 02.22.2023
version: 10.5
content_type: concept
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/admin/import/learn/index
language: nl
---

# Contactpersonen en productgegevens importeren

Een lege CRM-database helpt u niet bij het beheren van uw contactpersonen. Door uw klantgegevens in één keer te importeren met behulp van onze importfunctie, kunt u snel beginnen met het beheren van uw klantrelaties in SuperOffice CRM.

Gebruikt u de Windows-client? Zie [Instellingen van Windows-client][7].

[!include[Back up database before import](includes/caution-backup-before-import.md)]

In het scherm **Importeren** kunt u bedrijven, personen en producten importeren in SuperOffice. U kunt nieuwe en bestaande bedrijven/personen invoeren met bijgewerkte gegevens.

> [!NOTE]
> Voor elke import wordt een selectie gemaakt in SuperOffice CRM. Hiermee kunt u de geïmporteerde bedrijven/personen verder verwerken, of verwijderen.

## Bronnen

De Importeren-functie ondersteunt imports van de volgende bronnen:

* [Excel][1]. Met de Excel-indeling kunt u bedrijven, personen en [producten][5] van andere toepassingen en indelingen importeren.
* [Outlook][2]. Importeert bedrijven en personen van Microsoft Outlook.
* [Gmail][3]. Importeert bedrijven en personen van Google Gmail.
* [ERP][4]. Actors (klanten, leveranciers en personen) importeren uit een ERP-systeem.

> [!NOTE]
> Om gegevens zoals projecten, valuta, postcodes en belangrijke dagen te importeren, dient u de functie [Importeren][7] in Instellingen van Windows-client te gebruiken.

## Importeren in een legen SuperOffice-database

* Alle bedrijfsgegevens en gegevens van personen importeren. Zorg er voor dat u alle kolommen in de import koppelt aan de juiste SuperOffice-velden en dat u de juiste [Importinstellingen][6] specificeert om alle noodzakelijke gegevens van de importbron op te nemen.

* Enkel bedrijven importeren: Als u alleen bedrijven wilt importeren zonder personen, ga dan naar [Importinstellingen][6] en selecteer de optie **Geen - geen persoon importeren** in de keuzelijst **Duplicaat** onder **Persoon**.

* Alleen personen importeren: Als u alleen personen wilt importeren zonder bedrijven, ga dan naar [Importinstellingen][6] en selecteer de optie **Personen zonder bedrijf importeren** in de keuzelijst **Indien geen bedrijfsnaam** onder **Persoon**.

## Oude gegevens bijwerken in SuperOffice

Als SuperOffice verouderde informatie bevat en u deze velden wilt bijwerken met de juiste gegevens vanuit Excel bijvoorbeeld, moet u de actie **Vervangen - bestaande overschrijven** gebruiken bij het importeren. Lege SuperOffice-velden worden ook gevuld met de nieuwe informatie.

## Aanvullende informatie importeren

Als u veel informatie over klanten en contactpersonen in SuperOffice mist, gebruikt u de actie **Samenvoegen, lege velden bijwerken** bij het importeren van bedrijven en contactpersonen. Hiermee worden alleen lege velden bijgewerkt zonder de bestaande informatie te overschrijven.

<!-- Referenced links -->
[1]: from-excel.md
[2]: from-outlook.md
[3]: from-gmail.md
[4]: from-erp.md
[5]: products-from-excel.md
[6]: settings.md
[7]: https://help.superoffice.com/docs/10.3/en/onsite/win-client/learn/import/index.html

<!-- Referenced images -->

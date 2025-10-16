---
uid: help-nl-import-create-excel
title: Een importbestand maken
description: In deze handleiding leert u hoe u een importbestand maakt met behulp van de Excel-sjabloon.
keywords: import, Excel, bedrijf, contactpersoon, product, spreadsheet
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/admin/import/learn/create-import-file
language: nl
---

# Een importbestand maken

Om het voor u gemakkelijker te maken om personen te importeren, hebben we een importsjabloon gemaakt die u kunt downloaden en gebruiken om te importeren. In deze Excel-spreadsheet hebben we de basisgegevensvelden in kolommen ingesteld en hoeft u alleen maar uw contactgegevens naar de juiste cellen te kopiëren.

## Bedrijven en contactpersonen

Het Excel-werkblad moet ten minste kolommen bevatten met:

* Bedrijfsnamen
* Namen van de persoon (voornaam en achternaam)

> [!TIP]
> Controleer of de gegevens up-to-date zijn. Zijn bijvoorbeeld de postadressen en telefoonnummers correct?

**Voorbeeldweergave van een importbestand (Excel):**

![Het gebruik van een importbestand is de beste manier om al uw contactpersonen te importeren in SuperOffice CRM -screenshot][img2]

[Download de importsjabloon voor bedrijven en contactpersonen][1] [Excel spreadsheet]

## Producten

Het Excel-werkblad moet ten minste kolommen bevatten met:

* Productcode
* Productnaam
* Catalogusprijs

U kunt bijvoorbeeld de volgende kolommen met gegevens verwerken: In assortiment, productcode, naam, beschrijving, productcategorie, eenheid, catalogusprijs, minimumprijs eenheid, kosten, productnaam.

> [!TIP]
> Bekijk uitleg en tips door de muisaanwijzer op kolomkoppen te plaatsen.
>
> Zorg voor een unieke productcode voor iedere rij als duplicaatsleutel.

**Voorbeeldweergave van een importbestand (Excel):**

![Het gebruik van een importbestand is de beste manier om al uw producten te importeren in SuperOffice CRM -screenshot][img5]

[Download de importsjabloon voor producten][2] [Excel spreadsheet]

## Tips

* Sommige velden in SuperOffice CRM zijn **verplicht**. Wanneer u bedrijven en contactpersonen importeert, moet u ervoor zorgen dat u de kolommen Categorie, Bedrijf en Persoon/bedrijfsnummer opneemt in uw importbestand. Wanneer u productinformatie importeert, voegt u productcode, catalogusprijs en naam toe.

* Als u meerdere contactpersonen uit een bedrijf wilt importeren, moet u één rij toevoegen voor elke contactpersoon en dezelfde bedrijfsnaam toevoegen aan alle rijen.

* Houd er rekening mee dat de kwaliteit van de gegevens die u importeert, bepalend is voor de kwaliteit van uw CRM-gegevens. We raden u aan uw gegevens door te nemen en het importbestand op te schonen voordat u begint. Bij een Import met enorme hoeveelheden data kan het een hele klus zijn om op te ruimen als het misgaat.

> [!NOTE]
> Voor grotere en complexe importen raden we altijd aan om een van onze bekwame consultants te gebruiken om ervoor te zorgen dat de kwaliteit van de gegevens die u in SuperOffice CRM importeert op zijn best is.

## Gerelateerde inhoud

* [Instellingen voor uw import kiezen][3]
* [Contactpersonen importeren in SuperOffice CRM][4]
* [Producten importeren in een prijslijst][5]

<!-- Referenced links -->
[1]: ../../../assets/downloads/import-template-for-contacts.xlsx
[2]: ../../../assets/downloads/import-template-products.xlsx
[3]: settings.md
[4]: from-excel.md
[5]: products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/admin/import-with-excel.jpg
[img5]: ../../../media/loc/en/admin/preview-of-an-import-file.png

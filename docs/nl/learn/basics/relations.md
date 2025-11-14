---
uid: help-nl-company-contact-relations
title: Bedrijfs- en persoonsrelaties in SuperOffice CRM
description: Leer hoe u relaties tussen bedrijven en personen kunt bekijken, toevoegen en beheren in SuperOffice CRM, om complexe bedrijfsverbindingen en aangepaste relaties eenvoudiger bij te houden.
keywords: relatie toevoegen, relatie verwijderen, relatie, verbinding, persoon, contact, bedrijf
author: Bergfrid Skaara Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/admin/lists/learn/relation
  - /nl/company/learn/add-relation
  - /nl/company/learn/delete-relation
  - /nl/contact/learn/add-relation
  - /nl/contact/learn/delete-relation
---

# Bedrijfs- en persoonsrelaties in SuperOffice CRM

Relaties in SuperOffice CRM maken het mogelijk om verbindingen tussen bedrijven en personen te leggen. Relaties bestaan altijd uit twee partijen: een actieve en een passieve. Bijvoorbeeld, "Bedrijf A bezit Bedrijf B," waarbij Bedrijf A de actieve partij is en Bedrijf B de passieve partij. Deze handleiding geeft een overzicht van hoe u deze relaties kunt bekijken, toevoegen en beheren, wat het eenvoudiger maakt om complexe structuren, samenwerkingen of aangepaste relaties van uw bedrijf bij te houden.

## Voorbeelden van relaties

Voorbeelden omvatten eigendomsstructuren, partnerschapsakkoorden of persoonlijke relaties tussen personen.

| Type | Actief | Passief |
|---|---|---|
| Bedrijf - bedrijf | Bedrijf ABC Ltd werkt samen met Consultancy Firm Co. | Consultancy ABC Ltd werkt samen met Company Firm Co. |
| Bedrijf - persoon | Bedrijf ABC Ltd huurt Greg Campbell (Consultancy Firm Co.) in. | Greg Campbell (Consultancy Firm Co.) wordt ingehuurd door bedrijf Firm Co. |
| Persoon - bedrijf | Peter Johnson is eigenaar van Company ABC Ltd. | Bedrijf ABC Ltd is eigendom van Peter Johnson. |
| Persoon - persoon | Mark Johnson (Consultancy Firm Co.) is de zoon van Peter Johnson (Company ABC Ltd). | Peter Johnson (Company ABC Ltd) is de vader van Mark Johnson (Consultancy Firm Co.). |

## Relaties bekijken

Het sectietabblad **Relaties**, beschikbaar op zowel het Bedrijf- als het Persoonskaart, toont de relaties tussen de huidige entiteit en andere bedrijven of personen.

![Relaties (Bedrijfkaart) -screenshot][img2]

[!include[Kolommen in het sectietabblad Relaties](../includes/table-relations-tab-columns.md)]

Om meer details te bekijken of om te bewerken, dubbelklik op een rij om het **Relatie**-dialoogvenster te openen.

## <a id="add"></a>Relatie toevoegen

1. Ga naar het Bedrijf- of Persoonskaart waar u een relatie wilt toevoegen.

1. Selecteer het sectietabblad **Relaties**.

1. Klik op **Toevoegen** om het **Relatie**-dialoogvenster te openen.

    ![Dialoogvenster Relaties -screenshot][img1]

1. **Geef de partijen op:**

    * **Actieve:** Selecteer een bedrijf of persoon.
    * **Passieve:** Selecteer de andere entiteit die bij de relatie betrokken is.

1. **Kies de relatie type:** Kies het type relatie, zoals "bezit", "in dienst bij" of "partner" uit de **Relatie**-lijst. De beschikbare opties zijn afhankelijk van of de relatie tussen een persoon en een bedrijf of tussen twee personen is.

    Het **Resultaat**-veld wordt automatisch bijgewerkt op basis van uw keuzes.

1. Voeg een beschrijving toe (optioneel): Voeg aanvullende informatie toe indien nodig.

1. Klik op **Opslaan** om de relatie aan te maken.

## <a id="delete"></a>Relatie verwijderen

1. Ga naar het sectietabblad **Relaties** op het Bedrijf- of Persoonskaart.

1. Zoek de relatie die u wilt verwijderen, klik met de rechtermuisknop en kies **Verwijderen**.

1. In het dialoogvenster dat verschijnt, klik op **Ja** om te bevestigen.

## Extra tips

* **Dropdown zoeken:** Wanneer u de actieve en passieve partijen selecteert, begin met het typen van de naam om het bedrijf of de persoon snel te vinden.

* **Relatietypes:** Relatietypes worden gedefinieerd in **Instellingen en Onderhoud**. Het aanpassen van deze types maakt het gemakkelijker om aan de specifieke behoeften van uw organisatie te voldoen.

## Gerelateerde inhoud

* [Verwijderen van items in SuperOffice CRM][2]
* [Groepsinformatie in sectietabbladen][1]
* [Items toevoegen aan de lijst Algemeen - Relatie][3]
* [Aangepaste velden in relaties][4]

<!-- Referenced links -->
[1]: ../section-tabs/index.md
[2]: deleting-elements.md
[3]: ../../admin/lists/specialized-lists.md#relation
[4]: ../../custom-objects/learn/extra-field.md#relation

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/relation.png
[img2]: ../../../media/loc/en/company/relations-detail.png

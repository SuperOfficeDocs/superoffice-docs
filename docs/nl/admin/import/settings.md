---
uid: help-nl-import-settings
title: Importinstellingen
description: Importinstellingen
keywords: import
author: SuperOffice Product and Engineering
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/admin/import/learn/configure-import-settings
language: nl
---

# Importinstellingen configureren

Het aanpassen van de importinstellingen bespaart u tijd en maakt het gemakkelijker om uw gegevens correct te importeren.

[!include[Back up database before import](includes/caution-backup-before-import.md)]

In het dialoogscherm **Importinstellingen** kunt u het importeren dusdanig aanpassen dat exact wordt opgenomen wat u wilt. Om te garanderen dat de kwaliteit van de geïmporteerde gegevens optimaal is, is het van belang de juiste importinstellingen op te geven.

Dit geldt bijvoorbeeld in de volgende gevallen:

* Duplicaten: Selecteer de gewenste methode voor het beheren van informatie die zowel in het importbestand als in de database voorkomt.
* Personen die niet aan bedrijven zijn gekoppeld.
* Rechtsgrondslag en toestemmingsbron voor personen.
* Lijsten: Selecteer de gewenste methode voor het beheren van lijstelementen in de import. Bijvoorbeeld nieuwe categorieën, bedrijfstypen en telefoonnummers, nieuwe productcategorieën, productfamilies en producttypen.

## Waar u rekening mee moet houden voordat u uw persoons- of productgegevens importeert

* U kunt definiëren wat het systeem moet doen als u personen importeert die al bestaan in SuperOffice CRM. Het systeem kan het bijwerken overschrijven of overslaan - het is uw keuze.

* U kunt ervoor kiezen om het systeem automatisch nieuwe categorieën te laten maken, als u een categorie gebruikt die niet bestaat in SuperOffice CRM in uw importbestand.

## Gebruikelijke scenario's

* Ik wil informatie importeren die nog niet aanwezig is in SuperOffice, maar ik wil niet de bestaande informatie overschrijven.
    Selecteer de optie **Samenvoegen - lege velden bijwerken**. Alleen lege velden in SuperOffice worden dan bijgewerkt met geïmporteerde informatie.

* De kwaliteit van de data die ik wil importeren is gewaarborgd, en ik wil de SuperOffice-database bijwerken.
    Selecteer de optie **Vervangen - bestaande overschrijven**. De gegevens van de import zullen bestaande velden in SuperOffice overschrijven.

* Ik wil alleen nieuwe bedrijven en personen in SuperOffice importeren.
    Selecteer de optie **Record overslaan - niet importeren**. Bedrijven en personen die al bestaan in SuperOffice worden niet bijgewerkt.

* Ik wil alleen nieuwe producten in de geselecteerde prijslijst importeren.
    Selecteer de optie **Record overslaan - niet importeren**. Reeds aanwezige producten in de geselecteerde prijslijst worden overgeslagen.

* Ik wil alle bedrijven en personen in SuperOffice importeren, en eventuele duplicaten zelf beheren.
    Selecteer de optie **Altijd toevoegen**.

* Ik wil alle producten in de geselecteerde prijslijst importeren, en eventuele duplicaten zelf beheren.
    Selecteer de optie **Altijd toevoegen**.

### Voorbeeld

**Bestaande gegevens:**

| | Bedrijf | Adres | BTW-nr. | Code |
|---|---|---|---|---|
| **Excel/Outlook/Gmail importeren** | ACME Inc | Broadway 123 | 11223344 | - |
| **SuperOffice** | ACME Inc. | Main street 456 | - | ACME1 |

**Actie:**

| Actie | Bedrijf | Adres | BTW-nr. | Code |
|---|---|---|---|---|
| **Samenvoegen** | ACME Inc. | Broadway 123 | 11223344 | ACME1 |
| **Vervangen** | ACME Inc. | Main street 456 | 11223344 | - |
| **Record overslaan** | ACME Inc. | Broadway 123 | - | ACME1 |

## Duplicaten beheren (bedrijf/persoon)

Er is sprake van een duplicaat als dezelfde record zowel in het importbestand als in de database voorkomt. In de importinstellingen moet u altijd regels opgeven voor het beheren van duplicaten.

Onder **Bedrijf** en **Persoon** en **Persoon** in het dialoogvenster **Importinstellingen** geeft u aan hoe duplicaten moeten worden beheerd.

1. Klik op de keuzelijst **Duplicaat** en selecteer de velden die gebruikt moeten worden om duplicaten van bedrijven en personen te identificeren.

    > [!NOTE]
    > Om het gevaar van het overschrijven van gegevens te vermijden moet u de optie kiezen die uniek is voor ieder bedrijf, iedere persoon en ieder product.
    >
    > De geselecteerde data voor duplicaatcontrole MOETEN aanwezig zijn in het importbestand. Als u naam+code selecteert, moet uw importbestand tenminste deze kolommen bevatten.

1. Klik op de keuzelijst **Actie** en kies hoe de resultaten van duplicaten moeten worden beheerd:

    * **Altijd toevoegen**:
      * Nieuwe bedrijven, personen en producten worden altijd toegevoegd, zelfs als er duplicaten zijn.
      * Nieuwe producten worden altijd toegevoegd, ook als er duplicaten zijn.

    * **Samenvoegen, lege velden bijwerken**:
      * Als bestaande bedrijven en personen lege velden hebben in SuperOffice, worden deze lege velden gevuld met gegevens van de importbron. Bestaande gegevens in SuperOffice-velden worden niet overschreven.

      * Als bestaande producten in de geselecteerde prijslijst lege velden hebben worden deze lege velden gevuld met gegevens van de importbron. Bestaande gegevens in de geselecteerde prijslijst worden niet overgeschreven.

    * **Vervangen - bestaande overschrijven**:
      * Importgegevens zullen bestaande gegevens in SuperOffice-velden overschrijven.
      * De geïmporteerde gegevens zullen de bestaande velden in de geselecteerde prijslijst overschrijven.

    * **Overslaan, niet importeren**:
      * Als bedrijven en personen al bestaan in SuperOffice, worden ze niet geïmporteerd.
      * Reeds aanwezige producten in de geselecteerde prijslijst worden niet geïmporteerd.

### Opties voor duplicaten

**Bedrijf:**

* **Naam**: De bedrijfsnaam moet identiek zijn.
* **Naam+afdeling**: De bedrijfsnaam en het departement moeten identiek zijn.
* **Nummer**: Het bedrijfsnummer moet identiek zijn.
* **Code**: De bedrijfscode moet identiek zijn.
* **BTW-nummer**: Het BTW-nummer van het bedrijf moet identiek zijn.
* **ID**: De bedrijfs-ID moet identiek zijn.

**Contactpersoon:**

* **Naam**: De volledige naam van de persoon (voornaam+achternaam) moet identiek zijn.
* **E-mailadres**: Het e-mailadres van de persoon moet identiek zijn.
* **Mobiel nummer**: Het nummer van de mobiele telefoon van de persoon moet identiek zijn.
* **Nummer**: Het contactnummer moet identiek zijn.
* **Geen - persoon niet importeren**: Selecteer deze optie als u geen personen wenst te importeren.
* **ID**: De persoon-ID moet identiek zijn.

**Product:**

* **Naam**: De productnaam moet identiek zijn.
* **Code**: De productcode moet identiek zijn.
* **Naam + Code**: Zowel de productnaam als de productcode moeten identiek zijn.

## Personen beheren die niet aan een bedrijf zijn gekoppeld

Als personen in de importbron niet worden vermeld met een bedrijf, hebt u drie opties in de keuzelijst **Indien geen bedrijfsnaam**:

* **Bedrijf maken met naam persoon**: Er wordt een bedrijf gemaakt met de naam van de persoon, met hem-/haarzelf als de enige persoon.

* **Overslaan - geen bedrijf of persoon aanmaken**: De persoon wordt niet geïmporteerd.

* **Personen zonder bedrijf importeren**: De persoon wordt geïmporteerd zonder koppeling naar een bedrijf. Deze optie is alleen mogelijk als de algemene voorkeur **Verplicht bedrijf bij persoon** is ingesteld op **Nee**.

## Privacy-opties voor geïmporteerde personen

Wanneer u personen importeert, moet u ook de rechtsgrondslag en de toestemmingsbron instellen voor het doel **Verkopen en service**:

* **Rechtsgrondslag**: Selecteer een [rechtsgrondslag][1] uit de lijst of selecteer **Gebruik standaard** om de standaardwaarde te gebruiken die is gedefinieerd op het scherm Privacy.

* **Toestemmingsbron**: Deze waarde is standaard ingesteld op **Importeren**, maar u kunt een andere waarde selecteren in de lijst.

## Lijstwaarden beheren die niet bestaan in SuperOffice

De importbron kan bijvoorbeeld branches bevatten die niet bestaan in SuperOffice. Vervolgens moet u kiezen hoe nieuwe categorieën, branches, posities, aangepaste lijstwaarden en interesses beheerd moeten worden. In de keuzelijsten onder **Lijsten** vindt u de volgende opties:

* **Nieuw item aan lijst toevoegen**: Nieuwe waarden worden toegevoegd aan SuperOffice.
* **Negeren, standaardwaarde gebruiken**: Nieuwe waarden worden niet geïmporteerd, en de standaardwaarden voor categorie of branche worden gebruikt. U specificeert de standaardwaarde onder **Voorkeuren** > **Standaardwaarden**.

    > [!NOTE]
    > **Positie** heeft geen standaardwaarde.

* **Negeren, instellen op leeg**: Er worden geen nieuwe waarden geïmporteerd in SuperOffice.

## Nieuwe telefoonnummers, koppelingen en e-mailadressen beheren

De importbron kan bijvoorbeeld telefoonnummers, koppelingen en e-mailadressen bevatten die niet zijn geregistreerd in SuperOffice. Aangezien het mogelijk is diverse telefoonnummers, koppelingen en e-mailadressen te registreren voor één bedrijf/persoon, moet u opgeven hoe nieuwe waarden moeten worden beheerd. In de lijsten **Telefoonnummer** en **URL's + e-mail** onder **Lijsten**, heeft u de volgende opties:

* **Nieuw item toevoegen, bestaand item behouden**: Nieuwe waarden worden toegevoegd aan SuperOffice en bestaande waarden worden behouden.
* **Vervangen - bestaande overschrijven**: Bestaande waarden in SuperOffice worden overgeschreven door de bestaande waarden.
    Bijvoorbeeld: Dit kan relevant zijn als u weet dat de import de juiste e-mailadressen voor uw personen bevat. Wanneer de e-mailadressen die in SuperOffice zijn geregistreerd, verouder zijn, kunt u ze overschrijven om het systeem op te schonen.
* **Negeren, bestaand item behouden**: Er worden geen nieuwe waarden geïmporteerd in SuperOffice.

<!-- markdownlint-disable-next-line MD013 -->
## Beheer van productcategorieën, productfamilies en producttypes die niet aanwezig zijn in SuperOffice

De importbron kan bijvoorbeeld productcategorieën bevatten die niet bestaan in SuperOffice. Nu moet u kiezen hoe nieuwe productcategorieën, productfamilies en producttypes beheerd worden. In de keuzelijsten **Nieuwe waarden voor...** heeft u de volgende opties:

* **Nieuw item aan lijst toevoegen**: Nieuwe waarden worden toegevoegd aan SuperOffice.
* **Negeren, instellen op leeg**: Er worden geen nieuwe waarden toegevoegd aan SuperOffice.

<!-- Referenced links -->
[1]: ../../security/privacy/learn/index.md

<!-- Referenced images -->

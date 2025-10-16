---
uid: help-nl-import-products-from-excel
title: Producten importeren uit Excel
description: In deze handleiding leert u hoe u al uw producten, beschrijvingen en product kunt importeren.
keywords: import, product, Excel
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/admin/import/learn/import-products-from-excel
language: nl
---

# Producten importeren uit Excel

[Importeren][2] is een geweldige manier om uw database snel te vullen of bij te werken met prijsinformatie. Als u een Excel-spreadsheet hebt met een lijst van producten, kunt u deze eenvoudig importeren in SuperOffice.

## Voordat u begint

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Voordat u begint met importeren, [bereidt u het Excel-bestand voor][1]. Controlelijst:

* Het Excel-werkblad moet ten minste kolommen bevatten met productcode, productnaam en catalogusprijs.
* Zorg voor een unieke productcode voor iedere rij als duplicaatsleutel.

## Producten exporteren vanuit een Excel-importbestand

Bekijk deze video of volg de stappen om te leren hoe u uw producten importeert in SuperOffice CRM met behulp van onze importsjabloon (videolengte - 4:22):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xOTB6j2zzNo]

1. [!include[Open Import](includes/open-import.md)]

2. Klik op **Producten** onder **Een importbron selecteren**.

3. In **Importeren naar prijslijst**, selecteert u de prijslijst waarnaar u de producten wilt importeren.

4. Klik op het Excel-![pictogram][img1] onder **Een importbron selecteren**.

5. Klik in het dialoogvenster **Bestand uploaden** op **Bestand uploaden** om de Excel-spreadsheet te selecteren die u wilt importeren.

6. Blader naar de gewenste Excel-spreadsheet en klik op **Openen**. Het veld **Bestandsnaam** toont de positie en de naam van het bestand dat u hebt geselecteerd.

7. Klik op **Opslaan**. De gegevens van de spreadsheet worden in de tabel weergegeven en de naam van het importbestand wordt onderaan getoond.

> [!NOTE]
> In deze fase zijn producten uit Excel nog niet geïmporteerd in de SuperOffice-database. SuperOffice uploadt alleen de productenlijst van de spreadsheet, zodat u de importinstellingen kunt opgeven.

## Stel de import bij

Aangezien de Excel-spreadsheet alles kan bevatten van slechts enkele tot een grote hoeveelheid kolommen, is het belangrijk dat de kolommen met de gegevens die u wilt importeren aan het juiste SuperOffice-veld zijn gekoppeld.

> [!NOTE]
> De spreadsheet moet tenminste de door u voor Duplicaatcontrole geselecteerde kolommen bevatten in de procedure hieronder (naam, code, of naam + code).

1. Zoek de kolom met de namen van producten, klik op de kolomtitel **(Geen selectie)** en selecteer **Product: Naam**.

2. Zoek de kolom met de productcodes, klik op de kolomtitel **(Geen selectie)** en selecteer **Product: Code**.

3. Selecteer de SuperOffice-velden voor de resterende kolommen in de tabel. Sla de kolommen over die u niet wilt importeren.

4. [!include[Configure import settings](includes/configure-import-settings.md)]

5. Klik op **Volgende**. Het scherm **Voorbeeld van import** verschijnt.

6. Blader door de importgegevens om eventuele problemen op te lossen voordat het importeren begint.

    | Pictogram | Beschrijving |
    |---|---|
    | <i class="ph ph-warning" aria-label="Warning"></i> | Er is een probleem met de data in deze rij. Zie de uitleg in de koptekst van de tabel. |
    | ![pictogram][img3] | Het product bestaat nog niet en zal worden toegevoegd. |
    | ![pictogram][img4] | Het product bestaat al en zal worden bijgewerkt. |
    | legen | Niet bijwerken. |

7. Verwijder de vinkjes voor de rijen die u NIET wilt importeren. Als de Excel-spreadsheet een rij met een kolomkop bevat, kunt u deze hier verwijderen.

8. Nadat u hebt gecontroleerd of dit echt de gegevens zijn die u wilt importeren, klikt u op **Importeren**.

## Het importeren voltooien

Wanneer het importeren is voltooid, wordt een lijst met de geïmporteerde gegevens getoond. Boven de lijst ziet u een koppeling naar de bijgewerkte prijslijst.

## Gerelateerde inhoud

* [Importinstellingen configureren][3]
* [Importeren vanuit ERP][6]

<!-- Referenced links -->
[1]: create-spreadsheet.md
[2]: index.md
[3]: settings.md
[6]: from-erp.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/import-excel-small.png
[img3]: ../../../media/icons/admin/import-preview-icon-product-new.png
[img4]: ../../../media/icons/admin/import-preview-icon-product-changed.png

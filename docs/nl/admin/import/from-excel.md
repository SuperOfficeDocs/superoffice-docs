---
uid: help-nl-import-from-excel
title: Importeren uit Excel
description: In deze handleiding leert u hoe u al uw prospects, klanten en hun contactpersonen kunt importeren.
keywords: import, Excel, bedrijf, contactpersoon, spreadsheet
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/admin/import/learn/import-from-excel
language: nl
---

# Importeren uit Excel

U kunt [uw klantgegevens in één keer importeren][2] met Excel, Outlook, Gmail of uw ERP Synchronizer in SuperOffice CRM.

De Excel-spreadsheet kan bijvoorbeeld het volgende bevatten:

* Een lijst met leads/prospects die u wilt importeren in SuperOffice.

    > [!TIP]
    > Voeg een kolom toe met bijvoorbeeld de tekst "Prospect" voor alle personen, waardoor u hen makkelijk kunt koppelen aan de juiste categorie in SuperOffice CRM.

* Een lijst met bedrijven/contactpersonen met "opgeschoonde" gegevens (geëxporteerd en gecontroleerd op kwaliteit, en wordt opnieuw geïmporteerd).

* Bedrijven en contacten van andere applicaties en indelingen, zoals financiële systemen, andere CRM-clients, e-mail-clients (anders dan Gmail en Outlook) en Windows-installaties van SuperOffice CRM.

## Voordat u begint

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Voordat u begint met importeren, [bereidt u het Excel-bestand voor][1]. Controlelijst:

* De Excel-spreadsheet moet minimaal kolommen bevatten met bedrijfsnamen en namen van personen (voornaam en achternaam).

* Controleer of de gegevens up-to-date zijn. Zijn bijvoorbeeld de postadressen en telefoonnummers correct?

## Bedrijven/personen importeren vanuit een Excel-bestand

Bekijk deze video of volg de onderstaande stappen om te leren hoe u uw contactpersonen importeert in SuperOffice CRM met behulp van onze importsjabloon (videolengte - 4:02):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/dVkCfpOkNl8]

### Stappen

1. [!include[Open Import](includes/open-import.md)]

2. Zorg ervoor dat **Personen** is geselecteerd onder **Een importbron selecteren** en klik vervolgens op het Excel-![pictogram][img1].

3. Klik in het dialoogvenster **Bestand uploaden** op **Bestand uploaden** om de Excel-spreadsheet te selecteren die u wilt importeren.

4. Blader naar de gewenste Excel-spreadsheet en klik op **Openen**. De gegevens van de spreadsheet worden in de tabel weergegeven.

> [!NOTE]
> In deze fase zijn bedrijven/personen uit Excel nog niet geïmporteerd in de SuperOffice-database. SuperOffice uploadt alleen de bedrijven-/personenlijst van de spreadsheet, zodat u de importinstellingen kunt opgeven.

## Stel de import bij

Aangezien de Excel-spreadsheet alles kan bevatten van slechts enkele tot een grote hoeveelheid kolommen, is het belangrijk dat de kolommen met de gegevens die u wilt importeren aan het juiste SuperOffice-veld zijn gekoppeld.

> [!NOTE]
> Als de Excel-spreadsheet bovenaan een rij met koppen had, wordt deze ook weergegeven in de lijst. U kunt deze weghalen wanneer u de gegevens bekijkt in de volgende stap.

1. Zoek de kolom met de namen van bedrijven, klik op de kolomtitel **(Geen selectie)** en selecteer **Bedrijf: Naam**.

1. Zoek de kolom met de voor- en achternamen, klik op de kolomtitel **(Geen selectie)** en selecteer **Persoon: Voornaam** en **Persoon: Achternaam**. Als er één kolom is met zowel voor- als achternamen, selecteer dan **Persoon: Volledige naam**.

1. Selecteer de SuperOffice-velden voor de resterende kolommen in de tabel. Sla de kolommen over die u niet wilt importeren.

1. [!include[Configure import settings](includes/configure-import-settings.md)]

1. [!include[Enter concent comment](includes/step-concent-comment.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Verwijder de vinkjes voor de rijen die u NIET wilt importeren. Als de Excel-spreadsheet een rij met een kolomkop bevat, kunt u deze hier verwijderen.

1. Als u hebt gecontroleerd of dit echt de gegevens zijn die u wilt importeren, klikt u op **Importeren**.

### Troubleshooting

[!include[Contacts without icons](includes/troubleshoot-import.md)]

**Ik kom niet verder!**

U moet alle verplichte SuperOffice-velden aan de bijbehorende kolommen koppelen om door te gaan. De verplichte velden worden boven de tabel weergegeven. Als u hebt gespecificeerd dat personen zonder bedrijven moeten worden toegevoegd als nieuwe bedrijven, is alleen het SuperOffice-veld **Bedrijf: Naam** verplicht.

## Het importeren voltooien

[!include[Step: complete the import](includes/import-complete.md)]

## Gerelateerde inhoud

* [Importinstellingen configureren][3]
* [Importeren uit Outlook][4]
* [Importeren vanuit Gmail][5]
* [Importeren vanuit ERP][6]

<!-- Referenced links -->
[1]: create-spreadsheet.md
[2]: index.md
[3]: settings.md
[4]: from-outlook.md
[5]: from-gmail.md
[6]: from-erp.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/import-excel-small.png

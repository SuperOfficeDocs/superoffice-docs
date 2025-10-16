---
uid: help-nl-import-from-erp
title: Importeren vanuit ERP
description: Importeren vanuit ERP
keywords: import, ERP
author: digitaldiina
date: 04.28.2025
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/quote/learn/admin/sync/sync-import-from-erp
language: nl
---

# Importeren vanuit ERP

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Volg de onderstaande stappen om actors (klanten, leveranciers en personen) vanuit een ERP-systeem te importeren in de SuperOffice-database.

## Selecteer actors die moeten worden geïmporteerd vanuit het ERP-systeem

1. [!include[Open Import](includes/open-import.md)]
2. Klik op **ERP synchroniseren** onder **Een importbron selecteren**. Het dialoogvenster **ERP-verbinding selecteren** wordt geopend.

    Als het **ERP Sync** knop niet actief is, moet u synchronisatie uitschakelen in **Offerte/Synchroniseren** > **Sync**-tabblad.

3. Selecteer in de lijst **ERP-verbinding** [de verbinding][2] waaruit u wilt importeren.
4. Selecteer in de lijst **Actor-type** wat u wilt importeren. Bijvoorbeeld klanten, leveranciers of personen.
5. Klik op **OK**. Het dialoogvenster **Zoeken in ERP** wordt weergegeven.
6. [Zoek naar de actors die u wilt importeren][1], zoals alle leveranciers in een bepaalde stad.
7. Selecteer in de lijst met zoekresultaten de rijen die u wilt importeren.
8. Klik op **Import toevoegen**. De actoren worden getoond in Instellingen en onderhoud.

> [!NOTE]
> In deze fase zijn de actors uit het ERP-systeem nog niet geïmporteerd in de SuperOffice-database. SuperOffice laadt de actors die u wilt importeren slechts, zodat u de importinstellingen kunt definiëren.

## De import configureren

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Schakel de selectievakjes uit voor de rijen die u NIET wilt importeren.

1. Nadat u hebt gecontroleerd dat dit echt de gegevens zijn die u wilt importeren, klikt u op **Import**

## Het importeren voltooien

Als de import gereed is, worden er twee lijsten weergegeven:

* Nieuwe actors die werden geïmporteerd.
* Bestaande actors die zijn bijgewerkt door de import.

Boven elke lijst wordt een koppeling weergegeven naar de selectie met de nieuwe/bijgewerkte actors.

> [!TIP]
> Als u geïmporteerde actors uit SuperOffice wilt verwijderen, gebruikt u de selectie.

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: ../../erp/admin/add-connection.md

<!-- Referenced images -->

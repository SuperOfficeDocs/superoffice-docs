---
uid: help-nl-sync-add-erp-connection
title: ERP-verbinding toevoegen (Sync Connector)
description: ERP-verbinding toevoegen (Sync Connector)
author: SuperOffice RnD
date: 06.29.2022
keywords: offerte, synchroniseren, connector, ERP
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# ERP-verbinding toevoegen (Sync Connector)

Elke Sync Connector moet beschikken over een ERP-verbinding met configuratiegegevens om de Sync Connector te koppelen met SuperOffice.

## U voegt een ERP-verbinding als volgt toe

1. Ga naar het tabblad **Synchroniseren** op het scherm Offerte/Synchroniseren.

1. Klik op **Toevoegen** onder aan de lijst **ERP-verbindingen**. Het dialoogvenster **Een nieuwe ERP-verbinding definiëren** wordt weergegeven.

1. Geef de naam van de ERP-verbinding op in het veld **Naam**.

1. Selecteer de vereiste **ERP Sync Connector** in de lijst. Deze lijst is identiek aan **Sync Connectors**.

1. Selecteer de vereiste **Reikwijdte**:

    * **Iedereen**: Selecteer deze optie als alle gebruikers toegang moeten hebben tot deze ERP-verbinding en deze kunnen gebruiken. Dit betekent dat ze de prijslijsten kunnen gebruiken die toegankelijk zijn via deze verbinding.
    * **Specifieke gebruikers + groepen**: Klik op **Gebruikers en groepen selecteren** om te kiezen welke gebruikers en/of gebruikersgroepen toegang moeten hebben tot deze ERP-verbinding.

1. Onder **Configuratievelden** definieert u de vereiste instellingen. De inhoud van deze lijst varieert, afhankelijk van het type Sync Connector dat u hebt gekozen.

1. Type een beschrijving van de ERP-verbinding in het veld onderaan.

1. Klik op **ERP-verbinding testen** om te controleren of de verbinding werkt. Als er een foutbericht wordt weergegeven, moet u eerst het probleem oplossen voordat u doorgaat.

1. Klik op **OK**. De ERP-verbinding wordt weergegeven in de lijst **ERP-verbindingen**.

    > [!NOTE]
    > De knop **OK** blijft uitgeschakeld totdat de ERP-verbindingstest met succes is uitgevoerd.

U moet de kolom **Actief** inschakelen om de verbinding te activeren, zodat het tabblad **ERP** wordt weergegeven in SuperOffice CRM. Voordat u de ERP-verbinding echter activeert, moet u eerst controleren of deze correct is geconfigureerd:

* Geef de synchronisatie-instellingen op en kies welke velden moeten worden weergegeven in het zoekvenster en op het tabblad **ERP**. Zie [Veldtoewijzing configureren][1] en [Lijst toewijzing configureren][2].

* [Definieer de vereiste standaardwaarden][3] voor velden die meestal slechts één relevante waarde hebben, zodat de gebruiker deze waarden niet hoeft in te vullen in deze velden.

* [Selecteer de volgorde van de ERP-velden][4] die worden weergegeven op het ERP-tabblad in SuperOffice CRM.

* Als u meerdere ERP-verbindingen gebruikt, kunt u [prioriteit instellen voor verbindingen][5].

* [Gegevens importeren vanuit het ERP-systeem][6]

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md
[2]: sync-configure-list-mapping.md
[3]: sync-configure-default-values.md
[4]: sync-rank-fields-shown-in-erp-tab.md
[5]: sync-set-sync-priority.md
[6]: ../../../../admin/import/learn/import-from-erp.md

<!-- Referenced images -->

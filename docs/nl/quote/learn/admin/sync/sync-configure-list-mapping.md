---
uid: help-nl-sync-configure-list-mapping
title: Lijsttoewijzing configureren
description: Lijsttoewijzing configureren
author: Bergfrid Dias
so.date: 03.29.2023
keywords: offerte, synchroniseren, connector, ERP, toewijzen
so.topic: howto
so.user: admin
language: nl
---

# Lijsttoewijzing configureren

Wanneer u gegevens synchroniseert tussen SuperOffice en ERP-systemen, moet u opgeven welk SuperOffice-veld en welk ERP-veld bij elkaar hoort.

> [!NOTE]
> Voordat u een ERP-verbinding bewerkt, moet u deze eerst deactiveren.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Selecteer de ERP-verbinding en klik op de knop **Lijsttoewijzing** onderaan.

1. Selecteer een lijst. De beschikbare velditems staan rechts in het dialoogvenster weergegeven.

    Als er geen lijsten worden weergegeven, moet [u veldtoewijzing configureren][1].

1. Selecteer het corresponderende CRM-item voor elk ERP-item.

    > [!NOTE]
    > Toewijzing is "1-op-1". U kunt niet tweemaal hetzelfde CRM-item toewijzen. Dubbel toegewezen lijstitems worden ROOD weergegeven. Selecteer **(Geen selectie)** om een ERP-lijstitem geen toewijzing te geven.

1. Herhaal stappen 4 tot en met 5 om lijstitems voor de volgende lijst toe te wijzen.

1. Schakel **Actief** in voor de ERP-verbinding die u hebt bewerkt.

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md

<!-- Referenced images -->

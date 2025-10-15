---
uid: help-sv-import-from-erp
title: Importera från ERP
description: Importera från ERP
keywords: importera från ERP
author: digitaldiina
date: 04.28.2025
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /sv/quote/learn/admin/sync/sync-import-from-erp
language: sv
---

# Importera från ERP

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Så här importerar du aktörer (kunder, leverantörer och personer) från ett ERP-system till SuperOffice-databasen:

## Välj vilka aktörer som ska importeras från ERP-systemet

1. [!include[Open Import](includes/open-import.md)]
2. Klicka på **ERP Sync** under **Välj en importkälla**. Dialogrutan **Välj ERP-koppling** öppnas.

    Om knappen **ERP Sync** är inaktiv måste du stänga av synkronisering på fliken **Offert/Synk** > **Synk**.

3. [Välj den koppling][2] du vill importera från i listan **ERP-koppling**.
4. Välj vad du vill importera i listan **Aktörtyp**. Du kan välja till exempel kunder, leverantörer eller personer.
5. Klicka på **OK**. Dialogrutan **Sök i ERP** öppnas.
6. [Sök efter de aktörer du vill importera][1], till exempel alla leverantörer i en viss stad.
7. Välj de rader du vill importera i listan med sökresultat.
8. Klicka på **Lägg till import**. Aktörerna visas under Inställningar och underhåll.

> [!NOTE]
> Aktörer från ERP-systemet har inte importerats till SuperOffice-databasen än. SuperOffice läser bara in de aktörer du vill importera så att du kan definiera importinställningarna.

## Konfigurera importen

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Avmarkera de rader du INTE vill importera.

1. Klicka på **Importera** när du har kontrollerat att rätt data har valts.

## Slutför importen

När importen är klar visas två listor:

* Nya aktörer som har importerats
* Befintliga aktörer som har uppdaterats genom importen

Ovanför varje lista finns en länk till urvalet som innehåller de nya/uppdaterade aktörerna.

> [!TIP]
> Använd urvalet om du vill radera importerade aktörer från SuperOffice.

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: ../../erp/admin/add-connection.md

<!-- Referenced images -->

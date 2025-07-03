---
uid: help-sv-erp-update-connection
title: Redigera ERP-koppling
description: Läs hur du ändrar namn, omfång eller konfiguration för en befintlig ERP-koppling i SuperOffice CRM.
keywords: redigera ERP-koppling, uppdatera ERP-inställningar, ändra ERP-koppling, sync connector, ERP-konfiguration, SuperOffice synk
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from: /sv/quote/learn/admin/sync/sync-edit-erp-connection
index: true
---

# Redigera ERP-koppling

Du kan ändra namn, omfång eller konfigurationsvärden för en befintlig ERP-koppling.

> [!NOTE]
> Om kopplingen är aktiv (markerad i kolumnen **Aktiv**) måste du tillfälligt inaktivera den innan du uppdaterar konfigurationsvärden. Kom ihåg att aktivera kopplingen igen när du är klar med konfigurationen.

## Steg

1. I **Inställningar och underhåll**, välj <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offert/Synk** i navigatorn och öppna fliken **Synk**.

1. Markera ERP-kopplingen och klicka på **Konfigurera ERP-koppling**.

1. Uppdatera namn eller omfång efter behov.

1. För att uppdatera connector-specifika konfigurationsfält:

    1. Avmarkera kryssrutan **Aktiv**.
    1. Uppdatera fälten vid behov.
    1. Markera **Aktiv**.
    1. Klicka på **Testa ERP-koppling** och åtgärda eventuella fel.

1. Klicka på **OK** för att spara och stänga dialogrutan.

1. Om du även behöver ändra fältkopplingar, standardvärden eller listkopplingar gör du det nu med knapparna längst ner till vänster. Se [Konfigurera ERP-koppling][1] för mer information.

## Felsökning

### ERP-koppling kan inte sparas

Om knappen **OK** är nedtonad när du lägger till eller redigerar en koppling:

* Kontrollera att testet av kopplingen lyckades.
* Kontrollera att alla obligatoriska konfigurationsfält är ifyllda.
* Bekräfta att alla obligatoriska inställningar (t.ex. synlighet) är angivna.

## Relaterat innehåll

* [Lägg till en Sync Connector och ERP-koppling][2]
* [Koppla företag, kontakter och projekt till ERP-aktörer][3]

<!-- Referenced links -->
[1]: configure.md
[2]: add-connection.md
[3]: ../learn/connect.md

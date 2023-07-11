---
uid: help-sv-sync-configure-default-values
title: synk konfigurera standardvärden
description: synk konfigurera standardvärden
author: Bergfrid Dias
so.date: 03.29.2023
keywords: offert, synk, referens, ERP
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Konfigurera standardvärden för synkronisering

Genom att definiera standardvärden för fält som vanligtvis bara har ett relevant värde, sparar du användarna mycket tid. Det innebär att de inte behöver markera en ruta som alltid ska vara markerad eller att ange en siffra i ett fält som alltid ska innehålla ”30”. Detta är särskilt användbart när man måste ange stora mängder data.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Markera ERP-kopplingen och klicka på knappen **Standardvärden** nederst.

1. I dialogrutan väljer du fliken för den aktör som du vill konfigurera standardvärden för.

1. Klicka på **Lägg till** längst ned i dialogrutan. Dialogrutan **Lägg till standardvärde för synkronisering** visas.

1. **ERP-fält**: här väljer du vilket fält i ERP-systemet du vill definiera ett standardvärde för.

    * **Ange standardvärde**: Markera här för att ange ett standardvärde för ERP-fältet du valde ovan. När du har markerat här, anger du standardvärdet nedan.

    * **Fråga användaren om värde**: markera här om du vill att användaren ska kunna ange ett värde.

    * **Krävs – användaren måste fylla i ett värde**: markera här om du vill att användaren måste ange ett värde i fältet. Om det valda ERP-fältet är obligatoriskt, är det här fältet markerat som standard.

1. Klicka på **OK**.

1. Upprepa steg 5–6 om du vill lägga till fler standardvärden.

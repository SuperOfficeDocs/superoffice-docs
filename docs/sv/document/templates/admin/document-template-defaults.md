---
uid: help-sv-document-template-defaults
title: Standardvärden för nya dokumentmallar
description: Standardvärden för nya dokumentmallar
keywords: numrering, ny räknare, dokumentmall räknare, standardvärden
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: document
topic: template
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /sv/admin/options/learn/number-allocation/document-template-defaults
language: sv
---

# Standardvärden för nya dokumentmallar

Du kan ange [standardvärden][1] för nya dokumentmallar om det behövs. Det innebär att värdet i fältet **Vår ref.** i dialogrutan Dokument ökar med 1 varje gång den här mallen används. Om du inte markerar **Skapa nya räknare automatiskt för nya dokumentmallar** används samma räknare för alla dokumentmallar så att värdet i fältet **Vår ref.** ökar med 1 varje gång en mall används.

> [!NOTE]
> Huruvida fältet **Vår ref.** i dialogrutan Dokument fungerar som räknarfält beror på om mallvariabeln {snum} har definierats för den aktuella mallen. Detta definieras i fönstret Listor: Klicka på **Dokumentmall**. Dubbelklicka sedan på dokumentmallen under **Poster** och redigera fältet **Vår ref (standard)** i dialogrutan **Redigera post**.

## Ange att nya dokumentmallar ska ha egna räknare

1. Gå till Inställningar och underhåll och klicka på <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Systemval**.

1. Välj fliken **Nummertilldelning**.

1. Välj **Skapa nya räknare automatiskt för nya dokumentmallar** längst ner på fliken.

1. Klicka på **Standardvärden**.

1. Markera **Unik** om du vill att värdena i fältet **Vår ref.** ska vara unika. Det är praktiskt när SuperOffice CRM-användarna tilldelar värden själva.

1. Markera **Tillåt tomma** om du vill tillåta tomma räknarfält. Det är praktiskt om räknarvärdena måste vara unika. Om **Tillåt tomma** markeras betyder det att kravet på unika värden inte tillämpas på tomma fält.

1. Markera **Endast läsbart** om du inte vill att SuperOffice CRM-användarna ska kunna skriva in värden själva i fältet **Vår ref.**.

1. Markera **Tilldela** om du vill använda den automatiska räknarfunktionen. Systemet matar då in värdena i fältet **Vår ref.** automatiskt.

    [Se resultaten av olika kombinationer av de här värdena][1].

1. Ange det värde du vill att räknaren ska börja på i fältet **Nästa nummer**.

1. Klicka på **Spara**.

<!-- Referenced links -->
[1]: ../../../admin/options/configure-number-allocation.md

<!-- Referenced images -->

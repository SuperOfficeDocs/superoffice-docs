---
uid: help-sv-sales-guide-edit
title: Redigera eller inaktivera en säljguide
description: Lär dig hur du redigerar eller inaktiverar en säljguide i SuperOffice CRM. Uppdatera faser, händelser och dokument, eller koppla bort guiden från en försäljningstyp med möjlighet att aktivera den igen vid behov.
keywords: redigera säljguide, uppdatera säljguide, inaktivera säljguide, säljguide, guide, arbetsflöde, försäljning
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from:
  - /sv/sale/learn/sales-guide/deactivate
  - /sv/sale/learn/sales-guide/edit
index: true
---

# Redigera eller inaktivera en säljguide

[!include[Must be admin](../../learn/includes/req-admin.md)]

## Redigera en säljguide

1. Välj <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbetsflöde** i navigatorn.
1. Välj fliken **Säljguide**.
1. Välj önskad försäljningstyp i listan **Försäljningstyp**.
1. Klicka på **Redigera**.
1. [Redigera de enskilda faserna][3].
1. Redigera händelser och dokument genom att dubbelklicka på dem i listorna längst ned.

    * [Lägg till en händelse för en fas][1]
    * [Lägg till ett dokument för en fas][2]

   Ändringarna sparas automatiskt.

## Inaktivera en säljguide

Om du vill ta bort en säljguide från en [försäljningstyp][5] följer du dessa steg:

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.
1. Välj **Försäljning – Försäljningstyp (för faser)** i rullgardinsmenyn. Fliken **Poster** visar alla befintliga försäljningstyper.
1. Dubbelklicka på försäljningstypen som är kopplad till guiden du vill inaktivera. Dialogrutan **Redigera listpost** öppnas.
1. Avmarkera **Denna försäljningstyp har en anknuten guide**.
1. (Valfritt) Uppdatera andra fält vid behov.
1. Klicka på **Spara** för att tillämpa ändringarna eller **Avbryt** för att ignorera dem.

> [!NOTE]
> Om du senare vill återanvända säljguiden markerar du alternativet igen. Alla händelser och dokument som tidigare lagts till i säljguidens faser hämtas automatiskt vid återaktivering. Du kan även lägga till nya händelser och dokument eller ta bort de som inte längre är relevanta.

<!-- Referenced links -->
[1]: create-sales-guide.md#add-fo-stage
[2]: create-sales-guide.md#add-doc-stage
[3]: sale-stage.md
[5]: sale-type.md

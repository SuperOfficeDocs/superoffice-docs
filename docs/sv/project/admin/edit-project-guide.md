---
uid: help-sv-project-guide-edit
title: Redigera eller inaktivera en projektguide
description: Lär dig hur du redigerar eller inaktiverar projektguider i SuperOffice CRM. Ändra statusar, händelser och dokument, eller inaktivera guider för specifika projekttyper samtidigt som du behåller flexibiliteten att återaktivera dem.
keywords: redigera projektguide, uppdatera projektguide, inaktivera projektguide, projektguide, guide, arbetsflöde, projekt
author: Bergfrid Dias
date: 02.25.2025
version: 10.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from:
  - /sv/project/learn/project-guide/deactivate
  - /sv/project/learn/project-guide/edit
---

# Redigera eller inaktivera en projektguide

[!include[Must be admin](../../learn/includes/req-admin.md)]

## Redigera en projektguide

1. Klicka på <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbetsflöde** i navigatorn.
1. Välj fliken **Projektguide**.
1. Välj önskad projekttyp i listan högst upp.
1. [Redigera information om projekttypen och dess statusar][3].
1. [Redigera de enskilda statusarna][3].
1. Redigera händelser och dokument genom att dubbelklicka på dem i listorna längst ned.

    * [Lägg till en händelse för en status][2]
    * [Lägg till ett dokument för en status][1]

    Ändringarna sparas automatiskt.

## Inaktivera en projektguide

Om du vill ta bort en projektguide från en [projekttyp][4], gör följande:

1. Klicka på <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.

1. Välj **Projekt – Typ, status** i rullgardinsmenyn. På fliken **Element** visas alla befintliga projekttyper.

1. Dubbelklicka på projekttypen som är kopplad till guiden du vill inaktivera. Dialogrutan **Redigera listobjekt** öppnas.

1. Avmarkera **Denna projekttyp har en anknuten guide**.

1. (Valfritt) Uppdatera andra fält vid behov.

1. Klicka på **Spara** för att tillämpa ändringarna eller **Avbryt** för att ignorera dem.

> [!NOTE]
> Om du senare vill återanvända projektguiden markerar du helt enkelt alternativet igen. Alla händelser och dokument som tidigare lagts till i projektguidens statusar hämtas automatiskt vid återaktivering. Du kan också lägga till nya händelser eller dokument, eller ta bort de som inte längre är relevanta.

<!-- Referenced links -->
[1]: create-project-guide.md#add-doc-status
[2]: create-project-guide.md#add-fo-status
[3]: project-status.md
[4]: project-type.md

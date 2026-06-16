---
uid: help-sv-webhook-create
title: Skapa webhook
description: Skapa en webhook i Inställningar och underhåll utan att skriva kod eller anropa API:et.
keywords: skapa webhook, redigera webhook, avisering, händelse
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: howto
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
---

# Skapa webhook

Du kan skapa och hantera webhook-prenumerationer direkt i **Inställningar och underhåll**, utan att skriva kod eller anropa API:et.

> [!NOTE]
> Om du vill redigera en befintlig webhook högerklickar du på webhook-raden i listan **Webhooks** och väljer **Redigera**. Formuläret öppnas med alla aktuella värden förifyllda.

## Steg

1. Gå till **Inställningar och underhåll** > **System design** och välj fliken **Webhooks**.

1. Klicka på **Lägg till**.

    ![Nytt webhook-formulär i Inställningar och underhåll -screenshot][img1]

1. Ange ett **Webhook-namn** för att identifiera webhook'en (obligatoriskt). Maximalt 100 tecken.

1. Du kan även lägga till en **Beskrivning**. Den visas i Webhooks-panelen.

1. **Händelser som utlöser denna webhook** (obligatoriskt).

    Välj en eller flera händelser från listan **Lägg till händelse**. Varje vald händelse visas som en tagg. Om du vill ta bort en händelse väljer du **x** på taggen.

    > [!TIP]
    > Du kan också skriva in ett anpassat händelsenamn direkt i fältet och trycka **Enter**.

1. **Ange destination** (obligatoriskt).

    Välj var webhook'en ska levereras:

    * **Extern URL:** Ange **Slutpunkts-URL**:en. URL:en måste använda HTTPS och ha ett giltigt TLS-certifikat. Slutpunkten valideras när du sparar — en otillgänglig eller felbringande URL förhindrar sparande. Välj **Skicka test** för att verifiera anslutningen innan du sparar.
    * **CRMScript:** Välj ett skript från listan.

1. **Felmeddelande** (obligatoriskt).

    Ange vem som ska aviseras, hur de nås och när aviseringen ska skickas.

    * **Mottagare:** Lägg till CRM-användare eller ange externa e-postadresser. Mottagare visas som taggar.
    * **Meddela via:** Välj aviseringskanal.
    * **Aktivera förvarning:** Välj ett eller båda alternativen:
      * **Vid första felet:** Skickar en avisering första gången webhook'en misslyckas med att leverera.
      * **När funktionen är inaktiverad:** Skickar en avisering om webhook'en automatiskt inaktiveras efter upprepade fel.

    ![Webhook-formulär med händelser, destination och felavisering konfigurerade -screenshot][img2]

1. (Valfritt) Expandera **Säkerhet och avancerade inställningar**.

    * **Delad hemlighet:** Välj **Generera** för att skapa ett kryptografiskt slumpmässigt värde för signering av varje nyttolast. Hemligheten visas bara vid skapandet — kopiera den omedelbart. Om du vill ersätta den senare väljer du **Regenerera**.
    * **Anpassade rubriker:** Nyckel-värdepar som läggs till i varje HTTP POST-anrop. Tillgängligt bara för Extern URL-webhooks.
    * **Anpassade egenskaper:** Ytterligare data injicerad i varje nyttolast.

    ![Avsnittet Säkerhet och avancerade inställningar expanderat -screenshot][img3]

1. (Valfritt) Stäng av **Aktiv**-reglaget (övre högra hörnet) för att spara webhook'en i tillståndet *Stoppad*.

1. Klicka på **Spara**.

    ![Leveransstatus visad under Aktiv-reglaget efter sparande -screenshot][img4]

Efter sparandet visas leveransstatusinformation under **Aktiv**-reglaget. Klicka på **Tillbaka till Webhooks** längst upp för att återgå till listan.

## Relaterat innehåll

* [Webhooks-panel][1]
* [Registrera en webhook via API:et][2]
* [Skapa ett CRMScript][3]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../../en/automation/webhook/dev/register.md
[3]: ../../../customization/macros-and-scripts/admin/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/automation/new-webhook-required-fields.png
[img2]: ../../../../media/loc/en/automation/create-webhook-in-ui.png
[img3]: ../../../../media/loc/en/automation/webhook-advanced-settings.png
[img4]: ../../../../media/loc/en/automation/webhook-delivery-status.png

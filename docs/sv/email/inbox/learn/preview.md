---
uid: help-sv-email-inbox-preview
title: Visa e-postmeddelanden
description: Läs om hur du förhandsgranskar, flyttar, markerar och skriver ut e-postmeddelanden i SuperOffice Inkorg
keywords: öppna e-post, visa e-post, förhandsgranska, flytta e-post, markera som läst, skriv ut, e-post, SuperOffice Inkorg, inkorg
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/email/inbox/learn/mark-as-read
  - /sv/email/inbox/learn/move-email-to-folder
  - /sv/email/inbox/learn/print
---

# Visa e-postmeddelanden

När du markerar ett e-postmeddelande i inkorgen visas en förhandsgranskning av meddelandet till höger på skärmen. Dubbelklicka på ett meddelande för att öppna det i ett separat fönster.

![Förhandsgranskning av e-post med markerat meddelande och tillgängliga åtgärder -screenshot][img1]

## Förhandsgranskningsfönster

Förhandsgranskningen visar innehållet i det markerade meddelandet, inklusive mottagare, bilagor och annan information.

Om avsändaren finns i SuperOffice CRM kan du hålla muspekaren över namnet för att visa [kontaktkortet][9].

### Visa inbäddade bilder

Så här visar du inbäddade bilder i förhandsgranskningsfönstret:

1. Klicka på <i class="ph ph-user-circle" aria-hidden="true"></i> i toppraden och välj **Alternativ för e-post**.
1. Gå till fliken **Allmänt**.
1. Markera rutan **Visa interna bilder**.
1. Klicka på **OK** för att spara inställningen.

![Alternativ för e-post: fliken Allmänt -screenshot][img2]

### Öppna en bilaga

Bilagor visas under brevhuvudet när ett meddelande är markerat.

1. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid filnamnet.
1. Välj **Förhandsgranska** för att öppna den bifogade filen direkt i webbläsaren.

    Beroende på filtyp och webbläsarinställningar kan vissa filer, som PDF, öppnas i en ny flik.

> [!TIP]
> Du kan även välja **Ladda ned** för att spara filen eller **Arkivera** för att [spara den som ett dokument i SuperOffice CRM][2].

## <a id="mark-as-read"></a>Markera e-post som läst eller oläst

E-postmeddelanden **markeras inte automatiskt som lästa** om du inte aktiverar inställningen.

### Aktivera automatisk markering

1. Gå till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Alternativ för e-post** > **Allmänt**.
1. Markera **Markera som läst i förhandsgranskning**.
1. Klicka på **OK**.

### Markera meddelanden manuellt

* För ett enskilt meddelande:
    1. Markera meddelandet.
    1. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> och välj **Markera som läst/oläst**.

    ![Åtgärdsmeny med alternativ för att markera och flytta -screenshot][img3]

* För flera meddelanden:
    1. Använd **Ctrl+Klick** (Windows) eller **Cmd+Klick** (Mac) för att välja flera meddelanden.
    1. Använd knapparna **Markera som läst** eller **Markera som oläst** i meddelanderutan.

    ![Alternativ för att flytta, markera och ta bort flera markerade e-postmeddelanden -screenshot][img4]

## <a id="move"></a>Flytta e-post till en mapp

Du kan flytta meddelanden till andra mappar i ditt e-postkonto.

Mappstrukturen hämtas från din e-postleverantör (till exempel Outlook eller Gmail). Du kan inte skapa, byta namn på eller ta bort mappar i SuperOffice CRM. Gör dessa ändringar direkt i ditt e-postkonto.

### Flytta ett enskilt meddelande

1. Markera ett meddelande i inkorgen.
1. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> och välj **Flytta till mapp**.
1. Välj önskad mapp.

    > [!CAUTION]
    > Om mappnamnet är gråmarkerat är den inte synkroniserad.
    >
    > Klicka på mappen ovanför e-postlistan och välj ikonen **Prenumerera** (<i class="ph ph-cloud-slash" aria-label="Cloud"></i>) i nedre högra hörnet för att aktivera synkronisering.

### Flytta flera meddelanden

1. Markera flera meddelanden med **Ctrl+Klick** (Windows) eller **Cmd+Klick** (Mac).
1. Använd knappen **Flytta till mapp** i meddelanderutan.

## <a id="print"></a>Skriv ut ett e-postmeddelande

1. Markera ett meddelande i inkorgen.
1. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> och välj **Skriv ut valt e-postmeddelande**.
1. Meddelandet öppnas i ett förhandsgranskningsfönster i webbläsaren.
1. Använd webbläsarens alternativ för att skriva ut.

## Relaterat innehåll

* [Hantera avsändare][1]
* [Ta emot inbjudningar][3]
* [Skapa uppgift][4]
* [Skapa ärende][5]

<!-- Referenced links -->
[1]: manage-senders.md
[2]: archive.md#attachment
[3]: invitations.md
[4]: create-task.md
[5]: create-request.md
[9]: ../../../contact/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-preview-message.png
[img2]: ../../../../media/loc/en/email/email-options-general.png
[img3]: ../../../../media/loc/en/email/inbox-message-task-menu.png
[img4]: ../../../../media/loc/en/email/inbox-multiselect-actions.png

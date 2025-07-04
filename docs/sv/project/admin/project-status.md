---
uid: help-sv-project-status
title: Projektstatus
description: Lär dig hur du lägger till en ny projektstatus i SuperOffice CRM. Skapa och hantera fördefinierade statusar för att följa projektets faser och effektivisera arbetsflödet.
keywords: lägg till projektstatus, projektstatus, projekt, listan Projekt - Status
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from:
  - /sv/admin/lists/learn/project-status
  - /sv/project/learn/screen/project-status-admin
---

# Projektstatus

[!include[Must be admin](../../learn/includes/req-admin.md)]

Fältet **Status** i **Projekt**-fönstret hjälper till att kategorisera och spåra ett projekts framsteg. Dessa statusar definieras i listan **Projekt - Status**, som du hanterar i **Inställningar och underhåll** under **Listor**.

Statusar kan kopplas till [projekttyper][1] för att bestämma vilka statusar som är tillgängliga för varje typ. Om ingen projektguide är definierad, är fältet **Status** fortfarande synligt i projektet och kan uppdateras manuellt.

## Lägg till en status

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.

1. Välj **Projekt - Status** i rullgardinsmenyn. Fliken **Poster** visar alla befintliga statusar.

1. Klicka på **Lägg till** för att öppna dialogrutan **Redigera listpost**.

1. I fältet **Namn**, ange namnet på den nya statusen. *(Obligatoriskt)*

    Detta namn visas i fältet **Status** i **Projekt**-fönstret.

1. *(Valfritt)* Lägg till en beskrivning i fältet **Beskrivning** för att förklara statusens syfte.

1. Klicka på **Spara** för att spara ändringarna eller **Avbryt** för att ångra dem.

## Redigera eller ta bort en status

1. Följ steg 1–2 i **Lägg till en status** för att öppna listan **Projekt - Status**.

1. För att redigera:
    1. Dubbelklicka på önskad status för att öppna dialogrutan **Redigera listpost**.
    1. Uppdatera fälten vid behov och klicka på **Spara**.

1. För att ta bort:
    1. Markera statusen i listan och klicka på **Ta bort**.

    > [!CAUTION]
    > Om du tar bort en status tas den bort från alla kopplade projekttyper och projektguider. Kontrollera att statusen inte används i aktiva projekt innan du fortsätter.

## Återställ en borttagen projektstatus

Om en projektstatus har tagits bort kan du återställa den från listan **Projekt - Status**. Observera att återställning **inte** automatiskt återställer kopplingar till projekttyper eller guider. Du måste återskapa dessa länkar manuellt vid behov.

Stegen liknar de för att [återställa en borttagen projekttyp][2].

## Relaterat innehåll

* [Lägg till eller uppdatera projekttyper][1]
* [Skapa en projektguide][3]
* [Redigera en projektguide][4]
* [Flytta ett projekt till nästa status][5]

<!-- Referenced links -->
[1]: project-type.md
[2]: project-type.md#restore
[3]: create-project-guide.md
[4]: edit-project-guide.md
[5]: ../learn/project-guides.md#change-status

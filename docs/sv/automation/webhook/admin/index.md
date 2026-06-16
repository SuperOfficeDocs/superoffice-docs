---
uid: help-sv-webhook-panel
title: Webhooks-panel
description: Visa, hantera och övervaka webhooks från Inställningar och underhåll.
keywords: webhook-panel, webhook-status, inaktiverad webhook, starta om webhook, övervaka webhooks
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: concept
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
---

# Webhooks-panel

Webhooks-panelen är den centrala platsen för administratörer och konsulenter att hantera webhook-prenumerationer i SuperOffice. Du hittar den under **Inställningar och underhåll** > **System design** > **Webhooks**.

Från den här panelen kan du se tillståndet för alla webhooks på ett ögonblick, skapa nya prenumerationer, redigera befintliga och återställa webhooks som automatiskt har inaktiverats på grund av leveransfel.

![Översikt över Webhooks-panel i Inställningar och underhåll -screenshot][img1]

## Webhook-listan

Listan visar alla registrerade webhooks. Du kan sortera och filtrera efter valfri kolumn.

| Kolumn | Beskrivning |
| --- | --- |
| Namn | Webhookens visningsnamn. |
| Status | Statusmärke som visar aktuellt tillstånd. |
| Antal händelser | Antalet händelsetyper som webhook'en prenumererar på. |
| Mål-URL | Destinations-URL eller CRMScript-namn. |
| Senaste händelse | Tidsstämpel för det senaste leveransförsöket. |
| Flera fel i rad | Antal på varandra följande leveransfel de senaste 24 timmarna. |
| Uppdaterat av | Vem som senast ändrade webhook'en. |

## Statusmärken

Varje webhook har ett statusmärke som visar det aktuella tillståndet.

| Status | Färg | Innebörd |
| --- | --- | --- |
| Aktiv | Grön | Körs utan fel de senaste 24 timmarna. |
| Aktiv med fel | Gul | Körs men har haft leveransfel de senaste 24 timmarna. |
| Stoppad | Grå | Manuellt stoppad av en administratör. |
| Inaktiverad | Röd | Automatiskt inaktiverad av systemet efter 9 på varandra följande leveransfel. |

## Snabbmenyåtgärder

Högerklicka på en webhook-rad för att komma åt följande åtgärder.

| Åtgärd | Beskrivning |
| --- | --- |
| Redigera | Öppnar webhook-formuläret med alla aktuella värden förifyllda. |
| Kopiera | Skapar en kopia med "(copy)" tillagt till namnet. Kopian skapas i tillståndet Stoppad. |
| Aktivera/stoppa | Startar eller stoppar leverans för webhook'en. |
| Starta om | Återaktiverar en inaktiverad webhook. Visas bara när webhook-statusen är Inaktiverad. |
| Ta bort | Tar bort webhook'en permanent. En bekräftelse visas innan borttagningen. |

## Leveranshistorik

Välj en webhook-rad för att öppna detaljpanelen. Fliken **Händelser** visar en leveranslogg per webhook.

| Kolumn | Beskrivning |
| --- | --- |
| Tidsstämpel | När leveransen försöktes. |
| Status | Resultatet av försöket. |
| Försök | Antal leveransförsök för den här händelsen. |
| Felkod | Felet som returnerades om leveransen misslyckades. |

Du kan försöka med enskilda misslyckade händelser igen direkt från listan och exportera hela listan till CSV.

## Automatisk inaktivering och återställning

Om en webhook tar emot 9 på varandra följande leveransfel inaktiverar systemet den automatiskt. Raden visar en felräknare (till exempel 7/9) och det senaste felet.

Så här återställer du en inaktiverad webhook:

1. Lös problemet som orsakade leveransfelen.
1. Högerklicka på webhook-raden och välj **Starta om**.

Webhook'en återgår till Aktiv-status och återupptar normal leverans.

## Aviseringar i SuperOffice

Aviseringsmottagare ser en avisering i SuperOffice när en webhook automatiskt inaktiveras. Välj aviseringen för att öppna Webhooks-panelen.

## Relaterat innehåll

* [Skapa webhook][1]
* [Webhooks utvecklarguide][2]

<!-- Referenced links -->
[1]: create.md
[2]: ../dev/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-system-design-webhook-overview.png

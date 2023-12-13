---
uid: help-da-follow-up-alarms
title: Indstilling af alarmer for opfølgning
description: Sådan indstiller du en alarm til opfølgning i SuperOffice.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: dagbog, opfølgning, alarm, notifikation
so.topic: howto
language: da
---

# Indstilling af alarmer for opfølgninger

SuperOffice CRM kan minde dig inden starten af dit møde. Ved den indstillede ledetid vises en systemmeddelelse på din enhed.

![SuperOffice-browsermeddelelse -screenshot][img4]

For videomøder vises en meddelelse fra mødesystemudbyderen (som Microsoft Teams) ved mødets start. Klik på **Deltag** i mødet-knappen for at deltage, eller hvis du er værten, skal du klikke på **Start mødet**.

## Trin

[!include[Recurrence](includes/note-repetition.md)]

<!-- markdownlint-disable MD051 -->
### [Klassisk](#tab/old)

1. [Åbn eller opret en opfølgning][1].
1. Vælg fanen **Detaljer**.
1. Marker i **Alarm**-afkrydsningsfeltet.
1. I feltet ved siden af afkrydsningsfeltet tilføj antallet af timer og minutter før dit møde, du ønsker at blive påmindet.

    Standardværdien er 10 minutter, men du kan ændre den.

1. Klik på **Gem**.

![Du kan indstille en alarm for at blive underrettet, før dit møde begynder -screenshot][img2]

### [Ny (fra version 10.2.11 pilot)](#tab/new)

1. [Åbn eller opret en opfølgning][1].
1. Klik på klokkeikonet i overskriften og vælg et tidspunkt.
1. Klik på **Gem**.

![Alarm nedtrekksliste i opfølgningsdialogens overskrift -screenshot][img3]

***
<!-- markdownlint-restore -->

> [!NOTE]
> Opfølgningspåmindelser (alarmer) er ikke det samme som [aktivitetsmeddelelser][2], der vedrører nye eller opdaterede mødeinvitationer vist i meddelelsespanelet inde i SuperOffice.

<!-- Referenced links -->
[1]: create-follow-up.md
[2]: ../../learn/basics/notifications.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/diary/appointment-alarm-on-meeting.png
[img3]: ../../../media/loc/en/diary/set-alarm-in-header.png
[img4]: ../../../media/loc/en/diary/edge-meeting-alarm.png

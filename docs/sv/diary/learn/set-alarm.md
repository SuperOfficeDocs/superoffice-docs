---
uid: help-sv-follow-up-alarms
title: Ställa in alarm för händelser
description: Så ställer du in ett alarm för en händelse i SuperOffice.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: kalender, händelse, alarm, avisering
so.topic: howto
language: sv
---

# Ställa in alarm för händelser

SuperOffice CRM kan påminna dig innan ditt möte börjar. Vid den angivna ledtiden visas en systemnotis på din enhet.

![SuperOffice webbläsarnotis -screenshot][img4]

För videomöten kommer en notis från mötessystemleverantören (som Microsoft Teams) att visas vid mötets början. Klicka på **Gå med i mötet**-knappen för att delta eller, om du är värd, klicka på **Starta mötet**.

## Steg

[!include[Recurrence](includes/note-repetition.md)]

<!-- markdownlint-disable MD051 -->
### [Klassisk](#tab/old)

1. [Öppna eller skapa en uppföljning][1].
1. Välj fliken **Detaljer**.
1. Markera **Alarm**-kryssrutan.
1. I fältet bredvid kryssrutan lägg till antalet timmar och minuter före ditt möte du vill bli påmind om.

    Standardvärdet är 10 minuter, men du kan ändra det.

1. Klicka på **Spara**.

![Du kan ställa in en påminnelse för att bli meddelad innan ditt möte börjar -screenshot][img2]

### [Ny (från version 10.2.11 pilot)](#tab/new)

1. [Öppna eller skapa en uppföljning][1].
1. Klicka på klockikonet i sidhuvudet och välj en tid.
1. Klicka på **Spara**.

![Alarm nedrullningslista i uppföljningsdialogens sidhuvud -screenshot][img3]

***
<!-- markdownlint-restore -->

> [!NOTE]
> Händelsespåminnelser (larm) är inte samma som [aktivitetsnotiser][2], vilka gäller nya eller uppdaterade mötesinbjudningar som visas i meddelandepanelen inuti SuperOffice.

<!-- Referenced links -->
[1]: create-follow-up.md
[2]: ../../learn/basics/notifications.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/diary/appointment-alarm-on-meeting.png
[img3]: ../../../media/loc/en/diary/set-alarm-in-header.png
[img4]: ../../../media/loc/en/diary/edge-meeting-alarm.png

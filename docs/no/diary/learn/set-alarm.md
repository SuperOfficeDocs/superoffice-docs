---
uid: help-no-follow-up-alarms
title: Still inn alarmer for oppfølging
description: Slik stiller du en alarm for oppfølging i SuperOffice.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: dagbok, oppfølging, alarm, varsling
so.topic: howto
language: no
---

# Stille inn alarmer for oppfølginger

SuperOffice CRM kan minne deg før møtet starter. Ved den angitte ledetiden vises en systemvarsling på enheten din.

![SuperOffice nettleservarsel -screenshot][img4]

For videomøter vises en varsling fra møtesystemleverandøren (som Microsoft Teams) ved møtets start. Klikk på **Bli med** i møtet-knappen for å delta, eller hvis du er verten, klikk på **Start møtet**.

## Trinn

[!include[Recurrence](includes/note-repetition.md)]

<!-- markdownlint-disable MD051 -->
### [Klassisk](#tab/old)

1. [Åpne eller opprett en oppfølging][1].
1. Velg fanen **Detaljer**.
1. Merk av i **Alarm**-boksen.
1. I feltet ved siden av avmerkingsboksen, legg til antall timer og minutter før møtet du ønsker å bli påminnet.

    Standard er 10 minutter, men du kan endre det.

1. Klikk på **Lagre**.

![Du kan sette en alarm for å bli varslet før møtet begynner -screenshot][img2]

### [Ny (fra version 10.2.11 pilot)](#tab/new)

1. [Åpne eller opprett en oppfølging][1].
1. Klikk på bjelleikonet i overskriften og velg en tid.
1. Klikk på **Lagre**.

![Alarm nedtrekksliste i oppfølgingsdialogens overskrift -screenshot][img3]

***
<!-- markdownlint-restore -->

> [!NOTE]
> Oppfølgingspåminnelser (alarmer) er ikke det samme som [aktivitetsvarsler][2], som gjelder nye eller oppdaterte møteinvitasjoner som vises i varslingsruten inne i SuperOffice.

<!-- Referenced links -->
[1]: create-follow-up.md
[2]: ../../learn/basics/notifications.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/diary/appointment-alarm-on-meeting.png
[img3]: ../../../media/loc/en/diary/set-alarm-in-header.png
[img4]: ../../../media/loc/en/diary/edge-meeting-alarm.png

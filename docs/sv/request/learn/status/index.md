---
uid: help-sv-request-status
title: Ärendestatus
description: Ärendestatus
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: ärende, status
so.topic: concept
so.user: admin
so.user.tooltip: Settings and maintenance
language: sv
---

# Ärendestatus

Alla ärenden som registreras i SuperOffice har en status som t.ex. **Aktivt**, **Stängt** eller **Uppskjutet**. Välj **Ärende** i navigatorn och i fliken **Ärendestatus**, så kan du se de ärendestatusar som redan har definierats i systemet och skapa ytterligare ärendestatusar. En ärendestatus måste kopplas till någon av systemets interna statusar, t.ex. **Aktivt** eller **Avslutat**. Varje intern status måste länkas till minst en ärendestatus.

Du kan t.ex. skapa en ny status som heter "Väntar på svar" som är en mer detaljerad variant av **Avslutat** eller **Aktivt**, beroende på hur du vill att systemet ska hantera och rapportera denna status internt. Du kan även koppla egendefinierad logik till sådana statusar för att rationalisera processer i verksamheten.

## Inställningar

| Inställning | Beskrivning |
|---|---|
| Namn | Namn på den ärendestatusen. Varje intern status har som standard en ärendestatus med samma namn. |
| Intern status | Systemets interna statusar. Varje intern status måste länkas till minst en ärendestatus. Systemstatusen **Sammanslagna** och **Borttaget** används bara för ihopslagna ärenden och borttagna ärenden, och visas inte för användarna. |
| Standard | Anger om detta är en standardstatus för intern status. |
| Köstatus | Anger om ärenden med denna status ska placeras i kön. Aktuellt om du använder funktionen **Hämta nästa ärende i kön**. |
| Spåra tid som | Används för att rapportera hur mycket tid som går åt i olika faser av ärendehanteringen. Systemet beräknar den använda tiden i förhållande till både definierade "öppettider" och hela 24-timmarsperioden. Välj mellan: i kö och väntar på handläggning; i intern beslutsfas; i extern beslutsfas |

## Vad vill du göra nu?

* [Skapa ärendestatus][1]
* [Ta bort ärendestatus][2]
* [Konfigurera Hämta nästa ärende i kön][3].

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../next-in-queue.md

<!-- Referenced images -->

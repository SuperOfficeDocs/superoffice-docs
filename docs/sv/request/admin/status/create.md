---
uid: help-sv-request-status-create
title: Skapa ärendestatus
description: Lär dig hur du skapar en ärendestatus i den här steg-för-steg-guiden.
keywords: skapa ärendestatus, ny ärendestatus, lägga till ärendestatus, ärendestatus, intern status, köstatus, registrera tid, ärende, status
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: serviceessentials
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from: /sv/request/learn/status/create
---

# Skapa ärendestatus

## Steg

1. Klicka på knappen **Ärenden** i navigatören.

1. Välj fliken **Ärendestatus**.

1. Klicka på **Lägg till**-knappen.

1. I fältet **Namn** anger du ett beskrivande namn för ärendestatusen.

1. I listan **Intern status** väljer du vilken av de interna statusarna som du vill koppla den anpassade ärendestatusen till.

1. Markera **Standard** om du vill att denna ärendestatus ska vara standardstatusen för den interna status den representerar.

1. Markera **Köstatus** om ärenden med denna status ska placeras i kön.

1. Markera **Skapa nytt ärende vid kundsvar** om du vill förhindra att gamla ärenden öppnas igen när en kund svarar på ett gammalt meddelande. Detta kan vara lämpligt för statusar som **Avslutat** och **Borttaget**.

1. I listan **Registrera tid som** väljer du hur tidsanvändning ska rapporteras:

    * I kö och väntar på handläggning
    * I intern beslutsfas
    * I extern beslutsfas

1. Klicka på **Spara**. Ärendestatusen skapas.

1. Om det behövs kan du justera statusens placering med hjälp av pilknapparna under statuslistan. Rangordningen här avgör i vilken ordning statusvärden visas i listan **Status** när ett nytt ärende skapas. Placera de vanligaste statusarna högst upp.

## Relaterat innehåll

* [Så här konfigurerar du Hämta nästa ärende i kön][1]

<!-- Refererade länkar -->
[1]: ../next-in-queue.md

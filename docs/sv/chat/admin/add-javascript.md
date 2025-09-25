---
uid: help-sv-chat-add-javascript
title: Lägg till JavaScript till webbplatsen
description: Livechatt är ett populärt sätt för dina kunder och prospekt att komma i kontakt med dig när de besöker webbplatsen. Den här guiden visar hur du lägger till en chattwidget på din webbplats.
keywords: chatt JavaScript
author: SuperOffice Product and Engineering
date: 09.25.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/chat/learn/admin/add-javascript
index: true
---

# Lägg till JavaScript till webbplatsen

Om du vill göra chattfunktionen tillgänglig för kunderna måste du lägga till JavaScript på de relevanta sidorna på webbplatsen. Om du har konfigurerat flera chattkanaler har varje kanal ett specifikt JavaScript som måste läggas till på den eller de relevanta sidorna.

Nu när du har [konfigurerat chattwidgeten][1] visar det här steget hur du lägger till den på webbplatsen.

## Steg

1. [!include[Go to](../../learn/includes/goto-sm.md)]
1. Klicka på <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chatt** i navigatorn.
1. Välj en chattkanal i listan och klicka på **Visa**. JavaScript för vald chattkanal visas.
1. Markera och kopiera skriptet.
1. Logga in på redigeringssidan för din webbplats.
1. Gå till avsnittet där du kan redigera eller lägga till HTML-kod.
1. Klistra in JavaScriptet för din chattwidget i koden på din webbsida.
1. Spara, uppgradera eller publicera ändringarna (detta beror på vilket system du använder).
1. Öppna eller uppdatera din webbsida.

Chattwidgeten är nu tillgänglig och live. Webbplatsens besökare kan nu börja chatta med dig.

> [!NOTE]
> När du aktiverar chattfunktionen måste ditt företag vara redo att hantera alla inkommande chattkonversationer.
>
> Parametern *DEFER* ser till att det här skriptet inte blockerar öppning av en sida. Skriptet körs efter att sidan har öppnats.

## Video: lägg till chattwidgeten

Se den här demon för att se hur du lägger till chattwidgeten på din webbplats.
(Den här videon visar en tidigare version av SuperOffice, så designen kan se annorlunda ut. Stegen är desamma.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Q-i8nxHqAPc]

(filmens längd: 2:04)

## Relaterat innehåll

* [Anslut chatten till ditt Kundcenter][3]
* [AI-tjänster][2]

<!-- Referenced links -->
[1]: channel-create.md
[2]: ../../ai/learn/index.md
[3]: ../../customer-center/learn/enable-chat.md

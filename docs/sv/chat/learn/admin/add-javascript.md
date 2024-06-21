---
uid: help-sv-chat-add-javascript
title: Lägg till JavaScript till webbplatsen
description: Livechatt är ett populärt sätt för dina kunder och prospekt att komma i kontakt med dig när de besöker webbplatsen. Den här guiden visar hur du lägger till en chattwidget på din webbplats.
author: SuperOffice RnD
date: 02.22.2023
keywords: chatt
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägg till JavaScript till webbplatsen

Om du vill göra chattfunktionen tillgänglig för kunderna måste du lägga till JavaScript på de relevanta sidorna på webbplatsen. Om du har konfigurerat flera chattkanaler har varje kanal ett specifikt JavaScript som måste läggas till på den eller de relevanta sidorna.

Nu när du har [konfigurerat chattwidgeten][1] är det dags att lägga till den på webbplatsen. I den här filmen förklarar vi hur du lägger till chattwidgeten på din webbplats (filmens längd: 2:04):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Q-i8nxHqAPc]

## Steg

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Klicka på ![ikon][img2] **Chatt** i navigatorn.
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

## Relaterat

* [Anslut chatten till ditt Kundcenter][3]
* [AI-tjänster][2]

<!-- Referenced links -->
[1]: channel-create.md
[2]: ../../../ai/learn/index.md
[3]: ../../../customer-center/learn/enable-chat.md

<!-- Referenced images -->
[img2]: ../../../../../common/icons/nav-admin-chat-active.png

---
uid: help-sv-chat-respond
title: Svara på ett chattsamtal
description: När en kund skickar en fråga via chattwidgeten på webbplatsen är det inte bara viktigt att svara på den, utan också att registrera den på kundens kontaktkort.
keywords: svara på chatt, nästa chatt i kö, inkommande chatt, närvaro
author: Bergfrid Dias
date: 09.25.2025
version: 10.5
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Svara på ett chattsamtal

Inkommande chattar indikeras på följande sätt:

* En sifferikon på **Dashboard**-fliken visar hur många inkommande chattar som inte har besvarats av en handläggare.
* I listan **Inkommande chatt** på **Dashboard**-fliken. Du kan dubbelklicka på en rad för att svara på en chatt.
* På **Chattsamtal**-fliken visar fältet **I kö** hur många chattar som väntar på svar.
* En varning visas om en chatt inte besvaras inom en bestämd tid. Denna varning visas endast om din status är **Närvarande**.

## Ange status (Närvarande/Frånvarande)

Ange din närvaro överst till höger i **Chatt**-fönstret.

![ikon][img3]

* **Närvarande:** Du får varningar för obesvarade chattar.
* **Frånvarande:** Du får inte varningar men kan fortfarande svara på chattar. Om alla handläggare är frånvarande ser kunder det frånkopplade formuläret när de startar en chatt.

## Svara på nästa chattsamtal i kön

1. Klicka på **Chatt** i navigatorn.

1. Kontrollera att din status uppe till höger är inställd på **Närvarande**.

1. Klicka på **Hämta nästa i kön** för att ta nästa obesvarade chatt.

    För att svara en specifik kund, gå till fliken **Dashboard**, hitta chatten i listan **Inkommande chatt**, och dubbelklicka på raden.

1. Skriv ditt svar i meddelandefältet och tryck på **ENTER** eller klicka på **Skicka** för att chatta.

    * För att anpassa ditt svar, försök att [hitta kunden i SuperOffice][1]. Du kan då se relevant information i sidopanelen.
    * För att lägga till emojis eller klistermärken, klicka på <i class="ph ph-smiley" aria-label="Smiley"></i> bredvid textfältet.

1. För att skicka ytterligare information under chatten:
    * [Skicka en FAQ, ett svarsmall eller ett snabbsvar][4]
    * [Skicka en fil][5]

1. Om du inte kan hjälpa kunden, gör något av följande:
    * [Överför chatten][2] till en annan agent.
    * [Skapa ett ärende][3] från chatten.

1. När konversationen är avslutad klickar du på <i class="ph ph-list" aria-label="Task menu"></i> och väljer **Avsluta chatt**, om inte kunden stänger fönstret först.
    Chatten flyttas till **Senaste chatsessioner**, och en kopia sparas även under fliken **Aktiviteter** i SuperOffice CRM.

> [!NOTE]
> Om slutformuläret för chatten har aktiverats för chattkanalen kan kunden välja att återgå till chatten. Då aktiveras chattsamtalen igen.

## Svara kunden på ett effektivt sätt i chatten

För att du ska kunna ge snabba och professionella svar på dina kunders chattfrågor finns det flera funktioner i SuperOffice som hjälper dig att svara snabbt och tydligt.

Spara tid genom att använda fördefinierade texter när du svarar på kundfrågor i chatten. Du kan skapa och skicka snabbsvar på vanliga frågor. I andra situationer där snabbsvar inte är tillräckliga kan du [lägga till FAQ-artiklar, anpassade svarsmallar][4] eller [filer][5].

![Från knappen för att lägga till fördefinierad text kan du välja text från FAQ-artiklar, svarsmallar och snabbsvar -screenshot][img6]

## Relaterat innehåll

* [Använda chattfunktionen från kundens perspektiv][6]
* [Skapa eller ladda upp ett dokument][7]

<!-- Referenced links -->
[1]: link-to-person.md
[2]: transfer-to-agent.md
[3]: create-request.md
[4]: send-faq-or-reply-template.md
[5]: send-files.md
[6]: as-customer.md
[7]: ../../document/learn/create.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/chat/chat-status-present.png
[img6]: ../../../media/loc/en/chat/chat-quickreply.png

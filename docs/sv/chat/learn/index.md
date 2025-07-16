---
uid: help-sv-chat
title: Chatt
description: Kommunicera med och hjälp befintliga eller potentiella kunder via en chattwidget på din webbplats.
keywords: chatt
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: concept
language: sv
redirect_from: /sv/chat/learn/screen/index
---

# Chatt

Med **chattfunktionen** i SuperOffice kan dina handläggare och säljare kommunicera med och hjälpa befintliga eller potentiella kunder och andra personer via chattwidgeten på företagets webbplats. Funktionen kan till exempel användas för service/support och informationssökning före köp. Du kan enkelt integrera [FAQ-artiklar][1], dokument/bilagor och [mallar][3] med chatten så att dina handläggare kan spara tid genom att använda fördefinierade texter som ger snabbare svar.

Chattfunktionen kan anges med flera chattkanaler och vara riktat mot olika områden som tekniskt stöd, produktfrågor och säljstöd.

Handläggarna kommer åt chatten via navigatorn i både SuperOffice CRM och SuperOffice Service.

![Chattfönstret består av en Dashboard-flik och en Chatt-flik -screenshot][img1]

## Chattfönster

**Chatt**-fönstret består av följande flikar:

* **Dashboard**: Visar statistik för alla eller utvalda chattkanaler. Inkommande chatt och pågående chattsessioner finns angivna här.
* **Chattsamtal**: Där handläggaren chattar med kunderna.

### Fliken Dashboard

På fliken **Dashboard** kan du se chattstatistik, svara på inkommande chattsamtal och lyssna på pågående chattsamtal (om du har den behörigheten). Siffran på fliken **Dashboard** anger hur många inkommande chattsamtal som inte har besvarats av en handläggare.

![Fliken Dashboard -screenshot][img2]

### Fliken Chattsamtal

Använd fliken **Chattsamtal** för att svara på inkommande chattsamtal från kunder.

![Fliken Chattsamtal -screenshot][img3] Siffran på fliken **Chattsamtal** visar hur många chattsamtal du hanterar just nu.

Fliken **Chattsamtal** har tre huvudområden:

* Lista över aktiva/senaste chattsessioner (till vänster)
* Chattsamtal (mitten)
* Sidopanelen Kontakt (höger sida) visar kundinformation

#### Lista över aktiva/senaste chattsessioner

Den här listan innehåller

* pågående chattsamtal
* nyligen slutförda chattsamtal (de senaste 8 timmarna).

Antal chattsamtal i kö finns angivna även här och du kan klicka på **Hämta nästa i kön** för att svara på nästa chattsamtal i kön.

Följande ikoner används för de aktiva chattsessionerna i listan:

| Ikon | Beskrivning |
|---|---|
| ![ikon][img4] | Det senaste meddelandet i samtalet från kunden och agenten. |
| ![ikon][img5] | Antal olästa meddelanden från kunden. |
| <i class="ph ph-warning-circle" aria-label="Warning"></i> | Överförda chattsamtal till dig eller från dig. Väntar på att bli accepterad. |

#### Chattsamtal

Här kan du [chatta med kunden][4].

Åtgärder:

* [Skapa ärende i chatt][11]
* [Överföra ett chattsamtal till en annan agent][12]
* [Skicka FAQ:er, svarsmallar och snabbsvar i en chatt][13]
* [Skicka filer i chatt][14]
* [Skapa ett snabbsvar][15]

#### Sidopanelen Kontakt (höger sida)

När en kund kontaktar dig via chattfunktionen och hen redan är registrerad i SuperOffice, kan du visa relevant information om hen på höger sida av **Chatt**-fönstret. Du kan även lägga till nya kunder som nya kontakter (och nya företag).

Här kan du matcha kunden i chatten mot en befintlig kontakt i SuperOffice eller skapa en ny kontakt och/eller ett nytt företag.

Om kunden finns i SuperOffice kan du visa kontaktinformation, ärenden, försäljning, händelser och tidigare registrerade chattsessioner.

## Vad vill du göra?

* [Svara på ett chattsamtal][4]
* [Visa chattstatistik][5]
* [Använda chattfunktionen som kund][6]
* [Knyta chattsamtal till kontakten i SuperOffice][7]
* [Lägg till kund i SuperOffice][8]

<!-- Referenced links -->
[1]: ../../knowledge-base/learn/faq/index.md
[3]: ../../knowledge-base/learn/reply-templates/index.md
[4]: respond.md
[5]: statistics.md
[6]: as-customer.md
[7]: link-to-person.md
[8]: create-contact.md
[11]: create-request.md
[12]: transfer-to-agent.md
[13]: send-faq-or-reply-template.md
[14]: send-files.md
[15]: create-quick-reply.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/chat/10-chat-mainpage.png
[img2]: ../../../media/loc/en/chat/chat-tabs.png
[img3]: ../../../media/loc/en/chat/chat-tab-chats.png
[img4]: ../../../../common/icons/chat-status-light-blue-h32.png
[img5]: ../../../media/icons/chat-last-customer-unanswered.png

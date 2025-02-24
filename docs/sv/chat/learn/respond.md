---
uid: help-sv-chat-respond
title: Svara på ett chattsamtal
description: När en kund skickar en fråga via chattwidgeten på webbplatsen är det inte bara viktigt att svara på den, utan också att registrera den på kundens kontaktkort.
keywords: chatt
author: Bergfrid Dias
date: 02.25.2025
topic: howto
language: sv
---

# Svara på ett chattsamtal

Inkommande chattsamtal annonseras på följande sätt:

* ![ikon][img2] En sifferikon på **Dashboard**-fliken. Siffran visar hur många inkommande chattsamtal som inte har besvarats av en agent.
* I listan **Inkommande chatt** på **Dashboard**-fliken. Du kan dubbelklicka på en rad för att svara på en chatt.
* På fliken **Chattsamtal** visar fältet **I kö** hur många obesvarade chattsamtal som står i kö.
* Ett popupfönster med en varning om ett chattsamtal inte besvaras inom en angiven tidsram. Du ser bara varningen om din status är **Närvarande**.

## Ange status (Närvarande/Frånvarande)

Överst till höger i **Chatt**-fönstret kan du ange om du är närvarande eller inte:

![ikon][img3] Du listas som närvarande handläggare och får aviseringar om obesvarade chattsamtal.

![ikon][img4] Du listas inte som närvarande handläggare och får inte aviseringar om obesvarade chattsamtal. Du kan dock fortfarande svara på inkommande chattsamtal.

> [!NOTE]
> Om alla handläggare har status **Frånvarande** ser kunden bara det frånkopplade formuläret när de startar chattsamtalet.

## Svara på nästa chattsamtal i kön

1. Klicka på **Chatt** i navigatorn.

2. Kontrollera att statusen är satt till **Närvarande** längst upp till höger.

3. Klicka på **Hämta nästa i kön** för att svara på nästa chattsamtal.

    > [!NOTE]
    > Om du vill svara på ett specifikt chattsamtal (till exempel från en återkommande kund) dubbelklickar du på den relevanta raden i listan **Inkommande chatt** på **Dashboard**-fliken.

4. Försök att [hitta kunden i SuperOffice][1] så att du ser relevant information på sidopanelen. Det hjälper dig att svara på frågan.

5. För att chatta skriver du in text i den nedre delen av fönstret och trycker på **ENTER** eller klickar på **Skicka**.

6. Om du vill använda emojier/etiketter klickar du på <i class="ph ph-smiley" aria-label="Smiley"></i> bredvid textfältet.

7. Om du inte kan besvara kundens fråga gör du något av följande:

    * [Överför chatten][2] till en annan handläggare.
    * [Skapa ett ärende][3] från chatten.

8. Om du vill skicka ytterligare information till kunden:
    * [Skicka en FAQ-artikel, en svarsmall eller ett snabbsvar och/eller][4]
    * [Skicka en fil][5]

9. När samtalet har avslutats kan du klicka på <i class="ph ph-list" aria-label="Task menu"></i> och välja **Avsluta chatt** (om inte kunden stänger chattfönstret först). Chattsamtalen flyttas till **Senaste chattsessioner**. Du kan också hitta chattsamtalen som en post på detaljkortet **Aktiviteter** i SuperOffice CRM.

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
[img2]: ../../../media/loc/en/chat/chat-tab-dashboard.png
[img3]: ../../../media/loc/en/chat/chat-status-present.png
[img4]: ../../../media/loc/en/chat/chat-status-away.png
[img6]: ../../../media/loc/en/chat/chat-quickreply.png

---
uid: help-sv-video-meetings
title: Arbeta med videomöten
description: Lär dig hur du skapar och deltar i videomöten i SuperOffice här.
keywords: skapa videomöte, videomöte URL, kalender, händelse, videomöte
author: digitaldiina
date: 10.16.2025
version: 11.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/admin/preferences/learn/video-meetings/index
---

# Arbeta med videomöten <i class="ph ph-video-camera" aria-hidden="true"></i>

Med videomöten i SuperOffice kan du boka och skapa videomöten direkt från din kalender. Låt oss ta en titt på hur du skapar ett videomöte.

> [!NOTE]
> Innan du kan använda den här funktionen [måste administratören konfigurera][1] önskad videomötestjänst under Inställningar och underhåll i SuperOffice.

## Förutsättningar

* [Allmänna förutsättningar för videomöten][3]
* [Zoom][4]
* [Microsoft Teams (kräver Microsoft 365 för företag)][5]
* [Google Meet][6]
* [Cisco WebEx][7]
* [Jitsi Meet (gratis att använda, ingen prenumeration behövs)][8]

## Skapa ett videomöte

Du kan enkelt konfigurera ett videomöte när du skapar en händelse. Titta på den här filmen eller följ anvisningarna nedan om du vill skapa ett videomöte:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

(filmens längd: 1:09)

### Steg

1. Skapa en ny bokning och välj namnet på företaget och kontakten du ska ha möte med.

2. Skapa en URL till videomötet genom att klicka på <i class="ph ph-video-camera" aria-label="Camera icon"></i>. Ikonen ändrar färg och en videomöteslänk läggs till. SuperOffice CRM skapar och lägger till URL:n till videomötet för den videoleverantör du använder.

    ![Klicka på videomötesikonen för att skapa en URL till videomöte -screenshot][img5]

    > [!NOTE]
    > Första gången du klickar på <i class="ph ph-video-camera" aria-label="Video meeting"></i> måste du logga in för att autentisera din användare i videomötestjänsten som din administratör har definierat.
    >
    > Om du inte ser ikonen betyder det att videomötesfunktionen inte är konfigurerad ännu. Kontakta din SuperOffice-administratör som kan konfigurera funktionen och kopplingen till videoleverantören.

3. Om du vill kan du ställa in ett alarm som visar ett popup-meddelande innan mötet startar.

4. [Bjud in deltagare][2].

    När du har lagt till alla som du vill ska delta i mötet klickar du på **Spara**.

    Om du har aktiverat e-postinbjudningar för deltagarna i händelsen skickas ett e-postmeddelande med en länk för att ansluta till videomötet när bokningen sparas. I kalendern visas händelser med videomöten med <i class="ph ph-video-camera" aria-label="Camera icon"></i>.

> [!TIP]
> Klicka på <i class="ph ph-copy" aria-label="Copy"></i> för att kopiera länken till videomötet. Därefter kan du klistra in länken i agendaen / beskrivningen av bokningen eller skicka den till andra via direktmeddelanden. Använd mallvariabeln {burl} för att lägga till videomöteslänken i förfrågningsmallar.

## Ansluta till videomöten

Det finns flera olika sätt att ansluta till ett videomöte i SuperOffice:

* Klicka på **Anslut till möte** i dialogrutan **Händelse** (bokning).
* Klicka på **Anslut till möte** på sidopanelen.
* Klicka på en webbläsaravisering (endast tillgängligt om alternativet **Alarm** har aktiverats.)
* Högerklicka på ett videomöte i kalendern och välj **Anslut till möte**.

Titta på den här videon eller följ anvisningarna nedan:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

(filmens längd: 1:11)

### Steg

#### I popup-meddelandet

Om mötesvärden har aktiverat påminnelser för mötet får du ett meddelande från SuperOffice CRM i form av ett popupfönster innan mötet börjar. Du kan klicka på knappen **Anslut till möte** i popupfönstret för att starta videomötet automatiskt.

#### I bokningen

Du kan också ansluta till videomötet genom att öppna bokningen i din kalender och klicka på knappen **Anslut till mötet**. När du klickar på länken startar ditt videomöte automatiskt.

> [!TIP]
> Om du inte använder URL:n till videomötet, utan har en annan video-URL lägger du bara till den i fältet Plats så kan alla som använder Mobile CRM klicka på **Plats** för att ansluta till videomötet var de än befinner sig.

#### I förhandsgranskningen på sidopanelen

Klicka på bokningen i din SuperOffice-kalender för att se bokningsdetaljerna på sidopanelen. (Aktivera förhandsgranskningen genom att välja den i listrutan högst upp på sidopanelen).

Om du vill ansluta till videomötet via förhandsgranskningen klickar du på knappen **Anslut till möte**. När du har klickat på den startar videomötet automatiskt.

<!-- Referenced links -->
[1]: ../../../../integrations/video-meetings/howto/connect-provider.md
[2]: invitation/add-attendee.md
[3]: ../../../../integrations/video-meetings/index.md
[4]: ../../../../integrations/video-meetings/zoom/index.md
[5]: ../../../../integrations/video-meetings/ms-teams/index.md
[6]: ../../../../integrations/video-meetings/google-meet/index.md
[7]: ../../../../integrations/video-meetings/webex/index.md
[8]: ../../../../integrations/video-meetings/jitsi/index.md

<!-- Referenced images -->
[img5]: ../../../media/loc/en/diary/follow-up-video-meeting.png

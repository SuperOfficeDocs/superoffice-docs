---
uid: help-sv-video-meetings
title: Arbeta med videomöten
description: Starta videomöten direkt från kalendern med hjälp av våra integrationer för videokonferenssystem. Lär dig hur du skapar och deltar i videomöten i SuperOffice här.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: kalender, händelse, videomöte
so.topic: howto
language: sv
---

# Arbeta med videomöten

Med videomöten i SuperOffice kan du boka och skapa videomöten direkt från din kalender. Låt oss ta en titt på hur du skapar ett videomöte.

> [!NOTE]
> Innan du kan använda den här funktionen [måste administratören konfigurera][1] önskad videomötestjänst under Inställningar och underhåll i SuperOffice.

## Tillgängliga videokonferenssystem

* Zoom
* Microsoft Teams
* Google Meet
* Cisco WebEx
* Jitsi Meet (gratis att använda, ingen prenumeration behövs)

## Skapa ett videomöte

Du kan enkelt konfigurera ett videomöte när du skapar en händelse. Titta på den här filmen eller följ anvisningarna nedan om du vill skapa ett videomöte (filmens längd: 1:09):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

### Steg

1. Skapa en ny bokning och välj namnet på företaget och kontakten du ska ha möte med.

2. Skapa en URL till videomötet genom att klicka på ![ikon][img1] bredvid mötestypen (till exempel **Affärsmöte**). Ikonen ändras till ![ikon][img2] och en videomöteslänk läggs till. SuperOffice CRM skapar och lägger till URL:n till videomötet för den videoleverantör du använder.

    ![Klicka på videomötesikonen för att skapa en URL till videomöte -screenshot][img5]

    > [!NOTE]
    > Första gången du klickar på videoikonen (![ikon][img1]) måste du logga in för att autentisera din användare i videomötestjänsten som din administratör har definierat.
    >
    > Om du inte ser ikonen betyder det att videomötesfunktionen inte är konfigurerad ännu. Kontakta din SuperOffice-administratör som kan konfigurera funktionen och kopplingen till videoleverantören.

3. Om du vill kan du ställa in ett alarm som visar ett popup-meddelande innan mötet startar.

4. Bjud in deltagare: Gå till fliken **Deltagare** och klicka på knappen **\+ Lägg till** för att bjuda in andra personer till mötet.

    När du har lagt till alla som du vill ska delta i mötet klickar du på **Spara**.

    Om du har aktiverat e-postförfrågningar för deltagarna i händelsen skickas ett e-postmeddelande med en länk för att ansluta till videomötet när bokningen sparas. I kalendern visas händelser med videomöten med ikonen ![ikon][img3].

> [!TIP]
> Klicka på ![ikon][img4] för att kopiera länken till videomötet. Därefter kan du klistra in länken i beskrivningen av bokningen eller skicka den till andra via direktmeddelanden. Använd mallvariabeln {burl} för att lägga till videomöteslänken i förfrågningsmallar.

## Ansluta till videomöten

Det finns flera olika sätt att ansluta till ett videomöte i SuperOffice:

* Klicka på **Anslut till möte** i dialogrutan **Händelse** (bokning).
* Klicka på **Anslut till möte** på sidopanelen.
* Klicka på en webbläsaravisering (endast tillgängligt om alternativet **Alarm** har aktiverats.)
* Högerklicka på ett videomöte i kalendern och välj **Anslut till möte**.

Titta på den här videon eller följ anvisningarna nedan (filmens längd: 1:11):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

### Steg

#### I popup-meddelandet

Om mötesvärden har aktiverat påminnelser för mötet får du ett meddelande från SuperOffice CRM i form av ett popupfönster innan mötet börjar. Du kan klicka på knappen Anslut till möte i popupfönstret för att starta videomötet automatiskt.

#### I bokningen

Du kan också ansluta till videomötet genom att öppna bokningen i din kalender och klicka på knappen Anslut till mötet längst ner i bokningen.

När du klickar på länken startar ditt videomöte automatiskt.

> [!TIP]
> Om du inte använder URL:n till videomötet, utan har en annan video-URL lägger du bara till den i fältet Plats så kan alla som använder Mobile CRM klicka på **Plats** för att ansluta till videomötet var de än befinner sig.

#### I förhandsgranskningen på sidopanelen

Klicka på bokningen i din SuperOffice-kalender för att se bokningsdetaljerna i förhandsgranskningen på sidopanelen.

(Aktivera förhandsgranskningen genom att välja den i listrutan högst upp på sidopanelen).

Om du vill ansluta till videomötet via förhandsgranskningen klickar du på knappen Anslut till möte längst ner på sidopanelen. När du har klickat på den startar videomötet automatiskt.

<!-- Referenced links -->
[1]: ../../../en/video-meeting/howto/connect-provider.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/videocall-off.png
[img2]: ../../../../common/icons/videocall.png
[img3]: ../../../../common/icons/diary-videocall.png
[img4]: ../../../../common/icons/diary-copy.png
[img5]: ../../../media/loc/en/diary/appointment-videomeeting-icon.png

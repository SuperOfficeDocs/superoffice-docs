---
uid: help-sv-invitation-add-attendee
title: Lägga till deltagare i händelser
description: "Att bjuda in kontakter till en bokning görs på olika sätt. Den här guiden beskriver hur du lägger till deltagare i en bokning."
author: Bergfrid Dias
redirect_url: https://docs.superoffice.com/de/diary/learn/invitation/add-attendee.html
keywords: kalender, händelse, förfrågan, deltagare
topic: howto
language: sv
---

# Lägg till deltagare och resurser i bokningar

När du skapar en händelse som omfattar flera kontakter kan du koppla personerna till händelsen som deltagare. Du kan också boka företagets mötesrum och utrustning. Vilka som är tillgängliga som deltagare definieras under Inställningar och underhåll.

## Steg

> [!NOTE]
> Endast ägaren av uppföljningen kan lägga till (och ta bort) deltagare.

1. [Öppna eller skapa en händelse][3].

1. Klicka på **Bjud in**-knappen. Detta utökar dialogen.

    ![Händelsesdialog, Bjud in-knapp -screenshot][img14]

    ![Händelsesdialog, utökad -screenshot][img15]

1. Klicka på rutan **Lägg till deltagare**. Välj sedan en eller flera personer från listan.

    * Börja skriva för att söka efter en person i hela SuperOffice.
    * Välj en person från historiklistan ![ikon][img4] eller dina favoriter ![ikon][img5].
    * Klicka ![ikon][img6] för att söka efter en kollega eller ![ikon][img7] för att välja personer kopplade till ett företag.
    * Du kan också välja säljintressenter ![ikon][img8] och projektmedlemmar ![ikon][img9].

    ![Händelsesdialog, välj deltagare -screenshot][img17]

    > [!TIP]
    > För att bjuda in någon som inte är registrerad i SuperOffice, ange deras fullständiga e-postadress.

    ![Händelsesdialog, deltagare tillagda -screenshot][img16]

    Om en deltagare inte är tillgänglig visas ett utropstecken bredvid deras namn. Välj ett av de föreslagna tidsluckorna eller klicka på **Kontrollera tillgänglighet** för att hitta en bättre tid.

1. Valfritt, lägg till platser, rum och/eller resurser.

1. Valfritt, välj **Skicka e-postinbjudan till deltagare**. (Detta ändrar **Spara**-knappen till **Spara och skicka**.)

1. Klicka på **Spara** för att spara alla ändringar.

### <a id="availability"></a>Schemarådgivare

Schemarådgivaren är en del av den nya **Händelse**-dialogen. Den detaljerade kalendern visar tillgängligheten för varje intern deltagare (kollega). Den översta raden visar den ackumulerade tillgängligheten. Tillgängligheten för externa deltagare och e-postdeltagare är okänd.

![Händelsesdialog, schemarådgivare -screenshot][img18]

1. I **Händelse**-dialogen, klicka på **Kontrollera tillgänglighet.**

1. Klicka och dra pekaren åt vänster eller höger för att välja ett mötestidpunkt. Till exempel, från 13.30 till 15:00, som visas i grönt på detta skärmbild. Använd rullningslisten för att röra dig mellan dagarna.

    Som ett alternativ kan du uppdatera den valda datumen och tiden högst upp i dialogen.

1. Valgfritt, lägg till eller ta bort deltagare och resurser. Överväg att justera tiden igen om det finns en konflikt.

1. Klicka **OK** när du är klar.
1. Klicka **Spara** för att spara alla ändringar.

### <a id="preview"></a>Förhandsgranska och uppdatera inbjudnings-e-post

När du klickar på **Spara och skicka**, visas en förhandsgranskning av e-posten baserat på titeln och dagordningen. Eventuella interna anteckningar som läggs till i händelsen utesluts.

![Händelsesdialog, förhandsgranska e-postinbjudan -screenshot][img13]

1. Uppdatera ämnet och brödtexten i e-posten vid behov. Använd verktygsfältet för rik text längst ned för att styla din inbjudan.

    > [!NOTE]
    > Alla ändringar som görs i förhandsvisningen sparas **inte** tillbaka till händelsen.

1. När du är redo, klicka på **Skicka**.

## Vad händer härnäst

1. När du sparar händelsen, [får den andra personen en avisering][5].

2. Om den andra personen avvisar inbjudan får du en Inbjudan avvisades-avisering. Klicka på **Jag förstår** för att bekräfta.

3. Om så önskas, hitta en ny lämplig tid och ändra tidpunkten för händelse.

### Hur anger jag att en extern kontakt har accepterat eller avböjt förfrågan?

Externa deltagare meddelas via e-post (om du har valt detta alternativn). E-postförfrågningar som skickas till externa kontakter innehåller en iCal-fil (.ics) med information om förfrågan. När de svarar på din förfrågan uppdateras [statusen][1] automatiskt i SuperOffice.

Om du manuellt vill tacka ja eller nej till en förfrågan för någon annans räkning väljer du namnet i listan och klickar en gång på knappen **Byt status** för att infoga en grön bock, som visar att förfrågan har godtagits, eller två gånger för att infoga ett rött kryss som visar att förfrågan har avböjts.

## Felsökning

### Varför händer ingenting när jag klickar på E-postförfrågan?

Om den valda kontakten inte har en giltig e-postadress i SuperOffice CRM händer ingenting när du klickar på **E-postförfrågan**.

### Varför är knappen E-postförfrågan inaktiverad?

Använda inkorgen i SuperOffice: Om du inte har angett de obligatoriska uppgifterna i fönstret **Inloggning** som visas första gången du klickar på knappen **Inkorg** i SuperOffice CRM är knappen **E-postförfrågan** inaktiverad.

## Relaterat innehåll

* [Skapa bokningar][3]
* [Anslut till ett videomöte][4]

<!-- Referenced links -->
[1]: index.md#status
[3]: ../create-follow-up.md
[4]: ../video-meetings.md
[5]: accept-decline.md

<!-- Referenced images -->
[img4]: ../../../../../common/icons/history-icon.png
[img5]: ../../../../../common/icons/favourite-icon.png
[img6]: ../../../../../common/icons/personblack.png
[img7]: ../../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../../common/icons/sale.png
[img9]: ../../../../../common/icons/singlecolour/project.png
[img13]: ../../../../media/loc/en/diary/preview-invitation.png
[img14]: ../../../../media/loc/en/diary/invite.png
[img15]: ../../../../media/loc/en/diary/large-follow-up-dialog.png
[img16]: ../../../../media/loc/en/diary/attendees-added.png
[img17]: ../../../../media/loc/en/diary/follow-up-attendees.png
[img18]: ../../../../media/loc/en/diary/schedule-associate-ext-email.png

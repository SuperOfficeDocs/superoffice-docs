---
uid: help-sv-invitation-add-participant
title: Lägga till deltagare i händelser
description: "Att bjuda in kontakter till en bokning görs på olika sätt beroende på om det är en intern eller extern person, eller en resurs, till exempel ett mötesrum eller specialutrustning. Den här guiden beskriver hur du lägger till deltagare i en bokning."
author: SuperOffice RnD
so.date: 02.10.2023
keywords: kalender, händelse, förfrågan, deltagare
so.topic: howto
language: sv
---

# Lägg till deltagare och resurser i bokningar

När du skapar en händelse som omfattar flera kontakter kan du koppla personerna till händelsen som deltagare. Du kan också boka företagets mötesrum och utrustning. Vilka som är tillgängliga som deltagare definieras under Inställningar och underhåll.

Bjud in en kontakt till en bokning från deltagarfliken genom att klicka på knappen **Lägg till**. Titta på filmen om att [Lägga till deltagare i en bokning][5].

<!--
> [!Video https://community.SuperOffice.com/globalassets/user--admin/learning/user-guide/diary--appointments/add-contact-to-appointment.mp4] -->

## Steg

1. Öppna dialogrutan **Bokning**, **Uppgift** eller **Samtal** och [ange de nödvändiga uppgifter][2].

2. Öppna fliken **Deltagare** och klicka på **Lägg till** längst ned till vänster i fönstret. Dialogrutan **Förfrågan** visas.

    > [!NOTE]
    > Om du har andra användares eller resursers översikter öppna läggs de automatiskt till som deltagare på fliken **Deltagare**. Annars väljer du dem manuellt enligt beskrivningen nedan.

3. Välj varifrån du vill hämta deltagarna i fältet **Välj från**. Välj mellan **Medarbetare**, **Företag/kontakt**, **Projekt**, **Urval** och **Resurs**.

4. I listrutan under fältet **Välj från** väljer du användargruppen, företaget, kontakten, projektet, urvalet eller resursen som du ska hämta deltagare från. Innehållet i listrutan varierar beroende på vad du väljer i steget ovan.
    * Om du har valt **Medarbetare** eller **Resurser** i steg 3 kan du välja **Alla** i listrutan, så visas kontakter eller resurser från alla grupperna.
    * Om du har valt **Företag/kontakt**, **Projekt** eller **Urval** i steg 3 kan du söka efter företag, kontakt, projekt eller urval i det här fältet.

5. När du har valt källa visas en lista över alla poster som finns tillgängliga för källan. Markera de användare eller resurser som ska inkluderas i händelsen och klicka på pilknappen till höger om listan (![ikon][img2]). De visas då i fönstrets högra del. Du kan lägga till användare och resurser en i taget genom att dubbelklicka på dem.

    > [!NOTE]
    > Om någon eller några av personerna är upptagen vid den angivna tidpunkten visas deras namn med rött, så att du enkelt ser om du bör hitta en annan tidpunkt för händelsen. Du kan också bjuda in dem till den nya bokningen och deras sökträff visas då med rött och ordet "KONFLIKT" i dialogrutan för händelser.

6. Klicka på knappen **E-postförfrågan** för att aktivera e-postförfrågningar för alla deltagare på listan (utom dig själv). Ikonen ![ikon][img1] till vänster om deltagarens namn betyder att en e-postförfrågan för händelsen kommer att skickas till deltagaren. Klicka på ![ikon][img1] ikonen bredvid en deltagares namn för att inaktivera e-postförfrågan för denna deltagare. Ikonen ![ikon][img1] ändras till inaktiv (![ikon][img3]) och deltagaren får ingen förfrågan via e-post.

7. Stäng dialogrutan **Förfrågan** genom att klicka på **OK**. Du ser nu de valda deltagarna och resurserna på fliken **Deltagare**. Du kan klicka på knappen **E-postförfrågan** och ![ikon][img1]-ikonen för att aktivera/inaktivera e-postförfrågningar på samma sätt som i föregående steg.
    Om någon eller några av kontakterna du har valt inte har en giltig e-postadress registrerad i SuperOffice CRM ändras ![ikon][img1]-ikonen till inaktiv (![ikon][img3]) på fliken **Deltagare**.

    > [!NOTE]
    > Om du har valt användare eller resurser av misstag markerar du dem i listan längst till höger och klickar på **Ta bort** för att ta bort dem.

8. När du har valt deltagare och resurser klickar du på **Spara** för att spara dina val, eller på **Avbryt** för att stänga dialogrutan utan att spara.

## Felsökning

### Varför händer ingenting när jag klickar på E-postförfrågan?

Om den valda kontakten inte har en giltig e-postadress i SuperOffice CRM händer ingenting när du klickar på **E-postförfrågan**.

### Varför är knappen E-postförfrågan inaktiverad?

Använda inkorgen i SuperOffice: Om du inte har angett de obligatoriska uppgifterna i fönstret **Inloggning** som visas första gången du klickar på knappen **Inkorg** i SuperOffice CRM är knappen **E-postförfrågan** inaktiverad.

### Hur anger jag att en extern kontakt har accepterat eller avböjt förfrågan?

Externa deltagare meddelas via e-post (om du har valt detta alternativ i dialogrutan Förfrågan). E-postförfrågningar som skickas till externa kontakter innehåller en iCal-fil (.ics) med information om förfrågan. När de svarar på din förfrågan uppdateras [statusen][1] automatiskt i SuperOffice.

Om du manuellt vill tacka ja eller nej till en förfrågan för någon annans räkning väljer du namnet i listan och klickar en gång på knappen **Byt status** för att infoga en grön bock, som visar att förfrågan har godtagits, eller två gånger för att infoga ett rött kryss som visar att förfrågan har avböjts.

## Relaterat innehåll

* [Skapa bokningar][3]
* [Anslut till ett videomöte][4]

<!-- Referenced links -->
[1]: index.md#status
[2]: ../screen/dialog-for-followups.md
[3]: ../appointment.md
[4]: ../video-meetings.md
[5]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/diary--appointments/add-contact-to-appointment.mp4

<!-- Referenced images -->
[img1]: ../../../../../common/icons/pref-email.png
[img2]: ../../../../media/icons/arrow-right.png
[img3]: ../../../../media/icons/email-inactive.png

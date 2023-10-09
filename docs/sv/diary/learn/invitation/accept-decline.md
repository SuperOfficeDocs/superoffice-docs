---
uid: help-sv-invitation-accept
title: Händelser du har inbjudits till
description: Visa händelser du har inbjudits till; Acceptera eller tacka nej till förfrågningar
author: Bergfrid Dias
so.date: 10.04.2023
keywords: kalender, händelse, förfrågning
so.topic: howto
language: sv
---

# Händelser du har inbjudits till

När du ska visa en händelse som du inte själv äger visas den vanliga dialogrutan **Bokning**, **Uppgift** eller **Samtal**. Du kan däremot inte göra ändringar i någon annans förfrågan eller lägga till deltagare. Därmed är knappen **Lägg till** på fliken **Deltagare** inaktiverad.

* Tills du accepterar eller avslår förfrågan visas två extra knappar i dialogrutan: **Acceptera** och **Avslå**. När du har godtagit förfrågan inaktiveras knappen.

* Eftersom du inte har skapat bokningen, uppgiften eller samtalet själv kan du bara göra ändringar i fälten **Prioritet**, **Alarm** och **Slutfört**. Alla andra alternativ är inaktiverade.

![ikon][img1]

Deltagare som har bjudits in till en händelse får ett varningsmeddelande på toppraden. Klicka på ikonen **Varningar** för att visa förfrågan.

![Få förfrågningar -screenshot][img2]

* Överst visas en lista över dina förfrågningar med bland annat status och ikoner.

* Längst ned visas mer detaljerad information om de förfrågningar du markerar i den översta delen. Här hittar du en tydlig beskrivning av förfrågningen, datum för den och mer detaljerad information.

## Händelseikoner

Ikonerna i listan med förfrågningar ger mer information om förfrågningen som du har fått:

| Ikon | Beskrivning |
|---|---|
| ![ikon][img3] | Ikon för händelser som du har godtagit förfrågningar för. |
| ![ikon][img4] | Ikon för händelser som du har tackat nej till. Dessa händelser visas i dialogrutan **Förfrågningar** t.o.m. dagen efter att de har utförts, så du har möjlighet att ångra dig. |
| ![ikon][img5] | Återkommande händelse. |

## Filtrera vyn

Du kan få bättre överblick över förfrågningarna genom att filtrera översikten med hjälp av tre kryssrutor:

* Markera **Visa svar** om du vill visa meddelanden med avslag från andra personer som du har skickat förfrågningar till.
* Markera **Visa avslagna** om du vill visa händelser som du själv har tackat nej till.
* Check **Show repetitions** to show repeating follow-ups. Om förfrågningen gäller en återkommande händelse visas alla förekomster av händelsen i dialogrutan **Förfrågningar**. Där kan du avslå eller acceptera dem individuellt.

> [!TIP]
> Det kan vara bra att markera **Visa upprepningar** så att du ser om du kan vara med på alla möten. Om du vill acceptera alla samtidigt avmarkerar du **Visa upprepningar** igen, markerar raden med den aktuella händelsen och väljer **Acceptera**.

Markera alla tre om du vill visa all information samtidigt.

Om du inte markerar något alternativ visas endast händelser som du har fått förfrågan om, men ännu inte svarat på.

## <a id="accept" />Acceptera eller tacka nej till förfrågningar

När du markerar en förfrågan i den översta delen av dialogrutan visas information om förfrågan i den nedre delen. Den aktuella händelsen är markerad. Du kan acceptera eller avslå förfrågningen genom att klicka på **Acceptera** eller **Avslå**:

| Åtgärd | Beskrivning |
|---|---|
| Godkännande | Acceptera förfrågningen. En grön bock visas till vänster om ditt namn i listan med deltagare i det nedersta fönstret. Händelsen flyttas från dialogrutan **Förfrågningar** till din kalender. |
| Avslå | Avslå förfrågningen. Ett rött kryss visas till vänster om ditt namn i listan med deltagare i den nedersta fönstret. Händelsen tas bort från dialogrutan **Förfrågningar**. Dialogrutan **Orsak till avslag** öppnas där du kan ange varför du tackar nej. |

> [!TIP]
> När du har markerat en förfrågan i dialogrutan **Förfrågningar** visas den aktuella dagen i fönstret Kalender i bakgrunden så att du ser om du har andra bokningar.
Om du har andra överlappande bokningar visas även en **Konflikt**-ikon ![ikon][img6] i förhandsvisningen i dialogrutan **Förfrågningar**.

## Få förfrågan om att delta i återkommande händelser

Om du markerar **Visa upprepningar** under listan med förfrågningar så visas alla förekomster av händelsen.

Det finns två sätt att se om en [händelse är återkommande][3]:

* Statusikonen ![ikon][img5] visas i listan över förfrågningar.
* Du ser en upprepningsikon längst upp till vänster i den nedre delen av dialogrutan.

Stäng dialogrutan genom att klicka på **Stäng**.

### OBS!

* Om du först accepterar en förfrågan och därefter tar bort händelsen från kalendern räknas det som att du avslår den. Händelsen tas bort från kalendern och ditt namn markeras med ett rött kryss ![ikon][img4] i dialogrutan **Bokning**, **Uppgift** eller **Samtal** för kontakten som skickade förfrågan.

* Om du accepterar en förfrågan och därefter öppnar dialogrutan för händelser kan du bara ändra informationen om händelsen i fälten **Prioritet**, **Slutfört** och **Alarm**. Övriga ändringar kan endast göras av personen som skickade förfrågan.

* Om du tilldelar en händelse till en annan användare (byter ägare) och mottagaren avböjer den fungerar det på samma sätt som när du [hanterar svar på förfrågningar][4].

* Om du stänger dialogrutan **Förfrågningar** utan att acceptera eller avslå förfrågan blir händelsen liggande och ett öga ![ikon][img7] visas bredvid ditt namn i dialogrutan **Bokning**, **Uppgift** eller **Samtal** för att visa att du har sett den, men inte tagit ställning till den.

* En förfrågan sparas till dagen efter händelsen har markerats som slutförd, så att deltagarna meddelas om eventuella ändringar.

<!-- Referenced links -->
[3]: ../recurrence/index.md
[4]: ../follow-up-assign.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/notice-new.png
[img2]: ../../../../media/loc/en/diary/invitation.png
[img3]: ../../../../../common/icons/check-black.png
[img4]: ../../../../../common/icons/reject-appointment-icon.png
[img5]: ../../../../media/icons/recurring-booking-assignment.png
[img6]: ../../../../../common/icons/warning-red.png
[img7]: ../../../../../common/icons/assignment-seen.png

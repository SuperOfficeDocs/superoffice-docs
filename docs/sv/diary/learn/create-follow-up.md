---
uid: help-sv-follow-up-create
title: "Lägga till händelser"
description: "Lägga till eller kopiera möter, uppgifter och samtal i SuperOffice"
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: kalender, händelse, ringa upp, telefon, möte
so.topic: howto
language: sv
---

# Lägga till händelser

Om du skapar händelser och lägger in alla möten och aktiviteter i din SuperOffice-kalender har du alltid fullständig överblick över vad som är på gång och du kan bygga upp en solid kommunikationshistorik och hålla dina kollegor uppdaterade.

## Steg

Det finns många olika sätt att skapa händelser. Denna metod fungerar från var som helst i SuperOffice CRM och för alla typer av händelser.

1. Klicka på **Nytt** i det övre fältet och välj **Möte/Bokning**, **Händelse/Samtal** eller **Att göra/Uppgift**.

2. [Fyll i nödvändiga uppgifter i fälten.](#fields)

    Viss information infogas automatiskt baserat på sammanhanget, till exempel dagens datum.

3. Klicka på **Spara**-knappen.

**Andra alternativ:**

| Startpunkt | Möte (bokning) | Händelse (samtal) | Att göra (uppgift) |
|---|---|---|---|
| Detaljkortet Aktiviteter | x | x | x |
| Knappen Uppgift på kontaktkortet | x | x | |
| Kalender | x | | |

### <a id="fields" />Hur man anger information

> [!NOTE]
> Många fält har en lista över fördefinierade värden som du kan välja från. Klicka på pilen ![ikon][img4] för att expandera listan. Välj sedan ett värde för det fältet. Alternativt kan du börja skriva i fältet för att söka efter ett specifikt värde, som ett företagsnamn.

Om din SuperOffice har [tidszoner][9] aktiverat, kan du välja vilken tidszon händelsen ska skapas i. Tidszonerna visas efter land, och du kan söka både efter land och stad direkt i tidszonfältet.

Om du kryssar i **Hela dagen**, sätts tiden för händelsen till den period som anges som [standard arbetsdag][8] (**Starttid för hela dagen** och **Sluttid för hela dagen** preferens).

<!-- markdownlint-disable MD051 -->
#### [Klassisk](#tab/fields-old)

![Mötesdialogruta -screenshot][img6]

* Välj händelsestyp.

* Valfritt, välj ett företag och/eller en kontakt som händelsen gäller.

* Valfritt, välj ett projekt och/eller en försäljning för att länka det till händelsen. Du kan välja vilket projekt/försäljning som helst oavsett vilket företag du valde tidigare.

* Ange tid och datum. **Varaktighet**-fältet justeras automatiskt.
händelsen överlappar med en befintlig händelse, visas ett utropstecken ![ikon][img2] bredvid start- och stoppfälten som en påminnelse (du kan fortfarande lägga till händelsen). Ett förslag på första lediga tidpunkt visas. Klicka på den föreslagna tiden till höger om **Första lediga** för att välja den här tiden istället.

    När du skapar en ny to-do visas ingen tid i fälten **Start** och **Slut**. Dagens datum sätts automatiskt in, men du kan ändra det till det önskade datumet. Datumet indikerar deadline för to-do:n.

* Valfritt, välj eller ange adressen där händelsen kommer att äga rum.

* Välj fliken **Beskrivning** för att lägga till en beskrivning av händelsen (max 2048 tecken).
* Välj fliken **Detaljer** för att ställa in [återkommande][4], prioritet, [larm][3], ägare och "visa som".
* Välj fliken **Deltagare** för att [lägga till deltagare][5].

> [!TIP]
> Klicka på ![ikon][img5] för att ställa in en [videomöte][2].

#### [Ny (från version 10.2.11 pilot)](#tab/fields-new)

![Uppföljningsdialogruta -screenshot][img7]

* Ange en titel.

* Klicka på den färgade bollen och välj en händelsestyp.

* Valgfritt, välj ett företag eller en kontakt som händelsen gäller. Om du vill bjuda in dem och andra till mötet, klicka på **Bjud in**.

  * [Lägg till deltagare][5].
  * Valgfritt, legg til rum, lokasjoner, eller resurser.
  * Valgfritt, legg til plats eller adresse.

    ![Utökad uppföljningsdialogruta -screenshot][img8]

* Specificera tid och datum. Klicka på **Visa mer** för att ställa in [upprepning][4], "hela dagen", "upptagen/fri" och tidszon. Klicka på klockikonen i huvudet för att [ställa in larmet][3].

* Valgfritt, välj ett projekt och/eller försäljning för att länka det till uppföljningen. Du kan välja vilket projekt/försäljning som helst oavsett vilket företag du valde tidigare.

* Välj fliken **Agenda** för att lägga till ytterligare information, som en dagordning, en beskrivning av händelsen, filer, bilder och länkar. Använd knapparna i sidfoten för att lägga till formatering av rik text och innehåll.

    > [!TIP]
    > Om du vill begränsa åtkomsten endast till anställda, placera den informationen i fliken **Intern anteckningar**. Det som läggs till här skickas inte till externa deltagare. Klicka på klockikonen för att lägga till en tidsstämpel. En prick på fliken indikerar att någon har lagt till en anteckning.

***
<!-- markdownlint-restore -->

## Skapa händelser från detaljkortet Aktiviteter

* Klicka på **Lägg till**-knappen på detaljkortet **Aktiviteter**.

* Eller, dubbelklicka på en tom rad under den sista aktiviteten i listan. Om ingen tom rad visas längst ned i aktivitetslistan förstorar du aktivitetslistan: Håll muspekaren mellan sektionsflikarna och kortet ovanför. Markören ändras till en dubbelpil. Klicka och dra linjen uppåt tills du ser fler tomma rader längst ned i aktivitetslistan.

> [!NOTE]
> Om du anger tid eller varaktighet för en händelse som du skapar från aktivitetslistan läggs den in i kalendern.

## Skapa händelser från knappen Uppgift

1. Klicka på ![ikon][img3] knappen **Uppgift** på kontaktkortet.

    * För att skapa en mötesförfrågan, välj **Förfrågan om möte**.

    * För att registrera ett samtal, välj **Inled samtal**.

1. Mata in information och klicka på **Spara**.

## Skapa ett möte från fönstret Kalender

* **För att välja en tidslucka:** Klicka med musknappen på det klockslag som du vill att händelsen ska starta och håll ned musknappen samtidigt som du drar pekaren till önskad sluttidpunkt för uppgiften. Du ser ett blått område medan du definierar tidsperioden innan dialogrutan för händelser öppnas.

* **För att använda standardvaraktighet:** Dubbelklicka på ett klockslag i kalendern eller högerklicka på ett klockslag i kalendern och välj **Nytt**.

> [!NOTE]
> Om du skapar mötet på fliken **Översikt** kan du välja att deltagarlistan ska fyllas i automatiskt med deltagarna i översikten. Om du vill välja det här alternativet går du till ![ikon][img1] **Personliga inställningar** > **Inställningar** > **Funktioner** och sätter inställningen **Deltagare från gruppöversikt** till **Ja**. Klicka på **Spara**.

## <a id="associate" />Skapa möte för en medarbetare

Du kan öppna en annan användares kalender, eller kalendern för en tillgänglig resurs, för att se när de är lediga, eller för att skapa händelser för dem direkt.

1. Klicka på fliken **Översikt** i fönstret Kalender.

2. Klicka på kalenderägarlistan och leta fram personens kalender.

3. Skapa ett nytt möte i den här kalendern med musen.

4. I dialogrutan **Händelse**, [fyll i nödvändiga uppgifter i fälten](#fields).

5. [Välj vilka deltagare som ska inkluderas][5] om de inte inkluderas automatiskt.

6. Klicka på **Spara**-knappen. Mötet visas i den valda personens kalender.

## <a id="copy" />Kopiera en händelse till kalendern

Du kan också skapa en ny uppföljning genom att kopiera en befintlig uppföljning till en annan tid eller dag i dagboken.

1. Öppna dagboken och hitta uppföljningen du vill kopiera.

2. Om uppföljningen är slutförd, högerklicka på den och välj **Slutförd** för att aktivera redigering. (Kom ihåg att återställa statusen efter att du har kopierat den.)

3. Håll ned **CTRL**-tangenten medan du drar och släpper uppföljningen till en annan tid.

## Relaterat innehåll

* [Händelser][1]
* [Aktiviteter][7]
* [Skapa ett videomöte från SuperOffice-kalendern][2]

<!-- Referenced links -->
[1]: follow-ups.md
[2]: video-meetings.md
[3]: set-alarm.md
[4]: recurrence/index.md
[5]: invitation/add-participant.md
[7]: ../../learn/basics/activity.md
[8]: ../../learn/getting-started/preferences.md
[9]: ../../globalization-and-localization/learn/time-zones.md

<!-- Referenced images -->
[img1]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/icons/btn-menu.png
[img2]: ../../../../common/icons/warning-red.png
[img4]: ../../../../common/icons/dropdown-icon.png
[img5]: ../../../../common/icons/videocall-off.png
[img6]: ../../../media/loc/en/diary/appointment-new.png
[img7]: ../../../media/loc/en/diary/follow-up-dialog.png
[img8]: ../../../media/loc/en/diary/follow-up-attendees.png

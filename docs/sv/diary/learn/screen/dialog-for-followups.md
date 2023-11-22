---
uid: help-sv-dialog-for-followups
title: Dialogrutan för händelser
description: Dialogrutan för händelser
author: SuperOffice RnD
so.date: 06.29.2022
keywords: kalender, händelse
so.topic: reference
language: sv
---

# Dialogrutan för händelser

Oavsett vilken [typ av händelse][1] du arbetar med ser du dialogrutan för händelser. Namnet på den här dialogrutan varierar beroende på typen av händelse (Bokning, Uppgift eller Samtal), men fälten är alltid desamma. Fälten i dialogrutan och hur du använder dem beskrivs nedan.

Dialogrutan består av en huvuddel med allmän information om händelsen och fem flikar med ytterligare information:

* Beskrivning
* Specifikation
* Deltagare
* Länkar
* Mer

## Information om händelsen

Huvuddelen innehåller följande grundläggande uppgifter om händelsen:

### Typ

Om du klickar på pilen bredvid det här fältet (![ikon][img2]) visas en fördefinierad lista där du kan välja typ av händelse, till exempel möte eller utgående telefonsamtal. Du kan även söka efter typer genom att skriva i detta fält.

> [!NOTE]
> Fältet **Typ** avgör vilken typ av händelse det handlar om: bokning, uppgift eller samtal.

## Videomöte

Klicka på ![ikon][img3] om du vill konfigurera ett [videomöte][9]. Ikonen ändras till ![ikon][img4].

### Företag

Här skriver du in namnet på den kontakt som har kopplats till händelsen. Om du inte kommer ihåg hela namnet kan du söka efter det från detta fält.

### Kontaktperson

När du klickar på pilen efter detta fält visas en lista över kontakter som är registrerade för företaget. Om inget företag har valts ser du en lista över kontakter som inte är kopplade till något företag. Du kan söka direkt från detta fält.

### Projekt

Skriv in namnet på projektet som händelsen är kopplad till. Om du inte kommer ihåg hela namnet kan du söka efter det från detta fält.

> [!NOTE]
> I fältet **Projekt** kan du ange ett valfritt projekt i SuperOffice CRM, oavsett vilket företag händelsen är kopplad till.

### Försäljning

Skriv in namnet på den eventuella försäljning som händelsen är kopplad till. Om du inte kommer ihåg hela namnet kan du söka efter det från detta fält.

### Tidszonsväljare

Om [tidszoner][10] har aktiverats i SuperOffice kan du välja vilken tidszon händelsen ska skapas i. Tidszonerna visas efter land och du kan söka både efter land och ort direkt i fältet tidszon.

### Start / Slut/Tidsgräns / Varaktighet

I fälten **Start** och **Slut** (för bokningar och samtal) eller **Tidsgräns** (för uppgifter) skriver du in datum och eventuellt klockslag för händelsens start respektive slut eller tidsgräns. Om du anger klockslag justeras innehållet i fältet **Varaktighet** automatiskt efter detta.

> [!TIP]
> Om händelsen medför en konflikt med en annan händelse eller har flera deltagare visas fältet **Första lediga**, där den första lediga mötestiden visas.

### Hela dagen

Om du markerar **Hela dagen** ställs tiden för bokningen in på det som har angetts som standardarbetsdag.

> [!TIP]
> Standardinställningen anges i dialogrutan [Inställningar][13]. Välj **Kalender** och välj önskat klockslag för **Dagen startar** och **Dagen slutar**.

### Plats

Här kan du välja adressen där händelsen ska ske. Som standard är det här fältet tomt, men om du klickar på pilen ![ikon][img2] bredvid fältet visas två poster i en listruta. Den ena är användarens företag och den andra är det företag som ska följas upp.

Om du har angett en resurs av typen **Plats** (till exempel ett mötesrum) som deltagare på fliken **Deltagare** visas även den i listrutan.

> [!TIP]
> Du kan också skriva in en egen adress för platsen.

Slutförd ![ikon][img5] ![ikon][img6]

Markera det här alternativet när [händelsen har slutförts][11].

### Uppgift

![ikon][img1]

Klicka på den här knappen för att öppna relevanta uppgifter som kan utföras på den aktiva posten. Exempel: Ta bort, Skriv ut, Skicka som e-post, Tilldela till och Avboka möte. Under Inställningar och underhåll kan du även definiera egna uppgifter och lägga till dem under knappen **Uppgift**.

### Registrerad/Senast ändrad

I dessa fält visas datum för när händelsen registrerades första gången och när den senast ändrades. Här ser du även vem som har utfört handlingarna.

> [!TIP]
> Om du håller muspekaren över den här texten visas en inforuta med mer information om när händelsen skapades och eventuellt senast ändrades.

## Fliken Beskrivning

På den här fliken kan du lägga till en beskrivning av händelsen. Du kan använda den här funktionen för fritextsökning. Beskrivningen får inte vara längre än 2 048 tecken.

## Fliken Detaljer

Fliken **Detaljer** innehåller detaljerad information om händelsen.

### Upprepning

I det här fältet anger du om händelsen är återkommande. Klicka på ordet **Aldrig** till höger om fältet **Upprepning** om du vill att [bokningen ska upprepas][4] med jämna mellanrum. Om en händelse är återkommande visas en ikon ![ikon][img1] längst upp till vänster i huvuddelen av dialogrutan.

### Prioritet

Här anger du prioritet för händelsen. Om du klickar på pilen visas en lista med standardalternativ för hög, normal och låg prioritet. [!include[SM](../../../learn/includes/are-defined-sm.md)]

### Alarm

Om du vill aktivera aviseringar för händelsen markerar du **Alarm**. Om ett [alarm har valts][5] för en händelse visas en ikon ![ikon][img2] längst upp till vänster i huvuddelen av dialogrutan.

### Ägare

Ange vem som äger händelsen. Som standard är ägaren den inloggade användaren. Om du klickar på namnet bredvid fältet **Ägare** kan du överföra bokningen till en annan SuperOffice-användare. Dialogrutan **Överför till** visas. Under fältet **Tilldela händelsen till** finns en listruta där du kan välja önskad användargrupp. Välj önskad användare och klicka på **OK** för att spara ändringarna och stänga dialogrutan.

> [!NOTE]
> Om en användare redan är upptagen vid den aktuella tidpunkten visas ordet **KONFLIKT** i fältet **Status**. Om du vill dölja användare med konflikter markerar du **Dölj konflikt** längst ned i dialogrutan.

### Visa som

Markera **Ledig** eller **Upptagen** i fältet **Visa som** för att ange om du är tillgänglig för andra medan bokningen pågår. Om du väljer **Ledig** kan du ha andra händelser samtidigt, till exempel om du har avsatt större delen av dagen för arbete med ett projekt men ändå har tid för korta möten.

### Synlig för

Klicka i fältet **Synlig för** för att visa en lista där du kan välja om händelsen ska vara synlig för alla användare, bara synlig för den användare som definierats som ägare eller synlig för alla användare i användargruppen som användaren tillhör.

> [!NOTE]
> Om du anger att händelsen bara ska vara synlig för ägaren visas posten i kursiv stil på detaljkortet **Aktiviteter**.

Det här alternativet är bara tillgängligt om **Konfidentiella aktiviteter** har aktiverats för den aktuella användaren under Inställningar och underhåll.

### Publicera (separat licens krävs)

Markera det här alternativet om du vill att händelsen ska vara synlig för externa användare.

## Fliken Deltagare

Den här fliken innehåller en [lista över deltagare][6] i händelsen. Registrerade deltagare är markerade med en prick.

Om du klickar på ikonen **Visa som grupp** ![ikon][img7] längst ner till höger på fliken **Deltagare** öppnas fliken **Visa** i kalendern där du får en översikt över [de inbjudna medarbetarnas kalendrar][7] (SuperOffice-användare).

## Fliken Länkar

Den här fliken innehåller information om URL:er, aktiviteter (dokument och händelser), projekt och försäljningar som har [kopplats till den aktuella händelsen][8]. Om något är registrerat på den här fliken visas en knappnålssymbol bredvid **Länkar**.

## Fliken Mer

På den här fliken visas alla [egendefinierade fält][14] som har konfigurerats under Inställningar och underhåll. Om inte konfigurerat visas inte den här fliken.

<!-- Referenced links -->
[1]: ../follow-ups.md
[4]: ../recurrence/index.md
[5]: ../set-alarm.md
[6]: ../invitation/index.md
[7]: ../other-diaries.md
[8]: ../linking-documents-to-follow-ups.md
[9]: ../video-meetings.md
[10]: ../../../globalization-and-localization/learn/time-zones.md
[11]: ../change-completed-status.md
[13]: ../../../learn/getting-started/preferences.md
[14]: ../../../custom-objects/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../../common/icons/dropdown-icon.png
[img3]: ../../../../../common/icons/videocall-off.png
[img4]: ../../../../../common/icons/videocall.png
[img5]: ../../../../media/icons/followup-not-completed.png
[img6]: ../../../../media/icons/followup-completed.png
[img7]: ../../../../../common/icons/diary-participants.png

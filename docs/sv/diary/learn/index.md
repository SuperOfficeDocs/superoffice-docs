---
uid: help-sv-diary
title: Kalender
description: SuperOffice-kalendern är en central funktion i ditt CRM-system. De här guiderna förklarar hur du använder kalendern.
keywords: kalender, kalenderfönster, händelse, att-göra-lista, uppgift, bokning, möte, telefon, samtal
author: Bergfrid Dias
date: 09.17.2025
version: 11.3
content_type: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/diary/learn/screen
---

# Kalender

Kalender-fönstret är den centrala platsen i SuperOffice CRM för att hantera [händelser][1] (möten, uppgifter eller samtal). Det består av en kalender och en att-göra-lista som hjälper dig att hålla dig organiserad och produktiv.

![Kalenderfönster som visar en veckovy och en att göra-lista -screenshot][img1]

Kalendern består av följande huvudkomponenter:

* **Kalender:** Visar händelser som är planerade till specifika datum och tider. Det fungerar som en digital almanacka med separata vyer för dag, vecka och månad.
* **Att-göra-lista:** Visar (icke slutförda) aktiviteter utan specifika tider, såsom uppgifter och försäljningar.

Med flexibla vyer säkerställer kalendern smidig planering och samarbete, så att du enkelt kan strukturera din dag, vecka eller månad.

## <a id="open"></a>Öppna kalendern

För att öppna din kalender, klicka på **Kalender** i navigatorn och välj en tidsperiod från listan, eller klicka på **Idag** eller **Innevarande vecka** för att snabbt gå till aktuell dag eller vecka. Ditt namn visas längst upp till höger i kalendern.

Händelser visas i kalendern som färgade tidsblock, vilket representerar deras typ och varaktighet. Varje block innehåller information såsom företag, typ och beskrivning. Dubbelklicka på en händelse för att öppna den.

Följande symboler ger visuella ledtrådar om händelsen och eventuella åtgärder du kan vidta:

| Symbol | Beskrivning | Läs mer |
|:-:|---|---|
| <i class="ph ph-arrows-clockwise" aria-label="Återkommande händelse"></i> | Detta är en återkommande händelse. | [Skapa återkommande händelser][8] |
| <i class="ph ph-user-circle" aria-label="Flera deltagare"></i> | Händelsen har flera deltagare. | [Bjud in andra användare till en händelse][11] |
| <i class="ph ph-check" aria-label="Slutförd händelse"></i> | Händelsen är slutförd. | [Ändra Slutförd-status för en aktivitet][7] |
| <i class="ph ph-bell" aria-label="Påminnelse"></i> | Händelsen har en aktiv larm. | |
| <i class="ph ph-question" aria-label="Obesvarade inbjudningar"></i> | Det finns obesvarade inbjudningar för denna händelse. | [Status för inbjudningar][10] |
| <i class="ph ph-video-camera" aria-label="Videomöte"></i> | Detta är ett videomöte. För att ansluta, högerklicka på händelsen och välj **Anslut till möte**. | [Arbeta med videomöten][6] |

Administratörer definierar händelsetyper, inklusive deras färger, i Inställningar och underhåll.

## <a id="nav"></a>Navigera i kalendern

Du kan enkelt bläddra mellan datum eller tidsperioder i kalendern:

* Välj fliken **Dag**, **Vecka** eller **Månad** för att justera kalenderns detaljeringsnivå. Sidhuvudet uppdateras för att visa aktuell dag, vecka eller månad beroende på vilken vy du har valt.

* Använd knapparna **Föregående** och **Nästa** (<i class="ph ph-caret-circle-left" aria-hidden="true"></i><i class="ph ph-caret-circle-right" aria-hidden="true"></i>) för att bläddra framåt eller bakåt.

* För att snabbt hoppa till ett specifikt datum, vecka eller månad:
  * Klicka på ett datum för att öppna fliken **Dag** för det datumet.
  * Klicka på ett veckonummer för att visa den veckan i fliken **Vecka**.
  * Klicka på en månad (tillgänglig i sidopanelen) för att växla till fliken **Månad** för den månaden.

* Klicka på **Idag** eller **Innevarande vecka** för att återgå till aktuell dag eller vecka.

## <a id="tabs"></a>Flikar i kalendern

Kalendern har fyra huvudsakliga vyer. Använd dessa flikar för att växla mellan olika perspektiv:

<!-- markdownlint-disable MD051 -->
### [Fliken Dag](#tab/day)

Fliken **Dag** visar en enskild dag med timintervall längs vänsterkanten. Den här vyn är idealisk för att hantera ditt schema timme för timme.

![Kalenderfönster, fliken Dag -screenshot][img2]

Viktiga funktioner:

* Navigera enkelt till olika datum med hjälp av knappen **Idag** eller knapparna **Föregående** och **Nästa** (<i class="ph ph-caret-circle-left" aria-hidden="true"></i><i class="ph ph-caret-circle-right" aria-hidden="true"></i>).

* Lägg till eller omplanera händelser genom att dra och släppa dem i tidslinjen.

### [Fliken Vecka](#tab/week)

Fliken **Vecka** visar en vecka i taget, där dagar representeras som kolumner och timmar som rader.

![Kalenderfönster, fliken Vecka -screenshot][img3]

Viktiga funktioner:

* Klicka på en dag i sidhuvudet för att snabbt öppna den i fliken **Dag**.
* Se överlappande händelser tydligt i samma tidsblock.

> [!TIP]
> Om du vill ändra vilken dag veckan börjar på (söndag eller måndag), gå till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Inställningar**.

### [Fliken Månad](#tab/month)

Fliken **Månad** ger en överblick över alla händelser planerade under en viss månad.

![Kalenderfönster, fliken Månad -screenshot][img4]

Viktiga funktioner:

* Håll muspekaren över en händelse för att se en hjälptext med ytterligare information.
* Klicka på ett datum för att gå direkt till fliken **Dag** för mer detaljer.

### [Fliken Översikt](#tab/view)

Fliken **Översikt** låter dig visa och hantera gruppscheman samt kontrollera tillgänglighet.

![Kalenderfönster, fliken Översikt -screenshot][img5]

Viktiga funktioner:

* **Gruppvyer:** Kombinera scheman för flera användare eller resurser i en enskild vy. Välj en fördefinierad grupp från listan (<i class="ph ph-caret-down" aria-label="Dropdown icon"></i>) eller skapa och hantera egna gruppvyer via menyn **Uppgift** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>).

* **Visningslägen:** Växla mellan sid-vid-sid-vy och schemaläggningsvy med hjälp av växlingsknapparna (<i class="ph ph-columns" aria-label="Kolumner"></i>/<i class="ph ph-rows" aria-label="Rader"></i>) längst upp till höger.

För detaljerade instruktioner om hur du skapar och hanterar gruppvyer, se [Gruppvy][2].

> [!TIP]
> När du är i en gruppvy kan du skapa händelser för andra användare direkt i kalendern.

***
<!-- markdownlint-enable MD051 -->

Nere till vänster i kalendern finns ett fält för att välja [tidszon][20], om tidszoner har aktiverats.

## <a id="section-tabs"></a>Detaljkorten i kalenderfönstret

Den nedre delen av kalenderfönstret består av detaljkort som tillsammans utgör din att-göra-lista. Dessa inkluderar:

* **Aktiviteter:** Fungerar som en att-göra-lista och visar händelser utan specifika starttider för den valda användaren. Se [Detaljkortet Aktiviteter][12].

* **Försäljning:** Ger en översikt över försäljningsprocessen och schemalagda aktiviteter kopplade till försäljningar för den valda användaren. Det hjälper dig att spåra framsteg och hantera kommande uppgifter. Se [Detaljkortet Försäljning][13].

Detaljkorten i kalendern kan antingen visas under kalendern eller som en femte vy - fliken **Att-göra-lista** - beroende på dina inställningar.

När detaljkorten visas *under* kalendern (klassisk vy) förblir de synliga oavsett vilken kalenderflik du väljer, vilket gör att du enkelt kan förhandsgranska försäljningar eller händelser i sidopanelen medan du planerar i kalendern. När de visas *i* kalendern som en vy (ny vy) sparar du utrymme för själva kalendern.

![Kalenderfönster med detaljkorten visade i Att-göra-listan -screenshot][img6]

## Sidopanelen i kalendern

[Sidopanelen][17] finns på höger sida av kalenderfönstret och ger snabb åtkomst till ytterligare verktyg som månadsöversikten, förhandsgranskning av händelser eller SuperOffice Copilot.

Om du väljer ett datum, en vecka eller en månad i sidopanelen uppdateras kalendern för att matcha. På samma sätt uppdateras sidopanelen när du navigerar i kalendern.

## Personliga inställningar

Du kan anpassa kalendern efter ditt arbetsflöde:

1. Gå till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Inställningar**.

1. Välj **Standardvärden** och justera inställningar såsom:
    * Standardlängd och typ för nya möten.
    * Standardtitel för nya att göra.
    * Max antal händelser som visas i **Dag**-vyn.

1. Välj **Kalender** och anpassa inställningar såsom:
    * Standardlarmtider.
    * Start- och sluttider för heldagsaktiviteter.
    * Första veckodagen (söndag eller måndag).
    * Om att-göra-listan ska visas under kalendern eller som en separat flik.

1. Välj **Funktioner** och anpassa inställningar såsom:
    * Visa veckonummer i kalendrar.
    * Antal dagar framåt som ska visas i sektionerna **Aktiviteter** och **Försäljning**.
    * Markera förfallna aktiviteter.

1. Välj **Visuella effekter** och anpassa inställningar såsom:
    * Ta bort slutförda aktiviteter automatiskt.
    * Visa verktygstips.

1. Klicka på **Spara** för att tillämpa dina ändringar.

![Personliga inställningar för kalendern -screenshot][img7]

## Tips för effektivitet

* Få åtkomst till en annan användares eller resurs kalender för att kontrollera deras tillgänglighet eller skapa händelser direkt. För att se flera kalendrar samtidigt, skapa en [gruppvy][2].

* Minimera distraktioner genom att dölja sidopanelen och/eller navigatorn med hjälp av växlingsknappen (<i class="ph ph-sidebar-simple" aria-hidden="true"></i>).

* Använd kalendern för att visa, redigera och ta bort [aktiviteter][16] efter behov, så att ditt schema alltid är uppdaterat.

* Koppla regelbundet aktiviteter till en kontakt eller ett företag för att bibehålla en tydlig historik över teamets interaktioner och främja smidigt samarbete.

* För att förhandsgranska och hantera försäljningar eller aktiviteter medan du visar din kalender, aktivera inställningen **Visa aktivitetslistor under dagbok**. Detta visar detaljkorten under kalendern – precis som i andra skärmbilder – så att de förblir synliga oavsett vald kalendervy.

* Växla mellan sid-vid-sid-vy och schemaläggningsvy i **Översikt**-fliken för att välja det layoutalternativ som passar din planering bäst.

> [!TIP]
> Använd menyn **Inställningar** för att anpassa kalenderns layout, justera tidsinställningar eller aktivera funktioner som larm på händelser.

## Relaterat innehåll

* [Skapa eller kopiera en händelse (möte, att göra)][5]
* [Skapa återkommande händelse][8]
* [Bjud in medarbetare till en händelse][10]
* [Redigera eller ta bort händelse][3]
* [Ändra sluttid för en händelse][4]
* [Anslut till videomöten][6]
* [Skriva ut händelser][14]
* [Lägg till länk till dokument, försäljning, projekt eller webbplats][15]
* [Arbeta med händelser i API][50]

<!-- Referenced links -->
[1]: follow-ups.md
[2]: group-view.md
[3]: edit-follow-up.md
[4]: edit-follow-up.md#change-end
[5]: create-follow-up.md
[6]: video-meetings.md
[7]: change-completed-status.md
[8]: recurrence/create.md
[10]: invitation/index.md#status
[11]: invitation/add-attendee.md
[12]: ../../learn/section-tabs/activities-tab.md
[13]: ../../learn/section-tabs/sales-tab.md
[14]: ../../learn/basics/print.md
[15]: ../../learn/basics/links.md
[16]: ../../learn/basics/activity.md
[17]: ../../learn/getting-started/main-screen/side-panel.md
[20]: ../../localization/learn/time-zones.md
[50]: ../../../en/diary/reference/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/diary.png
[img2]: ../../../media/loc/en/diary/day-plan.png
[img3]: ../../../media/loc/en/diary/week-plan.png
[img4]: ../../../media/loc/en/diary/month-plan.png
[img5]: ../../../media/loc/en/diary/view-tab.png
[img6]: ../../../media/loc/en/diary/activities-list.png
[img7]: ../../../media/loc/en/diary/preferences.png

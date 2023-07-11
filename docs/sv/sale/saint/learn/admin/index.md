---
uid: help-sv-saint-admin
title: Konfigurera SAINT
description: Lär dig hur du konfigurerar SuperOffice SAINT i den här guiden.
author: SuperOffice RnD
so.date: 02.22.2023
keywords: försäljning, SAINT
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Konfigurera SAINT

Du kan följa upp dina kunder proaktivt genom att använda SAINT, som står för Sales Intelligence. SuperOffice SAINT kan användas på många sätt och för många olika processer. Innan du implementerar SAINT-funktionen är det viktigt att veta vad du vill förbättra och hur du kan analysera detta.

När du vet vad du vill förbättra, försök att tänka på de åtgärder ditt företag kan vidta för att förbättra den befintliga situationen. Vilka åtgärder kommer du att vidta?

* Skicka ut ett grupputskick med hjälp av SuperOffice-utskick
* Ring alla kunder i SAINT-urvalet
* Följ upp alla ärenden

[!include[Requirement](../includes/note-saint-req.md)]

På fliken **Statusövervakning/SAINT** i kan du skapa statusar för företag, kontakter och projekt. Statusövervakning är funktionaliteten bakom Sales Intelligence (SAINT). Detta underlättar uppföljningen av företag, kontakter och projekt och ger mer intelligenta sökfunktioner i SuperOffice CRM.

## Statusbilder

Status kan visas som bilder på projekt-, kontakt- eller företagskort om de uppfyller dina kriterier. En kund som du inte har haft kontakt med på ett tag kan till exempel ha ett spindelnät som statusbild. Då får du en visuell, direkt indikation på hur förhållandet till kunden är eller hur det går med ett projekt. När användaren klickar på eller håller muspekaren över en statusbild i SuperOffice CRM visas en del text. Till exempel för att ange de åtgärder som bör vidtas (du anger själv texten när du skapar statusen).

## Standardhändelse för status

När dialogrutan för status öppnas i SuperOffice CRM, får man också möjlighet att skapa en händelse för den aktuella statusen. Händelsetyp och händelsetext kan fördefinieras.

### Exempel

En status kan gälla för till exempel alla företag som uppfyller följande kriterier:

* Kategori = Kund
* Den senaste försäljningen var för över 2 månader sedan
* Antal försäljningar är över 50

Texten i fältet **Beskrivning** kan till exempel vara:

"&lt;name&gt; har tidigare varit en bra kund, men vi har inte sålt något till dem på två månader. &lt;cont&gt; är huvudkontakt för den här kunden och bör snarast ta kontakt med kunden på telefon (&lt;cpho&gt;) eller e-post (&lt;mail&gt;) och ta reda på varför."

I detta exempel användes följande mallvariabler för att skräddarsy texten till det aktuella företaget:

| Variabel | Beskrivning |
|---|---|
| name | Företagets namn |
| cont | Namnet på vår kontakt för företaget |
| cpho | Företagets telefonnummer |
| mail | Företagets e-postadress |

## Sökningar och urval

Statusar och räknare kan användas i sökningar och när du skapar dynamiska urval. Du kan till exempel söka efter företag. kontakter eller projekt som har en viss status eller räknare. [!include[Define counter](../../../learn/includes/def-counter.md)]

Du kan ställa in tre olika räknare/perioder, och dessa räknare är det antal dagar du vill räkna med aktiviteter, försäljning och ärenden. De olika perioderna beror på vad som är viktigt för dig. Om du till exempel vill bli meddelad om några av dina kunder inte har haft några under aktiviteter den senaste månaden (30 dagar), eller om det finns olösta kundärenden som är äldre än 30 dagar.

## Perioder

Du kan ange upp till tre olika perioder, så att SAINT-kriterierna kan omfatta kortare eller längre perioder. Om du anger tre perioder på 30, 60 och 90 dagar kan du välja SAINT-kriterier för var och en av dessa perioder.

## Skapa nya status

Logga först in på SuperOffice CRM, gå till huvudmenyn i det övre högra hörnet och öppna Inställningar och underhåll, klicka på SAINT i navigatorn. Där kan du ställa in din Sales Intelligence- och statusövervakning.

För att skapa en status:

1. [Skapa ny status][1]
1. [Välja bild för status][2]
1. [Välja typ av standardhändelse för status][3]
1. [Ange statuskriterier][4]
1. [Ange periodlängd][5]

Nu kan du gå tillbaka till SuperOffice CRM och öppna ett nytt dynamiskt urval för att se alla kontakter du måste följa upp.

Se till att lägga till dina SAINT-kriterier. Klicka på lägg till, klicka sedan bredvid fältet och välj Företag – Räknare (SAINT). Leta upp din SAINT-statusövervakning. I vårt exempel väljer vi Försummade kunder och klickar på OK. Uppdatera ditt urval, så vet du exakt vilka kunder som behöver följas upp.

## Återskapa och redigera statusar

* [Återskapa en borttagen status][6]
* [Redigera statusbeskrivning][7]

## Administrera och underhålla statusövervakning

* [Administrera statusövervakning][8]

<!-- Referenced links -->
[1]: create-status.md
[2]: select-image-for-status.md
[3]: select-default-follow-up-type-for-status.md
[4]: select-status-criteria.md
[5]: select-period-length.md
[6]: restore-status.md
[7]: edit-status.md
[8]: manage-status-monitors.md

<!-- Referenced images -->

---
uid: help-sv-saint-admin
title: Konfigurera SAINT
description: Lär dig hur du konfigurerar SuperOffice SAINT i den här guiden.
keywords: SAINT, statusövervakning
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/sale/saint/learn/admin/index
index: true
---

# Konfigurera SAINT

Du kan följa upp dina kunder proaktivt genom att använda SAINT, som står för Sales Intelligence. SuperOffice SAINT kan användas på många sätt och för många olika processer. Innan du implementerar SAINT-funktionen är det viktigt att veta vad du vill förbättra och hur du kan analysera detta.

När du vet vad du vill förbättra, försök att tänka på de åtgärder ditt företag kan vidta för att förbättra den befintliga situationen. Vilka åtgärder kommer du att vidta?

* Skicka ut ett grupputskick med hjälp av SuperOffice-utskick
* Ring alla kunder i SAINT-urvalet
* Följ upp alla ärenden

[!include[Requirement](../includes/note-saint-req.md)]

På fliken **Statusövervakning/SAINT** i kan du skapa statusar för företag, kontakter och projekt. Statusövervakning är funktionaliteten bakom Sales Intelligence (SAINT). Detta underlättar uppföljningen av företag, kontakter och projekt och ger mer intelligenta sökfunktioner i SuperOffice CRM.

![SAINT screen with status list, description, image, and criteria -screenshot][img1]

## Statuslistan

Statuslistan på flikarna **Företag**, **Kontakt** och **Projekt** visar aktiva statusmonitorer för denna post och – om **Visa borttagna** är markerat – även raderade.

| Element | Beskrivning |
|---|---|
| **Visualisera-ikon** <i class="ph ph-eye" aria-label="eye"></i> | Anger om en statusbild visas på företags-, kontakt- eller projektkort. Ikonen visas endast om **Visualisera**-rutan är markerad. |
| **Rött X** | Visas bredvid statusar som måste [regenereras][8]. Dessa statusar uppdateras inte och returnerar inte aktuella data. |
| **Namnkolumn** | Visar namnen på statusarna. Raderade statusar visas i rött om **Visa borttagna** är markerat under listan. |
| **Prioritetskolumn** | Anger vilken statusbild som visas på kortet när ett företag, en kontakt eller ett projekt matchar kriterierna för flera statusar. Statusen med högsta prioritet visas, medan andra aktiva statusar är tillgängliga som länkar i statusdialogen. |

## Statusbilder

Status kan visas som bilder på projekt-, kontakt- eller företagskort om de uppfyller dina kriterier. En kund som du inte har haft kontakt med på ett tag kan till exempel ha ett spindelnät som statusbild. Då får du en visuell, direkt indikation på hur förhållandet till kunden är eller hur det går med ett projekt. När användaren klickar på eller håller muspekaren över en statusbild i SuperOffice CRM visas en del text. Till exempel för att ange de åtgärder som bör vidtas (du anger själv texten när du skapar statusen).

## Standardhändelse för status

När dialogrutan för status öppnas i SuperOffice CRM, får man också möjlighet att skapa en händelse för den aktuella statusen. Händelsetyp och händelsetext kan fördefinieras.

## Sökningar och urval

Statusar och räknare kan användas i sökningar och när du skapar dynamiska urval. Du kan till exempel söka efter företag. kontakter eller projekt som har en viss status eller räknare. [!include[Define counter](../includes/def-counter.md)]

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

## <a id="database"></a>+Hur SAINT lagrar räknare och statusar

SAINT-räknare lagras i [countervalue][13]-tabellen och uppdateras automatiskt när du utför handlingar:

* När SAINT är aktiverat, skapas ett antal räknarposter varje gång en kontakt eller ett projekt skapas.

* Varje gång en händelse, ett dokument eller en försäljning skapas uppdateras motsvarande räknarposter.

SAINT-värden är enkla binära värden (på eller av) som bestämmer utseendet på företags- och projektkort. Dessa värden lagras i [statusvalue][14]-tabellen.

<!-- Referenced links -->
[1]: create-status.md
[2]: select-image-for-status.md
[3]: select-default-follow-up-type-for-status.md
[4]: select-status-criteria.md
[5]: select-period-length.md
[6]: restore-status.md
[7]: edit-status.md
[8]: update.md#regen
[13]: ../../../../en/database/tables/countervalue.md
[14]: ../../../../en/database/tables/statusvalue.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/status-monitors-company-tab.png

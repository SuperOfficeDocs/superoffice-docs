---
uid: help-sv-saint-admin
title: SAINT i Inställningar och underhåll
description: Lär dig om nyckelbegreppen i SuperOffice SAINT, inklusive kriterier, bilder, räknare och standarduppföljningar.
keywords: SAINT, aktivitetsövervakning, statusövervakning
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
redirect_from: /sv/sale/saint/learn/admin/index
---

# SAINT i Inställningar och underhåll

SAINT (Sales Intelligence) hjälper dig att övervaka företag, kontakter och projekt så att du kan följa upp vid rätt tidpunkt. En **aktivitetsövervakning** (även känd som statusövervakning) kombinerar kriterier, räknare och valfria egenskaper för att framhäva poster som behöver uppmärksamhet.

Innan du implementerar SAINT är det viktigt att veta vad du vill förbättra och hur du ska analysera det. Överväg sedan vilka proaktiva åtgärder ditt företag kan vidta för att förbättra den nuvarande situationen. Till exempel:

* Skicka en gruppeutskick
* Ringa alla kunder i SAINT-urvalet
* Följa upp alla förfrågningar

[!include[Requirement](../includes/note-saint-req.md)]

![SAINT-skärm med statuslista, beskrivning, bild och kriterier -screenshot][img1]

## Statuslistan

Statuslistan på flikarna **Företag**, **Kontakt** och **Projekt** visar aktiva statusövervakningar för den enheten och, om **Visa borttagna** är valt, även borttagna.

| Element | Beskrivning |
|---|---|
| **Visualisera-ikon** <i class="ph ph-eye" aria-label="eye"></i> | Anger om en statusbild visas på företags-, kontakt- eller projektkort. Ikonen visas endast om **Visualisera**-rutan är markerad. |
| **Rött X** | Visas bredvid statusar som måste [regenereras][8]. Dessa statusar uppdateras inte och returnerar inte aktuella data. |
| **Namnkolumn** | Visar namnen på statusarna. Raderade statusar visas i rött om **Visa borttagna** är markerat under listan. |
| **Prioritetskolumn** | Anger vilken statusbild som visas på kortet när ett företag, en kontakt eller ett projekt matchar kriterierna för flera statusar. Statusen med högsta prioritet visas, medan andra aktiva statusar är tillgängliga som länkar i statusdialogen. |

## Egenskaper

En statusövervakning kombinerar flera egenskaper som definierar hur den fungerar:

* **Kriterier:** Varje status måste innehålla ett eller flera kriterier. Dessa villkor bestämmer vilka företag, kontakter eller projekt som statusen gäller för. Du kan till exempel definiera en status för kunder utan försäljning de senaste 90 dagarna.

* **Statusbilder:** En valfri bild kan visas på företags-, kontakt- eller projektkort som uppfyller kriterierna. Till exempel kan ett spindelnät indikera inaktivitet. Bilder visas som ljusa vattenstämplar och kan klickas för fler detaljer.

* **Standarduppföljning:** När en användare klickar på statusen kan de skapa en händelse. Typen och beskrivningen kan vara fördefinierad, så händelsen tydligt anger vilken åtgärd som krävs.

## Räknare och perioder

Räknare [spårar aktivitet över tid][5], såsom försäljning, förfrågningar eller slutförda händelser.
Du kan använda räknare i sökningar och urval för att identifiera poster som uppfyller eller inte uppfyller vissa tröskelvärden.

Du kan definiera upp till tre olika perioder (till exempel 30, 60 och 90 dagar).
Detta låter dig använda samma räknare, såsom "Antal försäljningar", på olika tidsintervall.

## <a id="database"></a>Hur SAINT lagrar räknare och statusar

SAINT-räknare lagras i [countervalue][13]-tabellen och uppdateras automatiskt när du utför handlingar:

* När SAINT är aktiverat, skapas ett antal räknarposter varje gång en kontakt eller ett projekt skapas.

* Varje gång en händelse, ett dokument eller en försäljning skapas uppdateras motsvarande räknarposter.

SAINT-värden är enkla binära värden (på eller av) som bestämmer utseendet på företags- och projektkort. Dessa värden lagras i [statusvalue][14]-tabellen.

## Relaterat innehåll

* [Ställ in en ny statusövervakning][1]
* [Visualisera statusar med bilder][2]
* [Räknare och räknarinställningar][5]
* [Uppdatera, ta bort och återställa statusövervakningar][7]
* [Regenerera statusövervakningar och räknare][8]

<!-- Refererade länkar -->
[1]: set-up.md
[2]: set-up.md#image
[5]: counter-settings.md
[7]: update.md
[8]: update.md#regen
[13]: ../../../en/database/tables/countervalue.md
[14]: ../../../en/database/tables/statusvalue.md

<!-- Refererade bilder -->
[img1]: ../../../media/loc/en/saint/status-monitors-company-tab.png

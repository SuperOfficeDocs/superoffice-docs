---
uid: help-sv-selection
title: Urval
description: Urval
keywords: dynamiskt urval, statiskt urval, kombinerat urval, urvalsskärmen, urvalsmedlemmar, urval
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/search-options/selection/learn/combined-selections
  - /sv/search-options/selection/learn/dynamic-selections
  - /sv/search-options/selection/learn/static-selections
  - /sv/search-options/selection/learn/screen/index
---

# Urval

Du kan skapa urval av poster/data som du arbetar med mycket. Om du har licens för Sales Quote Access, kan du även skapa produkturval.

> [!TIP]
> Du kan skapa diagram från urval och även använda urval för att skapa utskick.

Alla urval innehåller även uppgifter om vilka företag och kontakter som är kopplade till posterna i urvalet. Till exempel företag och kontakter kopplade till försäljningen i ett försäljningsurval.

## <a id="types"></a>Typer

I SuperOffice CRM finns det tre olika typer av urval:

* **Statiskt urval:** Innehåller endast manuellt tillagda medlemmar.
* **Dynamiskt urval:** Uppdateras automatiskt med medlemmar som uppfyller urvalskriterierna.
* **Kombinerat urval:** En kombination av två befintliga urval.

### Statiska urval

Ett statiskt urval innehåller endast de medlemmar du har lagt till manuellt eller via en sökning, till skillnad från ett dynamiskt urval. När du har skapat ett statiskt urval och lagt till medlemmar, kommer det att förbli oförändrat tills du manuellt lägger till eller tar bort medlemmar.

Använd ett statiskt urval om du vill ha full kontroll över vilka medlemmar som ingår. Du kan [lägga till och ta bort medlemmar manuellt][7], antingen en i taget eller via en sökning.

**Exempel:** En noggrant utvald lista med VIP-kunder för en personlig marknadsföringskampanj.

### Dynamiska urval

Ett dynamiskt urval fungerar som en sparad sökning som körs varje gång du öppnar urvalet. När du lägger till poster i SuperOffice CRM som uppfyller urvalets sökkriterier, uppdateras urvalet automatiskt med de nya medlemmarna – till skillnad från ett statiskt urval.

Använd ett dynamiskt urval om du vill ha en alltid uppdaterad lista över företag, kontakter, försäljningar, projekt, dokument, händelser, ärenden eller produkter som uppfyller specifika kriterier.

**Exempel:** En realtidslista över alla öppna affärsmöjligheter under det aktuella kvartalet, som automatiskt uppdateras när nya affärer skapas.

### Kombinerade urval

Ett kombinerat urval är en kombination av två befintliga urval (statiska eller dynamiska). Det kan innehålla poster som är gemensamma för båda urvalen, poster som skiljer sig åt, poster som bara finns i ett av urvalen eller alla poster från båda urvalen.

**Exempel:** En filtrerad lista över alla kunder som har köpt en specifik produkt och samtidigt har ett öppet supportärende, vilket hjälper dig att prioritera uppföljningar.

Efter att du har [skapat ett kombinerat urval][4] kan du välja att omvandla det till ett statiskt urval.

## <a id="tabs"></a>Flikar i urvalsskärmen

| Flik | Beskrivning |
|---|---|
| Medlemslistan | Visar listan med poster i urvalet. |
| Företag/kontakt | Visar företag och kontakter kopplade till urvalsmedlemmar. Om urvalet är för företag eller kontakter är detta den enda fliken med medlemmar. |
| Kriterier | Visa och [redigera kriterier][9] för ett dynamiskt urval. |
| Specifikation | Visa och redigera allmän information om urvalet. |
| Diagram | [Visa urvalsdata som ett diagram.][3] Diagram kan också användas i [dashboards][16]. |
| Utskick | Visar utskick som är arkiverade för detta urval. [Skapa ett utskick][8] för kontakter i urvalet. |

> [!TIP]
> Klicka på <i class="ph ph-gear" aria-label="Gear"></i> till höger om kolumnrubrikerna i ett urval för att gruppera och filtrera poster, lägga till/ta bort kolumner och ange beräkningar. Dessa inställningar kan sparas för det aktiva urvalet genom att välja **Spara kolumner endast för markerat urval**.

## <a id="members"></a>Urvalsmedlemmar

Den första fliken i urvalet visar posterna i urvalet. Dubbelklicka på en post för att öppna och visa dess detaljer.

Layouten varierar beroende på vad urvalet innehåller. Alla urval utom **Företag/kontakt** har två listor: en för urvalsdata och en för kopplade företag och kontakter.

> [!NOTE]
> Som standard visas endast de första 100 posterna. För att ändra detta, gå till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Inställningar** > **Funktioner** > **Arkivsidstorlek**.

### <a id="filter"></a>Filtrera listan med medlemmar

1. Klicka på **Visa alla** i flikens sidfot för att inkludera alla poster.

1. För att aktivera [kolumnfiltret][12], klicka på <i class="ph ph-gear" aria-label="Gear"></i> och välj **Aktivera filter**. Filterknappen (<i class="ph ph-funnel" aria-hidden="true"></i>) kommer då att visas i filtrerbara kolumner.

## Knappar

| Knapp | Namn | Beskrivning |
|---|---|---|
| <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i> | Uppgiftsmeny | Utför olika uppgifter för urvalsmedlemmar, såsom att skicka e-post, massredigera och exportera. De tillgängliga uppgifterna beror på posttypen i fältet **Urval av**. |
| <i class="ph ph-arrow-clockwise" aria-hidden="true"></i> | Uppdatera | Uppdaterar data i listan. |
| **Antal: nummer** | | Visar antalet medlemmar i det aktiva urvalet. |
| <i class="ph ph-download-simple" aria-hidden="true"></i> | Exportera | [Exportera listan till ett kalkylark.][6] |

## <a id="ex"></a>Exempel på hur du kan använda urval

Urval gör det möjligt att gruppera och filtrera data baserat på specifika kriterier. Nedan finns exempel på olika typer av urval och deras potentiella användningsområden.

### Företag

Du kan skapa ett dynamiskt urval som innehåller alla företag i kategorin *Leverantör* med huvudkontor i Tyskland, om du planerar att utöka verksamheten i Tyskland.

### Kontakter

* Alla kontakter som skapats de senaste 30 dagarna.
* Alla kontakter där *julkort* eller *nyhetsbrev* är definierat som en intresse.

### Försäljning

Ett urval med alla försäljningar som du har genomfört under första kvartalet, eller alla dina försäljningar med statusen **Uppskjuten**, hjälper dig att identifiera trender och prioritera din framtida försäljningsstrategi.

> [!TIP]
> [Gruppera kolumner och summera belopp][10] för att identifiera trender och få en tydlig överblick över dina data.

![Urval av försäljning - gruppering och summan av belopp -screenshot][img3]

### Projekt

* Ett urval med alla aktiva projekt av typen *Internt* hjälper dig att bedöma vilka projekt som kan avslutas och vilka som behöver fortsatt arbete.

* Alla aktiva projekt som du medverkar i.

### Dokument

* Ett urval med alla dokument som du har skapat den senaste månaden ger dig en överblick över vilka dokument som har producerats och hjälper dig att identifiera eventuella bortglömda dokument.

* Alla kontrakt som har registrerats i SuperOffice CRM.

### Händelser

* Ett urval med alla händelser för en viss kund ger dig insikt i kundrelationen innan ett säljmöte.

* Ett urval med alla händelser du har denna månad hjälper dig att se dina planerade möten och avgöra om fler behöver bokas in.

### Produkter (kräver en Sales Premium-licens)

* En lista över alla kunder som har köpt en viss produkt eller produktkategori.

* Ett urval av alla produkter som har sålts under året, baserat på försäljningar med offerter som har statusen **Såld**. Urvalet kan begränsas till specifika produktkategorier, produktfamiljer osv., beroende på den statistiska rapportering du behöver.

* Om du planerar att uppgradera en produkt från t.ex. version 2 till version 3 kan du skapa ett urval av alla kunder som har köpt version 2 och använda detta som grund för en kampanj.

### Ärenden

* En lista över öppna ärenden med prioritet **Hög** för din avdelning (kategori).

* Ett urval av alla öppna ärenden som inte har uppdaterats på över en vecka hjälper dig att följa upp med de ansvariga ärendehandläggarna.

### Urval

* Alla aktiva urval som du äger.
* Alla urval med en viss kategori eller av en viss typ.

### Marknadsföring och kundengagemang

* Icke bearbetade formulärinlämningar för dina kunder.
* Dina chattkonversationer.
* Dina kunders chattkonversationer med specifika betyg.
* Utskick med en viss öppningsfrekvens eller klickfrekvens.
* Utskick med hög avvisningsfrekvens.

## Relaterat innhåll

* [Lägg till en post som favorit][11]
* [Skapa urval][2]
* [Redigera och ta bort urval][5]
* [Utföra uppgifter för urval][1]
* [Visa urval som diagram][3]

<!-- Referenced links -->
[1]: howto/index.md
[3]: howto/display-as-charts.md
[6]: howto/export.md
[8]: howto/create-mailings.md
[2]: create.md
[4]: combine.md
[5]: update.md
[7]: add-remove-members-static.md
[9]: ../../learn/search-criteria.md
[11]: ../../../learn/basics/fav.md
[10]: ../../../learn/section-tabs/configure-columns.md#calculate
[12]: ../../../learn/section-tabs/filter.md
[16]: ../../../dashboard/learn/create.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/sale/selection-sales-column-calculation-grouping.png

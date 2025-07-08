---
uid: help-sv-search-criteria
title: Använda sökkriterier
description: Använda sökkriterier
keywords: söka, kriterier, sök
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Använda sökkriterier

Du använder sökkriterier för att berätta vad du söker efter, till exempel "företag med adress i Danmark". Sökkriterier används på flera ställen i SuperOffice CRM, bland annat i fönstret **Sök** och när du ska skapa urval. Oavsett vad du ska använda kriterierna till så arbetar du med dem på samma sätt.

Överallt där du kan lägga till sökkriterier hittar du en kriterielista med de valda sökkriterierna.

Vanliga sökningar finns där för att hjälpa dig att komma igång och skapa din egen sökning efter CRM-data. När du har valt en vanlig sökning, kan du lägga till och redigera sökkriterier. Och när du har skapat en användbar sökning som du vill använda igen, kan du spara den som ett urval.

Titta på den här videon för att lära dig hur du gör en vanlig sökning och ändrar den genom att lägga till nya sökkriterier eller följ steg-för-steg-guiden nedan:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/gx-vXm-b_7g]

(videolängd - 3:01)

## Lägga till sökkriterier

1. Öppna kriterielistan.
    * Klicka på **Sök** i det övre fältet. Kriterielistan i fliken **Kriterier**.
    * Eller gå till önskat urval och välj fliken **Kriterier**.

1. Klicka på knappen **Lägg till**.
    En ny rad läggs till i kriterielistan och en lista visas med fält att välja mellan.

1. Välj i vilket fält du vill söka efter information. Du kan även [skriva in början på namnet på önskat fält][2]. Det finns flera typer av fält:

    * [Textsträng](#text)
    * [Ja/Nej](#yes-no)
    * [Datum](#date)
    * [Nummer](#number)
    * [Lista](#list)
    * [Status](#status)
    * [Räknare](#counter)

1. Välj värden för sökkriterierna i de olika fälten på raden.

1. Klicka på **Lägg till** om du vill lägga till en ny rad eller klicka på **Eller** om du vill lägga till en ny uppsättning kriterier.

## Fälttyper

### <a id="text"></a>Textfält

Om fältet som du ska söka i är ett textfält (till exempel namn) söker programmet efter text eller tal som du själv anger. Då visas en lista med följande alternativ:

* Börjar med
* Innehåller
* Slutar med
* Är lika med
* Är exakt
* Börjar inte med
* Innehåller inte
* Slutar inte med
* Är inte lika med

Välj ett av dessa alternativ och skriv sedan in sökkriterierna i textfältet till höger.

### <a id="yes-no"></a>Ja/Nej-fält

Om fältet som du ska söka i är ett Ja/Nej-fält, till exempel fältet **Inga utskick** i fönstret Företag, så visas två alternativknappar. Du kan välja mellan **Ja** och **Nej**.

### <a id="date"></a>Datumfält

Om fältet som du ska söka i är ett datumfält, till exempel fältet **Datum** i dialogrutan **Dokument**, visas en listruta med följande alternativ:

* Före
* Är lika med
* Efter
* Mellan
* Före i dag
* I dag
* Efter i dag
* Denna...
* Denna och nästa...
* Nästa...
* Denna och föregående...
* Föregående...
* Denna, föregående och nästa...

Välj önskat alternativ. Beroende på vad du väljer fylls fältet automatiskt i med ett datum eller datumintervall, eller så kan du ange önskat datum. Du kan också välja ett datum i kalendern som visas när du klickar på <i class="ph ph-caret-down" aria-label="Chevron"></i>.

### <a id="number"></a>Sifferfält

Om fältet som du ska söka i innehåller siffror, till exempel fältet **Belopp** i fönstret Försäljning, visas en listruta med följande alternativ:

| Alternativ | Beskrivning |
|---|---|
| = | Är lika med |
| &gt; | Större än |
| &lt; | Mindre än |
| &gt;= | Större än eller lika med |
| &lt;= | Mindre än eller lika med |
| &lt; &gt; | Är inte lika med |
| Mellan | Värdet ligger mellan två angivna siffror |

Välj önskat alternativ och skriv in önskat siffervärde i textfältet till höger.

### <a id="list"></a>Listfält

Om fältet som du ska söka i är ett fält som innehåller listor, till exempel fältet **Bransch** i fönstret Företag, visas en listruta med alternativen **Är en av** och **Är inte en av**.

Klicka i fältet **Välj objekt** för att visa listan med värden.

Om listan är lång, kan du skriva text i fälten **Sökkriterier** för att söka efter värden.

Klicka utanför listan för att stänga den.

### <a id="status"></a>Statusfält

Om fältet som du ska söka i är ett statusfält, välj en status.

Statusarna skapas och administreras i Inställningar och underhåll. Statusfält är bara aktuella om du har köpt licens för och aktiverat statusövervakning.

### <a id="counter"></a>Räknarfält

[Räknare][3] kan till exempel visa antal försäljningar i en period eller datum för den senast slutförda försäljningen.

Räknarfält finns under **Räknare (SAINT)** i listan över kriterier.

1. Till höger om fälten kan du klicka på länkarna för att ange ytterligare kriterier för räknarna. Vilka alternativ som är tillgängliga beror på vilken typ av post och räknare som du arbetar med.

    * **Saint-typ**: Här kan du välja vilken aktivitetstyp du ska söka efter.
    * **Status**: Här kan du välja vilken status du ska söka efter för posten.
    * **Riktning**: Här kan du välja om aktiviteten ska vara inkommande eller utgående.
    * **Beloppsklass**: Här väljer du beloppsklass på försäljningen.
    * **Syfte**: Här kan du ange syftet med aktiviteten.

1. Beroende på vad du har valt ovan så visas en listruta för datumfält eller sifferfält. Dessa listrutor fungerar som beskrivs ovan. Välj önskat alternativ och skriv ett siffervärde eller datum i textfältet.

Räknarna skapas och administreras i Inställningar och underhåll. Räknarfält är bara aktuella om du har köpt licens för och aktiverat statusövervakning.

## Arbeta med sökkriterier

Kriterielistorna innehåller ett antal standardkriterier som du kan redigera eller ta bort efter behov.

När du öppnar fönstret **Sök** innehåller den standardsökkriterier eller de sökkriterier som du angav förra gången du använde dialogrutan. För att använda andra sökkriterier än de som visas har du följande möjligheter:

| Uppgift | Steg |
|---|---|
| Flytta kriterier (en rad) | Klicka och dra <i class="ph ph-equals" aria-label="="></i>. |
| Ändra sökkriterier | Klicka på det och väljer ett annat i listan som visas. |
| Inaktivera ett eller flera sökkriterier | Lämna värdefältet tomt. |
| Inaktivera alla sökkriterierna | Klicka **Ta bort alla**. |
| Ta bort sökkriterier | Klicka på <i class="ph ph-x-circle" aria-label="X"></i>. |
| Återställa kriterielistan till standardkriterierna | Klicka **Återställ till standard**. |

> [!NOTE]
> Att flytta sökkriterier upp eller ner har ingen praktisk innebörd för sökningen, men gör att du kan ordna kriterierna i den ordning du föredrar. Om några av villkoren inte används men du fortfarande vill behålla dem, kan du flytta inaktiva kriterier längst ned på listan.
>
> Ett inaktiverat sökkriterium finns kvar i kriterielistan och kan enkelt aktiveras igen.

## Relaterat innehåll

* [Använda fönstret Sök][1]
* [Urval][4]

<!-- Referenced links -->
[1]: find-screen.md
[2]: in-navigator.md
[3]: ../../saint/learn/index.md
[4]: ../selection/learn/index.md

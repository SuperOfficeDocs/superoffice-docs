---
uid: help-sv-saint
title: Sales Intelligence (SAINT)
description: I den här guiden lär du dig hur SAINT kan utveckla dina försäljnings- och kundprocesser, samt förbättra arbetsflöden.
keywords: SAINT
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/sale/saint/learn/index
  - /sv/sale/saint/learn/status-dialog
  - /sv/saint/learn/status-dialog
---

# Sales Intelligence (SAINT)

Att vara proaktiv innebär att man kontrollerar en förväntad situation innan den uppstår. Med SuperOffice Sales Intelligence (SAINT) får du möjlighet att följa upp dina kunder vid rätt tidpunkt och ta kontroll över alla möjliga scenarier. SAINT är utformat för att övervaka din databas och hjälpa dig att vara proaktiv och förutse händelser som kan påverka ditt företag.

[!include[Requirement](../includes/note-saint-req.md)]

## Vad SAINT är och vad det kan göra

Övervakning och analys av informationen i ditt CRM-system ger insikter i vad du kan göra för att förbättra din verksamhet. Med SuperOffice SAINT kan du få insikter genom att söka efter information som finns och inte finns i SuperOffice CRM. Till exempel:

* Vilka kunder har vi inte följt upp under de senaste sex månaderna?
* Vilka kunder köpte inte något från oss under de senaste tre månaderna?
* Finns det kunder med för många ärenden under de senaste sex veckorna?
* Har ni framtida aktiviteter registrerade för alla pågående projekt?

Dessa frågor är utgångspunkten för beslutet att vidta åtgärder. Genom att vidta åtgärder kan du förbättra eller korrigera den befintliga situationen.

## Status

Om du har köpt licens till SAINT ("SAles INTelligence") kan du ange kriterier för statusövervakning av företag, kontakter och projekt i Inställningar och underhåll. Status som genereras efter sådana kriterier kan visualiseras som en bild på företags-. kontakt- eller projektkortet. Du kan till exempel visa en bild med en varningstriangel för en kund som har krävt många säljmöten men inte genererat någon försäljning, eller ett spindelnät för en kund som inte har kontaktats på över tre månader. På så sätt får du en tydlig och omedelbar indikation av vissa statuslägen, vilket till exempel en säljare kan ha stor nytta av.

## Ett enkelt exempel

Vårt påhittade företag Bridgecom säljer datorer, laptops och kontorsprogram. Som du vet måste varje dator uppdateras med ny programvara och ibland måste den bytas ut helt och hållet. Men teamet på Bridgecom kämpar för att få en översikt över de företag som behöver nya datorer och programuppdateringar. De skulle verkligen vilja ha en lista över företag som inte har uppdaterat sina datorer under de senaste två åren. På så sätt skulle de veta exakt vilka kunder de ska följa upp i början av varje månad. Men hur hittar man sådan information?

Genom att använda SAINT kan Bridgecom proaktivt söka efter alla kunder utan öppen eller slutförd försäljning som registrerades under de senaste två åren på deras kundkort. SAINT-urvalet genererar en lista över dessa kunder. Baserat på den information som inte finns i kunddatabasen – nämligen att det inte finns någon försäljning registrerad under de senaste två åren.

Med denna översikt kan Bridgecom avgöra hur de vill följa upp sina kunder för att förbättra relationerna och öka försäljningen.

Med SuperOffice SAINT kan du analysera din databas för att få en översikt över kunder, försäljning, ärenden och dokument. Detta kan göras i form av diagram och rapporter. Sedan kan de personer som är ansvariga för situationen som du analyserade med SAINT vidta åtgärder för att förbättra den.

### Företag/kontakter

| Statusnamn | Kriterier | Förklaring | Uppgift |
|---|---|---|---|
| Dyr kund | **Antal aktiviteter i period** med typen **Marknadsföring** är högt. **Antal försäljningar i period** med statusen **Såld** är lågt. | Du har mycket marknadsföringskommunikation med kunden, men det har lett till låg eller ingen försäljning. | Planera ett internmöte för att ta reda på vad som kan göras för att få kunden lönsam. |
| Försummad kund | **Antal aktiviteter** med riktning **Utgående** i perioden är lågt. | Du har haft ytterst lite kontakt med kunden. | Planera ett samtal med kunden för att underhålla kundrelationen. |
| Vilande kund | **Antal aktiviteter i period** med riktningen **Inkommande** är lågt eller noll. **Antal aktiviteter i period** med riktningen **Utgående** är högt. | Du försöker ta kontakt med kunden, men får liten eller ingen respons. | Boka ett möte med kunden för att ta reda på varför kunden inte vill kommunicera. |

### Projekt

| Statusnamn | Kriterier | Förklaring | Uppgift |
|---|---|---|---|
| Försummat projekt | **Projektstatus** anges som pågående. **Datum för senaste aktivitet** (händelse) är äldre än 14 dagar. | Projektet är aktivt, men det har inte varit någon aktivitet de senaste 2 veckorna. | Planera ett projektmöte för att få hjulen i rullning. |
| Olönsamt projekt | **Antal försäljningar** (slutförda) är lika med noll. **Projektstatus** anges som slutfört eller stoppat. | Projektet är klart, men inget såldes. | Planera ett internmöte för att ta reda på varför det inte blev någon försäljning. |

## Analys

SAINT tillhandahåller både realtids- och ad hoc-analyser av kontinuerligt uppdaterade CRM-data. Båda metoderna används för att säkerställa relevant och korrekt feedback. Analysen är utgångspunkten för det hela.

Med SuperOffice SAINT kan du inte bara söka efter element som finns i din databas, utan även söka efter element som saknas.

### Exempel: söka efter saknade element

Du kan söka efter kontakter som inte har haft några aktiviteter av en viss typ (eller inte har uttryckt någon försäljningsrelaterad avsikt) inom en viss tidsperiod. SAINT kommer att ge dig alla kunder utan en händelseaktivitet (öppen eller slutförd) under de senaste sex månaderna.

![Kriterieskärm i SAINT för att hitta kunder utan händelser -screenshot][img2]

Att ta reda på vad som inte har hänt, men som borde ha hänt, är ett exempel på hur SuperOffice SAINT kan hjälpa dig att prestera enligt dina definierade regler eller syften.

Om din interna kvalitetsrutin till exempel anger att en viss åtgärd ska vidtas i ett visst skede i ett projekt, kan du använda SAINT för att ta reda på om denna regel följdes eller inte. Eller, om ditt kundprogram anger att kunder i en viss kategori ska kontaktas enligt ett visst schema, kan SAINT hjälpa dig att identifiera och lista de kunder som inte har följts upp som planerat.

Dessa är exempel på vilken typ av insikter dina CRM-data och SAINT kan ge dig.

## Medvetenhet

När analysen är klar, måste du få dina kollegor att agera på resultaten.

SuperOffice SAINT använder visuella statusindikatorer på en kund, potentiell kund, en försäljning eller ett projekt, som visas som en bakgrundsbild på kortet. Det är omöjligt för en anställd att ignorera denna indikator. Användaren kommer omedelbart att se att det finns en möjlighet, ett problem eller något som kräver åtgärder.

SAINT kan vara kul! Du kan använda vilken bakgrundsbild som helst, till exempel:

* Ett spindelnät som symboliserar de kunder som inte har följts upp,
* Ett dollartecken för kunder med försenad försäljning,
* En livboj för kunder med för många serviceärenden.

Ur praktisk synvinkel kan SAINT ge en anställd förslag på åtgärder för en specifik situation. De kan skapa en händelseaktivitet eller lägga till kunden i ett urval.

![Använd en visuell indikator som ett spindelnät för att varna om att en kund behöver följas upp -screenshot][img3]

De SAINT-kriterier som genererar de analyser du använder blir automatiskt sökbara "fält". Alla användare kan använda dessa fält för att skapa en anpassad lista över åtgärder eller sökningar i SuperOffice Selection.

## Åtgärd

När bakgrundsbilden (visuell statusindikator) på ett kontakt-/företagskort eller urval har gjort användaren medveten om att åtgärd krävs, kan de komma åt SAINT-urvalet. Detta urval innehåller alla kunder som behöver följas upp.

Med hjälp av ditt SAINT-urval kan du vidta åtgärder i form av proaktiva, personliga uppföljningar, personliga e-postkampanjer eller schemalagda samtal i de kontoansvarigas kalendrar.

Så snart uppföljningsåtgärden sparas i SuperOffice CRM, kan urvalet uppdateras för att ge en korrekt översikt över nuläget. De kunder du följer upp kommer automatiskt att tas bort från ditt urval.

## Arbeta med SAINT i användargränssnittet

När du ser en statusbild för ett företag eller projekt har du två möjligheter:

* Om du håller muspekaren över bilden visas en inforuta med namn på statusen och en beskrivning. Du får också information om annan eventuell status för företaget eller projektet.

* Om du klickar på fönstret öppnas dialogrutan **Visa status**, där du kan se statusnamn och en beskrivning och vidta åtgärder för företaget, kontakten eller projektet.

> [!TIP]
> Du kan kombinera en eller flera statuslägen som kriterier när du skapar dynamiska urval och på så sätt få en praktisk översikt över alla företag, kontakter eller projekt som uppfyller kriterierna.
>
> Om du behöver hjälp med att konfigurera SAINT för att utveckla dina försäljnings- och kundprocesser, rekommenderar vi alltid att du tar kontakt med en av våra skickliga konsulter.

### <a id="dialog"></a>Dialogrutan Visa status

Dialogrutan **Visa status** öppnas när du klickar på en statusbild på ett projektkort för företag eller kontakt. I dialogrutan finns följande information:

| Objekt | Beskrivning |
|---|---|
| Namn | Namnet på statusen anges i Inställningar och underhåll. |
| Beskrivning | En beskrivning av statusen anges i Inställningar och underhåll. |
| Andra statuslägen | Här finns länkar till andra eventuella statuslägen som gäller för företag, kontakt eller projektet. Detta fält visas endast om det finns flera statuslägen för den aktuella poster. |
| Skapa uppföljning | Används för att [skapa en ny händelse][1] för företaget eller projektet. Vilken typ av händelse som skapas som standard definieras i Inställningar och underhåll. |
| Lägg till i urval | När man klickar här, öppnas dialogrutan **Lägg till i urval**, och du kan lägga till det aktuella företaget eller den aktuella kontakten i ett statiskt urval som du väljer själv. Detta alternativ kan endast används för statiska urval. [Så här använder du statusar i dynamiska urval][2].|

## Relaterat innehåll

* [Konfigurera SAINT][5]
* [Hur SAINT lagrar räknare och statusar][4]
* [Använda statusövervakning i dynamiska urval][2]

<!-- Referenced links -->
[1]: ../../diary/learn/create-follow-up.md
[2]: ../../search-options/selection/learn/create.md
[5]: ../admin/index.md
[4]: ../admin/index.md#database

<!-- Referenced images -->
[img2]: ../../../media/loc/en/saint/find-company-saint-criteria.png
[img3]: ../../../media/loc/en/saint/visualize-neglected-company.png

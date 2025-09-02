---
uid: help-sv-privacy-implementation
title: Hantera dina integritetsinställningar (GDPR)
description: Innan du börjar konfigurera din SuperOffice CRM-databas för att bli GDPR-kompatibel, bör du först lägga en grund för detta.
keywords: GDPR, samtycke, integritetsinställning
author: Bergfrid Dias
date: 02.21.2023
version: 10.3
content_type: concept
category: privacy
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
redirect_from: /sv/security/privacy/learn/implementation-guide
---

# Hantera dina integritetsinställningar (GDPR)

Som företag måste ni samla in, lagra och hantera människors personuppgifter. Enligt GDPR måste ni nu ha en laglig anledning till varför ni vill lagra denna information.

Den allmänna dataskyddsförordningen (GDPR) ger EU-medborgarna större kontroll över sina personuppgifter och säkerställer att deras information skyddas säkert inom hela Europa, oavsett om databehandlingen sker inom EU eller inte.

Alla företag samlar in personuppgifter om sina potentiella kunder, befintliga kunder, leverantörer och affärskontakter. Detta är typisk information som lagras i din CRM-databas, och du måste kunna dokumentera och hantera den enligt hur du bedriver din verksamhet och GDPR-kraven.

För att göra detta läggare, har SuperOffice CRM en uppsättning integritetsfunktioner som kallas samtyckeshantering, utformade för att hjälpa dig att dokumentera när, hur och varför nya personuppgifter förs in i din CRM-lösning.

> [!TIP]
> Om du behöver hjälp med att konfigurera GDPR-inställningarna i enlighet med hur du bedriver din verksamhet, rekommenderar vi alltid att du kontaktar en av [våra kompetenta konsulter][1] för att säkerställa att kraven följs.

## SuperOffice CRM täcker dina dokumentationsbehov

Det finns flera sätt att lagra information om personer och deras personuppgifter i SuperOffice CRM. Det kan komma från manuell registrering, via e-post, via chatt, serviceärenden, webbformulär eller integrationer med andra back-end-system.

Oavsett hur en person "kommer in i" databasen, erbjuder SuperOffice CRM den dokumentation ett företag behöver för VARFÖR, HUR och NÄR nya personuppgifter kommer in i systemet.

Det innebär att du är ansvarig för att definiera policyer som är GDPR-kompatibla.

Sedan kan du konfigurera SuperOffice CRM så att det automatiskt registrerar:

* Rätt **syfte** (VARFÖR du lagrar informationen om en viss person)

* Den **rättsliga grunden** (GDPR artikel 6.1 – Behandlingens laglighet)

* **Källan/ursprunget** (HUR personen kom in i SuperOffice CRM, till exempel: manuellt registrerad, via webbformulär, e-post)

* **Datum och tid** (NÄR informationen om en person matades in)

* **Vem gjorde det**

För att hjälpa dig att uppfylla GDPR-kraven innehåller SuperOffice CRM en hel uppsättning funktioner.

Från första början finns det några standardinställningar som du kan ändra för att passa ditt sätt att arbeta, och det finns ytterligare alternativ för att stödja hur ditt företag samlar in och hanterar personuppgifter.

## Fråga efter samtycke

GDPR beskriver vad som anses vara lagliga skäl att hantera personuppgifter och kräver att du får personens samtycke till att lagra deras uppgifter och respektera deras integritet.

I vissa fall måste du be om uttryckligt samtycke för att samla in och lagra personuppgifter. Detta kan vara relevant om ditt företag samlar in känslig personlig information om en person. Det är också vanligt att be om samtycke i förväg när man får tag i personuppgifter via ingående marknadsföringsmetoder.

När uttryckligt samtycke behövs, anger GDPR att du måste dokumentera själva samtycket, samt var det samlades in, när det samlades in och av vem.

Detta uppnår du genom att använda fälten för samtyckeshantering i SuperOffice CRM:

* **Rättslig grund:** här kan du dokumentera anledningen till varför du vill lagra och använda en individs uppgifter.

* **Syfte:** här kan du dokumentera vad du ska använda uppgifterna till.

* **Källa:** här registrerar du hur en kontakts personliga information samlades in. Det kan vara allt från att man får ett visitkort till att man får ett e-postmeddelande eller att någon fyller i ett webbformulär på din webbplats.

Vilka typer av syften, rättsliga grunder och källor du behöver använda beror på hur ditt företag samlar in personuppgifter och av vilka skäl och för vilka syften. När du har identifierat detta, kan du definiera dessa fält i ditt SuperOffice CRM.

## Definiera integritets- och samtyckeskrav

Om du vill definiera dessa fält, går du till Inställningar och underhåll och väljer **Integritet**. Här kan du definiera de olika samtycken som ditt företag behöver för att dokumentera och lagra uppgifter.

Det finns redan två standardsyften som du kan använda i systemet:

![I Inställningar och underhåll kan du definiera integritets- och samtyckeskrav -screenshot][img1]

Det första, **Försäljning och tjänster**, föreslår att anledningen till att du lagrar personuppgifter i din CRM-lösning är att du vill sälja och/eller betjäna kontakten med dina produkter och tjänster.

Den andra, **E-marknadsföring**, anger att ditt syfte med att lagra informationen är att skicka marknadsföringsmaterial till en kontakt. I många europeiska länder kräver detta syfte uttryckligt samtycke, särskilt när man skickar marknadsföringsmaterial till potentiella kunder.

Dessa syften kan vara rätt samtycke för ditt företag att använda. Baserat på ditt eget företags integritetspolicy måste du:

* Definiera vilka integritetsfält som är rätt för ditt företag.
* Konfigurera integritetsinställningarna enligt den samtyckesdokumentation du behöver.
* Uppdatera, lägga till eller ta bort alla anledningar ditt företag behöver för att lagra samtycken.

## Kom igång med GDPR i SuperOffice CRM

För att konfigurera ditt SuperOffice CRM för GDPR måste du genomföra tre grundläggande steg:

1. Förberedelse
1. Konfiguration
1. Tilldelning av åtkomstbehörigheter

Du kan konfigurera SuperOffice CRM själv om du har grundläggande behov eller om du har tidigare erfarenhet av att installera CRM-system. Alternativt kan du be en av våra konsulter att hjälpa dig att göra det.

### Förbered ditt företag för GDPR

Hur GDPR-lagen tillämpas på ditt företag är din lednings ansvar. Du måste ha en integritetsstrategi på plats och veta vilka uppgifter du vill lagra i vilket system, samt hur du tänker hantera dessa uppgifter. Allt detta avgör hur du ska konfigurera SuperOffice CRM för att stödja din operativa strategi och dina processer.

För att hjälpa dig att bli redo har vi tagit fram en femstegsplan som hjälper dig:

1. Kartlägg de personuppgifter som ditt företag lagrar.
1. Bestäm vilka uppgifter ni behöver behålla.
1. Läs om hur du uppfyller kraven i GDPR.
1. Vidta säkerhetsåtgärder.
1. Upprätta rutiner för att hantera personuppgifter.

När du förbereder ditt företag för GDPR, ha två huvudmål i åtanke:

* Gör era befintliga uppgifter redo för GDPR.
* Justera era integritetspolicyer för att säkerställa GDPR-efterlevnad.

#### Kartlägg de personuppgifter som ditt företag lagrar

Det är viktigt att kontrollera vilka personuppgifter ditt företag har behörighet att lagra.

Vilken typ av personuppgifter ni kan lagra beror på vilken typ av verksamhet ni bedriver. Du bör också tänka på hur ni ska använda den information ni lagrar.

Därför rekommenderar vi alla våra kunder att konsultera en jurist som är specialiserad på GDPR. De kommer att kunna ge dig juridisk rådgivning kring vilken information ditt företag får lagra och när ni behöver få uttryckligt samtycke till lagring av personuppgifter.

Baserat på de juridiska rekommendationer du får, kan du kartlägga var personuppgifterna i ditt företag kommer ifrån och dokumentera hur ni vill använda dessa uppgifter.

Vilken är den rättsliga grunden för lagring av personuppgifter?
Anledningen till att du laggar vissa personuppgifter kallas rättslig grund.

Det finns ett antal rättsliga standardgrunder för lagring av information som är tillgängliga i SuperOffice CRM (från och med version 8.2). Detta är en standardlista, och den kommer att vara gällande för 95 procent av företagen.

Du kan när som helst redigera den här listan över rättsliga grunder i Inställningar och underhåll genom att lägga till de kategorier inom rättslig grund som krävs specifikt för ditt företag eller ändra namnen så att de passar din egen terminologi.

Om du har många befintliga uppgifter som du vill uppdatera med en ny eller ändrad rättslig grund, kan du göra det med hjälp av massuppdateringsfunktionen.

#### Bestäm vilka uppgifter ni behöver behålla

För att avgöra vilken personlig information du vill behålla, titta på den information som lagras för närvarande.

Du kan ta reda på vilken information ditt företag lagrar genom att kontrollera kontaktkorten för dina kontakter: potentiella kunder, befintliga kunder och förlorade kunder. Du kan titta på:

* Fliken kontakt, som innehåller information som en persons telefonnummer, e-postadress och mobilnummer, samt information om kundens kategori och vilken typ av verksamhet de befinner sig inom;

* Fliken Mer, som kan innehålla användardefinierade fält som du har lagt till i din SuperOffice CRM-lösning;

* Fliken Intresse, som kan innehålla olika typer av kommunikation, arbetsrelaterade händelser som ditt företag kan organisera eller andra personliga intressen som till exempel en persons hobby.
När du vet vilken information du redan har i databasen, kan du bestämma vilka kundkategorier du behöver och vilka du inte behöver.

Kanske måste nya kategorier läggas till, medan andra bör tas bort?

En annan sak du bör tänka på är hur länge du behöver lagra uppgifter om dina potentiella kunder, befintliga kunder och förlorade kunder.

Efter en viss period, måste du radera information som inte längre används.

För att få hjälp kan du ladda ner en mall som hjälper dig att kartlägga alla kategorier du vill använda, den rättsliga grunden för lagring och hur länge du tänker lagra informationen.

Oberoende av GDPR-förordningen är det i allmänhet värt att bedöma vilka uppgifter du har lagrat och hur länge du lagrar dessa i din CRM-databas. Vi rekommenderar att du inte lagrar onödig information och tar bort uppgifter som inte används. Det är bäst att lagra uppgifter under kortast möjliga tid.

Om ditt företag samlar in stora mängder uppgifter utan någon verklig fördel, kommer det först och främst inte att ge dig något annat än en rörig databas, och för det andra får du helt enkelt inte lagra irrelevant eller överflödig information enligt [EU-förordningen om GDPR (art. 5)][2].

Under denna rensningsprocess, bör du ställa dig själv dessa frågor:

* Varför lagrar vi just dessa uppgifter istället för att bara radera dem?
* Vad försöker vi uppnå genom att samla in alla dessa kategorier av personuppgifter?
* Vem har tillgång till personuppgifter i vår SuperOffice CRM-lösning och bör de ha tillgång till denna information?

#### Läs om hur du uppfyller kraven i GDPR

Nu när du vet vilken information du vill behålla och hur du vill uppdatera din befintliga kundinformation, låt oss se hur du kan se till att du uppfyller kraven i GDPR även i framtiden.

För att göra detta, börja med att fråga dig själv detta: "Hur brukar kontakter "komma in i" min SuperOffice-databas?"

Det finns tre sätt att lägga till kontakter i din databas:

* Kontaktuppgifter kan samlas in digitalt. Du kan få kontaktuppgifter genom användning av webbformulär, ärenden, inkommande e-postmeddelanden eller chattar.

* Kontaktuppgifter kan samlas in manuellt. Du kan få kontaktuppgifter via möten, telefonsamtal, mässor, evenemang och sociala medier.

* Kontaktuppgifter kan samlas in från andra system. Du kan lägga till kontaktuppgifter genom en dataimport eller integrationer med andra system, till exempel din ERP-lösning.
När kontaktuppgifter läggs till digitalt kan du be om en persons samtycke på din webbplats eller till exempel via ett webbformulär medan personer fyller i sina uppgifter.

När du registrerar deras uppgifter manuellt eller via andra system, måste du dock be om personens samtycke till att lagra och använda deras personuppgifter separat, efter att du har lagt till deras uppgifter i din CRM-lösning.

För att hjälpa dig att be om detta samtycke innehåller SuperOffice CRM ett e-postmeddelande med en integritetsbekräftelse. Det här e-postmeddelandet skickas till kontakter för att informera dem om att du tänker lagra deras information i din CRM-databas.

För att be om samtycke på rätt sätt från de kontakter du planerar att lagra i din CRM-databas måste du först och främst veta hur du har samlat in deras uppgifter.

Du kan göra en lista över alla källor från vilka du samlar in personlig information. Skriv ner en lista över de webbformulär du använder, till exempel de webbsidor där du använder SuperOffice Chat.

När du ber om samtycke för att lagra en persons uppgifter bör du också låta dem när som helst kontrollera sitt samtycke.

Frågor för att kontrollera om dina kontakter kan hantera sitt samtycke:

* Erbjuder vi en länk till vår integritetspolicy?
* Kan människor enkelt acceptera och godkänna vår integritetspolicy?
* Kan människor acceptera de prenumerationer vi erbjuder?
* Är det möjligt för dem att också välja bort dem?

#### Vidta säkerhetsåtgärder

I linje med GDPR måste ditt företag utveckla och genomföra säkerhetskontroller i hela din CRM-lösning för att förhindra eventuella dataintrång.

Detta innebär införandet av säkerhetsåtgärder för att skydda mot dataintrång eller läckor och vidta snabba åtgärder för att meddela individer och myndigheter om en sådan händelse inträffar.

Naturligtvis kan SuperOffice hjälpa dig med detta genom att se till att uppgifter från alla SuperOffice CRM Online-kunder lagras tryggt och säkert.

Det är dock fortfarande ditt ansvar att se till att du har rätt säkerhetsåtgärder på plats om, och när, ett dataintrång inträffar.

##### Hur kan SuperOffice CRM hjälpa dig att hantera incidenter?

Det är en bra idé att skapa ett arbetsflöde som innehåller en detaljerad beskrivning av alla steg du bör vidta när ett dataintrång upptäcks eller rapporteras.

När du har upptäckt ett dataintrång måste du [informera alla kontakter som påverkas av det inom 72 timmar][4].

SuperOffice Service kan hjälpa dig att samla in eventuella rapporter om ett möjligt dataintrång. Du kan konfigurera Service för att följa det arbetsflöde du utformade för att informera och begränsa det potentiella dataintrånget.

Utskicksfunktionen i SuperOffice kan å andra sidan hjälpa dig att informera alla kontakter som berörts.

Du kan överväga att skapa en e-postmall för dataintrång. Den här mallen kan användas när ett dataintrång inträffar. Till exempel för att informera dina kontakter om vad som har hänt och hur du planerar att lösa situationen.

#### Upprätta rutiner för att hantera personuppgifter

Enligt GDPR har alla europeiska individer åtta grundläggande integritetsrättigheter.

Du måste upprätta integritetspolicyer och -procedurer för hur du ska säkerställa alla dessa GDPR-rättigheter.

Återigen, här är en uppsättning frågor som kan hjälpa dig att göra dig redo att säkerställa de åtta GDPR-rättigheterna:

* Hur kan individer ge sitt samtycke på ett lagligt sätt?
* Hur ser processen ut om en individ vill att deras uppgifter ska raderas?
* Hur kommer du att se till att information raderas på alla plattformar?
* Om en individ vill att deras uppgifter ska överföras, hur gör du det?
* Hur kommer du att bekräfta att den person som begärde att få sina uppgifter överförda är den person de säger att de är?
* Hur ser kommunikationsplanen ut vid ett dataintrång?

### Konfigurera din databas för GDPR

Baserat på din sekretesspolicy kan du nu:

* Ändra integritetslistor
* Konfigurera integritetsinställningar
* Lägga till och redigera prenumerationstyper

När du vet vilka personuppgifter du tänker lagra i SuperOffice CRM, samt varför och när du kommer att lagra dem, kan du konfigurera SuperOffice för att stödja dina policyer.

För att konfigurera GDPR-funktionen i din SuperOffice CRM-lösning kan du:

* **Ändra integritetslistor:** Som standard finns det två huvudsakliga syften för lagring och behandling av personuppgifter definierade i SuperOffice CRM, och du kan ändra dessa inställningar så att de passar ditt företag.

* **Konfigurera integritetsinställningar:** Detta inkluderar reglerna för om och när man automatiskt ska informera en person via e-post om att deras information lagrades i dina system. Eller ställa in systemet på ett sätt som gör att e-marknadsföringskommunikation inte skulle skickas till några CRM-kontakter som inte har nödvändiga samtycken registrerade (dvs. utesluta från e-postlistan).

* **Lägga till och redigera prenumerationstyper:** Den här funktionen hjälper dig att ge en person en chans att inte bara ge sitt samtycke till att ta emot e-marknadsföringsutskick från ditt företag, utan också att definiera sina egna utskickspreferenser.
Var och en av dessa instruktionssidor innehåller både en instruktionsvideo och en steg-för-steg-guide som du kan använda för att konfigurera din SuperOffice CRM-lösning så att den passar med dina integritetspolicyer.

### Tilldela åtkomsträttigheter

Eftersom huvudmålet med GDPR är att skydda människors integritet och att hålla deras personuppgifter säkra, bör inte alla GDPR-relaterade funktioner i SuperOffice CRM vara tillgängliga för alla inom ditt företag.

Du måste tilldela åtkomsträttigheter för att utföra följande funktioner:

* **Hantera e-marknadsföring/prenumerationer:** Som standard kan endast kontakten uppdatera sina prenumerationsinställningar. Du kan dock ge vissa användare åtkomsträttigheter som gör att de kan uppdatera e-marknadsföringsprenumerationerna för en kontakt manuellt.

* **Massuppdatera kontaktinformation:** Med den här funktionen kan du lägga till, ändra eller ta bort personlig information för grupper med kontakter, aktiviteter, försäljningar och projekt. Allt med bara några klick.

* **Massradera kontaktinformation:** Med den här funktionen kan du ta bort kontakter som inte (eller inte längre) ska lagras i databasen till följd av företagets integritetspolicy.
GDPR-efterlevnad – ett pågående projekt

Genom att slutföra de tre stegen har du tagit viktiga steg mot GDPR-efterlevnad. Att vara GDPR-kompatibel är dock ett pågående projekt och involverar alla it-system som ditt företag använder. Från och med nu bör du fokusera på att upprätthålla korrekt hantering av kunders personuppgifter i din SuperOffice CRM-lösning – i enlighet med ditt företags integritetspolicy och kraven i GDPR.

## Relaterat innehåll

* [Ladda ner vår mall "Förbered dig för GDPR"][3]
* [Redigera e-postbekräftelsen om personskydd][6]

<!-- Referenced links -->
[1]: https://www.superoffice.com/consulting/contact/
[2]: https://eur-lex.europa.eu/legal-content/EN/TXT/HTML/?uri=CELEX:02016R0679-20160504&from=EN
[3]: ../../../../assets/downloads/prepare-for-the-gdpr-download-template-9.xlsx
[4]: https://www.superoffice.com/blog/gdpr/
[6]: edit-privacy-confirmation-email.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/security/privacy.png

---
uid: help-sv-expander-services
title: Expander Services
description: Expander Services
keywords: expander services, license, development tools
author: digitaldiina
date: 10.22.2025
version: 11.5
content_type: concept
category: customization
deployment: online
platform: web
index: true
language: sv
---

# Expander Services

Du kan anpassa SuperOffice efter din affärsmodell och dina behov genom alternativ som finns tillgängliga i modulen **Inställningar och underhåll**.

Men ibland behöver du mer än vad som finns tillgängligt direkt från start. För dessa situationer erbjuder vi Expander Services, som innehåller en rad verktyg och tillägg som du kan använda för att skapa unika anpassningar av din SuperOffice CRM-lösning.

## Vad är Expander Services?

**Expander Services** är vårt namn för ett antal utvecklingsverktyg och utvecklingsprodukter som gör det möjligt att anpassa din CRM-lösning och integrera andra applikationer med SuperOffice.

## Utvecklingsprodukter

Utvecklingsprodukter är **fristående produkter** som hjälper kunder att använda och integrera SuperOffice CRM.

* [Sandbox Production Environment][7] (valfritt antal licenser)

* [Databasspegling][9]

* [Identitetshantering över domäner (SCIM)][8] (en företagsomfattande licens)
  * Använd ditt befintliga verktyg för användaradministration för att hantera användare i SuperOffice CRM.
  * SCIM sparar tid för IT-administratörer, förenklar användarhanteringen och minskar risken för fel.

* Databridge (en företagsomfattande licens)
  * Gör det möjligt att importera och exportera data mellan SuperOffice CRM och andra molnlösningar, antingen en gång eller så ofta som behövs – vilket säkerställer datakvalitet och sparar tid jämfört med manuella processer.
  * Du kan definiera dataflöden mellan dina system ad-hoc eller skapa schemalagda integrationsrutiner som matchar dina affärsprocesser. Verktyget hanterar dubbletter automatiskt och stöder flera format (inklusive Excel och Google Sheets) samt flera molnlagringstjänster, som Dropbox, Google Drive, Microsoft OneDrive, (S)FTP och e-post. Databridge-gränssnittet är utformat så att både CRM-administratörer och IT-personal eller konsulter kan använda det.

## <a id="tools"></a>Utvecklingsverktyg

Utvecklingsverktyg är en **webbplatsomfattande licens** som gör det möjligt för kunder och partners att utöka, optimera, konfigurera och automatisera SuperOffice CRM efter sina behov. Det är en **prenumerationsbaserad licens** som är tillgänglig för alla SuperOffice CRM-kunder – både i molnet och på plats.

### Viktiga funktioner

Med Utvecklingsverktyg kan du:

* Anpassa arbetsflöden och automatisering med:
  * [CRMScript][2]: en flexibel skriptmotor inbyggd i SuperOffice.
  * [SuperMacro][3]: en enkel regelmotor enligt "om detta, så gör det".
* Utöka och anpassa CRM-gränssnittet:
  * [Skärmdesign][5]: designa huvudsidor i CRM (från version 10).
  * [Anpassade skärmar][6]: skapa nya skärmar i Service anpassade efter dina processer (äldre Service).
* Utöka datamodellen:
  * [Extra tabeller][4]: lägg till nya tabeller för ökad flexibilitet i ärende- och relationshantering (anpassade objekt).
* Utveckla och integrera egna applikationer:
  * [SuperOffice API:er][16]: skapa externa appar och integrationer.
  * [Sandbox för utveckling (SOD)][13]: en säker miljö för att testa och utveckla dina integrationer.

Dessa verktyg nås via klienten **Inställningar och underhåll** och kräver låg till måttlig teknisk kompetens. Med hjälp av väldokumenterade API:er kan du dessutom skapa egna integrationer och applikationer som fungerar tillsammans med SuperOffice – och testa dessa i en sandbox-miljö.

Alla anpassningar som skapas med dessa verktyg distribueras och underhålls automatiskt på plattformen – vilket säkerställer att dina ändringar är **robusta**, **hållbara** och **framtidssäkra**.

### Hur fungerar Utvecklingsverktyg?

När du prenumererar på Utvecklingsverktyg blir ytterligare alternativ tillgängliga i modulen **Inställningar och underhåll**.

Licensen läggs till i din [tenant][19] via SuperOffice Operation Center och faktureras månadsvis till kunden.

Du kan fortsätta att använda Utvecklingsverktyg så länge du vill, tills du säger upp prenumerationen. Du kan lägga till hur många anpassningar du vill utan att det påverkar prenumerationsavgiften.

Ingen [anpassad applikation][16] görs tillgänglig i din SuperOffice CRM Online-lösning utan en aktiv prenumeration. Om kunden säger upp prenumerationen blir applikationen inaktiv/otillgänglig.

> [!NOTE]
> API-användning (vilket är avgiftsbelagt) aktiveras genom användning av vissa av dessa verktyg.

### När behöver du köpa Utvecklingsverktyg?

Om du behöver åtkomst till SuperOffice API:er eller någon av de avancerade utbyggnadsfunktionerna, behöver du troligen prenumerera på Utvecklingsverktyg. Priserna finns på [SuperOffice.com][20].

| Scenario/miljö | Online | Lokalt installerad |
|---|---|---|
| Använda verktyg för anpassning i Inställningar och underhåll | nej | nej |
| Publicera standardapplikation | nej (inbäddad) | ja |
| Aktivera anpassad applikation | ja | ja |

Du är fri att anpassa din lösning i **Inställningar och underhåll** med till exempel listdefinitioner, sekretessinställningar, mallar, försäljnings- och projektguider samt användardefinierade fält.

Dessutom behöver du *inte* ha Utvecklingsverktyg om ditt företag kör SuperOffice CRM i molnet och du vill använda någon av de [standardapplikationer][17] som finns tillgängliga i [SuperOffice App Store][21].

Men om du kör SuperOffice CRM lokalt, behöver du *alltid* Utvecklingsverktyg för att lägga till integrationer eller anpassningar, oavsett om de är anpassade för dig eller standardtillägg.

Samma sak gäller för alla [anpassade SuperOffice CRM Online-applikationer][16]. Du kan bygga egna eller [kontakta leverantörer direkt][24] för att ta reda på vilka alternativ som finns för att skapa en skräddarsydd version för ditt företag. Leverantörerna kan säga om en applikation är tillgänglig även om du kör SuperOffice CRM lokalt.

### Hur får jag Utvecklingsverktyg?

Applikationsutvecklare får åtkomst till Utvecklingsverktyg [vid registrering][13]. Kunder kan kontakta sin lokala SuperOffice-partner eller representant för rekommendationer utifrån sina specifika affärsbehov.

Vilka av dessa anpassningsverktyg du använder beror på dina behov, vilken kompetens du har och din vilja att betala för expertis.

### Vad innehåller Utvecklingsverktyg?

#### CRMScript: Anpassa dina arbetsflöden och automatiseringar

[CRMScript][2] är ett mycket flexibelt **skriptspråk** som är inbäddat i SuperOffice CRM. Det gör att du kan skapa olika typer av automatiseringar och arbetsflöden som passar just din verksamhet.

[Utlösare][3] bygger på CRMScript. Det är fördefinierade utlösare och händelser som gör det möjligt att konfigurera *"om detta, så gör det här"*-flöden i SuperOffice CRM.

Vi rekommenderar att du först utforskar möjligheterna med utlösare innan du börjar använda CRMScript för att definiera arbetsflöden. Anledningen är att utlösare inte kräver kunskaper i CRMScript, endast en god förståelse för hur SuperOffice CRM fungerar.

CRMScript kräver däremot teknisk kunskap och passar bäst för användare som är bekanta med programmeringsspråk som C, C++ eller Java.

#### Extratabeller: Lägg till nya tabeller i databasen och öka din flexibilitet

SuperOffice CRM levereras med en uppsättning fördefinierade tabeller där du kan lagra data. Det finns en underliggande logik kring hur dessa tabeller och dataposter relaterar till varandra.

Vissa av dessa standardtabeller är flexibla: du kan definiera vilken typ av data och egenskaper dessa tabeller ska ha. Dessa **användardefinierade fält** gör det möjligt att lägga till datum, nummer, text- eller kryssrutor, som du sedan kan placera på företag, projekt eller uppföljningar.

Om du behöver fler tabeller kan du lägga till extratabeller i databasen genom en prenumeration på Utvecklingsverktyg.

* Användare med en SuperOffice Service [användarplan][1] har full åtkomst till dessa tabeller och kan visa, redigera, söka och inkludera dem i rapporter.
* Användare med Standard-, Sales- eller Marketing-planer får tillgång till extratabeller via webbpaneler (ytterligare flikar). Dessa användare kan endast visa och redigera data – inte söka eller inkludera data i urval eller instrumentpaneler.

För att lägga till extratabeller krävs teknisk kompetens. Extratabeller används ofta tillsammans med anpassade skärmar.

#### Anpassade skärmar: Skapa nya skärmar i Service som stödjer dina processer

Med Utvecklingsverktyg kan du skapa nya skärmar i SuperOffice Service för att anpassa systemet efter dina affärsprocesser.

Till exempel, om du behöver andra fält än standardinformationen när du registrerar ett nytt ärende, kan du anpassa detta i systemet.

I kombination med extratabeller ger egna skärmar ännu större flexibilitet i SuperOffice CRM.

Anpassade skärmar som skapats för SuperOffice Service kan göras tillgängliga för användare med Standard-, Sales- eller Marketing-planer via webbpaneler.

För att skapa anpassade skärmar krävs omfattande teknisk kunskap.

#### SuperOffice API:er: Skapa skräddarsydda lösningar

Du får också tillgång till alla tillgängliga SuperOffice API:er:

* REST- och SOAP-webbtjänster
* WebHooks
* Connectors
* Integration Servers

API:erna levereras som [nuget-paket][22]. SuperOffice Docs innehåller SDK-dokumentation, guider, handledningar och kodexempel. De flesta exempel (inklusive .NET, Python och PHP) finns tillgängliga via [SuperOffice GitHub-organisationen][23].

SuperOffice-partner använder vanligtvis SDK för att utveckla standardapplikationer och integrationer som de erbjuder i SuperOffice App Store.

### Vad kan Utvecklingsverktyg användas till?

* Anpassa användargränssnittet i SuperOffice CRM – vad användaren ser och kan göra.
* Anpassa SuperOffice Service genom att lägga till extratabeller och skärmar, skapa nya skript och makron.
* Automatisera processer, arbetsflöden och åtgärder.
* Bygg [anpassade applikationer][16] med funktionalitet som är specifik för din verksamhet.
* Lägg till integrationer mot andra affärssystem som inte finns som standardapplikationer i SuperOffice App Store.

I takt med att dina behov växer, kan även möjligheterna i din CRM-lösning växa.

<!-- Referenced links -->

[1]: user-plans.md
[2]: ../../../en/automation/crmscript/overview/index.md
[3]: ../../../en/automation/trigger/create-trigger-macro.md
[4]: ../../custom-objects/learn/extra-table.md
[5]: ../../customization/screen-designer/admin/index.md
[6]: ../../../en/ui/blogic/custom-screens/index.md
[7]: ../../../en/online/sandbox/index.md
[8]: ../../../en/online/identity/scim/index.yml
[9]: ../../../en/online/mirroring/index.yml
[13]: ../../../en/developer-portal/getting-started/get-access-to-sod.md
[16]: ../../../en/developer-portal/custom-app/index.md
[17]: ../../../en/developer-portal/standard-app/index.md
[19]: ../../../en/developer-portal/getting-started/index.md#tenant
[20]: https://www.superoffice.com/pricing/
[21]: https://online.superoffice.com/appstore/
[22]: https://www.nuget.org/profiles/SuperOffice
[23]: https://www.github.com/SuperOffice
[24]: https://www.superoffice.com/company/partners/

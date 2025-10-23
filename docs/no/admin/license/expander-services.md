---
uid: help-no-expander-services
title: Expander Services
description: Expander Services
keywords: expander services, lisens, utviklingsverktøy
author: digitaldiina
date: 10.22.2025
version: 11.5
content_type: concept
category: customization
deployment: online
platform: web
index: true
language: no
---

# Expander Services

Du kan tilpasse SuperOffice slik at det passer din forretningsmodell og dine behov, ved å bruke alternativene som finnes i **Innstillinger og vedlikehold**.

Men noen ganger trenger du mer enn det som følger med "ut av boksen". For disse tilfellene tilbyr vi Expander Services – en samling verktøy og tillegg du kan bruke for å lage spesialtilpasninger i din SuperOffice CRM-løsning.

## Hva er Expander Services?

**Expander Services** er vårt navn på en samling utviklingsverktøy og produkter som lar deg tilpasse din CRM-løsning og integrere andre applikasjoner med SuperOffice.

## Utviklingsprodukter

Utviklingsprodukter er **frittstående produkter** som hjelper kunder med å utnytte og integrere SuperOffice CRM.

* [Produksjonsmiljø for Sandkasse][7] (valgfritt antall lisenser)

* [Databasespeiling][9]

* [Kryssdomene-identitetshåndtering (SCIM)][8] (en bedriftslisens)
  * Bruk ditt eksisterende brukeradministrasjonsverktøy til å administrere brukere i SuperOffice CRM.
  * SCIM sparer tid for IT-administratorer, forenkler brukerhåndtering og reduserer risiko for feil.

* Databridge (en bedriftslisens)
  * Importer og eksporter data mellom SuperOffice CRM og dine andre skyløsninger – én gang eller så ofte du vil.
  * Definer hvilke data som skal synkroniseres, enten ad hoc eller via planlagte rutiner. Støtter flere formater (Excel, Google Sheets), skytjenester (Dropbox, Google Drive, OneDrive), samt (S)FTP og e-post. Du trenger ikke være utvikler – vanlige CRM-administratorer kan bruke dette verktøyet.

## <a id="tools"></a>Utviklingsverktøy

**Utviklingsverktøy** er en **site-lisens** som gjør det mulig for kunder og partnere å utvide, optimalisere, konfigurere og automatisere SuperOffice CRM. Dette er et **abonnementsbasert** tillegg som er tilgjengelig uavhengig av om du bruker SuperOffice i skyen eller lokalt.

### Viktige muligheter

Med Utviklingsverktøy kan du:

* Tilpasse arbeidsflyt og automatisering ved hjelp av:
  * [CRMScript][2]: et fleksibelt innebygget skriptspråk i SuperOffice.
  * [SuperMacro][3]: et enkelt "hvis-så"-regelverktøy.
* Utvide og tilpasse CRM-grensesnittet:
  * [Skjermdesigner][5]: design hovedskjermbildene i CRM (fra versjon 10).
  * [Egendefinerte skjermbilder][6]: bygg nye skjermbilder i Service tilpasset dine prosesser.
* Utvide datamodellen:
  * [Ekstra tabeller][4]: legg til egne tabeller for mer fleksibel håndtering av saker og relasjoner.
* Utvikle og integrere egne applikasjoner:
  * [SuperOffice API-er][16]: lag egne applikasjoner og integrasjoner.
  * [Sandkasse for utvikling (SOD)][13]: et trygt miljø for utvikling og testing.

Verktøyene er tilgjengelige via **Innstillinger og vedlikehold** og krever lite til middels teknisk kompetanse. Med de godt dokumenterte API-ene kan du også utvikle egne integrasjoner og teste dem i et sandkassemiljø.

Alle tilpasninger du lager med disse verktøyene blir automatisk distribuert og vedlikeholdt på plattformen – og sikrer at endringene dine er **robuste**, **bærekraftige** og **framtidssikre**.

### Hvordan fungerer Utviklingsverktøy?

Når du abonnerer på Utviklingsverktøy, får du tilgang til nye alternativer i **Innstillinger og vedlikehold**.

Lisensen blir lagt til [leietakeren din][19] via SuperOffice Operation Center og faktureres månedlig.

Du kan bruke Utviklingsverktøy så mye du ønsker så lenge abonnementet er aktivt. Du kan legge til så mange tilpasninger du vil – dette påvirker ikke prisen.

Ingen [egendefinerte applikasjoner][16] kan brukes i SuperOffice Online uten abonnement. Hvis abonnementet avsluttes, blir applikasjonen deaktivert.

> [!NOTE]
> Bruk av API-er (som medfører målt forbruk) aktiveres av enkelte av disse verktøyene.

### Når trenger du Utviklingsverktøy?

Hvis du trenger tilgang til SuperOffice API-er eller avanserte tilpasningsfunksjoner, bør du abonnere på Utviklingsverktøy. Pris finner du på [SuperOffice.com][20].

| Scenario/miljø | Online | Lokalt |
|---|---|---|
| Bruke tilpasningsverktøy i Innstillinger og vedlikehold | nei | nei |
| Publisere standardapplikasjon | nei (innebygd) | ja |
| Aktivere egendefinert applikasjon | ja | ja |

Du kan fritt tilpasse løsningen via **Innstillinger og vedlikehold** – som lister, personverninnstillinger, maler, salgs- og prosjektguider, og egendefinerte felt.

Du *trenger ikke* Utviklingsverktøy hvis du bruker SuperOffice CRM Online og ønsker å bruke en av de [standardapplikasjonene][17] som finnes i [SuperOffice App Store][21].

Men hvis du har SuperOffice lokalt, *må* du ha Utviklingsverktøy for å legge til integrasjoner eller tilpasninger, uansett om de er laget spesielt for deg eller er standardtillegg.

Det samme gjelder for alle [egendefinerte apper for SuperOffice Online][16]. Du kan lage dine egne eller [kontakte en leverandør direkte][24] for å høre hvilke muligheter du har for en skreddersydd versjon.

### Hvordan får jeg Utviklingsverktøy?

Apputviklere får tilgang [ved registrering][13]. Kunder kan kontakte sin lokale SuperOffice-partner for råd og veiledning.

Hvilke verktøy du trenger avhenger av behovene dine, kompetansen du har, og om du ønsker å kjøpe ekstern hjelp.

## Hva inneholder Utviklingsverktøy?

### CRMScript: Tilpass arbeidsflyter og automatisering

[CRMScript][2] er et svært fleksibelt **skriptspråk** integrert i SuperOffice CRM. Det lar deg lage automatiseringer og arbeidsflyter som passer til hvordan virksomheten din jobber.

[Triggere][3] er basert på CRMScript. De er forhåndsdefinerte triggere og hendelser som lar deg sette opp *«hvis dette, så det»*-flyter direkte i SuperOffice CRM.

Vi anbefaler å utforske mulighetene med triggere før du begynner å bruke CRMScript for å definere en arbeidsflyt. Triggere krever ikke skriptkunnskap – bare at du kjenner systemet godt.

CRMScript krever teknisk kompetanse og passer for de som allerede er kjent med programmeringsspråk som C, C++ eller Java-syntaks.

### Ekstra tabeller: Legg til nye tabeller i databasen og øk fleksibiliteten

SuperOffice CRM leveres med et sett forhåndsdefinerte tabeller som brukes til å lagre data. Det finnes en underliggende logikk for hvordan disse tabellene og dataene er koblet sammen.

Noen av standardtabellene er fleksible – du kan definere hvilke datatyper og egenskaper de skal ha. Disse **egendefinerte feltene** lar deg legge til datoer, tall, tekst eller avkrysningsbokser, og du kan plassere dem på firma-, prosjekt- eller oppfølgingsbildene.

Hvis du trenger flere tabeller, kan du legge til **ekstra tabeller** i databasen når du abonnerer på Utviklingsverktøy.

* Brukere med SuperOffice Service-[brukerplan][1] har full tilgang til disse tabellene og kan vise, redigere, søke og inkludere data i rapporter.
* Brukere med Standard-, Sales- eller Marketing-plan får tilgang via webpaneler (tilleggsfaner). Disse brukerne kan vise og redigere data, men ikke søke i eller inkludere dem i utvalg og dashboards.

Å legge til ekstra tabeller krever teknisk kompetanse. Ofte brukes de i kombinasjon med egendefinerte skjermer.

### Egendefinerte skjermer: Opprett nye skjermer i Service for å støtte dine prosesser

Med Utviklingsverktøy kan du lage egne skjermer i SuperOffice Service tilpasset spesifikke forretningsprosesser.

For eksempel kan du utvide skjermbildet for å registrere saker dersom du trenger mer informasjon enn det som finnes i standardoppsettet.

I kombinasjon med ekstra tabeller gir dette høy grad av fleksibilitet for å skreddersy SuperOffice CRM.

Egendefinerte skjermer i SuperOffice Service kan gjøres tilgjengelig for brukere med Standard-, Sales- eller Marketing-plan via webpaneler.

Du trenger solid teknisk kunnskap for å lage egendefinerte skjermer.

### SuperOffice API-er: Lag egendefinerte tilpasninger

Du får tilgang til alle tilgjengelige SuperOffice API-er:

* REST- og SOAP-webtjenester
* WebHooks
* Connectors
* Integration Servers

API-ene distribueres som [nuget-pakker][22]. SuperOffice Docs inneholder SDK-er, API-referanser, guider, opplæringsmateriell og eksempler. De fleste eksempler (inkludert .NET, Python og PHP) finnes i [SuperOffice GitHub-organisasjonen][23].

SuperOffice-partnere bruker vanligvis SDK-et når de utvikler standardapplikasjoner og integrasjoner som tilbys som produkter i SuperOffice App Store.

### Hva kan Utviklingsverktøy brukes til?

* Du kan tilpasse hvordan brukerne samhandler med SuperOffice CRM – hva de ser og kan gjøre.
* Du kan tilpasse Service-modulen ved å legge til ekstra tabeller og skjermer, eller ved å lage egne skript og makroer.
* Du kan automatisere prosesser, arbeidsflyter og spesifikke handlinger.
* Du kan utvide funksjonaliteten i SuperOffice CRM ved å utvikle en [egendefinert applikasjon][16] som inneholder funksjoner spesifikke for virksomheten din.
* Du kan integrere med andre forretningssystemer som ikke finnes som standardmoduler eller apper i SuperOffice App Store.

Etter hvert som behovene dine vokser, kan også mulighetene i CRM-løsningen din vokse.

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

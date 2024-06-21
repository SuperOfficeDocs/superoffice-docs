---
uid: help-no-privacy-implementation
title: Administrer personverninnstillingene dine (GDPR)
description: "Før du begynner med konfigurering av SuperOffice CRM-databasen for å gjøre den GDPR-kompatibel, må du gjøre litt grunnleggende arbeid."
author: Bergfrid Dias
date: 02.21.2023
keywords: GDPR, samtykke
topic: concept
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Administrer personverninnstillingene dine (GDPR)

Som firma må du samle inn, lagre og håndtere folks personopplysninger. I henhold til GDPR må du nå ha en lovlig grunn til hvorfor du vil lagre denne informasjonen.

Personvernforordningen (GDPR) gir borgere i EU større kontroll over personopplysningene sine og sikrer at informasjonen blir sikkert beskyttet over hele Europa, uavhengig av om databehandlingen foregår i EU eller ikke.

Alle virksomheter samler inn personopplysninger om prospekter, kunder, leverandører og forretningsforbindelser. Dette er typisk informasjon som lagres i CRM-databasen din, og du må kunne dokumentere og håndtere den i henhold til hvordan du driver virksomheten din og i henhold til GDPR-kravene.

For å gjøre det enklere har SuperOffice CRM en rekke personvernfunksjoner som kalles Samtykkehåndtering, disse er utviklet for å hjelpe deg med å dokumentere når, hvordan og hvorfor nye personopplysninger kom inn i CRM-løsningen.

> [!TIP]
> Hvis du trenger hjelp til å konfigurere GDPR-innstillingene i samsvar med hvordan du driver virksomheten, anbefaler vi alltid at du bruker en av [våre dyktige konsulenter][1] for å sikre at kravene følges.

## SuperOffice CRM dekker dokumentasjonsbehovene dine

Informasjon om personer og deres personopplysninger kan lagres på flere måter i SuperOffice CRM. Den kan komme fra manuell registrering, via e-post, via chat, servicesaker, webskjema eller integrasjoner til andre back-end-systemer.

Uansett hvordan en person "kommer inn" i databasen, tilbyr SuperOffice CRM den dokumentasjonen et firma trenger for HVORFOR, HVORDAN og NÅR nye personopplysninger kommer inn i systemet.

Det betyr at du er ansvarlig for å definere retningslinjer som samsvarer med GDPR.

Deretter kan du angi at SuperOffice CRM skal registrere automatisk:

* Det riktige **formålet** (HVORFOR du lagrer informasjonen om en bestemt person)

* **Hjemmel** (GDPR artikkel 6.1 - Lovligheten av behandlingen)

* **Kilden/opprinnelsen** (HVORDAN denne personen ble med i SuperOffice CRM, for eksempel: manuelt registrert, via nettskjema, e-post)

* **Dato og klokkeslett** (NÅR informasjonen om en person ble lagt inn)

* **Hvem gjorde det**

For å hjelpe deg med å oppfylle GDPR-kravene inneholder SuperOffice CRM en hel rekke funksjoner.

I starten er det noen standardinnstillinger du kan endre på for å passe til måten du jobbet på, og det finnes flere alternativer for å støtte hvordan firmaet samler inn og håndterer personopplysninger.

## Be om samtykke

GDPR skisserer hva som anses som lovlige grunner til å håndtere personopplysninger og krever at du får personens samtykke til å lagre dataene deres og respekterer personvernet deres.

I noen tilfeller må du be om eksplisitt samtykke til å samle inn og lagre personopplysninger. Det kan være aktuelt hvis virksomheten din samler inn sensitive personopplysninger om en person. Det er også vanlig praksis å be om samtykke på forhånd når man innhenter personopplysninger via innkommende markedsføringsmetoder.

Når eksplisitt samtykke er nødvendig, sier GDPR at du må dokumentere selve samtykket, samt hvor det ble samlet inn, når det ble samlet inn og av hvem.

Det oppnår du ved å bruke feltene for samtykkehåndtering i SuperOffice CRM:

* **Rettslig grunnlag:** Der du kan dokumentere årsaken til hvorfor du ønsker å lagre og bruke en enkeltpersons data.

* **Formål:** Der du kan dokumentere hva du skal bruke dataene til.

* **Kilde:** der du registrerer hvordan en personer personopplysninger ble samlet inn. Dette kan være alt fra å få et visittkort, til å motta en e-post eller noen som fyller ut et webskjema på nettstedet ditt.

Hvilke typer formål, hjemler og kilder du må bruke, vil avhenge av hvordan virksomheten din samler inn personopplysninger og av hvilke grunner og til hvilke formål. Når du har identifisert dette, kan du definere disse feltene i SuperOffice CRM.

## Definer krav til personvern og samtykke

For å definere disse feltene, gå til Innstillinger og vedlikehold og velg **Personvern**. Her kan du definere de ulike samtykkene virksomheten din krever for å dokumentere og lagre data.

Det er allerede opprettet to standardformål i systemet som du kan bruke:

![I Innstillinger og vedlikehold kan du definere krav til personvern og samtykke -screenshot][img1]

Den første, **Salg og tjenester**, antyder at grunnen til at du lagrer personopplysninger i CRM-løsningen din er at du ønsker å selge og/eller betjene personen med dine produkter og tjenester.

Den andre, **E-markedsføring**, sier at formålet med å lagre informasjonen er å sende markedsføringsmateriale til en person. I mange europeiske land krever dette formålet eksplisitt samtykke, spesielt når du sender markedsføringsmateriell til potensielle kunder.

Disse formålene kan være, eller ikke være, de riktige samtykkene å bruke for ditt firma. Basert på personvernerklæringen til ditt eget firma, må du:

* Definere hvilke personvernfelt som er riktige for firmaet ditt.
* Konfigurer personverninnstillingene i henhold til samtykkedokumentasjonen du trenger.
* Oppdatere, legge til eller slette alle grunnene firmaet trenger for å lagre samtykker.

## Kom i gang med GDPR i SuperOffice CRM

Hvis du vil konfigurere SuperOffice CRM i henhold til personvernforordningen, må du utføre tre grunnleggende trinn:

1. Forberedelse
1. Konfigurering
1. Tildeling av tilgangsrettigheter

Du kan konfigurere SuperOffice CRM selv hvis du har grunnleggende behov, eller hvis du har erfaring med å sette opp et CRM-system fra tidligere. Alternativt kan du be en av våre konsulenter om å hjelpe deg å gjøre det.

### Forbered firmaet ditt for GDPR

Det er ledelsens ansvar å vite hvordan GDPR-loven gjelder for virksomheten. En personvernstrategi må være på plass og du må vite hvilke data du vil lagre i hvilke systemer, samt hvordan du har tenkt å håndtere disse dataene. Alt dette avgjør hvordan du konfigurerer SuperOffice CRM slik at det støtter driftsstrategien og -prosessene.

For å hjelpe deg å blir klar for dette, har vi laget en 5-trinns plan som vil hjelpe deg:

1. Kartlegg personopplysningene firmaet lagrer.
1. Finn ut hvilke data du må beholde.
1. Finn ut hvordan du overholder GDPR.
1. Få på plass sikkerhetstiltak.
1. Etabler prosedyrer for å håndtere personopplysninger.

Når du forbereder firmaet ditt på GDPR, må du ha to hovedmål i tankene:

* Gjør eksisterende data klare for GDPR.
* Juster personvernerklæringene dine for å sikre at de samsvarer med GDPR.

#### Kartlegg personopplysningene firmaet lagrer

Det er viktig å sjekke hvilke personopplysninger firmaet er autorisert til å lagre.

Hvilken type personopplysninger du kan lagre, avhenger av hvilken type virksomhet du er i. Du bør også tenke på hvordan du skal bruke informasjonen du lagrer.

Derfor anbefaler vi alle kundene våre å konsultere en advokat som er spesialist på GDPR. De vil kunne gi deg juridiske råd om hvilken informasjon firmaet har lov til å lagre og når du trenger å få eksplisitt samtykke til å lagre personopplysninger.

Basert på de juridiske anbefalingene du får, kan du kartlegge hvor personopplysningene i firmaet kommer fra og dokumentere hvordan du ønsker å bruke disse dataene.

Hva er det rettslige grunnlaget for lagring av personopplysninger?
Grunnen til at du lagrer visse personopplysninger kalles det hjemmel.

Det finnes en rekke hjemler for lagring av informasjon, de er tilgjengelig i SuperOffice CRM (fra versjon 8.2). Dette er en standardliste, og den vil gjelde for 95 prosent av virksomhetene.

Du kan når som helst redigere denne listen med hjemmel i Innstillinger og vedlikehold ved å legge til de hjemmelkategoriene som kreves for akkurat ditt firma, eller endre navnene slik at de passer til din terminologi.

Hvis du har mye eksisterende data du ønsker å oppdatere med nytt eller endret hjemmel, kan du gjøre dette ved å bruke funksjonen masseredigering.

#### Finn ut hvilke data du trenger å beholde

For å finne ut hvilke personopplysninger du vil beholde, se på informasjonen du lagrer for øyeblikket.

Du kan finne ut hvilken informasjon firmaet lagrer ved å sjekke Personkortene til personene dine: potensielle kunder, kunder og tapte kunder. Du kan ta en titt på:

* Person-fanen, som inneholder informasjon som en persons telefonnummer, e-postadresse og mobiltelefonnummer, samt informasjon om kundens kategori og type virksomhet,

* Mer-fanen, som kan inneholde brukerdefinerte felt du har lagt til i SuperOffice CRM-løsningen,

* Interesse-fanen, som kan inneholde ulike typer kommunikasjon, arbeidsrelaterte arrangementer firmaet kan organisere, eller andre personlige interesser som en persons hobby, for eksempel.
Når du vet hvilken informasjon du allerede har i databasen, kan du bestemme hvilke kundekategorier du trenger og hvilke du ikke trenger.

Kanskje nye kategorier må legges til, og andre bør slettes?

En annen ting du bør tenke på er hvor lenge du trenger å lagre data om potensielle kunder, kunder og tapte kunder.

Etter en viss periode må du slette informasjon som ikke lenger brukes.

Til hjelp kan du laste ned en mal som hjelper deg å kartlegge alle kategoriene du ønsker å bruke, hjemmelen for lagring og hvor lenge du har tenkt å lagre informasjonen.

Uavhengig av GDPR-forordningen er det verdt å vurdere generelt hvilke data du oppbevarer i CRM-databasen, og hvor lenge. Vi anbefaler at du ikke lagrer unødvendig informasjon og fjerner data som ikke brukes. Det beste er å lagre data i kortest mulig tid.

Hvis virksomheten din samler inn mye data som egentlig ikke kan brukes til noe, vil det for det første bare gi deg en rotete database, og for det andre har du rett og slett ikke lov til å lagre irrelevant eller overflødig informasjon i henhold til EU-forordningen i [GDPR (art. 5)][2].

Still disse to spørsmålene under denne oppryddingsprosessen:

* Hvorfor arkiverer vi egentlig disse dataene i stedet for bare å slette dem?
* Hva prøver vi å oppnå ved å samle inn alle disse kategoriene av personopplysninger?
* Hvem har tilgang til personopplysninger i SuperOffice CRM-løsningen vår, og bør de ha tilgang til denne informasjonen?

#### Finn ut hvordan du overholder GDPR

Nå som du vet hvilken informasjon du vil beholde og hvordan du vil oppdatere den eksisterende kundeinformasjonen, skal vi se på hvordan du kan sørge for at du overholder GDPR i fremtiden også.

Når du skal gjøre dette, starter du med å stille dette spørsmålet: "Hvordan kommer personer vanligvis inn i SuperOffice-databasen min?"

Personer kan legges til databasen på tre måter:

* Persondetaljer kan samles inn digitalt. Du kan motta persondetaljer ved bruk av webskjema, forespørsler/saker, innkommende e-post eller chat.

* Persondetaljer kan samles inn manuelt. Du kan motta persondetaljer gjennom møter, telefonsamtaler, messer, arrangementer og sosiale medier.

* Persondetaljer kan hentes fra andre systemer. Du kan legge til persondetaljer gjennom en dataimport, integrasjoner med andre systemer, for eksempel ERP-løsningen din.
Når persondetaljer legges til digitalt, kan du be om en persons samtykke på nettstedet ditt eller via et nettskjema, for eksempel, mens folk fyller ut detaljene sine.

Når du registrerer opplysningene deres manuelt eller gjennom andre systemer, må du imidlertid be om personens samtykke til å lagre og bruke personopplysningenes deres separat etter at du har lagt til deres detaljer i CRM-løsningen.

For å hjelpe deg med å be om dette samtykket inneholder SuperOffice CRM en e-postbekreftelse for personvern. Denne e-postmeldingen sendes til personer for å informere dem om at du har tenkt å lagre opplysningene deres i CRM-databasen.

For å kunne be om samtykke fra personene du planlegger å lagre i CRM-databasen, må du først og fremst vite hvordan du har samlet inn opplysningene deres.

Du kan lage en liste over alle kildene du samler inn personopplysninger fra. Lag en liste over nettskjemaene du bruker, for eksempel nettsidene der du bruker SuperOffice Chat.

Når du ber om samtykke til å lagre en persons opplysninger, bør du også gjøre det mulig for dem å kontrollere samtykket sitt til enhver tid.

Spørsmål for å sjekke om personene dine kan administrere samtykket sitt:

* Tilbyr vi en kobling til vår personvernerklæring?
* Kan folk enkelt godta og samtykke til vår personvernerklæring?
* Kan folk melde seg på abonnementene vi tilbyr?
* Er det mulig for dem å avmelde seg ut også?

#### Få på plass sikkerhetstiltak

I tråd med GDPR må firmaet utvikle og implementere sikkerhetskontroller i hele CRM-løsningen for å hindre potensielle databrudd.

Det betyr å få på plass sikkerhetstiltak for å beskytte mot datainnbrudd eller lekkasjer, og treffe raske tiltak for å varsle enkeltpersoner og myndigheter hvis det oppstår en slik hendelse.

SuperOffice kan selvfølgelig hjelpe deg med dette ved å sørge for at dataene til alle SuperOffice CRM nettkunder lagres trygt og sikkert.

Men det er fortsatt ditt ansvar å sørge for at du har de riktige sikkerhetstiltakene på plass hvis og når et datainnbrudd oppstår.

##### Hvordan kan SuperOffice CRM hjelpe deg med å håndtere hendelser?

Det er lurt å opprette en arbeidsflyt som inneholder en detaljert beskrivelse av alle trinn du bør ta når et datainnbrudd oppdages eller rapporteres.

Når du har oppdaget et datainnbrudd, må du [informere alle personer som er berørt av dette innen 72 timer][4].

SuperOffice Service kan hjelpe deg å samle inn rapporter om et mulig datainnbrudd. Du kan konfigurere Service til å følge arbeidsflyten du har utformet for å informere om og begrense det potensielle datainnbruddet.

Men funksjonen Utsendelser i SuperOffice kan hjelpe deg med å informere alle personer som er berørt.

Du kan vurdere å lage en e-postmal for datainnbrudd. Denne malen kan brukes når det oppstår et datainnbrudd. For eksempel for å informere kontaktpersonene dine om hva som har skjedd og hvordan du planlegger å løse situasjonen.

#### Etablere prosedyrer for å administrere personopplysninger

Under GDPR har alle europeiske individer 8 grunnleggende personvernrettigheter.

Du må etablere retningslinjer og prosedyrer for personvern for hvordan du vil oppfylle alle disse GDPR-rettighetene.

Her finnes det også noen spørsmål som kan hjelpe å bli klar til å gi de 8 GDPR-rettighetene:

* Hvordan kan enkeltpersoner gi sitt samtykke på en lovlig måte?
* Hva er prosessen hvis en person ønsker at dataene deres skal slettes?
* Hvordan vil du sikre at informasjon blir slettet på tvers av alle plattformer?
* Hvis en person ønsker at dataene deres skal overføres, hvordan vil du gjøre det?
* Hvordan vil du bekrefte at personen som ba om å få dataene sine overført, virkelig er den personen de sier de er?
* Hva er kommunikasjonsplanen i tilfelle datainnbrudd?

### Konfigurer databasen for GDPR

Basert på personvernerklæringene dine kan du nå:

* Endre personvernlister
* Konfigurere personverninnstillinger
* Legge til og redigere abonnementstyper

Når du vet hvilke personopplysninger du har tenkt å lagre i SuperOffice CRM, samt hvorfor og når du skal lagre dem, kan du konfigurere SuperOffice til å støtte policyene dine.

Hvis du vil konfigurere GDPR-funksjonaliteten i SuperOffice CRM-løsningen, kan du:

* **Endre personvernlister:** Som standard er det to hovedformål for lagring og behandling av personopplysninger definert i SuperOffice CRM. Du kan endre disse innstillingene slik at de passer til det som er riktig for ditt firma.

* **Konfigurere personverninnstillinger:** Dette inkluderer reglene for om og når du automatisk skal informere en person via e-post om at informasjonen deres ble lagret i systemene dine. Eller konfigurere systemet på en slik måte at e-markedsføringskommunikasjon ikke sendes til CRM-personer som ikke har nødvendige samtykker registrert (dvs. ekskludere fra e-postlisten).

* **Legge til og redigere abonnementstyper:** Denne funksjonaliteten hjelper deg å tilby en person muligheten til å ikke bare gi samtykke til å motta e-markedsføringsutsendelser fra firmaet ditt, men også til å definere sine egne preferanser for utsendelsen.
Disse veiledningssidene inneholder både en instruksjonsvideo og en trinn-for-trinn-veiledning som du kan bruke til å konfigurere SuperOffice CRM-løsningen slik at den samsvarer med personvernerklæringene dine.

### Tildele tilgangsrettigheter

Fordi hovedmålet med GDPR er å beskytte folks personvern og holde personopplysningene deres trygge, skal ikke all GDPR-relatert funksjonalitet i SuperOffice CRM være tilgjengelig for alle i firmaet.

Du må tilordne tilgangsrettigheter for å utføre følgende funksjoner:

* **Administrere abonnementer på e-markedsføring:** Som standard er det bare personen som kan oppdatere abonnementsinnstillingene. Men du kan gi bestemte brukere tilgangsrettigheter som gjør det mulig for dem å oppdatere e-markedsføringsabonnementene til en person manuelt.

* **Masseredigere personinformasjon:** Med denne funksjonaliteten kan du legge til, endre eller fjerne personlige opplysninger for grupper av personer, aktiviteter, salg og prosjekter. Alt med bare noen få klikk.

* **Masseslette personinformasjon:** Med denne funksjonaliteten kan du slette personer som ikke (eller ikke lenger) skal lagres i databasen som følge av firmaets personvernerklæring.
GDPR-samsvar – et pågående prosjekt

Ved å fullføre de tre trinnene har du tatt viktige skritt mot GDPR-samsvar. Men samsvar med GDPR et pågående prosjekt og involverer alle IT-systemene firmaet bruker. Fra nå av bør du fokusere på å opprettholde riktig håndtering av personlige kundedata i SuperOffice CRM – i henhold til firmaets personvernerklæring og GDPR-kravene.

## Beslektet

* [Last ned malen "Forbered deg på GDPR"][3]
* [Rediger e-postbekreftelsen for personvern][6]

<!-- Referenced links -->
[1]: https://www.superoffice.com/consulting/contact/
[2]: https://eur-lex.europa.eu/legal-content/EN/TXT/HTML/?uri=CELEX:02016R0679-20160504&from=EN
[3]: ../../../../assets/downloads/prepare-for-the-gdpr-download-template-9.xlsx
[4]: https://www.superoffice.com/blog/gdpr/
[6]: edit-privacy-confirmation-email.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/security/privacy.png

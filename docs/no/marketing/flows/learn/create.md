---
uid: help-no-flow-create
title: Opprette en ny flyt
description: Hvordan opprette ny flyt og definere flytinnstillinger i SuperOffice Marketing
keywords: flyt, markedsføringsautomatisering, ny flyt, flytinnstilling
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Opprette en ny flyt

## Trinn

1. Velg **Markedsføring** i navigatoren.
1. Gå til **Flyter**-fanen.
1. Hvis nødvendig, klikk på **Legg til mappe** for å [opprette en mappe for flyten][8].
1. Klikk på **Flyt**-knappen under **Opprett ny** på høyre side av skjermen.
1. I dialogboksen angir du et kort, beskrivende **Navn**.
1. [Fyll inn feltene](#fields) som beskrevet nedenfor. Husk å klikke **Lagre** regelmessig for å lagre arbeidet ditt. Flyten lagres ikke automatisk.
1. [Definer trigger og filter for flyten.](#trigger)
1. [Legg til trinn.](#add-step)
1. Angi hva som skjer når flyten avsluttes.
1. Klikk **Lagre** når du er ferdig.

![Set properties for new flow -screenshot][img1]

## <a id="fields"></a>Fylle ut flytfeltene

### Innstillinger (for flyt)

| Innstilling | Beskrivelse |
|---|---|
| Navn | En beskrivende etikett. |
| Beskrivelse | Forklar formålet med flyten. Denne teksten er kun synlig internt.|
| Tidssone | Påkrevd for å begrense sendetidspunktet. |
| Fjern kontakten fra disse flytene når kontakten er registrert | Hvis valgt, endres deltakerens status til *Dropout*, og de forlater de valgte flytene. Eksempel: fjern fra Lead nurturing når påmeldt i Onboarding-flyten. |
| Eier | Medarbeider som oppretter flyten. |
| Synlig for | Tilgang til flyten (eier, eiers gruppe, alle). Tilgangsnivået kontrolleres også av funksjonelle rettigheter. |
| Mappe | Plasseringen av flyten. |

### E-post (innstillinger)

Vanlige e-postinnstillinger for alle e-poster i flyten. Hvis du ikke planlegger å sende e-poster fra denne flyten, kan du hoppe over å fylle ut disse innstillingene.

| Innstilling | Beskrivelse |
|---|---|
| Abonnementstype | Angis på flytnivå (i stedet for individuelt på hvert e-posttrinn). Sikrer at alle e-poster i en flyt har samme abonnementstype. |
| Fra, fra navn, fra adresse | Samme avsender på alle e-posttrinn innen flyten. I listen **Fra**, velg **Bruk alltid** og skriv inn avsenderens e-postadresse i feltet nedenfor for å bruke samme avsender for alle utsendelser. Du kan også velge en salgs- eller supportperson som avsender, hvis en er definert for denne mottakeren. Angi en e-postadresse som skal brukes hvis ingen salgs- eller supportperson er tilgjengelig. Hvis din administrator har aktivert [global e-postvalideringspreferanse][12], velger du domenet du vil sende fra i nedtrekkslisten. |
| Svar til | Samme alternativer som ovenfor. I tillegg kan du velge **Bruk fraadressen som svaradresse**. Alle svar vil da bli sendt til avsenderen. |
| Begrens utsending av e-post og tekstmeldinger til en gitt tidsramme | Begrens sendetidspunktet. Deltakere venter i dette trinnet til den tillatte tidsrammen starter. Velg mellom arbeidsdag (man-fre) og ukedag (man-søn). Spesifiser tid. Krever at tidssone er satt. |
| Bruk Google Analytics | Aktiverer Google Analytics-sporing for alle e-poster i en flyt. Når den er valgt, kan du angi kilde og kampanje. |

> [!TIP]
> Tidspunkt påvirker åpningsrate og interaksjon med e-post. Bruk innstillingen **tidsramme** for å maksimere leserinteraksjon og for å ikke forstyrre abonnentene dine om natten.

![Sette felles e-postinnstillinger for ny flyt -screenshot][img2]

### Suksesskriterier (valgfritt)

Suksesskriterier definerer [hva suksess betyr for en flyt][7].

1. Velg **Sukses** fra venstremenyen.
1. Klikk **Legg til suksesskriterier** og velg et alternativ.
1. Velg eventuelt **Deltaker flyttes direkte til Fullfør-trinnet når suksesskriteriene er oppfylt**.

    * Hvis valgt: Deltakerens status endres til *Fullført med suksess* og de avslutter alle andre handlinger senere i flyten.

    * Hvis ikke valgt: Deltakerens status forblir *Aktiv* og de fortsetter å følge flyten. Når de når **Fullfør**-trinnet, endres statusen deres til *Fullført med suksess*. Bruk dette alternativet hvis suksessrate brukes primært for statistikk, og du vil at deltakeren skal fullføre alle trinnene selv om suksess er oppnådd.

![Sett suksesskriterium for ny flyt -screenshot][img3]

## <a id="trigger"></a>Definer trigger og filter for flyten

Trinnet **Trigger** legges automatisk til som startpunkt for enhver flyt. Det bestemmer hvem flyten er relevant for. Triggere aktiveres bare for kjørende eller pausede flyter.

> [!NOTE]
> Det *er* mulig å opprette en flyt uten noen automatisert trigger - ved å bruke oppgaveknappen i personkortet eller en utvalgsoppgave. Vi vil diskutere dette spesialtilfellet i et annet emne.

1. Velg **Trinn** fra venstremenyen.
1. Klikk på **Trigger**-trinnet i flytskjemaet.
1. I innstillingene på høyre side, klikk **Legg til trigger** og velg et alternativ.
1. Fyll inn de nødvendige innstillingene for den valgte triggeren.
1. Angi eventuelt tilleggskvalifiseringskriterier.
1. Velg eventuelt **En kontaktperson kan bare starte denne flyten én gang**. Hvis en flyt trigges en gang til på samme person, sikrer denne innstillingen at de ikke blir påmeldt på nytt.

![Legg til trigger for ny flyt -screenshot][img5]

| Trigger | Beskrivelse |
|---|---|
| Person opprettet | Når en ny person registreres, uavhengig av kilde (unntatt import). |
| Person oppdatert | Når en person oppdateres, uavhengig av hva som er oppdatert (unntatt import og masseoppdatering). |
| Salg opprettet | Når et salg registreres på personen. |
| Salg solgt | Når et salg på personen settes til solgt. |
| Salg tapt | Når et salg på personen settes til tapt. |
| Lagt til i prosjekt | Når en person legges til som prosjektmedlem. |
| Sak opprettet | Når en sak opprettes på personen (uavhengig av kilde). |
| Skjema sendt | Når et skjema (sendt inn av en person) **behandles** (et manuelt trinn kan være involvert før personen ender opp i flyten). |
| Lenke klikket | Når en person klikker en sporet lenke. |

**Merk:**

* Hvis du velger *skjema sendt* eller *lenke klikket*, vær oppmerksom på eventuelle varselikoner. Skjemaer og sporede lenker kan også ha tilknyttede handlinger.
* For å inkludere personer opprettet eller oppdatert ved import, må du manuelt legge til importerte personer fra utvalget til en flyt.
* Når du reagerer på person oppdatert, har vi tilgang til de nåværende verdiene av personfeltene. Vi har imidlertid ikke informasjon om hvilket felt som ble oppdatert eller den forrige verdien av et felt før oppdateringen.

### Legg til personfilter (valgfritt)

**Filtre** er tilleggskriterier som brukes på alle foreslåtte deltakere (automatisk og manuelt lagt til). Bruk personfilteret for å velge spesifikke personer for flyten din. For eksempel, sett filteret til *personkategori = potensielle kunder* for å tillate bare potensielle kunder inn i flyten, ikke eksisterende kunder, som fyller ut et skjema på nettstedet ditt. Dette lar deg skreddersy innholdet til forskjellige brukergrupper.

> [!NOTE]
> Filtre gjelder bare når **nye flytdeltakere identifiseres**. Eventuelle endringer gjort i filteret etterpå påvirker ikke deltakere som allerede er påmeldt.

1. Velg personfeltet du vil filtrere på.
1. [Velg verdier for kriteriet][13] i de forskjellige feltene på linjen (som i Finn-skjermen).
1. Klikk **Legg til** for å angi tilleggskriterier (legger til en ny linje).

![Add contact filter on trigger of new flow -screenshot][img6]

### Ekskluderingsliste (valgfritt)

Ekskluderingslisten **forhindrer utvalgte personer fra å bli lagt til i flyten**. Bruk et [statisk utvalg][14] for å håndtere unntak, som for eksempel:

* Forhindre spesifikke kunder fra å motta generelle masse-e-poster.
* Send påminnelser, men ikke til de som allerede er påmeldt.

## <a id="add-step"></a>Legg til trinn

1. Velg **Trinn** fra venstremenyen.
1. Velg et trinn og dra det til hvor du ønsker å legge det til i flytskjemaet.
1. Trinnmenyen endres til **trinninnstillinger**. [Tilgjengelige innstillinger][9] avhenger av trinnets type.

    * [Send melding][3]
    * Flytkontroll
    * [Oppdater deltaker][4]
    * [Opprett aktivitet][5]
    * [Interne handlinger][10]

Klikk X i trinninnstillingsheaderen for å gå tilbake til trinnmenyen.

### Første gang

Når du åpner fanen **Trinn** for første gang, vil du se noe slikt:

![Flyt og trinn -screenshot][img4]

* Et flytskjema med en **Trigger**, en **plassholder** for å legge til et trinn, og et **Avsluttet**-trinn (i midten).
* En liste av tilgjengelige trinntyper (til høyre).

## <a id="wait"></a>Flytkontroll

De fleste trinn i en flyt representerer handlinger knyttet til deltakeren, som å oppdatere personens interesser. Flytkontrolltrinn er imidlertid annerledes; de involverer **timing** og **segmentering**.

Uten flytkontroll vil enkeltpersoner gå fra en handling til en annen til de enten faller fra eller når slutten av flyten. For eksempel, de kan motta hele introduksjonsprogrammet på en enkelt dag eller motta alle nyhetsbrev samtidig.

Videre, uten flytkontroll, ville alle påmeldte følge den samme sekvensen av trinn. Mens dette kan være egnet for en enkel flyt, ved å sette betingelser for påfølgende handlinger, kan du for eksempel sende et nyhetsbrev på mottakerens foretrukne språk eller sende en tilbakemeldingsundersøkelse kun til de som deltok på webinaret.

**Alternativer:**

* Ventetid
* Vent på hendelse
* [Del][1]

> [!NOTE]
> Deltakere blir merket med et **vent til**-tidsstempel når de når et ventetrinn. Hvis neste trinn er en e-post eller SMS, og en tidsramme er spesifisert i e-postinnstillingene, kan den totale ventetiden overskride det som er satt i trinnet.

### Ventetid

Bruk et tidsbasert ventetrinn for å vente et bestemt antall dager før du sender neste e-post/SMS, eller for å vente til en bestemt dato for spesifikke anledninger eller handlinger. For eksempel, for å sende påminnelser 1 uke, 1 dag og 1 time før et webinar.

1. Dra **Ventetid**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
1. Angi betingelsen. Gjør ett av følgende:

    * Velg **Antall dager/timer etter forrige trinn** og deretter velg antall og enhet.
    * Eller, velg **Til spesifikk dato/klokkeslett** og deretter velg en dato fra kalenderen.

Aktive flytdeltakere forblir ved dette trinnet før de fortsetter til neste trinn i henhold til den definerte regelen.

![Flyttrinn ventetid -screenshot][img7]

### Vent på hendelse

Bruk et handlingbasert ventetrinn for å vente på at deltakeren skal gjøre noe (sende inn et skjema eller klikke på en lenke).

1. Dra **Vent på hendelse**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.

2. Klikk **Legg til handling** og velg hvilken hendelse du vil vente på.

3. Fra listen, velg navnet på lenken eller skjemaet du vil vente på.

4. Angi hvor lenge du er villig til å vente (et tidsavbrudd). Standard maksimal ventetid er 7 dager. Hvis du fjerner avmerkingen for denne innstillingen, vil deltakere som ikke svarer bli stående ved dette trinnet på ubestemt tid.

5. Velg eventuelt **Avslutt flyten dersom ingen handlinger utføres innen tidsavbrudd**. Deltakere som ikke svarer vil forlate flyten med statusen *Drop out*. Du kan velge å flytte dem til en annen flyt og/eller legge dem til i et statisk utvalg.

![Flyttrinn vent på hendelse -screenshot][img8]

> [!TIP]
> Du kan vente på mer enn én handling innen et enkelt trinn. Den første forekommende handlingen (skjemainnsending, lenkeklikk eller tidsavbrudd) flytter deltakeren videre i flyten. Bare gjenta trinn 2 og 3 ovenfor.

## Hva skjer nå?

Etter å ha designet en flyt og lagret den, lukkes **Dialogvindu for å redigere flyt**, og flytskjemaet vises i **Vis flyt**-skjermen. Den nye flyten har status **Stoppet** til en flytadministrator manuelt starter den ved å endre statusen til Kjørende = sann.

## Relatert innhold

* [Flytt, dupliser, eller fjern trinn][2]
* [Definer flythandlinger][3]
* [Del flyt][1]
* [Start flyt][6]

<!-- Referenced links -->
[1]: split.md
[2]: update.md
[3]: define-flow-actions.md
[4]: define-flow-actions.md#update
[5]: define-flow-actions.md#create
[10]: define-flow-actions.md#internal
[6]: run-pause-end.md
[7]: index.md#success
[9]: step-settings.md
[8]: ../../learn/create-folder.md
[12]: ../../../admin/lists/learn/add-items-to-mailing-domain.md
[13]: ../../../search-options/learn/search-criteria.md
[14]: ../../../search-options/selection/learn/static-selections.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-settings.png
[img2]: ../../../../media/loc/en/marketing/flow-email-settings.png
[img3]: ../../../../media/loc/en/marketing/flow-success-form-submission.png
[img4]: ../../../../media/loc/en/marketing/flow-steps-initial.png
[img5]: ../../../../media/loc/en/marketing/trigger-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/flow-trigger-filter-contact.png
[img7]: ../../../../media/loc/en/marketing/flow-wait-time.png
[img8]: ../../../../media/loc/en/marketing/flow-wait-action.png

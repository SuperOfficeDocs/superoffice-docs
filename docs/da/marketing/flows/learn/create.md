---
uid: help-da-flow-create
title: Opret et nyt flow
description: Opret et nyt flow
keywords: Marketing, flow
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.17.2024
version: 10.3.9
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Opret et nyt flow

## Trin

1. Vælg **Marketing** i navigatoren.
1. Gå til fanen **Flows**.
1. Klik om nødvendigt på **Tilføj mappe** for at [oprette en mappe til flowet][8].
1. Klik på knappen **Flow** under **Opret ny** på højre side af skærmen.
1. I dialogboksen **Floweditor** skal du indtaste et kort, beskrivende **Navn**.
1. [Udfyld felterne](#fields) som beskrevet nedenfor. Husk at klikke på **Gem** regelmæssigt for at gemme dit arbejde. Flowet gemmes ikke automatisk.
1. [Definér flow-trigger og filter.](#trigger)
1. [Tilføj trin.](#add-step)
1. Specificér, hvad der sker, når flowet afsluttes.
1. Klik på **Gem**, når du er færdig.

![Angiv egenskaber for nyt flow -screenshot][img1]

## <a id="fields"></a>Udfyldning af flow-felter

### Indstillinger (for flow)

| Indstilling | Beskrivelse |
|---|---|
| Navn | En beskrivende etiket. |
| Beskrivelse | Forklar formålet med flowet. Denne tekst er kun synlig internt. |
| Tidszone | Kræves for at begrænse sendetidsrammen. |
| Når personen er tilmeldt, skal du fjern vedkommende fra disse andre flows | Hvis markeret, ændres deltagerens status til *Frafald*, og de forlader de valgte flows. Eksempel: fjern fra Lead nurturing, når tilmeldt Onboarding-flowet. |
| Ejer | Den medarbejder, der opretter flowet. |
| Synlig for | Adgang til flowet (ejer, ejers gruppe, alle). Adgangsniveau kontrolleres også af funktionelle rettigheder. |
| Mappe | Flowets placering. |

### E-mail (indstillinger)

Fælles e-mail-indstillinger for alle e-mails i flowet. Hvis du ikke planlægger at sende e-mails fra dette flow, kan du springe indtastning af disse indstillinger over.

| Indstilling | Beskrivelse |
|---|---|
| Abonnementstype | Indstil på flow-niveau (i stedet for individuelt på hvert e-mail-trin). Sikrer, at alle e-mails inden for et flow har samme abonnementstype. |
| Fra, fra navn, fra adresse | Samme afsender på alle e-mail-trin i flowet. I **Fra**-listen skal du vælge **Brug altid** og indtaste afsenderens e-mail-adresse i feltet nedenfor for at bruge den samme afsender til alle mails. Du kan også vælge en salgsperson eller supportperson som afsender, hvis en er defineret for denne modtager. Indtast en e-mail-adresse, der skal bruges, hvis ingen salgsperson eller supportperson er tilgængelig. Hvis din administrator har aktiveret [den globale e-mail-valideringspræference][12], skal du vælge det domæne, du vil sende fra i rullemenuen. |
| Svar til | De samme muligheder som ovenfor. Derudover kan du vælge **Brug "Fra" som svaradresse**. Eventuelle svar sendes derefter til afsenderen. |
| Send kun e-mails og SMS'er inden for en bestemt tidsramme | Begrænser sendetidsrammen. Deltagerne venter i dette trin, indtil den tilladte tidsramme starter. Vælg mellem Arbejdsdag (man-fre) og Ugedag (man-søn). Specificér tid. Kræver, at tidszone er indstillet. |
| Brug Google Analytics | Aktiverer Google Analytics-sporing for alle e-mails i et flow. Når markeret, kan du indstille kilde og kampagne. |

> [!TIP]
> Timing påvirker e-mailens åbningsrate og interaktion. Brug indstillingen **tidsramme** for at maksimere læserinteraktion og for ikke at forstyrre dine abonnenter om natten.

![Indstil fælles e-mail-indstillinger for nyt flow -screenshot][img2]

### Succeskriterier (valgfrit)

Succeskriterier definerer [hvad succes betyder for et flow][7].

1. Vælg **Succes** fra venstremenuen.
1. Klik på **Tilføj succeskriterier** og vælg en mulighed.
1. Vælg valgfrit **Deltageren flyttes direkte til trinnet Afslut, når succeskriteriene er opfyldt**.

    * Hvis markeret: Deltagerens status ændres til *Afsluttet med succes*, og de afslutter eventuelle andre handlinger senere i flowet.

    * Hvis ikke markeret: Deltagerens status forbliver *Aktiv*, og de fortsætter med at følge flowet. Når de når **Afslut**-trinnet, ændres deres status til *Afsluttet med succes*. Brug denne mulighed, hvis succesraten primært bruges til statistik, og du vil have, at deltageren gennemfører alle trinene, selvom succes er nået.

![Indstil succeskriterier for nyt flow -screenshot][img3]

## <a id="trigger"></a>Definér trigger og filtre

**Trigger**-trinnet tilføjes automatisk som udgangspunkt for ethvert flow. Det bestemmer, hvem flowet er relevant for. Triggere aktiveres kun for i gang eller pausede flows.

> [!NOTE]
> Det *er* muligt at oprette et flow uden nogen automatiseret trigger - ved at bruge personopgave-menuen eller en udvalgsopgave. Vi vil diskutere dette specielle tilfælde i et andet emne.

1. Vælg **Trin** fra venstremenuen.
1. Klik på **Trigger**-trinnet i flowdiagrammet.
1. I trigger-indstillingerne til højre, klik **Tilføj trigger** og vælg en mulighed.
1. Indtast de krævede indstillinger for den valgte trigger.
1. Specificér valgfrit yderligere kvalifikationskriterier.
1. Vælg valgfrit **En personperson kan kun starte dette flow én gang**. Hvis et flow udløses en anden gang på samme person, sikrer denne indstilling, at de ikke bliver tilmeldt igen.

![Tilføj trigger for nyt flow -screenshot][img5]

| Trigger | Beskrivelse |
|---|---|
| Person oprettet | Når en ny person registreres, uafhængigt af kilden (undtagen import). |
| Person opdateret | Når en person opdateres, uafhængigt af hvad der opdateres (undtagen import og masseopdatering). |
| Salg oprettet | Når et salg registreres på personen. |
| Salg solgt | Når et salg på personen sættes til solgt. |
| Salg tabt | Når et salg på personen sættes til tabt. |
| Tilføjet til projekt | Når person tilføjes som projektmedlem. |
| Sag oprettet | Når en sag oprettes på personen (uafhængigt af kilden). |
| Formular indsendt | Når en formular (indsendt af en person) **behandles** (et manuelt trin kunne være involveret, før personen ender i flowet). |
| Link klikket | Når en person klikker på et sporet link. |

**Bemærk:**

* Hvis du vælger *formular indsendt* eller *link klikket*, skal du være opmærksom på eventuelle advarselsikoner. Formularer og sporede links kan også have tilknyttede handlinger.
* For at inkludere personer, der er oprettet eller opdateret ved import, skal du manuelt tilføje importerede personer fra et udvalg til et flow.
* Når trigger på person opdateret, har vi adgang til de aktuelle værdier af personfelter. Vi har dog ikke information om, hvilket felt der blev opdateret eller den tidligere værdi af et felt før opdateringen.

### Tilføj personfilter (valgfrit)

**Filtre** er yderligere regler, der anvendes på alle foreslåede deltagere (automatisk og manuelt tilføjet). Brug personfilteret til at vælge specifikke personer til dit flow. For eksempel, indstil filteret til *kategori = prospect* for kun at tillade prospekter i flowet, ikke eksisterende kunder, der udfylder en formular på din hjemmeside. Dette giver dig mulighed for at skræddersy indhold til forskellige brugergrupper.

> [!NOTE]
> Filtre gælder kun, når **nye flow-deltagere identificeres**. Eventuelle ændringer af filteret efterfølgende påvirker ikke allerede tilmeldte deltagere.

1. Vælg det personfelt, du vil filtrere på.
2. [Vælg værdier for kriteriet][13] i de forskellige felter på linjen (ligesom i Find-skærmen).
3. Klik på **Tilføj** for at angive yderligere kriterier (tilføjer en ny linje).

![Tilføj personfilter på trigger for nyt flow -screenshot][img6]

### Udelukkelsesliste (valgfrit)

Udelukkelseslisten **forhindrer udvalgte personer i at blive tilføjet til flowet**. Brug et [statisk udvalg][14] til at håndtere undtagelser, såsom:

* Forhindre specifikke kunder i at modtage generelle masse-e-mails.
* Send påmindelser, men ikke til dem, der allerede er tilmeldt.

## <a id="add-step"></a>Tilføj trin

1. Vælg **Trin** fra venstremenuen.
1. Vælg et trin og træk det til, hvor du ønsker at tilføje det i flowdiagrammet.
1. Trinmenuen ændres til **trindstillinger**. [Tilgængelige indstillinger][9] afhænger af trinnets type.

    * [Send besked][3]
    * Flowkontrol
    * [Opdater deltager][4]
    * [Opret aktivitet][5]
    * [Interne handlinger][10]

Klik på X i trindstillingernes overskrift for at vende tilbage til trinmenuen.

### Det første trin

Når du åbner fanen **Trin** for første gang, vil du se noget som dette:

![Flow-trin -screenshot][img4]

* Et flowdiagram med en **Trigger**, en **pladsholder** til at tilføje et trin og et **Afslut**-trin (i midten).
* En liste over tilgængelige trin-typer (til højre).

## <a id="wait"></a>Flowkontrol

De fleste trin i et flow repræsenterer handlinger relateret til deltageren, såsom opdatering af personinteresser. Flowkontrol-trin er dog forskellige; de involverer **timing** og **segmentering**.

Uden flowkontrol ville individer gå fra en handling til en anden, indtil de enten falder fra eller når slutningen af flowet. For eksempel kunne de modtage hele onboarding-programmet på en enkelt dag eller modtage alle nyhedsbreve samtidig.

Desuden ville uden flowkontrol alle tilmeldte følge den samme rækkefølge af trin. Mens dette måske er passende for et simpelt flow, kan du ved at sætte betingelser for efterfølgende handlinger f.eks. sende et nyhedsbrev på personens foretrukne sprog eller sende en feedback-undersøgelse kun til dem, der deltog i webinaret.

**Muligheder:**

* Ventetid
* Vent på handling
* [Del][1]

> [!NOTE]
> Deltagerne markeres med et **vent indtil** tidsstempel, når de når et ventetrin. Hvis det næste trin er en e-mail eller SMS, og en begrænset tidsramme er specificeret i e-mail-indstillingerne, kan den samlede ventetid overstige, hvad der er indstillet i trinnet.

### Ventetid

Brug et tidsbaseret ventetrin til at vente et bestemt antal dage, før du sender den næste e-mail/SMS, eller vent indtil en bestemt dato for specifikke begivenheder eller handlinger. For eksempel at sende påmindelser 1 uge, 1 dag og 1 time før et webinar.

1. Træk **Ventetid**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.
1. Indstil betingelsen. Gør en af følgende:

    * Vælg **Antal dage/timer efter forrige trin** og vælg derefter antal og enhed.
    * Eller vælg **Indtil specifik dato/ specifikt klokkeslæt** og vælg en dato fra kalenderen.

Aktive flowdeltagere forbliver i dette trin, før de går videre til næste trin i henhold til den definerede regel.

![Flow-trin ventetid -screenshot][img7]

### Vent på handling

Brug et handlingsbaseret ventetrin til at vente på, at deltageren gør noget (indsender en formular eller klikker på et link).

1. Træk **Vent på handling**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.

2. Klik på **Tilføj handling** og vælg hvilken handling, der skal ventes på.

3. Vælg fra listen navnet på linket eller formularen, der skal ventes på.

4. Specificér, hvor længe du er villig til at vente på en handling (en timeout). Den maksimale ventetid er som standard 7 dage. Hvis du fjerner markeringen af denne indstilling, vil deltagere, der ikke reagerer, blive stoppet ved dette trin på ubestemt tid.

5. Vælg valgfrit **Afslut flow, hvis der ikke foretages handlinger inden for maksimal ventetid**. Deltagere, der ikke reagerer, vil forlade flowet med status *frafald*. Du kan vælge at flytte dem til et andet flow og/eller tilføje dem til et statisk udvalg.

![Flow-trin vent på handling -screenshot][img8]

> [!TIP]
> Du kan vente på mere end én handling inden for et enkelt trin. Den først-forekommende handling (formularindsendelse, linkklik eller timeout) flytter deltageren videre i flowet. Gentag blot trin 2 og 3 ovenfor.

## Hvad sker der nu?

Efter at have designet et flow og gemt det, lukkes **Floweditoen**, og flowdiagrammet vises på skærmen **Vis flow**. Det nye flow har status **Ikke i gang**, indtil en flow-administrator manuelt starter det ved at skifte I gang = sandt.

## Relateret indhold

* [Flyt, dupliker eller fjern trin][2]
* [Definer flow-handlinger][3]
* [Opdel flow][1]
* [Start flow][6]

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

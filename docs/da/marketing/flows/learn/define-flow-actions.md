---
uid: help-da-flow-actions
title: Definér flow-handlinger
description: Definér flow-handlinger
keywords: Marketing, flow, flow-handlinger
author: Bergfrid Dias, Trude Lien Smedbråten
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Definér flow-handlinger

## Tilgængelige handlinger

* [Send besked](#send)
* [Opdater deltager](#update)
* [Opret aktivitet](#create)
* [Interne handlinger](#internal)

> [!NOTE]
> Når du tilføjer eller opdaterer flow-handlinger, skal du huske, at formularer og sporede links også har handlinger. Sørg for, at der ikke er nogen dublerede eller modstridende handlinger. Vi anbefaler, at du inkluderer alle handlinger ét sted, enten i formularen eller i flowet.

## <a id="send"></a>Send besked

Overvejelser:

* Hvor ofte skal vi sende ny information?
* Skal den næste e-mail være baseret på personengagement, når en person udfylder en formular eller klikker på et sporet link?
* Skal alle personer få det samme indhold?

### Send e-mail (udsendelse)

Et e-mail-trin bruges til at sende en e-mail til en aktiv flowdeltager. Du kan vælge en allerede forberedt e-mail eller tilføje en ny.

1. Træk **Send e-mail**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.

    > [!NOTE]
    > Når du tilføjer et e-mail-trin, skal du angive e-mailindstillinger, før du starter flowet. Du vil se et advarselsikon (som på skærmbilledet nedenfor), hvis disse indstillinger mangler. Du kan stadig gemme flowet! Fortsæt blot med at designe flowet og vend tilbage til e-mailindstillingerne senere.

1. Vælg en af følgende muligheder:

    * Opret ny e-mail til dette trin. Indtast et navn og klik **Ny*. Dette åbner udsendelsesguiden på **Skabelon**-trinnet.
    * Vælg eksisterende e-mail til dette trin. Klik for at vælge flowindhold.

1. Indtast e-mailens **emnelinje**. Personvariabler (merge tags) er tilgængelige.

1. Tilføj valgfrit en eller flere vedhæftede filer (maks. 25MB i alt).

![Tilføj e-mail-trin til flow -screenshot][img1]

> [!NOTE]
> Oprettelse af en ny e-mail som flowindhold er kun mulig fra flow-UI.

### Send SMS

Et SMS-trin bruges til at sende en SMS til en aktiv flowdeltager.

Flowdeltagere uden et registreret telefonnummer kan enten springe trinnet over (fortsætte til næste trin) eller afslutte flowet, afhængigt af trinindstillingerne.

1. Træk **Send SMS**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.

1. Indtast afsenderen og SMS-teksten. Personvariabler (merge tags) er tilgængelige.

1. Vælg valgfrit **Afslut flow, hvis intet mobiltelefonnummer er registreret**, og vælg, hvordan du vil håndtere personer, der ikke kan modtage SMS'en.

> [!TIP]
> Hvis du kun ønsker at sende én SMS, skal du holde øje med tælleren i nederste højre hjørne. Hvis antallet af tegn overstiger 160, sendes beskeden som flere SMS-segmenter, og yderligere omkostninger kan gælde. Vi anbefaler at holde beskeden kort og informativ.

## <a id="update"></a>Opdater deltager

* Opdater person
* Tilføj til udvalg/projekt
* Fjern fra udvalg/projekt

### Opdater person

Brug dette trin til at opdatere relevante data om en person eller deres firma, før deltageren flyttes til næste trin i flowet.

1. Træk **Opdater person**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.
1. Vælg et felt til opdatering i **Felt**-kolonnen. Du kan også skrive navnet i feltet. Mens du skriver hvert bogstav, viser listen nedenfor relevante matches.
1. Vælg en handling i **Handling**-kolonnen. De [tilgængelige handlinger][11] afhænger af typen af felt, du valgte i det forrige trin.
1. Angiv nye værdier, hvis relevant.
1. For at opdatere yderligere felter, klik **Tilføj** og gentag trin 2-4.
1. Sørg for, at alle de felter, du ønsker at opdatere - og kun dem - har et flueben. Du kan klikke på det røde X for at fjerne overflødige linjer.

![Opdater persondata i flow -screenshot][img2]

Dette fungerer på samme måde som [masseopdatering][11].

### Tilføj til udvalg/projekt

Hold overblik over dem, der tilmeldte sig, eller var engageret, eller for at holde styr på og følge op på senere. Personen tilføjes som medlem til det specificerede udvalg og/eller projekt.

1. Træk **Tilføj til udvalg og/eller projekt**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.
1. Tilføj person til statisk udvalg: Vælg et statisk personudvalg fra listen, eller klik **Ny** for at oprette et nyt.

1. Tilføj person som projektmedlem: Vælg et projekt fra listen.

> [!TIP]
> Begynd at skrive for at søge på en liste.

### Fjern fra udvalg/projekt

Personen fjernes som medlem fra det specificerede udvalg og/eller projekt.

Dette trin ligner **Tilføj til udvalg og/eller projekt**.

## <a id="create"></a>Opret aktivitet

Flowet kan automatisk oprette en opfølgning, sag og/eller salg på personen i henhold til indstillingerne. Ved at forbinde CRM-aktiviteter og meddelelser kan din organisation bygge bro mellem marketing og salg. Oprettelse af aktiviteter giver dig også mulighed for at fokusere på personer, der er engagerede.

### Opret opfølgning

Eksempel: Opret en gratis konsultation på den første ledige tid i vores kontakt's dagbog. De vil blive underrettet i **Meddelelser**-panelet.

1. Træk **Opret opfølgning**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.
1. Indtast en titel.
1. Vælg en opfølgningstype.
1. Angiv en forfaldsdato for en to-do eller reserver den første ledige tid til et møde.
1. Tildel til: vælg, hvem der skal følge op på deltageren: "vores kontakt" eller "vores servicekontakt" eller en specifik navngiven medarbejder.
1. Angiv valgfrit andre oplysninger. For detaljer, se [listen over trinindstillinger][1] og [hvordan man opretter en opfølgning][12].

### Opret sag

1. Træk **Opret sag**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.
1. Indtast en beskrivende **titel**.
1. Vælg en [sagstype][14], som vil påvirke standardværdier og tilgængelige statusser og prioriteter.
1. Vælg [status][15], [kategori][16], og [prioritet][17].
1. **Ejer:**
    * For at tildele sagen til en bestemt person, vælg det ønskede navn.
    * **Automatisk tildelt:** Hvis du vælger denne mulighed, tildeler systemet sagen i overensstemmelse med de gældende tildelingsregler.
    * **Ikke tildelt:** Du kan også vælge ikke at tildele sagen. Medlemmerne af den relevante kategori bliver derefter ansvarlige for at håndtere sagen.
1. Indtast den faktiske besked, du vil tilføje til sagen.

For detaljer, se [listen over trinindstillinger][1] og [hvordan man opretter en sag][13].

### Opret salg

Når personen når dette trin, er personen moden og har vist tegn på at være en salgsmulighed.

1. Træk **Opret salg**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.
1. Indtast en beskrivende **titel**.
1. Vælg en salgstype, som vil påvirke standardværdier og tilgængelige stadier.
1. Indtast de krævede oplysninger i de andre felter.
1. Ejer: Vælg, hvem der skal følge op på denne lead: "vores kontakt" eller "vores servicekontakt" eller en specifik navngiven medarbejder.

    > [!NOTE]
    > Tilføj også en opfølgning for at underrette salgets ejer om denne nye mulighed.

For detaljer, se [listen over trinindstillinger][1] og [hvordan man opretter et salg][18].

## <a id="internal"></a>Interne handlinger

### Kør script

Kør brugerdefineret forretningslogik ved at udløse et CRM-script som en del af flowet.

1. Træk **Kør script**-boksen fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.
1. Vælg et [CRMScript][20] fra listen.

> [!NOTE]
> Deltageren vil fortsætte til næste trin umiddelbart efter scriptet udløses, uden at vente på resultatet.

### Giv besked via e-mail

Send en underretnings-e-mail til en bestemt person som en del af flowet.

1. Træk boksen **Giv besked via e-mail** fra trinmenuen og slip den i en tilgængelig slot i flowdiagrammet.
1. Angiv modtageren (**Til:**).
1. Indtast **overskriften** for e-mailen.
1. Indtast den besked, du ønsker at sende.

Personvariabler (merge tags) er tilgængelige.

### Giv besked via SMS

Send en underretnings-SMS til en bestemt person som en del af flowet.

1. Træk boksen **Giv besked via SMS** fra trinmenuen, og slip den i en tilgængelig slot i flowdiagrammet.
2. Angiv modtageren (**Til:**).
3. Indtast den besked, du ønsker at sende. Personvariabler (merge tags) er tilgængelige.

Hvis der ikke er angivet et mobiltelefonnummer på de valgte personer, modtages ingen SMS i den anden ende.

## Flowhandling vs. formularhandling

Flere handlingstyper er mulige både som formularhandling og som flowtrin.

En [formularhandling][6] kan:

* Tilføje person til udvalg og/eller projekt
* Tilføje interesse til person
* Indstille standardkategori og forretning for nye personer og firmaer
* Oprette en sag
* Sende en formularsvar-udsendelse til person

## Flowhandling vs. linkhandling

En [linkhandling][7] kan:

* Tilføje person til udvalg og/eller projekt
* Opdatere interesser
* Tilføje en værdi til et [ekstrafelt][19] på person
* Oprette en sag
* Oprette en opfølgning

<!-- Referenced links -->
[1]: step-settings.md
[6]: ../../forms/learn/define-form-actions.md
[7]: ../../tracked-links/learn/define-link-actions.md
[11]: ../../../learn/basics/bulk-update.md
[12]: ../../../diary/learn/create-follow-up.md
[13]: ../../../request/learn/create.md
[14]: ../../../request/admin/type/index.md
[15]: ../../../request/admin/status/index.md
[16]: ../../../request/admin/category/index.md
[17]: ../../../request/admin/priority/index.md
[18]: ../../../sale/learn/create.md
[19]: ../../../custom-objects/learn/extra-field.md
[20]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-send-email-new.png
[img2]: ../../../../media/loc/en/marketing/flow-update-contact.png

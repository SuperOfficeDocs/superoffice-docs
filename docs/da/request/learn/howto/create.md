---
uid: help-da-request-create
title: Opret en sag
description: Opret en sag
author: Hanne Gunnarsson
date: 03.11.2025
version: 10.5.3
keywords: sag
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Opret en sag

En sag kan komme ind i systemet via en e-mail-meddelelse fra kunden, eller du kan registrere den manuelt via skærmbilledet **Ny sag**. Det kan være aktuelt, hvis en kunde kommer med en henvendelse via telefon.

## Workflow

1. Vælg **Ny** > **Sag**.

    Alternativt, hvis du er i detaljekortet **Sager** for en kontakt, kan du klikke på **Tilføj** for at oprette en sag med personen forudfyldt.

1. I feltet **Titel** skal du angive et beskrivende navn på sagen.

1. Tilføj en person i feltet **Søg efter person** (hvis ikke forudfyldt).
   Vil du ikke tilføje en person? Du kan oprette en billet uden at tilføje en person og tilføje disse informationer senere, hvis du har travlt.

1. Når du opretter en ny sag, har feltet **Til** følgende formål:

    * Som standard vil den eller de personer, der er angivet her, også være person/personer for den nye sag.
    * Hvis du indtaster mere end én person, er den første person primær person for sagen. Du kan klikke på og trække i personerne for at ændre rækkefølgen.

    I feltet **Person** (Søg efter person) skal du begynde at skrive personens navn (eller telefonnummer). På listen over søgeresultater skal du bruge pil op/pil ned på tastaturet til at vælge en person og trykke på **ENTER**. Eller brug musemarkøren til at vælge personen.

    Du kan også angive en e-mail-adresse, hvis du vil tilføje en modtager uden at registrere vedkommende i systemet. I dette tilfælde tilføjes vedkommende ikke som kontaktperson for sagen.

    > [!NOTE]
    > Du kan lade dette felt være tomt, hvis du ikke vil sende meddelelsen til nogen.

1. Valgfrit: Klik på knappen **Cc/Bcc** yderst til højre for at tilføje personer i Cc eller Bcc.

1. Gå til panelet **Egenskaber** i højre side af skærmen, og indtast oplysninger for at tildele og prioritere anmodningen korrekt.

    * I rullemenuen **Sagstype**, skal du vælge type, som vil påvirke standardverdier og tilgjengelige statusser og prioriteter.

    * I rullemenuen **Status** skal du vælge en af følgende valgmuligheder:
      * **Aktiv**: Vælg denne, hvis sagen er under behandling.
      * **Afsluttet**: Vælg denne valgmulighed, hvis sagen er fuldført.
      * **Udsat**: Hvis der er behov for at udsætte sagsbehandlingen, markerer du denne valgmulighed og angiver dato og tid i feltet **Angivet** eller en forudindstillet tid fra listen nedenunder. På denne dato og klokkeslæt sættes sagen til **Aktiv** igen.

    * I feltet **Ejer** skal du vælge én blandt følgende valgmuligheder:
      * Hvis du vil tildele sagen til en bestemt person, vælger du det ønskede navn. Vælg dit eget navn for at tildele billetten til dig selv.
      * **(Automatisk tildelt)**: Hvis du vælger denne valgmulighed, fordeler systemet sagen efter de gældende fordelingsregler.
      * **(Ufordelt)**: Du kan også vælge ikke at tildele sagen. I så fald bliver medlemmerne af den aktuelle kategori ansvarlige for at behandle sagen.

    * I feltet **Kategori** skal du vælge den ønskede kategori på den liste, der vises.

    * I rullemenuen **Prioritet** kan du vælge mellem **Lav**, **Middel** og **Høj**, eller du kan angive, at systemet skal tildele prioritet automatisk. Det kan f.eks. gøres på grundlag af [eskaleringsniveauer][3], der er angivet for forskellige personer og firmaer.

    * I rullemenuen **Adgangsniveau for sag** kan du vælge blandt følgende valgmuligheder:
      * **Eksternt**: Vælg denne valgmulighed, hvis personen skal have adgang til sagen via SuperOffice Kundecenter.
      * **Intern**: Vælg denne indstilling, hvis personen ikke skal have adgang til sagen. Sagen vises i SuperOffice Kundecenter, men personen kan ikke se sagsdetaljerne eller meddelelserne.

    * Gå til rullemenuen **Tags**, og [vælg de relevante tags][4] til denne sag.

    ![Request properties sidebar -screenshot][img7]

1. På fanen **Meddelelser** skal du indtaste selve den [meddelelse](#message), du vil tilføje i sagen.

1. Klik på **Send** for at sende og gemme sagen.

## <a id="message"></a>Meddelelse

> [!NOTE]
> Hvis du vil sende meddelelsen til en person, skal du tilføje modtagere i feltet **Til** over fanerne. Hvis du vil gøre meddelelsen tilgængelig for personen via SuperOffice kundecenter, skal du angive adgangsniveauet (for meddelelsen) til **Ekstern**.

Her kan du skrive selve den meddelelse, du vil tilføje i sagen. Dette fungerer på samme måde, som når du indtaster tekst i et tekstbehandlingsprogram. Du kan også føje vedhæftede filer, [svarskabeloner][2] og ofte stillede spørgsmål til meddelelsen.

Nederst i hvert skærmbillede finder du desuden følgende valgmuligheder:

* ![ikon][img1] – Klik her for at vise eller skjule værktøjslinjen i meddelelseseditoren
* ![ikon][img2] – Klik her for at få vist indstillinger for vedhæftede filer. Her kan du tilføje et eller flere relevante dokumenter som vedhæftninger i sagen.
  * Klik på **Upload filer (eller træk her)** for at gennemse og tilføje en fil fra en disk eller en server.
  * Træk og slip en fil fra Windows Stifinder til vedhæftningsfeltet.
  * Klik på **Vælg et CRM-dokument** for at vælge et dokument i SuperOffice CRM.
* **Indsæt**: Klik på listeknappen ![ikon][img3], og vælg, hvad der skal indsættes i meddelelsen. Du kan tilføje en svarskabelon, en FAQ-post, en tidligere meddelelse eller en vedhæftet fil. Valgfrit: Du kan også [tilføje svarskabeloner på andre sprog][7]. Vælg et sprog på sproglisten. Hvis teksten er tilgængelig, indsættes den på det valgte sprog. I modsat fald anvendes standardsproget.
* **Intern/ekstern**: Her kan du vælge **Ekstern**, hvis personen skal have adgang til meddelelsen via SuperOffice Customer Service, eller **Intern**, hvis personen ikke skal have adgang til meddelelsen.
* **Forløbet tid**: Her kan du registrere, hvor meget tid der er brugt på behandling af meddelelsen. Uret starter automatisk, når du opretter sagen. Du kan stoppe uret ved at klikke på stopknappen ![ikon][img4], og du kan også genstarte uret ved at klikke på startknappen ![ikon][img5]. Klik på knappen ![ikon][img6] (**Vælg tidsperiode**) for at registrere den forløbne tid.

> [!NOTE]
> Standardanmodningssignaturen føjes til meddelelsen. Du kan redigere signaturen direkte i meddelelsen eller redigere din [standardmailsignatur][1].

## <a id="details"></a>Detaljer

Fanen **Detaljer** indeholder yderligere informationer om sagen. Her finder du informationer som, hvornår sagen blev oprettet, hvornår den sidst blev ændret, lukket eller besvaret, hvornår den blev læst af ejeren eller personen og ekstra felter. Disse informationer opdateres automatisk i sagens levetid, men der er nogle felter, der kan redigeres, når sagen oprettes:

* **Relation**: Her kan du vælge at knytte sagen til en anden sagen, hvis den nye sag er relateret til en anden eksisterende.
* **Adgangsniveau**: Dette er en anden måde at indstille adgangsniveauet for sagen på. Dette kan også gøres på panelet **Egenskaber**. Hvis du ændrer adgangsniveauet her, ændres det også automatisk i panelet **Egenskaber**.
* **Salg**: Her kan du linke anmodningen til et eksisterende salg ved at søge efter det ønskede salg eller vælge det fra listen.
* **Projekt**: Her kan du linke sagen til et eksisterende salg ved at søge efter det ønskede salg eller vælge det fra listen.

## Automatisk gemning

Når du arbejder på en sag og pludselig modtager en mere presserende sag, skal du forlade den sag, du arbejder på, for at løse den prioriterede sag.

Funktionen til automatisk gemning gemmer automatisk ændringerne, indtil du klikker på **Send** for at sende eller annullere ændringerne af sagen.
Automatisk gemte oplysninger placeres i den lokale lagring i din browser, så dine data vil også overleve et browsernedbrud, genstart, logaf og logon.

Funktionen til automatisk gemning aktiveres som standard, når du får vist og redigerer sager og svar/svar alle.

### Begrænsninger

* Automatisk gemte data overføres ikke fra én computer til en anden. Det betyder, at du ikke kan begynde at svare på en sag på arbejdet og derefter fortsætte derhjemme.
* Automatisk gemte data deles ikke mellem to forskellige browsere.
* Funktionen til automatisk gemning er en nyttig funktion, men bør ikke erstatte gemning af dit arbejde på den rigtige måde.

## Detaljer

Denne fane indeholder eventuelle ekstrafelter, der er defineret for sager. Dette varierer fra virksomhed til virksomhed.

## Hvad vil du foretage dig nu?

* [Rediger meddelelse][5]
* [Behandling af sager][8]
* [Rediger e-mail-signatur][1]
* [Eskaleringsniveauer][3]
* [Brug af tags i sager][4]
* [Tilføjelse af svarskabeloner i meddelelser][2]
* [Skabelonvariabler][11]
* [Opret svarskabelon][9]
* [Oprettelse af ny sprogversion af svarskabelon][7]

<!-- Referenced links -->
[1]: ../../../learn/getting-started/edit-email-signature.md
[2]: reply.md#reply-templ
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: edit-message.md
[7]: ../../reply-templates/learn/new-language.md
[8]: ../index.md
[9]: ../../reply-templates/learn/index.md
[11]: ../../reply-templates/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/format-font.png
[img2]: ../../../../../common/icons/attachments-theme.png
[img3]: ../../../../../common/icons/copy-paste-icon.png
[img4]: ../../../../../common/icons/stop.png
[img5]: ../../../../../common/icons/play.png
[img6]: ../../../../../common/icons/timespan.png
[img7]: ../../../../media/loc/en/request/requests-select-request-types.png

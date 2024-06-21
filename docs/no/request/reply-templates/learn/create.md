---
uid: help-no-reply-template-create
title: Opprette svarmaler
description: "Lær hvordan du oppretter en svarmal, i denne veiledningen."
author: Bergfrid Dias
date: 03.16.2023
keywords: sak, svare, mal
topic: howto
audience: user
audience_tooltip: SuperOffice Service
language: no
---

# Opprette svarmal

En svarmal er en ferdig tekst som kan limes inn i en melding du skriver til en person. Bruk av svarmaler sparer tid og lar deg sende personlige meldinger til personene dine.

Svarmaler kan også inneholde vedlegg, som da blir lagt til i meldingen. Før du sender svaret til personen, kan du både redigere teksten og fjerne eller legge til vedlegg.

> [!NOTE]
> Du trenger *Kunnskapsbase* som funksjonell rettighet for å opprette svarmaler.

## Trinn

1. Gå til ![ikon][img1] **Hovedmeny** i toppraden, og velg **Kunnskapsbase** > **Svarmaler**.

1. Gå til mappen du vil plassere svarmalen i. Hvis den ikke finnes ennå, kan du [opprette en ny mappe][2].

    ![Slik finner du svarmaler i SuperOffice -screenshot][img3]

1. Klikk på **Ny svarmal**-knappen.

1. Øverst i fanen **Egenskaper** i bildet **Egenskaper for svarmal** skriver du inn følgende:

    * **Navn**: Et beskrivende navn på svarmalen.
    * **Beskrivelse**: En kort beskrivelse av hva svarmalen inneholder.
    * **Mappe**: Som standard navnet på den valgte mappen. Du kan velge en annen mappe her.
    * **Tilgang**: Her velger du hvem som skal ha tilgang til å lese og endre den aktuelle svarmalen.

1. Velg fanen **(Uspesifisert språk)**.

1. I fanen **Egenskaper** angir du følgende informasjon:
    * **Språk**: I denne listen velger du hvilket språk svarmalen er på. Listeboksen inneholder de språkene som er registrert under ![ikon][img2] > **Kundespråk**.
    * **Standard**: Merk av her hvis du vil at dette språket skal være standardspråk for denne svarmalen.
    * **Emne**: Her skriver du inn svarmalens tittel. Vanligvis settes denne inn i **Emne**-feltet når svarmalen brukes som e-postmelding.
    * **Meldingshode**: Her kan du legge til forhåndsdefinert innhold som skal vises i meldingshodet i en e-postmelding, for eksempel i **Til**- og **Emne**-feltet. Denne funksjonen brukes bare i spesielle tilfeller.

1. I fanen **Vanlig tekst** angir du følgende informasjon:

    * **Inkluder ren tekst**: Når du oppretter en HTML-versjon, er det alltid lurt å opprette en ren tekstversjon i tillegg for e-postprogrammer som ikke støtter HTML. E-postprogrammet velger deretter automatisk riktig format. Hvis du ikke merker av for dette alternativet, ignoreres teksten nedenfor. Den lagres imidlertid, slik at du kan velge å inkludere den senere.

    > [!NOTE]
    > Hvis du inkluderer både ren tekst og HTML-tekst, velger e-postprogrammet den "beste" utgaven, og det vil vanligvis være HTML. Husk at meldinger som blir sendt uten ren tekst, bare kan leses av e-postprogrammer som støtter HTML.

    * I det store feltet midt i bildet skriver du inn selve innholdet i svarmalen. Det er alltid denne teksten som brukes når du [legger til svarmaler i meldinger][4].
    * **Stavekontroll**: Starter en stavekontroll av meldingen på språket som er angitt i listen **Språk**.

1. I fanen **HTML-tekst** angir du følgende informasjon:

    * **Inkluder HTML-tekst**: Merk av for dette alternativet for å inkludere teksten nedenfor i en HTML-versjon av e-postmeldingen. Dette brukes overfor kunder med e-postprogrammer som kan lese HTML (for eksempel Outlook). Budskapet kommer ofte tydeligere frem hvis du sender meldingen som HTML, fordi du kan bruke bilder og farger i teksten.
    * I det store feltet midt i bildet skriver du inn HTML-formatert tekst som du vil inkludere i meldingen til personen. Husk at bilder som det henvises til her, må ligge på en server som er tilgjengelig for mottakerne av e-postmeldingen. Du kan for eksempel legge til bilder som tidligere har vært lastet opp til **Eksterne dokumenter**.

1. I fanen **SMS-tekst** kan du legge til svarmalstekst som er beregnet på sending via SMS. Her angir du følgende informasjon:

    * **SMS-tekst**: I dette feltet skriver du inn selve svarmalsteksten.
    * **Antall tegn**: Her kan du følge med på hvor mange tegn du har skrevet inn.

1. I fanen **Vedlegg** kan du legge til vedlegg du vil inkludere i svarmalen:

    1. Klikk på **Velg filer**.
    2. I dialogboksen blar du til dokumentet du trenger.
    3. Klikk på **Legg til** for å legge til vedlegget.
    4. Gjenta denne fremgangsmåten hvis du vil legge til flere vedlegg.

    > [!TIP]
    > Du kan slette et vedlegg ved å klikke på **Slett** til høyre for raden.

1. Klikk på **OK** for å lagre svarmalen. Fanen **(Uspesifisert språk)** endres til det valgte språket. Klikk på **Tilbake** for å gå tilbake til mappestrukturen for svarmaler. Den er nå tilgjengelig for bruk i [svar på henvendelser fra kunder][4].

## Opprette egendefinert layout for svar ved hjelp av kategorier

Hvis du vil gi hver avdeling i firmaet en egendefinert layout til korrespondansen, kan du opprette svarmaler med forskjellige layouter. Hver svarmal kan knyttes til en [kategori][1] som representerer en avdeling. Alle utgående svar fra kategoriene (avdelingene) slås sammen med det avdelingsspesifikke designet.

Bortsett fra layouten/formateringen til svarmalen, må den inneholde følgende malvariabler for å kunne slås sammen med svaret:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
[[ELSE]]
[[message.body]]
[[ENDIF]]
```

## <a id="faq" />Automatisk FAQ-svar

SuperOffice Service leveres med et sett med svarmaler. Blant disse svarmalene finner du "Eksempel på automatisk FAQ-svar". Denne svarmalen inneholder et eksempel på automatisering av svar til kunden, i fanen **HTML-tekst**.

Med utgangspunkt i kundens henvendelse søker systemet etter tilsvarende ord (inkludert nøkkelord) i FAQ-oppføringer i SuperOffice Service. Basert på graden av samsvar mellom disse settes det inn forslag til FAQ-er som kan hjelpe kunden, i svarmalen som automatisk sendes til kunden for å bekrefte mottak av saken.

Du kan selv velge graden av samsvar mellom saken fra kunden og FAQ-oppføringene i feltet **Minimumsscore for FAQ-søkeresultat (i prosent)** i ![ikon][img2] **Systeminnstillinger** > **System** > **Innstillinger**.

## Hva vil du gjøre nå?

* [Opprette ny språkversjon av svarmal][5]
* [Rediger svarmaler][6]
* [Kopiere svarmaler][7]

<!-- Referenced links -->
[1]: ../../learn/category/index.md
[2]: manage-folders.md
[4]: ../../learn/howto/reply.md
[5]: new-language.md
[6]: edit.md
[7]: copy.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/main-menu.png
[img2]: ../../../../media/icons/main-menu-small.png
[img3]: ../../../../media/loc/en/request/create-a-new-reply-template.png

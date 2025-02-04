---
uid: help-no-reply-template-create
title: Opprette svarmaler
description: Lær hvordan du oppretter en svarmal i denne veiledningen.
keywords: opprett svarmal, ny svarmal, kopier svarmal, svarmalegenskaper, kunnskapsbase, sak, svarmal, mal
author: Bergfrid Dias
date: 02.04.2025
version: 10.5.1
topic: howto
license: serviceessentials
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: no
---

# Opprett svarmal

En svarmal er en forhåndsdefinert tekst som kan settes inn i en melding du skriver til en person. Ved å bruke svarmaler sparer du tid og kan sende personlige meldinger til kundene dine.

Svarmaler kan også inneholde vedlegg, som automatisk legges til i meldingen. Før du sender svaret til personen, kan du redigere teksten og legge til eller fjerne vedlegg.

> [!NOTE]
> Du må ha *Kunnskapsbase* som funksjonell rettighet for å kunne opprette svarmaler.

## Trinn – opprett fra bunnen av

1. Gå til <i class="ph ph-list" aria-label="Hovedmeny"></i> i toppraden, og velg **Kunnskapsbase** > **Svarmaler**.

1. Gå til mappen hvor du vil lagre svarmalen. Hvis den ikke finnes, kan du [opprette en ny mappe][2].

1. Klikk på knappen **Ny svarmal**.

1. Øverst på fanen **Egenskaper** i skjermbildet **Svarmalegenskaper**, fyll inn følgende:

    * **Navn**: Et beskrivende navn på svarmalen.
    * **Beskrivelse**: En kort beskrivelse av hva svarmalen inneholder.
    * **Mappe**: Standard er den valgte mappen. Du kan velge en annen mappe her.
    * **Tilgang**: Angi hvem som skal ha leserettigheter og redigeringsrettigheter for svarmalen.

1. Velg fanen **(Uspesifisert språk)**.

1. Under fanen **Egenskaper**, fyll inn følgende:

    * **Språk**: Velg hvilket [kundespråk][7] svarmalen er på.
    * **Standard**: Merk av hvis dette skal være standardspråket for svarmalen.
    * **Emne**: Skriv inn emnet for svarmalen. Dette settes automatisk inn i **Emne**-feltet når svarmalen brukes i en e-post.
    * **Meldingshode**: Legg til forhåndsdefinert innhold som skal vises i meldingshodet, for eksempel **Til**- og **Emne**-feltene i en e-post. Dette brukes kun i spesielle tilfeller.

1. Under fanen **Vanlig tekst**, fyll inn:

    * **Inkluder vanlig tekst**: Når du oppretter en HTML-versjon, er det lurt å også ha en versjon i vanlig tekst for e-postprogrammer som ikke støtter HTML.

    > [!NOTE]
    > Hvis du inkluderer både vanlig tekst og HTML, vil mottakerens e-postprogram velge den "beste" versjonen, som vanligvis er HTML. Hvis du kun sender HTML, kan ikke meldingen leses i e-postprogrammer som ikke støtter HTML.

    * I det store feltet midt på skjermen, skriv inn innholdet i svarmalen. Dette er teksten som brukes når du [legger til svarmaler i meldinger][4].
    * **Stavekontroll**: Kjør en stavekontroll basert på språket som er valgt i **Språk**-feltet.

1. Under fanen **HTML-tekst**, fyll inn:

    * **Inkluder HTML-tekst**: Merk av for dette alternativet hvis du vil at svarmalen skal inkludere HTML-formatering.
    * I det store tekstfeltet midt på skjermen, skriv inn HTML-formatert tekst som skal vises i meldingen.

1. Under fanen **SMS-tekst**, fyll inn:

    * **SMS-tekst**: Skriv inn svarmalens innhold for SMS-meldinger.
    * **Antall tegn**: Viser hvor mange tegn som er skrevet.

1. Under fanen **Vedlegg**, kan du legge til vedlegg:

    1. Klikk på **Velg filer**.
    2. Finn filen du vil legge til.
    3. Klikk på **Legg til**.
    4. Gjenta for å legge til flere vedlegg.

    > [!TIP]
    > Du kan fjerne et vedlegg ved å klikke på **Slett** ved siden av filnavnet.

1. Klikk på **OK** for å lagre svarmalen. Fanen **(Uspesifisert språk)** endres til det valgte språket. Klikk på **Tilbake** for å gå tilbake til mappestrukturen for svarmaler. Svarmalen er nå tilgjengelig for bruk i [besvarelse av kundehenvendelser][4].

## <a id="copy"></a>Kopiere svarmal

For å opprette en ny svarmal basert på en eksisterende, kan du kopiere den.

1. Gå til <i class="ph ph-list" aria-label="Hovedmeny"></i> i toppraden, og velg **Kunnskapsbase** > **Svarmaler**.
1. Finn mappen der svarmalen ligger.
1. Klikk på svarmalen for å åpne skjermbildet **Vise svarmaler**.
1. Klikk på **Kopier**. En kopi åpnes i redigeringsmodus.
1. Endre navn og eventuelt andre detaljer.
1. Klikk på **OK** for å lagre.

## Opprett egendefinert layout for svar ved hjelp av kategorier

For å gi hver avdeling et unikt layout på sine svar, kan du knytte svarmaler til en [kategori][1] som representerer avdelingen. Alle utgående svar fra kategorien flettes med det avdelingsspesifikke designet.

I tillegg til layout og formatering, må svarmalen inneholde følgende malvariabler for å flettes riktig med svaret:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
[[ELSE]]
[[message.body]]
[[ENDIF]]
```

## <a id="faq"></a>Automatisk FAQ-svar

SuperOffice Service leveres med et sett med svarmaler. Blant disse svarmalene finner du "Eksempel på automatisk FAQ-svar". Denne svarmalen inneholder et eksempel på automatisering av svar til kunden, i fanen **HTML-tekst**.

Med utgangspunkt i kundens henvendelse søker systemet etter tilsvarende ord (inkludert nøkkelord) i FAQ-oppføringer i SuperOffice Service. Basert på graden av samsvar mellom disse settes det inn forslag til FAQ-er som kan hjelpe kunden, i svarmalen som automatisk sendes til kunden for å bekrefte mottak av saken.

Du kan selv velge graden av samsvar mellom saken fra kunden og FAQ-oppføringene i feltet **Minimumsscore for FAQ-søkeresultat (i prosent)** i <i class="ph ph-list" aria-label="Hovedmeny"></i> **Systeminnstillinger** > **System** > **Innstillinger**.

## Relatert innhold

* [Opprette ny språkversjon av svarmal][5]
* [Rediger svarmaler][6]

<!-- Referenced links -->
[1]: ../../admin/category/index.md
[4]: ../../learn/reply.md
[2]: manage-folders.md
[5]: new-language.md
[6]: edit.md
[7]: ../../../admin/options/learn/custlang/index.md

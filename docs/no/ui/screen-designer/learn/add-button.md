---
uid: help-no-screen-designer-button
title: Legg til en knapp eller kobling
description: Hvordan legge til en knapp eller kobling med Skjermdesigneren i Innstillinger og vedlikehold.
keywords: Skjermdesigner, layout, oppsett, knapp, kobling, etikett, A-Z
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.7
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Legg til en knapp eller kobling

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Tilpassede knapper og koblingr legges til i **Forhåndsvisning**-panelet når du redigerer en layout. Nettadressen brukes til å åpne en nettside i gjeldende eller ny fane, kjøre et CRMScript fra skjermen eller navigere til andre deler av SuperOffice ved hjelp av [SoProtocol][3].

Knapper og koblingr fungerer på lignende måte. Forskjellen er at du kan style en knapp, men ikke en kobling.

> [!TIP]
> Du kan bruke [malvariabler][1] i URL-ene.

Instruksjonene nedenfor antar at du allerede er [i ferd med å redigere layouten][4].

## Legg til en knapp

1. Velg fanen du vil redigere.

1. Velg seksjonen **Elementer**.

1. Klikk og dra elementet **Knapp** til layouten.

1. Klikk for å velge den nye knappen.

1. I **Innstillinger** til venstre, erstatt teksten "Knapp" med det nye knappenavnet.

    ![Skjermdesigner, innstillinger for knappelement -screenshot][img1]

    > [!TIP]
    > Du kan også legge til knappenavnet på andre språk.

1. I listen **Handling** velger du handlingen som skal utføres når du klikker på knappen. Se referanseseksjonen på slutten av denne siden for detaljer om hver handling.

    * Åpne nettside: Velg dette alternativet for å legge til en kobling til en nettside. Velg URL-koding og adresse etter behov.

    * Kjør CRMScript: Velg dette alternativet for å legge til et [CRMScript][2] for å utføre spesifikke handlinger i SuperOffice.

    * Snarvei ([SoProtocol][3]): Velg dette alternativet for å legge til en kontroll som navigerer til et annet område eller skjerm i SuperOffice når den klikkes.

1. I listen **Modus** velger du om knappen alltid skal være tilgjengelig, eller om den kun skal være tilgjengelig i lese- eller redigeringsmodus.

1. I listen **Stil** velger du stilen til knappen.

## <a id="link"></a>Legg til koblingr

1. Velg fanen du vil redigere.

1. Velg seksjonen **Elementer**.

1. Klikk og dra elementet **kobling** til layouten.

1. Klikk for å velge det nye koblingfeltet.

1. I **Innstillinger** til venstre, erstatt teksten "kobling" med det nye koblingnavnet.

    > [!TIP]
    > Du kan også legge til koblingnavnet på andre språk.

1. I listen **Handling**, velg handlingen som skal utføres når du klikker på koblingn. (Samme liste som for knapper.)

1. I **Modus**-listen velger du om koblingn alltid skal være tilgjengelig, eller om den bare skal være tilgjengelig i lese- eller redigeringsmodus.

## Oversettelse av etiketter

Navnet og verktøytipsteksten kan oversettes til andre språk.

Når elementet er valgt:

1. Klikk på <i class="ph ph-translate" aria-label="Translate"></i> ved siden av etiketten.
1. Klikk på **Legg til** og velg et språk fra listen.
1. Skriv inn tekst for det nye språket.

    ![Skjermdesigner, oversett etikett -screenshot][img2]

1. Gjenta trinn 2-3 for flere språk.
1. Klikk på **Lukk** for å avslutte oversettelsesdialogen.

Husk å publisere layouten på nytt.

## Referanse

| Innstilling | Beskrivelse | Kommentar |
|---|---|---|
| Navn | Tekst | Kan oversettes |
| Handling | Hva skjer ved klikk: Åpne nettside, CRMScript, SoProtocol | |
| URL | URL | HTTP-prefiks legges automatisk til. Du må legge til 'https://' selv hvis relevant. |
| Modus | Når elementet vises: Alltid, lesemodus, redigeringsmodus | |
| Verktøytips | Tekst | Kan oversettes |
| Stil | Handling, Normal, Slett, OK, Rediger | Ikke aktuelt for koblingr |

Noen innstillinger avhenger av valgt handling.

### Åpne nettside

* URL-koding: Ingen, ANSI eller Unicode
* Mål: Ny fane eller samme fane

![Skjermdesigner, åpne nettside på knapp -screenshot][img4]

> [!NOTE]
> Det anbefales å spesifisere protokollen, for eksempel `https://www.superoffice.com`; ellers er standarden HTTP.

### Utfør CRMScript

* CRMScript: Velg det spesifikke skriptet som skal kjøres.

![Skjermdesigner, utfør CRMScript på knapp -screenshot][img3]

[Lær mer om CRMScript][2]

### Snarvei (SoProtocol)

* SoProtocol: Navigasjons- og innholdsdelen av URL-en uten prefikset `superoffice:`.

![Skjermdesigner, SoProtocol på knapp -screenshot][img5]

[Lær mer om SoProtocol][3]

<!-- Referenced links -->
[1]: ../../../document/templates/variables/from-company-card.md
[2]: ../../../../en/automation/crmscript/overview/index.md
[3]: ../../../../en/ui/soprotocol/index.md
[4]: edit-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/new-button.png
[img2]: ../../../../media/loc/en/ui/translate-button-label.png
[img3]: ../../../../media/loc/en/ui/button-script.png
[img4]: ../../../../media/loc/en/ui/button-website.png
[img5]: ../../../../media/loc/en/ui/button-soprotocol.png

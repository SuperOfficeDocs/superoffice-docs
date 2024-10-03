---
uid: help-no-screen-designer-edit-layout
title: Rediger layouten til et kort
description: I denne veiledningen lærer du hvordan du redigerer en layout.
keywords: Skjermdesigner, layout, oppsett, format, felt, faneoppsett, hovedkort, kortlayout
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Rediger layouten til et kort

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Når du har [opprettet en ny layout][6], er det tid for tilpasning. Tilpass layouten for hovedkortene og arkivene slik at de dekker informasjonsbehovene i din organisasjon.

## Viktige hensyn

Før du tilpasser en layout, bør du fastsette hvem de tiltenkte brukerne er.

* Hva trenger de lett tilgang til?
* Trenger de alle standardfelter og faner, eller bør du fjerne noe?
* Trenger de flere faner?
* Hva er den logiske rekkefølgen på feltene?

> [!NOTE]
> Du kan redigere **standardlayouten**, men du kan ikke endre standardkontrollinnstillingene og du kan ikke tilordne layouten til en brukergruppe på nytt.

Se denne videoen og finn ut hvordan du bruker skjermdesigneren til å konfigurere skjermbildene i SuperOffice CRM, eller følg trinn-for-trinn-guiden nedenfor (videolengde - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## <a id="edit"></a>Rediger kortlayout

1. Åpne Skjermdesigneren (i **Innstillinger og vedlikehold**).
1. Velg en skjerm eller dialog øverst for å tilpasse.
1. Velg **Hovedkort**.
1. Velg en layout fra listen til venstre.
1. Klikk **Rediger layout** under forhåndsvisningen.
1. I skjermbildet **Rediger kortlayout**, gå gjennom fanene på skjermen.

    * [Legg til, rediger, flytt eller fjern et felt][1]
    * [Legg til kobling eller knapp][2]
    * [Organiser informasjon i logiske grupper][4]
    * [Legg til, fjern eller gjenopprett en fane][3]
    * [Endre antall kolonner i en fane][5]<a id="columns"></a>

![Fjern, legg til og flytt de forskjellige feltene i layouten -screenshot][img3]

## <a id="save"></a>Lagre, publiser eller avbryt

Etter å ha redigert en layout, klikk på en av følgende knapper:

| Knapp | Beskrivelse |
|---|---|
| Lagre utkast | Lagrer en upublisert versjon av layouten, som du kan fortsette å redigere senere eller be noen om å gjennomgå. |
| Lagre + Publiser | Bruker layouten for de valgte brukergruppene **eller** salgs-/prosjekt-/sak-/oppfølgingstype. |
| Avbryt | Forkaster alle endringer. |

## <a id="undo-changes"></a>Angre endringer

Hvis du trenger å gå tilbake til en tidligere versjon av skjermbildet, har du tilgang til følgende alternativer fra **Oppgave**-knappen:

* **Tilbakestill fabrikkinnstillinger**: Dette alternativet forkaster alle endringer og tilbakestiller layouten til standardversjonen levert av SuperOffice.

* **Gjenopprett faner**: Dette alternativet gjenoppretter alle tidligere fjernede faner.

* **Slett utkast**: Dette alternativet forkaster alle ulagrede endringer og tilbakestiller layouten til den sist publiserte versjonen.

## <a id="delete"></a>Slett layout

Når en brukergruppebasert layout slettes, ser brukere i denne gruppen standard (system) layout.

For å slette en layout:

1. Velg layouten fra **Layouter**-listen.
1. Klikk **Slett**.

## Relatert innhold

* [Arbeide med detaljkort (arkiv)][7]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: add-button.md
[3]: working-with-tabs.md
[4]: working-with-tabs.md#label
[5]: working-with-tabs.md#columns
[6]: add-layout.md
[7]: working-with-archives.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/ui/edit-the-screen-layout-of-companies-and-contacts.png

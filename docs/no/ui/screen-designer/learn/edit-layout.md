---
uid: help-no-screen-designer-edit-layout
title: Redigere hovedkortlayout
description: I denne veiledningen lærer du hvordan du redigerer en layout.
author: Bergfrid Dias
so.date: 03.29.2023
keywords: Skjermdesigner, format, felt
so.topic: howto
language: no
---

# Redigere layout – Hovedkort

Når du har [opprettet en ny layout][4], kan du tilpasse den i henhold til behovene til de tilordnede brukergruppene. Hvis du tilpasser en layout for salgsteamet, bør du ha en klar plan for hvilke behov de har med hensyn til layout og formatering av fanene, feltene, elementene og kolonnene i hovedkortet. Hvilken informasjon bør man kunne finne først og enklest? Trenger de alle felt og faner? Hva er den logiske rekkefølgen på feltene?

Tilpass layouten for hovedkortene og arkivene slik at den samsvarer med organisasjonens informasjonsbehov. Når du redigerer layouten på et hovedkort, kan du legge til og fjerne felt, eller omorganisere rekkefølgen slik at den passer til teamets behov. Først må du vite hvilken informasjon som er viktigst for teamet.

Se denne videoen og finn ut hvordan du bruker skjermdesigner til å konfigurere skjermbildene i SuperOffice CRM, eller følg trinn-for-trinn-veiledningen nedenfor (videolengde – 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## Trinn

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->

3. Klikk på **Hovedkort**.

4. Velg en layout i listen til venstre.

5. Klikk på **Rediger layout** under forhåndsvisningen.

6. **Rediger kortlayout** redigerer du layouten som beskrevet nedenfor.

7. Når du er ferdig, klikker du på en av følgende knapper:

    * **Lagre utkast**: Klikk denne knappen hvis layouten ikke er ferdig ennå.
    * **Lagre + Publiser**: Klikk denne knappen for å publisere layouten til de valgte brukergruppene.
    * **Avbryt**: Klikk på denne knappen for å [forkaste alle endringer](#undo-changes).
<!-- markdownlint-restore -->

## Rediger eksisterende felt i layouten

1. Velg fanen du vil redigere.

2. Redigere eksisterende felt:

    * Flytt felt ved å klikke ![ikon][img4] til venstre for en ledetekst og dra feltet til en ny posisjon. Hvis du vil legge til et nytt felt, se [Felt](#fields).

    * Slett felt ved å holde musepekeren over et felt og klikke ![ikon][img2]. Slettede felt kan legges til på nytt fra **Felt**-området. Obligatoriske felt kan ikke slettes, og **Slett**-knappen vises ikke for slike felt. Se [Felt](#fields).

    * Rediger feltformatering (for eksempel skriftformat) og andre innstillinger ved å klikke på feltet. **Innstillinger** -området åpnes i venstre del av vinduet. Se [Innstillinger](#settings).

3. [Endre antall kolonner i en fane](#columns) fra **Kolonner**-delen.

4. Lagre endringene som beskrevet ovenfor.

![Fjern, legg til og flytt de forskjellige feltene i layouten -screenshot][img3]

## Legg til nytt innhold i en layout

1. Velg fanen du vil redigere, eller klikk på ![ikon][img5] **Legg til** for å [legge til en ny fane](#tabs).

2. Rediger layouten ved å velge ett av følgende områder:

    * **Felt**: Dra [felt](#fields) fra listen til layouten. Felt kan plasseres i kolonnene, og i overskriften og bunnteksten.

    * **Elementer**: Dra ulike elementer slik som etiketter, skillelinjer, koblinger og knapper til layouten.

    * **Innstillinger**: Klikk på et felt eller element i layouten for å redigere innstillingene. De tilgjengelige innstillingene kan variere avhengig av det valgte objektet. Se [Innstillinger](#settings).

    * **Kolonner**: [Velg hvor mange kolonner du vil vise i en fane](#columns).

3. Når du har tilpasset skjermlayouten, klikker du en av følgende knapper:

    * **Lagre utkast**: Klikk denne knappen hvis layouten ikke er ferdig ennå.
    * **Lagre + Publiser**: Klikk denne knappen for å publisere layouten til de valgte brukergruppene.
    * **Avbryt**: Klikk på denne knappen for å forkaste alle endringer.

Bokser med prikkede linjer i layouten angir hvor du kan plassere et felt:

![Bokser med stiplede linjer - skjermbilde][img6]

Nedenfor finner du mer detaljerte beskrivelser av de ulike delene og funksjonene.

## <a id="fields" />Felt

I **Felt**-delen finner du alle tilgjengelige datafelt for den valgte skjermlayouten. Bruk filterfunksjonen til å finne bestemte felt.

* Dra et felt fra listen til et prikket område i den valgte fanen.
* Hvis du vil være sikker på at et felt alltid er synlig uansett hvilken kategori som er valgt, plasserer du feltet i overskriften eller bunnteksten.
* Du kan eventuelt plassere det samme feltet flere steder i skjermlayouten.
* Flytt felt ved å klikke ![ikon][img4] til venstre for en ledetekst og dra feltet til en ny posisjon. Hvis du vil flytte et felt til en annen kategori, drar du feltet til faneoverskriften for å åpne fanen, og deretter plasserer du feltet i den åpne fanen.
* Slett felt ved å holde musepekeren over et felt og klikke ![ikon][img2]. Obligatoriske felt kan ikke slettes, og **Slett**-knappen vises ikke for slike felt.

**Begrensninger:**

* Obligatoriske felt kan ikke slettes. Dette defineres i [Felt][3]-bildet.
* Noen faner kan ikke redigeres siden de har bestemte funksjoner, slik som **ERP** og **Merk**.

## Elementer

I **Elementer**-delen kan du legge til ulike ikke-dataelementer slik som etiketter, skillelinjer, koblinger og knapper.

## <a id="settings"/>Innstillinger

Gjør felt mer synlige ved å endre til fet og stor skrift. Gjør plass til flere felt med mindre skrift. Spar skjermplass ved å skjule etiketter.

Klikk på et felt eller element i oppsettet for å redigere innstillingene. Den tilgjengelige innstillingen vil variere avhengig av typen felt eller element.

## <a id="columns"/>Kolonner

En kategori har to kolonner som standard, men du kan bruke alt fra 1–4 kolonner etter behov. Brukere med brede skjermer foretrekker kanskje flere kolonner for å vise og sortere mer data.

**Begrensninger:**

* Hvis du endrer fra 2–4 kolonner til én kolonne, flyttes alle feltene til én kolonne.
* Bruker du fire kolonner, kan påvirke synligheten til enkelte felt. Du kan vurdere å skjule etikettene for enkelte felt (se [Innstillinger](#settings)).
* Noen faner, for eksempel **ERP** og **Merk**, har ikke et kolonneoppsett siden de har bestemte funksjoner.
* Hvis en bruker ikke har en skjermstørrelse som har plass til alle kolonnene, stables de oppå hverandre.

## <a id="tabs" >/Faner

Legg til flere faner for flere felt, eller fjern irrelevante faner.

**Slik fjerner du en fane:**

1. Velg fanen, og klikk på **Oppgave** > **Fjern fane**.
2. Klikk på **OK** i dialogboksen som vises.

**Slik legger du til en ny fane:**

1. Klikk på ![ikon][img5] **Legg til**. **Kolonner**-delen åpnes til venstre.
2. Under **Fanenavn**, erstatter du teksten **Ny fane** med det nye fanenavnet.
3. Du kan også [legge til fanenavnet på andre språk][2] ved å klikke på ![ikon][img1].
4. Velg antall kolonner du vil bruke i den nye fanen.

> [!TIP]
> Hvis du vil gi nytt navn til fanen senere, velger du fanen og deretter **Kolonner**.

**Begrensninger:**

* Du kan ikke gi nytt navn til standardfanene.
* Du kan ikke fjerne en fane som inneholder obligatoriske felt. Obligatoriske felt må først flyttes til en annen fane.
* Hvis bare én fane gjenstår, kan du ikke slette den.

## <a id="undo-changes" />Angre endringer

Hvis du må gå tilbake til en tidligere versjon av skjermbildet, har du tilgang til følgende alternativer fra **Oppgave**-knappen:

* **Tilbakestill fabrikkinnstillinger**: Dette alternativet sletter alle endringer og tilbakestiller skjermlayouten til standardlayoten levert av SuperOffice.
* **Slett utkast**: Sletter alle endringer og tilbakestillinger til den publiserte versjonen av skjermlayouten.

<!-- Referenced links -->
[2]: ../../../globalization-and-localization/learn/translate-fields.md
[3]: ../../../custom-objects/learn/udef/index.md
[4]: add-new-layout.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../../common/icons/delete-circle-red.png
[img4]: ../../../../media/icons/criteria-move.png
[img5]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../media/loc/en/ui/edit-the-screen-layout-of-companies-and-contacts.png
[img6]: ../../../../media/loc/en/ui/screendesigner-field-place.png

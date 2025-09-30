---
uid: help-no-tutorial-document-mailing
title: Opplæring - utsendelse av dokumenter
description: I denne opplæringen lærer du å opprette et dokumentutsendelse.
keywords: dokumentutsendelse
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# Opplæring - utsendelse av dokumenter

[!include[Tips](includes/tip-mailing-save-draft.md)]

## Trinn 1: Oppsett

> [!TIP]
> Hvis du vil vise og skrive ut en eksisterende dokumentutsendelse, avslutter du trinnet **Oppsett** (klikk på **Avbryt** eller **Lagre + lukk**). Velg fanen **Utsendelser**, finn dokumentet, klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>, og velg **Vis**. Klikk på knappen under **Last ned generert dokument**. Dokumentet lastes ned til nettleseren din. Åpne og skriv ut dokumentet.

Ved hjelp av arbeidsflyten for dokumentutsendelse kan du generere et PDF-dokument som skrives ut og sendes til kundene. Det første trinnet når du skal lage en dokumentutsendelse, kalles **Oppsett**. Her kan du angi navnet på utsendelsen, overskriften og hvem utsendelsen er tiltenkt, i dokumentet, samt angi arkiveringsalternativer for utsendelsen.

Du kan knytte dokumentutsendelsen til et bestemt prosjekt. Dette kan være aktuelt hvis du lager utsendelser hvor mottakerne er medlemmer av et SuperOffice CRM-prosjekt. Ved å bruk malvariabler i malen kan du legge til prosjektdata i utsendelsen.

Du kan knytte dokumentutsendelsen til et bestemt salg. Dette kan være aktuelt hvis du oppretter utsendelser hvor mottakerne er interessenter fra et SuperOffice CRM-salg. Ved å bruk malvariabler i malen kan du legge til salgsdata i utsendelsen.

**Trinn:**

1. Skriv inn et navn i feltet **Navn på utsendelse**.

1. I feltet **Overskrift** skriver du inn dokumenttittelen.

1. I feltet **Ved** må du velge hvem utsendelsen skal dirigeres til. Velg ett av følgende alternativer:

    * **Hvis ingen er definert**: Velg dette alternativet hvis du vil bruke mottakernes navn som standard. Hvis ingen mottakernavn blir funnet, bruker du mottakeren du angir i tekstfeltet. Hvis du lager en utsendelse rettet mot IT-medarbeidere i et firma, kan du skrive inn "IT-avdeling" eller lignende.

    * **Bruk alltid**: Velg dette alternativet hvis du vil overstyre mottakernes navn og bare bruke mottakeren du angir i tekstfeltet.

1. I feltet **Din ref** skriver du inn navnet som skal vises som vår referanse i dokumentet. Du kan bruke SuperOffice CRM [malvariabler][1] i dette feltet.

    > [!NOTE]
    > For at variabler som salgs-ID eller prosjekt-ID skal fungere, må du knytte dokumentutsendelsen til et salg eller et prosjekt.

1. I listen **Mappe** velger du en mappe du vil plassere utsendelsen i.

    [Hvordan oppretter jeg en utsendelsesmappe?][3]

1. I feltene **Utvalg** og **Prosjekt** kan du knytte utsendelsen til et utvalg og/eller et prosjekt. Begynn å skrive for å søke.

1. Klikk på **Neste** for å gå til neste trinn.

## Trinn 2: Mal

[!include[Hvordan velge en mal](includes/mailing-choose-template.md)]

## Trinn 3: Innhold

I trinnet **Innhold** kan du redigere utseendet på og innholdet i dokumentet.

1. Klikk på knappen **Rediger**.

1. I dialogboksen klikker du på **Last ned dokument**. Filen lastes ned til nettleseren din.

1. Åpne dokumentet for å redigere det. I de fleste nettlesere kan du klikke på den nedlastede filen for å åpne den i standardprogrammet.

1. Rediger innholdet i dokumentet.

1. Lagre dokumentet.

1. I SuperOffice Marketing klikker du på **Rediger** for å åpne dialogboksen på nytt (hvis det er aktuelt).

1. Klikk på **Velg fil**, merk det lagrede dokumentet, og klikk på **Last opp valgt fil**. Forhåndsvisningen på høyre side oppdateres med innholdet i den opplastede filen.

1. Klikk på **Neste** for å gå til neste trinn.

### Bruke malvariabler

Du kan bruke SuperOffice CRM-[malvariabler][1] i dokumentet for å sette inn kundespesifikk informasjon. Dette vil gi meldingen et mer personlig preg.

## Trinn 4: Mottakere

[!include[Trinn 4-mottakere](includes/step-4-recipients.md)]

## Trinn 5: Bekreft

> [!NOTE]
> Dokumentutsendelser sendes i realiteten ikke når du klikker på **Send nå**. Det genereres et PDF-dokument som inneholder alle sidene for alle personer/firmaer du har valgt som mottakere i utsendelsen. Du kan [åpne og skrive ut](#pdf) PDF-dokumentet fra bildet **Vis utsendelse**.

I det siste trinnet, **Bekreft**, kan du vise et sammendrag av utsendelsen og bekrefte at den er korrekt. Eventuelle feilmeldinger som vises i dette bildet, må løses før utsendelsen kan sendes.

> [!NOTE]
> Alternativene for sending deaktiveres hvis det er ufullstendige trinn eller manglende informasjon i utsendelsen. Disse indikeres med rødt.

### Sende utsendelsen nå

Klikk på **Send nå** for å generere et PDF-dokument. Det genereres et PDF-dokument. Arbeidsflyten lukkes, og du returneres til fanen **Utsendelser**.

Klikk på utsendelsen i listen for å [vise sendestatus og statistikk][2].

### <a id="pdf"></a>Åpne og skrive ut dokumentet

1. Velg fanen **Utsendelser**.
1. Finn dokumentet, klikk på <i class="ph ph-list" aria-label="Task menu"></i> og velg **Vis**.
1. Klikk på knappen under **Last ned generert dokument**. Dokumentet lastes ned til nettleseren din.
1. Åpne og skriv ut dokumentet.

<!-- Referenced links -->
[2]: ../view-statistics.md
[1]: ../../../editor/learn/index.md#variables
[3]: ../../../learn/create-folder.md

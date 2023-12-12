---
uid: help-no-service-mailbox-create
title: Opprette e-postkasser
description: Opprette e-postkasser
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: e-post
so.topic: howto
language: no
---

# Opprette e-postkasser

Du kan opprette en postkasse som skal brukes til å importere e-post til SuperOffice Service. Før du gjør dette, må du opprette en postboks på e-postserveren som e-postmeldingen leveres til.

> [!NOTE]
> Før du konfigurerer en postboks, må du kontrollere at det ikke er gamle meldinger i denne postboksen på e-postserveren. SuperOffice Service importerer all e-post i postkassen, og du risikerer å sende automatiske svar til alle personer som har sendt e-post til denne adressen. For å importere disse gamle e-postene, bør du deaktivere autosvarfunksjonen. Fremfor alt gjelder dette alternativet **Ikke autosvar** på skjermbildet **E-postkasse egenskaper** og alternativet **Ikke send e-post til nye personer** i fanen **Innstillinger** på **System**-skjermbildet i SuperOffice Service.

## Slik oppretter du en ny postboks – tilkoblet

1. [!include[Go to email](includes/goto-email.md)]

1. Klikk på **Ny e-postkasse**. Skjermbildet **Egenskaper for e-postkasse** vises med fanen **Egenskaper** åpen.

1. I **Adresse**-feltet skriver du inn navnet uten @domene.xx, og trykker **TAB** for å legge til CRM Online-innstillingene til e-postadressen.

    > [!NOTE]
    > En "vennlig" e-postadresse kan legges til adressen ved å legge til ("vennlig navn") på slutten av e-postadressen. Eksempel: <info@company.com> (Kunde Ltd.).

1. Velg kategori, prioritet, og sakstype:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. [!include[Set customer language](includes/step-set-language.md)]

1. Angi svar:

    [!include[Common steps](includes/step-set-reply.md)]

1. [!include[Import stuff](includes/step-import.md)]

1. **AI-tjenester**: Her kan du velge følgende alternativer for kategorisering og tekstanalyse ved hjelp av [AI:][4]

    * **Bruk AI til å foreslå kategorier**: Velg dette alternativet hvis du vil [la kunstig intelligens foreslå en kategori][3] for saker basert på innholdet i e-postmeldinger.
    * **Bruk tekstanalyse**: Velg dette alternativet for å [la AI analysere teksten][2] i e-postmeldinger for å gjenkjenne språk (for oversettelse) og utføre sentimentanalyse.

1. Klikk på **OK**. E-postkassen opprettes.

## Slik oppretter du en ny postboks – på stedet

1. [!include[Go to email](includes/goto-email.md)]

1. Klikk på **Ny e-postkasse**. Skjermbildet **Egenskaper for e-postkasse** vises med fanen **Egenskaper** åpen.

1. I **Adresse**-feltet skriver du inn e-postadressen du vil bruke for postboksen.

    > [!NOTE]
    > Konfigurer videresending til denne e-postkasseadressen hvis du skal bruke firmaets e-postadresse (for eksempel <info@company.com>). Bruk **Videresendingsadresse** på skjermbildet **E-postkasser**.

1. I listeboksen **Protokoll** velger du hvilken protokoll som skal brukes til å kommunisere med e-postserveren. Noen av protokollene kan kreve ytterligere konfigurasjon.

1. I feltet **E-postserver** skriver du inn serverens vertsnavn.

1. I feltene **Brukernavn** og **Passord** skriver du inn henholdsvis brukernavnet og passordet til e-postkassen.

1. I feltet **Mappe** skriver du inn mappenavnet til e-postkassen på serveren.

1. I feltet **Port** kan du eventuelt endre foreslått standardport for valgt protokoll.

1. Velg kategori, prioritet, og sakstype:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. I **Intervall**-listen velger du hvor ofte SuperOffice Service ser etter meldinger i denne postkassen.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Angi svar:

    [!include[Common steps](includes/step-set-reply.md)]

1. Gå til fanen **Alias**. Her kan du skrive inn et hvilket som helst e-postalias for en postkasse (for eksempel hvis <sales@company.com> og <sale@company.com> går til samme e-postkasse). Du legger til et alias ved å skrive inn en e-postadresse og deretter klikke ![icon][img1].

1. [!include[Import stuff](includes/step-import.md)]

1. Klikk på **OK**. E-postkassen opprettes.

## Hva vil du gjøre nå?

* [Slette e-postkasser][1]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-add.png

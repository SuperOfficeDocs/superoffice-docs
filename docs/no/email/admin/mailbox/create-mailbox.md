---
uid: help-no-service-mailbox-create
title: Opprette e-postkasser
description: Opprette e-postkasser
author: digitaldiina
date: 05.04.2026
version: 11.13
keywords: e-post
content_type: howto
category: email
topic: Service mailbox
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
---

# Opprette e-postkasser

Du kan opprette en postkasse som skal brukes til å importere e-post til SuperOffice Service. Før du gjør dette, må du opprette en postboks på e-postserveren som e-postmeldingen leveres til.

> [!NOTE]
> Før du konfigurerer en postboks, må du kontrollere at det ikke er gamle meldinger i denne postboksen på e-postserveren. SuperOffice Service importerer all e-post i postkassen, og du risikerer å sende automatiske svar til alle personer som har sendt e-post til denne adressen. For å importere disse gamle e-postene, bør du deaktivere autosvarfunksjonen. Fremfor alt gjelder dette alternativet **Ikke autosvar** på skjermbildet **E-postkasse egenskaper** og alternativet **Ikke send e-post til nye personer** i fanen **Innstillinger** på **System**-skjermbildet i SuperOffice Service.

## Trinn

1. [!include[Go to email](includes/goto-email.md)]

1. Klikk på **Ny e-postkasse**. Skjermbildet **Egenskaper for e-postkasse** vises med fanen **Egenskaper** åpen.

1. I **Adresse**-feltet skriver du inn navnet uten @domene.xx, og trykker **TAB** for å legge til CRM Online-innstillingene til e-postadressen.

    > [!NOTE]
    > En "vennlig" e-postadresse kan legges til adressen ved å legge til ("vennlig navn") på slutten av e-postadressen. Eksempel: `info@company.com` (Kunde Ltd.).

1. Velg kategori, prioritet, og sakstype:

    * I **Kategori**-listeboksen velger du kategorien meldingene i denne e-postkassen tilhører.

    * I **Prioritet**-listeboksen velger du prioriteten for å gi saker fra denne postboksen.

    * I **Sakstype**-listeboksen velger du typen meldinger som tilhører denne postkassen.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Angi svar:

    1. Velg **Ikke send automatisk svar** hvis du vil deaktivere funksjonen for automatisk svar. Se merknaden øverst i dette emnet.

    1. I feltet **E-postfelt** kan du angi en kommadelt liste over e-postfelt (overskrifter) som skal vises i sakssmeldingen, for eksempel Til og Kopi til.

    1. I listeboksen **Svarmal for svar til kunde** velger du hvilken svarmal som skal brukes når det sendes automatisk svar til kunden.

    1. **Foreslå FAQ-oppføringer fra**: Hvis avmerket, vil systemet foreslå FAQ-oppføringer basert på teksten i innkommende e-poster. De foreslåtte FAQ-oppføringene er tilgjengelige som malvariabler, og kan derfor gjentas i den valgte svarmalen. Du kan også angi hvilken gren av FAQ-treet det skal søkes i, ved å angi ønsket mappe.

1. **Importer automatiske svar og systemmeldinger**: Som standard importeres ikke e-postmeldinger som inneholder "ute av kontoret"-meldinger, systemmeldinger og andre irrelevante meldinger. Hvis du vil importere slike e-poster, kan du velge dette alternativet.

1. **AI-tjenester**: Her kan du velge følgende alternativer for kategorisering og tekstanalyse ved hjelp av [AI:][4]

    * **Bruk AI til å foreslå kategorier**: Velg dette alternativet hvis du vil [la kunstig intelligens foreslå en kategori][3] for saker basert på innholdet i e-postmeldinger.
    * **Bruk tekstanalyse**: Velg dette alternativet for å [la AI analysere teksten][2] i e-postmeldinger for å gjenkjenne språk (for oversettelse) og utføre sentimentanalyse.

1. Klikk på **OK**. E-postkassen opprettes.

## Relatert innhold

* [Slette e-postkasser][1]
* [E-post i Service og Marketing][5]
* [Opprette e-postkasse (onsite)][6]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md
[5]: ../../../../en/online/mail-services/curl/index.md
[6]: https://help.superoffice.com/docs/11/no/email/admin/mailbox/create-mailbox.html

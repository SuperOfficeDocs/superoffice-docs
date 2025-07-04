---
uid: help-no-quote-send
title: Sende tilbud
description: Lær hvordan du sender, godkjenner og versjonerer tilbud i SuperOffice CRM.
keywords: sende tilbud, godkjenne tilbud, redigere sendt tilbud, sende, publisere, godkjenning, tilbudsversjon, fanen Vedlegg, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/quote/learn/approve
  - /no/quote/learn/send
  - /no/quote/learn/versions
---

# Sende tilbud

Når du har lagt til produkter og opprettet et tilbudsdokument, kan du sende tilbudet til kunden. Tilbudet får status **Sendt** og låses for redigering.

## Klargjør tilbudet

1. Gå til detaljkortet **Tilbud** i salget og klikk på **Åpne** for å redigere tilbudet.

1. Kontroller følgende:

    * All nødvendig produkinformasjon er fylt ut.
    * Tilbudsdokumentet er opprettet.
    * Relevante vedlegg er valgt i fanen **Vedlegg** (hvis aktuelt). Disse filene blir med når tilbudet sendes til kunden.
    * Riktig alternativ er valgt som **favorittalternativ**.
    * Ingen [varsler eller feil][4] er til stede.

> [!NOTE]
> Du kan ikke sende et tilbud hvis det inneholder varsler, feil eller krever godkjenning. **Send**-knappen er deaktivert til problemet er løst.

## <a id="approve"></a>Krever godkjenning?

Noen tilbud må godkjennes før de kan sendes, for eksempel hvis fortjenesten er for lav eller rabatten for høy. Godkjenningskrav defineres per salgstype i Innstillinger og vedlikehold (**Lister** > **Salg – Type, Faser, Tilbud**).

* Hvis godkjenning kreves, får tilbudet statusen **Trenger godkjenning**.
* Det vises et varselbanner i dialogboksen **Rediger tilbud**, og varselsikoner vises.

### Slik godkjenner du et tilbud

1. En bruker med godkjenningsrettigheter åpner tilbudet.

1. Klikk **Godkjenn** eller **Avvis**.

1. Statusen oppdateres til **Godkjent** (<i class="ph ph-check-square" aria-hidden="true"></i>) eller **Avvist** (<i class="ph ph-x-square" aria-hidden="true"></i>).

## <a id="send"></a>Slik sender du tilbudet

1. Klikk på **Send** i dialogboksen **Rediger tilbud**.

    Dialogboksen **Publiser/send tilbud** åpnes.

    ![Dialogboksen Send tilbud -screenshot][img1]

2. Juster eventuelt gyldighetsdatoen i feltet **Gyldig til** (standard er 30 dager).

3. Velg **Tilbudsoppsett** (mal) og **Språk** for tilbudet.

4. Hvis tilbudet har flere alternativer, kan du merke av for **Bruk kun favorittalternativ** for å sende kun dette. Ellers blir alle alternativene tatt med i tilbudet.

5. I delen **Publiser**, velg hvordan tilbudet skal leveres:

    * **Send som e-post og arkiver som PDF** (velg en e-postmal)
    * **Kun arkiver som PDF** (du må sende tilbudet separat)

6. (Valgfritt) Merk av for **Lag oppfølging**, skriv en notat og velg dato for å lage en påminnelse.

7. Klikk **Forhåndsvisning** for å se tilbudet som PDF.

8. Klikk **OK** for å sende og/eller arkivere tilbudet.

    Hvis du velger e-post, åpnes dialogboksen **Ny e-post** for å tilpasse meldingen.

### Etter sending

* Tilbudet får statusen **Sendt**.
* Gjeldende versjon låses.
* **Status** viser utløpsdatoen (f.eks. *Sendt (Gyldig til - 03.05.2025)*).
* Ikonet endres fra <i class="ph ph-pencil-simple" aria-label="Utkastikon"></i> til konvolutt (<i class="ph ph-envelope" aria-label="Sendt ikon"></i>).
* PDF-en arkiveres i detaljkortet **Aktiviteter**.

    ![Detaljkortet Tilbud når tilbudet er sendt -screenshot][img2]

## <a id="versions"></a>Redigere sendt tilbud

Etter sending blir tilbudet skrivebeskyttet. For å gjøre endringer (for eksempel etter ønske fra kunden) må du opprette en ny versjon.

1. Klikk **Åpne** i detaljkortet **Tilbud**.
2. Klikk **Rediger** i dialogboksen **Rediger tilbud**.
3. En ny versjon opprettes med status **Utkast**. Den forrige versjonen arkiveres (<i class="ph ph-folder-simple" aria-hidden="true"></i>).

Du kan bytte mellom versjoner ved hjelp av rullegardinmenyen **Versjon** øverst i dialogen.

> [!TIP]
> Endringer i den nye versjonen påvirker ikke originalen. Du må sende den nye versjonen manuelt.

## Relatert innhold

* [Opprette tilbudsdokument][1]
* [Bytte tilbudsdokument][2]
* [Registrere ordre][3]
* [Konfigurere regler for tilbudsgodkjenning][5] i Innstillinger og vedlikehold

<!-- Referenced links -->
[1]: create-quote-document.md
[2]: create-quote-document.md#replace
[3]: place-order.md
[4]: create.md#warning
[5]: ../../admin/sale-type.md#quote-fields

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/send-quote-dialog.png
[img2]: ../../../../media/loc/en/sale/sent-quote.png

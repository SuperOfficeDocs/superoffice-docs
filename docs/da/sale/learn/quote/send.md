---
uid: help-da-quote-send
title: Afsendelse af tilbud
description: Lær, hvordan du sender, godkender og versionerer tilbud i SuperOffice CRM.
keywords: sende tilbud, godkende tilbud, redigere sendt tilbud, send, publicer, godkendelse, tilbudsversion, fanen Vedhæftede filer, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from:
  - /da/quote/learn/approve
  - /da/quote/learn/send
  - /da/quote/learn/versions
---

# Afsendelse af tilbud

Når du har tilføjet produkter og oprettet et tilbudsdokument, kan du sende tilbuddet til kunden. Tilbuddet får status **Sendt** og låses for redigering.

## Klargør tilbuddet

1. Gå til fanen **Tilbud** i salget, og klik på **Åbn** for at redigere tilbuddet.

1. Kontrollér følgende:

    * Alle obligatoriske produktoplysninger er udfyldt.
    * Tilbudsdokumentet er oprettet.
    * Eventuelle nødvendige vedhæftede filer er valgt i fanen **Vedhæftede filer**.
    * Det korrekte alternativ er angivet som **favoritalternativ**.
    * Der er ingen [advarsler eller fejl][4].

> [!NOTE]
> Du kan ikke sende et tilbud, hvis det har advarsler, fejl eller kræver godkendelse. Knap **Send** er deaktiveret, indtil problemet er løst.

## <a id="approve"></a>Kræver godkendelse?

Nogle tilbud skal godkendes, før de kan sendes, f.eks. hvis indtjeningen er for lav eller rabatten for høj. Krav om godkendelse fastsættes pr. salgstype i Indstillinger og vedligeholdelse (**Lister** > **Salg – Type, Faser, Tilbud**).

* Hvis godkendelse kræves, får tilbuddet status **Skal godkendes**
* Der vises et banner i dialogboksen **Rediger tilbud**, og advarselsikoner vises

### Sådan godkendes et tilbud

1. En bruger med godkendelsesrettigheder åbner tilbuddet.

1. Klik på **Godkend** eller **Afvis**.

1. Status opdateres til **Godkendt** (<i class="ph ph-check-square" aria-hidden="true"></i>) eller **Afvist** (<i class="ph ph-x-square" aria-hidden="true"></i>).

## <a id="send"></a>Sådan sendes tilbuddet

1. Klik på **Send** i dialogboksen **Rediger tilbud**.

    Dialogboksen **Publicer/send et tilbud** åbnes.

    ![Dialogboksen Send tilbud -screenshot][img1]

2. Justér eventuelt udløbsdatoen i feltet **Gyldig til** (standard er 30 dage).

3. Vælg **Tilbudslayout** (skabelon) og **Sprog** for tilbuddet.

4. Hvis tilbuddet har flere alternativer, kan du vælge **Brug kun favoritalternativ** for kun at inkludere dette. Ellers er alle alternativer inkluderet i tilbuddet.

5. I sektionen **Udgiv**, vælg hvordan tilbuddet skal leveres:

    * **Send som e-mail og arkiver som PDF** (vælg en e-mailskabelon)
    * **Arkiver kun som PDF** (du skal sende tilbuddet separat)

6. (Valgfrit) Markér **Opret opfølgning**, tilføj en note og vælg dato for påmindelsen.

7. Klik på **Eksempel** for at få vist tilbuddet som PDF.

8. Klik på **OK** for at sende og/eller arkivere tilbuddet.

    Hvis du valgte e-mail, åbnes dialogboksen **Ny e-mail** for at tilpasse beskeden.

### Efter afsendelse

* Tilbuddet får status **Sendt**.
* Den aktuelle version låses.
* **Status** viser udløbsdatoen (f.eks. *Sendt (Gyldig til - 03.05.2025)*).
* Ikonet skifter fra <i class="ph ph-pencil-simple" aria-label="Kladde ikon"></i> til konvolut (<i class="ph ph-envelope" aria-label="Sendt ikon"></i>).
* PDF-filen arkiveres under fanen **Aktiviteter**.

    ![Fanen Tilbud når tilbud er sendt -screenshot][img2]

## <a id="versions"></a>Redigere et sendt tilbud

Når tilbuddet er sendt, bliver det skrivebeskyttet. For at foretage ændringer (f.eks. som svar på en kundeanmodning) skal du oprette en ny version.

1. Klik på **Åbn** under fanen **Tilbud**.
2. Klik på **Rediger** i dialogboksen **Rediger tilbud**.
3. Der oprettes en ny version med status **Kladde**. Den tidligere version arkiveres (<i class="ph ph-folder-simple" aria-hidden="true"></i>).

Du kan skifte mellem versioner ved hjælp af rullemenuen **Version** øverst i dialogen.

> [!TIP]
> Ændringer i den nye version påvirker ikke originalen. Du skal sende den nye version manuelt.

## Relateret indhold

* [Opret tilbudsdokument][1]
* [Udskift tilbudsdokument][2]
* [Opret ordre][3]
* [Konfigurer regler for tilbudsgodkendelse][5] i Indstillinger og vedligeholdelse

<!-- Referenced links -->
[1]: create-quote-document.md
[2]: create-quote-document.md#replace
[3]: place-order.md
[4]: create.md#warning
[5]: ../../admin/sale-type.md#quote-fields

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/send-quote-dialog.png
[img2]: ../../../../media/loc/en/sale/sent-quote.png

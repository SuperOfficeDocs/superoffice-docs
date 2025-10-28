---
uid: help-da-tutorial-email-mailing
title: Selvstudium - e-mail-udsendelse
description: Når du har gennemført de nødvendige forberedelser, som inkluderer oprettelse af din målliste og forberedelse af din mailskabelon, så er du klar til at oprette en ny udsendelse i SuperOffice CRM. I dette selvstudium lærer du at oprette en e-mail-udsendelse.
keywords: e-mail-udsendelse
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Selvstudium - e-mail-udsendelse

[!include[Tip](includes/tip-mailing-save-draft.md)]

## Trin 1: Opsætning

Du kan oprette din nye udsendelse på skærmbilledet Marketing under fanen Udsendelser. Klik på knappen Opret udsendelse, så kommer du til det første trin, hvor du kan konfigurere din udsendelse.

Det første trin i oprettelse af en e-mailudsendelse kaldes **Opsætning**. Her kan du angive oplysninger i e-mailens meddelelseshoved som f.eks. afsender, svar-til-adresse samt emne. Du kan også tilføje vedhæftninger, indstille arkiveringsvalg for udsendelsen og vælge sporingsindstillinger.

1. Skriv et navn i feltet **Udsendelsens navn**.

1. Skriv emnet for e-mailen ind i feltet **E-mailens emne**.

1. På listen **Fra** skal du vælge **Brug altid** og skrive afsenderens e-mailadresse ind i feltet nedenfor for at angive samme afsender for alle udsendelser. Du kan også vælge, at salgskontakt eller supportkontakt skal stå som afsender, hvis de er angivet for den aktuelle modtager. Indtast en e-mailadresse, der skal anvendes, hvis der ikke er en tilgængelig salgs- eller supportkontakt. Hvis din administrator har aktiveret den [generelle præference for e-mailvalidering][2], skal du vælge det domæne, du vil sende fra, på rullelisten.

    [!include[Note](includes/spf-look-up.md)]

1. I listen **Svar til** har du samme valg som ovenfor. Samtidig kan du også vælge **Brug "Fra" som svaradresse**. Alle svar vil så blive sendt til afsenderen.

1. Vælg en mappe fra listen **Mappe**, som du vil lægge udsendelsen i.

    [Hvordan opretter jeg en mappe til udsendelser?][4]

1. I felterne **Udvalg** og **Projekt** kan du knytte udsendelsen til et udvalg og/eller et projekt. Begynd at skrive for at søge.

    Hvis du markerer et udvalg, tilføjes alle personer i udvalget som modtagere i udsendelsen.

1. På listen **Type** vælger du hvilken type udsendelse, du opretter. Vælg **(Hvilken som helst)**, hvis udsendelsen matcher to eller flere af de tilgængelige typer. Anvend **(Hvilken som helst)**, når du har tilføjet flere modtagere med flere abonnementer, og du vil sende ud til dem alle.

1. **Vedhæftning**: Du kan tilføje en vedhæftning til udsendelsen med en af de følgende metoder:

    * Klik på **Upload filer (eller træk her)** for at gennemse og tilføje en fil fra en disk eller en server.
    * Træk og slip en fil fra Windows Stifinder til vedhæftningsfeltet.
    * Klik på **Vælg et CRM-dokument** for at vælge et dokument i SuperOffice CRM.

1. Under **Sporing** finder du følgende valgmuligheder:

    [!include[Tracking options for mailing](includes/mailing-tracking-options.md)]

1. Klik på **Næste** for at gå til det næste trin.

### Validering af e-mail-domæne (KUN ONLINE)

Hvis din administrator har aktiveret [generelle indstillinger][2] i form af **Brug kun godkendte e-mail-domæner**, vil feltet **Fra-adresse** blive delt op, og du skal vælge det domæne, du vil sende fra, i rullelisten over godkendte domæner.
Hvis du forsøger at sende fra et domæne, der ikke har en gyldig SPF-registrering, får du vist en advarsel, og du kan ikke sende fra det domæne. Det gælder for alle e-maildomæner, også selvom valideringspræferencen ikke er aktiveret.

> [!NOTE]
> Hvis **Vores kontaktadresse** har et e-maildomæne, der ikke er valideret, sendes mailudsendelsen automatisk fra den adresse, der er angivet i rullelisten **Ellers brug**.

## Trin 2: Skabelon

[!include[Sådan vælger du en skabelon](includes/mailing-choose-template.md)]

## Trin 3: Indhold

[!include[Trin 3 e-mail](includes/step-3-content-email.md)]

## Trin 4: Modtagere

[!include[Trin 4 modtagere](includes/step-4-recipients.md)]

## Trin 5: Bekræft

[!include[Sådan bekræftes og sendes en udsendelse](includes/step-5-confirm-and-send-mailing.md)]

<!-- Referenced links -->
[2]: ../../admin/add-domain.md
[4]: ../../../learn/create-folder.md

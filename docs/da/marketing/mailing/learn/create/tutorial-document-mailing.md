---
uid: help-da-tutorial-document-mailing
title: Selvstudium - dokumentudsendelse
description: I dette selvstudium lærer du at oprette en dokumentudsendelse.
keywords: dokumentudsendelse
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

# Selvstudium - dokumentudsendelse

[!include[Tip](includes/tip-mailing-save-draft.md)]

## Trin 1: Opsætning

> [!TIP]
> Hvis du vil have vist og udskrive en eksisterende dokumentforsendelse, skal du lukke trinnet **Opsætning** (klik på **Annuller** eller **Gem + Luk**). Vælg fanen **Udsendelser** find dokumentet, klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> og vælg  **Se**. Klik på knappen under **Download genereret dokument**. Filen downloades til din browser. Åbn og udskriv dokumentet.

Ved hjælp af arbejdsgangen dokumentudsendelse kan du generere et PDF-dokument, der skal udskrives og sendes til dine kunder. Det første trin ved oprettelse af en udsendelse kaldes **Opsætning**. Her kan du indstille udsendelsens navn, dokumentets overskrift og fokus-tekst og indstille arkiveringsvalg for udsendelsen.

Du kan forbinde udsendelsen med et specifikt projekt. Det kan være relevant, hvis du opretter udsendelser, hvor modtagerne er projektmedlemmer fra et projekt i SuperOffice CRM. Ved at bruge skabelonvariabler i skabelonen kan du tilføje data til din udsendelse.

Du kan koble udsendelsen til et specifikt salg. Det kan være relevant, hvis du opretter udsendelser, hvor modtagerne er salgsinteressenter fra et projekt i SuperOffice CRM. Ved at bruge skabelonvariabler i skabelonen kan du tilføje salgsdata til din udsendelse.

**Trin:**

1. Skriv et navn i feltet **Udsendelsens navn**.

1. I feltet **Overskrift** skal du skrive dokumentets titel.

1. I feltet **Att.** skal du vælge hvem udsendelsen skal stiles til. Vælg en af følgende valgmuligheder:

    * **Hvis ingen defineret**: Vælg denne indstilling for at bruge modtagernes navne som standard, eller brug den modtager, du skriver i tekstfeltet, hvis der ikke findes noget modtagernavn. Hvis du opretter en udsendelse, der skal sendes til it-medarbejdere i en virksomhed, kan du indtaste "it-afdeling" eller lignende.

    * **Brug altid**: Vælg denne indstilling for at tilsidesætte modtagernes navne og kun bruge den modtager, du indtaster i tekstfeltet.

1. I feltet **Vores ref.** skriver du det navn, der skal vises som vores kontaktperson i dokumentet. Du kan bruge SuperOffice CRMs [skabelonvariabler][1] i dette felt.

    > [!NOTE]
    > Hvis variabler som salgs-id eller projekt-id skal fungere, skal du knytte dokumentforsendelsen til et salg eller projekt.

1. Vælg en mappe fra listen **Mappe**, som du vil lægge udsendelsen i.

    [Hvordan opretter jeg en mappe til udsendelser?][3]

1. I felterne **Udvalg** og **Projekt** kan du knytte udsendelsen til et udvalg og/eller et projekt. Begynd at skrive for at søge.

1. Klik på **Næste** for at gå til det næste trin.

## Trin 2: Skabelon

[!include[Sådan vælger du en skabelon](includes/mailing-choose-template.md)]

## Trin 3: Indhold

I trinnet **Indhold** kan du redigere dokumentets udseende og indhold.

1. Klik på knappen **Rediger**.

1. Klik på **Download dokument**i dialogboksen. Filen downloades til din browser.

1. Åbn dokumentet til redigering. I de fleste browsere kan du klikke på den downloadede fil for at åbne den i standard-programmet.

1. Rediger dokumentets indhold.

1. Arkiver dokumentet.

1. (hvis aktuelt) I SuperOffice Marketing kan du klikke på **Redigér** for at genåbne dialogboksen.

1. Klik på **Vælg fil**, vælg det gemte dokument og klik på **Upload den valgte fil**. Forhåndsvisningen til højre opdateres med indholdet af den uploadede fil.

1. Klik på **Næste** for at gå til det næste trin.

### Anvende skabelonvariabler

Du kan bruge  [skabelonvariabler][1] fra SuperOffice CRM i dit dokument til at indsætte kundespecifikke oplysninger. Det giver meddelelsen et mere personligt præg.

## Trin 4: Modtagere

[!include[Trin 4 modtagere](includes/step-4-recipients.md)]

## Trin 5: Bekræft

> [!NOTE]
> Dokumentudsendingerne afsendes reelt ikke, når du klikker på **Send nu**. Der genereres et PDF-dokument, der indeholder samtlige sider til alle de personer/virksomheder, du har valgt som modtagere af din udsendelse. Du kan [åbne og udskrive](#pdf) PDF-filen via skærmbilledet **Vis udsendelse** .

Under det sidste trin, **Bekræftelse**, kan du se en sammenfatning af udsendelsen og bekræfte, at alt er korrekt. Alle fejlmeddelelser, der vises på dette skærmbillede, skal løses inden udsendelsen kan afsendes.

> [!NOTE]
> Sendeindstillingerne er deaktiveret, hvis der er ufuldstændige trin eller manglende oplysninger i din mailudsendelse. De er angivet med rødt.

### Sende udsendelsen med det samme

Klik på **Send nu** for at generere et PDF-dokument. Der genereres et PDF-dokument. Workflowet lukker, og du kommer tilbage til fanebladet **Udsendelser**.

Klik på udsendelsen på listen for at [se status og statistik for din afsendelse][2].

### <a id="pdf"></a>Åbne og udskrive dokumentet

1. Vælg fanen **Udsendelser**.
1. Find dokumentet, klik på <i class="ph ph-list" aria-label="Task menu"></i> og vælg **Vis**.
1. Klik på knappen under **Download genereret dokument**. Filen downloades til din browser.
1. Åbn og udskriv dokumentet.

<!-- Referenced links -->
[2]: ../view-statistics.md
[1]: ../../../editor/learn/index.md#variables
[3]: ../../../learn/create-folder.md

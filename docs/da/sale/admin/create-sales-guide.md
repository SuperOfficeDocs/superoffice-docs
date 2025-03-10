---
uid: help-da-sales-guide-create
title: Opret en ny salgsguide
description: Sådan opretter du en salgsguide i SuperOffice.
keywords: opret salgsguide, ny salgsguide, salgsguide, guide, workflow, salg
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: salespremium
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
---

# Opret en ny salgsguide

[!include[Skal være administrator](../../learn/includes/req-admin.md)]

I **Indstillinger og vedligeholdelse** definerer du, hvilke salgstyper der skal have en salgsguide, og hvilke faser og aktiviteter, de skal indeholde. Hvordan en salgsguide ser ud, afhænger derfor af dine konfigurationer.

Den bedste måde at definere din egen workflow på er først at drøfte og blive enige om bedste praksis i jeres salgsproces. Du kan opsætte flere salgstyper med guides, hvis din virksomhed har mere end én salgsproces. For eksempel kan du have en salgstype med en guide for nye kunder, en for eksisterende kunder og en til længerevarende salgsprocesser, der indeholder mange faser og aktiviteter.

Denne vejledning viser dig, hvordan du opretter en salgsguide fra bunden.

1. Definer [faser](#create-stages), der skal medtages i salgsguiden.
2. Opret [en salgstype](#create-type) (med tilknyttede faser), som salgsguiden skal knyttes til.
3. Design selve [salgsguiden](#create-guide).

## <a id="create-stages"></a>Opret faser til salgsguiden

En salgsguide skal være knyttet til en salgstype, som igen består af flere faser. [Sådan opretter du faser][2].

For eksempel kan en salgsguide for salg til nye kunder indeholde faserne "Første møde", "Tilbud" og "Underskrivelse af kontrakt".

Gå til næste trin for at knytte faserne til en salgstype.

## <a id="create-type"></a>Opret en salgstype til salgsguiden

En salgsguide skal være tilknyttet en salgstype. [Sådan opretter du en salgstype][3].

Eksempler på salgstyper: "Salg til ny kunde", "Salg til eksisterende kunde", "Krydssalg til eksisterende kunde".

1. Markér **Denne salgstype er tilknyttet en guide**.
1. Vælg mindst to faser.
1. Gå til næste trin for at oprette salgsguiden.

## <a id="create-guide"></a>Opret en salgsguide

Når du har oprettet faser og angivet en salgstype for salgsguiden, kan du designe selve salgsguiden ved at tilføje opfølgninger og/eller dokumenter for hver fase.

1. Klik på **Workflow** i **Navigator** (<i class="ph ph-arrows-left-right" aria-hidden="true"></i>).

2. Vælg fanen **Salgsguide**.

3. Vælg den salgstype, du vil oprette en salgsguide til, fra listen øverst. De tilknyttede faser vises nedenfor.

    * Hvis salgstypen ikke er konfigureret til at have en salgsguide, skal du klikke på **Klik her for at aktivere guide**.

    * Hvis der ikke er defineret nogen faser for salgstypen, skal du klikke på **Klik her for at tilføje faser**. Du kan også redigere salgstypen ved at klikke på **Rediger**.

4. Vælg den ønskede fase fra listen. Fasens detaljer vises nederst i skærmbilledet.

5. [Tilføj en eller flere opfølgninger](#add-fo-stage) til den valgte fase.

    Du behøver ikke at tilføje et dokument til hver fase, men du bør tilføje mindst én opfølgning.

6. [Tilføj et eller flere dokumenter](#add-doc-stage) til den valgte fase.

7. Gentag trin 4-6 for hver fase, du vil tilføje opfølgninger og dokumenter til.

Ændringerne gemmes automatisk. Salgsguiden vil nu blive vist i SuperOffice CRM, når der oprettes et salg med den valgte salgstype.

## <a id="add-fo-stage"></a>Tilføj en opfølgning til en fase

1. Vælg den ønskede salgstype og -fase som beskrevet ovenfor.

2. Klik på **Tilføj** under **Foreslåede opfølgninger i denne fase**.

3. I dialogboksen **Foreslået opfølgning** skal du indtaste navnet på opfølgningen i feltet **Navn**. Dette bør være et beskrivende navn til opfølgningen.

4. I feltet **Formålet med denne opfølgning** skal du skrive en kort beskrivelse, der vises som et værktøjstip i detaljekortet **Salgsguide** i SuperOffice CRM.

    > [!NOTE]
    > Visse indstillinger nedenfor er ikke relevante for den første opfølgning i en salgsguide.

5. Markér **Foreslå denne opfølgning automatisk**, hvis du ønsker, at SuperOffice CRM skal foreslå denne opfølgning, når den forrige opfølgning (i denne eller en tidligere fase) er markeret som fuldført.

6. Vælg en opfølgningstype fra listen **Opfølgningstype**.

7. I feltet **Startdato** skal du angive, hvor mange dage der skal være mellem den forrige opfølgning og denne.

8. I feltet **Varighed** skal du angive, hvor længe opfølgningen skal vare. Formatet er *0h00m*.

9. I feltet **Standardtekst i opfølgning** kan du tilføje en beskrivelse af opfølgningen. Denne tekst vises automatisk, når brugeren opretter opfølgningen.

    > [!TIP]
    > Brugeren kan ændre den forudindstillede tekst, hvis det er nødvendigt.

10. Klik på **Gem**.

11. Gentag denne procedure for at tilføje flere opfølgninger i denne eller andre faser.

### Eksempel på opfølgning

**Salgstype**: Salg til ny kunde
**Fase**: Første møde
**Navn** på opfølgning: Første møde
**Formålet med denne opfølgning**: Undersøg den potentielle kundes krav, og vurder, om produktet kan opfylde deres behov
**Opfølgningstype**: Kundemøde
**Varighed**: 1 time
**Standardtekst**:

Dagsorden for første møde:

\- Information om kundens branche og organisation
\- Behov, ønsker, problemer
\- Firmapræsentation
\- Andet

## <a id="add-doc-stage"></a>Tilføj et dokument til en fase

1. Vælg den ønskede salgstype og -fase som beskrevet ovenfor.

2. Klik på **Tilføj** under **Foreslåede dokumenter i denne fase**.

3. I dialogboksen **Foreslået dokument** skal du indtaste dokumentets navn i feltet **Navn**. Dette bør være et beskrivende navn til dokumentet.

4. I feltet **Formålet med dette dokument** skal du skrive en kort beskrivelse, der vises som et værktøjstip i detaljekortet **Salgsguide**.

5. Vælg den relevante [skabelon][4] i feltet **Skabelon**.

6. Angiv emnet for dokumentet i feltet **Standardoverskrift**.

7. Indtast eventuelt en reference i feltet **Vores ref.**. Du kan f.eks. bruge en [skabelonvariabel][1] til at indsætte salgsnummer, salgstitel eller en anden relevant reference.

8. Klik på **Gem**.

9. Gentag denne procedure for at tilføje flere dokumenter i denne eller andre faser.

### Eksempel på et dokument

**Salgstype**: Salg til ny kunde
**Fase**: Første møde
**Navn** på dokument: Mødebekræftelse
**Formål med dette salgstrin**: Send en e-mail med mødebekræftelse og dato/klokkeslæt til alle deltagere for det første møde.
**Skabelon**: E-mail
**Standardemne**: Mødebekræftelse (første møde)

<!-- Referenced links -->
[1]: ../../document/templates/variables/for-sales.md
[4]: ../../document/templates/learn/index.md
[2]: sale-stage.md
[3]: sale-type.md

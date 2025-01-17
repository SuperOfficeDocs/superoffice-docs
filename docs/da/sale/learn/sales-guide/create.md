---
uid: help-da-sales-guide-create
title: Opret ny salgsguide
description: Sådan opretter du en salgsguide i SuperOffice
author: SuperOffice RnD
so.date: 06.29.2022
keywords: salg, guide
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Oprettelse af ny salgsguide

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Denne procedure viser, hvordan du opretter en salgsguide fra bunden.

1. Definer [faser](#create-stages), der skal medtages i salgsguiden.
2. Definer [den salgstype](#create-type) (med tilknyttede faser), som salgsguiden skal knyttes til.
3. Design [salgsguiden](#create-guide).

## <a id="create-stages" />Opret faser til salgsguiden

En salgsguide skal være knyttet til en salgstype, som igen består af flere faser. [Sådan opretter du faser][2].

For eksempel kan en salgsguide for salg til nye kunder indeholde faserne "Første møde", "Tilbud" og "Underskrivelse af kontrakt".

Gå til den næste procedure for at knytte faserne til en salgstype.

## <a id="create-type" />Opret en salgstype til salgsguiden

En salgsguide skal være tilknyttet en salgstype. [Sådan opretter du en salgstype][3].

Eksempler på salgstyper: "Salg til ny kunde", "Salg til eksisterende kunde", "Krydssalg til eksisterende kunde".

1. Vælg **Denne salgstype er tilknyttet en guide**.
1. Vælg mindst to faser.
1. Gå til den næste procedure for at oprette salgsguiden.

## <a id="create-guide" />Opret en salgsguide

Når du har oprettet faser og angivet en salgstype for salgsguiden, kan du designe selve salgsguiden ved at tilføje opfølgninger og/eller dokumenter for hver fase.

1. Klik på knappen **Workflow** i Navigator (![ikon][img1]).

2. Vælg fanen **Salgsguide**.

3. På listen øverst skal du vælge den salgstype, du vil oprette en salgsguide til. De faser, der er valgt til denne salgstype, vises nedenunder.

    * Hvis salgstypen ikke er konfigureret til at have en salgsguide, skal du klikke på **Klik her for at tilknytte guide** nederst i skærmbilledet.

    * Hvis der ikke er defineret nogen faser for salgstypen, skal du klikke på **Klik her for at tilføje faser** nederst i skærmbilledet. Du kan også redigere salgstypen ved at klikke på knappen **Rediger** øverst.

4. Vælg den ønskede fase på listen. Fasens detaljer vises nederst i skærmbilledet.

5. [Tilføj en eller flere opfølgninger](#add-fo-stage) for den valgte fase.

    Du behøver ikke at tilføje et dokument for hver fase, men du bør tilføje mindst én opfølgning for hver fase.

6. [Tilføj et eller flere dokumenter](#add-doc-stage) for den valgte fase.

7. Gentag trin 4-6 for hver fase, du vil tilføje opfølgninger og dokumenter for.

Ændringerne gemmes automatisk. Salgsguiden vises nu i SuperOffice CRM, når der oprettes et salg med salgstypen valgt i trin B.

## <a id="add-fo-stage" />Tilføj en opfølgning til en fase

1. Vælg den ønskede salgstype og -fase som beskrevet ovenover.

2. Klik på **Tilføj** under **Foreslåede opfølgninger i denne fase**.

3. I dialogboksen **Foreslået opfølgning** skal du indtaste navnet på opfølgningen i feltet **Navn**. Dette bør være et beskrivende navn til opfølgningen.

4. I feltet **Formålet med denne opfølgning** skal du indtaste den tekst, der skal bruges som værktøjstip til opfølgningen, i detaljekortet **Salgsguide** under fanen SuperOffice CRM.

    > [!NOTE]
    > Nogle af indstillingerne nedenunder er af logiske årsager ikke relevante for den første opfølgning i en salgsguide.

5. Vælg **Foreslå denne opfølgning automatisk**, hvis du ønsker, at SuperOffice CRM skal foreslå denne opfølgning, når den forrige opfølgning (i denne eller forrige fase) markeres som fuldført.

6. Vælg en type til opfølgningen på listen **Opfølgningstype**.

7. I feltet **Startdato** skal du angive, hvor mange dage der skal være mellem den forrige opfølgning og denne.

8. I feltet **Varighed** skal du angive, hvor længe opfølgningen skal vare. Formatet er *0h00m*.

9. Angiv en beskrivelse af opfølgningen i feltet **Standardtekst i opfølgning**.

    > [!TIP]
    > Brugeren kan ændre ovenstående oplysninger efter behov.

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

## <a id="add-doc-stage" />Tilføj et dokument til en fase

1. Vælg den ønskede salgstype og -fase som beskrevet ovenover.

2. Klik på **Tilføj** under **Foreslåede dokumenter i denne fase**.

3. I dialogboksen **Foreslået dokument** skal du indtaste navnet på opfølgningen i feltet **Navn**. Dette bør være et beskrivende navn til dokumentet.

4. I feltet **Formålet med denne opfølgning** skal du indtaste den tekst, der skal bruges som værktøjstip til dokumentet, i detaljekortet **Salgsguide**.

5. Vælg den ønskede skabelon i feltet **Skabelon** (se også [Dokument - Skabelon][4]).

6. Angiv det emne, der skal bruges i dokumentet, i feltet **Standardoverskrift**.

7. Indtast en reference i feltet **Vores ref.**. Det kan for eksempel være en [skabelonvariabel][1] for salgsnummer, salgstitel eller et andet felt, der vedrører salget.

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
[1]:https://docs.superoffice.com/en/document/templates/variables/for-sales.html
[2]: ../../../admin/lists/learn/sale-stage.md
[3]: ../../../admin/lists/learn/sale-type.md
[4]: ../../../admin/lists/learn/document-template.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png

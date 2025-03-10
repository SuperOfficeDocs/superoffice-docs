---
uid: help-da-project-guide-create
title: Oprettelse af ny projektguide
description: Sådan opretter du en ny projektguide i SuperOffice
keywords: projekt, guide, workflow
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Oprettelse af ny projektguide

[!include[Must be admin](../../learn/includes/req-admin.md)]

I Indstillinger og vedligeholdelse kan du definere, hvilke projekttyper der er tilknyttet en projektguide, og hvilke statusser og aktiviteter projektguiderne skal indeholde. Det kan derfor variere, hvordan en projektguide ser ud.

Du kan f.eks. have en projekttype med navnet **Konference**. Denne projekttype kan være knyttet til en projektguide, der indeholder følgende statusser, opfølgninger og dokumenter:

| Status | Opfølgninger | Dokumenter |
|---|---|---|
| Planlagt | Planlægningsmøde (Møde (internt)) | Konferenceprogram (Bemærkning) |
| Igangværende | Opret liste over projektdeltagere (Opgave); Konference (Møde (eksternt)) | Konferenceinvitation (Brev) |
| Lukning | Evalueringsmøde (Møde (internt)) | Evalueringsrapport (Bemærkning) |

Denne procedure viser, hvordan du opretter en projektguide fra bunden.

1. Definer [statusser](#create-stage), der skal medtages i projektguiden.
2. Definer den [projekttype](#create-type) (med tilknyttede statusser), som projektguiden skal knyttes til.
3. Design [projektguiden](#create-guide).

![Gå til afsnittet Workflow og opret dine egne projektrutiner i SuperOffice CRM -screenshot][img2]

## <a id="create-stage"></a> Opret statusser for projektguiden

En projektguide skal være knyttet til en projekttype, som igen består af flere statusser. [Sådan opretter du en status][2].

En projektguide til et projekt af konferencetypen kan f.eks. have statusserne Planlagt, Igangværende og Under udførelse.

Gå til den næste procedure for at knytte statusserne til en projekttype.

## <a id="create-type"></a> Opret en projekttype til projektguiden

En projektguide skal være knyttet til en projekttype. [Sådan opretter du en projekttype][3].

Eksempler på projekttyper: "Konference", "Kampagne", "Intern".

1. Markér **Denne projekttype er knyttet til en guide**.
1. Vælg mindst to statusser.
1. Gå til den næste procedure for at oprette projektguiden.

## <a id="create-guide"></a>Opret en projektguide

Når du har oprettet statusser og angivet en projekttype for projektguiden, kan du designe selve projektguiden. Det gør du ved at tilføje opfølgninger og/eller dokumenter for hver status i projektguiden.

1. Klik på <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** i navigatoren.

2. Vælg fanen **Projektguide**.

3. Vælg den projekttype, du vil oprette en projektguide for, på listen **Projekttype**. De statusser, der er valgt for denne projekttype, vises på listen ovenfor.

    > [!NOTE]
    > Hvis projekttypen ikke er konfigureret til at have en projektguide, skal du klikke på **Klik her for at aktivere guide** nederst på skærmen.
    >
    > Hvis der ikke er defineret nogen statusser for projekttypen, skal du klikke på **Klik her for at tilføje statusser** nederst på skærmen. Du kan også redigere projekttypen ved at klikke på knappen **Rediger** øverst.

4. Vælg den ønskede status på listen. Statusoplysningerne vises nederst på skærmen.

5. [Tilføj en eller flere opfølgninger for den valgte status](#add-fo-status).

    > [!NOTE]
    > Du behøver ikke at tilføje et dokument for hver status, men du bør tilføje mindst én opfølgning for hver status.

6. [Tilføj et eller flere dokumenter for den valgte status](#add-doc-status).

7. Gentag trin 4-6 for hver status, du vil tilføje opfølgninger og dokumenter for.

Ændringerne gemmes automatisk. Projektguiden vises nu i SuperOffice CRM, når der oprettes et projekt med projekttypen valgt i trin 2.

## <a id="add-fo-status"></a>Tilføj en opfølgning for en status

1. Vælg den ønskede projekttype og -status som beskrevet ovenfor.

2. Klik på **Tilføj** under **Foreslåede opfølgninger i denne status**.

3. I dialogboksen **Foreslået opfølgning** skal du indtaste navnet på opfølgningen i feltet **Navn**. Dette bør være et beskrivende navn til opfølgningen.

4. Angiv formålet med opfølgningen i feltet **Formålet med denne opfølgning**. Denne tekst vises, når du holder musemarkøren over opfølgningen under fanen **Projektguide** i SuperOffice CRM.

    > [!NOTE]
    > Nogle af mulighederne nedenfor er af logiske årsager ikke relevante for den første opfølgning i en projektguide.

5. Markér **Foreslå at knytte opgaven til en projektdeltager** for at gøre det muligt at knytte denne opfølgning til en af projektdeltagerne. Når projektejeren opretter denne opfølgning i SuperOffice CRM, kan vedkommende vælge en af sine medarbejdere til at være ejer af opfølgningen.

6. Markér **Milepælsopfølgning** for at definere opfølgningen som en milepæl.

7. Vælg en type til opfølgningen på listen **Opfølgningstype**.

8. I feltet **Startdato** skal du angive, hvornår opfølgningen skal starte, som antallet af dage fra i dag.

9. I feltet **Varighed** skal du angive, hvor længe opfølgningen skal vare. Formatet er *0h00m*.

10. Angiv en beskrivelse af opfølgningen i feltet **Standardtekst i opfølgning**.

    > [!TIP]
    > Brugeren kan ændre ovenstående oplysninger efter behov.

11. Klik på **Gem**.

12. Gentag denne procedure for at tilføje flere opfølgninger i denne eller andre statusser.

### Eksempel på opfølgning

**Projekttype**: Konference
**Status**: Planlagt
**Navn** på opfølgning: Planlægningsmøde
**Formålet med denne opfølgning**: Holde et møde for at planlægge konferencen og fastlægge et konferenceprogram.
**Opfølgningstype**: Møde (internt)
**Varighed**: 1 time
**Standardtekst**:

Planlægningsmøde:

\- Hvad skal konferencen indeholde?
\- Deltagere?
\- Foredragsholdere?
\- Hvor?

## <a id="add-doc-status"></a>Tilføj et dokument til en status

1. Vælg den ønskede projekttype og -status som beskrevet ovenfor.

2. Klik på **Tilføj** under **Foreslåede dokumenter i denne status**.

3. I dialogboksen **Foreslået dokument** skal du indtaste navnet på dokumentet i feltet **Navn**. Dette bør være et beskrivende navn til dokumentet.

4. Angiv formålet med dokumentet i feltet **Formålet med dette dokument**. Denne tekst vises, når du holder musemarkøren over dokumentet under detaljekortet **Projektguide** i SuperOffice CRM.

5. Vælg den ønskede [skabelon][4] i feltet **Skabelon**.

6. Angiv det emne, der skal bruges i dokumentet, i feltet **Standardoverskrift**.

7. Indtast en reference i feltet **Vores ref.**. Det kan f.eks. være en [skabelonvariabel][1] for et projektnummer, en projekttitel eller et andet felt, der vedrører projektet.

8. Klik på **Gem**.

9. Gentag denne procedure for at tilføje flere dokumenter i denne eller andre statusser.

### Eksempel på et dokument

**Projekttype**: Konference
**Status**: Planlagt
**Navn** på dokument: Konferenceprogram
**Formålet med denne projektstatus**: Fastlæg et program for konferencen.
**Skabelon**: Bemærkning
**Standardemne**: Konferenceprogram

## Relateret indhold

* [Rediger eller deaktiver en projektguide][5]

<!-- Referenced links -->
[1]: ../../document/templates/variables/from-project-card.md
[4]: ../../document/templates/learn/index.md
[2]: project-status.md
[3]: project-type.md
[5]: edit-project-guide.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/project/create-project-guide.png

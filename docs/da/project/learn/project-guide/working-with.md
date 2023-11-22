---
uid: help-da-project-guide-working-with
title: Arbejde med projektguide
description: Arbejde med projektguide
author: SuperOffice RnD
so.date: 07.04.2022
keywords: projekt, guide
so.topic: howto
language: da
---

# Arbejde med projektguide

Hvis der er defineret en projektguide for en projekttype, du har angivet for et projekt, sker der følgende:

* Første fase i projektguiden er valgt i feltet **Status** på hovedkortet **Projekt**.

* Opfølgninger og/eller dokumenter for statussen er angivet på detaljekortet **Projektguide**.

## Trin

1. Klik på knappen **Opret** foran opfølgningens/dokumentets navn.

   ![Detaljekortet Projektguide med oversigt over status for Planlagt -screenshot][img1]

1. I den dialogboks, der åbnes, [opretter du opfølgningen][2] eller [dokumentet][3] på normal vis. Mange af felterne er færdigudfyldte, men du kan ændre oplysningerne eller tilføje flere oplysninger.

    Du kan delegere opfølgningen til andre medarbejdere ved at angive dem som ejer af opfølgningen. Hvis dette er defineret i Indstillinger og vedligeholdelse, åbnes dialogboksen **Overfør opgaven til en projektdeltager**, hvor du kan vælge en medarbejder som ejer af opfølgningen.

1. Når du er færdig med opfølgningen, markerer du **Udført** i den aktuelle dialogboks eller i afkrydsningsfeltet foran opfølgningsnavnet på detaljekortet **Projektguide**. Dokumenter er som standard markeret som udført.

    > [!TIP]
    > Hvis du vil oprette flere opfølgninger af samme type, kan du højreklikke på opfølgningen og vælge **Opret en til**.
    >
    > ![Opret en til -screenshot][img2]

1. Når alle opfølgninger og dokumenter i en projektstatus er udført, går du til næste status.

    > [!NOTE]
    > Hvis du ønsker det, kan du gå til næste status uden at oprette eller udføre alle opfølgningerne/dokumenterne i en status.

1. Gentag fremgangsmåden ovenfor for alle opfølgninger/dokumenter i hver status i projektguiden.

## <a id="move-to-next-status" />Gå til næste status

Du kan flytte projektet til næste status på to måder:

* Sådan flytter du projektet til næste status automatisk:

    I Indstillinger og vedligeholdelse kan det angives, at projektguiden skal foreslå, at projektet flyttes til næste status, når den sidste opfølgning i en status markeres som udført. Derefter åbnes dialogboksen **Projektguide - flyt projektet til næste status**.

    Klik på **Ja** for at flytte projektet til næste status, eller klik på **Nej** for at fortsætte med at arbejde med projektet i stamme status.

* Sådan flytter du projektet til næste status manuelt:

    Højreklik på knappen for næste status i detaljekortet **Projektguide**, og vælg **Gå til denne status**.

    Eller gør følgende på hovedkortet **Projekt**:

    1. Klik på **Rediger** på hovedkortet **Projekt**.
    1. Klik på pilen ved siden af feltet **Status**.
    1. Vælg den ønskede status fra den liste, der vises. [!include[SM](../../../learn/includes/are-defined-sm.md)]
    1. Klik på **Gem**.

## Eksempel

Husk, at dine projektguider kan konfigureres anderledes i Indstillinger og vedligeholdelse.

### Registrering af et nyt projekt og valg af projekttype

Du registrerer et nyt projekt og vælger projekttypen **Konference**, som er tilknyttet en projektguide. Projektguiden kan f.eks. have følgende statusser, opfølgninger og dokumenter:

| Status | Opfølgninger | Dokumenter |
|---|---|---|
| Planlagt | Planlægningsmøde (møde inde) | Konferenceprogram (bemærkning) |
| Er i gang | Oprettelse af liste over projektdeltagere (Opfølgning) | konference (møde ude) |
| Afsluttes | Evalueringsmøde (møde inde) |
| Evalueringsrapport (bemærkning) |

### Statussen Planlagt

1. Du har aftalt mødetidspunktet, og du vil oprette opfølgingen **Planlægningsmøde** i dagbogen samt invitere deltagere.

    1. I projektguiden klikker du på knappen **Opret** ved siden af opfølgningen **Planlægningsmøde**.
        Dialogboksen **Opfølging** åbnes med **Møde inde** angivet som type og navnet på projektet færdigudfyldt.
    1. Udfyld informationer, og [inviter deltagere][2].
    1. Klik på **Gem**.

1. På mødet bestemmer du konferenceprogrammet (agendaen), og du vil oprette en bemærkning, som indeholder denne oplysning.

    1. Klik på knappen **Opret** ved siden af **Konferenceprogram**.
        Dialogboksen **Dokument** åbnes med **Bemærkning** allerede valgt som dokumentskabelon og navnet på projektet færdigudfyldt.
    1. Udfyld yderligere oplysninger i felterne i dialogboksen **Dokument**.
    1. Klik på knappen **Opret** for at oprette og gemme bemærkningen.

1. Når mødet er gennemført, og konferenceprogrammet er klar, skal du angive dette i projektguiden og gå videre til næste projektstatus.

    I projektguiden markerer du afkrydsningsfeltet ved siden af opfølgningen **Planlægningsmøde**.

    > [!TIP]
    > Dette kan også gøres fra aktivitetslisten på eksempelvis skærmbillederne Dagbog og Firma.

    1. Dialogboksen **Projektguide - flyt projektet til næste status** åbnes.
    1. I denne dialogboks bliver du spurgt, om du vil flytte projektet til næste status, som er **Er i gang**.
    1. Klik på **Ja** for at flytte projektet til næste status.

    > [!NOTE]
    > Dialogboksen **Projektguide - flyt projektet til næste status** åbnes, fordi det er defineret for projekttypen i Indstillinger og vedligeholdelse.

### Statussen Er i gang

1. Alle opfølgningerne og dokumenterne i statussen **Planlagt** er udført, og du har flyttet projektet ved hjælp af dialogboksen **Projektguide - flyt projektet til næste status**. Denne dialogboks vises, når du sætter den sidste opfølgning til fuldført. Opfølgningerne og dokumenterne for den nyeste status vises nu på detaljekortet **Projektguide**.

    > [!NOTE]
    > Dialogboksen **Projektguide - flyt projektet til næste status** vises kun, hvis dette er defineret for projekttypen. Hvis dette ikke er defineret, [skal du flytte projektet til næste status](#move-to-next-status).

1. På planlægningsmødet var der enighed om, at din kollega skal oprette listen over deltagerne på konferencen. Du vil oprette en opgave i deres dagbog som en påmindelse.

    1. Klik på **Opret** ved siden af opfølgningen **Opret en liste over projektdeltagere**.
        Dialogboksen **Overfør opgaven til en projektdeltager** vises.

    1. På listen over projektdeltagere vælger du den person, der skal have ansvaret for opfølgingen og klikker på **OK**.

    1. Indtast de ønskede oplysninger, og klik til sidst på **Gem**. (På fanen **Detaljer** kan du se, at din kollega allerede er angivet som ejer af opgaven.)

    1. Opfølgningen vises i din kollegas dagbog, og når vedkommende er færdig med at oprette listen, sætter vedkommende opfølgningen til **Udført**.

        > [!NOTE]
        > Dialogboksen **Overfør opgaven til en projektdeltager** åbnes, fordi det er defineret i Indstillinger og vedligeholdelse.

1. Nu vil du oprette et invitationsbrev.

    Klik på **Opret** ved siden af dokumentet **Konferenceinvitation**, og [opret dokumentet][3].

1. Til sidst skal selve konferencen afholdes. Du opretter **Konference**-mødet.

    1. Klik på **Opret** ved siden af opfølgningen **Konference**.
        Dialogboksen **Opfølgingen** åbnes med **Møde ude** angivet som type og navnet på projektet færdigudfyldt.
    2. Udfyld oplysningen og inviter konferencedeltagerne, som du plejer.
    3. Klik på **Gem**.

### Statussen Afslutning

1. Når konferencen er afholdt og alle relevante opfølgninger og dokumenter i statussen **Igangværende** er udført, går du til sidste status i projektguiden, som er **Lukning**.

    * Klik på **Ja** i dialogboksen **Projektguide - flyt projektet til næste status**.
        eller
    * Klik på **Rediger** på hovedkortet **Projekt**, klik på pilen til højre for feltet **Status**, vælg **Lukning** fra listen, og klik på **OK**.

1. Du vil holde et møde internt for at opsummere konferencen.

    1. Klik på **Opret** ved siden af opfølgingen **Evalueringsmøde**, udfyld oplysningen, og klik på **Gem**.
    2. Når mødet er udført, markerer du afkrydsningsfeltet.

1. Derefter vil du oprette en evalueringsrapport, som opsummerer evalueringsmødet og konferencen.

    Klik på **Opret** ved siden af dokumentet **Evalueringsrapport** for at oprette dokumentet.

Når alle ønskede opfølgninger og dokumenter for projektet er færdige, kan du markere projektet som udført.

## Relaterede emner

* [Dialogboksen Dokument][1]
* [Dialogboksen for opfølgninger][2]
* [Tilføj og rediger projektguider i Indstillinger og vedligeholdelse][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/project/project-guide-create.png
[img2]: ../../../../media/loc/en/project/project-guide-right-click.png

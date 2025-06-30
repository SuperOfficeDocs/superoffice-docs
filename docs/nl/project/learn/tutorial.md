---
uid: help-nl-project-guide-tutorial
title: Projectgids tutorial
description: Een stapsgewijze handleiding voor het werken met projectgidsen in SuperOffice.
keywords: project, gids, workflow
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: tutorial
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Projectgids tutorial

Houd er rekening mee dat uw projectgidsen mogelijk anders zijn geconfigureerd in Instellingen en onderhoud.

## Een nieuw project invoeren en een projecttype selecteren

U registreert een nieuw project en selecteert het projecttype **Vergadering**, dat is gekoppeld aan een projectgids. De projectgids bevat de volgende statussen, vervolgactiviteiten en documenten.

| Statussen | Vervolgactiviteiten | Documenten |
|---|---|---|
| Gepland | Planningsvergadering (Vergadering (intern)) | Conferentieprogramma (Memo) |
| Wordt uitgevoerd | Lijst met projectleden maken (Vervolgtaak) | conferentie (Vergadering (extern)) |
| Bezig met sluiten | Evaluatievergadering (Vergadering (intern)) | Evaluatierapport (Memo) |

## De status Gepland

1. U hebt een tijd afgesproken en wilt de vervolgactiviteit **Planningsvergadering** vastleggen in de agenda en deelnemers uitnodigen.

    1. Klik in de projectgids op **Maken** naast **Planningsvergadering**.
        Het dialoogvenster **Vervolgactiviteit** opent, waarbij **Vergadering (intern)** en de projectnaam al zijn ingevuld.
    1. Vul de resterende informatie in en [nodig deelnemers uit][1].
    1. Klik op **Opslaan**.

1. Tijdens de vergadering wordt de agenda voor de conferentie vastgesteld en u wilt een memo maken met deze informatie.

    1. Klik op **Maken** naast **Conferentieprogramma**.
        Het dialoogvenster **Document** opent, waarbij **Memo** en de projectnaam al zijn ingevuld.
    1. Vul de overige velden in.
    1. Klik op **Maken** om het document op te slaan.

1. Nadat de vergadering heeft plaatsgevonden en het vergaderprogramma is klaar, wilt u dit bevestigen in de projectgids en naar de volgende projectstatus gaan.

    Schakel in de projectgids het selectievakje naast de vervolgactiviteit **Planningsvergadering** in.

    > [!TIP]
    > U kunt dit ook doen vanuit de activiteitenlijst, bijvoorbeeld in het scherm Agenda en Bedrijf.

    1. Het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen** wordt geopend.
    1. In dit dialoogvenster wordt u gevraagd of u het project wilt verplaatsen naar de volgende status: **Wordt uitgevoerd**.
    1. Klik op **Ja** om het project naar de volgende status te verplaatsen.

    > [!NOTE]
    > Het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen** wordt geopend omdat dit voor dit projecttype is gedefinieerd in Instellingen en onderhoud.

## De status Wordt uitgevoerd

1. Alle vervolgactiviteiten en documenten in de status **Gepland** zijn voltooid en u hebt het project verplaatst via het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen**. Dit dialoogvenster wordt weergegeven wanneer u de laatste vervolgactiviteit hebt ingesteld als voltooid. De vervolgactiviteiten en documenten voor deze nieuwe status worden nu weergegeven op het sectietabblad **Projectgids**.

    > [!NOTE]
    > Het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen** wordt alleen geopend wanneer dit gedrag voor dit projecttype is gedefinieerd. Wanneer dit niet het geval is, [verplaats dan het project naar de volgende status][2].

1. Bij de planningsvergadering gaat u ermee akkoord dat uw collega een lijst met gedelegeerden voor de vergadering opstelt. U wilt een taak in hun dagboek maken als herinnering.

    1. Klik op de knop **Maken** naast de vervolgactiviteit **Lijst met projectleden maken**.
        Het dialoogvenster **Taak toewijzen aan projectlid** wordt geopend.

    1. Selecteer in de lijst met projectleden de persoon aan wie u de taak wilt toewijzen en klik op **OK**.

    1. Voer de vereiste informatie in en klik op **Opslaan**. (Via het tabblad **Details** kunt u nagaan of uw collega al is gedefinieerd als eigenaar van de taak.)

    1. De vervolgactiviteit wordt weergegeven in de agenda van uw collega en nadat hij/zij de lijst heeft opgesteld, markeert hij/zij de vervolgactiviteit als **Voltooid**.

        > [!NOTE]
        > Het dialoogvenster **Taak toewijzen aan projectlid** wordt geopend omdat dit zo is gedefinieerd in Instellingen en onderhoud.

1. U kunt nu een uitnodigingsbrief opstellen.

    Klik op de knop **Maken** naast het document **Uitnodiging voor conferentie** en [maak het document][3].

1. Ten slotte wordt de vergadering gehouden. U maakt de **Vergadering**.

    1. Klik op de knop **Maken** naast de vervolgactiviteit **Conferentie**.
        Het dialoogvenster **Afspraak** wordt geopend, met het afspraaktype **Vergadering (extern)** en vooraf ingevulde naam van het project.
    2. Vul de overige gegevens in en nodig de deelnemers aan de vergadering op de gebruikelijke manier uit.
    3. Klik op **Opslaan**.

## De status Bezig met sluiten

1. Nadat de conferentie is afgerond en alle relevante vervolgactiviteiten en documenten in de status **Wordt uitgevoerd** zijn voltooid, gaat u naar de laatste status in de projectgids: **Bezig met sluiten**.

    * Klik op **Ja** in het dialoogvenster **Projectgids - verplaats project naar volgende status**.
    * Of klik op <i class="ph ph-pencil-simple" aria-label="Bewerken"></i> op de hoofdkaart **Project**, klik op de pijl naast het veld **Status**, selecteer **Bezig met sluiten** in de lijst en klik vervolgens op **OK**.

1. U wilt een interne vergadering organiseren om de conferentie te evalueren.

    1. Klik op **Maken** naast de vervolgactiviteit **Evaluatievergadering**, vul de benodigde informatie in en sla op.
    2. Nadat de vergadering is gehouden, vinkt u het selectievakje aan om deze als voltooid te markeren.

1. Vervolgens wilt u een evaluatierapport opstellen waarin de evaluatievergadering en de conferentie worden samengevat.

    Klik op **Maken** naast het document **Evaluatierapport** om het document aan te maken.

Wanneer alle vereiste vervolgactiviteiten en documenten voor het project zijn voltooid, kunt u de projectstatus instellen op **Voltooid**.

<!-- Referenced links -->
[1]: ../../diary/learn/invitation/add-attendee.md
[2]: project-guides.md#change-status
[3]: ../../document/learn/edit.md

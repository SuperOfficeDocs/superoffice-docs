---
uid: help-nl-project-guide-working-with
title: Werken met projectgidsen
description: Werken met projectgidsen
author: SuperOffice RnD
so.date: 07.04.2022
keywords: project, gids
so.topic: howto
language: nl
---

# Werken met projectgidsen

Wanneer een projectgids is gedefinieerd voor een projecttype dat u voor een project opgeeft, gebeurt het volgende:

* De eerste status in de projectgids wordt geselecteerd in het veld **Status** op de hoofdkaart **Project**.

* Vervolgactiviteiten en/of documenten voor de status worden weergegeven op het tabblad **Projectgids**.

## Stappen

1. Klik op de knop **Maken** die voor de naam van de vervolgactiviteit/het document staat.

   ![Sectietabblad Projectgids met overzicht van de status Gepland -screenshot][img1]

1. U [maakt de vervolgactiviteit][2] of het [document][3] op de gebruikelijke manier in het dialoogvenster dat wordt geopend. Veel van de velden zijn al ingevuld, maar u kunt de informatie wijzigen of informatie toevoegen.

    U kunt de vervolgactiviteit naar uw collega's delegeren door hem/haar tot eigenaar van de vervolgactiviteit te maken. Wanneer dit voor een specifieke vervolgactiviteit gedefinieerd is in Instellingen en onderhoud, wordt het dialoogvenster **Taak toewijzen aan projectlid** weergegeven, waar u een collega als eigenaar van de vervolgactiviteit kunt selecteren.

1. Wanneer u de vervolgactiviteit voltooit, schakelt u de optie **Voltooid** in het relevante dialoogvenster in of schakelt u het selectievakje in vóór de naam van de vervolgactiviteit op het sectietabblad **Projectgids**. Documenten worden standaard gemarkeerd als voltooid.

    > [!TIP]
    > Als u meerdere vervolgactiviteiten van hetzelfde type wilt maken, klikt u met rechtermuisknop op de activiteit en selecteert u **Nog een maken**.
    >
    > ![Nog een maken -screenshot][img2]

1. Nadat alle vereiste vervolgactiviteiten en documenten voor een projectstatus zijn voltooid, kunt u naar de volgende status gaan.

    > [!NOTE]
    > u kunt zo nodig naar de volgende status gaan zonder alle vervolgactiviteiten/documenten binnen een status te maken of uit te voeren.

1. Herhaal de bovenstaande procedure voor alle vervolgactiviteiten/documenten binnen elke status van de projectgids.

## <a id="move-to-next-status" />Naar de volgende status gaan

U kunt het project op twee manieren naar de volgende status verplaatsen:

* Het project automatisch naar de volgende status verplaatsen:

    In Instellingen en onderhoud kan worden ingesteld dat de projectgids voorstelt het project naar de volgende status te verplaatsen wanneer de laatste vervolgactiviteit binnen een status als voltooid is gemarkeerd. Het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen** wordt dan geopend.

    Klik op **Ja** om het project naar de volgende status te verplaatsen; klik op **Nee** om verder te werken aan het project binnen dezelfde status.

* Het project handmatig naar de volgende status verplaatsen:

    Klik met de rechtermuisknop op de knop voor de volgende status op het sectietabblad **Projectgids** en selecteer **Ga naar deze status**.

    Of voer een van de volgende handelingen uit op de hoofdkaart **Project**:

    1. klik op **Bewerken** op de hoofdkaart **Project**.
    1. Klik op de pijl naast het veld **Status**.
    1. Selecteer de gewenste status in de lijst die wordt weergegeven. [!include[SM](../../../learn/includes/are-defined-sm.md)]
    1. Klik op **Opslaan**.

## Voorbeeld

Houd er rekening mee dat uw projectgidsen mogelijk anders zijn geconfigureerd in Instellingen en onderhoud.

### Een nieuw project invoeren en een projecttype selecteren

U registreert een nieuw project en selecteert het projecttype **Vergadering**, dat is gekoppeld aan een projectgids. De projectgids bevat de volgende statussen, vervolgactiviteiten en documenten.

| Statussen | Vervolgactiviteiten | Documenten |
|---|---|---|
| Gepland | Planningsvergadering (Vergadering (intern)) | Conferentieprogramma (Memo) |
| Wordt uitgevoerd | Lijst met projectleden maken (Vervolgtaak) | conferentie (Vergadering (extern)) |
| Bezig met sluiten | Evaluatievergadering (Vergadering (intern)) |
| Evaluatierapport (Memo) |

### De status Gepland

1. U hebt een tijd afgesproken en wilt de vervolgactiviteit **Planningsvergadering** vastleggen in de agenda en deelnemers uitnodigen.

    1. In de projectgids klikt u op de knop **Maken** naast de vervolgactiviteit **Planningsvergadering**.
        Het dialoogvenster **Vervolgactiviteit** wordt geopend, met het type **Vergadering (intern)** en vooraf ingevulde naam van het project.
    1. Vul de overige gegevens in en [nodig deelnemers uit][2].
    1. Klik op **Opslaan**.

1. Tijdens de vergadering wordt het conferentieprogramma (agenda) bepaald en u wilt een memo maken met deze informatie.

    1. Klik op de knop **Maken** naast **Conferentieprogramma**.
        Het dialoogvenster **Document** wordt geopend, waarin de documentsjabloon **Memo** en de naam van het project al zijn ingevuld.
    1. Vul de overige velden in het dialoogvenster **Document** in.
    1. Klik op de knop **Maken** om de opmerking te maken en op te slaan.

1. Nadat de vergadering heeft plaatsgevonden en het vergaderprogramma is klaar, wilt u dit bevestigen in de projectgids en naar de volgende projectstatus gaan.

    Schakel in de projectgids het selectievakje naast de vervolgactiviteit **Planningsvergadering** in.

    > [!TIP]
    > U kunt dit ook doen vanuit de activiteitenlijst, bijvoorbeeld in het scherm Agenda en Bedrijf.

    1. Het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen** wordt geopend.
    1. In dit dialoogvenster wordt u gevraagd of u het project wilt verplaatsen naar de volgende status: **Wordt uitgevoerd**.
    1. Klik op **Ja** om het project naar de volgende status te verplaatsen.

    > [!NOTE]
    > Het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen** wordt geopend omdat dit voor dit projecttype is gedefinieerd in Instellingen en onderhoud.

### De status Wordt uitgevoerd

1. Alle vervolgactiviteiten en documenten in de status **Gepland** zijn voltooid en u hebt het project verplaatst via het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen**. Dit dialoogvenster wordt weergegeven wanneer u de laatste vervolgactiviteit hebt ingesteld als voltooid. De vervolgactiviteiten en documenten voor deze nieuwe status worden nu weergegeven op het sectietabblad **Projectgids**.

    > [!NOTE]
    > Het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen** wordt alleen geopend wanneer dit gedrag voor dit projecttype is gedefinieerd. Wanneer dit niet het geval is, [verplaats dan het project naar de volgende status](#move-to-next-status).

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

### De status Sluiten

1. Nadat de conferentie klaar is en alle relevante vervolgactiviteiten en documenten met de status **Wordt uitgevoerd** zijn voltooid, gaat u naar de laatste status in de projectgids: **Sluiten**.

    * Klik op **Ja** in het dialoogvenster **Projectgids - het project naar de volgende status verplaatsen**.
        of
    * klik op **Bewerken** op de hoofdkaart **Project**, klik op de pijl rechts van het veld **Status** en selecteer **Sluiten** in de lijst en klik vervolgens op **OK**.

1. U kunt een interne vergadering houden om de gehouden vergadering samen te vatten.

    1. Klik op de knop **Maken** naast de vervolgactiviteit **Evaluatievergadering**, voer de vereiste informatie in en klik op **Opslaan**.
    2. Wanneer de vervolgactiviteitk is voltooid, vinkt u het selectievakje aan.

1. Vervolgens kunt u een evaluatierapport opstellen waarin de vergadering en de evaluatievergadering worden samengevat.

    Klik op **Maken** naast het document **Evaluatierapport** om het document te maken.

Nadat alle vereiste vervolgactiviteiten en documenten voor het project zijn voltooid, kunt u de projectstatus instellen op Voltooid.

## Verwante onderwerpen

* [Het dialoogvenster Document][1]
* [Het dialoogvenster activiteiten][2]
* [Toevoegen en bewerken van de projectgidsen in  Instellingen en onderhoud][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/project/project-guide-create.png
[img2]: ../../../../media/loc/en/project/project-guide-right-click.png

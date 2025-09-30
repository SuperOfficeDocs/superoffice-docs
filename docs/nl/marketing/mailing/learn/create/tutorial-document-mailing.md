---
uid: help-nl-tutorial-document-mailing
title: Zelfstudie - documentmailing maken
description: In deze zelfstudie leert u een documentmailing te maken.
keywords: documentmailing
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Zelfstudie - documentmailing maken

[!include[Tip](includes/tip-mailing-save-draft.md)]

## Stap 1: Setup

> [!TIP]
> Als u een bestaande mailing met document wilt weergeven en afdrukken, sluit u de stap **Instellingen** (klik op **Annuleren** of **Opslaan + sluiten**). Selecteer het tabblad **Mailings**, zoek het document, klik op <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> en selecteer **Weergeven**. Klik op de knop onder **Gegenereerd document downloaden**. Het document wordt gedownload naar uw browser. Open het document en druk het af.

Met gebruik van de workflow voor de mailing met document kunt u een PDF-document genereren om af te drukken en te verzenden naar uw klanten. De eerste stap bij het maken van een mailing met document is **Instellingen**. Hier kunt u de naam van de mailing, de koptekst en de t.a.v.-tekst in het document instellen en de archiveringsopties voor de mailing instellen.

U kunt de mailing met document koppelen aan een bepaald project. Dit kan relevant zijn als u mailings maakt die zijn bestemd voor de projectleden van een SuperOffice CRM-project. Met gebruik van sjabloonvariabelen in de sjabloon kunt u projectgegevens toevoegen aan uw mailing.

U kunt de mailing met document koppelen aan een bepaalde verkoop. Dit kan relevant zijn als u mailings maakt die zijn bestemd voor de verkoopbelanghebbenden van een SuperOffice CRM-verkoop. Met gebruik van sjabloonvariabelen in de sjabloon kunt u verkoopgegevens toevoegen aan uw mailing.

**Stappen:**

1. Voer een naam in het veld **Naam van mailing**.

1. Voer in het veld **Koptekst** de titel van het document in.

1. In het veld **T.a.v.** moet u selecteren aan wie de mailing moet worden gericht. Selecteer een van de volgende opties:

    * **Indien niets gedefinieerd**: Selecteer deze optie om standaard de namen van de ontvangers te gebruiken of, als er geen naam van een ontvanger is gevonden, de ontvanger te gebruiken die u invoert in het tekstveld. Als u een mailing maakt voor de IT-professionals in een bedrijf, kunt u bijvoorbeeld "IT-afdeling" invoeren.

    * **Altijd gebruiken**: Selecteer deze optie om de namen van de ontvangers te overschrijven en alleen de ontvanger te gebruiken die u invoert in het tekstveld.

1. Voer in het veld **Onze ref.** de naam in die als onze referentie moet worden weergegeven in het document. U kunt in dit veld [sjabloonvariabelen][1] van SuperOffice CRM gebruiken.

    > [!NOTE]
    > Als u wilt dat de variabelen zoals verkoop-ID of project-ID goed werken, moet u mailing met document koppelen aan een verkoop of project.

1. Selecteer een map waarin u de mailing wilt plaatsen in de lijst **Mappen**.

    [Hoe maak ik een mailingmap?][3]

1. In de velden **Selectie** en **Project** kunt u de mailing koppelen aan een selectie en/of een project. Begin te typen om te zoeken.

1. Klik op **Volgende** om naar de volgende stap te gaan.

## Stap 2: Sjabloon

[!include[Een sjabloon kiezen](includes/mailing-choose-template.md)]

## Stap 3: Inhoud

Bij de stap **Inhoud** kunt u het uiterlijk en de inhoud van het document bewerken.

1. Klik op de knop **Bewerken**.

1. Klik in het dialoogvenster op **Document downloaden**. Het bestand wordt gedownload naar uw browser.

1. Open het document voor bewerking. In de meeste browsers kunt u op het gedownloade bestand klikken om het te openen in de standaardtoepassing.

1. Bewerk de inhoud van het document.

1. Sla het document op.

1. (indien van toepassing) Klik in SuperOffice Marketing op **Bewerken** om het dialoogvenster opnieuw te openen.

1. Klik op **Bestand selecteren**, selecteer het opgeslagen document en klik op **Geselecteerd bestand uploaden**. De voorbeeldweergave rechts wordt bijgewerkt met de inhoud van het geüploade bestand.

1. Klik op **Volgende** om naar de volgende stap te gaan.

### Sjabloonvariabelen gebruiken

U kunt SuperOffice CRM-[sjabloonvariabelen][3] gebruiken in uw document om klantspecifieke informatie in te voegen. Zo geeft u het bericht een persoonlijke benadering.

## Stap 4: Ontvangers

[!include[Stap 4 ontvangers](includes/step-4-recipients.md)]

## Stap 5: Bevestigen

> [!NOTE]
> Mailings met documenten worden niet daadwerkelijk verzonden wanneer u op **Nu verzenden** klikt. Er wordt een PDF-document gegenereerd dat alle pagina's bevat voor alle personen/bedrijven die u in de mailing hebt geselecteerd als ontvangers. U kunt de PDF [openen en afdrukken](#pdf) vanaf het scherm **Mailing weergeven**.

Bij de laatste stap, **Bevestigen** kunt u een overzicht van de mailing weergeven en controleren of alles juist is. Als er in dit scherm foutberichten worden weergegeven, moeten deze worden opgelost voordat de mailing kan worden verzonden.

> [!NOTE]
> De verzendopties zijn uitgeschakeld als er stappen niet voltooid zijn of als er informatie ontbreekt aan uw mailing. Dit wordt in rood aangegeven.

## De mailing nu verzenden

Klik op **Nu verzenden** om een PDF-document te genereren. Er wordt een PDF-document gegenereerd. De workflow wordt gesloten en u gaat terug naar het tabblad **Mailings**.

Klik op de mailing in de lijst om de [verzendstatus en de statistieken weer te geven][2].

## <a id="pdf"></a>Het document openen en afdrukken

1. Selecteer het tabblad **Mailings**.
1. Zoek het document, klik op <i class="ph ph-list" aria-label="Task menu"></i> en selecteer **Weergeven**.
1. Klik op de knop onder **Gegenereerd document downloaden**. Het document wordt gedownload naar uw browser.
1. Open het document en druk het af.

<!-- Referenced links -->
[2]: ../view-statistics.md
[1]: ../../../editor/learn/index.md#variables
[3]: ../../../learn/create-folder.md

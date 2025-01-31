---
uid: help-no-project-guide-tutorial
title: Veiledning for prosjektguide
description: En gjennomgang av hvordan du bruker prosjektguider.
keywords: prosjektguide, guide, arbeidsflyt, prosjekt
author: Bergfrid Dias
date: 01.31.2025
version: 10
topic: tutorial
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Veiledning for prosjektguide

Husk at prosjektguidene dine kan være konfigurert annerledes i **Innstillinger og vedlikehold**.

## Registrere et nytt prosjekt og velge prosjekttype

Du oppretter et nytt prosjekt og velger prosjekttypen **Konferanse**, som har en tilknyttet prosjektguide. Prosjektguiden inneholder følgende statuser, oppfølginger og dokumenter.

| Statuser | Oppfølginger | Dokumenter |
|---|---|---|
| Planlagt | Planleggingsmøte (Møte inne) | Konferanseprogram (Notat) |
| Under arbeid | Lag liste over prosjektdeltakere (Oppfølging) | Konferanse (Møte ute) |
| Lukking | Evalueringsmøte (Møte inne) | Evalueringsrapport (Notat) |

## Statusen Planlagt

1. Du har avtalt et møtetidspunkt og ønsker å opprette oppfølgingen **Planleggingsmøte** i dagboken og invitere deltakere.

    1. I prosjektguiden klikker du på **Opprett** ved siden av **Planleggingsmøte**.
        Dialogboksen **Oppfølging** åpnes med **Møte inne** som type og prosjektnavnet ferdig utfylt.
    1. Fyll ut informasjonen og [inviter deltakere][1].
    1. Klikk på **Lagre**.

1. På møtet fastsetter dere konferanseprogrammet, og du vil opprette et notat med denne informasjonen.

    1. Klikk på **Opprett** ved siden av **Konferanseprogram**.
        Dialogboksen **Dokument** åpnes med **Notat** som forhåndsvalgt mal og prosjektnavnet ferdig utfylt.
    1. Fyll ut informasjonen i dialogboksen **Dokument**.
    1. Klikk på **Opprett** for å lagre notatet.

1. Etter at møtet er gjennomført og konferanseprogrammet er klart, vil du bekrefte dette i prosjektguiden og gå videre til neste prosjektstatus.

    * I prosjektguiden, merk av i boksen ved siden av **Planleggingsmøte**.

    > [!TIP]
    > Du kan også gjøre dette fra aktivitetslisten i for eksempel Dagbok eller Firma.

    1. Dialogboksen **Prosjektguide – flytt prosjektet til neste status** åpnes.
    1. Klikk på **Ja** for å gå videre til statusen **Under arbeid**.

    > [!NOTE]
    > Denne dialogboksen vises fordi dette er definert for prosjekttypen i **Innstillinger og vedlikehold**.

## Statusen Under arbeid

1. Alle oppfølgingene og dokumentene i **Planlagt**-statusen er fullført, og prosjektet har gått videre via dialogboksen **Prosjektguide – flytt prosjektet til neste status**. Detaljkortet **Prosjektguide** viser nå de nye oppfølgingene og dokumentene.

    > [!NOTE]
    > Hvis dette ikke er definert for prosjekttypen, må du [flytte prosjektet til neste status manuelt][2].

1. På planleggingsmøtet ble dere enige om at en kollega skal lage en liste over konferansedeltakerne. Du vil opprette en oppgave i deres dagbok som en påminnelse.

    1. Klikk på **Opprett** ved siden av **Lag liste over prosjektdeltakere**.
        Dialogboksen **Overfør oppgaven til en prosjektdeltaker** åpnes.

    1. Velg prosjektmedlemmet som skal utføre oppgaven, og klikk på **OK**.

    1. Fyll ut nødvendig informasjon i dialogen og klikk **Lagre**.

    1. Oppfølgingen vises i dagboken til kollegaen din, og når listen er laget, merkes oppfølgingen som **Utført**.

        > [!NOTE]
        > Dialogboksen **Overfør oppgaven til en prosjektdeltaker** åpnes fordi dette er definert i **Innstillinger og vedlikehold**.

1. Nå ønsker du å lage et invitasjonsbrev.

    Klikk på **Opprett** ved siden av dokumentet **Konferanseinvitasjon**, og [opprett dokumentet][3].

1. Til slutt skal selve konferansen avholdes. Du oppretter **Konferanse**-møtet.

    1. Klikk på **Opprett** ved siden av oppfølgingen **Konferanse**.
        Dialogboksen **Oppfølging** åpnes, med **Møte ute** som type og prosjektnavnet ferdig utfylt.
    2. Fyll ut informasjonen og inviter konferansedeltakerne.
    3. Klikk på **Lagre**.

## Statusen Lukking

1. Når konferansen er avholdt og alle relevante oppfølginger og dokumenter i **Under arbeid**-statusen er fullført, går du til siste status i prosjektguiden, **Lukking**.

    * Klikk **Ja** i dialogboksen **Prosjektguide – flytt prosjektet til neste status**.
    * Eller, klikk **Rediger** på hovedkortet **Prosjekt**, klikk på pilen ved siden av **Status**, velg **Lukking**, og klikk **OK**.

1. Du vil arrangere et internt møte for å oppsummere konferansen.

    1. Klikk på **Opprett** ved siden av **Evalueringsmøte**, fyll ut informasjon, og klikk **Lagre**.
    2. Når møtet er utført, merk av i boksen for å angi at det er fullført.

1. Deretter lager du en evalueringsrapport som oppsummerer evalueringsmøtet og konferansen.

    Klikk på **Opprett** ved siden av dokumentet **Evalueringsrapport** for å opprette dokumentet.

Når alle nødvendige oppfølginger og dokumenter for prosjektet er ferdige, kan du sette prosjektstatus til **Fullført**.

<!-- Referenced links -->
[1]: ../../diary/learn/invitation/add-attendee.md
[2]: project-guides.md#change-status
[3]: ../../document/learn/edit.md

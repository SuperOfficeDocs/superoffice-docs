---
uid: help-no-project-guide-working-with
title: Arbeide med prosjektguide
description: Arbeide med prosjektguide
author: SuperOffice RnD
so.date: 07.04.2022
keywords: prosjekt, guide
so.topic: howto
language: no
---

# Arbeide med prosjektguider

Hvis en prosjektveiledning er definert for en prosjekttype som du angir for et prosjekt, skjer følgende:

* Første status i prosjektguiden er valgt i feltet **Status** på hovedkortet **Prosjekt**.

* Oppfølginger og/eller dokumenter for statusen står oppført på detaljkortet **Prosjektguide**.

## Trinn

1. Klikk på knappen **Opprett** foran navnet på oppfølgingen/dokumentet.

   ![Detaljkortet Prosjektguide med oversikt over statuskode Planlagt -screenshot][img1]

1. I dialogboksen som åpnes, [oppretter du oppfølgingen][2] eller [dokumentet][3] på vanlig måte. Mange av feltene er ferdig utfylt, men du kan endre informasjonen eller legge til mer informasjon.

    Du kan delegere oppfølgingen til andre medarbeidere ved å angi dem som eier av oppfølgingen. Hvis dette er definert i Innstillinger og vedlikehold, åpnes dialogboksen **Overfør oppgaven til en prosjektdeltaker**, der du kan velge en medarbeider som eier av oppfølgingen.

1. Når du er ferdig med oppfølgingen, merker du av for **Utført** i den aktuelle dialogboksen, eller i avmerkingsboksen foran oppfølgingsnavnet på detaljkortet **Prosjektguide**. Dokumenter er som standard merket som utført.

    > [!TIP]
    > Hvis du vil opprette flere oppfølginger av samme type, kan du høyreklikke på aktiviteten og velge **Opprett en til**.
    >
    > ![I tabben Prosjektguide kan du høyreklikke og velge Opprett en til -screenshot][img2]

1. Etter at alle oppfølginger og dokumenter i en prosjektstatus er utført, går du til neste status.

    > [!NOTE]
    > Hvis du ønsker det, kan du gå til neste status uten å opprette eller utføre alle oppfølgingene/dokumentene i en status.

1. Gjenta fremgangsmåten ovenfor for alle oppfølginger/dokumenter i hver status i prosjektguiden.

## <a id="move-to-next-status" />Flytt til neste status

Du kan flytte prosjektet til neste status på to måter:

* Slik flytter du prosjektet til neste status automatisk:

    I Innstillinger og vedlikehold kan det angis at prosjektguiden skal foreslå å flytte prosjektet til neste status når den siste oppfølgingen i en status merkes som utført. Da åpnes dialogboksen **Prosjektguide - flytt prosjektet til neste status**.

    Klikk på **Ja** for å flytte prosjektet til neste status, eller klikk på **Nei** for å fortsette å jobbe med prosjektet i samme status.

* Slik flytter du prosjektet til neste status manuelt:

    Høyreklikk på knappen for neste status i detaljkortet **Prosjektguide**, og velg **Gå til denne statusen**.

    Eller gjør følgende på hovedkortet **Prosjekt**:

    1. Klikk på **Rediger** på hovedkortet **Prosjekt**.
    1. Klikk på pilen ved siden av feltet **Status**.
    1. Velg ønsket status fra listen som vises.[!include[SM](../../../learn/includes/are-defined-sm.md)]
    1. Klikk på **Lagre**.

## Eksempel

Husk at prosjektguidene dine kan være konfigurert annerledes i Innstillinger og vedlikehold.

### Registrere et nytt prosjekt og velge prosjekttype

Du registrerer et nytt prosjekt og velger prosjekttypen **Konferanse**, som er tilknyttet en prosjektguide. Prosjektguiden kan for eksempel ha følgende statuser, oppfølginger og dokumenter.

| Status | Oppfølginger | Dokumenter |
|---|---|---|
| Planlagt | Planleggingsmøte (Møte inne) | Konferanseprogram (Notat) |
| Under arbeid | Lag liste over prosjektdeltakere (Oppfølging) | konferanse (Møte ute) |
| Lukking | Evalueringsmøte (Møte inne) |
| Evalueringsrapport (Notat) |

### Statusen Planlagt

1. Du har avtalt møtetidspunktet, og du ønsker å opprette oppfølgingen **Planleggingsmøte** i dagboken og invitere deltakere.

    1. I prosjektguiden klikker du på knappen **Opprett** ved siden av oppfølgingen **Planleggingsmøte**.
        Dialogboksen **Avtale** åpnes, med **Møte inne** angitt som type og navnet på prosjektet ferdig utfylt.
    1. Fyll ut informasjon, og [inviter deltakere][2].
    1. Klikk på **Lagre**.

1. På møtet fastsetter dere konferanseprogrammet (agenda), og du ønsker å opprette et notat som inneholder denne informasjonen.

    1. Klikk på **Opprett**-knappen ved siden av **Konferanseprogram**.
        Dialogboksen **Dokument** åpnes med **Notat** allerede valgt som dokumentmal og navnet på prosjektet ferdig utfylt.
    1. Fyll ut annen informasjon i feltene i dialogboksen **Dokument**.
    1. Klikk på **Opprett**-knappen for å opprette og lagre notatet.

1. Når møtet er gjennomført og konferanseprogrammet er klart, vil du angi dette i prosjektguiden og gå videre til neste prosjektstatus.

    I prosjektguiden merker du av i avmerkingsboksen ved siden av oppfølgingen **Planleggingsmøte**.

    > [!TIP]
    > Du kan også gjøre dette fra aktivitetslisten i for eksempel Dagbok og Firma.

    1. Dialogboksen **Prosjektguide - flytt prosjektet til neste status** åpnes.
    1. I denne dialogboksen får du spørsmål om du vil flytte prosjektet til neste status, som er **Under arbeid**.
    1. Klikk på **Ja** for å flytte prosjektet til neste status.

    > [!NOTE]
    > Dialogboksen **Prosjektguide – flytt prosjektet til neste status** åpnes fordi det er definert for prosjekttypen i Innstillinger og vedlikehold.

### Statusen Under arbeid

1. Alle oppfølgingene og dokumentene i statusen **Planlagt** er utført, og du har flyttet prosjektet ved hjelp av dialogboksen **Prosjektguide – flytt prosjektet til neste status**. Denne dialogboksen vises når du setter den siste oppfølgingen til fullført. Oppfølgingene og dokumentene for den nyeste statusen vises nå på detaljkortet **Prosjektguide**.

    > [!NOTE]
    >Dialogboksen **Prosjektguide – flytt prosjektet til neste status** vises bare hvis dette er definert for prosjekttypen. Hvis dette ikke er definert, [flytter du prosjektet til neste status](#move-to-next-status).

1. På planleggingsmøtet ble dere enige om at kollegaen din skal sette opp listen over deltakerne på konferansen. Du vil opprette en oppgave i dagboken deres som en påminnelse.

    1. Klikk på **Opprett** ved siden av oppfølgingen **Lag liste over prosjektdeltakere**.
        Dialogboksen **Overfør oppgaven til en prosjektdeltaker** vises.

    1. På listen over prosjektdeltakere velger du personen som skal ha ansvaret for oppgaven, og klikker på **OK**.

    1. Fyll ut med ønsket informasjon i dialogen, og klikk til slutt på **Lagre**. (I fanen **Detaljer** kan du se at kollegaen din allerede er angitt som eier av oppgaven.)

    1. Oppfølgingen vises i dagboken til kollegaen din, og når vedkommende er ferdig med å sette opp listen, setter han/hun oppfølgingen til **Utført**.

        > [!NOTE]
        >Dialogboksen **Overfør oppgaven til en prosjektdeltaker** åpnes fordi det er definert i Innstillinger og vedlikehold.

1. Nå ønsker du å lage et invitasjonsbrev.

    Klikk på **Opprett** ved siden av dokumentet **Konferanseinvitasjon**, og [opprett dokumentet][3].

1. Til slutt skal selve konferansen avholdes. Du oppretter **Konferanse**-møtet.

    1. Klikk på **Opprett** ved siden av oppfølgingen **Konferanse**.
        Dialogboksen **Oppfølging** åpnes, med **Møte ute** angitt som type og navnet på prosjektet ferdig utfylt.
    2. Fyll ut informasjon og inviter konferansedeltakerne på vanlig måte.
    3. Klikk på **Lagre**.

### Statusen Avslutning

1. Når konferansen er avholdt og alle relevante oppfølginger og dokumenter i statusen **Under arbeid** er utført, går du til siste status i prosjektguiden, som er **Avslutning**.

    * Klikk på **Ja** i dialogboksen **Prosjektguide - flytt prosjektet til neste status**.
        eller
    * Klikk på **Rediger** på hovedkortet **Prosjekt**, klikk på pilen til høyre for feltet **Status**, velg **Lukking** fra listen, og klikk på **OK**.

1. Du vil arrangere et møte internt for å oppsummere konferansen.

    1. Klikk på **Opprett** ved siden av oppfølgingen **Evalueringsmøte**, fyll ut informasjon, og klikk på **Lagre**.
    2. Når møtet er utført, merker du av i avmerkingsboksen.

1. Deretter lager du en evalueringsrapport som oppsummerer evalueringsmøtet og konferansen.

    Klikk på **Opprett** ved siden av dokumentet **Evalueringsrapport** for å opprette dokumentet.

Når alle ønskede oppfølginger og dokumenter for prosjektet er ferdige, kan du sette prosjektet til utført.

## Aktuelle emner

* [Dialogboksen Dokument][1]
* [Dialogboksen for oppfølginger][2]
* [Legg til og rediger prosjektguider i Innstillinger og vedlikehold][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/project/project-guide-create.png
[img2]: ../../../../media/loc/en/project/project-guide-right-click.png

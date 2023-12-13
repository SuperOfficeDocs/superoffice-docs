---
uid: help-no-working-with-sales-guide
title: Arbeide med salgsguide
description: Arbeide med salgsguide
author: SuperOffice RnD
so.date: 02.16.2023
keywords: salg
so.topic: howto
language: no
---

# Arbeide med salgsguide

Salgsguiden leder deg gjennom de ulike fasene i en forhåndsdefinert salgsprosess, gir automatisk forslag og maler til dokumenter som må opprettes underveis, og fremhever oppfølgingsaktiviteter som må utføres.

Hvis du ikke allerede har gjort det, kan du finne ut hvordan du konfigurerer en salgsguide, her. Du kan bruke SuperOffice Salgsguide eller sette opp din egen.

Se denne videoen for å lære hvor enkelt det er å bruke salgsguiden (videolengde – 1:24):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IyETjAtn3po]

## Atferd når et salg har en guide

* Første fase i salgsguiden er valgt i feltet **Fase** på hovedkortet **Salg**.

* Oppfølginger og/eller dokumenter for fasen står oppført på detaljkortet **Salgsguide**.

## Salgsprosessen

1. Klikk på knappen **Opprett** foran navnet på oppfølgingen/dokumentet.

2. I dialogboksen som åpnes, [oppretter du oppfølgingen][2] eller [dokumentet][3] på vanlig måte. Mange av feltene er ferdig utfylt, men du kan endre informasjonen eller legge til mer informasjon.

3. Når du er ferdig med oppfølgingen, merker du av for **Utført** i den aktuelle dialogboksen, eller i avmerkingsboksen foran oppfølgingsnavnet på detaljkortet **Salgsguide**. Dokumenter er som standard merket som utført.

    > [!TIP]
    > Hvis du vil opprette flere oppfølginger av samme type, kan du høyreklikke på aktiviteten og velge **Opprett en til**.

4. Når alle oppfølginger og dokumenter for en fase er utført, går du til neste fase på hovedkortet **Salg**.

    > [!NOTE]
    > Hvis du ønsker det, kan du gå til neste fase uten å opprette eller utføre alle oppfølgingene/dokumentene i en fase.

5. Gjenta fremgangsmåten over for alle oppfølginger/dokumenter i hver fase av salgsguiden.

## Slik flytter du frem til neste status

Du kan flytte prosjektet til neste status på to måter:

**Fra salgsguiden:**

1. Høyreklikk på knappen for neste status i detaljkortet **Salgsguide**, og velg **Gå til denne statusen**.

**Fra fanen Salg:**

1. Klikk på **Endre** på fanen **Salg**.
2. Klikk på pilen ved siden av feltet **Fase**.
3. Velg ønsket fase fra listen som vises. Med unntak av statusene **Solgt** og **Tapt** blir alternativene på listen definert i Innstillinger og vedlikehold.
4. Klikk på **Lagre**.

## Hvorfor åpnes dialogboksen Salgsguide når jeg merker en oppfølging som utført?

I Innstillinger og vedlikehold kan du angi at en oppfølging i en salgsguide skal foreslås automatisk når foregående oppfølging merkes som utført. Da åpnes dialogboksen **Salgsguide** når du merker forrige oppfølging som utført.

I dialogboksen **Salgsguide** har du tre muligheter:

* Klikk på **Opprett** for å opprette neste oppfølging i salgsguiden. Du kommer direkte til dialogboksen for oppfølgingen.

* Klikk på **Avbryt** hvis du ikke vil opprette oppfølgingen nå. Dialogboksen **Salgsguide** lukkes, og du må selv huske å opprette oppfølgingen senere.

* Merk av for **Alltid opprette oppfølging? Ikke vis denne dialogboksen igjen** hvis du i fremtiden alltid vil opprette den foreslåtte aktiviteten. Da åpnes dialogboksen for oppfølginger automatisk neste gang.

> [!TIP]
> Hvis du vil tilbakestille dette alternativet slik at dialogboksen **Salgsguide** åpnes, går du til ![ikon][img1] **Personlige innstillinger** > **Preferanser** > **Salg** og velger **Ja** for alternativet **Bekreft oppretting av foreslått oppfølging**.

## Eksempel

Husk at salgsguidene dine kan være konfigurert annerledes i Innstillinger og vedlikehold.

### Registrere et nytt salg og velge salgstype

Du registrerer et nytt salg og velger salgstypen **Salg til ny kunde**, som er tilknyttet en salgsguide. Salgsguiden inneholder følgende faser, oppfølginger og dokumenter:

| Fase | Oppfølginger | Dokumenter |
|---|---|---|
| Første møte | Kundemøte (Møte ute) | Møtebekreftelse (e-post) |
| Tilbud | Tilbudsforberedelser (Oppgave) | Tilbud (Brev) |
| Kontraktssignering | Avtale kontraktsmøte (Telefon ut)<br /> Kontraktsmøte (Møte ute) | Signert kontrakt |

### Fasen Første møte

1. Du har avtalt møtetidspunktet, og du vil opprette oppfølgingen **Kundemøte** i dagboken og invitere deltakere.

    1. I prosjektguiden klikker du på **Opprett** ved siden av oppfølgingen **Kundemøte**.
        Dialogboksen **Oppfølging** åpnes, med **Møte ute** angitt som type og navnet på salget og firmaet ferdig utfylt.
    2. Fyll ut informasjon, og [inviter deltakere][1].
    3. Klikk på **Lagre**.

2. For ordens skyld ønsker du å sende en e-post der du bekrefter møtetidspunkt og møtested.

    1. Klikk på **Opprett** ved siden av **Møtebekreftelse**.
        Dialogboksen **Dokument** åpnes, der **E-post** allerede er valgt som dokumenttype, og navnet på firmaet og salget er ferdig utfylt.
    2. Fyll ut annen informasjon i feltene i dialogboksen **Dokument**.
    3. Klikk på knappen **Opprett** for å opprette og sende e-posten.

3. Etter at møtet har funnet sted, ønsker du å bekrefte dette i salgsguiden.

    I salgsguiden merker du av i avmerkingsboksen ved siden av oppfølgingen **Kundemøte**.

    > [!TIP]
    > Du kan også gjøre dette fra aktivitetslisten i for eksempel Dagbok og Firma.

### Tilbudsfasen

1. Alle oppfølgingene og dokumentene i fasen **Første møte** er utført, og du vil gå til neste fase av salgsguiden.

    1. Klikk på **Rediger**-knappen på hovedkortet **Salg**.
    2. Klikk på pilen ved siden av feltet **Fase** og velg **Tilbud** fra listen.
    3. Klikk på **Lagre**.
        Oppfølgingene og dokumentene for den nyeste fasen vises nå på detaljkortet **Salgsguide**.

    > [!TIP]
    > Du kan også høyreklikke på knappen **Tilbud** på detaljkortet **Salgsguide** og velge **Gå til denne fasen**.

2. Du vil opprette en oppgave i dagboken din som minner deg på at du må utarbeide et tilbud.

    1. Klikk på **Opprett** ved siden av oppfølgingen **Tilbudsforberedelse**.
        Dialogboksen **Oppgave** vises med **Oppfølging** angitt som oppgavetype.
    2. Fyll ut informasjon.
    3. Klikk på **Lagre**.
    4. Når du har utarbeidet innholdet i tilbudet, setter du aktiviteten til **Utført**.

3. Nå ønsker du å opprette tilbudet til firmaet.

    Klikk på **Opprett** ved siden av dokumentet **Tilbud**, og [opprett dokumentet][3].

### Fasen Kontraktssignering

1. Når alle oppfølgingene og dokumentene du ønsker å bruke i fasen **Tilbud**, er utført, går du til siste fase i salgsguiden, som er **Kontraktssignering**.

    1. Klikk på **Rediger**-knappen på hovedkortet **Salg**.
    2. Klikk på pilen til høyre for feltet **Fase** og velg **Kontraktssignering** fra listen.
    3. Klikk på **Lagre**.
        Oppfølgingene og dokumentene for denne fasen vises nå på detaljkortet **Salgsguide**.

2. Du ønsker å opprette og utføre den første oppfølgingen i fasen.

    1. Klikk på **Opprett** ved siden av telefonsamtalen **Avtal kontraktsmøte**, og opprett samtalen på vanlig måte.

    2. Når samtalen er fullført, merker du av i boksen.

    3. I dialogboksen **Salgsguide** har du tre muligheter:

        * Klikk på **Opprett** for å opprette oppfølgingen **Kontraktsmøte**, som er neste oppfølging i salgsguiden. Du kommer direkte til dialogboksen for oppfølgingen.

        * Klikk på **Avbryt** hvis du ikke vil opprette oppfølgingen nå. Dialogboksen **Salgsguide** lukkes, og du må selv huske å opprette oppfølgingen senere.

        * Merk av for **Alltid opprette oppfølging? Ikke vis denne dialogboksen igjen** hvis du i fremtiden alltid vil opprette den foreslåtte aktiviteten. Da åpnes dialogboksen for oppfølginger automatisk neste gang.

    > [!NOTE]
    > Dialogboksen **Salgsguide** åpnes fordi det er definert **Foreslå denne oppfølgingen automatisk** for oppfølgingen **Kontraktsmøte** i Innstillinger og vedlikehold. Du kan velge at denne dialogboksen ikke skal vises, slik at neste oppfølging foreslås automatisk.

3. Du vil opprette oppfølgingen **Kontraktsmøte** fra dialogboksen **Salgsguide**.

    Klikk på **Opprett** i dialogboksen **Salgsguide**.
    Dialogboksen **Oppfølging** åpnes, der du kan opprette møtet på vanlig måte.

4. Deretter ønsker du å opprette kontrakten du skal ha med på møtet.

    1. Klikk på **Opprett** ved siden av dokumentet **Signert kontrakt** for å opprette kontrakten.
    2. Når kontraktsmøtet er gjennomført og kontrakten underskrevet, merker du oppfølgingen **Kontraktsmøte** som utført.

Nå kan du endre fasen til **Solgt**. Når alle ønskede oppfølginger og dokumenter for salget er utført, kan du sette salget til utført.

> [!TIP]
> Hvis du vil at salget fortsatt skal være synlig i for eksempel detaljkortet **Aktiviteter** i Salg-bildet og detaljkortet **Salg** i Dagbok-bildet, må du ikke sette salget til utført.

## Relatert

* [Sette opp en salgsguide i Innstillinger og vedlikehold][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/personal-settings-small.png

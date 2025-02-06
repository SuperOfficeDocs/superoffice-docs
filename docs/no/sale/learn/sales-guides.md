---
uid: help-no-sales-guide
title: Salgsguide
description: Introduksjon til salgsguider i SuperOffice. Hvordan strukturere og standardisere salgsrutinene. Salgsguiden leder deg gjennom de ulike fasene i en forhåndsdefinert salgsprosess, gir automatisk forslag og maler til dokumenter som må opprettes underveis, og fremhever oppfølgingsaktiviteter som må utføres.
keywords: salgsguide, guide, arbeidsflyt, detaljkortet Salgsguide, salg
author: Bergfrid Dias
date: 02.03.2025
version: 10.5.2
topic: concept
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Salgsguide

Salgsguider i SuperOffice CRM er kraftige verktøy som forenkler og standardiserer salgsprosessen ved å koble salgstyper til forhåndsdefinerte faser. Hver fase inkluderer forslag til oppfølginger og dokumenter, noe som hjelper selgere med å følge en strukturert salgsprosess. Dette sikrer at ingen muligheter går tapt og gir økt konsistens i teamet.

> [!NOTE]
> Denne funksjonen krever lisensen Sales Premium.

## Hva er en salgsguide?

En salgsguide består av:

* **Faser:** Forhåndsdefinerte trinn i salgsprosessen, som Første møte, Tilbud eller Kontraktssignering. Hver fase har et navn, en sannsynlighetsprosent og en beskrivelse.
* **Oppfølginger:** Handlinger som møter eller telefonsamtaler knyttet til hver fase.
* **Dokumenter:** Maler for tilbud, kontrakter eller e-poster som er relevante for salgsprosessen.

Når du oppretter et salg eller oppdaterer salgstypen til en med en tilknyttet salgsguide, aktiveres guiden automatisk i detaljkortet **Salgsguide**. Dette kortet gir en oversikt over faser, oppfølginger og dokumenter for salget.

**Eksempel:**

En salgstype for nye kunder kan ha følgende faser:

* **Første møte:** Oppfølging med møte og introduksjons-e-post.
* **Tilbud:** Utarbeidelse og utsending av tilbud.
* **Kontraktssignering:** Signering av kontrakt og planlegging av videre oppfølginger.

Salgsguider settes opp i Innstillinger og vedlikehold og kan tilpasses etter organisasjonens arbeidsprosesser.

## Hvordan fungerer en salgsguide?

Se denne videoen for å lære hvor enkelt det er å bruke salgsguiden:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IyETjAtn3po]

(videolengde – 1:24)

### Trinn

1. **Start med en fase:** Når du oppretter eller oppdaterer et salg med en tilknyttet salgsguide, settes den første fasen automatisk. Detaljkortet **Salgsguide** viser oppfølgingene og dokumentene som er knyttet til fasen.

1. **Opprett aktiviteter:** Oppfølginger og dokumenter kan opprettes direkte fra detaljkortet **Salgsguide**:
    * Klikk på **Opprett** ved siden av oppfølgingen eller dokumentet.
    * Fullfør feltene i dialogen og lagre.

    > [!TIP]
    > Tildel oppfølginger til spesifikke teammedlemmer for bedre samarbeid.

1. **Marker oppgaver som utført:** Etter at en aktivitet er gjennomført, merk av i boksen ved siden av navnet i detaljkortet **Salgsguide**. Dokumenter markeres automatisk som utført når de opprettes.

    Utførte oppgaver vises også i detaljkortet **Aktiviteter**.

1. **Gå videre til neste fase:** Når alle aktiviteter for en fase er fullført eller etter behov:
    * Flytt salget manuelt til neste fase, eller la det skje automatisk (hvis aktivert).
    * Guiden oppdateres med forslag til oppfølginger og dokumenter for den nye fasen.

1. **Gjenta til salget er fullført:** Arbeid deg gjennom fasene til salget er markert som **Solgt** eller **Tapt**.

> [!NOTE]
> Du kan gå til neste fase uten å fullføre alle oppfølginger for den gjeldende fasen.

## <a id="sales-guide-tab"></a>Detaljkortet Salgsguide

Detaljkortet **Salgsguide** gir en visuell og funksjonell oversikt over salgsprosessen, slik at selgere enkelt kan spore fremdrift og administrere oppgaver.

![Detaljkortet Salgsguide -screenshot][img1]

### Hovedkomponenter

* **Faseknapper:** Øverst vises knappene for de forhåndsdefinerte fasene, som Første møte, Tilbud og Kontraktssignering.

    ![Faser i salgsguide -screenshot][img2]

  * **Gjeldende fase:** Markert med en fylt sirkel (<i class="ph ph-fill ph-circle" aria-hidden="true"></i>).
  * **Fremtidige faser:** Markert med en åpen sirkel (<i class="ph ph-circle" aria-hidden="true"></i>).
  * **Fullførte faser:** Markert med en hake (<i class="ph ph-check" aria-hidden="true"></i>).

* **Aktiviteter:** Kortet er delt i to kolonner: **Oppfølginger** og **Dokumenter**. Hver rad har en **Opprett**-lenke, som lar brukeren generere den nødvendige oppfølgingen eller dokumentet direkte.

    > [!TIP]
    > Bruk avkrysningsboksen **Vis alle faser** for å se alle aktiviteter og dokumenter på tvers av faser.

## Opprett en oppfølging eller et dokument

Slik oppretter du en oppfølging eller et dokument knyttet til en salgsguide:

1. Gå til detaljkortet **Salgsguide**.
1. Finn oppfølgingen eller dokumentet under gjeldende fase.
1. Klikk på **Opprett** ved siden av elementet.

   * For oppfølginger åpnes [Oppfølgingsdialogen][6] med forhåndsutfylte felter basert på innstillingene i salgsguiden. Juster om nødvendig, og klikk **Lagre**.

   * For dokumenter åpnes [Dokumentdialogen][7] med en forhåndsvalgt mal. Fullfør nødvendige felter og klikk **Lagre**.

> [!TIP]
> Du kan opprette flere oppfølginger eller dokumenter av samme type ved å høyreklikke på elementet og velge **Opprett en til**.

## Marker en oppfølging som utført

1. I detaljkortet **Salgsguide** finner du oppfølgingen.
1. Merk av i boksen ved siden av oppfølgingens navn. Oppgaven markeres som utført og vises som ferdig i detaljkortet **Aktiviteter**.

Dokumenter markeres automatisk som utført når de opprettes.

### Hvorfor åpnes Salgsguide-dialogen når jeg fullfører en oppfølging?

I Innstillinger og vedlikehold kan du angi at en oppfølging i en salgsguide skal foreslås automatisk når den foregående oppfølgingen er utført. Da åpnes dialogen **Salgsguide** når du markerer forrige oppfølging som utført.

I **Salgsguide**-dialogen har du tre alternativer:

* Klikk på **Opprett** for å opprette neste oppfølging i salgsguiden. Du kommer direkte til oppfølgingsdialogen.
* Klikk på **Avbryt** hvis du ikke vil opprette oppfølgingen nå. Dialogen lukkes, og du må huske å opprette oppfølgingen senere.
* Merk av for **Alltid opprette oppfølging? Ikke vis denne dialogen igjen** hvis du alltid vil opprette den foreslåtte oppfølgingen fremover. Oppfølgingsdialogen åpnes da automatisk neste gang.

> [!TIP]
> For å tilbakestille dette valget, slik at **Salgsguide**-dialogen åpnes igjen, går du til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **Preferanser** > **Salg** og velger **Ja** for alternativet **Bekreft oppretting av foreslått oppfølging**.

## <a id="change-stage"></a>Gå til neste fase

Salgsguider støtter både manuell og automatisk progresjon gjennom faser:

### Automatisk faseprogresjon

Hvis aktivert, foreslås neste fase automatisk når alle nødvendige oppfølginger og dokumenter i gjeldende fase er markert som utført.

![Automatisk faseprogresjon -screenshot][img3]

1. Fullfør alle nødvendige oppfølginger og dokumenter for gjeldende fase.
1. Når dialogen vises, klikk **Ja** for å gå til neste fase eller **Nei** for å bli værende.

> [!NOTE]
> Automatisk progresjon må være aktivert i **Innstillinger og vedlikehold** for at denne funksjonen skal fungere.

### Manuell faseprogresjon

Du kan manuelt flytte salget til neste fase, uten å fullføre alle oppfølginger og dokumenter i gjeldende fase.

1. Høyreklikk på knappen for ønsket fase i detaljkortet **Salgsguide**.
1. Velg **Gå til denne fasen** fra menyen.

Alternativt:

1. Klikk på <i class="ph ph-pencil-simple" aria-label="Rediger"></i> på salgskortet.
1. Bruk **Fase**-listen til å velge neste fase.
1. Klikk **Lagre**.

> [!TIP]
> Du kan også gå tilbake til en tidligere fase ved å følge samme trinn.

## Relatert innhold

* [Introduksjon til salg][1]
* [Opprette et salg][2]
* [Arbeide med salgsguide][3]
* [Opprette en ny salgsguide][4]
* [Redigere eller deaktivere en salgsguide][5]

<!-- Refererte lenker -->
[1]: index.md
[2]: create.md
[3]: tutorial.md
[4]: ../admin/create-sales-guide.md
[5]: ../admin/edit-sales-guide.md
[6]: ../../diary/learn/create-follow-up.md
[7]: ../../document/learn/edit.md

<!-- Refererte bilder -->
[img1]: ../../../media/loc/en/sale/sales-guide-tab.png
[img2]: ../../../media/loc/en/sale/guide-stages.png
[img3]: ../../../media/loc/en/sale/goto-next-stage.png

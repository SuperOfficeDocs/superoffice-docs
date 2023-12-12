---
uid: help-da-preferences
title: Præferencer
description: "Administratorer kan indstille præferencer for forskellige funktioner i systemet for bestemte brugere, brugergrupper eller for hele SuperOffice CRM (globale præferencer)."
author: Bergfrid Dias
so.date: 03.21.2023
keywords: indstillinger, præferencer
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Præferencer

På skærmbilledet Præferencer kan du angive præferencer for hele systemet (globalt), én database, én brugergruppe eller en individuel bruger. Præferencer, der kun kan angives på globalt (system)niveau, findes under fanen **[Globale præferencer][1]**.

Brugerne kan redigere indstillingerne for [individuelle præferencer][4] for at tilpasse dem til egen brug ved at gå til **Personlige indstillinger** > **Præferencer** i toplinjen. Hvilke præferencer der vises for brugeren, afhænger af, hvad der er angivet i Indstillinger og vedligeholdelse.

Derudover kan du konfigurere videomøder under fanen [Videomøder][8] og dokumentbiblioteket under fanen [Dokumentbibliotek][9].

## <a id="levels" />Niveauer for præferenceindstillinger

Præferenceindstillinger kan angives for fire forskellige niveauer:

| Niveau | Beskrivelse |
|---|---|
| System | Globale præferencer, der gælder for alle brugerne i systemet, herunder alle satellitter, grupper og enkeltbrugere. |
| Database | Præferencer, der gælder for én bestemt database, og alle grupper og brugere, der er tilknyttet denne database. |
| Gruppe | Præferencer, der gælder for alle brugerne i en bestemt gruppe. |
| Bruger | Præferencer, der er knyttet til hver enkelt bruger. |

Du kan angive forskellige værdier for forskellige niveauer således, at du for eksempel kan have én indstilling for en bruger og en anden for den brugergruppe, som personen tilhører. Det er altid det laveste niveau, der gælder.

> [!NOTE]
> Ikke alle niveauer er tilgængelige for alle præferencer. Hvis en eller flere af indstillingerne er deaktiveret, kan du ikke vælge dette for denne præference.

Du kan vælge, hvilke indstillinger der skal vises på listen, baseret på det niveau, de er angivet for, i feltet **Aktive indstillinger**. De viste niveauer afhænger af, hvilke niveauer du markerer nederst i feltet. Du kan bruge disse afkrydsningsfelter til at vise et, to eller alle niveauer.

> [!NOTE]
> Indstillinger for systemniveauet vises altid.

## <a id="global" />Globale præferencer (for hele systemet)

Nogle [præferencer][1] kan kun indstilles på globalt niveau:

* Statistik
* Funktioner
* E-mail
* Grupperede lister
* Marketing
* Mobile CRM
* Salg
* SuperOffice Service-systemindstillinger
* System
* SMS-konfiguration
* Adgangskodepolitik for Customer Centre

### Ændring af globale præferencer

Hvis du vil redigere disse indstillinger, skal du gå til skærmbilledet ![icon][img1] **Præferencer** og vælge fanen **Globale præferencer**.

* De forskellige præferencer er opdelt i sektioner.
* Hold musemarkøren over en præference for at få vist yderligere oplysninger.
* Klik på **Gem** for at implementere ændringerne.

## <a id="preferences-tab" />Fanen Præferencer

På fanen **Præferencer** kan du angive indstillinger for forskellige dele af SuperOffice CRM, f.eks. antallet af elementer, der skal vises på historiklisten, standardtypen for nytt møde og standardvalutaen på skærmbilledet Salg.

Øverst på fanen **Præferencer** kan du vælge den ønskede præferencegruppe. Resten af fanen **Præferencer** er opdelt i tre hovedafsnit: en liste over alle præferencer, et beskrivelsesfelt, der forklarer beskrivelsen af den aktuelt valgte præference, og et felt, der viser de indstillinger, der er angivet for denne præference.

### Listen Præferencer

Til venstre finder du listen **Præferencer**, som indeholder alle de præferencer, der er defineret for den aktuelle præferencegruppe.

**Grupper af præferencer:**

* Kontaktperson
* Standardværdier
* Dagbog
* E-mail
* Dialogboksen Filter
* Fritekstsøgning
* Funktioner
* Grupperede lister
* Kommunikation i appen
* Marketing
* Meddelelser via e-mail + popup + SMS
* Sag
* Salg
* Sortering
* System
* Værktøjstip
* Visuelle effekter
* Webserver
* Web Services

> [!NOTE]
> Præferencer med aktive individuelle indstillinger vises med fed skrift.

### Aktive indstillinger

Feltet **Aktive indstillinger** viser de indstillinger, der er angivet for den præference, som er markeret på listen **Præferencer**, samt niveauerne og værdierne for hver af dem. Du kan redigere og slette eksisterende indstillinger og tilføje nye i dette felt.

Feltet består af tre kolonner:

| Kolonne | Beskrivelse |
|---|---|
| Hvem | Viser, hvem indstillingen gælder for (navnet på systemet, databasen, gruppen eller brugeren). Hvis dette er en individuel bruger, vises et værktøjstip om denne bruger, når du holder musemarkøren over brugerens initialer i denne kolonne. |
| Niveau | Viser, hvilket [niveau indstillingen gælder for](#levels) (navnet på systemet, databasen, gruppen eller brugeren). |
| Værdi | Viser den værdi, der er angivet for indstillingen. |

Indholdet af disse kolonner er defineret i dialogboksen **Indstilling**. [Sådan tilføjes præferenceindstillinger][3].

Du kan sortere rækkerne i kolonnerne ved at klikke på den ønskede kolonneoverskrift. Klik på kolonneoverskriften onc for at sortere i omvendt rækkefølge.

<!-- Referenced links -->
[1]: global-preferences/system.md
[3]: update-preferences.md
[4]: update-preferences.md#personal
[8]: video-meetings/index.md
[9]: document-library/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-preferences-active.png

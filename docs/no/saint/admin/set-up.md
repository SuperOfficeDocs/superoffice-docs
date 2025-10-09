---
uid: help-no-saint-setup
title: Sett opp ny aktivitetsovervåkning
description: Sett opp ny aktivitetsovervåkning
keywords: SAINT, aktivitetsovervåkning, statusovervåkning
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
index: true
redirect_from: 
  - /no/sale/saint/learn/admin/create-status
  - /no/sale/saint/learn/admin/select-image-for-status
  - /no/saint/admin/select-image-for-status
  - /no/saint/admin/create-status
---

# Sett opp ny aktivitetsovervåkning

[!include[Requirement](../includes/note-saint-req.md)]

Med statusovervåkingen ser du enkelt alle kundene som må vies oppmerksomhet.

For å opprette en status definerer du navnet og beskrivelsen, legger til minst ett kriterium, og setter eventuelt en prioritet, standard oppfølgingstype eller bilde. Trinnene nedenfor viser hele prosessen.

## Trinn

1. Åpne **SAINT**-skjermen i Innstillinger og vedlikehold, og velg fanen **Firma**, **Person** eller **Prosjekt**.

1. Klikk **Legg til** under listen **Statusovervåkning**.

1. I dialogboksen fyller du ut disse feltene:

    * **Navn:** Angi et beskrivende navn på statusen du vil legge til.
        Valgfritt: Klikk <i class="ph ph-translate" aria-label="Translate"></i> for å [legge til oversettelser][8] av statusnavnet.

    * **Beskrivelse:** Angi en klar beskrivelse av statusen og hvilken handling som kreves eller anbefales. Du kan også bruke [malvariabler][9] for å skreddersy teksten til firmaet, personen eller prosjektet.

    ![Ny statusovervåkingsdialog -screenshot][img1]

    Navnet og beskrivelsen vises i SuperOffice CRM når brukeren holder musepekeren over statusbildet eller åpner statusdialogen. Du kan senere redigere beskrivelsen.

1. Klikk **Lagre**. Velg deretter den nye statusen i listen for å fortsette med oppsettet.

1. **Angi kriterier for statusen:**

    1. Under kriterielisten velger du **Legg til** for å sette inn et nytt kriterium.
    1. Velg en kriteriumtype, sett betingelsen og angi en verdi.

    ![Kriterieliste med flere betingelser definert og Legg til-knappen under listen -screenshot][img3]

    Hver status må inneholde minst ett kriterium. Gjenta etter behov for å legge til flere.

1. *(Valgfritt)* [Definer en standard oppfølgingstype][2] for statusen i fanen **Opprett oppfølging**.

1. *(Valgfritt)* [Velg et bilde for å visualisere statusen](#image).

1. Hvis det er flere statuser i listen, sett **prioritet** for å kontrollere hvilket statusbilde som vises på kortet.
    Et firma, en person eller et prosjekt kan samsvare med kriteriene for flere statuser, men bare ett bilde kan vises.
    Velg en status og bruk pilknappene under listen for å flytte den opp eller ned.

    ![Liste over statusovervåkinger med prioriteringer -screenshot][img2]

1. Når du er ferdig, velg <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Regenerer valgt statusovervåkning** for å aktivere statusen.

## <a id="image"></a>Velge et bilde for en status

Du kan legge til et bilde som skal vises på firma-, person- eller prosjektkort som oppfyller statuskriteriene. Bildet vises som et lett vannmerke (40% gjennomsiktighet) slik at det ikke skjuler annet innhold.

Å legge til et bilde er valgfritt. Det kan bidra til å tiltrekke oppmerksomhet og symbolisere typen oppfølgingshandling du ønsker at brukerne skal utføre. Hvis du bare vil bruke statusen for søk eller utvalg, kan du la den være uten bilde.

1. I statuslisten velger du ønsket status.
1. På høyre side av skjermen merker du av for **Visualiser** for å vise bildet.
1. Velg **Endre bilde**.
1. Gjør ett av følgende:
    * Velg et av de eksisterende bildene fra **Bilder**-listen.
    * Velg **Legg til**, last opp en fil, skriv inn en beskrivelse og velg **Lagre**.
1. Velg **OK** for å bekrefte.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Bruk enkle, lysfarget bilder som representerer statusen på en meningsfull måte. For eksempel kan et edderkoppnett symbolisere inaktivitet.

## Bruk malvariabler i beskrivelser

Du kan bruke malvariabler i feltet **Beskrivelse** for å tilpasse teksten som vises i oppfølginger eller statusdialoger. Variabler erstattes med informasjon fra firmaet, personen eller prosjektet.

### Eksempel

En status kan for eksempel gjelde for firmaer som oppfyller følgende kriterier:

* Kategori = Kunde
* Siste salg er mer enn 2 måneder gammelt
* Antall salg større enn 50

Teksten i feltet **Beskrivelse** kan da være:

"&lt;name&gt; har tidligere vært en god kunde, men vi har ikke solgt noe til dem på 2 måneder. &lt;cont&gt; er hovedkontakten for denne kunden og bør ta kontakt med kunden snart per telefon (&lt;cpho&gt;) eller e-post (&lt;mail&gt;) for å finne ut hvorfor."

I dette eksemplet brukes følgende malvariabler:

| Variabel | Beskrivelse |
|---|---|
| name | Navnet på firmaet |
| cont | Navnet på vår kontakt for firmaet |
| cpho | Firmaets telefonnummer |
| mail | Firmaets e-postadresse |

## Aktuelt innhold

* [Oppdater, slett og gjenopprett statusovervåkning][2]
* [Tellere og tellerinnstillinger (periode)][7]
* [Regenerer statusovervåkning og tellere][4]

<!-- Referenced links -->
[2]: update.md
[4]: update.md#regen
[7]: counter-settings.md
[8]: ../../localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/new-status-monitor.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
[img3]: ../../../media/loc/en/saint/criteria.png

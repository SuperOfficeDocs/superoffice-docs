---
uid: help-no-basics-delete
title: Slette elementer
description: "Hvordan slå sammen, slette og gjenopprette elementer."
author: SuperOffice RnD
so.date: 03.07.2023
keywords: slette, gjenopprette, papirkurv
so.topic: howto
language: no
---

# Slette og gjenopprette elementer

For å være effektiv i arbeidet med kunder og personer, er det viktig å ha et ryddig miljø. Når du legger til nye firma og personer, må du dobbeltsjekke at de ikke er lagt til fra før. Og selvfølgelig, sørg for at du legger til riktig informasjon om firma og personer. Slett også ubrukte firma og personer og slå sammen duplikater.

## Slå sammen firma og personer

Hvis du finner duplisert informasjon, kan du slå dem sammen så snart som mulig for å sikre at det er lettere å finne riktig firma og person. Du kan også flytte en person hvis de er lagt til på feil firmakort. Dette er for å forhindre duplikater i fremtiden.

> [!NOTE]
> Denne funksjonaliteten krever brukerrettigheter, så kontakt administrator for å få tilstrekkelige funksjonsrettigheter.

**Oppgaver:**

* [Slå sammen personer][4]
* [Flytt person][5]
* [Slå sammen firmaer][1]

## Slette firma og personer

Når du har lagt til feil eller duplisert informasjon, kan det være lurt å slette en person. Det er flere måter å gjøre dette på:

* [Slette et firma og tilknyttede data][2]
* [Slette en person][3]
* [Massesletting av personer og/eller firma med valg][6]

Når du velger å slette noe i SuperOffice CRM, viser dialogboksen **Slett oppfølging**, **Slett salg**, **Slett utvalg** og så videre,avhengig av hva du har valgt å slette. Navnet på elementet vises i dialogboksen, slik at du kan sjekke at du har gjort riktig valg.

Når du har mange personer eller firmaer du må slette, er den beste måten å masseslette dem på, å legge dem til i et nytt utvalg og bruke Slett oppgaver på Oppgave-menyen. På utvalget klikker du på Oppgave-knappen og velger en av de ønskede Slett-funksjonene.

### Hvorfor er Slett-knappen deaktivert (grå)?

Hvis **Slett**-knappen er deaktivert (lys grå), betyr det at du ikke har rettigheter til å slette dette bestemte elementet.

Eksempler:

* Du kan ikke slette en person som også er ansatt i et SuperOffice-firma.
* Du kan ikke slette oppfølginger, dokumenter, salg, prosjekter og så videre som ikke tilhører deg, med mindre du har tilstrekkelige brukerrettigheter.

## <a id="restore" />Gjenopprette slettede firma og personer

Når du har slettet noe som ikke var ment å bli slettet for firmaer og personer, kan du fortsatt gjenopprette dem fra papirkurven. Dette gjør det mindre skummelt å slette, når du vet at du fortsatt har et alternativ for gjenoppretting.

![Du kan gjenopprette slettede elementer fra papirkurven i menyen Personlige innstillinger -screenshot][img3]

Slettede firma og personer oppbevares som standard i papirkurven i 14 dager. Etter denne perioden slettes de permanent.

Du har også muligheten til å gjenopprette andre brukeres slettede firma og personer, bare sett Vis slettede firma for alle brukere PÅ.

1. Velg ![icon][img1] **Personlige innstillinger** > **Papirkurv**.

2. I dialogboksen velger du fanen **Firma** eller **Person**. Firma og personer som ble slettet av deg, vises.

3. Valgfritt: Velg **Vis slettede firmaer/personer for alle brukere**. Dette alternativet krever funksjonelle rettigheter.

4. Velg firmaene eller personene du vil gjenopprette.
    * Gjenoppretting av et firma gjenoppretter også alle personene som er tilknyttet dette firmaet.
    * Gjenoppretting av en person der firmaet også ble slettet, vil gjenopprette firmaet og den valgte personen.

    ![Gjenopprette firma og personer fra papirkurven -screenshot][img2]

5. Klikk på **Gjenopprett**. Firmaene og personene gjenopprettes i SuperOffice.

## Knapper

| Knapp | Effekt |
|---|---|
| Ja | Bekrefter sletting av ett element om gangen. |
| Ja til alle | Bekrefter sletting av alle valgte elementer. Hvis du for eksempel valgte fem elementer for sletting, vil denne knappen slette dem alle automatisk. |
| Nei | Avbryter sletting av ett element om gangen. Dialogboksen lukkes uten at noe slettes. |
| Avbryt | Avbryter sletting av alle valgte elementer. Dialogboksen lukkes uten at noe slettes. |

* Du kan velge at denne dialogboksen ikke skal vises, ved å: Merke av for **Ikke vis denne dialogboksen igjen** nederst i dialogboksen for sletting.
* Du kan aktivere denne dialogboksen igjen, ved å: Gå til ![icon][img1] **Personlige innstillinger** > **Preferanser** > **Funksjoner** og sette alternativet**Vis bekreftelsesdialogboks** til **Nei**.

> [!NOTE]
> Når du sletter et firma, et utvalg eller et prosjekt, blir du alltid bedt om å bekrefte slettingen, og alternativet **Ikke vis denne dialogboksen igjen** er ikke tilgjengelig.

## Aktuelt innhold

* [Stoppe repeterende oppfølginger][6]
* [Masseslette personer og firma fra utvalg][7]
* [Finn og utvalg][8]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../company/learn/delete.md
[3]: ../../contact/learn/delete.md
[4]: ../../contact/learn/merge-contacts.md
[5]: ../../contact/learn/move.md

[6]: ../../diary/learn/recurrence/stop.md
[7]: ../../search-options/selection/learn/howto/mass-delete.md
[8]: ../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/personal-settings-small.png
[img2]: ../../../media/loc/en/learn/recycle-bin.png
[img3]: ../../../media/loc/en/learn/recycle-bin-personal-settings.png

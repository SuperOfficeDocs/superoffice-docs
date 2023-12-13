---
uid: help-da-basics-delete
title: Sletning af elementer
description: "Sådan flettes, slettes og gendannes elementer."
author: SuperOffice RnD
so.date: 03.07.2023
keywords: slette, genoprette, papirkurv
so.topic: howto
language: da
---

# Slet og gendan elementer

For at være effektiv i arbejdet med kunder og kontakter er det vigtigt at have et miljø uden rod. Når du tilføjer nye firmaer og kontakter, skal du dobbelttjekke, at de ikke er tilføjet før. Og selvfølgelig skal du sørge for at tilføje korrekte oplysninger om virksomheder og kontakter. Det betyder også at slette ubrugte firmaer og personer og flette dubletter.

## Flet firmaer og kontaktpersoner

Hvis du finder duplikerede oplysninger, skal du flette dem så hurtigt som muligt for at sikre, at det er lettere at finde det rigtige firma og person. Du kan også flytte en person, hvis vedkommende er tilføjet på det forkerte firmakort. Dette er for at forhindre dubletter i fremtiden.

> [!NOTE]
> Denne funktionalitet kræver brugerrettigheder, så kontakt din administrator for at få tilstrækkelige funktionelle rettigheder.

**Opgaver:**

* [Flette kontaktpersoner][4]
* [Flyt kontaktperson][5]
* [Flet kontakter][1]

## Slet firma og kontaktpersoner

Når du har tilføjet forkerte eller duplikerede oplysninger, kan det være en god ide at slette en kontaktperson. Der er flere måder at gøre dette på:

* [Slet et firma med tilhørende data][2]
* [Slet en person][3]
* [Massesletning af personer og/eller firmaer med valg][6]

Når du vælger at slette noget i SuperOffice CRM, åbnes dialogboksene **Slet opfølging**, **Slet salg**, **Slet udvalg** osv., afhængigt af hvad du ønsker at slette. Dialogboksen viser blandt andet navnet på elementet, så du kan kontrollere, at du har valgt det rigtige element til sletning.

Når du har mange personer eller firmaer, du skal slette, er den bedste måde at masseslette dem på at føje dem til en ny markering og bruge Slet opgaver i menuen Opgave. Ved valget skal du klikke på knappen Task og vælge en af de ønskede Slet-funktioner.

### Hvorfor er knappen Slet deaktiveret (grå)?

Hvis knappen **Slet** er deaktiveret (lysegrå), betyder det, at du ikke har rettigheder til at slette netop dette element.

Eksempler:

* Du kan ikke slette en person, som også er ansat i et SuperOffice-firma.
* Du kan ikke slette opfølginger, dokumenter, salg, projekter m.m., som ikke tilhører dig, medmindre du har tilstrækkelige brugerrettigheder til at gøre det.

## <a id="restore" />Gendannelse af slettede firmaer og personer

Når du har slettet noget, der ikke var beregnet til at blive slettet, for firmaer og personer, kan du stadig gendanne dem fra papirkurven. Dette gør det mindre skræmmende at slette, når du ved, at du stadig har en gendannelsesmulighed.

![Du kan gendanne slettede elementer fra papirkurven i menuen Personlige indstillinger -screenshot][img3]

Slettede firmaer og personer gemmes som standard i 14 dage. Efter denne periode slettes de permanent.

Du har også mulighed for at gendanne andre brugeres slettede firmaer og personer, du skal blot sætte Vis slettede virksomheder for alle brugere TIL.

1. Vælg ![ikon][img1] **Personlige indstillinger** > **Papirkurv**.

2. Vælg fanen **Firma** eller **Person** i dialogboksen. Firmaer og personer, som er blevet slettet af dig, bliver vist.

3. Valgfrit: Vælg **Vis slettede firmaer/personer for alle brugere**. Dette alternativ kræver funktionelle rettigheder.

4. Vælg de firmaer eller personer, du vil gendanne.
    * Gendannelse af et firma gendanner også alle de personer, der er knyttet til dette firma.
    * Gendannelse af en person, hvor firmaet også er blevet slettet, gendanner firmaet og den valgte person.

    ![Gendannelse af firmaer og personer fra papirkurven -screenshot][img2]

5. Klik på **Gendan**. Firmaerne og personerne gendannes i SuperOffice.

## Knapper

| Knap | Effekt |
|---|---|
| Ja | Bekræfter sletning af ét element ad gangen. |
| Ja til alle | Bekræfter sletning af alle markerede elementer. Hvis du for eksempel har markeret fem elementer til sletning, slettes de alle automatisk, når du vælger denne knap. |
| Nej | Annullerer sletning af ét element ad gangen. Dialogboksen lukkes, uden at noget slettes. |
| Annuller | Annullerer sletning af alle markerede elementer. Dialogboksen lukkes, uden at noget slettes. |

* Du kan vælge, at denne dialogboks ikke skal vises, på følgende måde: Marker **Vis ikke denne dialogboks igen** nederst i dialogboksen til sletning.
* Du kan vælge, at denne dialogboks skal vises igen, på følgende måde: Gå til ![ikon][img1] **Personlige indstillinger** > **Præferencer** > **Funktioner**, og sæt indstillingen **Vis dialogboks for bekræftelse** til **Nej**.

> [!NOTE]
> Når du sletter et firma, et udvalg eller et projekt, bliver du altid spurgt, om du virkelig vil slette dem, og du kan således ikke vælge **Vis ikke denne dialogboks igen**.

## Relateret indhold

* [Stop af gentagne opfølgninger][6]
* [Masseslette personer og firmaer fra markeringen][7]
* [Søg og udvalg][8]

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

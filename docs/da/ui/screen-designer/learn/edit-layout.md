---
uid: help-da-screen-designer-edit-layout
title: Rediger hovedkortets layout
description: "I denne vejledning lærer du, hvordan du redigerer et layout."
author: Bergfrid Dias
so.date: 03.29.2023
keywords: skærmdesigner, udseende, felt
so.topic: howto
language: da
---

# Rediger layout – Hovedkort

Når du har [oprettet et nyt layout][4], er det tid til at tilpasse det efter behovene i den eller de tildelte brugergrupper. Hvis du tilpasser et layout til salgsteamet, skal du have en klar plan for, hvad deres behov er med hensyn til layoutet og formateringen af faner, felter, elementer og kolonner på hovedkortet. Hvilke oplysninger skal være først og nemmest at finde? Har de brug for alle felter og faner? Hvad er felternes logiske rækkefølge?

Tilpas layoutet for hovedkortene og arkiverne, så det passer til organisationens informationsbehov. Når du redigerer layoutet på et hovedkort, kan du tilføje og fjerne felter eller omarrangere rækkefølgen, så den passer til teamets behov. Du skal først finde ud af, hvilken information der er vigtigst for teamet.

Se denne video og find ud af, hvordan du bruger skærmdesigneren til at konfigurere dine skærmbilleder i SuperOffice CRM, eller følg den trinvise guide nedenunder (videolængde - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## Trin

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Klik på **Hovedkort**.

4. Vælg et layout på listen i venstre side.

5. Klik på **Rediger layout** under forhåndsvisningen.

6. I vinduet **Rediger kortlayout** skal du redigere layoutet som beskrevet nedenunder.

7. Når du er færdig, kan du klikke på en af følgende knapper:

    * **Gem udkast**: Klik på denne knap, hvis layoutet endnu ikke er færdigt.
    * **Gem + Udgiv**: Klik på denne knap for at udgive layoutet for de valgte brugergrupper.
    * **Annuller**: Klik på denne knap for at [forkaste alle ændringer](#undo-changes).
<!-- markdownlint-restore -->

## Rediger eksisterende felter i layoutet

1. Vælg den fane, du vil redigere.

2. Rediger eksisterende felter:

    * Flyt felter ved at klikke på ![ikon][img4] til venstre for en feltetiket og trække feltet til en ny position. Klik på [Felter](#fields)for at tilføje et nyt felt.

    * Slet felter ved at holde musemarkøren over et felt og klikke på ![ikon][img2]. Slettede felter kan tilføjes igen fra sektionen **Felter.** Obligatoriske felter kan ikke slettes, og knappen **Slet** vises ikke for sådanne felter. Se [Felter](#fields).

    * Rediger feltformatering (f.eks. skrifttypeformat) og andre indstillinger ved at klikke på feltet. Sektionen **Indstillinger** åbnes i venstre del af vinduet. Se [Indstillinger](#settings).

3. [Rediger antallet af kolonner under en fane](#columns) fra sektionen **Kolonner**.

4. Gem ændringerne som beskrevet ovenfor.

![Fjern, tilføj og flyt de forskellige felter i layoutet -screenshot][img3]

## Føj nyt indhold til et layout

1. Vælg den fane, du vil redigere, eller klik på ![ikon][img5] **Tilføj** for [at tilføje en ny fane](#tabs).

2. Rediger layoutet ved at vælge en af følgende afsnit:

    * **Felt**: Træk [felter](#fields) fra listen til layoutet. Felter kan placeres i kolonnerne og i sidehovedet og sidefoden.

    * **Elementer**: Tilføj elementer som etiketter, skilleelementer, links eller knapper til layoutet.

    * **Indstillinger**: Klik på et felt eller element i layoutet for at redigere de relevante indstillinger. De tilgængelige indstillinger kan variere afhængigt af det valgte objekt. Se [Indstillinger](#settings).

    * **Kolonner**: [Vælg, hvor mange kolonner der skal vises under en fane](#columns).

3. Når du har tilpasset skærmlayoutet, skal du klikke på en af følgende knapper:

    * **Gem udkast**: Klik på denne knap, hvis layoutet endnu ikke er færdigt.
    * **Gem + Udgiv**: Klik på denne knap for at udgive layoutet for de valgte brugergrupper.
    * **Annuller**: Klik på denne knap for at slette alle ændringer.

Bokse med hæftede linjer i layoutet, angiv, hvor du kan placere et felt:

![Bokse med hæftede linjer – skærmbillede](media/screendesigner-field-place.png)

Nedenfor kan du finde mere detaljerede beskrivelser af de forskellige sektioner og funktioner.

## Felter

I sektionen **Felter** kan du finde alle tilgængelige datafelter for det valgte skærmlayout. Brug filterfunktionen til at finde bestemte felter.

* Træk et felt fra listen til et hæftet område under den markerede fane.
* Hvis du vil sikre dig, at et felt altid er synligt, skal du placere feltet i sidehovedet eller sidefoden, uanset hvilken fane der er markeret.
* Du kan placere det samme felt flere steder i skærmlayoutet, hvis det er relevant.
* Flyt felter ved at klikke på ![ikon][img4] til venstre for en feltetiket og trække feltet til en ny position. Hvis du vil flytte et felt til en anden fane, skal du trække feltet til tabulatorhovedet for at åbne fanen og derefter placere feltet under den åbne fane.
* Slet felter ved at holde musemarkøren over et felt og klikke på ![ikon][img2]. Obligatoriske felter kan ikke slettes, og knappen **Slet** vises ikke for sådanne felter.

**Begrænsninger:**

* Obligatoriske felter kan ikke slettes. Dette er defineret på skærmbilledet [Felter.][3]
* Nogle faner, som for eksempel **ERP** og **Bemærkning**, kan ikke redigeres, fordi de har bestemte funktioner.

## Elementer

I sektionen **Elementer** kan du tilføje forskellige elementer, der ikke er data, f.eks. etiketter, skilleelementer, links eller knapper.

## Indstillinger

Gør felter mere synlige ved at ændre skrifttypen til fed og stor tekst. Gør plads til flere felter ved hjælp af en mindre skrifttype. Gem skærmplads ved at skjule etiketter.

Klik på et felt eller element i layoutet for at redigere indstillingerne. Den tilgængelige indstilling varierer afhængigt af felttypen eller elementet.

## Kolonner

Som standard har en fane 2 kolonner, men du kan bruge alt fra 1-4 kolonner afhængigt af dine behov. Brugere med brede skærme foretrækker muligvis flere kolonner for at kunne se og sortere flere data.

**Begrænsninger:**

* Hvis du skifter fra 2-4 kolonner til 1 kolonne, flyttes alle felter til 1 kolonne.
* Brug af 4 kolonner kan påvirke synligheden af nogle felter. Du kan overveje at skjule etiketterne på nogle felter (se [Indstillinger](#settings)).
* Nogle faner, som for eksempel **ERP** og **Bemærkning**, har ikke kolonneopsætning, fordi de har bestemte funktioner.
* Hvis en bruger ikke har en skærmstørrelse, der passer til alle kolonner, stables de oven på hinanden.

## Faner

Føj flere faner til yderligere felter, eller fjern irrelevante faner.

**Tilføj/fjern en fane:**

1. Vælg fanen, og klik på **Opgave** &gt; **fanen Fjern**.
2. Klik på **OK** i den dialogboks, der vises.

**Sådan tilføjes en ny fane:**

1. Klik på ![ikonet][img5] **Tilføj**. Sektionen **Kolonner** åbnes til venstre.
2. Erstat teksten **Ny fane** under **Fanetitel** med det nye fanenavn.
3. Du kan også [tilføje fanenavnet på andre sprog][2] ved at klikke på ![ikon][img1].
4. Vælg det antal kolonner, du vil bruge under den nye fane.

> [!TIP]
> Hvis du senere vil omdøbe fanen, skal du markere den og vælge **Kolonner**.

**Begrænsninger:**

* Du kan ikke omdøbe standardfaner.
* Du kan ikke fjerne en fane, der indeholder obligatoriske felter. Obligatoriske felter skal flyttes til en anden fane først.
* Hvis der kun er én fane tilbage, kan du ikke slette den.

## Fortryd ændringer

Hvis du har brug for at vende tilbage til en tidligere version af skærmen, kan du få adgang til følgende indstillinger fra knappen **Opgave**:

* **Nulstil til fabriksindstillinger**: Denne indstilling kasserer alle ændringer og nulstiller skærmlayoutet til det standardlayout, der leveres af SuperOffice.
* **Slet kladde**: Sletter alle ændringer og nulstiller til den udgivne version af skærmlayoutet.

<!-- Referenced links -->
[2]: ../../../globalization-and-localization/learn/translate-fields.md
[3]: ../../../custom-objects/learn/udef/index.md
[4]: add-new-layout.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../../common/icons/delete-circle-red.png
[img4]: ../../../../media/icons/criteria-move.png
[img5]: ../../../../../common/icons/add-icon.png
[img3]: media/edit-the-screen-layout-of-companies-and-contacts.png

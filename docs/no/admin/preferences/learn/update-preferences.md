---
uid: help-no-preferences-manage
title: Arbeide med preferanser
description: "Slik legger du til, redigerer og sletter preferanseinnstillinger."
author: Bergfrid Dias
date: 03.21.2023
keywords: preferanse, innstilling
topic: howto
language: no
---

# Arbeide med preferanser

## Gå til preferansen du vil oppdatere

1. [!include[Open preferences](includes/open-preferences.md)]
2. Velg ønsket preferansegruppe fra listeboksen øverst.
3. Merk ønsket preferanse på **Preferanser**-listen.

    I feltet **Aktive innstillinger** vises innstillingene som allerede er definert for denne preferansen. Hvis dette feltet er tomt, kan det skyldes at valgene for å vise ulike nivåer ikke er merket av.

> [!TIP]
> Bruk feltet for **fritekstsøk** øverst på skjermen for å finne preferansen du vil endre. Søkeresultatene vises i listen under.

## Legge til preferanseinnstillinger

1. Gå til preferansen du vil legge til en ny innstilling for.

1. Klikk på **Legg til** nederst i vinduet.

1. I dialogboksen **Innstilling** under **Denne innstillingen gjelder for** velger du [hvilket nivå][2] innstillingen skal gjelde for – hele systemet, én database, én brukergruppe eller én bruker.

    > [!NOTE]
    > Hvis ett eller flere av alternativene er deaktivert, kan du ikke velge dette for denne innstillingen.

1. Velg navnet på ønsket database, gruppe eller bruker, i henhold til hva du valgte ovenfor.

    > [!NOTE]
    > Hvis du valgte **System**, fylles feltet **Mål** ut automatisk, siden det bare finnes ett system.

1. Navnet på feltet under **Verdi** varierer, avhengig av hvilken preferanse det gjelder. Her angir du verdien for innstillingen ved å skrive inn noe i feltet, velge fra en forhåndsdefinert liste, merke av i en utvalgboks og så videre, avhengig av hva slags preferansetype det dreier seg om.

1. Hvis du valgte et høyere nivå enn det lavest mulige under **Denne innstillingen gjelder for**, kan du merke av for **Fjern innstillinger på lavere nivåer** nederst i dialogboksen hvis du vil fjerne innstillingene på alle lavere nivåer. Denne nye innstillingen vil da overstyre innstillingene som er angitt for lavere nivåer.

1. Klikk på **Lagre**. Innstillingen blir tilgjengelig for brukere neste gang de logger på SuperOffice.

> [!NOTE]
> Preferanser med aktive brukerinnstillinger vises med fet skrift i preferanselisten.

## <a id="edit"></a>Redigere preferanseinnstilling

1. Gå til preferansen du vil oppdatere.

1. Dobbeltklikk på innstillingen du vil endre.

1. Oppdater feltene etter behov.

1. Klikk på **Lagre**. Innstillingen blir tilgjengelig for brukere neste gang de logger på SuperOffice.

    > [!NOTE]
    > Hvis du ikke vil lagre endringene likevel, kan du klikke på **Avbryt**.

## <a id="personal"></a> Tillate brukerinnstillinger

1. Gå til preferansen du vil gjøre tilgjengelig, i menyen **Personlige innstillinger**.

1. Merk av for **Tillat brukerinnstillinger**. Da vises preferansen i dialogboksen **Preferanser**, og alle kan redigere innstillingene for eget bruk.

> [!NOTE]
> Funksjonen for brukerinnstillinger er ikke tilgjengelig for alle preferanser.

## Slette preferanseinnstilling

1. Gå til preferansen du vil slette en innstilling for.

1. Velg én eller flere innstillinger du vil slette, og klikk deretter på **Slett** nederst i vinduet. Alle merkede innstillinger forsvinner fra listen.

<!-- Referenced links -->
[2]: index.md#levels

<!-- Referenced images -->

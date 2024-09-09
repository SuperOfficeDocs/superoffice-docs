---
uid: help-no-using-document-templates-for-multiple-languages
title: bruke dokumentmaler for flere språk
description: bruke dokumentmaler for flere språk
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger og vedlikehold
topic: help
language: no
---

# Bruke dokumentmaler på flere språk i prosjekt- og salgsguidene

Hvis bedriften din har avdelinger i flere land, kan det være nyttig å ha dokumentmalene i prosjekt- og salgsguidene tilgjengelige på flere språk. Først må du legge dokumentmalene for de ulike språkene i riktige mappe, og deretter angi hvem som skal bruke de ulike språkversjonene.

## Legge til dokumentmaler for språk

1. Åpne Windows Utforsker og gå til mappen *\\SuperOffice\\SO_Arc\\Template*.

2. Opprett en mappe for hvert av de språkene du vil ha dokumentmaler for (se tabellen nedenfor). For eksempel *\\SuperOffice\\SO_Arc\\Template\\GE*.

3. Legg dokumentmalene for de ulike språkene i de aktuelle språkmappene. Dokumentmalene må ha nøyaktig samme filnavn og filtype som hovedmalen. Hovedmalen er dokumentmalen på hovedspråket dere bruker i SuperOffice. Du finner den i listen **Dokument - Mal**-listen i **Lister**-bildet (dobbeltklikk på en dokumentmal i listen for å se filnavnet/-typen). Se Legge til forekomster på listen Dokument - Mal

> [!TIP]
>  Hvis dokumentmalen for det aktuelle språket IKKE ligger i språkmappen, brukes dokumentmalen på hovedspråket.

### Mappenavn for de ulike språkene

[!include[Språkkoder](../../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Angi dokumentspråk for brukere

Du må nå velge riktig dokumentspråk for brukerne som skal bruke dokumentmalene på de ulike språkene:

1. Gå til **Preferanser**-bildet, velg **System** fra listeboksen **Vis gruppe**, og velg **Foretrukket dokumentspråk**.

2. Klikk på **Legg til** nederst i listen **Aktive innstillinger**.

3. Velg **Bruker** under **Denne innstillingen gjelder for**.

    > [!TIP]
    > Hvis avdelingene bruker satellittdatabaser, kan du velge å angi dokumentspråk for databaser. Du kan også velge dokumentspråk for grupper, men da må den aktuelle gruppen være primærgruppen til brukerne som du angir dokumentspråk for.

4. Klikk på **Mål**-listen, og velg ønsket bruker.

5. Velg ønsket språk i listen **Foretrukket dokumentspråk**.

6. Klikk på **Lagre**.

7. Gjenta trinn 2-6 for hver bruker du vil angi dokumentspråk for.

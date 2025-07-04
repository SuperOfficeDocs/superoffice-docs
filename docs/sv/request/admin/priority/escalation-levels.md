---
uid: help-sv-request-escalation
title: Eskaleringsnivåer
description: Eskaleringsnivåer
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
keywords: eskaleringsnivå, lägg till eskaleringsnivå, ny nivå, eskalera, fliken Eskaleringsnivåer, ärendeprioritet, ärende, prioritet
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/request/learn/priority/escalation-levels
index: true
---

# Eskaleringsnivåer

För varje **ärendeprioritet** kan du definiera en eller flera eskaleringsnivåer, så att ärendet vidarebefordras inom organisationen om det inte har lästs eller behandlats inom en viss tid.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Så här definierar du nya nivåer

1. Klicka på knappen **Ärenden** i navigatorn och välj fliken **Prioriteter**.

1. Välj en prioritet som du vill skapa eskaleringsnivåer för.

1. Välj fliken **Eskaleringsnivåer**.

1. Klicka på knappen **Lägg till**. Du skapar nu den första eskaleringsnivån.

1. Ange följande information:

    * **Inträffar efter**
    * **Omdela till**
    * **Kör skript**

    Information om varje fält finns nedan.

1. Under **Skicka svarsmall** kan du definiera vem som ska få ett e-postmeddelande och SMS när den här eskaleringsnivån utlöses.

    Markera kryssrutorna för **E-post** eller **SMS** bredvid varje mottagare och välj relevant svarsmall. Om du väljer **Andra** måste du ange relevanta e-postadresser (använd kommatecken) och telefonnummer i fälten nedan.

    > [!NOTE]
    > Om fliken **Skicka svarsmall på SMS till** inte visas tyder det på att SMS inte är aktiverat för den licens som du använder. Kontakta systemansvarig person om du vill ha mer information.

1. Klicka på **Spara**.

1. Upprepa dessa steg för att skapa ytterligare eskaleringsnivåer.

1. Om du skapade flera eskaleringsnivåer kan du välja i vilken ordning de ska inträffa med pilknapparna under listan över eskaleringsnivåer.

## Eskaleringsinställningar

| Inställning | Beskrivning |
|---|---|
| Prioritet | Den prioritet som du vill koppla eskaleringsnivån till. |
| Inträffar efter | Hur mycket tid som måste gå innan den här eskaleringsnivån är aktiverad. Om prioriteten är definierad så att eskaleringen ska följa tidsramen påverkar det den tid som anges här. En prioritet med tidsram från måndag till fredag kl 09.00 till 17.00 med första eskaleringsnivå efter 2 timmar kommer till exempel att eskaleras måndag kl 10.00 om ärendet registreras fredag kl 16.00. |
| Omdela till | Markera detta om du vill att ärendet ska skickas till en annan ärendehandläggare när denna eskaleringsnivån uppnås. Välj därefter önskad användare i listan. |
| Kör skript | Markera detta om du vill att ett skript ska köras när eskaleringsnivån uppnås. Välj därefter önskat skript i listan. |

## Inställningar för svarsmall

| Inställning | Beskrivning |
|---|---|
| Kontaktperson | Om detta alternativ markeras, skickas den svarsmall som anges i fältet till höger till kontakten för ärendet när denna eskaleringsnivå inträffar. Välj önskad svarsmall i listan. |
| Ärendeägare | Om detta alternativ markeras, skickas den svarsmall som anges i fältet till höger till ärendets ägare när denna eskaleringsnivå inträffar. Välj önskad svarsmall i listan. |
| Kategoriadministratör | Om detta alternativ markeras, skickas den svarsmall som anges i fältet till höger till den kategoriansvarige när denna eskaleringsnivå inträffar. Välj önskad svarsmall i listan. |
| Andra | Om detta alternativ markeras, skickas svarsmallen som har angetts i fältet till höger till den/de e-postadress(er) som har angetts i fältet nedanför. Välj önskad svarsmall i listan. |
| E-postadress | Här skriver du in e-postadressen som svarsmallen i fältet **Andra** ska skickas till. Du kan lägga in flera adresser om du avgränsar dem med komma. |

## Ta bort eskaleringsnivå

1. Välj den eskaleringsnivå som du vill ta bort.
2. Klicka på knappen **Ta bort** längst ned på skärmen.

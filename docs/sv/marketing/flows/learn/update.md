---
uid: help-sv-flow-update
title: Uppdatera flöde
description: Uppdatera flöde
keywords: flöde, uppdatera flöde, lägga till steg
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Uppdatera flöde

Det är användbart att börja med ett enkelt flöde och utöka det efter att ha övervakat prestandan. Du kanske också vill uppdatera ett flöde under dess design.

För att göra ändringar:

1. [Pausa flödet][1].
1. Klicka på **Redigera**.
1. Gör de nödvändiga ändringarna.
1. Klicka på **Spara**.
1. Starta om flödet.

> [!NOTE]
> Ändringar som du gör på ett steg påverkar endast nya deltagare och aktiva deltagare som ännu inte har nått det steget.

## Uppdatera flödesinställningar, framgångskriterier och/eller trigger

Samma som när du [skapar ett flöde][2].

## Lägg till steg

Samma som när du [skapar ett flöde][3].

## Uppdatera stegsinställningar

1. Klicka på ett steg i flödesschemat för att öppna stegsinställningarna.
1. Beroende på stegets typ kan du:

    * Uppdatera egenskaper för nya aktiviteter.
    * Lägg till e-postinnehåll och/eller bilagor.
    * Förlänga eller förkorta väntetid.
    * Lägga till eller ta bort åtgärder.
    * Välja ett statisk urval, projekt eller flöde att överföra deltagaren till.
    * Ändra ordningen på grenar, döpa om grenar, lägga till en gren.
    * Uppdatera villkor i en delning.

1. Klicka på **Spara**.

Du kan hitta dessa resurser användbara:

* [Lista över tillgängliga inställningar för varje steg][6].
* [Dela flöde][5]
* [Väntetid och vänta på åtgärd][4]
* [Lägg till innehåll][7]
* [Skapa aktivitet][9]
* [Uppdatera kontakt][8]
* [Skapa urval][11]
* [Skapa formulär][10]

## Flytta, duplicera eller ta bort steg

* **Flytta:** Klicka på ett steg och dra det till en ny plats.
* **Duplicera:** Peka på ett steg och klicka på **Duplicera**-ikonen (<i class="ph ph-copy" aria-hidden="true"></i>). Detta skapar ett nytt steg baserat på det aktuella och lägger till det som nästa steg. Använd den här funktionen för att återanvända ett steg i samma flöde.
* **Ta bort:** Peka på ett steg och klicka på den röda X:et. Detta tar bort steget från flödet (men inte dess innehåll).

> [!NOTE]
> När du duplicerar ett e-poststeg skapas också en **kopia av e-postinnehållet**. Du kan redigera detta nya flödesinnehåll oberoende av e-postinnehållet i det steg som duplicerades.
>
> När du tar bort ett e-poststeg tas bara steget bort från flödet. E-postinnehållet tas inte bort eller raderas.

## Ta bort flöde

[Se *Kör, pausa och avsluta flöde*][1]

## Felsökning

Det finns några begränsningar när du redigerar ett flöde efter att det har körts för att skydda aktiva deltagare (med andra ord: för att förhindra att du gör en röra).

### Kan inte redigera flöde

* Du kan inte redigera ett pågående flöde. Pausa flödet och försök igen.
* Om **Redigera**-knappen fortfarande är grå, har du inte den nödvändiga funktionella rätten 'Flödesadministratör'.

### Kan inte flytta eller ta bort steg

* Du kan inte flytta eller ta bort ett **Väntetid**, **Vänta på åtgärd** eller **Dela**-steg om det finns aktiva deltagare i steget.

Gå till fliken **Deltagare** och kontrollera kolumnen **Aktuellt steg** för att hitta en lämplig tidpunkt att pausa och uppdatera flödets styrningssteg.

### Kan inte ta bort gren

* Du kan inte ta bort grenen 'Alla andra'.
* Du kan inte ta bort en gren om det finns aktiva deltagare på den.

Gå till fliken **Flöde** för att kontrollera om det finns någon på grenen. Om ja, gå till fliken **Deltagare** för detaljer. Hur du hanterar dessa deltagare är upp till dig. Några alternativ att överväga:

* Lägg till deltagare i ett statisk urval för att följa upp senare.
* Lägg till deltagare i flödets exkluderningslista.
* Ta bort deltagare från flödet med hjälp av **Uppgift**-menyn.
* Vänta på att grenen ska "dräneras". Du kanske behöver uppdatera grenens villkor för att förhindra att nya deltagare kommer in.

<!-- Referenced links -->
[1]: run-pause-end.md
[2]: create.md
[3]: create.md#add-step
[4]: create.md#wait
[5]: split.md
[6]: step-settings.md
[7]: content.md
[8]: define-flow-actions.md#update
[9]: define-flow-actions.md#create
[10]: ../../forms/learn/create.md
[11]: ../../../search-options/selection/learn/create.md

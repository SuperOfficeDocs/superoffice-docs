---
uid: help-sv-time-zones
title: Tidszoner
description: Tidszoner
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: concept
language: sv
---

# Tidszoner

SuperOffice CRM har stöd för händelser i olika tidszoner. Om tidszoner har aktiverats finns det en listruta nederst till vänster i kalendern (flagga och land), där du kan välja önskad tidszon.

> [!NOTE]
> Användning av tidszoner måste aktiveras per land i Inställningar och underhåll (under **Alternativ** > **Tidszoner**). Dessutom kan du gå till **Inställningar** för att visa tidszonsväljaren och ange standardtidszon. Där finns också mer information om hur du ställer in tidszoner.

## Hur fungerar tidszoner i SuperOffice CRM?

Tidszonsfunktionen är väldigt praktisk om företaget har kontor i flera länder med olika tidszoner och du ska planera möten eller telefonkonferenser med medarbetare i länder med andra tidszoner än ditt eget land. Händelsen skapas då i tidszonen som motsvarar det valda landet.

Om ditt företag finns i Sverige och du ska boka möte med medarbetare i företagets dotterbolag i Finland och USA, skapar du möten med lokal, svensk tid och kontrollerar sedan motsvarande tid i Finland och USA. Då undviker du att skapa möten mitt i natten i amerikansk tid. Medarbetarna som får förfrågan ser möten i den tidszon de har angett i sin egen SuperOffice CRM-klient, även om du har skapat möten med svensk tid.

Funktionen har stöd för sommartid.

> [!NOTE]
> Händelser som har skapats innan tidszoner aktiverades visas fortfarande i standardtidszonen i din SuperOffice-databas.

## Hur väljer du tidszoner?

Tidszoner visas i form av en listruta i [kalenderen][1] och för [händelser][3]. Tidszonen som är standard för din SuperOffice-databas visas överst med denna ikon: ![ikon][img1].

Tidszonslistan sorteras efter land. Högst upp i tidszonslistan visas det valda landets namn och flagga.

### Söka efter land och städer

Använd det översta fältet med det valda landet flagga som ett sökfält. Du kan söka efter både land och större städer direkt i tidszonsfältet. Om du till exempel inte vet vilken tidszon Canberra befinner sig i söker du efter Canberra, så visas den aktuella tidszonen i Australien i listan.

1. Placera muspekaren i landfältet.
2. Skriv namnet på staden eller landet som du vill visa tidszon för.
3. När du har hittat staden eller landet visas klickar du på posten, så aktiveras motsvarande tidszon.

### Söka på antal timmar

Du kan söka på antal timmar och hitta rätt tidszon. Om du till exempel skriver in +3 visas alla tidszoner som ligger tre timmar efter den angivna tidszonen i SuperOffice CRM.

> [!NOTE]
> I listan i tidszonsväljaren är regionnamnen alltid på engelska, medan namnen på länderna beror på språkinställningarna i SuperOffice CRM. Tänk på det när du söker efter länder och regioner.

## Praktiska tips om tidszoner

* Om du håller muspekaren över tidszonslistan visas en inforuta med information om vilka större städer (i det aktuella landet) som ingår i den valda tidszonen.

* Om du håller muspekaren över en kalenderhändelse som har skapats i en annan tidszon än standardtidszonen i din SuperOffice-databas så visas en inforuta med information om bokningstiden i både din egen tidszon och händelsesägarens tidszon.

<!-- Referenced links -->
[1]: ../../diary/learn/index.md
[3]: ../../diary/learn/follow-ups.md

<!-- Referenced images -->
[img1]: ../../../media/icons/time-zone-local.png

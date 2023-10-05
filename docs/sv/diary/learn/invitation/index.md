---
uid: help-sv-invitation
title: Skapa händelser med dina medarbetare
description: Skapa händelser med dina medarbetare
author: Bergfrid Dias
so.date: 10.04.2023
keywords: kalender, händelse
so.topic: howto
language: sv
---

# Bjuda in andra medarbetare till en händelse

Om du vill avsätta tid för ett möte med en eller flera medarbetare går du till fliken **Översikt** i Kalender-fönstret. Här kan du öppna dina medarbetares kalendrar för att se när de är tillgängliga för ett möte. Du kan också välja att visa resurser som konferensrum, se när de är lediga och skapa en gemensam bokning för alla från din egen kalender.

Händelser med medarbetare skapas genom att de kopplas till händelsen som deltagare.

## <a id="status" />Status

Användarna du väljer att koppla till en händelse får ett meddelande om detta på skärmen. Om du öppnar händelsen på fliken **Deltagare** visas en lista över de deltagare och resurser du har kopplat till händelsen. Med hjälp av symbolerna bredvid namnen kan du också se vilka som har sagt ja eller nej och vilka resurser som är bokade:

| Ikon | Beskrivning |
|---|---|
| ![ikon][img1] | Förfrågan har godtagits. |
| ![ikon][img2] | Förfrågan har avböjts. |
| ![ikon][img3] | Förfrågan har mottagits men inte besvarats. |
| ingen symbol | Förfrågningen har inte tagits emot. |

### Resurser

När du kopplar resurser ändras statusen till *Accepterad* eftersom en resurs inte kan svara på förfrågan.

Resurser kan dubbelbokas. Om en resurs inte är ledig på den aktuella tidpunkten står det **Konflikt** i kolumnen **Status**. Dessutom visas ett utropstecken i dialogrutan **Bokning**. Du måste ändra tidpunkt för händelsen. I fältet **Första lediga** visas den första lediga tidpunkten.

### Befintliga kontakter

De kontakter som du väljer under **Företag** i dialogrutan **Förfrågan** tillhör normalt inte din egen organisation. Du kan skicka förfrågan till dem via e-post med hjälp av alternativet **E-postförfrågan**. E-postförfrågningar som skickas till externa kontakter innehåller en iCal-fil (.ics) med information om förfrågan. När de svarar på din inbjudan kommer statusen automatiskt att uppdateras i SuperOffice.

Händelsen visas på detaljkortet **Aktiviteter** under det aktuella företaget.

## Hantera svar på förfrågningar

När du skickar en förfrågan kan mottagaren välja att acceptera eller avböja den.

* Om mottagaren avböjer förfrågan kan du ändra tiden eller omfördela uppföljningen, beroende på vilken typ av förfrågan det handlar om.

* Om kontakten godtar förfrågan försvinner den från dialogrutan **Förfrågningar** och registreras som vanligt i SuperOffice CRM.

## Vad vill du göra?

* [Lägga till deltagare i händelser][2]
* [Skapa gruppöversikter][1]

<!-- Referenced links -->
[1]: ../group-view.md
[2]: add-participant.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/check-black.png
[img2]: ../../../../../common/icons/reject-appointment-icon.png
[img3]: ../../../../../common/icons/assignment-seen.png

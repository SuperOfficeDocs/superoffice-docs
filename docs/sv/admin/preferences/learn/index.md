---
uid: help-sv-preferences
title: Preferenser
description: Administratörer kan ange inställningar för olika funktioner i systemet för olika användare och användargrupper eller för hela SuperOffice CRM (globala inställningar).
author: Bergfrid Dias
so.date: 03.21.2023
keywords: inställningar, inställningar
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Preferenser

I fönstret Inställningar kan du välja inställningar för hela systemet (globalt), en databas, en användargrupp eller en enskild användare. Inställningar som bara kan göras globalt (på systemnivå) finns på fliken **[Globala inställningar][1]**.

Under **Personliga inställningar** > **Inställningar** i det övre fältet kan användarna ändra de [individuella inställningarna][4] efter egna önskemål. Vilka inställningar som är tillgängliga för användarna beror på valen under Inställningar och underhåll.

Du kan också konfigurera videomöten på fliken [Videomöten][8] och dokumentbiblioteket på fliken [Dokumentbibliotek][9].

## <a id="levels" />Nivåer för inställningar

Inställningar kan anges på fyra olika nivåer:

| Nivå | Beskrivning |
|---|---|
| System | Globala inställningar som gäller för alla användare i systemet, inklusive alla satelliter, grupper och enskilda användare. |
| Databas | Inställningar som gäller för en bestämd databas och alla grupper och användare som har kopplats till databasen. |
| Grupp | Inställningar som gäller för alla användare i en bestämd grupp. |
| Användare | Inställningar som har kopplats till varje enskild användare. |

Du kan ange olika värden för olika nivåer, så att du till exempel kan ha en inställning för en användare och en annan inställning för användargruppen som personen ingår i. Det är alltid den lägsta nivån som gäller.

> [!NOTE]
> Alla nivåer är inte tillgängliga för alla inställningar. Om ett eller flera alternativ är inaktiverade kan du inte välja de alternativen i inställningen.

Du kan välja vilka inställningar som ska visas i listan baserat på vilken nivå de har angetts för i fältet **Aktiva inställningar**. Vilka nivåer som visas beror på vilka nivåer du markerar längst ned i fältet. Du kan använda de här kryssrutorna för att visa en, två eller alla nivåer.

> [!NOTE]
> Inställningarna för systemnivå visas alltid.

## <a id="global" />Globala inställningar (för hela systemet)

Vissa [inställningar][1] kan bara göras på global nivå:

* Statistik
* Funktioner
* E-post
* Grupperade listor
* Marknadsföring
* Mobile CRM
* Försäljning
* Systeminställningar för SuperOffice Service
* System
* SMS-konfiguration
* Lösenordspolicy för Kundcenter

### Ändra globala inställningar

Om du vill ändra de här inställningarna går du till fönstret **Inställningar** ![ikon][img1] och väljer fliken **Globala inställningar**.

* De olika inställningarna är indelade i sektioner.
* Håll muspekaren över en inställning för att visa mer information.
* Klicka på **Spara** för att implementera ändringarna.

## <a id="preferences-tab" /> Fliken inställningar

På fliken **Inställningar** kan du ange ett antal inställningar för olika delar av SuperOffice CRM, bland annat hur många poster som ska visas i historiken, standardtyp för ett nytt möte samt standardvaluta i fönstret Försäljning.

Högst upp i fliken **Inställningar** kan du välja önskad inställningsgrupp. Resten av fliken **Inställningar** är indelad i tre huvudsektioner: en lista över alla inställningar, ett beskrivningsfält som förklarar den aktiva inställningen och ett fält som visar de aktuella inställningarna för parametern.

### Listan Preferenser

Till vänster finns listan **Inställningar** med alla inställningar som har definierats inom den aktuella inställningsgruppen.

**Inställningsgrupper:**

* Kontaktperson
* Standardvärden
* Kalender
* E-post
* Dialogrutan Filter
* Fritextsökning
* Funktioner
* Grupperade listor
* In-app communication
* Marknadsföring
* Aviseringar via e-post + popup + SMS
* Ärende
* Försäljning
* Sortering
* System
* Hjälptext
* Visuella effekter
* Webbserver
* Web Services

> [!NOTE]
> Parametrar med aktiva individuella inställningar visas i feststil.

### Aktiva inställningar

Fältet **Aktiva inställningar** visar vilka val som har gjorts för den markerade parametern i listan **Inställningar** samt nivåer och värden för varje inställning. I det här fältet kan du ändra och ta bort befintliga inställningar och lägga till nya.

Fältet består av tre kolumner:

| Kolumn | Beskrivning |
|---|---|
| Vem | Visar vem inställningen tillämpas på (namnet på systemet, databasen, gruppen eller användaren). Om det är en enskild användare öppnas en hjälptext när du håller muspekaren över användarens initialer i den här kolumnen. |
| Nivå | Visar vilken [nivå inställningen tillämpas på](#levels) (system, databas, grupp eller användare). |
| Värde | Visar det värde som har angetts för inställningen. |

Innehållet i de här kolumnerna definieras i dialogrutan **Inställning**. [Så lägger du till inställningar][3].

Du kan sortera raderna i kolumnerna genom att klicka på önskad kolumnrubrik. Klicka på kolumnrubriken en gång till om du vill sortera i omvänd ordning.

<!-- Referenced links -->
[1]: global-preferences/system.md
[3]: update-preferences.md
[4]: update-preferences.md#personal
[8]: video-meetings/index.md
[9]: document-library/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-preferences-active.png

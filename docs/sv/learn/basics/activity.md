---
uid: help-sv-activity
title: Aktiviteter
description: Aktiviteter i SuperOffice CRM
keywords: aktivitet
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Aktiviteter

![Aktiviteter i SuperOffice CRM -screenshot][img3]

## Typer

Det finns två huvudtyper av aktiviteter – dokument och händelser. Dessutom visas utskick, formulärinlämningar och chattposter på detaljkortet **Aktiviteter**.

* [Händelser][1]
  * <i class="ph ph-calendar-blank" aria-hidden="true"></i> Möte (bokning)
  * <i class="ph ph-calendar-blank" aria-hidden="true"></i> Händelse (samtal)
  * <i class="ph ph-calendar-check" aria-hidden="true"></i> Att göra (uppgift)
* [Dokument][4]
  * <i class="ph ph-files" aria-hidden="true"></i> Dokument (brev och andra dokument)
  * <i class="ph ph-at" aria-hidden="true"></i> E-post
* <i class="ph ph-target" aria-hidden="true"></i> [Utskick][3] (massutskick via brev, e-post eller SMS)
* <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> [Chattposter][12]
* <i class="ph ph-rows" aria-hidden="true"></i> Formulärinlämningar

## Var hittar jag aktiviteter?

[Detaljkortet Aktiviteter][18] finns tillgängligt i skärmarna Företag, Kontakt, Projekt, Försäljning och Kalender.

> [!NOTE]
> Aktiviteter visas också i de [olika vyerna][7] i skärmbilden Kalender.

## <a id="view"></a>Visa aktiviteter

Vilka aktiviteter som visas beror på vilka filter du väljer längst ned på detaljkortet. Du kan visa alla aktiviteter eller bara en viss typ. Klicka på knappen **Filter** (<i class="ph ph-funnel" aria-hidden="true"></i>) för att [filtrera aktiviteter][17] efter datum och användare.

![Detaljkortet Aktiviteter visar filteralternativ för olika posttyper -screenshot][img4]

## Kolumner

Listan över aktiviteter innehåller följande information:

* Den första kolumnen anger **Slutfört**-status för en aktivitet. En bock (<i class="ph ph-check" aria-hidden="true"></i>) betyder att aktiviteten är slutförd, medan en tom ruta betyder att den inte är slutförd.

* Kolumnen **Kategori** innehåller ikoner som visar vilken typ av aktivitet det är, till exempel en kalender för ett möte. Dessa ikoner motsvarar texten i kolumnen **Typ**.

* Övriga kolumner visar information om aktiviteten. Om all text inte är synlig i ett fält, håll muspekaren över det för att visa en tooltip.

## Skapa en aktivitet

Du kan skapa aktiviteter via menyn **Nytt** i det övre fältet eller genom att klicka på knappen **Lägg till** på detaljkortet.

## <a id="delete"></a>Ta bort en aktivitet

Du kan ta bort aktiviteter från alla skärmar där de visas:

1. Markera en eller flera aktiviteter som du vill ta bort.
2. Högerklicka på de markerade aktiviteterna och välj **Ta bort**.
3. Klicka på **Ja** när du tillfrågas om du verkligen vill ta bort aktiviteten.

[!include[Deleting items](../includes/tip-deletion.md)]

## Preferenser <i class="ph ph-user-circle" aria-label="Kontaktikon"></i>

När en aktivitet har slutförts tas den bort från aktivitetslistan dagen efter. Som standard visar detaljkortet **Aktiviteter** att göra-poster som ännu inte har slutförts.

### Visa framtida att göra-poster

1. Gå till **Personliga inställningar** > **Inställningar**.
2. Välj **Funktioner** och leta upp alternativet **Visa dagar framåt**.
3. Ange hur många dagar framåt du vill att aktiviteter ska visas. Till exempel visar ett värde på 7 aktiviteter för den kommande veckan.

### Ta bort aktivitet från listan när den är slutförd

1. Gå till **Personliga inställningar** > **Inställningar**.
2. Välj **Visuella effekter**.
3. Uppdatera [inställningen][2] **Ta bort slutförda aktiviteter**.

### Markera förfallna aktiviteter

Om en aktivitet visas med röd text betyder det att dess planerade datum har passerat. För att ändra denna inställning:

1. Gå till **Personliga inställningar** > **Inställningar**.
2. Välj **Funktioner**.
3. Uppdatera alternativet **Markera aktiviteter som har utgått**.

## Relaterat innehåll

* [Filtrera aktiviteter][17]
* [Ändra Slutfört-status för en aktivitet][10]
* [Lägg till händelseratt göra, samtal)][8]
* [Ring till kontakter][11]
* [Arbeta med dokument][4]
* [Skriv ett e-postmeddelande][5]
* [Detaljkortet Aktiviteter][18]

<!-- Referenced links -->
[1]: ../../diary/learn/follow-ups.md
[2]: ../getting-started/preferences.md
[3]: ../../marketing/mailing/learn/index.md
[4]: ../../document/learn/index.md
[5]: ../../email/inbox/learn/compose.md
[7]: ../../diary/learn/index.md
[8]: ../../diary/learn/create-follow-up.md
[10]: ../../diary/learn/change-completed-status.md
[11]: ../../contact/learn/dial.md
[12]: ../../chat/learn/index.md
[17]: ../section-tabs/filter.md
[18]: ../section-tabs/activities-tab.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/diary/activities-detail.png
[img4]: ../../../media/loc/en/learn/activities-filter.png

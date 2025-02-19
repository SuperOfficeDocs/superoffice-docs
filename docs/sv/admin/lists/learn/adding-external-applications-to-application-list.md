---
uid: help-sv-adding-external-applications-to-application-list
title: Lägg till externa applikationer i applikationslistan
description: Lägg till externa applikationer i applikationslistan
keywords: listan GUI – Applikation
author: SuperOffice RnD
date: 02.25.2025
topic: howto
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
---

# Lägga till poster i listan GUI – Applikation

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] när posterna är applikationer eller liknande:

> [!NOTE]
> Filer eller applikationer som måste köras lokalt (till exempel en *.exe*-fil) är inte tillgängliga i SuperOffice CRM for Web.

1. Skriv in namnet på posten i fältet **Namn**. Det här namnet visas sedan där du lägger till applikationen i SuperOffice CRM (se steg 7 om listrutan **Visa**).

    > [!NOTE]
    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Under **Lägg till som** väljer du vad applikationen ska läggas till som:

    * **Knapp**: applikationsikonen visas i navigatorn. Användaren kan då öppna applikationen direkt genom att klicka på ikonen i navigatorn.
    * **Menyval**: användaren får åtkomst till applikationen genom att klicka på knappen **Verktyg** (<i class="ph ph-wrench" aria-hidden="true"></i>) i navigatorn och/eller välja **Andra applikationer** på huvudmenyn (<i class="ph ph-list" aria-hidden="true"></i>).
    * **Händelse**: applikationen körs när SuperOffice CRM startas eller avslutas, eller vid lokal uppdatering (Travel). Se steg 8. Du kan till exempel köra ett synkroniseringsprogram för en PDA-dator när SuperOffice CRM stängs.
    * **Uppgift**: välj ett alternativ i den här listrutan om du vill att applikationen ska vara tillgänglig via fliken **Uppgift** i fönstret Urval eller **Uppgift**-knapparna.

        <details><summary>Läs mer om de olika alternativen.</summary>

        Namnen inom parentes anger detaljkortet där applikationen är tillgänglig.

        Exempel:

        * **Försäljningsurval (försäljning)**: När du har öppnat ett försäljningsurval i fönstret Urval och detaljkortet **Försäljning** är aktivt visas applikationen som en uppgift på fliken **Uppgift**.
        * **Försäljningsurval (företag)**: När du har öppnat ett försäljningsurval i fönstret Urval och detaljkortet **Företag** är aktivt visas applikationen som en uppgift på fliken **Uppgift**.
        * **Säljurval (externt)**: Om din installation av SuperOffice CRM är kopplad till en tredjepartsapplikation kan andra detaljkort visas för de olika urvalen. Du kan då till exempel välja **Försäljningsurval (externt)** och visa applikationen som en uppgift på fliken **Uppgift** när du öppnar ett försäljningsurval i fönstret Urval och detaljkortet för tredjepartsapplikationen är aktivt.

        Andra alternativ:

        * **Verktygsfältet**: Applikationen visas som ett val i verktygsfältet. Användaren måste konfigurera verktygsfältet i SuperOffice CRM och välja att visa applikationen.

        * **Dialogrutan för händelser**: Applikationen visas som ett alternativ under **Uppgift**-knappen i dialogrutan för händelser.

        * **Dialogrutan Dokument**: Applikationen visas som ett alternativ under knappen **Uppgift** i den valda dialogrutan. Samma alternativ är tillgängligt för skärmbilderna Kontakt, Offert och Produkt.

        </details>

    > [!NOTE]
    > Dina val under **Lägg till som** avgör vilka alternativ som ska vara tillgängliga i resten av dialogrutan.

1. Under **Tillgänglig på** väljer du var du vill att applikationen ska vara tillgänglig. Du kan välja flera av dessa alternativ samtidigt.

    * **Central databas**: När du jobbar i den centrala databasen.
    * **Satellit**: När du jobbar på en satellitstation.
    * **Travel**: När du använder en lokal databas via Travel-funktionen.

1. Ange önskad applikation i fältet **Filnamn**.

1. I fältet **Parametrar** kan du ange eventuella startparametrar för applikationen.

1. I fältet **Arbetsmapp** kan du ange vilken mapp som ska vara aktuell när applikationen startas. Skriv in sökvägen manuellt. Vanligtvis lämnas detta fält tomt.

1. Välj önskat alternativ i listrutan **Visa**. Den här listrutan visas bara om du har valt **Menyval** under **Lägg till som**.

    * **Verktygsmenyn**: Användaren kommer åt applikationen genom att klicka på knappen **Verktyg** i navigatorn eller välja **Andra applikationer** på huvudmenyn i SuperOffice CRM.
    * **Visa-menyn**: Användaren kommer åt applikationen via alternativet **Andra applikationer** på **Visa**-menyn i SuperOffice CRM.

1. I listrutan **Kör när** väljer du när applikationen ska köras. Den här listrutan visas bara om du har valt **Händelse** under **Lägg till som**.

    * **SuperOffice CRM startas**: Applikationen körs när SuperOffice CRM startas.
    * **SuperOffice CRM stängs**: Applikationen körs när SuperOffice CRM avslutas.
    * **Lokal uppdatering**: Applikationen startas när Travel används.

1. Markera **Vänta tills applikationen är färdig** om du inte vill att SuperOffice CRM ska stängas förrän du har avslutat den externa applikationen. Om du inte markerar det här alternativet kan du stänga SuperOffice CRM utan att stänga den externa applikationen. Den här listrutan visas bara om du har valt **Händelse** under **Lägg till som**.

1. Under **Startläge** väljer du i vilken typ av fönster applikationen ska startas: maximerat, minimerat eller återskapat.

1. I fältet **Ikon** kan du välja om en särskild ikon för applikationen ska visas i navigatorn i SuperOffice CRM (se steg 7 om listrutan **Visa**). Den här listrutan visas bara om du har valt **Knapp** under **Lägg till som**.

    * **Från biblioteket**: Välj en av de tillgängliga ikonerna i listan.
    * **Använd programikonen**: Använd standardikonen för den valda applikationen.

1. Skriv eventuellt en beskrivning av posten i fältet **Beskrivning**.

1. Klicka på **Spara**. Posten läggs nu till i listan **Poster**. Upprepa proceduren om du vill lägga till fler poster.

> [!NOTE]
> Användarna måste logga in i SuperOffice CRM igen för att applikationen ska visas.

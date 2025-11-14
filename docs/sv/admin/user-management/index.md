---
uid: help-sv-users
title: Användare
description: Lär dig hur du lägger till nya användare, tilldelar rätt användarroller och grupper och hjälper användarna med konfigurationen och WebTools.
keywords: Fönstret Användare, användare, medarbetare, våra företag, synlighet, tillgängligt
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
redirect_from: 
  - /sv/admin/user-management/learn/index
  - /sv/admin/user-management/learn/screen/index
  - /sv/admin/user-management/learn/visibility
  - /sv/admin/user-management/learn/associates-filter-group
language: sv
---

# Användare

Som administratör ansvarar du för att lägga till och hantera dina användare.

SuperOffice CRM använder ett roll‑ och gruppbaserat åtkomsträttighetssystem. Det innebär att **varje SuperOffice‑användare har en roll och tillhör en primär grupp** (dessa inställningar är obligatoriska).

Följande diagram visar en modell för hur åtkomsträttighetssystemet fungerar i SuperOffice CRM.

![Diagram som visar åtkomsträttighetssystemet][img1]

En [roll][6] har en uppsättning data‑ och [funktionella rättigheter][7], och en grupptilldelning ger tillgång till dataobjekt, olika SuperOffice‑listor och hjälper till att ställa in systempreferenser mer effektivt.

Systemet gör det möjligt att konfigurera åtkomst till företag, kontakter, projekt, projektmedlemmar, urval, försäljning, intressenter (av försäljning), händelser, dokument (inklusive e‑post och utskick), relationer (kontakt och företag), och dashboards. Alla dessa olika typer av poster kallas **dataobjekt**.

Varje dataobjekt tillhör en användare som kan vara du själv (a), användare i din primära grupp (b), användare som tillhör dina andra grupper (c), andra medarbetare som du inte är kopplad till via någon av dina grupper (d), externa användare (e), och anonyma användare (f).

![Roller ‑ Medarbetare‑skärm, fliken data‑rättigheter ‑screenshot][img2]

Ägandet av olika dataobjekt ställs in via olika fält. Till exempel anger fältet **Vår kontakt** i företagskortet ägaren av posten. För händelser är det fältet **Ägare**, i projektet **Ansvarig**, och så vidare.

## <a id="visible"></a>Synlighet

Huruvida du kan se specifika dokument, försäljningar, händelser och urval beror inte enbart på vilken roll du har tilldelats. Det kan finnas enskilda informationsposter som du inte har tillgång till. I dialogrutorna dokument och händelser och i fönstren Försäljning och Urval finns en listruta med namnet **Synlig för**. I fönstret Försäljning kan du till exempel välja att göra en försäljning synlig för alla, endast synlig för primärgruppen som ägaren tillhör eller endast synlig för ägaren.

Detta kräver att du har licensen **Konfidentiella aktiviteter**.

Om du vill aktivera den här licensen lokaliserar du önskad användare, klickar på fliken **Licenser** och markerar sedan kryssrutan för **Konfidentiella aktiviteter**.

## Användartyper

* **Medarbetare**: SuperOffice CRM-användare (i ditt företag)

* **Andra användare**: Anonyma användare och systemanvändare (endast lokalt)

* **Anonyma användare**: Användare med begränsad behörighet, som definieras av [rollen för anonyma användare][4]. Anonyma användare kan till exempel få tillgång till webbsidor. På så sätt kan säljare publicera relevant information från SuperOffice CRM på en webbplats som inte kräver inloggning där kunderna enkelt får tillgång till den.

* **Systemanvändare**: Systemanvändaren är avsedd för integration och kan bland annat användas för att ge processer fullständig åtkomst till SuperOffice-databasen vid replikering av kalendrar.

## Medarbetare

**Medarbetare** är SuperOffice-användare i ditt företag (eller ett associerat företag, till exempel ett dotterbolag).

På fliken **Medarbetare** i fönstret Användare kan du bland annat lägga till användare av typen **Medarbetare** och tilldela dem roller, grupper och licenser, redigera befintliga användare och ta bort användare.

Innan en person kan registreras som SuperOffice CRM-användare måste hen ha registrerats på ett företag som finns med i listrutan **Företag** i fönstret Användare. Enligt samma princip måste ett företag finnas med i företagslistan på fliken **Våra företag** i fönstret Användare för att visas i listrutan **Företag**.

> [!NOTE]
> I fönstret Användare anger du vilka licenser de olika användarna ska ha. Om du vill lägga till nya systemlicenser eller öka/minska antalet licenser för en eller flera moduler kontaktar du SuperOffice och [uppdaterar licensinformationen][16].

## Användargrupper

En **grupp** tilldelas användaren och ger åtkomst till dataobjekt (4 i föregående diagram). En användare måste ha en **primär grupp** och kan ha flera **andra grupper**.

![Diagram för gruppmedlemskap][img5]

I detta exempel har användare A Marketing som annan grupp och användare B har Marketing som primär grupp. I detta fall, om användare A vill se data som skapats av användare B, måste användare A:s roll ha rättigheten "Läs" bredvid alla dataobjekt i kolumnen *Annan grupp*. Detta beror på att Marketing‑gruppen är annan grupp för användare A och binder dem till poster som användare B skapar.

En grupp kan också ge åtkomst till listelement (5 i diagrammet) i SuperOffice CRM. Detta gäller endast om du använder inställningen **Gruppering och filtrering** (a) för dina listor. Om denna inställning inte är aktiverad, har alla användare åtkomst till alla listor i SuperOffice CRM. Gruppering och filtrering är särskilt användbart då många användare med olika ansvar får tillgång till systemet. På så sätt kan du undvika att vissa användare får åtkomst till information som de inte borde se.

![Gruppering och filtrering efter användargrupp för dokumentmall‑lista –screenshot][img6]

Till exempel, om du vill göra ett visst listelement synligt endast för vissa användare, går du till den lista som lagrar dessa element (a), väljer elementet (b) och i rutan "Synligt för användargrupper", markerar du de användargrupper som ska se listelementet (c).

![Välj preferensnivå grupp för uppföljning –screenshot][img7]

Att organisera dina användare i grupper är också praktiskt när du vill anpassa SuperOffice‑inställningar, vilka vi kallar [preferenser][15] (6). Varje preferens kan ställas in för en användare, användargrupp eller hela systemet.

![Preferenser för Försäljnings‑grupp –screenshot][img8]

## <a id="screen"></a>Fönstret Användare

I fönstret Användare kan du lägga till och redigera olika typer av användare.

![En översikt över fönstret Användare under Inställningar och underhåll -screenshot][img3]

[**Våra företag:**][2] Innan en person kan registreras som SuperOffice CRM-användare måste hen ha registrerats på ett företag som finns med i listan **Företag** i fönstret Användare. Enligt samma princip måste ett företag finnas med i företagslistan på fliken **Våra företag** i fönstret Användare för att visas i listan **Företag**.

> [!NOTE]
> Ändringar som du gör i fönstret Användare träder inte i kraft förrän du klickar på **Spara** längst ned i fönstret eller bekräftar att du vill spara ändringarna i dialogrutan som visas. Om du klickar på **Avbryt** förlorar du alla ändringar som du har gjort i fönstret sedan du sparade sist.

### <a id="associates"></a>Medarbetarlistan

Listan på fliken **Medarbetare** har som standard följande kolumner:

| Kolumn | Beskrivning |
|---|---|
| Användar-ID | Användarnamnet som medarbetaren har tilldelats. |
| Förnamn | Användarens förnamn. |
| Efternamn | Användarens efternamn. |
| Primärgrupp | Användarens primära grupp. |
| Roll | [Rollen][6] som användaren har tilldelats. Rollen definierar vilka databehörigheter användaren har i SuperOffice CRM. |
| Användarplan | Användarplanen som användaren har tilldelats. |
| Ägarföretag | Namn på det företag som användaren tillhör (definieras som databasägare). |

> [!TIP]
> Du kan välja vilka kolumner som ska visas i listan. Högerklicka bara på en kolumnrubrik och markera relevanta kolumner i kolumnlistan. Du kan ändra ordningen på kolumnerna genom att klicka och dra i kolumnrubrikerna.

* **Sök efter användare:** Använd den här dynamiska sökfunktionen för att snabbt hitta specifika användare efter namn eller användar-ID, eller för att hitta alla användare som tillhör specifika roller, grupper eller användarplaner. Skriv bara in text i sökfältet för att uppdatera listan med matchande användare.

* **Visa endast användare som kan logga in:** Välj det här alternativet om du bara vill visa användare som är aktiva (inte har inaktiverats).

#### Filtrera listan <i class="ph ph-funnel" aria-hidden="true"></i>

Du kan filtrera listan över användare efter kolumnrubrikerna.

> [!NOTE]
> Högerklicka på en kolumn om du vill lägga till ytterligare kolumner att filtrera på.

1. Gå till fliken **Medarbetare**.
1. Högerklicka på en kolumnrubrik eller klicka på <i class="ph ph-gear" aria-label="Gear"></i> längst upp till höger i listan.
1. Välj **Aktivera filter**.
1. Klicka på **OK**. Filterknappar läggs till i varje kolumnrubrik.
1. Klicka på <i class="ph ph-funnel" aria-label="Filter icon"></i> i den kolumn du vill filtrera.
1. Markera relevanta värden i listan. Använd sökfunktionen om listan är lång.
1. Klicka på **Filter**.
1. Upprepa steg 5–7 för att filtrera fler kolumner.

#### Gruppera listan

Du kan gruppera användarlistan efter roll, användarplan, primärgrupp och liknande. Dessutom kan du gruppera på flera nivåer.

> [!NOTE]
> Högerklicka på en kolumn om du vill lägga till ytterligare kolumner att gruppera efter (se även [Anpassa översikter][14]).

1. Gå till fliken **Medarbetare**.
1. Högerklicka på en kolumnrubrik eller klicka på <i class="ph ph-gear" aria-label="Gear"></i> längst upp till höger i listan.
1. Välj **Aktivera gruppering**.
1. Klicka på **OK**.
1. Klicka på kolumnrubriken för det värde som du vill gruppera och dra det till området ovanför kolumnerna ("Dra en kolumnrubrik och ..."). Listan grupperas nu efter det värdet.
1. Om du vill gruppera efter ytterligare värden klickar du på och drar en annan kolumnrubrik till samma område.
1. Klicka och dra gruppvärdena om du vill ändra ordningen på grupperingsnivåerna.
1. Klicka på ett gruppvärde om du vill ändra sorteringsordningen.

> [!NOTE]
> Om du navigerar till en annan flik återställs grupperingen.

#### Användarinformation

På höger sida av fönstret finns detaljerad information om den användare som är markerad i listan över medarbetare.

Fullständigt namn, e-postadress och ägarföretag visas högst upp. Längst ned i det här avsnittet kan du aktivera/inaktivera användaren i SuperOffice med knappen **Kan logga in**. Klicka på knappen **Uppgift** för att komma åt funktioner som **Flytta användare** och för att skicka välkomstmeddelanden och e-postmeddelanden för återställning av lösenord.

I användaröversikten finns olika flikar:

* **Detaljer** – huvudöversikt med användarinformation som **Användar-ID**, **Roll**, **Användarplan**, **Primärgrupp** och **Service-kategorier**.
* **Licenser** – extra licensinformation som **Konfidentiella aktiviteter** som användaren kan använda för att ange **synlig för** för händelser, dokument och urval.
* **Mer** – fliken visar om det finns extrafält för en person.

### <a id="other-users"></a>Andra användare (lokalt)

På fliken **Andra användare** i fönstret Användare kan du redigera inloggningsrättigheter för och lägga till anonyma användare och systemanvändare.

### <a id="our-companies"></a>Våra företag

Syftet med företagslistan på fliken **Våra företag** är att specificera följande:

* Vem som kan definieras som användare av SuperOffice CRM. Innan en person kan registreras som SuperOffice CRM-användare måste hen ha registrerats på ett företag som finns med i listrutan **Företag** i fönstret Användare. Enligt samma princip måste ett företag finnas med i företagslistan på fliken **Våra företag** i fönstret Användare för att visas i listrutan **Företag**.

* Vilka företag som kan definieras som ägare av en satellit.

#### Kolumner i företagslistan

| Kolumn | Beskrivning |
|---|---|
| Företagsnamn | Företagets namn. |
| Avdelning | Namnet på avdelningen i företaget. |
| Ort | Var företaget ligger. |
| Medarbetare | Hur många medarbetare som har skapats för företaget. |
| Aktiv satellit | Huruvida företaget är registrerat som en aktiv satellit . |

### Användarlicenser

På fliken **Användarlicenser** i fönstret Användare får du en översikt över hur många användarlicenser som är i bruk och vilka användare som använder de olika licenserna.

* Klicka på en licens i listan **Användarlicenser** för att visa en lista över användare som just nu använder licensen i fråga.

* Håll muspekaren över ett licensnamn för att visa detaljerad information om licensen.

### Användargrupper

På fliken **Användargrupper** i fönstret Användare får du en översikt över användare och användargrupper. Klicka på ett gruppnamn i listan **Tillgängliga grupper** för att visa en lista över användare som tillhör gruppen.

## Relaterat innehåll

* [Hantera dina roller][6]
* [Lägg till en ny användare][2]
* [Skapa en användargrupp][3]
* [Ändra användarplaner för aktiva användare][17]

<!-- Referenced links -->
[2]: add-associate.md
[3]: user-groups.md
[4]: onsite/other-users.md#rights
[6]: role/index.md
[7]: role/functional-rights.md
[14]: ../adjusting-views.md
[15]: ../preferences/index.md
[16]: ../license/activate.md
[17]: ../license/change-user-plan.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/access-right-system.png
[img2]: ../../../media/loc/en/admin/user-access-level.png
[img3]: ../../../media/loc/en/admin/admin-users-overview.png
[img5]: ../../../media/loc/en/admin/groups.png
[img6]: ../../../media/loc/en/admin/lists-grouping.png
[img7]: ../../../media/loc/en/admin/follow-up-type.png
[img8]: ../../../media/loc/en/admin/sales-group.png
